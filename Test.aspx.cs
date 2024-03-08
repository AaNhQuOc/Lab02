using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab02
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Control login = Page.LoadControl("~/Controls/CtrlLogin.ascx");
            Panel1.Controls.Add(login);
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Control login = Page.LoadControl("~/Controls/CtrlRegister.ascx");
            Panel1.Controls.Add(login);
        }
    }
}