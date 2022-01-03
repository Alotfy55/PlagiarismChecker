using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlagiarismChecker.App_Code
{
    public class Checker
    {
        public static List<Dictionary<string, int>> Documents { get; set; } = new List<Dictionary<string, int>>();
        public static float MesaureSimilarity(Dictionary<string, int> doc1, Dictionary<string, int> doc2)
        {
            float similarity = 0;
            float magDoc1 = getDocumentMagnitude(doc1);
            float magDoc2 = getDocumentMagnitude(doc2);
            foreach (KeyValuePair<string, int> valueDoc1 in doc1)
            {
                if (doc2.ContainsKey(valueDoc1.Key) == true)
                    similarity += calcTermIDF(valueDoc1.Key) * (valueDoc1.Value * doc2[valueDoc1.Key]);
            }

            return similarity / (magDoc2 * magDoc1);
        }
        private static float getDocumentMagnitude(Dictionary<string, int> doc)
        {
            float magnitude = 0;
            foreach (KeyValuePair<string, int> valueDoc in doc)
            {
                magnitude += calcTermIDF(valueDoc.Key)*(valueDoc.Value * valueDoc.Value);
            }
            return (float)Math.Sqrt((double)magnitude);
        }
        private static float calcTermIDF(string term)
        {
            int foundinDocs = 0;

            if (Documents.Count == 0)
                return 1;

            foreach (Dictionary<string, int> doc in Documents)
            {
                if (doc.ContainsKey(term) == true)
                    foundinDocs++;
            }
            if (foundinDocs == 0)
                return 1;

            float idf = (float)Math.Log10((double)Documents.Count / foundinDocs);
            if (idf == 0)
            {
                return 0.01f;
            }
            return idf;
        }
    }
}