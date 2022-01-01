using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlagiarismChecker.App_Code
{
    public class Checker
    {
        public static List<Dictionary<string, int>> Documents { get; set; } = new List<Dictionary<string, int>>();
        public static double MesaureSimilarity(Dictionary<string, int> doc1, Dictionary<string, int> doc2)
        {
            double similarity = 0;
            double magDoc1 = getDocumentMagnitude(doc1);
            double magDoc2 = getDocumentMagnitude(doc2);
            foreach (KeyValuePair<string, int> valueDoc1 in doc1)
            {
                if (doc2.ContainsKey(valueDoc1.Key) == true)
                    similarity += calcTermIDF(valueDoc1.Key) * (valueDoc1.Value * doc2[valueDoc1.Key]);
            }

            return similarity / (magDoc2 * magDoc1);
        }
        private static double getDocumentMagnitude(Dictionary<string, int> doc)
        {
            double magnitude = 0;
            foreach (KeyValuePair<string, int> valueDoc in doc)
            {
                magnitude += calcTermIDF(valueDoc.Key)*(valueDoc.Value * valueDoc.Value);
            }
            return Math.Sqrt(magnitude);
        }
        private static double calcTermIDF(string term)
        {
            double foundinDocs = 0;

            if (Documents.Count == 0)
                return 1;

            foreach (Dictionary<string, int> doc in Documents)
            {
                if (doc.ContainsKey(term) == true)
                    foundinDocs++;
            }
            if (foundinDocs == 0)
                return 1;

            double idf = Math.Log10((double)Documents.Count / foundinDocs);
            if (idf == 0)
            {
                return 0.01f;
            }
            return idf;
        }
    }
}