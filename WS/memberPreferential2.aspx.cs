using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberPreferential2 : System.Web.UI.Page
{
    Website2API.Website2API w = new Website2API.Website2API();
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];


    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime dPrintDay;
        int tMsg;
        string sImageUrl;
        string coupondata;
        // 在這裡放置使用者程式碼以初始化網頁
        if (!IsPostBack)
        {
            if (Session["uid"] == null)
                this.Response.Redirect("memberPreferentialLogin2.aspx");
            else
            {
                lblName.Text = Session["UName"].ToString().Trim();
                lblName2.Text = Session["UName"].ToString().Trim();

                #region 每月20日之前，coupon的使用期限為當月的最後一天
                if (DateTime.Today.Day >= 20)
                {
                    //lblExpiredDate.Text = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString();				
                    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString());
                    lblExpiredDate.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";

                }
                #endregion

                #region 每月20日之後，將coupon的使用期限延至次月的最後一天
                if (DateTime.Today.Day < 20)
                {
                    //lblExpiredDate.Text = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString();				
                    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString());
                    lblExpiredDate.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";
                }
                #endregion

                //設定該品牌結婚禮卷編號!!!"0047"
                string code = w.Wow_BarcodeSendLog("0047", Session["uid"].ToString().Trim(), CareerNo, "180", "180", out tMsg, out sImageUrl, out coupondata);
                
                
                Image1.ImageUrl = sImageUrl;
                lblBarcode.Text = "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + code;
                Session.Remove("uid");
            }
        } 
    }
}
