using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_14_fall_coupon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["201404_392PrintName"] == null)
                Response.Redirect("login.aspx");

            //labCName.Text = "這是給 " + Session["201404_371PrintName"].ToString().Trim() + " 貴賓的~";
            Session.Remove("201404_392PrintName");
        }
    }
}
