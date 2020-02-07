using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class member_login_birthday : System.Web.UI.Page
{
    wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
    #region Page_Load
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    #endregion

    #region 登入
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
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

        string sError = "";
        DataSet DS = new DataSet();
        sError = wow.Wow_MemberLoginCheckBirthday(out DS, aaclsPubSet.strP_ShopNo, txtEmail.Text.Trim(), txtPwd.Text.Trim());
        //  sError = m.MemberLoginCheckBirthday(txtEmail.Text.Trim(), txtPwd.Text.Trim(), aaclsPubSet.strP_Ename, out DS);
        if (sError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sError + "');</script>");
            return;
        }
       
        Session["105_uid"] = DS.Tables[0].Rows[0]["uid"].ToString().Trim();
        Session["105_BirthdayMemberName"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();
        this.Response.Redirect("member_birthday_print.aspx");
    }
    #endregion
    
}