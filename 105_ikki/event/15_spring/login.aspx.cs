using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;


public partial class event_15_spring_login : System.Web.UI.Page
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

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)//填資料+分享紐
    {

        #region 驗證是否開始或已經結束
        string sDateError = "";
        DataSet DSReturn = new DataSet();
        sDateError = _Public.CheckActionDate(Public.strP_Ename, sAction_No, ref DSReturn);
        if (sDateError != "")
        {
            Tools.REG_script(Page, "<script>alert('" + sDateError + "');</script>");
            return;
        }
        #endregion       
        

        #region 登入檢查驗證
        if (txtEmail.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [e - mail]');</script>");
            return;
        }

        if (txtPwd.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [密碼]');</script>");
            return;
        }

        string sError = "";
        DataSet DS = new DataSet();
        Member.Member m = new Member.Member();
        sError = m.ActionMemberLoginCheck(txtEmail.Text.Trim(), txtPwd.Text.Trim(), aaclsPubSet.strP_Ename, sAction_No, out DS);
        if (sError != "")
        {
            Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
            return;
        }
        #endregion


        #region 輸入完整檢查

        if (dataName.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [暱稱]');</script>");
            return;
        }
        if (dataPlace.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [推薦...]');</script>");
            return;
        }

        #endregion



        #region 寫入活動登入資料表
        //(1)記名字資料(下一頁寫入資料庫)++++++++++++++++++++++++++++++++++++++++
        Session["416_ikName_in1"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();
        Session["416_ikUid_in1"] = DS.Tables[0].Rows[0]["uid"].ToString().Trim();

        //417資料庫一直寫********************************************************
        int iCNT = _blAction.BindTotalCount(sAction_No) + 1;
        //(2)記名子直接寫進資料庫++++++++++++++++++++++++++++++++++++++++++++++++
        string strUid = "";
        strUid = DS.Tables[0].Rows[0]["uid"].ToString().Trim(); ;
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", Public.strP_Ename));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("uid", strUid));
        sb.Append(s.ParamXML("email", txtEmail.Text.Trim()));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", iCNT));//編號
        sb.Append(s.ParamXML("value2",dataName.Text.ToString().Trim() ));//暱稱
        sb.Append(s.ParamXML("value3",dataPlace.Text.ToString().Trim() ));//地方
        sb.Append("</insert>");
        sb.Append("</sql>");
        try
        {
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
            return;
        }
       
        //416資料庫只寫一筆for抽獎
        if (_blAction.BindEmailCount("416", txtEmail.Text.Trim()) < 1)//416資料庫內為登入過
        {
            string strUid416 = "";
            strUid416 = DS.Tables[0].Rows[0]["uid"].ToString().Trim(); ;
            StringBuilder sb416 = new StringBuilder();
            sb416.Append("<sql>");
            sb416.Append("<insert>");
            sb416.Append("<table><![CDATA[[wang_action_members]]]></table>");
            sb416.Append(s.ParamXML("Career", Public.strP_Ename));
            sb416.Append(s.ParamXML("Action_NO", "416"));
            sb416.Append(s.ParamXML("uid", strUid416));
            sb416.Append(s.ParamXML("email", txtEmail.Text.Trim()));
            sb416.Append(s.ParamXML("input_time", DateTime.Now));
            sb416.Append("</insert>");
            sb416.Append("</sql>");
            try
            {
                s.Cmd2DS(s.ConnStr.website, sb416.ToString(), out sError);
            }
            catch (Exception exp)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
                return;
            }
        }

        #endregion


        #region 頁面轉換
        //(1)下一頁+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Response.Redirect("loginok.aspx");


        //(2)警示小視窗+跳下一頁++++++++++++++++++++++++++++++++++++++++++++++++
        //this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('恭喜您已經完成活動登錄！預祝您幸運中獎！');</script>");
        //this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.html';</script>");        
        #endregion
    }

}
