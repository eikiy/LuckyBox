using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class e_member_application_index : System.Web.UI.Page
{

    Crm2WebMember.Crm2WebMember crm = new Crm2WebMember.Crm2WebMember();
    Website2API.Website2API wow = new Website2API.Website2API();


    protected void Page_Load(object sender, EventArgs e)
    {

    }

    //[白金會員]登入========================================================================
    /* *********************
     * Crm_Phone
     * Crm_BarCode
     * Crm_txtCode
     * ********************/
    protected void Button1_Click1(object sender, EventArgs e)
    {
        #region 登入檢查驗證:資料完整性
        if (Crm_Phone.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [會員手機]');</script>");
            return;
        }
        else
        {
            try
            {
                Convert.ToInt32(Crm_Phone.Text);
            }
            catch (Exception ex)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('手機格式錯誤');</script>");
                return;
            }
        }

        if (Crm_BarCode.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [會員專屬條碼]');</script>");
            return;
        }
        #endregion



        string sCustomerID="";
        crm.CrmMemberCheckBarCode(Crm_BarCode.Text.ToString().Trim(), out sCustomerID);


        if (sCustomerID == "")//比對條碼------------------------------------------------------------------------------------
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('查無此條碼...');</script>");
            return;
        }
        else//比對手機------------------------------------------------------------------------------------------------------
        {
            
            DataSet DS_member = crm.CrmMemberGetCustmain(sCustomerID);
            if (DS_member.Tables[0].Rows[0]["MobileNo"].ToString().Trim() != Crm_Phone.Text.ToString().Trim())
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('手機號碼與條碼配對不符合喔...');</script>");
                return;
            }            

            //取得舊白金CRM會員資料轉頁面            
            Session["DS_type"] = "CrmMember";
            Session["DS_member"] = DS_member;
            Response.Redirect("inforation.aspx");
        }
    }



    
    //[網路會員]登入========================================================================474
    /* *********************
     * websiteMember_Email
     * websiteMember_PassWord
     * websiteMember_txtCode
     * ********************/
    protected void Button2_Click(object sender, EventArgs e)
    {
        #region 登入檢查驗證:資料完整性
        if (websiteMember_Email.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [會員Email]');</script>");
            return;
        }

        if (websiteMember_PassWord.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [會員密碼]');</script>");
            return;
        }
        #endregion

        string sError = "";
        DataSet DS_member = new DataSet();
        Member.Member m = new Member.Member();
        sError = m.ActionMemberLoginCheck(websiteMember_Email.Text.Trim(), websiteMember_PassWord.Text.Trim(), Public.strP_Ename, "474", out DS_member);
        
        
        
        if (sError != "")
        {
            Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
            return;
        }
        else
        {
            //取得網路會員資料轉頁面
            Session["DS_type"] = "websiteMember";
            Session["DS_member"] = DS_member;
            Response.Redirect("inforation.aspx");
        }
    }
}
