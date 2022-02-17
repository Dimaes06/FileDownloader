using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class Form1 : Form
    {

        URIParser URIParser = new URIParser();
        public Form1()
        {
            InitializeComponent();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {

            downloadButton.Enabled = false;

            Downloader downloader = new Downloader(URITextBox.Text, downloadingProgressBar, fileSizeLabel);

            var fileSize = await downloader.GetFileSizeAsync();

             
            if (fileSize == null)
            {
                fileSizeLabel.Text = "N/A";
            }
            else if (fileSize > 999999999)
            {
                fileSizeLabel.Text = Math.Round((Double)fileSize / (1024 * 1024 * 1024), 2).ToString() + " Gbytes";
            }
            else if (fileSize > 999999)
            {
                fileSizeLabel.Text = Math.Round((Double)fileSize / (1024 * 1024), 2).ToString() + " Mbytes";
            }
            else if (fileSize > 999)
            {
                fileSizeLabel.Text = Math.Round((Double)fileSize / 1024, 2).ToString() + " Kbytes";
            }
            else if (fileSize <= 999)
            {
                fileSizeLabel.Text = Math.Round((Double)fileSize / (1)).ToString() + " bytes";
            }

            downloader.DownloadAsync(URITextBox.Text, URIParser.GetFileName(URITextBox.Text, presentersTextBox.Text));

            URITextBox.Text = String.Empty;
            presentersTextBox.Text = String.Empty;

        }

        private void URITextBox_TextChanged(object sender, EventArgs e)
        {
            fileNameLabel.Text = URIParser.GetFileName(URITextBox.Text, presentersTextBox.Text);
            if (String.IsNullOrEmpty(fileNameLabel.Text) || fileNameLabel.Text == "N/A" || fileNameLabel.Text == "Invalid URI")
            {
                downloadButton.Enabled = false;
                return;
            }
            downloadButton.Enabled = true;
        }

        private void presentersTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(URITextBox.Text))
            {
                fileNameLabel.Text = URIParser.GetFileName(URITextBox.Text, presentersTextBox.Text);
            }
        }
    }
}
