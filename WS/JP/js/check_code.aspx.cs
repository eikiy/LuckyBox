using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class check_code : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //檢查email重覆
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        
        if (Session["Valid"] == null)
        {
            Response.Write("no");
            Response.End();
        }

        if (Session["Valid"] != null && Request.Form["code"].ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            Response.Write("no");
            Response.End();
        }
        else
        {
            Response.Write("yes");
            Response.End();
        }
    }
}