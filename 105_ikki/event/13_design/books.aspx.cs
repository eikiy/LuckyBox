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


public partial class event_13_design_books : System.Web.UI.Page
{

    Sql s = new Sql();
    Public p = new Public();
    string sAction_No = "322";
    string sCareer = "ikki";
    int totalCouponCnt = 10000;
    protected void Page_Load(object sender, EventArgs e)
    {
        IBtnSend.Attributes["onmouseover"] = "EvImageOverChange(this, 'in');";
        IBtnSend.Attributes["onmouseout"] = "EvImageOverChange(this, 'out');";      

        if (!IsPostBack)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[select [NumberCode],[CheckCode] from [wang_action_code] Where ActionNo='" + sAction_No + "' and IsDelete=0 and IsUsed='0' ]]></list>");
            sb.Append("</select>");            
            sb.Append("</sql>");
            string sError = "";
            DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);


            if (DD.Tables["list"].Rows.Count > 0)
                lblCnt.Text = Convert.ToString(Convert.ToInt16(DD.Tables["list"].Rows.Count) / 2);
            else
                lblCnt.Text = "0";
        }

    }

    

    protected void IBtnSend_Click(object sender, ImageClickEventArgs e)
    {
        string sDateError = "";
        //string sAction_No = "322";
        //string sCareer = "ikki";
        //int totalCouponCnt = 20;
        string coupon1 = "", coupon2 = "";
        string checkCode1 = "", checkCode2 = "";

        sDateError = p.CheckActionDate(sCareer, sAction_No);
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
        if (bJoin)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您已參加過了喔, 請勿重複參加..');</script>");
            return;
        }


        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list1><![CDATA[select [NumberCode],[CheckCode] from [wang_action_code] Where ActionNo='" + sAction_No + "' and IsDelete='0' and IsUsed='1' ]]></list1>");        
        sb.Append("<list2><![CDATA[select [NumberCode],[CheckCode] from [wang_action_code] Where ActionNo='" + sAction_No + "' and IsDelete='0' and IsUsed='0' ]]></list2>");
        sb.Append("</select>");
        sb.Append("</sql>"); 
        DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);



        if ( (DD.Tables["list1"].Rows.Count/2) >= totalCouponCnt)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('博客來E-Coupon已索取完畢..');</script>");
            return;
        }

        if ( (DD.Tables["list2"].Rows.Count/2) <= totalCouponCnt && DD.Tables["list2"].Rows.Count >= 2)
        {
            coupon1 = DD.Tables["list2"].Rows[0]["NumberCode"].ToString().Trim();
            checkCode1 = DD.Tables["list2"].Rows[0]["CheckCode"].ToString().Trim();
            coupon2 = DD.Tables["list2"].Rows[1]["NumberCode"].ToString().Trim();
            checkCode2 = DD.Tables["list2"].Rows[1]["CheckCode"].ToString().Trim();
        }
        else
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('博客來E-Coupon已索取完畢..');</script>");
            return;
        }

        sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<update>");
        sb.Append("<table><![CDATA[[wang_action_code]]]></table>");
        sb.Append(s.ParamXML("IsUsed", "1"));
        sb.Append("<where field=\"NumberCode\"><![CDATA[" + coupon1 + "]]></where>");
        sb.Append("<where field=\"CheckCode\"><![CDATA[" + checkCode1 + "]]></where>");
        sb.Append("<where field=\"ActionNo\"><![CDATA[" + sAction_No + "]]></where>");
        sb.Append("</update>");
        sb.Append("<update>");
        sb.Append("<table><![CDATA[[wang_action_code]]]></table>");
        sb.Append(s.ParamXML("IsUsed", "1"));
        sb.Append("<where field=\"NumberCode\"><![CDATA[" + coupon2 + "]]></where>");
        sb.Append("<where field=\"CheckCode\"><![CDATA[" + checkCode2 + "]]></where>");
        sb.Append("<where field=\"ActionNo\"><![CDATA[" + sAction_No + "]]></where>");
        sb.Append("</update>");
        sb.Append("</sql>");
 
        try
        {
            sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
            if (sError != "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('更新失敗!!請洽系統管理員~');</script>");
                return;
            }
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('更新失敗!!請洽系統管理員~');</script>");
            return;
        }



        sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", sCareer));
        sb.Append(s.ParamXML("uid", DS.Tables["select"].Rows[0]["uid"].ToString().Trim()));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("email", DS.Tables["select"].Rows[0]["email"].ToString().Trim()));         
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", coupon1));
        sb.Append(s.ParamXML("value2", coupon2));
        sb.Append(s.ParamXML("value5", checkCode1));
        sb.Append(s.ParamXML("value6", checkCode2));                
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

        Session["322_Coupon1"] = coupon1;
        Session["322_Coupon2"] = coupon2;

        this.Response.Redirect("books_ok.aspx");
			

    }
}
