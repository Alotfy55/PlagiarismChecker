using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlagiarismChecker
{
    public partial class Login_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (DatabaseController.checkPassword(TextBox1.Text, TextBox2.Text))
            {
                PlagiarismChecker.App_Code.AppController.USERNAME = TextBox1.Text;
                Response.Redirect("Main menu.aspx");
            }
        }
    }
}