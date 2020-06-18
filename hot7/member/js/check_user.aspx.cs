using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



using System.Text.RegularExpressions;


public partial class check_user : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Website2API.Website2API wow = new Website2API.Website2API();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        string str_Email_Mobile = HttpUtility.HtmlEncode(Request.Form["id"].ToString());

        if (str_Email_Mobile != string.Empty && !Regex.IsMatch(str_Email_Mobile, "^[0-9]{4}[0-9]{6}$"))
        {
            #region 檢查郵件
            if (str_Email_Mobile.Length > 100)
            {
                str_Email_Mobile = str_Email_Mobile.Substring(0, 100);
            }

            if (Session[CareerNo + "_email_s"] != null && Session[CareerNo + "_email_s"].ToString() != "")
            {
                if (Session[CareerNo + "_email_s"].ToString() == str_Email_Mobile)
                {
                    Response.Write("no");
                }
                else
                {
                    DataSet ds = wow.Wow_CheckIsWeb_Members(CareerNo, str_Email_Mobile);
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

                DataSet ds = wow.Wow_CheckIsWeb_Members(CareerNo, str_Email_Mobile);
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
            #endregion

        }
        else
        {
            #region 檢查手機
            if (str_Email_Mobile.Length > 100)
            {
                str_Email_Mobile = str_Email_Mobile.Substring(0, 100);
            }

            if (Session[CareerNo + "_mobile_s"] != null && Session[CareerNo + "_mobile_s"].ToString() != "")
            {
                if (Session[CareerNo + "_mobile_s"].ToString() == str_Email_Mobile)
                {
                    Response.Write("no");
                }
                else
                {
                    DataSet ds = wow.Wow_CheckIsWeb_Members_MobilePhone(CareerNo, str_Email_Mobile);
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

                DataSet ds = wow.Wow_CheckIsWeb_Members_MobilePhone(CareerNo, str_Email_Mobile);
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
            #endregion
        }
    }

    
}