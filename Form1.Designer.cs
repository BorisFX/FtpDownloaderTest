namespace FtpDownloaderTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.urlString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pathField = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.byteBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tranferRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.TextBox();
            this.downLoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Url";
            // 
            // urlString
            // 
            this.urlString.Location = new System.Drawing.Point(108, 58);
            this.urlString.Name = "urlString";
            this.urlString.Size = new System.Drawing.Size(217, 22);
            this.urlString.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Save to...";
            // 
            // pathField
            // 
            this.pathField.Location = new System.Drawing.Point(448, 61);
            this.pathField.Name = "pathField";
            this.pathField.Size = new System.Drawing.Size(227, 22);
            this.pathField.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(681, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Select path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(108, 144);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(567, 23);
            this.progressBar.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Progress bar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Downloaded bytes:";
            // 
            // byteBox
            // 
            this.byteBox.Location = new System.Drawing.Point(257, 202);
            this.byteBox.Name = "byteBox";
            this.byteBox.ReadOnly = true;
            this.byteBox.Size = new System.Drawing.Size(124, 22);
            this.byteBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Transfer rate:";
            // 
            // tranferRate
            // 
            this.tranferRate.Location = new System.Drawing.Point(257, 239);
            this.tranferRate.Name = "tranferRate";
            this.tranferRate.ReadOnly = true;
            this.tranferRate.Size = new System.Drawing.Size(124, 22);
            this.tranferRate.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estimated time left:";
            // 
            // timeLeft
            // 
            this.timeLeft.Location = new System.Drawing.Point(257, 276);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.ReadOnly = true;
            this.timeLeft.Size = new System.Drawing.Size(124, 22);
            this.timeLeft.TabIndex = 12;
            // 
            // downLoadButton
            // 
            this.downLoadButton.Location = new System.Drawing.Point(607, 313);
            this.downLoadButton.Name = "downLoadButton";
            this.downLoadButton.Size = new System.Drawing.Size(177, 55);
            this.downLoadButton.TabIndex = 13;
            this.downLoadButton.Text = "Download";
            this.downLoadButton.UseVisualStyleBackColor = true;
            this.downLoadButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 380);
            this.Controls.Add(this.downLoadButton);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tranferRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.byteBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urlString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlString;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pathField;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox byteBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tranferRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox timeLeft;
        private System.Windows.Forms.Button downLoadButton;
    }
}

