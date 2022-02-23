using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileDownloader
{
    public partial class Form1 : Form
    {

        IEnumerable<URIItem> URIList = new List<URIItem>();


        public Form1()
        {
            InitializeComponent();
        }

        private async void downloadButton_Click(object sender, EventArgs e)
        {

            downloadButton.Enabled = false;

            Downloader downloader = new Downloader(downloadingProgressBar, fileSizeLabel, richTextBox2);

            int count = 0;
            string totalFilesToDownload = (from uriItem in URIList where (uriItem.BadUri != "1" && uriItem.FileName != "") select uriItem).Count().ToString();

            foreach (var URIItem in URIList)
            {
                if ((URIItem.BadUri == "1") || (URIItem.FileName == ""))
                {
                    continue;
                }

                await downloader.DownloadAsync(URIItem.Uri, URIItem.FileName);
                count++;
                numOfDownloadedFilesLabel.Text = $"{count} of {totalFilesToDownload} files downloaded";
            }

            downloadingProgressBar.Value = 0;

            MessageBox.Show("All files downloaded!", "All done!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Downloader downloader = new Downloader(URITextBox.Text, downloadingProgressBar, fileSizeLabel);

            //var fileSize = await downloader.GetFileSizeAsync();


            //if (fileSize == null)
            //{
            //    fileSizeLabel.Text = "N/A";
            //}
            //else if (fileSize > 999999999)
            //{
            //    fileSizeLabel.Text = Math.Round((Double)fileSize / (1024 * 1024 * 1024), 2).ToString() + " Gbytes";
            //}
            //else if (fileSize > 999999)
            //{
            //    fileSizeLabel.Text = Math.Round((Double)fileSize / (1024 * 1024), 2).ToString() + " Mbytes";
            //}
            //else if (fileSize > 999)
            //{
            //    fileSizeLabel.Text = Math.Round((Double)fileSize / 1024, 2).ToString() + " Kbytes";
            //}
            //else if (fileSize <= 999)
            //{
            //    fileSizeLabel.Text = Math.Round((Double)fileSize / (1)).ToString() + " bytes";
            //}

            //downloader.DownloadAsync(URITextBox.Text, URIParser.GetFileName(URITextBox.Text, presentersTextBox.Text));

            //URITextBox.Text = String.Empty;
            //presentersTextBox.Text = String.Empty;

        }

        private async void openExcelFileButton_Click(object sender, EventArgs e)
        {
            await ExcelInteraction.LoadListFromExcelAsync(openFileDialog1, excelFileNameLabel);

            URIList = await ExcelInteraction.GetURIList();


            if (URIList.Count() > 0)
            {

                numberOfLoadedURIlabel.Text = (from uriItem in URIList where (uriItem.BadUri != "1" && uriItem.FileName != "") select uriItem).Count().ToString();
                numOfBadURILabel.Text = (from uriItem in URIList where (uriItem.BadUri == "1") select uriItem).Count().ToString();
                numOfMissingProgramsLabel.Text = (from uriItem in URIList where (uriItem.FileName == "" && uriItem.BadUri != "1") select uriItem).Count().ToString();

                int count = 0;

                foreach (var URI in URIList)
                {
                    count++;
                    listOfURIRichTextBox.Text += count.ToString() + ": ";
                    listOfURIRichTextBox.Text += URI.Uri;
                    listOfURIRichTextBox.Text += "\n";
                }
            }

            downloadButton.Enabled = URIList.Count() > 0;

        }
    }
}
