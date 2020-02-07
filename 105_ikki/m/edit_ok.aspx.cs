using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class edit_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strHmtl = "";
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        if (Session[CareerNo +"_name_s"] == null || Session[CareerNo +"_email_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('login.aspx');</script>");
            Response.End();
        }

        if (Request.QueryString["t"].ToString() == "2")
        {
            strHmtl = Session[CareerNo + "_name_s"].ToString() + "貴賓<br>資料已修改完成，謝謝！";
            LiteContent.Text = strHmtl;
        }
        else
        {
            strHmtl = Session[CareerNo + "_name_s"].ToString() + "貴賓<br>";
            strHmtl += "資料已修改，您的會員認證資料已發<br>";
            strHmtl += "送到" + Session[CareerNo + "_email_s"] + "這個信箱.";
            strHmtl += "請至此Email信箱啟用確認完成修改。";
            strHmtl += "謝謝！";
            strHmtl += "<br><br><table width=\"295\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">";
            strHmtl += "<tr>";
            strHmtl += "<td valign=\"top\">&nbsp;</td>";
            strHmtl += "<td align=\"left\" class=\"title\">是否一直沒收到確認信函？</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"2\" valign=\"top\" height=\"13\"></td>";
            strHmtl += "</tr>";
            strHmtl += "<tr class=\"txt\">";
            strHmtl += "<td align=\"left\" valign=\"top\">‧</td>";
            strHmtl += "<td align=\"left\">首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr class=\"txt\">";
            strHmtl += "<td align=\"left\" valign=\"top\">‧</td>";
            strHmtl += "<td align=\"left\">建議您可檢查郵件信箱的【垃圾郵件夾】，檢查是否有藝奇的註冊確認信函</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr class=\"txt\">";
            strHmtl += "<td align=\"left\" valign=\"top\">‧</td>";
            strHmtl += "        <td align=\"left\">倘若您一直沒收到確認信函，建議您可檢查您的e-mail是否有錯誤。若發現任何錯誤,可再重新註冊一次即可。</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr class=\"txt\">";
            strHmtl += "<td align=\"left\" valign=\"top\">‧</td>";
            strHmtl += "<td align=\"left\">若您一直無法收到確認信函，歡迎您可填寫<a href=\"mailto:service@ikki.com.tw\"><span style=\"color:#d50000;\"><u>連絡信箱</u></span></a>或撥打免付費意見專線0800-365-000為您處理。</td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";

            LiteContent.Text = strHmtl;
        }

        Session[CareerNo + "_name_s"] = null;
        Session[CareerNo + "_email_s"] = null;
    }
}