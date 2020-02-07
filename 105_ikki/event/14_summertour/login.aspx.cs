using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class event_14_summertour_login : System.Web.UI.Page
{
    Public p = new Public();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // string sDateError = "";
        string sAction_No = "377";
        string sCareer = aaclsPubSet.strP_Ename;
       
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
 
        string sDateError = "";
        DataSet DSReturn = new DataSet();
        sDateError = p.CheckActionDate(sCareer, sAction_No, ref DSReturn);
        if (sDateError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sDateError + "');</script>");
            return;
        }

        string sError = "";
        DataSet DS = new DataSet();
        Member.Member m = new Member.Member();
        sError = m.ActionMemberLoginCheck(txtEmail.Text.Trim(), txtPwd.Text.Trim(), sCareer, sAction_No, out DS);
        if (sError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sError + "');</script>");
            return;
        }



        //check參加過了沒
        //bool bJoin = m.HaveJoinAction(sCareer, sAction_No, txtEmail.Text.Trim());
        //if (bJoin)
        //{
        //    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您已參加過了喔, 請勿重複參加..');</script>");
        //    return;
        //}

        ////value1:發票日期  value2:發票號碼   value3:消費客數

        //StringBuilder sb = new StringBuilder();
        //sb.Append("<sql>");
        //sb.Append("<insert>");
        //sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        //sb.Append(s.ParamXML("Career", sCareer));
        //sb.Append(s.ParamXML("Action_NO", sAction_No));
        //sb.Append(s.ParamXML("uid", DS.Tables[0].Rows[0]["uid"].ToString().Trim()));
        //sb.Append(s.ParamXML("email", DS.Tables[0].Rows[0]["email"].ToString().Trim()));
        //sb.Append(s.ParamXML("input_time", DateTime.Now));
        //sb.Append("</insert>");
        //sb.Append("</sql>");

        //try
        //{
        //    sError = "";
        //    s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        //    if (sError != "")
        //    {
        //        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
        //        return;
        //    }
        //}
        //catch (Exception exp)
        //{
        //    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
        //    return;
        //}




        Session["2014_377Uid"] = DS.Tables[0].Rows[0]["uid"].ToString().Trim();
        Session["2014_377Email"] = DS.Tables[0].Rows[0]["email"].ToString().Trim();
        Session["2014_377CName"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();

        Response.Redirect("keyin.aspx");
    }
}
