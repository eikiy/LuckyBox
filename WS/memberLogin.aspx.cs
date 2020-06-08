using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (email.Text == "")
        {
            Response.Write("<script language=javascript>alert('請輸入 [e - mail]!!');location.href='memberLogin.aspx';</script>");
            Response.End();
        }

        if (pwd.Text == "")
        {
            Response.Write("<script language=javascript>alert('請輸入 [密碼]');location.href='memberLogin.aspx';</script>");
            Response.End();
        }

        check_input new_word = new check_input();
        //資料驗證
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string str_email = new_word.doCheck_Input(email.Text.ToString(), 100);
        string str_pwd = new_word.doCheck_Input(pwd.Text.ToString(), 10);

        Website2API.Website2API wow = new Website2API.Website2API();
        int res = wow.Wow_MemberLoginCheck(CareerNo, str_email, str_pwd);
        switch (res)
        {
            case 0:
                Session[CareerNo + "_email_s"] = str_email;
                Response.Write("<script language=javascript>location.href='memberEdit.aspx';</script>");
                Response.End();
                break;
            case 1:
                Response.Write("<script language=javascript>alert('系統錯誤');location.href='memberEdit.aspx';</script>");
                Response.End();
                break;
            case 2:
                Response.Write("<script language=javascript>alert('該會員密碼不符');location.href='memberLogin.aspx';</script>");
                Response.End();
                break;
            case 3:
                Response.Write("<script language=javascript>alert('無該會員資料');location.href='memberLogin.aspx';</script>");
                Response.End();
                break;
            case 4:
                Response.Write("<script language=javascript>alert('尚未啟動帳號');location.href='memberLogin.aspx';</script>");
                Response.End();
                break;
        }
    }
}
