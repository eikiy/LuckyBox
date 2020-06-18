using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
public partial class citi_apply_online : System.Web.UI.Page
{
    Sql s = new Sql();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSend_Click(object sender, ImageClickEventArgs e)
    {
        if (txtName.Value.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[姓名] 欄位不能空白');</script>");
            return;
        }
        if (txtMobile.Value.Trim().Length != 10)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[手機] 不正確');</script>");
            return;
        }
        if (!radSex1.Checked && !radSex0.Checked)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請選擇 [性別]');</script>");
            return;
        }
        string sCareer = "hot7";
        string sAmPm = "";
        if (cbAm.Checked) sAmPm += "上午、";
        if (cbPm.Checked) sAmPm += "下午、";
        if (cbNm.Checked) sAmPm += "晚上、";
        if (sAmPm != "") sAmPm = sAmPm.Substring(0, sAmPm.Length - 1);
        string sSex = "先生";
        if (radSex0.Checked) sSex = "小姐";

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[citi_apply]]]></table>");
        sb.Append(s.ParamXML("Career", sCareer));
        sb.Append(s.ParamXML("Name", txtName.Value.Trim()));
        sb.Append(s.ParamXML("OfficePhone", txtOfficePhone.Value.Trim()));
        sb.Append(s.ParamXML("HomePhone", txtHomePhone.Value.Trim()));
        sb.Append(s.ParamXML("Mobile", txtMobile.Value.Trim()));
        sb.Append(s.ParamXML("AmPm", sAmPm));
        sb.Append(s.ParamXML("InputTime", DateTime.Now));
        sb.Append(s.ParamXML("Sex", sSex));
        sb.Append("</insert>");
        sb.Append("</sql>");

        try
        {
            string sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
            return;
        }


        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('資料已送出~ 客服人員將於一週內為你服務，謝謝!');</script>");
        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='../index.html';</script>");
    }
}
