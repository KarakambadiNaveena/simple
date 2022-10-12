using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep30
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("Welcome to Login Page");
            }
            else
            {
                if (txtid.Text == "Nani" && txtpwd.Text == "Nani@123")
                {
                  //  Response.Write("You have logged in successfully");
                    Response.Redirect("~/Welcome.aspx");
                   // Response.Redirect("http://www.google.com");
                }
                else
                {
                    Response.Write("Invalid userid/password... Pls check..");
                }

            }
        }


        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void txtpwd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
