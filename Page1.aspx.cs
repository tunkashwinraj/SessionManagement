using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement_1262774
{
    public partial class Page1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Store data in the session
            Session["Userdata"] = 25;
            Response.Write("User data set to " + ((int)Session["Userdata"]).ToString());
        }
    }
}