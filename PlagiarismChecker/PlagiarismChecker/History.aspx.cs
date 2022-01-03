using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlagiarismChecker
{
    public partial class History : System.Web.UI.Page
    {
        List<string> document1 = new List<string>();
        List<string> document2 = new List<string>();
        List<double> percentage = new List<double>();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListView1.DataSource = document1;
            ListView2.DataSource = document2;
            ListView3.DataSource = percentage;
        }
    }
}