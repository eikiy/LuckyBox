using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// Public 的摘要描述
/// </summary>
public class Public
{

    
    #region 共用參數
    Sql s = new Sql();
    public Public()
    {
    }
    #endregion



    #region 站台共用參數(藝奇)
    public static string strP_ShopNo = "105";
    public static string strP_Cname = "藝奇";
    public static string strP_Ename = "ikki";
    public static string strP_Ename2 = "Ikki";
    #endregion


    //098177*************************************************************************************************//
  

























    

    #region LogMemberAction
    public void LogMemberAction(string Type, string Career, string Action_no, string uid, string email)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[wang_members_action_log]]></table>");
        sb.Append(s.ParamXML("Type", Type));
        sb.Append(s.ParamXML("Career", Career));
        sb.Append(s.ParamXML("Action_no", Action_no));
        sb.Append(s.ParamXML("uid", uid));
        sb.Append(s.ParamXML("email", email));
        sb.Append(s.ParamXML("InputTime", DateTime.Now));
        sb.Append("</insert>");
        sb.Append("</sql>");
        string sError = "";
        s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
    }
    #endregion

    #region LogVisitCount
    public void LogVisitCount(System.Web.UI.Page webForm, string CareerNo, string ActionID)
    {
        //CareerNo:111
        //ActionID:RSS頁面
        StringBuilder sb1 = new StringBuilder();
        sb1.Append("<sql>");
        sb1.Append("<select>");
        sb1.Append("<select><![CDATA[select * from visit_count where careerno='" + CareerNo + "' and action_id='" + ActionID + "' and session_id='" + webForm.Session.SessionID + "']]></select>");
        sb1.Append("</select>");
        sb1.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);
        if (DS.Tables["select"].Rows.Count < 1)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<insert>");
            sb.Append("<table><![CDATA[visit_count]]></table>");
            sb.Append(s.ParamXML("careerno", CareerNo));
            sb.Append(s.ParamXML("action_id", ActionID));
            sb.Append(s.ParamXML("ip", webForm.Request.ServerVariables.Get("REMOTE_ADDR").Trim()));
            sb.Append(s.ParamXML("session_id", webForm.Session.SessionID));
            sb.Append(s.ParamXML("input_time", DateTime.Now));
            sb.Append("</insert>");
            sb.Append("</sql>");
            sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        }
    }
    #endregion

    #region LogVisitCount
    public void LogVisitCount(System.Web.UI.Page webForm, string CareerNo, string ActionID, string Email)
    {
        //CareerNo:111
        //ActionID:RSS頁面
        StringBuilder sb1 = new StringBuilder();
        sb1.Append("<sql>");
        sb1.Append("<select>");
        sb1.Append("<select><![CDATA[select * from visit_count where careerno='" + CareerNo + "' and action_id='" + ActionID + "' and session_id='" + webForm.Session.SessionID + "']]></select>");
        sb1.Append("</select>");
        sb1.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);
        if (DS.Tables["select"].Rows.Count < 1)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<insert>");
            sb.Append("<table><![CDATA[visit_count]]></table>");
            sb.Append(s.ParamXML("careerno", CareerNo));
            sb.Append(s.ParamXML("action_id", ActionID));
            sb.Append(s.ParamXML("email", Email));
            sb.Append(s.ParamXML("ip", webForm.Request.ServerVariables.Get("REMOTE_ADDR").Trim()));
            sb.Append(s.ParamXML("session_id", webForm.Session.SessionID));
            sb.Append(s.ParamXML("input_time", DateTime.Now));
            sb.Append("</insert>");
            sb.Append("</sql>");
            sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        }
    }
    #endregion

    #region CheckIsWeb_Members
    public DataSet CheckIsWeb_Members(string sCareerName, string sEmail, out string sError)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select * from dbo." + sCareerName + "_members where email=@email]]>");
        sb.Append(s.ParamXML("email", sEmail));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        return DS;
    }
    #endregion

    #region CheckIsWeb_Members2
    public DataSet CheckIsWeb_Members(string sCareerName, string sEmail, string sUID, out string sError)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select * from dbo." + sCareerName + "_members where email=@email and uid<>" + sUID + "]]>");
        sb.Append(s.ParamXML("email", sEmail));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        return DS;
    }
    #endregion

    #region ValidDate
    public bool ValidDate(string sDate)
    {

        if (sDate == "")
            return true;

        try
        {
            DateTime.Parse(sDate);
        }
        catch
        {
            return false;
        }

        return true;

    }
    #endregion

    #region CheckActionDate
    public string CheckActionDate(string strCareer, string strAction_No)
    {
        string strMes = "";

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select Action_PostDate,Action_CloseDate from dbo.wang_action where Action_No=@Action_No AND Career=@Career]]>");
        sb.Append(s.ParamXML("Action_No", strAction_No));
        sb.Append(s.ParamXML("Career", strCareer));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);

        if (DS.Tables[0].Rows.Count <= 0)
        {
            strMes = "系統發生異常，請洽系統管理人員!";
            return strMes;
        }

        DateTime dateStart = DateTime.Parse(DS.Tables[0].Rows[0]["Action_PostDate"].ToString() == "" ? "2000/1/1" : DS.Tables[0].Rows[0]["Action_PostDate"].ToString());
        DateTime dateEnd = DateTime.Parse(DS.Tables[0].Rows[0]["Action_CloseDate"].ToString() == "" ? "2999/1/1" : DS.Tables[0].Rows[0]["Action_CloseDate"].ToString());
        if (dateStart > DateTime.Now)
        {
            strMes = "活動尚未開始~~感謝您的愛護!!";
        }
        if (dateEnd < DateTime.Now)
        {
            strMes = "活動已經結束囉~~感謝您的愛護!!";
        }

        return strMes;
    }

    public string CheckActionDate(string strCareer, string strAction_No, ref DataSet DSReturn)
    {
        string strMes = "";

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select Action_PostDate,Action_CloseDate,JoinCount  from dbo.wang_action where Action_No=@Action_No AND Career=@Career]]>");
        sb.Append(s.ParamXML("Action_No", strAction_No));
        sb.Append(s.ParamXML("Career", strCareer));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);

        if (DS.Tables[0].Rows.Count <= 0)
        {
            strMes = "系統發生異常，請洽系統管理人員!";
            return strMes;
        }

        DSReturn = new DataSet();
        DSReturn = DS;

        DateTime dateStart = DateTime.Parse(DS.Tables[0].Rows[0]["Action_PostDate"].ToString() == "" ? "2000/1/1" : DS.Tables[0].Rows[0]["Action_PostDate"].ToString());
        DateTime dateEnd = DateTime.Parse(DS.Tables[0].Rows[0]["Action_CloseDate"].ToString() == "" ? "2999/1/1" : DS.Tables[0].Rows[0]["Action_CloseDate"].ToString());
        if (dateStart > DateTime.Now)
        {
            strMes = "活動尚未開始~~感謝您的愛護!!";
        }
        if (dateEnd < DateTime.Now)
        {
            strMes = "活動已經結束囉~~感謝您的愛護!!";
        }
        return strMes;
    }
    #endregion


    #region keyin發票號碼是否已存在
    public DataSet Check_DoubleData(string Career, string Action_No, string valueColumn, string sCodeID, out string sError)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select * from dbo.wang_action_members where Action_No=@Action_No AND Career=@Career ");
        sb.Append("  AND " + valueColumn + " =@sCodeID]]>");
        sb.Append(s.ParamXML("Action_No", Action_No));
        sb.Append(s.ParamXML("Career", Career));
        sb.Append(s.ParamXML("sCodeID", sCodeID));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        return DS;
    }

    #endregion

}