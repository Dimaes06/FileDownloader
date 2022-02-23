using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    class Downloader
    {
        readonly HttpClient _client = new HttpClient();
        string _URI;
        private string _fileName;
        ProgressBar _progressBar;
        Label _fileSizeLabel;
        private RichTextBox _richTextBox;


        public Downloader(ProgressBar progressBar, Label fileSizeLabel, RichTextBox richTextBox)
        {
            _progressBar = progressBar;
            _fileSizeLabel = fileSizeLabel;
            _richTextBox = richTextBox;

        }

        public async Task DownloadAsync(String URI, String fileName)
        {

            string _fullFileName = @".\MP3\" + fileName;

            _fileName = fileName;

            if (CheckForFileExist(_fileName))
            {
                MessageBox.Show($"File \"{fileName}\" already exist!");
                _fileSizeLabel.Text = "0 bytes";
                return;
            }

            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;

                await client.DownloadFileTaskAsync(new Uri(URI), AppContext.BaseDirectory + _fullFileName);
            }

        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //MessageBox.Show("Download Completed");
            _richTextBox.Text += "Downloaded: " + _fileName;
            _richTextBox.Text += "\n";
            _progressBar.Value = 100;
            //_fileSizeLabel.Text = "0 bytes";

        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _progressBar.Value = e.ProgressPercentage;
        }

        public async Task<long?> GetFileSizeAsync()
        {

            var result = await _client.SendAsync(new HttpRequestMessage(HttpMethod.Head, _URI));
            return result.Content.Headers.ContentLength;
        }

        private Boolean CheckForFileExist(String fileName)
        {
            var path = Application.StartupPath + "\\" + fileName;
            return File.Exists(path);
        }


    }
}
