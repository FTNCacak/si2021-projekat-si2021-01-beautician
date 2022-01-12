using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BeuticianWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
           

            if (Session["User"] != null)
            {
                var login = this.FindControl("linklogin");
                login.Visible = false;

                var register = this.FindControl("linkregister");
                register.Visible = false;
            }

            else {
            
                var cart = this.FindControl("linkcart");
                cart.Visible = false;

                var logout = this.FindControl("linklogout");
                logout.Visible = false;
            }

        }

        protected void LinkLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Response.Redirect("~/Default");
        }
    }
}