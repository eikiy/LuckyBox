using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class member_forget : System.Web.UI.Page
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

        check_input new_word = new check_input();
        wowapi.Website2API wow = new wowapi.Website2API();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string email = new_word.doCheck_Input(txtEmail.Text.Trim(), 100);

        //檢查必填欄位--------------------------------------------------------------------------------------
        if (txtEmail.Text.Trim() == "" || code.Text.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('欄位未填寫完整!!');</script>");
            return;
        }
        //檢查email是否存在---------------------------------------------------------------------------------
        DataTable dt = new DataTable("MemberData");
        dt = wow.Wow_GetMemberData(CareerNo, txtEmail.Text.Trim());
        if (dt == null)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('此帳號非該品牌會員喔!!');</Script>");
            return;
        }
        //檢查驗證碼----------------------------------------------------------------------------------------
        if (Session["Valid"] != null && code.Text.ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            return;
        }

        //正式區修改===============================================================================================
        int res = wow.Wow_MemberForgetPwdNoPWD(CareerNo, email, 0);
        switch (res)
        {
            case 0:
                Response.Write("<script language=javascript>alert('您將在幾分鐘後收到一封電子郵件，\\n請啟動信中連結，重新設定密碼。');location.href='member_forget.aspx';</script>");
                Response.End();
                break;
            case 1:
                Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='member_forget.aspx';</script>");
                Response.End();
                break;
            case 2:
                Response.Write("<script language=javascript>alert('該品牌查無此 Email 帳號');location.href='member_forget.aspx';</script>");
                Response.End();
                break;
            case 3:
                Response.Write("<script language=javascript>alert('尚未啟動帳號');location.href='member_forget.aspx';</script>");
                Response.End();
                break;
        }

    }
}