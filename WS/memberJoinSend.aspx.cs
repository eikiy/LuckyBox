using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberJoinSend : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (!IsPostBack)
        {
            if (Session[CareerNo + "_name_s"] == null || Session[CareerNo + "_email_s"] == null)
            {
                Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('memberJoin.aspx');</script>");
                Response.End();
            }
        }

        lblName.Text = Session[CareerNo + "_name_s"].ToString();
        labEmail.Text = Session[CareerNo + "_email_s"].ToString();

        Session[CareerNo + "_name_s"] = null;
        Session[CareerNo + "_email_s"] = null;
    }
}
