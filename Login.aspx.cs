using SessionManagement_1262774.Utils;
using System;

namespace SessionManagement_1262774
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "bill" && txtPassword.Text == "bill100")
            {
                lblStatus.Text = $"Welcome {txtUsername.Text}..";

                // Set session variables using SessionFacade
                SessionFacade.LastLogin = DateTime.Now;
                SessionFacade.UserName = txtUsername.Text;
                SessionFacade.Account = 1234; // Simulated account number from DB
            }
            else
            {
                lblStatus.Text = "Invalid username or password.";
            }
        }
    }
}
