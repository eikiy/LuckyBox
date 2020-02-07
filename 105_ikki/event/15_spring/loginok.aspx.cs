using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class event_15_spring_loginok : System.Web.UI.Page
{

    #region 共用參數
    Sql s = new Sql();//資料庫的
    Public _Public = new Public();//共用的
    blAction _blAction = new blAction();//活動的
    check_input _check = new check_input();//檢查
    string sAction_No = "417";//活動編號[要改]
    string sCareer = "ikki";//事業處[要改]
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];//事業處編號
    #endregion
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["416_ikName_in1"] == null)
                Response.Redirect("login.aspx");
            #endregion

            //顯示登入者姓名(本名) 
            lblName.Text = Session["416_ikName_in1"].ToString().Trim();
            //顯示登入者姓名(暱稱) 
            //lblName.Text = Session["408_tbPetName"].ToString().Trim();


            #region 顯示條碼-個人的
            string ActionBarCodeID = "0755";//該活動條碼編號[要改]
            string sHeigh = "180";
            string sWidth = "180";
            int tMsg;
            string sImageUrl = "";
            string coupondata = "";
            wowapi.Website2API wow = new wowapi.Website2API();
            string code = wow.Wow_BarcodeSendLog(ActionBarCodeID, Session["416_ikUid_in1"].ToString(), CareerNo, sWidth, sHeigh, out tMsg, out sImageUrl, out coupondata);

            lblBarCode.Text = code;
            imgQRCode.Src = sImageUrl;
            #endregion



            #region 釋放記憶體暫存資料
            //登入者
            Session.Remove("416_ikName_in1");
            Session.Remove("416_ikUid_in1");
            #endregion
        }
    }
}
