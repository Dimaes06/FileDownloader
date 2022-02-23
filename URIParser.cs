using System;
using System.Threading.Tasks;

namespace FileDownloader
{
    public static class URIParser
    {
        public static async Task<string> GetFileName(String URI)
        {
            if (String.IsNullOrEmpty(URI))
            {
                return null;
            }

            string fileName;

            try
            {
                string[] fileNameParts = URI.Substring(28).Split(new char[] { '-' });

                var fileDate = fileNameParts[2] + "_" + fileNameParts[1] + "_" + fileNameParts[0].Substring(2);

                var fileTime = fileNameParts[4].Substring(0, 2) + "_" + fileNameParts[4].Substring(2);

                var programName = await ExcelInteraction.GetTitleForFileName(fileNameParts[3]);

                if (string.IsNullOrEmpty(programName))
                {
                    return "";
                }

                fileName = await ExcelInteraction.GetTitleForFileName(fileNameParts[3]) + " " + fileDate + " " + fileTime + ".mp3";

                if (fileNameParts.Length != 6 || fileNameParts[2].Length != 2 || fileNameParts[1].Length != 2 || fileNameParts[0].Length != 4 || fileNameParts[4].Length != 4)
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return fileName;
        }
    }
}
