using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class event_15_fall_index : System.Web.UI.Page
{

    #region 共用參數
    Sql s = new Sql();//資料庫的
    Public _Public = new Public();//共用的
    blAction _blAction = new blAction();//活動的
    check_input _check = new check_input();//檢查
    Tools _Tools = new Tools();//小工具
    string sAction_No = "451";//活動編號[要改]
    string sCareer = Public.strP_Ename;//事業處
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];//事業處編號
    #endregion
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //Page.MaintainScrollPositionOnPostBack = true;
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

        #region
        if (textfield.Text.ToString().Trim() == "" || textfield.Text.ToString().Trim() == "有你一起...")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 留言 ');</script>");
            return;
        }
        #endregion

        #region 登入資訊紀錄
        //直接寫進資料庫++++++++++++++++++++++++++++++++++++++++++++++++
        string sError = "";
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", Public.strP_Ename));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("value1", textfield.Text.Trim()));
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
        Page.ClientScript.RegisterStartupScript(
             this.GetType(), 
             "alert",
             "$(function(){ OpenShow('Default.aspx'); });",
             true);

        textfield.Text = "";
        #endregion
    }
}
