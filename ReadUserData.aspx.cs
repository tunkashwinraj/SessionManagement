using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionManagement_1262774
{
    public partial class ReadUserData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Read the session data and display it
            lblUserData.Text = ((int)Session["Userdata"]).ToString();
        }
    }
}