using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PlagiarismChecker
{
    public partial class Registration_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //el esm uniqe
            bool isUnique = true;
            if (!DatabaseController.checkUsernameAvailability(TextBox1.Text))
                isUnique = false;
            if (isUnique)
            {
                //set el id el gded
                DatabaseController.insertData(TextBox1.Text, TextBox2.Text);
                App_Code.AppController.USERNAME = TextBox1.Text;
                Response.Redirect("Main menu.aspx");
            }
            else
            {
                TextBox1.BorderColor = System.Drawing.Color.Red;
            }
        }
    }
}