using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_edit_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string strHmtl = "";
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        if (Session[CareerNo +"_name_s"] == null || Session[CareerNo +"_email_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_login.aspx');</script>");
            Response.End();
        }

        if (Request.QueryString["t"].ToString() == "2")
        {

            strHmtl = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
            strHmtl += "<tr>";
            strHmtl += "<td style=\"border:none;\">" + Session[CareerNo + "_name_s"].ToString() + " 貴賓您好：<br>資料已修改完成，謝謝！</td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";
            LiteOut.Text = strHmtl;
        }
        else
        {
            strHmtl = "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
            strHmtl += "<tr>";
            strHmtl += "    <td style=\"border:none;\">" + Session[CareerNo + "_name_s"].ToString() + " 貴賓您好：<br>您的會員認證資料已發" + Session[CareerNo + "_email_s"].ToString() + "這個信箱. <br>請至此 email 信箱確認成為 藝奇 的網路會員，並列印入會禮。謝謝。</td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";
            strHmtl += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"margin-top:-20px;\">";
            strHmtl += "<tr>";
            strHmtl += "  <td colspan=\"2\" class=\"font_02\">是否一直沒收到確認信函？</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "  <td width=\"4%\">．</td>";
            strHmtl += "  <td>首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。 </td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "  <td width=\"4%\">．</td>";
            strHmtl += "  <td>倘若您一直沒收到確認信函，建議您可檢查您的 email 是否有錯誤。<br>若發現任何錯誤,可再重新註冊一次即可。</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "  <td width=\"4%\">．</td>";
            strHmtl += "  <td>建議您可檢查郵件信箱的垃圾郵件夾，檢查是否有 藝奇 的註冊確認信函。</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "  <td width=\"4%\">．</td>";
            strHmtl += "  <td>若您一直無法收到確認信函，歡迎您可填寫 <a href=\"mailto:service@ikki.com.tw\"> 客服信箱</a> </span> 或 <br>撥打免付費意見專線<span class=\"font01\"> 0800-365-000 </span>為您處理。 </td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";

            LiteOut.Text = strHmtl;
        }

        Session[CareerNo + "_name_s"] = null;
        Session[CareerNo + "_email_s"] = null;

       
    }
}