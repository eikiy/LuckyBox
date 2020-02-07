using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register_success : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string name = "";
        string uid = "";

        if (Request.QueryString["sid"] == null || Request.QueryString["sid"] == "")
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗!!\");location.replace('register.aspx');</script>");
            Response.End();
        }

        check_input new_word = new check_input();
        string sid = new_word.doCheck_Input(Request.QueryString["sid"].ToString(), 100);

        int res = wow.Wow_MemberSuccess(out name, out uid, CareerNo, sid);
        if (res == 0)
        {
            Session[CareerNo +"_name_s"] = name;
            Session[CareerNo +"_uid_s"] = uid;
            
            Response.Write("<script language=javascript>alert(\"啟動會員帳號成功!!\");location.replace('coupon.aspx');</script>");
            Response.End();
        }
        else
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗，請至已修改的email信箱啟動!!\");location.replace('index.htm');</script>");
            Response.End();
        }
    }
}