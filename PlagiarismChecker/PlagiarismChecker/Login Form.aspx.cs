using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using PlagiarismChecker.App_Code;

namespace PlagiarismChecker
{
    public partial class Login_Form : System.Web.UI.Page
    {
        private static int counter =0;
        private const int COUNTHRESH = 5;
        protected void Page_Load(object sender, EventArgs e)
        {
            Image1.Visible = false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DatabaseController.checkPassword(TextBox1.Text, TextBox2.Text))
            {
                AppController.USERNAME = TextBox1.Text;
                Response.Redirect("Main menu.aspx");
            }
            else if(counter == COUNTHRESH)
            {
                Image1.Visible = true;
            }
            else
            {
                counter++;
            }
        }
    }
}
