using PMSCLS.Model;
using System;
using System.Web.UI;

namespace PMS.UserControl
{
    public partial class TopBanner : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionL ssl = new PMSCLS.ILogin().GetCookieVal();
            if (ssl.UserId == null || ssl.UserId == "-1")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "A", "<script>LoginCalldialog('Your Session has expired');</script>", false);
                return;
            }
            if (!Page.IsPostBack)
            {
                lblUserName.InnerText = "Welcome : " + ssl.UserName.ToString();
            }
        }
    }
}