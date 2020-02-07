using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
public partial class event_14_summertour_download : System.Web.UI.Page
{
    Sql s = new Sql();
    Public p = new Public();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtEmail.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的email未輸入,請重新填寫..');</script>");
            return;
        }
        if (txtPwd.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的密碼未輸入,請重新填寫..');</script>");
            return;
        }

        string sCareer = aaclsPubSet.strP_Ename;
        string sAction_No = "376";
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
        int iJoinCount = 0;
        if (DSReturn.Tables[0].Rows.Count > 0)
            iJoinCount = int.Parse(DSReturn.Tables[0].Rows[0]["JoinCount"].ToString());
        if (iJoinCount > 0)
        {
            bool bJoin = m.HaveJoinAction(sCareer, sAction_No, txtEmail.Text.Trim());
            if (bJoin)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您已參加過了喔, 請勿重複參加..');</script>");
                return;
            }
        }


        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", sCareer));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("uid", DS.Tables["select"].Rows[0]["uid"].ToString().Trim()));
        sb.Append(s.ParamXML("email", DS.Tables["select"].Rows[0]["email"].ToString().Trim()));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append("</insert>");
        sb.Append("</sql>");

        try
        {
            sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
            if (sError != "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
                return;
            }
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
            return;
        }

        Session["201404_376PrintName"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();
        Response.Redirect("download_ok.aspx");
    }
   
}
