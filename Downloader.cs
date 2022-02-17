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
        ProgressBar _progressBar;
        Label _fileSizeLabel;


        public Downloader(string URI, ProgressBar progressBar, Label fileSizeLabel)
        {
            if (URI is null)
            {
                throw new ArgumentNullException(nameof(URI));
            }

            _URI = URI;
            _progressBar = progressBar;
            _fileSizeLabel = fileSizeLabel;
        }

        public void DownloadAsync(String URI, String fileName)
        {

            if (CheckForFileExist(fileName))
            {
                MessageBox.Show($"File \"{fileName}\" already exist!");
                _fileSizeLabel.Text = "0 bytes";
                return;
            }

            using (var client = new WebClient())
            {
                client.DownloadProgressChanged += Client_DownloadProgressChanged;
                client.DownloadFileCompleted += Client_DownloadFileCompleted;
                client.DownloadFileAsync(new Uri(URI), AppContext.BaseDirectory + fileName);
            }

        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
            _progressBar.Value = 0;
            _fileSizeLabel.Text = "0 bytes";

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
