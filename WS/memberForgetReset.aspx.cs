using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberForgetReset : System.Web.UI.Page
{
    Website2API.Website2API wow = new Website2API.Website2API();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            try
            {
                if (Request["fid"] == null)
                    Response.Redirect("index.html");

                //檢查連結是否為正常有效的
                string sReturnMsg = "";
                int iError = 0;
                string sUid = "";
                //iError -->0:例外錯誤1:正常 2:超過時間 3:無效的key 或已失效的key
                sUid = wow.Wow_MemberSelWang_MembersEditPWD(Request["fid"].ToString(), out iError, out sReturnMsg);
                if (iError != 1)
                {
                    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sReturnMsg + "');</script>");
                    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.html';</script>");
                    return;
                }
                hidUid.Value = sUid;
                hidfFid.Value = Request["fid"].ToString().Trim();
            }
            catch (Exception ex)
            {
                Response.Redirect("index.html");
            }

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //檢查有沒有填寫
        if (pwd.Text.Trim() == null || chk_pwd.Text.Trim() == null)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('欄位未填寫完整!!');</script>");
            return;
        }
        //檢查長度
        if (pwd.Text.Trim().Length > 8 || chk_pwd.Text.Trim().Length > 8)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('欄位長度超過限制!!');</script>");
            return;
        }
        //檢查有無相同
        if (pwd.Text.Trim() != chk_pwd.Text.Trim())
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您填寫的資料似乎有錯誤喔～再檢查一下吧！');</script>");
            return;
        }
        //正式區
        string sReturnMsg = "";
        int iError = 0;
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        iError = wow.Wow_MemberEditPWD(CareerNo, hidUid.Value.Trim(), pwd.Text.Trim(), hidfFid.Value.Trim(), out sReturnMsg);
        //Error值 0: 修改成功 1: 修改失敗

        if (iError == 1)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sReturnMsg + "');</script>");
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.html';</script>");
            return;
        }

        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的新密碼已更換成功，謝謝~');</script>");
        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.html';</script>");
    
    }
}
