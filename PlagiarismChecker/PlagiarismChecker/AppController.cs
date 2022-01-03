using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web.UI.WebControls;
using System.Text;

namespace PlagiarismChecker.App_Code
{
    public class AppController
    {
        public static string USERNAME = "";

        public static string Save_Directory = "D:\\SaveData\\";
        // read saved data into program 
        public static Dictionary<string,int> getDocumentDictionary(string filename)
        {
            char[] document = DocEditor.ReturnPDF(Save_Directory + filename);
            File.Delete(Save_Directory + filename);
            document = DocEditor.RemovePunct(document);
            Dictionary<string, int> documentValues = DocEditor.GetWordCount(document);
            return documentValues;
        }

        public static void SaveFile(FileUpload fileUpload)
        {
            StringBuilder sb = new StringBuilder();

            if (fileUpload.HasFile)
            {
                try
                {
                    sb.AppendFormat(" Uploading file: {0}", fileUpload.FileName);
                    //saving the file
                    fileUpload.SaveAs(App_Code.AppController.Save_Directory + fileUpload.FileName);

                    //Showing the file information
                    sb.AppendFormat("<br/> Save As: {0}", fileUpload.PostedFile.FileName);
                    sb.AppendFormat("<br/> File type: {0}", fileUpload.PostedFile.ContentType);
                    sb.AppendFormat("<br/> File length: {0}", fileUpload.PostedFile.ContentLength);
                    sb.AppendFormat("<br/> File name: {0}", fileUpload.PostedFile.FileName);
                }
                catch (Exception ex)
                {
                    sb.Append("<br/> Error <br/>");
                    sb.AppendFormat("Unable to save file <br/> {0}", ex.Message);
                }
            }
            else
            {

            }
        }

        public static void storeInDatabase(Dictionary<string, int> documentData)
        {
            DatabaseController.InsertDocument(documentData);
        }

        public static List<SimilarityReading> GetSimilarityReadings()
        {
            return DatabaseController.GetUserHistory(USERNAME);
        }

        public static void StoreHistoryReading(SimilarityReading reading)
        {
            DatabaseController.insertHistoryData(reading, USERNAME);
        }
    }
}