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

public partial class event_13_design_mail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["323_Name1"] != null)
            lblName.Text = Session["323_Name1"].ToString();


        if (Session["323_Name2"] != null)
            lblName2.Text = Session["323_Name2"].ToString();

        if (Session["323_SerialNo"] != null)
            lblSerialNo.Text = Session["323_SerialNo"].ToString();

        ////Session.Remove("323_Name1");
        ////Session.Remove("323_Name2");
        ////Session.Remove("323_SerialNo");
         
    }
}
