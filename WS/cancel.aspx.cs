using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class cancel : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入帳號。');</script>");
            return;
        }
        if (txtPwd.Text.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入密碼。');</script>");
            return;
        }
        //檢查驗証碼
        if (Session["Valid"] == null)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            return;
        }

        if (Session["Valid"] != null && code.Text.ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            return;
        }


        Website2API.Website2API wow = new Website2API.Website2API();
        int res = wow.Wow_MemberLoginCheck(Public.strP_ShopNo, txtEmail.Text.Trim(), txtPwd.Text.Trim());
        switch (res)
        {

            case 1:
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('系統錯誤');</script>");
                return;
                break;
            case 2:
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('該會員密碼不符');</script>");
                return;
                break;
            case 3:
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('無該會員資料');</script>");
                return;
                break;
            case 4:
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('尚未啟動帳號');</script>");
                return;
                break;
        }

        string sError = "";



        // DataSet DS = new DataSet();
        sError = wow.Wow_MemberCancelAllEdm(Public.strP_ShopNo, "", txtEmail.Text.Trim());
        if (sError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sError + "');</script>");
            return;
        }

        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('已取消訂閱~系統處理約需3-7個工作天，期間如收到電子報通知敬請見諒! 謝謝！');</script>");
    
    }
}
