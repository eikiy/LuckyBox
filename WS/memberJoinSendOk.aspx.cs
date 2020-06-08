using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class memberJoinSendOk : System.Web.UI.Page
{
    #region 共用參數
    Public _Public = new Public();
    blAction _blAction = new blAction();
    string sCareer = Public.strP_Ename;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        Website2API.Website2API wow = new Website2API.Website2API();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string name = "";
        string uid = "";
        string email = "";



        if (Request.QueryString["sid"] == null || Request.QueryString["sid"] == "")
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗!!\");location.replace('index.htm');</script>");
            Response.End();
        }
        check_input new_word = new check_input();
        string sid = new_word.doCheck_Input(Request.QueryString["sid"].ToString(), 100);



        int res = wow.Wow_MemberSuccess(CareerNo, sid, out name, out uid);//一般
        //int res = wow.Wow_MemberSuccess_Action(CareerNo, sid, out name, out uid, out email);//活動

        if (res == 0)
        {
            Session[CareerNo + "_name_s"] = name;
            Session[CareerNo + "_uid_s"] = uid;

            #region 加入會員抽機票活動
            //string sAction_No = "465";//活動編號[要改]

            //bool blReturn = true;
            //blReturn = _blAction.InsertWangActionMembers_login(Public.strP_Ename, sAction_No, uid, email);
            #endregion


            #region 加入會員優惠卷
            string ActionBarCodeID = "0048";
            int tMsg;
            string sImageUrl = "";
            string coupondata = "";
            string sWidth = "180";
            string sHeigh = "180";

            if (Session[CareerNo + "_name_s"] == null || Session[CareerNo + "_uid_s"] == null)
            {
                Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('memberJoin.aspx');</script>");
                Response.End();
            }


            string code = wow.Wow_BarcodeSendLog(ActionBarCodeID, Session[CareerNo + "_uid_s"].ToString(), CareerNo, sWidth, sHeigh, out tMsg, out sImageUrl, out coupondata);

            if (tMsg == 0 || tMsg == 2)
            {
                Session[CareerNo + "name_s"] = null;
                Session[CareerNo + "uid_s"] = null;
                Response.Write("<script language=javascript>alert(\"資料錯誤!!\");location.replace('memberJoin.aspx');</script>");
                Response.End();
            }
            LiteQR.Text = "<img src=\"" + sImageUrl + "\" width=\"180\" height=\"180\">";
            LiteNO.Text = code.ToString();
            LiteDate.Text = coupondata;
            LiteName.Text = Session[CareerNo + "_name_s"].ToString();
            LiteName2.Text = Session[CareerNo + "_name_s"].ToString();

            Session[CareerNo + "_name_s"] = null;
            Session[CareerNo + "_uid_s"] = null;
            #endregion


            //Response.Write("<script language=javascript>alert(\"啟動會員帳號成功!!\");location.replace('memberJoinSendOk.aspx');</script>");
            //Response.End();
        }
        else
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗，請至已修改的email信箱啟動!!\");location.replace('index.html');</script>");
            Response.End();
        }
    }
}
