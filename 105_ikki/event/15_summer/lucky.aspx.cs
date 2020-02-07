using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;


public partial class event_15_summer_lucky : System.Web.UI.Page
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

    }


    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        #region 驗證是否開始或已經結束
        string sDateError = "";
        DataSet DSReturn = new DataSet();
        sDateError = _blAction.CheckActionDate3(Public.strP_Ename, sAction_No, ref DSReturn);
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
        sError = m.ActionMemberLoginCheck(txtEmail.Text.Trim(), txtPwd.Text.Trim(), Public.strP_Ename, sAction_No, out DS);
        if (sError != "")
        {
            Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
            return;
        }
        #endregion


        #region 帳號參加次數控管
        //(2)此活動一個帳號只能參加一次
        int iJoinCount = 0;
        if (DSReturn.Tables[0].Rows.Count > 0)
            iJoinCount = int.Parse(DSReturn.Tables[0].Rows[0]["JoinCount"].ToString());
        if (iJoinCount > 0)
        {
            bool bJoin = m.HaveJoinAction(Public.strP_Ename, sAction_No, txtEmail.Text.Trim());
            if (bJoin)
            {
                //留在本頁
                Tools.REG_script(Page, "<script>alert('此帳號已登入參加過，謝謝！');</script>");
                return;
            }
        }
        #endregion


        #region 登入資訊紀錄
        //(1)記名字資料++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        Session["439_iName_in1"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();

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
        #endregion

        #region 頁面轉換
        Response.Redirect("lucky_ok.aspx");
        #endregion
    
    }
}
