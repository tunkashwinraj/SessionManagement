using SessionManagement_1262774.Utils;
using System;

namespace SessionManagement_1262774
{
    public partial class Status : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblUsername.Text = SessionFacade.UserName ?? "No user logged in";
                lblAccountNum.Text = SessionFacade.Account?.ToString() ?? "No account";
                lblLastLogin.Text = SessionFacade.LastLogin?.ToString("g") ?? "No login time";
            }
            catch (Exception ex)
            {
                lblStatus.Text = $"Error: {ex.Message}";
            }
        }
    }
}
