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
using System.Text;


public partial class event_13_design_check : System.Web.UI.Page
{
    Sql s = new Sql();
    Public p = new Public();
    string sAction_No = "322";
    string sCareer = "ikki";
    int totalCouponCnt = 20;

    protected void Page_Load(object sender, EventArgs e)
    {
        IBtnSend.Attributes["onmouseover"] = "EvImageOverChange(this, 'in');";
        IBtnSend.Attributes["onmouseout"] = "EvImageOverChange(this, 'out');";      


    }


    protected void IBtnSend_Click(object sender, ImageClickEventArgs e)
    {
        string sDateError = "";
        string coupon1 = "", coupon2 = "";
        string checkCode1 = "", checkCode2 = "";

        //2013/11/1 活動查詢功能，日期延11/30 jean.chen
        DateTime dateStart = DateTime.Parse("2013/10/01");
        DateTime dateEnd = DateTime.Parse("2013/11/30");
        if (dateStart > DateTime.Now)
        {
            sDateError = "活動尚未開始~~感謝您的愛護!!";
        }
        if (dateEnd < DateTime.Now)
        {
            sDateError = "活動已經結束囉~~感謝您的愛護!!";
        }



       // sDateError = p.CheckActionDate(sCareer, sAction_No);
        if (sDateError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sDateError + "');</script>");
            return;
        }
        if (txtEmail.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [e - mail]');</script>");
            return;
        }
        if (txtPwd.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [密碼]');</script>");
            return;
        }

        string sError = "";
        DataSet DS = new DataSet();
        wsMember.Member m = new wsMember.Member();
        sError = m.ActionMemberLoginCheck(txtEmail.Text.Trim(), txtPwd.Text.Trim(), sCareer, sAction_No, out DS);
        if (sError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sError + "');</script>");
            return;
        }

        //check參加過了沒
        bool bJoin = m.HaveJoinAction(sCareer, sAction_No, txtEmail.Text.Trim());
        if (!bJoin)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您尚未參加過了, 請先參加活動..');</script>");
            return;
        }


        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list1><![CDATA[select * from [wang_action_members] Where action_no='" + sAction_No + "' and email='" + txtEmail.Text.Trim() + "' ]]></list1>"); 
        sb.Append("</select>");
        sb.Append("</sql>");
        DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);


        if (DD.Tables["list1"].Rows.Count > 0)
        {
            coupon1 = DD.Tables["list1"].Rows[0]["value1"].ToString().Trim();
            coupon2 = DD.Tables["list1"].Rows[0]["value2"].ToString().Trim();
        }

        if (DS.Tables[0].Rows.Count > 0)
            Session["322_QueryCName"] = DS.Tables[0].Rows[0]["姓名"].ToString();
 

        Session["322_QueryCoupon1"] = coupon1;
        Session["322_QueryCoupon2"] = coupon2;

        this.Response.Redirect("check_ok.aspx");
    }
}
