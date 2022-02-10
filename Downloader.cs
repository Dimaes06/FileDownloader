using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloader
{
    class Downloader
    {
        readonly HttpClient _client = new HttpClient();
        string _URI;
        string _filePath;


        public Downloader(string URI, string filePath)
        {
            if (URI is null)
            {
                throw new ArgumentNullException(nameof(URI));
            }

            if (filePath is null)
            {
                throw new ArgumentNullException(nameof(filePath));
            }

            _URI = URI;
            _filePath = filePath;


        }

        public async Task DownloadAsync()
        {


            var stream = await _client.GetStreamAsync(_URI);
            using (var fileStream = File.Create(_filePath))
            {
                await stream.CopyToAsync(fileStream);
            }

        }

        public async Task<long?> GetFileSizeAsync()
        {

            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_URI);
            //request.Method = "HEAD";
            //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //{
            //    var fileLenght = response.ContentLength;                
            //    return fileLenght;
            //}

            var result = await _client.SendAsync(new HttpRequestMessage(HttpMethod.Head, _URI));
                return result.Content.Headers.ContentLength;


        }


    }
}
