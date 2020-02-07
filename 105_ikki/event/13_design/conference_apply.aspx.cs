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
using System.Net.Mail;



public partial class event_13_design_conference_apply : System.Web.UI.Page
{
    Sql s = new Sql();
    Public p = new Public();
    Tools t = new Tools();
    string sAction_No = "323";
    string sCareer = "ikki";
    int totalCnt = 20;
     

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[select *   from [wang_action_members] Where action_no='" + sAction_No + "' ]]></list>");
            sb.Append("</select>");
            sb.Append("</sql>");
            string sError = "";
            DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);


            if (DD.Tables["list"].Rows.Count > 0)
                lblConferenceCnt.Text = DD.Tables["list"].Rows.Count.ToString();
            else
                lblConferenceCnt.Text = "0";
             
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
        string serial_no = "001";

        sDateError = p.CheckActionDate(sCareer, sAction_No);
        if (sDateError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sDateError + "');</script>");
            return;
        }
         
        if (txtUserName1.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [姓名]');</script>");  //value1
            return;
        }

        if (txtUserName2.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者姓名]');</script>");  //value2
            return;
        }


        if (txtPhome1.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [手機]');</script>");  //value5
            return;
        }

        if (txtPhone2.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者手機]');</script>"); //value6
            return;
        }


        if (txtEmail1.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [Email]');</script>"); //value7
            return;
        }

        if (txtEmail2.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者E-mail]');</script>");  //value8
            return;
        }

        if (txtBirthDate.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [出生年月日]');</script>");  //value9
            return;
        }

        if (Session["CheckImageCode"].ToString().Trim().ToLower() != txtCode.Text.Trim().ToLower())
        {
            txtCode.Text = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證號碼不符合，請重新輸入!!..');</script>");
            return;
        }



 

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select * from [wang_action_members] Where action_no='" + sAction_No + "' ]]></list>");
        sb.Append("<list1><![CDATA[select * from [wang_action_members] Where action_no='" + sAction_No + "' and  (value5='" + txtPhome1.Text.Trim() + "' or  value5='" + txtPhone2.Text.Trim() + "'   or  value6='" + txtPhome1.Text.Trim() + "' or  value6='" + txtPhone2.Text.Trim() + "') ]]></list1>");
        sb.Append("<list2><![CDATA[select * from [wang_action_members] Where action_no='" + sAction_No + "' and  (value7='" + txtEmail1.Text.Trim() + "'  or value7='" + txtEmail2.Text.Trim() + "'   or  value8='" + txtEmail1.Text.Trim() + "'  or value8='" + txtEmail2.Text.Trim() + "') ]]></list2>");
        sb.Append("<list5><![CDATA[select top 1 value10  as value10 from [wang_action_members] Where action_no='" + sAction_No + "'  Order by  value10 desc , input_time desc ]]></list5>");

        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);

        if (DD.Tables["list"].Rows.Count >= totalCnt)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('報名人數已經額滿...');</script>");
            return;
        }

        if (DD.Tables["list1"].Rows.Count > 0 && DD.Tables["list2"].Rows.Count > 0)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您好！所留填的手機與E-mail皆重複，請提供其他聯絡方式。');</script>");
            return;
        }

        if (DD.Tables["list1"].Rows.Count > 0)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您好！所留填的手機重複，請提供其他手機。');</script>");
            return;
        }

        if (DD.Tables["list2"].Rows.Count > 0)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您好！所留填的E-mail重複，請提供其他E-mail。 ');</script>");
            return;
        }

        if (DD.Tables["list5"].Rows.Count > 0)
        {
            serial_no = (Convert.ToInt16(DD.Tables["list5"].Rows[0]["value10"]) + 1).ToString("000");
        }

        sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", sCareer));
        //sb.Append(s.ParamXML("uid", DS.Tables["select"].Rows[0]["uid"].ToString().Trim()));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("email",  txtEmail1.Text.Trim() ));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", txtUserName1.Text.Trim() ));
        sb.Append(s.ParamXML("value2", txtUserName2.Text.Trim() ));
        sb.Append(s.ParamXML("value5", txtPhome1.Text.Trim()));
        sb.Append(s.ParamXML("value6", txtPhone2.Text.Trim())); 
        sb.Append(s.ParamXML("value7", txtEmail1.Text.Trim()));
        sb.Append(s.ParamXML("value8", txtEmail2.Text.Trim()));
        sb.Append(s.ParamXML("value9", txtBirthDate.Text.Trim()));
        sb.Append(s.ParamXML("value10",  serial_no ));
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

            Session["323_Name1"] = txtUserName1.Text.Trim();
            Session["323_Name2"] = txtUserName2.Text.Trim();
            Session["323_SerialNo"] = "ikki_" + serial_no;

            #region 寄信給參與者

            System.IO.StringWriter writer = new System.IO.StringWriter();
            Server.Execute("mail.aspx", writer);

            StringBuilder mailSb = new StringBuilder();
            mailSb.Append(writer.ToString());


            string sTitle = "城市創藝 × 藝奇同饗 9/2創藝響應";
            string sBody = mailSb.ToString();
            //string sMail = "<a href=mailto:" + txtEmail.Text.ToString().Trim() + ">" + txtEmail.Text.ToString().Trim() + "</a>";

            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.From = new System.Net.Mail.MailAddress("marketing@ikki.com.tw", "藝奇");
            mail.To.Add(new MailAddress(txtEmail1.Text.Trim(),txtUserName1.Text.Trim()));
            mail.To.Add(new MailAddress(txtEmail2.Text.Trim(),txtUserName2.Text.Trim()));
            mail.Subject = sTitle;
            mail.Body = sBody;
            mail.IsBodyHtml = true;
            mail.BodyEncoding = System.Text.Encoding.UTF8;
            mail.SubjectEncoding = System.Text.Encoding.UTF8;
            mail.Body = sBody;

            System.Net.Mail.SmtpClient SMTPServer = new System.Net.Mail.SmtpClient(t.SmtpServer);


            //Mail.From = new System.Net.Mail.MailAddress(pFromMail, pFromMailName);
            //Mail.Subject = pSubject;
            //Mail.IsBodyHtml = true;
            //Mail.BodyEncoding = System.Text.Encoding.UTF8;
            //Mail.SubjectEncoding = System.Text.Encoding.UTF8;
            //Mail.Body = pBody;


            
            //sSMTPServer = ConfigurationSettings.AppSettings["SMTPServer"];

            //System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
            

            // Mail 相關屬性設定
            //mail.From = "\"藝奇\"<marketing@ikki.com.tw>";
            //mail.To = txtEmail1.Text + ";" + txtEmail2.Text ;           
            
            //mail.Subject = sTitle;
            //mail.Body = sBody;
            //mail.BodyFormat = MailFormat.Html;
            //SmtpMail.SmtpServer = sSMTPServer;

            try
            {
                SMTPServer.Send(mail);
                 //mail.Subject = sTitle;.Send(mail);
            }
            catch(Exception ex)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請檢查email是否正確~');</script>");
                return;
            }




            #endregion

            Response.Redirect("conference_ok.aspx");


        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
            return;
        }

     

    }

     
}
