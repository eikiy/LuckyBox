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

public partial class member_birthday_print : System.Web.UI.Page
{
    #region Page_Load

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["105_BirthdayMemberName"] == null)
                Response.Redirect("member_login_birthday.aspx");
            else
            {
                string ActionBarCodeID = "0058";
                int tMsg;
                string sImageUrl = "";
                string coupondata = "";
                string sWidth = "180";
                string sHeigh = "180";


                if (Session["105_BirthdayMemberName"] == null || Session["105_uid"] == null)
                {
                    Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_birthday_print.aspx');</script>");
                    Response.End();
                }

                wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
                string code = wow.Wow_BarcodeSendLog(out tMsg, out sImageUrl, out coupondata, ActionBarCodeID, Session["105_uid"].ToString(), aaclsPubSet.strP_ShopNo, sWidth, sHeigh);
                string sPrintDate = "";
                //每月20日之前，coupon的使用期限為當月的最後一天
                if (DateTime.Today.Day >= 20)
                {
                    sPrintDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString();
                }

                //每月20日之後，將coupon的使用期限延至次月的最後一天
                if (DateTime.Today.Day < 20)
                {
                    sPrintDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString();
                }

                if (tMsg == 0 || tMsg == 2)
                {
                    Session["105_BirthdayMemberName"] = null;
                    Session["105_uid"] = null;
                    Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('member_birthday_print.aspx');</script>");
                    Response.End();
                }
                LiteQR.Text = "<img src=\"" + sImageUrl + "\" width=\"180\" height=\"180\">";
                LiteNO.Text = code.ToString();
                LiteDate.Text = sPrintDate;
                lblCName.Text = Session["105_BirthdayMemberName"].ToString();
                LiteName2.Text = Session["105_BirthdayMemberName"].ToString();

                Session.Remove("105_uid");
                Session.Remove("105_BirthdayMemberName");
            }
        }

    }
     #endregion
}
