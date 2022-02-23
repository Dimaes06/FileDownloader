
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
            this.URILabel = new System.Windows.Forms.Label();
            this.downloadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.numOfDownloadedFilesLabel = new System.Windows.Forms.Label();
            this.URIListGroupBox = new System.Windows.Forms.GroupBox();
            this.numberOfLoadedURIlabel = new System.Windows.Forms.Label();
            this.excelFileNameLabel = new System.Windows.Forms.Label();
            this.listOfURIRichTextBox = new System.Windows.Forms.RichTextBox();
            this.totalURINumberLabel = new System.Windows.Forms.Label();
            this.openExcelFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.numOfBadURILabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numOfMissingProgramsLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.URIListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Enabled = false;
            this.downloadButton.Location = new System.Drawing.Point(620, 258);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(111, 23);
            this.downloadButton.TabIndex = 0;
            this.downloadButton.Text = "Download all files";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // URILabel
            // 
            this.URILabel.AutoSize = true;
            this.URILabel.Location = new System.Drawing.Point(23, 170);
            this.URILabel.Name = "URILabel";
            this.URILabel.Size = new System.Drawing.Size(29, 13);
            this.URILabel.TabIndex = 2;
            this.URILabel.Text = "URI:";
            // 
            // downloadingProgressBar
            // 
            this.downloadingProgressBar.Location = new System.Drawing.Point(26, 195);
            this.downloadingProgressBar.Name = "downloadingProgressBar";
            this.downloadingProgressBar.Size = new System.Drawing.Size(705, 23);
            this.downloadingProgressBar.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox2);
            this.groupBox1.Controls.Add(this.fileSizeLabel);
            this.groupBox1.Controls.Add(this.numOfDownloadedFilesLabel);
            this.groupBox1.Controls.Add(this.URILabel);
            this.groupBox1.Controls.Add(this.downloadingProgressBar);
            this.groupBox1.Controls.Add(this.downloadButton);
            this.groupBox1.Location = new System.Drawing.Point(24, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 299);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File Name";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(26, 26);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(705, 129);
            this.richTextBox2.TabIndex = 13;
            this.richTextBox2.Text = "";
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(23, 233);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(41, 13);
            this.fileSizeLabel.TabIndex = 9;
            this.fileSizeLabel.Text = "0 bytes";
            // 
            // numOfDownloadedFilesLabel
            // 
            this.numOfDownloadedFilesLabel.AutoSize = true;
            this.numOfDownloadedFilesLabel.Location = new System.Drawing.Point(615, 233);
            this.numOfDownloadedFilesLabel.Name = "numOfDownloadedFilesLabel";
            this.numOfDownloadedFilesLabel.Size = new System.Drawing.Size(116, 13);
            this.numOfDownloadedFilesLabel.TabIndex = 2;
            this.numOfDownloadedFilesLabel.Text = "0 of 0 files downloaded";
            // 
            // URIListGroupBox
            // 
            this.URIListGroupBox.Controls.Add(this.numOfMissingProgramsLabel);
            this.URIListGroupBox.Controls.Add(this.label2);
            this.URIListGroupBox.Controls.Add(this.numOfBadURILabel);
            this.URIListGroupBox.Controls.Add(this.label1);
            this.URIListGroupBox.Controls.Add(this.numberOfLoadedURIlabel);
            this.URIListGroupBox.Controls.Add(this.excelFileNameLabel);
            this.URIListGroupBox.Controls.Add(this.listOfURIRichTextBox);
            this.URIListGroupBox.Controls.Add(this.totalURINumberLabel);
            this.URIListGroupBox.Controls.Add(this.openExcelFileButton);
            this.URIListGroupBox.Location = new System.Drawing.Point(24, 12);
            this.URIListGroupBox.Name = "URIListGroupBox";
            this.URIListGroupBox.Size = new System.Drawing.Size(751, 235);
            this.URIListGroupBox.TabIndex = 10;
            this.URIListGroupBox.TabStop = false;
            this.URIListGroupBox.Text = "URI List";
            // 
            // numberOfLoadedURIlabel
            // 
            this.numberOfLoadedURIlabel.AutoSize = true;
            this.numberOfLoadedURIlabel.Cursor = System.Windows.Forms.Cursors.No;
            this.numberOfLoadedURIlabel.Location = new System.Drawing.Point(215, 169);
            this.numberOfLoadedURIlabel.Name = "numberOfLoadedURIlabel";
            this.numberOfLoadedURIlabel.Size = new System.Drawing.Size(13, 13);
            this.numberOfLoadedURIlabel.TabIndex = 5;
            this.numberOfLoadedURIlabel.Text = "0";
            // 
            // excelFileNameLabel
            // 
            this.excelFileNameLabel.AutoSize = true;
            this.excelFileNameLabel.Location = new System.Drawing.Point(215, 201);
            this.excelFileNameLabel.Name = "excelFileNameLabel";
            this.excelFileNameLabel.Size = new System.Drawing.Size(104, 13);
            this.excelFileNameLabel.TabIndex = 4;
            this.excelFileNameLabel.Text = "Excel file name: N/A";
            // 
            // listOfURIRichTextBox
            // 
            this.listOfURIRichTextBox.Location = new System.Drawing.Point(26, 19);
            this.listOfURIRichTextBox.Name = "listOfURIRichTextBox";
            this.listOfURIRichTextBox.Size = new System.Drawing.Size(705, 135);
            this.listOfURIRichTextBox.TabIndex = 3;
            this.listOfURIRichTextBox.Text = "";
            // 
            // totalURINumberLabel
            // 
            this.totalURINumberLabel.AutoSize = true;
            this.totalURINumberLabel.Location = new System.Drawing.Point(23, 169);
            this.totalURINumberLabel.Name = "totalURINumberLabel";
            this.totalURINumberLabel.Size = new System.Drawing.Size(174, 13);
            this.totalURINumberLabel.TabIndex = 1;
            this.totalURINumberLabel.Text = "Total number of URI\'s to download:";
            // 
            // openExcelFileButton
            // 
            this.openExcelFileButton.Location = new System.Drawing.Point(26, 196);
            this.openExcelFileButton.Name = "openExcelFileButton";
            this.openExcelFileButton.Size = new System.Drawing.Size(164, 23);
            this.openExcelFileButton.TabIndex = 0;
            this.openExcelFileButton.Text = "Open Excel File...";
            this.openExcelFileButton.UseVisualStyleBackColor = true;
            this.openExcelFileButton.Click += new System.EventHandler(this.openExcelFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bad URI:";
            // 
            // numOfBadURILabel
            // 
            this.numOfBadURILabel.AutoSize = true;
            this.numOfBadURILabel.Location = new System.Drawing.Point(401, 168);
            this.numOfBadURILabel.Name = "numOfBadURILabel";
            this.numOfBadURILabel.Size = new System.Drawing.Size(13, 13);
            this.numOfBadURILabel.TabIndex = 7;
            this.numOfBadURILabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Missing programs:";
            // 
            // numOfMissingProgramsLabel
            // 
            this.numOfMissingProgramsLabel.AutoSize = true;
            this.numOfMissingProgramsLabel.Location = new System.Drawing.Point(639, 168);
            this.numOfMissingProgramsLabel.Name = "numOfMissingProgramsLabel";
            this.numOfMissingProgramsLabel.Size = new System.Drawing.Size(13, 13);
            this.numOfMissingProgramsLabel.TabIndex = 9;
            this.numOfMissingProgramsLabel.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.URIListGroupBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.URIListGroupBox.ResumeLayout(false);
            this.URIListGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label URILabel;
        private System.Windows.Forms.ProgressBar downloadingProgressBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label numOfDownloadedFilesLabel;
        private System.Windows.Forms.GroupBox URIListGroupBox;
        private System.Windows.Forms.RichTextBox listOfURIRichTextBox;
        private System.Windows.Forms.Label totalURINumberLabel;
        private System.Windows.Forms.Button openExcelFileButton;
        private System.Windows.Forms.Label excelFileNameLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label numberOfLoadedURIlabel;
        private System.Windows.Forms.Label numOfBadURILabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label numOfMissingProgramsLabel;
        private System.Windows.Forms.Label label2;
    }
}

