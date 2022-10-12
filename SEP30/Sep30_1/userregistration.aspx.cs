using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep30
{
    public partial class userregistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            Userdata.SetActiveView(PersonalDetails);

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "PersonalDetails")
            {
                Userdata.SetActiveView(PersonalDetails);

            }
            else if (DropDownList1.SelectedValue == "EducationDetails")
            {
                Userdata.SetActiveView(EducationDetails);
            }
            else
            {
                Userdata.SetActiveView(BankDetails);
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty
                (FileUpload1.FileName))
            {
                if (FileUpload1.HasFiles)
                {

                    foreach (HttpPostedFile item in FileUpload1.PostedFiles)
                    {
                        string fname = item.FileName;
                        FileInfo finfo = new FileInfo(fname);
                        string ext = finfo.Extension;

                        if (ext == ".pdf")
                        {
                            string s = item.FileName;
                          

                            FileUpload1.SaveAs(Server.MapPath("UploadedFiles") + "\\" + s);
                        }
                        else
                        {
                            Response.Write("U can only upload pdf");
                        }

                    }
                }

            }
            else
            {
                Response.Write("Unable to save the file becoz no file uploaded");
            }

        }
    }
}
