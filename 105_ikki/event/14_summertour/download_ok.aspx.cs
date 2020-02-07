using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_14_summertour_download_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["201404_376PrintName"] == null)
            {
                Response.Redirect("download.aspx");
                return;
            }

            labCName.Text = Session["201404_376PrintName"].ToString().Trim();

            Session.Remove("201404_376PrintName");
        }
    }
}
