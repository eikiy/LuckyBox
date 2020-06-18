using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Text;

/// <summary>
/// SuggestCard 的摘要描述
/// </summary>
public class SuggestCard
{
    #region 公用參數
    Sql s = new Sql();
    #endregion

    public SuggestCard()
    {
        //
        // TODO: 在此加入建構函式的程式碼
        //
    }

    #region SC_MainData
    public DataTable BindVersionID(string Career, string ExpendDate, bool blIsAll, bool blIsCareerOnly)
    {
        string sCareerNo = Career;
        if (blIsCareerOnly)
            sCareerNo = Career.Trim().Substring(0, 3) + "00";


        //sb.Append("<sql>");
        ////    sb.Append("<select>");
        ////    sb.Append("<list><![CDATA[SELECT TOP 1 SatisMGUID FROM dbo.SSF_SatisFaction WHERE Career=@Career AND VersionID=@VersionID");
        ////    sb.Append(" AND CONVERT(NVARCHAR(7),SDate,111)<=CONVERT(NVARCHAR(7),@SDate,111) AND IsDel=0 GROUP BY SatisMGUID,SDate ORDER BY SDate DESC]]>");
        ////    sb.Append(s.ParamXML("Career", sCareer));
        ////    sb.Append(s.ParamXML("VersionID", sVersionID));
        ////    sb.Append(s.ParamXML("SDate", sDate));
        ////    sb.Append("</list>");
        ////    sb.Append("<list1><![CDATA[SELECT TOP 1 ISNULL(SatisMGUID,'') AS SatisMGUID FROM dbo.SSF_SatisFaction WHERE LEFT(Career,3)=LEFT(@Career,3) AND VersionID=@VersionID");
        ////    sb.Append(" AND CONVERT(NVARCHAR(7),SDate,111)<=CONVERT(NVARCHAR(7),@SDate,111) AND IsDel=0 GROUP BY SatisMGUID,SDate ORDER BY SDate DESC]]>");
        ////    sb.Append(s.ParamXML("Career", sCareer));
        ////    sb.Append(s.ParamXML("VersionID", sVersionID));
        ////    sb.Append(s.ParamXML("SDate", sDate));
        ////    sb.Append("</list1>");
        ////    sb.Append("</select>");
        ////    sb.Append("</sql>");

        //list1會傳回所有未上線的版本
        //list2會傳回已發佈上線的版本
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        if (blIsAll)
        {
            sb.Append("<list><![CDATA[SELECT TOP 5 * FROM SC_MainData WHERE CareerNo=@CareerNo ");
            sb.Append(" AND (CONVERT(NVARCHAR(10),TestTime,111) <= CONVERT(NVARCHAR(10),@ExpendDate,111)  OR CONVERT(NVARCHAR(10),StartTime,111) <= CONVERT(NVARCHAR(10),@ExpendDate,111))  ORDER BY VersionID DESC]]>");
            sb.Append(s.ParamXML("CareerNo", sCareerNo));
            sb.Append(s.ParamXML("ExpendDate", ExpendDate));
            sb.Append("</list>");
        }
        else
        {
          
    

            //sb.Append("<list2><![CDATA[SELECT TOP 1* FROM SC_MainData WHERE CareerNo=@CareerNo AND CONVERT(VARCHAR(10),SatisFactionTimeStr,111)<=CONVERT(NVARCHAR(10),@ExpendDate,111) ");
            //sb.Append(" AND ISNULL(CONVERT(VARCHAR(10),SatisFactionTimeEnd,111),'2999/12/31') > CONVERT(NVARCHAR(10),@ExpendDate,111) ORDER BY SUBSTRING( VersionID,13,3) ASC]]>");
            sb.Append("<list2><![CDATA[SELECT * FROM SC_MainData WHERE CareerNo=@CareerNo AND CONVERT(NVARCHAR(10),@ExpendDate,111) >=  CONVERT(NVARCHAR(10),SatisfactionTimeStr,111) ");
            sb.Append(" AND CONVERT(NVARCHAR(10),@ExpendDate,111) < ISNULL(CONVERT(NVARCHAR(10),SatisFactionTimeEnd,111),'2999/12/31' ) ORDER BY SUBSTRING( VersionID,13,3) ASC]]>");
            sb.Append(s.ParamXML("CareerNo", sCareerNo));
            sb.Append(s.ParamXML("ExpendDate", ExpendDate));
            sb.Append("</list2>");
        }
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();

        if (DS.Tables.Count > 0)
        {

            if (blIsAll)
                DT = DS.Tables["list"];
            else
                DT = DS.Tables["list2"];

        }

        return DT;

    }

    #endregion


    #region SC_Question

