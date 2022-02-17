using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDownloader
{
    class URIParser
    {
        public static string GetFileName(String URI, String presenters)
        {
            if (String.IsNullOrEmpty(URI))
            {
                return "N/A";
            }

            string fileName;

            try
            {
                string[] fileNameParts = URI.Substring(28).Split(new char[] { '-' });                          

                var fileDate = fileNameParts[2] + "_" + fileNameParts[1] + "_" + fileNameParts[0].Substring(2);

                var fileTime = fileNameParts[4].Substring(0, 2) + "_" + fileNameParts[4].Substring(2);

                fileName = fileNameParts[3] + " " + fileDate + " " + fileTime + " " + presenters + ".mp3";

                if (fileNameParts.Length != 6 || fileNameParts[2].Length != 2 || fileNameParts[1].Length != 2 || fileNameParts[0].Length != 4 || fileNameParts[4].Length != 4)
                {
                    return "Invalid URI";
                }
            }
            catch (Exception e)
            {
                return "Invalid URI";
            }

            return fileName;
        }
    }
}
