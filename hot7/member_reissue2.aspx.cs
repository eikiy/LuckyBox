﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_reissue2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (Session[CareerNo + "_email_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_join.aspx');</script>");
            Response.End();
        }
        Session[CareerNo + "_email_s"] = null;
    }
}