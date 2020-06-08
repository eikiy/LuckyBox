using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mail;
using System.Text;
using System.Data;

public partial class part : System.Web.UI.Page
{
    blSuggestCard _blSuggestCard = new blSuggestCard();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            blSuggestCard.BindCareer(seleCareer);
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        bool bCheck = true;
        if (txtSubject.Text.Trim() == "")
            bCheck = false;
        if (txtAuthor.Text.Trim() == "")
            bCheck = false;
        if (txtEmail.Text.Trim() == "")
            bCheck = false;
        if (txtArea.Text.Trim() == "")
            bCheck = false;
        if (seleCareer.SelectedValue.Trim() == "請選擇")
            bCheck = false;


        if (bCheck)
        {
            string strSubject = this.txtSubject.Text.Trim();
            string strAuthor = this.txtAuthor.Text.Trim();
            string strEmail = this.txtEmail.Text.Trim();
            string strDesc = this.txtArea.Text.Trim();
            //2015/11/10 新增recno調整由原本自動遞增加號，改抓時間

            //隨機產生uid
            Random crandom = new Random();
            Random crandom2 = new Random();
            decimal drandom = crandom.Next(10000) + crandom2.Next(10000);
            decimal drandomUid = decimal.Parse(DateTime.Now.ToString("yyyyMMddHHmmssfff")) + drandom;
            string snewUid =(seleCareer.SelectedValue.Trim() + drandomUid.ToString().Trim()).Substring(0,18);




            bool blReturn = true;
            blReturn = _blSuggestCard.InsertSC_workersSuggestion(seleCareer.SelectedItem.Text.Trim(),strSubject,strAuthor,strEmail,strDesc,snewUid,Request.ServerVariables.Get("REMOTE_ADDR"));
            if (!blReturn)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
                return;
            }


            //email=======================================================================================
            string message = "<b>事業處:</b>";
            message = message + seleCareer.SelectedItem.Text.Trim() + "<br>";
            message = message + "<b>姓名：</b>";
            message = message + strAuthor.Trim() + "<br>";
            message = message + "<b>Email:</b>";
            message = message + strEmail.Trim() + "<br><br>";
            message = message + "<b>意見主旨：</b><br>";
            message = message + strSubject.Trim() + "<br><br>";
            message = message + "<b>意見內容：</b><br>";
            message = message + strDesc.Trim() + "<br>";

            MailMessage mail = new MailMessage();
            mail.BodyEncoding =  Encoding.UTF8;
          
            mail.From = "empservice@wangsteak.com.tw";
            mail.To = "service@wowprime.com";
            //mail.To="lynn.kuo@wanggroup.com";
            mail.Subject = "王品集團同仁意見訊息";
            mail.Body = message;
            mail.BodyFormat = MailFormat.Html;
            SmtpMail.SmtpServer = "192.168.2.1";
            SmtpMail.Send(mail);

            Response.Redirect("part2.htm");

        }
        else
        {
            lbl1.Visible = true;
        }
    }
    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        txtSubject.Text = "";
        txtAuthor.Text = "";
        txtEmail.Text = "";
        txtArea.Text = "";
    }


}
