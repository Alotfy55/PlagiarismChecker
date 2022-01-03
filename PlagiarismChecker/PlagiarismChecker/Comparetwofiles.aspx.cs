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
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            AppController.SaveFile(FileUpload1);
            AppController.SaveFile(FileUpload2);
            Dictionary<string, int> doc1 = AppController.getDocumentDictionary(FileUpload1.FileName);
            Dictionary<string, int> doc2 = AppController.getDocumentDictionary(FileUpload2.FileName);

            double similarity = Checker.MesaureSimilarity(doc1, doc2);
            similarity *= 100;
            similarity = int.Parse(similarity.ToString().Split('.')[0]);
            TextBox1.Text = similarity.ToString() + '%';
            TextBox1.Enabled = false;
            // save in database
            DatabaseController.InsertDocument(doc1);
            DatabaseController.InsertDocument(doc2);

        }
    }
}