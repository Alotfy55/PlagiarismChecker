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
                    //saving the file
                    fileUpload.SaveAs(App_Code.AppController.Save_Directory + fileUpload.FileName);

                }
                catch (Exception ex)
                {
                    
                }
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