using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Oct_3
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session.SessionID.ToString();

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text;
            Session["uname"] = username;
            Response.Redirect("~/logintable.aspx");

            if (TextBox1.Text== "nani@gmail.com" && TextBox2.Text == "123")
            {
                Response.Write("You have logged in successfully");
            }
            else
            {
                Response.Write("Invalid credentials...pls check again");
            }
           


        }
    }
}