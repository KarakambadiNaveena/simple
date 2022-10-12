using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sep30
{
    public partial class welcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txt1.Text = C1.SelectedDate.ToLongDateString();

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}