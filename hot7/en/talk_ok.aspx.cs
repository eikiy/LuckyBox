using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class en_talk_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (Session[CareerNo + "_talk_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"error!\");location.replace('talk.aspx');</script>");
            Response.End();
        }

        Session[CareerNo + "_talk_s"] = null;
    }
}
