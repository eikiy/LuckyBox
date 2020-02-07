using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (Session[CareerNo +"_name_s"] == null || Session[CareerNo +"_email_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('register.aspx');</script>");
            Response.End();
        }
       
        LiteName.Text = Session[CareerNo +"_name_s"].ToString();
        LiteEmail.Text = Session[CareerNo +"_email_s"].ToString();

        Session[CareerNo +"_name_s"] = null;
        Session[CareerNo +"_email_s"] = null;
    }
}