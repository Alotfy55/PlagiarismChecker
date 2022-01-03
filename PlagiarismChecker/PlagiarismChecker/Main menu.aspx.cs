using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlagiarismChecker
{
    public partial class Main_menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Comparetwofiles");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ComapreWithDatabase");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("History");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Guide");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile");
        }
    }
}