using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_15_summer_lucky_ok : System.Web.UI.Page
{
    #region 共用參數
    Sql s = new Sql();//資料庫的
    Public _Public = new Public();//共用的
    blAction _blAction = new blAction();//活動的
    check_input _check = new check_input();//檢查
    Tools _Tools = new Tools();//小工具
    string sAction_No = "439";//活動編號[要改]
    string sCareer = Public.strP_Ename;//事業處
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];//事業處編號
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["439_iName_in1"] == null)//暫存???
                Response.Redirect("lucky.aspx");//第一頁???
            #endregion

           
            #region 釋放記憶體暫存資料
            //登入者的
            Session.Remove("439_iName_in1");
            #endregion
        }

    }
}
