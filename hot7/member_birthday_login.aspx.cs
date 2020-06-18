using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class member_birthday_login : System.Web.UI.Page
{
    Website2API.Website2API wow = new Website2API.Website2API();
    Member.Member m = new Member.Member();

    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //[登入]紐==============================================================================================
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

        string sError = "";
        DataSet DS = new DataSet();
        sError = wow.Wow_MemberLoginCheckBirthday(CareerNo, txtEmail.Text.Trim(), txtPwd.Text.Trim(), out DS);//驗證
        //sError = m.MemberLoginCheckBirthday(txtEmail.Text.Trim(), txtPwd.Text.Trim(), "taoban", out DS);//驗證
        if (sError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sError + "');</script>");
            return;
        }
        Session["uid"] = DS.Tables[0].Rows[0]["uid"].ToString().Trim();
        Session["UName"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();
        Session["Birth"] = DS.Tables[0].Rows[0]["生日"].ToString().Trim();
        this.Response.Redirect("member_birthday.aspx");
    }

}
