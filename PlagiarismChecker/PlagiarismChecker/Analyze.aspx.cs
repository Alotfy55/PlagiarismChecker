using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PlagiarismChecker.App_Code;
using System.Data;

namespace PlagiarismChecker
{
    public partial class Guide : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> words = AppController.getDocumentDictionary(FileUpload1.FileName);
            List<String> word = new List<string>();
            List<int> count = new List<int>();

            foreach (KeyValuePair<string, int> entry in words)
            {
                word.Add(entry.Key);
                count.Add(entry.Value);
            }
            GridView1.DataSource = word;
            GridView1.DataBind();
            GridView2.DataSource = count;
            GridView2.DataBind();

        }
    }
}