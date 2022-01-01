using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlagiarismChecker.App_Code;

namespace PlagiarismChecker
{
    public partial class ComapreWithDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            AppController.SaveFile(FileUpload1);
            Dictionary<string, int> doc = AppController.getDocumentDictionary(FileUpload1.FileName);

            Checker.Documents = DatabaseController.getData();

            double similarity = 0;
            foreach (Dictionary<string, int> document in Checker.Documents)
            {
                similarity = Math.Max(Checker.MesaureSimilarity(doc, document), similarity);
            }
            similarity *= 100;
            similarity = int.Parse(similarity.ToString().Split('.')[0]);
            TextBox1.Text = similarity.ToString() + '%';
            TextBox1.Enabled = false;
            // save in database
            if (similarity < 99)
            {
                DatabaseController.InsertDocument(doc);
            }
            Checker.Documents = DatabaseController.getData();
        }
    }
}