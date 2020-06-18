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
using System.Web.Mail;
using System.Text;


public partial class member_forget : System.Web.UI.Page
{
    Sql s = new Sql();
    protected void Page_Load(object sender, EventArgs e)
    {
        btnSend.Attributes["onmouseover"] = "EvImageOverChange(this, 'in');";
        btnSend.Attributes["onmouseout"] = "EvImageOverChange(this, 'out');";  
    }

    protected void btnSend_Click(object sender, ImageClickEventArgs e)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select * from [hot7_members] where email='" + txtEmail.Text.Trim() + "']]></list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        if (DS.Tables["list"].Rows.Count <= 0)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('email不存在或輸入錯誤..');</script>");
            return;
        }

        string message = "<b>您好,這是hot 7網站會員管理系統發出的帳號密碼通知信.</b>";
        message = message + "<br><br>您的帳號為:" + DS.Tables["list"].Rows[0]["email"].ToString().Trim() + "<br>";
        message = message + "您的密碼為:" + DS.Tables["list"].Rows[0]["password"].ToString().Trim() + "<br><br><br>";
        message = message + "用餐資訊查詢 <a href='http://www.hot-7.com'>www.hot-7.com</a><br>免付費意見專線: 0800-295777<br>服務信箱: service@hot-7.com<br>";

        MailMessage mail = new MailMessage();
        mail.From = "\"hot 7\"service@hot-7.com";
        mail.To = DS.Tables["list"].Rows[0]["email"].ToString().Trim();
        mail.Subject = "歡迎加入hot 7網路會員,這是一封帳號密碼通知信.";
        mail.Body = message;
        mail.BodyFormat = MailFormat.Html;
        SmtpMail.SmtpServer = "192.168.2.1";
        SmtpMail.Send(mail);

        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的帳號資料已經寄到您設定的Email Address..');</script>");
        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.html';</script>");
    }
}
