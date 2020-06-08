using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Data;

/// <summary>
/// dbSuggestCard 的摘要描述
/// </summary>
public class dbSuggestCard:DBBaseClass
{
	#region 共用參數
	public dbSuggestCard()
	{
		//
		// TODO: 在此加入建構函式的程式碼
		//
    }
    #endregion

	
    //同仁意見=========================================
    #region 搜尋
    public DataSet Sel_Career(out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();

            sb.Append(@"SELECT CareerNo Career,Called CareerName, CareerNo 
                        FROM wanggroup.dbo.Career_view ");
            sb.Append(@" where left(CareerNo,1)=1 and CareerNo<>'101' and CareerNo<>'121' and Show=1 and CareerNo<'180' ");
            sb.Append(" ORDER BY  CareerNo");

            SDA_Website.SelectCommand.CommandText = sb.ToString();
            SDA_Website.Fill(DS);
            SDA_Website.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 寫入
    public bool InsertSC_workersSuggestion(string sCareer, string sSubject, string sName, string sEmail, string sContext, string sRecno, string sIP)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();

        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[workers_suggestion](career,subject,name,email,context,recno,IP,pDate) ");
            sb.Append("VALUES (@career,@subject,@name,@email,@context,@recno,@IP,@pDate)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@career", sCareer);
            SQC_Website.Parameters.AddWithValue("@subject", sSubject);
            SQC_Website.Parameters.AddWithValue("@name", sName);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@context", sContext);
            SQC_Website.Parameters.AddWithValue("@recno", sRecno);
            SQC_Website.Parameters.AddWithValue("@IP", sIP);
            SQC_Website.Parameters.AddWithValue("@pDate", DateTime.Now);
            SQC_Website.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC_Website.ExecuteNonQuery();
            SQC_Website.Connection.Close();
            SQC_Website.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion


	
   //事業處相關資料======================================================================
    #region 搜尋Store_View:分店下拉                                             ...財務部設定
    public DataSet Sel_StoreView(string strStoreNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_wanggroup.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_wanggroup.SelectCommand.Parameters.Clear();
            SDA_wanggroup.SelectCommand.Parameters.AddWithValue("@StoreNo", strStoreNo);//117
            SDA_wanggroup.SelectCommand.Parameters.AddWithValue("@StoreNo2", strStoreNo + "00");//11700

            sb.Append(@"SELECT StoreNo,StoreName 
                        FROM Cancer.wanggroup.dbo.Store_View ");
            //sb.Append(@"WHERE [CareerNo]=@StoreNo and [StoreNo]<>@StoreNo2 AND OpenDate is not null AND DATEADD(MONTH,1,GETDATE())>GETDATE() AND ISNUMERIC(StoreNo)=1");
            sb.Append(@"WHERE [CareerNo]=@StoreNo and [StoreNo]<>@StoreNo2 AND OpenDate is not null AND CloseDate is null AND ISNUMERIC(StoreNo)=1 ");
            sb.Append(" ORDER BY  ZipCode ASC");

            SDA_wanggroup.SelectCommand.CommandText = sb.ToString();
            SDA_wanggroup.Fill(DS);
            SDA_wanggroup.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 搜尋SC_ParameterItems:用餐時段下拉                                  ...資訊部直接新增IN[SC_ParameterItems]
    public DataSet Sel_SC_ParameterItems(string strStoreNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        //DataTable DT = DS.Tables["list"];//1; table取名字
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@strStoreNo_Times", strStoreNo + "Times");

            sb.Append(@"SELECT PItemName,PItemCode 
                        FROM [SuggestCard].[dbo].[SC_ParameterItems] ");
            sb.Append(@" WHERE PTypeID=@strStoreNo_Times");
            sb.Append("  ORDER BY  PItemOrder");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 搜尋Store_View:分店下拉(測試)
    public DataSet Sel_StoreViewTest(string strStoreNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_wanggroup.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_wanggroup.SelectCommand.Parameters.Clear();
            SDA_wanggroup.SelectCommand.Parameters.AddWithValue("@StoreNo", strStoreNo);//117
            SDA_wanggroup.SelectCommand.Parameters.AddWithValue("@StoreNo2", strStoreNo + "00");//11700

            sb.Append(@"SELECT StoreNo,StoreName 
                        FROM Cancer.wanggroup.dbo.Store_View ");
            sb.Append(@"WHERE [CareerNo]=@StoreNo and [StoreNo]<>@StoreNo2");// AND OpenDate is not null
            sb.Append(" ORDER BY  ZipCode ASC");

            SDA_wanggroup.SelectCommand.CommandText = sb.ToString();
            SDA_wanggroup.Fill(DS);
            SDA_wanggroup.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 搜尋SC_ParameterItems:用餐時段下拉(測試)
    public DataSet Sel_SC_ParameterItemsTest(string strStoreNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        //DataTable DT = DS.Tables["list"];//1; table取名字
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@strStoreNo_Times", strStoreNo + "Times");

            sb.Append(@"SELECT PItemName,PItemCode 
                        FROM [SuggestCard].[dbo].[SC_ParameterItems] ");
            sb.Append(@" WHERE PTypeID=@strStoreNo_Times");
            sb.Append("  ORDER BY  PItemOrder");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion




	
	

    //線上建議卡相關題目讀取資料庫========================================================
    #region 搜尋SC_MainData:問卷版本
    public DataSet SelSC_MainData(string Career, string ExpendDate, bool blIsAll, bool blIsCareerOnly)
    {
        string sCareerNo = Career;
        if (blIsCareerOnly)
            sCareerNo = Career.Trim().Substring(0, 3) + "00";

        DataSet DS = new DataSet();
        StringBuilder sb = new StringBuilder();
        
		//會傳回所有未上線的版本--------------------------------------------------------------------------
        if (blIsAll)
        {
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo);
            SDA.SelectCommand.Parameters.AddWithValue("@ExpendDate", ExpendDate);

            sb.Append(@"SELECT TOP 5 * 
                        FROM [SuggestCard].[dbo].[SC_MainData]");
            sb.Append("WHERE CareerNo=@CareerNo AND (CONVERT(NVARCHAR(10),TestTime,111) <= CONVERT(NVARCHAR(10),@ExpendDate,111)  OR CONVERT(NVARCHAR(10),StartTime,111) <= CONVERT(NVARCHAR(10),@ExpendDate,111)) ");
            sb.Append(" AND [OnWebsite]=1 ");
            sb.Append("ORDER BY [VersionID] DESC");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
		//會傳回已發佈上線的版本---------------------------------------------------------------------------
        else
        {
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo);
            SDA.SelectCommand.Parameters.AddWithValue("@ExpendDate", ExpendDate);

            sb.Append(@"SELECT * 
                        FROM [SuggestCard].[dbo].[SC_MainData]");
            sb.Append("WHERE CareerNo=@CareerNo AND CONVERT(NVARCHAR(10),@ExpendDate,111) >=  CONVERT(NVARCHAR(10),SatisfactionTimeStr,111) ");
            sb.Append(" AND CONVERT(NVARCHAR(10),@ExpendDate,111) < ISNULL(CONVERT(NVARCHAR(10),SatisFactionTimeEnd,111),'2999/12/31' )");
            sb.Append(" AND [OnWebsite]=1 ");
            sb.Append("ORDER BY SUBSTRING( VersionID,13,3) ASC");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();

        }
        return DS;
    }
    #endregion

    #region 搜尋SC_Question:問卷題目
    public DataSet SelSC_Question(string sMainDataGUID, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@MainDataGUID", sMainDataGUID);

            sb.Append(@"SELECT [QuestionGUID],[MainDataGUID],[QuestionName],[QuestionOrder],[QuestionAnsCount],[QuestionTypeID] 
                        FROM [SuggestCard].[dbo].[SC_Question]");
            sb.Append("WHERE [MainDataGUID]=@MainDataGUID");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 搜尋View_SC_Ans:各題目下拉選單答案
    public DataSet SelSC_Ans(string sMainDataGUID, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@MainDataGUID", sMainDataGUID);

            sb.Append(@"SELECT [QuestionGUID],[QuestionTypeID],[QuestionName],[AnsGUID],[AnsName],[AnsPositionY],[AnsPositionX],[AnsCode],[AnsOrder],[AnsLocal],[IsMeal] 
                        FROM [SuggestCard].[dbo].[View_SC_Ans]");
            sb.Append("WHERE [MainDataGUID]=@MainDataGUID");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 搜尋SC_WebSatisfactionData
    public DataSet SPSelSC_WebSatisfactionData(string sMainDataGUID, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {

            SDA.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;
            SDA.SelectCommand.CommandText = "SC_WebSatisfactionData";
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@MainDataGUID", sMainDataGUID);
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }

        return DS;
    }
    #endregion

	#region 搜尋SSF_SuggestionType  :建議方向
    public DataSet SelSSF_SuggestType(string sCareerNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo);

            sb.Append(@"SELECT [SugMGUID],[CareerNo],[SugMName],[SugMOrder] 
                        FROM [SuggestCard].[dbo].[SSF_SuggestionType]");
            sb.Append("WHERE [CareerNo]=@CareerNo AND [IsDel]=0");
            sb.Append(" ORDER BY [SugMOrder]");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion
	
    #region 搜尋SSF_AnalysisMain    :建議類別 
    public DataSet SelBindSSF_AnalysisMain(string sCareerNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo);

            sb.Append(@"SELECT [AnalyMGUID],[SugMGUID],[CareerNo],[AnalyMName],[AnalyMOrder],[IsDel],[InsertTime],[InsertMan] 
                        FROM [SuggestCard].[dbo].[SSF_AnalysisMain]");
            sb.Append(@"WHERE [CareerNo]=@CareerNo AND [IsDel]=0");
            sb.Append(" ORDER BY [AnalyMOrder]");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion
 
    #region 搜尋SSF_AnalysisMain    :建議類別，只限菜色
    public DataSet SelBindSSF_AnalysisMain_onFood(string sCareerNo, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo);

            sb.Append(@"SELECT [AnalyMGUID],[SugMGUID],[CareerNo],[AnalyMName],[AnalyMOrder],[IsDel],[InsertTime],[InsertMan] 
                        FROM [SuggestCard].[dbo].[SSF_AnalysisMain]");
            sb.Append(@"WHERE [CareerNo]=@CareerNo AND [IsDel]=0 AND [iTypeID]=1");
            sb.Append(" ORDER BY [AnalyMOrder]");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion
	
    #region 搜尋SSF_AnalysisDetail  :建議品項(2015/08/24版本)
	/// <summary>
    /// 建議項目
    /// </summary>
    /// <param name="sAnalyMGUID">建議類別guid</param>
    /// <param name="sVersionID">版次後三碼</param>
    /// <returns></returns>
    public DataSet SelSSF_AnalysisDetail(string sAnalyMGUID, string sVersionID, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@AnalyMGUID", sAnalyMGUID);
            SDA.SelectCommand.Parameters.AddWithValue("@VersionID", sVersionID);

            sb.Append(@"SELECT * 
                        FROM [SuggestCard].[dbo].[SSF_AnalysisDetail]");
            sb.Append(@"WHERE  [AnalyMGUID]=@AnalyMGUID 
                        AND [VersionID]=@VersionID 
                        AND IsDel=0");          
            sb.Append(" ORDER BY [AnalyDOrder]");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion

    #region 搜尋SSF_SuggestionDetail:建議內容(2015/08/24版本)
    /// <summary>
    /// SSF_SuggestionDetail 意見細項(太甜、太油..)
    /// </summary>
    /// <param name="sAnalyMGUID">建議類別guid</param>
    /// <returns></returns>
    public DataSet SelSSF_SuggestionDetail(string sAnalyMGUID, string sVersionID, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA.SelectCommand.Parameters.Clear();
            SDA.SelectCommand.Parameters.AddWithValue("@AnalyMGUID", sAnalyMGUID);
            SDA.SelectCommand.Parameters.AddWithValue("@VersionID", sVersionID);

            sb.Append(@"SELECT * 
                        FROM [SuggestCard].[dbo].[SSF_SuggestionDetail] ");
            sb.Append(@"WHERE AnalyMGUID=@AnalyMGUID  
                        AND IsDel=0");
            sb.Append(" ORDER BY [SugDOrder] ASC");

            SDA.SelectCommand.CommandText = sb.ToString();
            SDA.Fill(DS);
            SDA.SelectCommand.Parameters.Clear();
        }
        catch (Exception ex)
        {
            sReturnMsg = ex.ToString();
        }
        return DS;
    }
    #endregion


	
	
	
	
	




    //線上建議卡資料寫入資料庫============================================================
    #region 寫入SC_RecMainData2Par:用餐資訊
    /// <summary>
    /// 新增SC_RecMainData
    /// </summary>
    /// <param name="sMainDataGUID">版次guid</param>
    /// <param name="sRecMainGUID">RecMainGUID</param>
    /// <param name="sVersionID">版次</param>
    /// <param name="sStoreNo">店別</param>
    /// <param name="sExpendDate">消費日期</param>
    /// <param name="sCName">修改人員</param>
    /// <returns></returns>
    public bool InsertSC_RecMainData2Par(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sStoreNo, string sExpendDate, string sCName, string sEatTime)
    {
        bool blReturn;
        try
        {
            SQC.CommandType = System.Data.CommandType.Text;
            SQC.CommandText = @"BEGIN
            IF NOT EXISTS (SELECT *  FROM [dbo].[SC_RecMainData2Par] WHERE RecMainGUID =@RecMainGUID)
                                    BEGIN
         INSERT INTO SC_RecMainData2Par(RecMainGUID,MainDataGUID,VersionID,StoreNo,ExpendDate,Trans,InsertTime,InsertMan,ModifyTime,ModifyMan,TransTime,TransMan,EatTime)
         VALUES(@RecMainGUID,@MainDataGUID,@VersionID,@StoreNo,@ExpendDate,@Trans,GETDATE(),@InsertMan,GETDATE(),@ModifyMan,GETDATE(),@TransMan,@EatTime)
                                    END 
                                    ELSE
                                    BEGIN
         UPDATE SC_RecMainData2Par SET MainDataGUID=@MainDataGUID,VersionID=@VersionID,StoreNo=@StoreNo,ExpendDate=@ExpendDate,
        Trans=@Trans,InsertTime=GETDATE(),InsertMan=@InsertMan,ModifyTime=GETDATE(),ModifyMan=@ModifyMan,TransTime=GETDATE(),TransMan=@TransMan,EatTime=@EatTime
        WHERE RecMainGUID= @RecMainGUID

              DELETE SC_RecAns2Par  WHERE RecMainGUID=@RecMainGUID 

                                    END

                                 END";

            SQC.Parameters.Clear();
            SQC.Parameters.AddWithValue("@RecMainGUID", sRecMainGUID);
            SQC.Parameters.AddWithValue("@MainDataGUID", sMainDataGUID);
            SQC.Parameters.AddWithValue("@VersionID", sVersionID);
            SQC.Parameters.AddWithValue("@StoreNo", sStoreNo);
            SQC.Parameters.AddWithValue("@ExpendDate", sExpendDate);
            SQC.Parameters.AddWithValue("@Trans", 0);
            SQC.Parameters.AddWithValue("@InsertMan", sCName);
            SQC.Parameters.AddWithValue("@ModifyMan", sCName);
            SQC.Parameters.AddWithValue("@TransMan", sCName);
            SQC.Parameters.AddWithValue("@EatTime", sEatTime);

            SQC.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion

    #region 寫入SC_RecAns2Par:全部意見
    /// <summary>
    /// 新增SC_RecAns
    /// </summary>
    /// <param name="sRecAnsGUID"></param>
    /// <param name="sRecMainGUID">RecMainGUID</param>
    /// <param name="sQuestionGUID"></param>
    /// <param name="sAnsGUIDGroup"></param>
    /// <param name="sAnsCodeGroup"></param>
    /// <param name="iIsSatisFaction"></param>
    /// <param name="sAnsSatisCodeGroup"></param>
    /// <returns></returns>
    public bool InsertSC_RecAns2Par(string sRecAnsGUID, string sRecMainGUID, string sQuestionGUID, string sAnsGUIDGroup, string sAnsCodeGroup, int iIsSatisFaction, string sAnsSatisCodeGroup, string sStoreNo, string sExpendDate, string sCName)
    {
        bool blReturn;
        try
        {

            SQC.CommandType = System.Data.CommandType.Text;
            SQC.CommandText = @"BEGIN
            IF NOT EXISTS ( SELECT *  FROM [dbo].[SC_RecAns2Par] Where RecMainGUID=@RecMainGUID AND QuestionGUID=@QuestionGUID AND AnsGUIDGroup=@AnsGUIDGroup)
                                    BEGIN

             INSERT INTO SC_RecAns2Par(RecAnsGUID,RecMainGUID,QuestionGUID,AnsGUIDGroup,AnsCodeGroup,IsSatisFaction,AnsSatisCodeGroup
                ,StoreNo,ExpendDate,ModifyTime,ModifyMan)
             VALUES(@RecAnsGUID,@RecMainGUID,@QuestionGUID,@AnsGUIDGroup,@AnsCodeGroup,@IsSatisFaction,@AnsSatisCodeGroup
             ,@StoreNo,@ExpendDate,GETDATE(),@ModifyMan)
                                    END 
                                    ELSE
                                    BEGIN

              UPDATE SC_RecAns2Par SET QuestionGUID=@QuestionGUID,AnsCodeGroup=@AnsCodeGroup,IsSatisFaction=@IsSatisFaction,AnsSatisCodeGroup=@AnsSatisCodeGroup
                    ,StoreNo=@StoreNo,ExpendDate=@ExpendDate,ModifyTime=GETDATE(),ModifyMan=@ModifyMan WHERE RecMainGUID=@RecMainGUID AND AnsGUIDGroup=@AnsGUIDGroup 

                                    END

                                 END";
            SQC.Parameters.Clear();
            SQC.Parameters.AddWithValue("@RecAnsGUID", sRecAnsGUID);
            SQC.Parameters.AddWithValue("@RecMainGUID", sRecMainGUID);
            SQC.Parameters.AddWithValue("@QuestionGUID", sQuestionGUID);
            SQC.Parameters.AddWithValue("@AnsGUIDGroup", sAnsGUIDGroup);
            SQC.Parameters.AddWithValue("@AnsCodeGroup", sAnsCodeGroup);
            SQC.Parameters.AddWithValue("@IsSatisFaction", iIsSatisFaction);
            SQC.Parameters.AddWithValue("@AnsSatisCodeGroup", sAnsSatisCodeGroup);
            SQC.Parameters.AddWithValue("@StoreNo", sStoreNo);
            SQC.Parameters.AddWithValue("@ExpendDate", sExpendDate);
            SQC.Parameters.AddWithValue("@ModifyMan", sCName);

            SQC.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion

	#region 寫入SC_NotMemberData
	public bool InsertSC_NotMemberData(string sNotMemberGUID,string sIQRecMGUID,string sCName,string sGender, DateTime  sBirthday,string sCareerNo,string sEmail)
        {
            bool blReturn;
            StringBuilder sb = new StringBuilder();

            try
            {
                SQC.CommandType = System.Data.CommandType.Text;
                sb.Append("INSERT INTO [dbo].[SC_NotMemberData](NotMemberGUID,IQRecMGUID,CName,Gender,Birthday,CareerNo,Email)");
                sb.Append("VALUES (@NotMemberGUID,@IQRecMGUID,@CName,@Gender,@Birthday,@CareerNo,@Email)");
                SQC.CommandText = sb.ToString();
                SQC.Parameters.Clear();

                SQC.Parameters.AddWithValue("@NotMemberGUID", sNotMemberGUID);
                SQC.Parameters.AddWithValue("@IQRecMGUID", sIQRecMGUID);
                SQC.Parameters.AddWithValue("@CName", sCName);
                SQC.Parameters.AddWithValue("@Gender", sGender);               
                SQC.Parameters.AddWithValue("@Birthday", sBirthday);
                SQC.Parameters.AddWithValue("@CareerNo", sCareerNo);
                SQC.Parameters.AddWithValue("@Email", sEmail);
				SQC.Connection.Open();
                //this.SQC.ExecuteNonQuery();
                int intResult = SQC.ExecuteNonQuery();
                SQC.Connection.Close();
                SQC.Parameters.Clear();
                if (intResult > 0)
                    blReturn = true;
                else
                    blReturn = false;
            }
            catch (Exception ex)
            {
                blReturn = false;
            }
            return blReturn;
        }
	#endregion
	
	
    #region 寫入SC_IQMainData:問券會員相關資料_紙本無
    /// <summary>
    /// 新增SC_IQMainData
    /// </summary>
    /// <param name="sMainDataGUID"></param>
    /// <param name="sRecMainGUID"></param>
    /// <param name="sVersionID"></param>
    /// <param name="sVersionName"></param>
    /// <param name="sStoreNo"></param>
    /// <param name="sExpendDate"></param>
    /// <param name="sCName"></param>
    /// <param name="sSugMGUID"></param>
    /// <param name="sDOGUID"></param>
    /// <param name="sEmail"></param>
    /// <param name="sMemberUID"></param>
    /// <param name="sInvoice"></param>
    /// <param name="sEatTime"></param>
    /// <returns></returns>
    public bool InsertSC_IQMainData(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sSugMGUID, string sDOGUID, string sEmail, string sMemberUID, string sInvoice, string sEatTime)
    {
        bool blReturn;
        try
        {


            SQC.CommandType = System.Data.CommandType.Text;
            SQC.CommandText = @"BEGIN
            IF NOT EXISTS (SELECT *  FROM [dbo].[SC_IQMainData] Where IQRecMGUID=@IQRecMGUID)
                                    BEGIN
         INSERT INTO SC_IQMainData(IQRecMGUID,StoreNo,MainDataGUID,VersionID,VersionName,EatTime,ExpendDate,RecMainGUID,SugMGUID,DOGUID,Email,MemberUID,IQInvoice,InsertTime,InsertMan)
         VALUES(@IQRecMGUID,@StoreNo,@MainDataGUID,@VersionID,@VersionName,@EatTime,@ExpendDate,@RecMainGUID,@SugMGUID,@DOGUID,@Email,@MemberUID,@IQInvoice,GETDATE(),@InsertMan)
                                    END 
                                    ELSE
                                    BEGIN
         UPDATE SC_IQMainData SET  StoreNo=@StoreNo,MainDataGUID=@MainDataGUID,VersionID=@VersionID,VersionName=@VersionName,EatTime=@EatTime
                ,ExpendDate=@ExpendDate,RecMainGUID=@RecMainGUID,SugMGUID=@SugMGUID,DOGUID=@DOGUID,Email=@Email
                  ,MemberUID=@MemberUID,IQInvoice=@IQInvoice,InsertTime=GETDATE(),InsertMan=@InsertMan
        WHERE IQRecMGUID= @RecMainGUID


                                    END

                                 END";

            SQC.Parameters.Clear();
            SQC.Parameters.AddWithValue("IQRecMGUID", sRecMainGUID);
            SQC.Parameters.AddWithValue("StoreNo", sStoreNo);
            SQC.Parameters.AddWithValue("MainDataGUID", sMainDataGUID);
            SQC.Parameters.AddWithValue("VersionID", sVersionID);
            SQC.Parameters.AddWithValue("VersionName", sVersionName);
            SQC.Parameters.AddWithValue("EatTime", sEatTime);
            SQC.Parameters.AddWithValue("ExpendDate", sExpendDate);
            SQC.Parameters.AddWithValue("RecMainGUID", sRecMainGUID);
            SQC.Parameters.AddWithValue("SugMGUID", sSugMGUID);
            SQC.Parameters.AddWithValue("DOGUID", sDOGUID);
            SQC.Parameters.AddWithValue("Email", sEmail);
            SQC.Parameters.AddWithValue("MemberUID", sMemberUID);
            SQC.Parameters.AddWithValue("IQInvoice", sInvoice);
            SQC.Parameters.AddWithValue("InsertMan", sCName);
            SQC.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion

    #region 寫入SSF_Daily_OtherSuggest:其他意見_紙本無
    /// <summary>
    /// 新增SSF_Daily_OtherSuggest
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
    /// <returns></returns>
    public bool InsertSSF_Daily_OtherSuggest(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sDOGUID, string sSugType, string sSuggest, string sAnalyMGUID)
    {
        bool blReturn;
        try
        {


            SQC.CommandType = System.Data.CommandType.Text;
            SQC.CommandText = @"BEGIN
            IF NOT EXISTS (SELECT *  FROM [dbo].[SSF_Daily_OtherSuggest] Where DOGUID= @DOGUID)
                                    BEGIN
         INSERT INTO SSF_Daily_OtherSuggest(DOGUID,DailyGUID,CareerNo,ExpendDate,VersionID,VersionName,AnalyMGUID,AnalyDGUID,SugDGUID,SugMGUID,SugTypeMNo,SugTypeDNo,SugCount,SugNote,InsertTime,InsertMan)
         VALUES(@DOGUID,@DailyGUID,@CareerNo,@ExpendDate,@VersionID,@VersionName,@AnalyMGUID,@AnalyDGUID,@SugDGUID,@SugMGUID,@SugTypeMNo,@SugTypeDNo,@SugCount,@SugNote,GETDATE(),@InsertMan)
                                    END 
                                    ELSE
                                    BEGIN
         UPDATE SSF_Daily_OtherSuggest SET DailyGUID=@DailyGUID,CareerNo=@CareerNo,ExpendDate=@ExpendDate,VersionID=@VersionID,VersionName=@VersionName,AnalyMGUID=@AnalyMGUID
        ,AnalyDGUID=@AnalyDGUID,SugDGUID=@SugDGUID,SugMGUID=@SugMGUID,SugTypeMNo=@SugTypeMNo,SugTypeDNo=@SugTypeDNo,SugCount=@SugCount,SugNote=@SugNote,InsertTime=GETDATE(),InsertMan=@InsertMan
        WHERE DOGUID= @DOGUID
                                    END

                                 END";

            SQC.Parameters.Clear();
            SQC.Parameters.AddWithValue("DOGUID", sDOGUID);
            SQC.Parameters.AddWithValue("DailyGUID", sRecMainGUID);
            SQC.Parameters.AddWithValue("CareerNo", sStoreNo);
            SQC.Parameters.AddWithValue("ExpendDate", sExpendDate);
            SQC.Parameters.AddWithValue("VersionID", sVersionID);
            SQC.Parameters.AddWithValue("VersionName", sVersionName);
            SQC.Parameters.AddWithValue("AnalyMGUID", sAnalyMGUID.Trim());
            SQC.Parameters.AddWithValue("AnalyDGUID", "");
            SQC.Parameters.AddWithValue("SugDGUID", "");
            SQC.Parameters.AddWithValue("SugMGUID", sSugType);
            SQC.Parameters.AddWithValue("SugTypeMNo", "");
            SQC.Parameters.AddWithValue("SugTypeDNo", "");
            SQC.Parameters.AddWithValue("SugCount", 1);
            SQC.Parameters.AddWithValue("SugNote", sSuggest);
            SQC.Parameters.AddWithValue("InsertMan", sCName);
            SQC.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion

    #region 寫入SSF_Daily_OtherSuggest:其他意見_紙本無(2015.8.24版本)
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
    /// <returns></returns>
    public bool InsertSSF_Daily_OtherSuggest(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sDOGUID, string sSugType, string sSuggest, string sAnalyMGUID, string sAnalyDGUID, string sSugDetail)
    {
        bool blReturn;
        try
        {
            SQC.CommandType = System.Data.CommandType.Text;
            SQC.CommandText = @"BEGIN
            IF NOT EXISTS (SELECT *  FROM [dbo].[SSF_Daily_OtherSuggest] Where DOGUID= @DOGUID)
                                    BEGIN
         INSERT INTO SSF_Daily_OtherSuggest(DOGUID,DailyGUID,CareerNo,ExpendDate,VersionID,VersionName,AnalyMGUID,AnalyDGUID,SugDGUID,SugMGUID,SugTypeMNo,SugTypeDNo,SugCount,SugNote,InsertTime,InsertMan)
         VALUES(@DOGUID,@DailyGUID,@CareerNo,@ExpendDate,@VersionID,@VersionName,@AnalyMGUID,@AnalyDGUID,@SugDGUID,@SugMGUID,@SugTypeMNo,@SugTypeDNo,@SugCount,@SugNote,GETDATE(),@InsertMan)
                                    END 
                                    ELSE
                                    BEGIN
         UPDATE SSF_Daily_OtherSuggest SET DailyGUID=@DailyGUID,CareerNo=@CareerNo,ExpendDate=@ExpendDate,VersionID=@VersionID,VersionName=@VersionName,AnalyMGUID=@AnalyMGUID
        ,AnalyDGUID=@AnalyDGUID,SugDGUID=@SugDGUID,SugMGUID=@SugMGUID,SugTypeMNo=@SugTypeMNo,SugTypeDNo=@SugTypeDNo,SugCount=@SugCount,SugNote=@SugNote,InsertTime=GETDATE(),InsertMan=@InsertMan
        WHERE DOGUID= @DOGUID
                                    END

                                 END";

            SQC.Parameters.Clear();
            SQC.Parameters.AddWithValue("DOGUID", sDOGUID);
            SQC.Parameters.AddWithValue("DailyGUID", sRecMainGUID);
            SQC.Parameters.AddWithValue("CareerNo", sStoreNo);
            SQC.Parameters.AddWithValue("ExpendDate", sExpendDate);
            SQC.Parameters.AddWithValue("VersionID", sVersionID);
            SQC.Parameters.AddWithValue("VersionName", sVersionName);
            SQC.Parameters.AddWithValue("AnalyMGUID", sAnalyMGUID.Trim());
            SQC.Parameters.AddWithValue("AnalyDGUID", sAnalyDGUID.Trim());
            SQC.Parameters.AddWithValue("SugDGUID", sSugDetail);
            SQC.Parameters.AddWithValue("SugMGUID", sSugType);
            SQC.Parameters.AddWithValue("SugTypeMNo", sSugType);
            SQC.Parameters.AddWithValue("SugTypeDNo", sSugDetail);
            SQC.Parameters.AddWithValue("SugCount", 1);
            SQC.Parameters.AddWithValue("SugNote", sSuggest);
            SQC.Parameters.AddWithValue("InsertMan", sCName);
            SQC.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion
 
    #region 寫入SC_ProductSugguest:喜惡三道_紙本無
	/*  [ProdSugGUID]--key值
		[RecMainGUID]--關聯用
		[AnsGUID]    --項目GUID
		[AnsName]    --項目
		[SugNote]    --菜色
		[InsertTime] --寫入時間
		[InsertMan]  --
		[CareerNo]   --事業處
		[iType]      --用途 */
    public bool InsertSC_ProductSugguest(string sProdSugGUID, string sRecMainGUID, string sAnsGUID, string sAnsName, string sSugNote, string sCareerNo, string siType, string sStoreNo, string sExpendDate)
    {
        bool blReturn;
        try
        {
            SQC.CommandType = System.Data.CommandType.Text;
            SQC.CommandText = @"BEGIN
            IF NOT EXISTS (SELECT *  FROM [dbo].[SC_ProductSugguest] Where ProdSugGUID= @ProdSugGUID)
									BEGIN
										INSERT INTO [SC_ProductSugguest] (ProdSugGUID,RecMainGUID,AnsGUID,AnsName,SugNote,CareerNo,iType,StoreNo,ExpendDate,InsertTime)
									                              VALUES(@ProdSugGUID,@RecMainGUID,@AnsGUID,@AnsName,@SugNote,@CareerNo,@iType,@StoreNo,@ExpendDate,GETDATE())
									END 
                                    ELSE
										BEGIN
										UPDATE [SC_ProductSugguest] 
										SET RecMainGUID=@RecMainGUID,AnsGUID=@AnsGUID,AnsName=@AnsName,SugNote=@SugNote,CareerNo=@CareerNo,iType=@iType,StoreNo=@StoreNo,ExpendDate=@ExpendDate,InsertTime=GETDATE()
										WHERE ProdSugGUID= @ProdSugGUID
									END

									END";

            SQC.Parameters.Clear();
            SQC.Parameters.AddWithValue("ProdSugGUID", sProdSugGUID);//key值
            SQC.Parameters.AddWithValue("RecMainGUID", sRecMainGUID);//關聯用
            SQC.Parameters.AddWithValue("AnsGUID", sAnsGUID);//項目GUID
            SQC.Parameters.AddWithValue("AnsName", sAnsName);//項目
            SQC.Parameters.AddWithValue("SugNote", sSugNote);//菜色
            SQC.Parameters.AddWithValue("CareerNo", sCareerNo);//事業處
            SQC.Parameters.AddWithValue("iType", siType);//用途
            SQC.Parameters.AddWithValue("StoreNo", sStoreNo);//用餐店鋪
            SQC.Parameters.AddWithValue("ExpendDate", sExpendDate);//用餐日期

            SQC.Connection.Open();
            //this.SQC.ExecuteNonQuery();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
	#endregion
 
 
 
    //線上建議卡更新資料庫====================================================================
    #region 更新SC_IQMainData:問券會員相關資料_紙本無
    public bool UpdSC_IQMainData(string sIQRecMGUID, string sEmail, string sMemberUID, string sInsertMan)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();

        try
        {
            SQC.CommandType = System.Data.CommandType.Text;
            sb.Append("UPDATE [dbo].[SC_IQMainData] SET Email=@Email,MemberUID=@MemberUID,InsertMan=@InsertMan");
            sb.Append(" WHERE IQRecMGUID=@IQRecMGUID");
            SQC.CommandText = sb.ToString();
            SQC.Parameters.Clear();

            SQC.Parameters.AddWithValue("@IQRecMGUID", sIQRecMGUID);//KEY值
            SQC.Parameters.AddWithValue("@Email", sEmail);
            SQC.Parameters.AddWithValue("@MemberUID", sMemberUID);
            SQC.Parameters.AddWithValue("@InsertMan", sInsertMan);

            SQC.Connection.Open();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion

	#region 更新SC_IQMainData:問券會員相關資料_紙本無
    public bool UpdSC_IQMainData(string sIQRecMGUID, string sEmail)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();

        try
        {
            SQC.CommandType = System.Data.CommandType.Text;
            sb.Append("UPDATE [dbo].[SC_IQMainData] SET Email=@Email");
            sb.Append(" WHERE IQRecMGUID=@IQRecMGUID");
            SQC.CommandText = sb.ToString();
            SQC.Parameters.Clear();

            SQC.Parameters.AddWithValue("@IQRecMGUID", sIQRecMGUID);//KEY值
            SQC.Parameters.AddWithValue("@Email", sEmail);

            SQC.Connection.Open();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion
	
    #region 更新SC_RecAns2Par
    public bool UpdSC_RecAns2Par(string sRecAnsGUID, string sAnsGUIDGroup, string sAnsCodeGroup)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();

        try
        {
            SQC.CommandType = System.Data.CommandType.Text;
            sb.Append("UPDATE [dbo].[SC_RecAns2Par] SET AnsGUIDGroup=@AnsGUIDGroup,AnsCodeGroup=@AnsCodeGroup");
            sb.Append(" WHERE RecAnsGUID=@RecAnsGUID");
            SQC.CommandText = sb.ToString();
            SQC.Parameters.Clear();

            SQC.Parameters.AddWithValue("@RecAnsGUID", sRecAnsGUID);//KEY值
            SQC.Parameters.AddWithValue("@AnsGUIDGroup", sAnsGUIDGroup);
            SQC.Parameters.AddWithValue("@AnsCodeGroup", sAnsCodeGroup);

            SQC.Connection.Open();
            int intResult = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            if (intResult > 0)
                blReturn = true;
            else
                blReturn = false;
        }
        catch (Exception ex)
        {
            blReturn = false;
        }
        return blReturn;
    }
    #endregion
}
