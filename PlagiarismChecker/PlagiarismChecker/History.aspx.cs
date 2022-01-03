using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlagiarismChecker.App_Code;

namespace PlagiarismChecker
{
    public partial class History : System.Web.UI.Page
    {
        List<string> document1 = new List<string>();
        List<string> document2 = new List<string>();
        List<float> percentage = new List<float>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            List<SimilarityReading> similarityReadings = AppController.GetSimilarityReadings();

            foreach(SimilarityReading reading in similarityReadings)
            {
                document1.Add(reading.doc1Name);
                document2.Add(reading.doc2Name);
                percentage.Add(reading.similarity);
            }

            ListView1.DataSource = document1;
            ListView2.DataSource = document2;
            ListView3.DataSource = percentage;
        }
    }
}