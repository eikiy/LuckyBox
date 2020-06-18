using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register_success : System.Web.UI.Page
{
    #region 共用參數
    Public _Public = new Public();
    blAction _blAction = new blAction();
    string sCareer = "putien";
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



        //int res = wow.Wow_MemberSuccess(CareerNo, sid, out name, out uid);//一般
        int res = wow.Wow_MemberSuccess_Action(CareerNo, sid, out name, out uid, out email);//活動

        if (res == 0)
        {
            Session[CareerNo + "_name_s"] = name;
            Session[CareerNo + "_uid_s"] = uid;

            #region 加入會員抽機票活動
            //string sAction_No = "465";//活動編號[要改]

            //bool blReturn = true;
            //blReturn = _blAction.InsertWangActionMembers_login(Public.strP_Ename, sAction_No, uid, email);
            #endregion




            #region 加入會員抽獎活動(7/1~8/31)
            if (DateTime.Now > DateTime.Parse("2016/07/01") && DateTime.Now < DateTime.Parse("2016/08/31"))
            {
                string sAction_No = "477";//活動編號[要改]

                bool blReturn = true;
                blReturn = _blAction.InsertWangActionMembers_login(Public.strP_Ename, sAction_No, uid, email);

            }
            #endregion



            Response.Write("<script language=javascript>alert(\"啟動會員帳號成功!!\");location.replace('index.html');</script>");
            Response.End();
        }
        else
        {
            Response.Write("<script language=javascript>alert(\"啟動會員帳號失敗，請至已修改的email信箱啟動!!\");location.replace('index.htm');</script>");
            Response.End();
        }
    }

}
