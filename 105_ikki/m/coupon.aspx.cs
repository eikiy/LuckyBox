using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class coupon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";
        string ActionBarCodeID = "0093";
        int tMsg;
        string sImageUrl = "";
        string coupondata = "";
        string sWidth = "300";
        string sHeigh = "300";
        
        if (Session[CareerNo + "_name_s"] == null || Session[CareerNo + "_uid_s"] == null)
        {
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('register.aspx');</script>");
            Response.End();
        }
        
        LiteName.Text = Session[CareerNo +"_name_s"].ToString();

        
        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();

        string code = wow.Wow_BarcodeSendLog(out tMsg, out sImageUrl , out coupondata, ActionBarCodeID, Session[CareerNo + "_uid_s"].ToString(), CareerNo, sWidth, sHeigh);
        
        if (tMsg == 0 || tMsg == 2)
        {
            Session[CareerNo +"name_s"] = null;
            Session[CareerNo +"uid_s"] = null;
            Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('register.aspx');</script>");
            Response.End();
        }

        strHtml = "<div class=\"img\"><img src=\"" + sImageUrl + "\" width=\"300\" height=\"300\"></div>";
        strHtml += "<div class=\"txt\">" + code.ToString() + "</div>";

        LiteBarcode.Text = strHtml;
        LiteDate.Text = coupondata;

        Session[CareerNo +"_name_s"] = null;
        Session[CareerNo +"_uid_s"] = null;
    }
}