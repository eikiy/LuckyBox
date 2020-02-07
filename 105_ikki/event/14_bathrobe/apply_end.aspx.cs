using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_14_bathrobe_apply_end : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["372YESNo2"] == null)
            {
                Response.Redirect("apply.aspx");
                return;
            }
            Session.Remove("372YESNo2");
        }

    }
}
