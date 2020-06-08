using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class e_member_application_success : System.Web.UI.Page
{
    blAction _blAction = new blAction();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["name"] == null)//暫存???
                Response.Redirect("index.aspx");//第一頁???
            #endregion
            Label1.Text = Session["name"].ToString();
        }
    }


    //領取優惠卷
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sError = "";
        DataSet DS_member = new DataSet();
        Member.Member m = new Member.Member();
        sError = m.ActionMemberLoginCheck(Session["email"].ToString().Trim(), Session["pwd"].ToString().Trim(), Public.strP_Ename, "474", out DS_member);



        if (sError != "")//登入失敗----------------------------------------------------------------------
        {
            Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
            return;

        }
        else//登入成功-----------------------------------------------------------------------------------
        {
            string sErrorCrm = "";
            DataSet DS_memberCrm = new DataSet();
            DS_memberCrm = _blAction.Sel_WM_Customer_CellPhone(DS_member.Tables[0].Rows[0]["手機"].ToString().Trim(), out sErrorCrm);


            if (DS_memberCrm.Tables[0].Rows.Count > 0)
            {
                #region 已經在新白金中了，直接前往優惠卷
                Session["uid"] = DS_member.Tables[0].Rows[0]["uid"].ToString().Trim();
                Session["UName"] = DS_member.Tables[0].Rows[0]["姓名"].ToString().Trim();
                Session["email"] = DS_member.Tables[0].Rows[0]["email"].ToString().Trim();
                Session["password"] = DS_member.Tables[0].Rows[0]["password"].ToString().Trim();
                Session["Birth"] = DS_member.Tables[0].Rows[0]["生日"].ToString().Trim();
                Session["Marry"] = DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString().Trim();
                Response.Redirect("../coupon/coupon.aspx");
                #endregion
            }
            else
            {
                #region 不再新白金中，前往修改資料
                Session["DS_type"] = "websiteMember";
                Session["DS_member"] = DS_member;
                Response.Redirect("inforation.aspx");
                #endregion
            }
        }
    }
}
