using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class edit_success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string name = "";
        string uid = "";
        
        if (Request.QueryString["sid"] == null || Request.QueryString["sid"] == "")
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗!!\");location.replace('email_resend.aspx');</script>");
            Response.End();
        }

        check_input new_word = new check_input();
        string sid = new_word.doCheck_Input(Request.QueryString["sid"].ToString(), 100);

        int res = wow.Wow_MemberSuccess(out name, out uid, CareerNo, sid);
        if (res == 0)
        {
            LiteName.Text = name;
        }
        else
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗!!\");location.replace('email_resend.aspx');</script>");
            Response.End();
        }
    }
}