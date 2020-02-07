using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class check_user : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();

        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string email = HttpUtility.HtmlEncode(Request.Form["id"].ToString());
        
        if (email.Length > 100)
        {
            email = email.Substring(0, 100);
        }

        if (Session[CareerNo + "_email_s"] != null && Session[CareerNo + "_email_s"].ToString() != "")
        {
            if (Session[CareerNo + "_email_s"].ToString() == email)
            {
                Response.Write("no");
            }
            else
            {
                DataSet ds = wow.Wow_CheckIsWeb_Members(CareerNo, email);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Response.Write("yes");
                    Response.End();
                }
                else
                {
                    Response.Write("no");
                    Response.End();
                }
            }
        }
        else
        {

            DataSet ds = wow.Wow_CheckIsWeb_Members(CareerNo, email);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Response.Write("yes");
                Response.End();
            }
            else
            {
                Response.Write("no");
                Response.End();
            }
        }

    }
}