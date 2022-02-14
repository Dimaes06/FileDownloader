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
             
            Downloader downloader = new Downloader(URITextBox.Text, "test.mp3");

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

            await downloader.DownloadAsync();


        }

        private void URITextBox_TextChanged(object sender, EventArgs e)
        {
            fileNameLabel.Text = URIParser.GetFileName(URITextBox.Text, presentersTextBox.Text);
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
