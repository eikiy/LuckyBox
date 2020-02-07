using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class event_13_design_check_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["322_QueryCName"] == null || Session["322_QueryCoupon1"] == null || Session["322_QueryCoupon2"] == null)
            Response.Redirect("check.aspx");


        lblCName.Text = Session["322_QueryCName"].ToString().Trim();
        lblCoupon1.Text = Session["322_QueryCoupon1"].ToString().Trim();
        lblCoupon2.Text = Session["322_QueryCoupon2"].ToString().Trim();

        Session.Remove("322_QueryCName");
        Session.Remove("322_QueryCoupon1");
        Session.Remove("322_QueryCoupon2");

    }
}
