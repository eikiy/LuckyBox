using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Text.RegularExpressions;
using System.Data;

using System.Net;
using System.Xml;

public partial class e_member_coupon_coupon : System.Web.UI.Page
{
    Website2API.Website2API w = new Website2API.Website2API();
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

    ServiceReferenceER.PublicServiceClient er = new ServiceReferenceER.PublicServiceClient();//呼叫宜瑞，測試站API
    blAction _blAction = new blAction();//活動的
    Tools _Tools = new Tools();//小工具
    string sAction_No = "475";//活動編號[要改]
    EdenredAPIDES_class _Edenred = new EdenredAPIDES_class();


    protected void Page_Load(object sender, EventArgs e)
    {
        DateTime dPrintDay;
        int tMsg;
        string sImageUrl;
        string coupondata;
        // 在這裡放置使用者程式碼以初始化網頁================================================================================================
        if (!IsPostBack)
        {
            Panel_6QR.Visible = false;
            Panel_birthday.Visible = false;
            Panel_marry.Visible = false;

            if (Session["uid"] == null)
            {
                this.Response.Redirect("index.aspx");
            }
            else
            {
                #region 網路會員登入

                lblName.Text = Session["UName"].ToString().Trim();
                //六折============================================================================================

                //六著卷活動期間7/6~8/31
                if (DateTime.Now >= DateTime.Parse("2016/07/06") && DateTime.Now < DateTime.Parse("2016/11/01"))
                {
                    Panel_6QR.Visible = true;

                    string sReturnMsg;
                    DataSet DS_memberAction = new DataSet();
                    DS_memberAction = _blAction.Sel_WangActionMembers_all(sAction_No, Session["email"].ToString().Trim(), out sReturnMsg);

                    if (DS_memberAction.Tables[0].Rows.Count <= 0)
                    {
                        /*

                        #region 宜睿六折卷
                            lblName_coupon.Text = Session["UName"].ToString().Trim();


                            //宜睿的API(會員代號、活動編號、???)
                            string sConsumerCode = "000000000000402";           //由Edenred提供,固定值(正式站與測試站會不同)，consumerCode :   000000000000135
                            string sOperationCode = "GetVoucher";               //API功能名稱(CheckVoucherQuantity(確認庫存數量) , GetVoucher(取序號))


                            string sParameters = "<?xml version=\"1.0\" encoding=\"utf-8\"?> <RequestDto xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">  <OperationCode>GetVoucher</OperationCode>  <Parameters> &lt;GetVoucherRequestDto xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;&lt;OrderNumber&gt;201606288087&lt;/OrderNumber&gt;&lt;ProductCode&gt;WWSYMMDD02&lt;/ProductCode&gt;&lt;RecipientEmail&gt;"
                                + Session["email"].ToString().Trim() + "&lt;/RecipientEmail&gt;&lt;ActiveDate&gt;"
                                + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") + "&lt;/ActiveDate&gt;&lt;ClientOrderNumber&gt;"
                                + CareerNo + Session["uid"].ToString().Trim() + "&lt;/ClientOrderNumber&gt;&lt;/GetVoucherRequestDto&gt;</Parameters><RequestGuid>"
                                + Guid.NewGuid().ToString() + "</RequestGuid></RequestDto>";


                            //sParameters要做加密
                            string sParameters_ADD = EdenredAPIDES_class.DES.EncryptDES(sParameters);

                            //Invoke 包含三個參數 ,  Invoke(consumerCode, OperationCode,Parameters加密後的XML)
                            string sERbarcode = er.Invoke(sConsumerCode, sOperationCode, sParameters_ADD);

                            //解密宜睿給的字串
                            string sERbarcode_ED = EdenredAPIDES_class.DES.DecryptDES(sERbarcode);



                            //第一次拆解
                            XmlDocument Xmldoc = new XmlDocument();
                            Xmldoc.LoadXml(sERbarcode_ED);
                            XmlReader Xmlreader = XmlReader.Create(new System.IO.StringReader(Xmldoc.OuterXml));
                            DataSet ds = new DataSet();
                            ds.ReadXml(Xmlreader);
                            DataTable dt = ds.Tables[0];

                            //第二次拆解
                            XmlDocument Xmldoc2 = new XmlDocument();
                            Xmldoc2.LoadXml(dt.Rows[0]["Response"].ToString());
                            XmlReader Xmlreader2 = XmlReader.Create(new System.IO.StringReader(Xmldoc2.OuterXml));
                            DataSet ds2 = new DataSet();
                            ds2.ReadXml(Xmlreader2);
                            DataTable dt2 = ds2.Tables[0];


                            string sBarcode = dt2.Rows[0]["VoucherNo"].ToString();

                            //***注意***把這個紀錄寫道我們的活動資料表(sCareer,sAction_No,Uid,sEmail,string Value1)
                            bool blReturn = true;

                            blReturn = _blAction.InsertWangActionMembers_input(Public.strP_Ename, sAction_No, Session["uid"].ToString().Trim(), Session["email"].ToString().Trim(), sBarcode);
                            if (!blReturn)
                            {
                                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
                                return;
                            }



                            //產生圖+++++++++++++++++++++++++++++++++++++++++++++++++++++++
                            string sImageW = "180";
                            string sImageH = "180";
                            string sImageUrl_6QR = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", sBarcode, sImageW, sImageH);


                            Image_6QR.ImageUrl = sImageUrl_6QR;
                            lblBarcode_6QR.Text = "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + sBarcode;

                            #endregion
                         * */


                        Panel_6QR.Visible =false;
                    }
                    else//有登入過===========================================================================
                    {
                        lblName_coupon.Text = Session["UName"].ToString().Trim();

                        string sImageW = "180";
                        string sImageH = "180";
                        string sImageUrl_6QR = string.Format("http://chart.apis.google.com/chart?cht=qr&chs={1}x{2}&chl={0}", DS_memberAction.Tables[0].Rows[0]["value1"].ToString().Trim(), sImageW, sImageH);

                        Image_6QR.ImageUrl = sImageUrl_6QR;
                        lblBarcode_6QR.Text = "&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp" + DS_memberAction.Tables[0].Rows[0]["value1"].ToString().Trim();
                    }
                }






                //九折============================================================================================

                lblName_e_member9.Text = Session["UName"].ToString().Trim();

           
                #region 顯示條碼-個人的
                string ActionBarCodeID = "0976";//該活動條碼編號[要改]
                string sHeigh = "180";
                string sWidth = "180";
                int tMsg_9;
                string sImageUrl_9 = "";
                string coupondata_9 = "";
                Website2API.Website2API wow = new Website2API.Website2API();
                string code_9 = wow.Wow_BarcodeSendLog(ActionBarCodeID, Session["uid"].ToString(), CareerNo, sWidth, sHeigh, out tMsg_9, out sImageUrl_9, out coupondata_9);

                Image_e_member9.ImageUrl = sImageUrl_9;
                lblBarcode_e_member9.Text = code_9;


                #region 每月25日之後，將coupon的使用期限延至次月的最後一天
                if (DateTime.Today.Day >= 25)
                {
                    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString());
                    lblExpiredDate_e_member9.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";

                }
                #endregion

                #region 每月25日之前，coupon的使用期限為當月的最後一天
                if (DateTime.Today.Day < 25)
                {
                    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString());
                    lblExpiredDate_e_member9.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";
                }
                #endregion

                #endregion












                //生日============================================================================================
                string sError1 = "";
                DataSet DS1 = new DataSet();
                sError1 = w.Wow_MemberLoginCheckBirthday(CareerNo, Session["email"].ToString().Trim(), Session["password"].ToString().Trim(), out DS1);//驗證
                if (sError1 == "")
                {
                    //判斷條件
                    //1.客人當月生日就顯示
                    //2.客人次月生日+本月25號以後顯示
                    
                    DateTime birthday = DateTime.Parse(DS1.Tables[0].Rows[0]["生日"].ToString());
                    if (DateTime.Now.Month == birthday.Month || (DateTime.Now.Month == birthday.Month - 1 && DateTime.Now.Day>=25))
                    {
                        Panel_birthday.Visible = true;
                    }



                    

                    #region 生日禮卷
                    //券的到期日為生日月份的月底
                    lblName_birthday.Text = Session["UName"].ToString().Trim();
                    lblExpiredDate_birthday.Text = DateTime.Now.Year.ToString() + "年" + birthday.Month.ToString() + "月" +  DateTime.DaysInMonth(DateTime.Now.Year, birthday.Month).ToString() + "日";                    
                    
                    lblName_birthday.Text = Session["UName"].ToString().Trim();

                    //#region 每月25日之後，將coupon的使用期限延至次月的最後一天
                    //if (DateTime.Today.Day >= 25)
                    //{

                    //    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString());
                    //    lblExpiredDate_birthday.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";

                    //}
                    //#endregion

                    //#region 每月25日之前，coupon的使用期限為當月的最後一天
                    //if (DateTime.Today.Day < 25)
                    //{
                    //    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString());
                    //    lblExpiredDate_birthday.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";
                    //}
                    //#endregion

                    //設定該品牌生日禮卷編號!!!"0046"
                    string code = w.Wow_BarcodeSendLog("0046", Session["uid"].ToString().Trim(), CareerNo, "180", "180", out tMsg, out sImageUrl, out coupondata);

                    Image_birthday.ImageUrl = sImageUrl;
                    lblBarcode_birthday.Text = code;


                    #endregion
                }


                //結婚============================================================================================
                string sError2 = "";
                DataSet DS2 = new DataSet();
                sError2 = w.Wow_MemberLoginCheckMarry(CareerNo, Session["email"].ToString().Trim(), Session["password"].ToString().Trim(), out DS2);//驗證
                if (sError2 == "")
                {
                    //判斷條件
                    //1.客人當月結婚就顯示
                    //2.客人次月結婚+本月25號以後顯示
                    DateTime merryDay = DateTime.Parse(DS1.Tables[0].Rows[0]["結婚紀念日"].ToString());
                    if (DateTime.Now.Month == merryDay.Month || (DateTime.Now.Month == merryDay.Month - 1 && DateTime.Now.Day >= 25))
                    {
                        Panel_marry.Visible = true;
                    }
                    
                    lblName_marryday.Text = Session["UName"].ToString().Trim();
                    lblExpiredDate_marryday.Text = DateTime.Now.Year.ToString() + "年" + merryDay.Month.ToString() + "月" + DateTime.DaysInMonth(DateTime.Now.Year, merryDay.Month)  + "日";                    

                    //Panel_marry.Visible = true;

                    #region 結婚禮卷
                    //lblName_marryday.Text = Session["UName"].ToString().Trim();

                    //#region 每月25日之後，將coupon的使用期限延至次月的最後一天
                    //if (DateTime.Today.Day >= 25)
                    //{
                    //    //lblExpiredDate.Text = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString();				
                    //    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(2).AddDays(-1).ToShortDateString());
                    //    lblExpiredDate_marryday.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";

                    //}
                    //#endregion

                    //#region 每月25日之前，coupon的使用期限為當月的最後一天
                    //if (DateTime.Today.Day < 25)
                    //{
                    //    //lblExpiredDate.Text = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString();				
                    //    dPrintDay = DateTime.Parse(DateTime.Parse(DateTime.Now.ToString("yyyy-MM-01")).AddMonths(1).AddDays(-1).ToShortDateString());
                    //    lblExpiredDate_marryday.Text = dPrintDay.Year.ToString() + "年 " + dPrintDay.Month.ToString() + "月 " + dPrintDay.Day.ToString() + "日止";
                    //}
                    //#endregion

                    //設定該品牌結婚禮卷編號!!!"0047"
                    string code2 = w.Wow_BarcodeSendLog("0047", Session["uid"].ToString().Trim(), CareerNo, "180", "180", out tMsg, out sImageUrl, out coupondata);


                    Image_marryday.ImageUrl = sImageUrl;
                    lblBarcode_marryday.Text = code2;

                    #endregion
                }



                Session.Remove("uid");
                Session.Remove("email");
                Session.Remove("password");
                Session.Remove("UName");
                Session.Remove("Birth");
                Session.Remove("Marry");

                #endregion
            }
        }
    }

    /// <summary>
    /// 取某月最後一天
    /// </summary>
    /// <param name="year"></param>
    /// <param name="month"></param>
    /// <returns></returns>
    public DateTime GetLastDayofMonth(int year, int month)
    {
        int days = DateTime.DaysInMonth(year, month);
        DateTime datetime = new DateTime(year, month, 1);
        return datetime.AddDays(days - 1);
    }




}
