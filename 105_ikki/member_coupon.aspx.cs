using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_coupon : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        string ActionBarCodeID = "0060";
        int tMsg;
        string sImageUrl = "";
        string coupondata = "";
        string sWidth = "180";
        string sHeigh = "180";

        if (Request.QueryString["sid"] == null || Request.QueryString["sid"] == "")
        {
            if (Session[CareerNo + "_name_s"] == null || Session[CareerNo + "_uid_s"] == null)
            {
                Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_join.aspx');</script>");
                Response.End();
            }

            LiteName.Text = Session[CareerNo + "_name_s"].ToString();

            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            string code = wow.Wow_BarcodeSendLog(out tMsg, out sImageUrl, out coupondata, ActionBarCodeID, Session[CareerNo + "_uid_s"].ToString(), CareerNo, sWidth, sHeigh);

            if (tMsg == 0 || tMsg == 2)
            {
                Session[CareerNo + "name_s"] = null;
                Session[CareerNo + "uid_s"] = null;
                Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_join.aspx');</script>");
                Response.End();
            }
            LiteQR.Text = "<img src=\"" + sImageUrl + "\" width=\"180\" height=\"180\">";
            LiteNO.Text = code.ToString();
            LiteDate.Text = coupondata;
            LiteName.Text = Session[CareerNo + "_name_s"].ToString();
            LiteName2.Text = Session[CareerNo + "_name_s"].ToString();

            Session[CareerNo + "_name_s"] = null;
            Session[CareerNo + "_uid_s"] = null;
        }
        else
        {
            Response.Redirect("register_success.aspx?sid=" + Request.QueryString["sid"].ToString());
        }

    }
}