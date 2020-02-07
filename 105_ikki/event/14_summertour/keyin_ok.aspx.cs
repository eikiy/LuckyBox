using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_14_summertour_keyin_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) 
        {
            if (!IsPostBack)
            {
                if (Session["2014_PrintCName"] == null)
                    Response.Redirect("login.aspx");


                labCName.Text = Session["2014_PrintCName"].ToString().Trim();
                Session.Remove("2014_PrintCName");
            }
          
        }
    }
}
