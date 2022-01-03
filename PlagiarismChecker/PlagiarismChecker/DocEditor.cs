using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PlagiarismChecker.App_Code
{
    public class DocEditor
    {
        public static char[] ReturnPDF(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text.ToCharArray();
        }



        public static char[] RemovePunct(char[] document)
        {
            string[] words = { ",", "\\", "/", ".", ";", ":", "\"", "\'", "?" ,"-" , "*"
            ,"(" , ")" , "_" , "\n" , "|"};
            Dictionary<string, string> punct = new Dictionary<string, string>();
            for (int i = 0; i < words.Length; i++)
            {
                punct.Add(words[i], " ");
            }

            for (int i = 0; i < document.Length; i++)
            {
                /*
                if (punct.ContainsKey(document[i].ToString()) == true)
                {
                    document[i] = ' ';
                }*/
                if ((document[i] < 58 && document[i] > 47) || (document[i] < 91 && document[i] > 64) || (document[i] < 123 && document[i] > 96))
                {
                    continue;
                }

                document[i] = ' ';
            }
            return document;
        }

        public static void WriteDocument(string document)
        {
            for (int i = 0; i < document.Length; i++)
            {
                Console.Write(document[i]);
            }
        }

        public static Dictionary<string, int> GetWordCount(char[] document)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            string stringDocument = new string(document);
            string[] words = stringDocument.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] != "")
                {
                    if (wordCount.ContainsKey(words[i]) == false)
                    {
                        wordCount.Add(words[i], 0);
                    }
                    wordCount[words[i]]++;
                }
            }
            return wordCount;
        }


        private static void storeInDatabase(Dictionary<string, int> documentData)
        {
            DatabaseController.InsertDocument(documentData);
        }
    }
}