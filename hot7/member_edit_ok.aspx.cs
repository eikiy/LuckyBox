using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_edit_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strHmtl = "";
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        if (Session[CareerNo + "_name_s"] == null || Session[CareerNo + "_email_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_login.aspx');</script>");
            Response.End();
        }

        if (Request.QueryString["t"].ToString() == "2")
        {
            strHmtl = "<table width=\"86%\" height=\"70\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">";
            strHmtl += "<tr>";
            strHmtl += "<td align=\"center\"><p class=\"gt13\">" + Session[CareerNo + "_name_s"].ToString() + " 貴賓</p>";
            strHmtl += "<p class=\"gt13\">資料已修改完成，謝謝！</p></td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";
            LiteOut.Text = strHmtl;
        }
        else
        {
            strHmtl = "<table width=\"79%\" height=\"243\" border=\"0\" align=\"center\" cellpadding=\"0\" cellspacing=\"0\">";
            strHmtl += "<tr>";
            strHmtl += "<td><p class=\"gt13\">" + Session[CareerNo + "_name_s"].ToString() + " 貴賓： <br><span class=\"rt13\">您的會員認證資料已發送到 " + Session[CareerNo + "_email_s"].ToString() + " 這個信箱. </span><br>";
            strHmtl += "  請至此 email 信箱確認成為 hot 7 的網路會員， 謝謝。</p>";
            strHmtl += "<p class=\"gt13\">&nbsp;</p></td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "<td height=\"20\" class=\"bt13\">是否一直沒收到確認信函？</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "<td><ul>";
            strHmtl += "<li><FONT face=\"新細明體\" class=\"bt13\">首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。 </FONT></li>";
            strHmtl += "<li><FONT face=\"新細明體\" class=\"bt13\">倘若您一直沒收到確認信函，建議您可檢查您的email是否有錯誤。 若發現任何錯誤,可再重新註冊一次即可。 </FONT></li>";
            strHmtl += "<li><FONT face=\"新細明體\" class=\"bt13\">建議您可檢查郵件信箱的垃圾郵件夾，檢查是否有陶板屋的註冊確認信函。 </FONT></li>";
            strHmtl += "<li><FONT face=\"新細明體\" class=\"bt13\">若您一直無法收到確認信函，歡迎您可填寫 <a href=\"mailto:service@tokiya.com.tw\" class=\"pt13\">客服信箱</a> 或 ";
            strHmtl += "撥打免付費意見專線 0800-585-199 為您處理。</FONT></li>";
            strHmtl += "<li><FONT face=\"新細明體\" class=\"bt13\">小提醒：記得準備印表機！！在啟動確認信之後，可以列印兌換券哦！</FONT></li>";
            strHmtl += "</ul></td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";

            LiteOut.Text = strHmtl;
        }

        Session[CareerNo + "_name_s"] = null;
        Session[CareerNo + "_email_s"] = null;
    }

}
