using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_reissue : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        Response.Cache.SetExpires(new DateTime(1900, 1, 1, 0, 0, 0, 0));
        Response.Expires = 0;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (IsPostBack)
        {
            //檢查必填欄位
            if (Request.Form["email"] == null || Request.Form["email"].ToString() == "")
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='member_reissue.aspx';</script>");
                Response.End();
            }

            check_input new_word = new check_input();
            //資料驗證
            string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
            string email = new_word.doCheck_Input(Request.Form["email"].ToString(), 100);
            string ip = "";
            string WebSiteUrl1 = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "register_success.aspx";
            string WebSiteUrl2 = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "member_edit_success.aspx";
            string status = "";

            //判所client端是否有設定代理伺服器
            if (Request.ServerVariables["HTTP_VIA"] == null)
            {
                ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            else
            {
                ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            }

            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            int res = wow.Wow_MemberReissue(out status, CareerNo, email, ip, WebSiteUrl1, WebSiteUrl2);
            switch (res)
            {
                case 0:
                    Response.Write("<script language=javascript>alert('確認信補發成功');location.href='member_reissue.aspx';</script>");
                    Response.End();
                    break;
                case 1:
                    Response.Write("<script language=javascript>alert('您輸入的帳號為無效之會員帳號，請確認，謝謝');location.href='member_reissue.aspx';</script>");
                    Response.End();
                    break;
                case 2:
                    Response.Write("<script language=javascript>alert('您的帳號之前已經啟動過了，將不再做補發的動作');location.href='member_reissue.aspx';</script>");
                    Response.End();
                    break;
                case 3:
                    Response.Write("<script language=javascript>alert('信件送出失敗!!請洽系統管理員');location.href='member_reissue.aspx';</script>");
                    Response.End();
                    break;
            }

        }
    }
}