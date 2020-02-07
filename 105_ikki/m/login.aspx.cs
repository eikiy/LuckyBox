using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (IsPostBack)
        {
            //檢查來源
            if (Request.UrlReferrer.ToString() != System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "m/login.aspx")
            {
                Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='login.aspx';</script>");
                Response.End();
            }

            //檢查必填欄位
            if (Request.Form["email"] == null || Request.Form["pwd"] == null)
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='login.aspx';</script>");
                Response.End();
            }

            if (Request.Form["email"].ToString() == "" || Request.Form["pwd"].ToString() == "")
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='login.aspx';</script>");
                Response.End();
            }

            check_input new_word = new check_input();
            //資料驗證
            string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
            string email = new_word.doCheck_Input(Request.Form["email"].ToString(), 100);
            string pwd = new_word.doCheck_Input(Request.Form["pwd"].ToString(), 10);

            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            int res = wow.Wow_MemberLoginCheck(CareerNo, email, pwd);
            switch (res)
            {
                case 0:
                    Session[CareerNo + "_email_s"] = email;
                    Response.Write("<script language=javascript>location.href='edit.aspx';</script>");
                    Response.End();
                    break;
                case 1:
                    Response.Write("<script language=javascript>alert('系統錯誤');location.href='login.aspx';</script>");
                    Response.End();
                    break;
                case 2:
                    Response.Write("<script language=javascript>alert('該會員密碼不符');location.href='login.aspx';</script>");
                    Response.End();
                    break;
                case 3:
                    Response.Write("<script language=javascript>alert('無該會員資料');location.href='login.aspx';</script>");
                    Response.End();
                    break;
                case 4:
                    Response.Write("<script language=javascript>alert('尚未啟動帳號');location.href='login.aspx';</script>");
                    Response.End();
                    break;
            }

        }
    }
}