using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileDownloader
{
    public static class ExcelInteraction
    {
        private static String _excelFileName;
        //private static string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=1;\"";

        private static List<string> GetSheetsName(DataTable schemaDataTable)
        {
            var sheets = new List<string>();
            foreach (var dataRow in schemaDataTable.AsEnumerable())
            {
                sheets.Add(dataRow.ItemArray[2].ToString());
            }
            return sheets;
        }


        public static async Task<List<URIItem>> GetURIList()
        {

            List<URIItem> URIList = new List<URIItem>();

            var connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=1;\"";

            string excelQuery = "SELECT * FROM [URI$]";

            using (System.Data.OleDb.OleDbConnection excelConnection = new OleDbConnection(connectionString))
            {
                await excelConnection.OpenAsync();
                DataTable dtShema = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                //List<string> sheetNames = ExcelInteraction.GetSheetsName(dtShema);

                //if (!sheetNames.Contains("URI$"))
                //{
                //    MessageBox.Show("Выбранный файл не содержит лист \"URI\"\ncо списком URI для скачивания!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                OleDbCommand excelCommand = new OleDbCommand(excelQuery, excelConnection);
                OleDbDataAdapter excelDataAdapter = new OleDbDataAdapter(excelCommand);

                DataTable sheetURI = new DataTable();
                excelDataAdapter.Fill(sheetURI);

                var URIDataReader = sheetURI.CreateDataReader();

                if (URIDataReader.HasRows)
                {
                    while (await URIDataReader.ReadAsync())
                    {
                        object[] items = new object[URIDataReader.FieldCount];
                        URIDataReader.GetValues(items);

                        URIList.Add(new URIItem()
                        {
                            Uri = Convert.ToString(items[0]),
                            BadUri = Convert.ToString(items[1]),
                            Downloaded = Convert.ToString(items[2]),
                            FileName = Convert.ToString(items[3]),
                            FileSha = Convert.ToString(items[4]),
                            Presenters = Convert.ToString(items[5])

                        });


                        //if (!UriIsValid(URI).Result)
                        //{
                        //    MessageBox.Show($"{items[0]}\nis invalid URI!", "Invalid URI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //    BadURIList.Add(URI);
                        //}
                    }
                }
            }

            return URIList;
        }

        public static async Task LoadListFromExcelAsync(OpenFileDialog openFileDialog, Label selectedExcelFileName)
        {
            List<URIItem> URIList = new List<URIItem>();
            List<String> BadURIList = new List<String>();


            string connectionString;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _excelFileName = openFileDialog.FileName;
            }
            else
            {
                return;
            }

            switch (Path.GetExtension(_excelFileName))
            {
                case ".xlsx":
                case ".xls":
                    connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=1;\"";
                    //connectionString = $"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={_excelFileName}; Extended Properties=\"Excel 8.0; HDR=YES; IMEX=1\"";
                    break;
                default:
                    MessageBox.Show("Выберите файл Excel!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
            }

            string excelQuery = "SELECT * FROM [URI$]";

            using (System.Data.OleDb.OleDbConnection excelConnection = new OleDbConnection(connectionString))
            {
                await excelConnection.OpenAsync();
                DataTable dtShema = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                List<string> sheetNames = ExcelInteraction.GetSheetsName(dtShema);

                if (!sheetNames.Contains("URI$"))
                {
                    MessageBox.Show("Выбранный файл не содержит лист \"URI\"\ncо списком URI для скачивания!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                OleDbCommand excelCommand = new OleDbCommand(excelQuery, excelConnection);
                OleDbDataAdapter excelDataAdapter = new OleDbDataAdapter(excelCommand);

                DataTable sheetURI = new DataTable();
                excelDataAdapter.Fill(sheetURI);

                var URIDataReader = sheetURI.CreateDataReader();

                if (URIDataReader.HasRows)
                {
                    while (await URIDataReader.ReadAsync())
                    {
                        object[] items = new object[URIDataReader.FieldCount];
                        URIDataReader.GetValues(items);

                        String URI = Convert.ToString(items[0]);

                        URIList.Add(new URIItem()
                        {
                            Uri = Convert.ToString(items[0]),
                            BadUri = "",
                            Downloaded = "",
                            FileName = "",
                            FileSha = "",
                            Presenters = ""

                        });


                        if (!UriIsValid(URI).Result)
                        {
                            //MessageBox.Show($"{items[0]}\nis invalid URI!", "Invalid URI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            BadURIList.Add(URI);
                        }
                    }
                }
            }

            if (BadURIList.Count > 0)
            {
                SetBadURIFlag(BadURIList);
            }

            if (URIList.Count > 0)
            {
                SetFileNames(URIList);
            }

            selectedExcelFileName.Text = Path.GetFileName(_excelFileName);


            //return URIList;
        }

        private static async Task<Boolean> UriIsValid(String URI)
        {
            if (await URIParser.GetFileName(URI) == null)
            {
                return false;
            }

            return true;
        }

        private static void SetBadURIFlag(List<String> badURIList)
        {

            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=3;\"";

            using (OleDbConnection excelConnection = new OleDbConnection(connectionString))
            {
                excelConnection.Open();

                foreach (var URI in badURIList)
                {
                    string excelQuery = $"UPDATE [URI$] SET BadURI = '1' WHERE URI = '{URI}'";
                    OleDbCommand excelCommand = new OleDbCommand(excelQuery, excelConnection);
                    excelCommand.ExecuteNonQuery();
                }
            }
        }

        private static async void SetFileNames(List<URIItem> URIList)
        {

            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=3;\"";

            using (OleDbConnection excelConnection = new OleDbConnection(connectionString))
            {
                excelConnection.Open();

                foreach (var URI in URIList)
                {
                    string excelQuery = $"UPDATE [URI$] SET FileName = '{await URIParser.GetFileName(URI.Uri)}' WHERE URI = '{URI.Uri}'";
                    OleDbCommand excelCommand = new OleDbCommand(excelQuery, excelConnection);
                    excelCommand.ExecuteNonQuery();
                }
            }
        }

        public static void SetDownloadedFlag(String URI)
        {

            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=3;\"";

            using (OleDbConnection excelConnection = new OleDbConnection(connectionString))
            {
                excelConnection.Open();
                string excelQuery = $"UPDATE [URI$] SET Downloaded = '1' WHERE URI = '{URI}'";
                OleDbCommand excelCommand = new OleDbCommand(excelQuery, excelConnection);
                excelCommand.ExecuteNonQuery();
            }
        }

        public static async Task<String> GetTitleForFileName(String title)
        {

            string connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0; Data Source={_excelFileName}; Extended Properties=\"Excel 12.0 Xml; HDR=YES; IMEX=3;\"";

            string result = "";

            string excelQuery = $"SELECT * FROM [Titles$] WHERE FileName = '{title}'";

            using (System.Data.OleDb.OleDbConnection excelConnection = new OleDbConnection(connectionString))
            {
                await excelConnection.OpenAsync();
                DataTable dtShema = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                List<string> sheetNames = ExcelInteraction.GetSheetsName(dtShema);

                OleDbCommand excelCommand = new OleDbCommand(excelQuery, excelConnection);
                OleDbDataAdapter excelDataAdapter = new OleDbDataAdapter(excelCommand);

                DataTable sheetTitles = new DataTable();
                excelDataAdapter.Fill(sheetTitles);

                var TitlesDataReader = sheetTitles.CreateDataReader();

                if (TitlesDataReader.HasRows)
                {
                    while (await TitlesDataReader.ReadAsync())
                    {
                        object[] items = new object[TitlesDataReader.FieldCount];
                        TitlesDataReader.GetValues(items);
                        result = Convert.ToString(items[0]);
                    }
                }
            }

            return result;
        }

    }
}
