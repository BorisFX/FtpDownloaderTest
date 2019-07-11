using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace FtpDownloaderTest
{
    public partial class Form1 : Form
    {
        private Stopwatch _stopwatch;
        private WebClient _webClient;

        public Form1()
        {
            InitializeComponent();
            _stopwatch = new Stopwatch();
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                pathField.Text = folderBrowserDialog1.SelectedPath;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var fileName = string.Empty;
            var path = string.Empty;
            try
            {
                var url = new Uri(urlString.Text);
                fileName = Path.GetFileName(url.AbsolutePath);
                if (fileName == string.Empty) throw new Exception("Url not file");

                path = pathField.Text;
                if (path == string.Empty) throw new Exception("Path not select");

                if (!Directory.Exists(path)) throw new Exception("Path not exist");
                downLoadButton.Visible = false;
                DownloadFile(url, path + "\\" + fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DownloadFile(Uri url, string pathToSavedFile)
        {
            using (_webClient = new WebClient())
            {
                _webClient.DownloadProgressChanged += ProgressChanged;
                _webClient.DownloadFileCompleted += Completed;
                _stopwatch.Start();
                try
                {
                    _webClient.DownloadFileAsync(url, pathToSavedFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            var transferRate = e.BytesReceived / _stopwatch.Elapsed.TotalSeconds;
            tranferRate.Text = $"{transferRate / 1024d:0.00} kb/s";

            timeLeft.Text = $"{(e.TotalBytesToReceive - e.BytesReceived) / transferRate:0.00} sec";

            byteBox.Text =
                $"{e.BytesReceived / 1024d / 1024d:0.00} MB's / {e.TotalBytesToReceive / 1024d / 1024d:0.00} MB's";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            _stopwatch.Reset();
            downLoadButton.Visible = true;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.ToString());
                return;
            }

            if (e.Cancelled)
                MessageBox.Show("Canceled");
            else
                MessageBox.Show("Done!");
        }
    }
}