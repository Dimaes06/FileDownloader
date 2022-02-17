
namespace FileDownloader
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
            this.downloadButton = new System.Windows.Forms.Button();
            this.URITextBox = new System.Windows.Forms.TextBox();
            this.URILabel = new System.Windows.Forms.Label();
            this.downloadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.programNameLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.presentersTextBox = new System.Windows.Forms.TextBox();
            this.presenterTitleLabel = new System.Windows.Forms.Label();
            this.fileNameTitleLabel = new System.Windows.Forms.Label();
            this.programNameTitleLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(669, 284);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(86, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // URITextBox
            // 
            this.URITextBox.Location = new System.Drawing.Point(60, 37);
            this.URITextBox.Name = "URITextBox";
            this.URITextBox.Size = new System.Drawing.Size(695, 20);
            this.URITextBox.TabIndex = 1;
            this.URITextBox.TextChanged += new System.EventHandler(this.URITextBox_TextChanged);
            // 
            // URILabel
            // 
            this.URILabel.AutoSize = true;
            this.URILabel.Location = new System.Drawing.Point(28, 40);
            this.URILabel.Name = "URILabel";
            this.URILabel.Size = new System.Drawing.Size(26, 13);
            this.URILabel.TabIndex = 2;
            this.URILabel.Text = "URI";
            // 
            // downloadingProgressBar
            // 
            this.downloadingProgressBar.Location = new System.Drawing.Point(60, 73);
            this.downloadingProgressBar.Name = "downloadingProgressBar";
            this.downloadingProgressBar.Size = new System.Drawing.Size(695, 23);
            this.downloadingProgressBar.TabIndex = 3;
            // 
            // programNameLabel
            // 
            this.programNameLabel.AutoSize = true;
            this.programNameLabel.Location = new System.Drawing.Point(119, 37);
            this.programNameLabel.Name = "programNameLabel";
            this.programNameLabel.Size = new System.Drawing.Size(27, 13);
            this.programNameLabel.TabIndex = 4;
            this.programNameLabel.Text = "N/A";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(119, 107);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(27, 13);
            this.fileNameLabel.TabIndex = 7;
            this.fileNameLabel.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.presentersTextBox);
            this.groupBox1.Controls.Add(this.presenterTitleLabel);
            this.groupBox1.Controls.Add(this.fileNameTitleLabel);
            this.groupBox1.Controls.Add(this.programNameTitleLabel);
            this.groupBox1.Controls.Add(this.programNameLabel);
            this.groupBox1.Controls.Add(this.fileNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(60, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // presentersTextBox
            // 
            this.presentersTextBox.Location = new System.Drawing.Point(122, 69);
            this.presentersTextBox.Name = "presentersTextBox";
            this.presentersTextBox.Size = new System.Drawing.Size(558, 20);
            this.presentersTextBox.TabIndex = 13;
            this.presentersTextBox.TextChanged += new System.EventHandler(this.presentersTextBox_TextChanged);
            // 
            // presenterTitleLabel
            // 
            this.presenterTitleLabel.AutoSize = true;
            this.presenterTitleLabel.Location = new System.Drawing.Point(23, 70);
            this.presenterTitleLabel.Name = "presenterTitleLabel";
            this.presenterTitleLabel.Size = new System.Drawing.Size(60, 13);
            this.presenterTitleLabel.TabIndex = 12;
            this.presenterTitleLabel.Text = "Presenters:";
            // 
            // fileNameTitleLabel
            // 
            this.fileNameTitleLabel.AutoSize = true;
            this.fileNameTitleLabel.Location = new System.Drawing.Point(23, 107);
            this.fileNameTitleLabel.Name = "fileNameTitleLabel";
            this.fileNameTitleLabel.Size = new System.Drawing.Size(55, 13);
            this.fileNameTitleLabel.TabIndex = 9;
            this.fileNameTitleLabel.Text = "File name:";
            // 
            // programNameTitleLabel
            // 
            this.programNameTitleLabel.AutoSize = true;
            this.programNameTitleLabel.Location = new System.Drawing.Point(23, 36);
            this.programNameTitleLabel.Name = "programNameTitleLabel";
            this.programNameTitleLabel.Size = new System.Drawing.Size(80, 13);
            this.programNameTitleLabel.TabIndex = 8;
            this.programNameTitleLabel.Text = "Program Name:";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(391, 106);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(41, 13);
            this.fileSizeLabel.TabIndex = 9;
            this.fileSizeLabel.Text = "0 bytes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 336);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.downloadingProgressBar);
            this.Controls.Add(this.URILabel);
            this.Controls.Add(this.URITextBox);
            this.Controls.Add(this.downloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox URITextBox;
        private System.Windows.Forms.Label URILabel;
        private System.Windows.Forms.ProgressBar downloadingProgressBar;
        private System.Windows.Forms.Label programNameLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label fileNameTitleLabel;
        private System.Windows.Forms.Label programNameTitleLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox presentersTextBox;
        private System.Windows.Forms.Label presenterTitleLabel;
        private System.Windows.Forms.Label fileSizeLabel;
    }
}

