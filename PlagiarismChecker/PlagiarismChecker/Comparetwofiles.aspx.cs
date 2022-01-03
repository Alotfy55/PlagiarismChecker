using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlagiarismChecker.App_Code;



namespace PlagiarismChecker
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AppController.SaveFile(FileUpload1);
            AppController.SaveFile(FileUpload2);
            Dictionary<string, int> doc1 = AppController.getDocumentDictionary(FileUpload1.FileName);
            Dictionary<string, int> doc2 = AppController.getDocumentDictionary(FileUpload2.FileName);

            float similarity = Checker.MesaureSimilarity(doc1, doc2);
            similarity *= 100;
            similarity = int.Parse(similarity.ToString().Split('.')[0]);
            TextBox1.Text = similarity.ToString() + '%';
            TextBox1.Enabled = false;
            // save in database
            if (CheckBox1.Checked)
            {
                AppController.storeInDatabase(doc1);
                if (similarity < 99) 
                AppController.storeInDatabase(doc2);
            }
            SimilarityReading reading = new SimilarityReading(FileUpload1.FileName, FileUpload2.FileName, similarity);
            AppController.StoreHistoryReading(reading);
            if (similarity > 70) 
            {
                Image1.Visible = true;
            }
        }
    }
}