using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class e_member_coupon_index : System.Web.UI.Page
{

    Crm2WebMember.Crm2WebMember crm = new Crm2WebMember.Crm2WebMember();
    Website2API.Website2API wow = new Website2API.Website2API();
    
    check_input new_word = new check_input();

    protected void Page_Load(object sender, EventArgs e)
    {
        Website2API.Website2API wow = new Website2API.Website2API();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string name = "";
        string uid = "";
        string email = "";

        if (Request.QueryString["sid"] == null || Request.QueryString["sid"] == "")
        {
            //無SID則不做更新動作
        }
        else
        {            
            string sid = new_word.doCheck_Input(Request.QueryString["sid"].ToString(), 100);
            int res = wow.Wow_MemberSuccess(CareerNo, sid, out name, out uid);

            if (res != 0)
            {
                Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗!!\");location.replace('index.html');</script>");
                Response.End();
            }
        }
    }



    //[網路會員]登入========================================================================
    protected void LinkButton1_Click(object sender, EventArgs e)
    {

        #region 登入檢查驗證:資料完整性
        if (email.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [會員Email]');</script>");
            return;
        }

        if (pwd.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [會員密碼]');</script>");
            return;
        }
        #endregion


        #region 檢查驗證碼----------------------------------------------------------------------------------------
        if (Session["Valid"] != null && txtCode.Value.ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            return;
        }
        #endregion

        string sError = "";
        DataSet DS_member = new DataSet();
        Member.Member m = new Member.Member();
        sError = m.ActionMemberLoginCheck(email.Text.Trim(), pwd.Text.Trim(), Public.strP_Ename, "474", out DS_member);



        if (sError != "")//登入失敗----------------------------------------------------------------------
        {
            Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
            return;
        }
        else//登入成功-----------------------------------------------------------------------------------
        {
            string sErrorCrm = "";
            DataSet DS_Members2App = new DataSet();
            blAction _blAction = new blAction();

            //[版本一:判別新白金中有沒有他網路會員登記的手機號碼]
            //DS_memberCrm = _blAction.Sel_WM_Customer_CellPhone(DS_member.Tables[0].Rows[0]["手機"].ToString().Trim(), out sErrorCrm);
            //if (DS_memberCrm.Tables[0].Rows.Count > 0)


            //[版本二:判斷他在的瘋美食會員身分是不是已經是2(菁英)了]
            DS_Members2App = _blAction.Sel_Members2App_email(Public.strP_ShopNo, DS_member.Tables[0].Rows[0]["email"].ToString().Trim(), out sErrorCrm);
            if (DS_Members2App.Tables[0].Rows.Count > 0)
            {
                #region 已經在新白金中了，直接前往優惠卷
                Session["uid"] = DS_member.Tables[0].Rows[0]["uid"].ToString().Trim();
                Session["UName"] = DS_member.Tables[0].Rows[0]["姓名"].ToString().Trim();
                Session["email"] = DS_member.Tables[0].Rows[0]["email"].ToString().Trim();
                Session["password"] = DS_member.Tables[0].Rows[0]["password"].ToString().Trim();
                Session["Birth"] = DS_member.Tables[0].Rows[0]["生日"].ToString().Trim();
                Session["Marry"] = DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString().Trim();
                Response.Redirect("coupon.aspx");
                #endregion                
            }
            else
            {
                #region 不再新白金中，前往修改資料
                Session["DS_type"] = "websiteMember";
                Session["DS_member"] = DS_member;
                Response.Redirect("../application/inforation.aspx");
                #endregion
            }
        }
    }



}