    public DataTable BindSC_Question(string sMainDataGUID)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT QuestionGUID,MainDataGUID,QuestionName,QuestionOrder,QuestionAnsCount,QuestionTypeID FROM SC_Question WHERE MainDataGUID=@MainDataGUID ]]>");
        sb.Append(s.ParamXML("MainDataGUID", sMainDataGUID));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;
    }

    #endregion

    #region SC_Ans

    public DataTable BindSC_Ans(string sMainDataGUID)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT QuestionGUID,QuestionTypeID,QuestionName,AnsGUID,AnsName,AnsPositionY,AnsPositionX,AnsCode,AnsOrder,AnsLocal,IsMeal FROM View_SC_Ans WHERE MainDataGUID=@MainDataGUID]]>");
        sb.Append(s.ParamXML("MainDataGUID", sMainDataGUID));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;
    }

    #endregion

    #region SC_Satisfaction

    public DataTable BindSC_Satisfaction(string sMainDataGUID)
    {
        //AnsGUID ,AnsName ,AnsOrder ,AnsLocal
        //,SatisfactionGUID0 ,SatisfactionName0 ,SatisfactionY0 ,SatisfactionX0 ,SatisfactionCode0
        //,SatisfactionGUID1 ,SatisfactionName1 ,SatisfactionY1 ,SatisfactionX1 ,SatisfactionCode1
        //,SatisfactionGUID2 ,SatisfactionName2 ,SatisfactionY2 ,SatisfactionX2 ,SatisfactionCode2
        //,SatisfactionGUID3 ,SatisfactionName3 ,SatisfactionY3 ,SatisfactionX3 ,SatisfactionCode3
        //,SatisfactionGUID4 ,SatisfactionName4 ,SatisfactionY4 ,SatisfactionX4 ,SatisfactionCode4
        //,SatisfactionGUID5 ,SatisfactionName5 ,SatisfactionY5 ,SatisfactionX5 ,SatisfactionCode5 

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<sp>");
        sb.Append("<list>");
        sb.Append("<sp_name><![CDATA[[SC_WebSatisfactionData]]]></sp_name>");
        sb.Append(s.ParamXML("MainDataGUID", sMainDataGUID));
        sb.Append("</list>");
        sb.Append("</sp>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;
    }

    #endregion














    public DataTable BindSSF_SuggestType(string sCareerNo)
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT SugMGUID,CareerNo,SugMName,SugMOrder FROM dbo.SSF_SuggestionType WHERE CareerNo=@CareerNo AND IsDel=0 ORDER BY SugMOrder ]]>");
        sb.Append(s.ParamXML("CareerNo", sCareerNo));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;


    }

    //建議類別
    public DataTable BindSSF_AnalysisMain(string sCareerNo)
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT AnalyMGUID,SugMGUID,CareerNo,AnalyMName,AnalyMOrder,IsDel,InsertTime,InsertMan FROM dbo.SSF_AnalysisMain WHERE CareerNo=@CareerNo AND IsDel=0 ORDER BY AnalyMOrder ]]>");
        sb.Append(s.ParamXML("CareerNo", sCareerNo));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;


    }
    
    //發票登入
    public bool BindIQInvoice(string sEmail, string IQInvoice, ref string sError)
    {
        bool blIsIQHave = false;
        sError = "";
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[SELECT COUNT(*) FROM dbo.wang_action_members where action_no='311' AND email=@Email and value2=@IQInvoice]]>");
            sb.Append(s.ParamXML("Email", sEmail));
            sb.Append(s.ParamXML("IQInvoice", IQInvoice.Trim()));
            sb.Append("</list>");
            sb.Append("</select>");
            sb.Append("</sql>");
            DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);

            if (int.Parse(DS.Tables[0].Rows[0][0].ToString().Trim()) >= 1)
                blIsIQHave = true;

        }
        catch (Exception ex)
        {
            sError = "發票登入發生錯誤~";
            blIsIQHave = true;
        }

        return blIsIQHave;

    }
    
    #region 建立ID:CreateGUID
    /// <summary>
    /// guid使用年月日時分秒毫秒
    /// </summary>
    /// <returns></returns>
    public string CreateGUID(int iLengh)
    {
        //1.2 取當前年  
        string sY = System.DateTime.Now.Year.ToString();
        //1.3 取當前月  

        string sM = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
        //1.4 取當前日  
        string sD = System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        // 1.5 取當前時  
        string sHH = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
        // 1.6 取當前分  
        string sSS = System.DateTime.Now.Minute.ToString();
        // 1.7 取當前秒  
        string sSSS = System.DateTime.Now.Second.ToString();
        // 1.8 取當前毫秒  
        string sSSSS = System.DateTime.Now.Millisecond.ToString();

        string sDate = sY + sM + sD + sHH + sSS + sSSS + sSSSS;
        string sGUID = "";
        sGUID = (sDate + (Guid.NewGuid().ToString().Replace("-", ""))).Substring(0, iLengh);

        return sGUID;
    }
    #endregion
        
    #region 建議項目(2015/08/24)
    /// <summary>
    /// 建議項目
    /// </summary>
    /// <param name="sAnalyMGUID">建議類別guid</param>
    /// <param name="sVersionID">版次後三碼</param>
    /// <returns></returns>
    public DataTable BindSSF_AnalysisDetail(string sAnalyMGUID, string sVersionID)
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT * FROM  dbo.SSF_AnalysisDetail WHERE AnalyMGUID=@AnalyMGUID AND VersionID=@VersionID AND IsDel=0 ORDER BY AnalyDOrder ]]>");
        sb.Append(s.ParamXML("AnalyMGUID", sAnalyMGUID));
        sb.Append(s.ParamXML("VersionID", sVersionID));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;


    }
    #endregion

    #region 意見細項(2015/08/24)
    /// <summary>
    /// SSF_SuggestionDetail 意見細項(太甜、太油..)
    /// </summary>
    /// <param name="sAnalyMGUID">建議類別guid</param>
    /// <returns></returns>
    public DataTable BindSSF_SuggestionDetail(string sAnalyMGUID, string sVersionID)
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT * FROM  dbo.SSF_SuggestionDetail WHERE AnalyMGUID=@AnalyMGUID  AND IsDel=0 ORDER BY SugDOrder ASC]]>");
        sb.Append(s.ParamXML("AnalyMGUID", sAnalyMGUID));
        sb.Append(s.ParamXML("VersionID", sVersionID));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
        DataTable DT = new DataTable();
        if (DS.Tables.Count > 0)
        {
            DT = DS.Tables[0];
        }

        return DT;
    }
    #endregion

    #region 寫入Daily_OtherSuggest:其他意見_紙本無(2015.8.24版本)
    /// <summary>
    /// 2015/08/24新增SSF_Daily_OtherSuggest
    /// </summary>
    /// <param name="sMainDataGUID"></param>
    /// <param name="sRecMainGUID"></param>
    /// <param name="sVersionID"></param>
    /// <param name="sVersionName"></param>
    /// <param name="sStoreNo"></param>
    /// <param name="sExpendDate"></param>
    /// <param name="sCName"></param>
    /// <param name="sDOGUID"></param>
    /// <param name="sSugType"></param>
    /// <param name="sSuggest"></param>
    /// <param name="sAnalyMGUID"></param>
    /// <param name="sAnalyDGUID"></param>
    /// <param name="sSugDetail"></param>
    /// <returns>sError</returns>
    public string InsertSSF_Daily_OtherSuggest(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sDOGUID, string sSugType, string sSuggest, string sAnalyMGUID, string sAnalyDGUID, string sSugDetail)
    {
        string sError = "";
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[SELECT *  FROM [dbo].[SSF_Daily_OtherSuggest] Where DOGUID= @DOGUID]]>");
            sb.Append(s.ParamXML("DOGUID", sDOGUID));
            sb.Append("</list>");
            sb.Append("</select>");
            sb.Append("</sql>");

            DataSet DS = s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);
            string sbTxt = "insert";
            if (DS.Tables[0].Rows.Count > 0)
            {
                sbTxt = "update";
            }

            sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<" + sbTxt + ">");
            sb.Append("<table><![CDATA[[SSF_Daily_OtherSuggest]]]></table>");
            if (sbTxt == "insert")
                sb.Append(s.ParamXML("DOGUID", sDOGUID));
            sb.Append(s.ParamXML("DailyGUID", sRecMainGUID));
            sb.Append(s.ParamXML("CareerNo", sStoreNo));
            sb.Append(s.ParamXML("ExpendDate", sExpendDate));
            sb.Append(s.ParamXML("VersionID", sVersionID));
            sb.Append(s.ParamXML("VersionName", sVersionName));
            sb.Append(s.ParamXML("AnalyMGUID", sAnalyMGUID.Trim()));
            sb.Append(s.ParamXML("AnalyDGUID", sAnalyDGUID.Trim()));
            sb.Append(s.ParamXML("SugDGUID", sSugDetail));
            sb.Append(s.ParamXML("SugMGUID", sSugType));
            sb.Append(s.ParamXML("SugTypeMNo", sSugType));
            sb.Append(s.ParamXML("SugTypeDNo", sSugDetail));
            sb.Append(s.ParamXML("SugCount", 1));
            sb.Append(s.ParamXML("SugNote", sSuggest));
            sb.Append(s.ParamXML("InsertMan", sCName));
            sb.Append(s.ParamXML("InsertTime", DateTime.Now));
            if (sbTxt == "update")
                sb.Append("<where field=\"DOGUID\"><![CDATA[" + sDOGUID.Trim() + "]]></where>");
            sb.Append("</" + sbTxt + ">");
            sb.Append("</sql>");
            sError = "";
            s.Cmd2DS(s.ConnStr.suggestcard, sb.ToString(), out sError);

            sError = "修改失敗!!請後在試~";

        }
        catch (Exception ex)
        {
            sError = "修改失敗!!請後在試~";
        }
        return sError;
    }
    #endregion
}
