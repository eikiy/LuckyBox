using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Data;
using System.Web.UI.WebControls;
/// <summary>
/// blSuggestCard 的摘要描述
/// </summary>
public class blSuggestCard
{

    dbSuggestCard DBSuggestCard = new dbSuggestCard();
    public blSuggestCard()
    {
        //
        // TODO: 在此加入建構函式的程式碼
        //
    }


    //0900意見調查========================================================================
    //搜尋ALL事業處
    public static void BindCareer(DropDownList ddl)
    {
        dbSuggestCard DBSuggestCard_BindCareer = new dbSuggestCard();//要再宣告一次

        DataSet DS = new DataSet();
        string sReturnMsg;
        DS = DBSuggestCard_BindCareer.Sel_Career(out sReturnMsg);

        ddl.DataSource = DS;
        ddl.DataMember = "table";
        ddl.DataTextField = "CareerName";
        ddl.DataValueField = "CareerNo";
        ddl.DataBind();
        if (DS.Tables[0].Rows.Count != 1)
            ddl.Items.Insert(0, new ListItem("請選擇", ""));
    }

    public bool InsertSC_workersSuggestion(string sCareer, string sSubject, string sName, string sEmail, string sContext, string sRecno, string sIP)
    {
        return DBSuggestCard.InsertSC_workersSuggestion(sCareer, sSubject, sName,  sEmail,  sContext, sRecno, sIP);
    }




    //線上建議卡基本用餐資訊讀取資料庫====================================================
    //搜尋StoreView:店鋪下拉選單
    public static void BindStore(DropDownList ddl, string strStoreNo)
    {
        dbSuggestCard DBSuggestCard_BindStore = new dbSuggestCard();//要再宣告一次

        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBSuggestCard_BindStore.Sel_StoreView(strStoreNo, out sReturnMsg);

        ddl.DataSource = DS;
        ddl.DataMember = "table";
        ddl.DataTextField = "StoreName";
        ddl.DataValueField = "StoreNo";
        ddl.DataBind();
        if (DS.Tables[0].Rows.Count != 1)
            ddl.Items.Insert(0, new ListItem("請選擇", ""));
    }

    //搜尋SC_ParameterItems:消費時間
    public static void BindTime(DropDownList dropTime, string strStoreNo)
    {
        dbSuggestCard DBSuggestCard_BindTime = new dbSuggestCard();//要再宣告一次

        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBSuggestCard_BindTime.Sel_SC_ParameterItems(strStoreNo, out sReturnMsg);

        dropTime.DataSource = DS;
        dropTime.DataMember = "table";
        dropTime.DataTextField = "PItemName";
        dropTime.DataValueField = "PItemCode";
        dropTime.DataBind();
        dropTime.Items.Insert(0, new ListItem("請選擇", ""));
    }








    //線上建議卡相關題目讀取資料庫========================================================
    //搜尋SC_MainData:BindVersionID
    public DataTable BindVersionID(string Career, string ExpendDate, bool blIsAll, bool blIsCareerOnly)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelSC_MainData(Career, ExpendDate, blIsAll, blIsCareerOnly);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }

    //搜尋SC_Question
    public DataTable BindSC_Question(string sMainDataGUID, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelSC_Question(sMainDataGUID, out sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }

    //搜尋View_SC_Ans:各種題目下拉選單
    public DataTable BindSC_Ans(string sMainDataGUID, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelSC_Ans(sMainDataGUID, out sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }

    //搜尋SSF_SuggestionType
    public DataTable BindSSF_SuggestType(string sCareerNo, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelSSF_SuggestType(sCareerNo, out sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }

    //搜尋SC_WebSatisfactionData
    public DataTable BindSC_Satisfaction(string sMainDataGUID, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SPSelSC_WebSatisfactionData(sMainDataGUID, out sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }



    //搜尋SelBindSSF_AnalysisMain
    public DataTable BindSSF_AnalysisMain(string sCareerNo, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelBindSSF_AnalysisMain(sCareerNo, out  sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }
	
	//搜尋SelBindSSF_AnalysisMain_onFood
    public DataTable BindSSF_AnalysisMain_onFood(string sCareerNo, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelBindSSF_AnalysisMain_onFood(sCareerNo, out  sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }

    //搜尋SelSSF_AnalysisDetail
    public DataTable BindSSF_AnalysisDetail(string sAnalyMGUID, string sVersionID, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelSSF_AnalysisDetail(sAnalyMGUID, sVersionID, out  sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }

    //搜尋SelSSF_SuggestionDetail
    public DataTable BindSSF_SuggestionDetail(string sAnalyMGUID, string sVersionID, out string sReturnMsg)
    {
        DataSet DS = new DataSet();
        DS = DBSuggestCard.SelSSF_SuggestionDetail(sAnalyMGUID, sVersionID, out  sReturnMsg);

        DataTable DT = DS.Tables["table"];//1; table取名字
        return DT;
    }







    //線上建議卡資料寫入資料庫============================================================
    //寫入SC_RecMainData2Par:用餐資訊
    public bool InsertSC_RecMainData2Par(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sStoreNo, string sExpendDate, string sCName, string sEatTime)
    {
        return DBSuggestCard.InsertSC_RecMainData2Par(sMainDataGUID, sRecMainGUID, sVersionID, sStoreNo, sExpendDate, sCName, sEatTime);
    }

    //寫入SC_RecAns2Par:全部意見
    public bool InsertSC_RecAns2Par(string sRecAnsGUID, string sRecMainGUID, string sQuestionGUID, string sAnsGUIDGroup, string sAnsCodeGroup, int iIsSatisFaction, string sAnsSatisCodeGroup, string sStoreNo, string sExpendDate, string sCName)
    {
        return DBSuggestCard.InsertSC_RecAns2Par(sRecAnsGUID, sRecMainGUID, sQuestionGUID, sAnsGUIDGroup, sAnsCodeGroup, iIsSatisFaction, sAnsSatisCodeGroup, sStoreNo, sExpendDate, sCName);
    }


    //寫入SC_NotMemberData
    public bool InsertSC_NotMemberData(string sNotMemberGUID, string sIQRecMGUID, string sCName, string sGender, DateTime sBirthday, string sCareerNo, string sEmail)
    {
        return DBSuggestCard.InsertSC_NotMemberData(sNotMemberGUID, sIQRecMGUID, sCName, sGender, sBirthday, sCareerNo, sEmail);
    }

    //寫入SC_IQMainData:問券會員相關資料_紙本無
    public bool InsertSC_IQMainData(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sSugMGUID, string sDOGUID, string sEmail, string sMemberUID, string sInvoice, string sEatTime)
    {
        return DBSuggestCard.InsertSC_IQMainData(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, sSugMGUID, sDOGUID, sEmail, sMemberUID, sInvoice, sEatTime);
    }

    //寫入SSF_Daily_OtherSuggest:其他意見_紙本無
    public bool InsertSSF_Daily_OtherSuggest(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sDOGUID, string sSugType, string sSuggest, string sAnalyMGUID)
    {
        return DBSuggestCard.InsertSSF_Daily_OtherSuggest(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, sDOGUID, sSugType, sSuggest, sAnalyMGUID);
    }

    //寫入SSF_Daily_OtherSuggest:其他意見_紙本無(2015.8.24版本)
    public bool InsertSSF_Daily_OtherSuggest(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sDOGUID, string sSugType, string sSuggest, string sAnalyMGUID, string sAnalyDGUID, string sSugDetail)
    {
        return DBSuggestCard.InsertSSF_Daily_OtherSuggest(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, sDOGUID, sSugType, sSuggest, sAnalyMGUID, sAnalyDGUID, sSugDetail);
    }


	//寫入SC_ProductSugguest:喜惡三道_紙本無
    public bool InsertSC_ProductSugguest(string sProdSugGUID, string sRecMainGUID, string sAnsGUID, string sAnsName, string sSugNote, string sCareerNo, string siType, string sStoreNo, string sExpendDate)
    {
        return DBSuggestCard.InsertSC_ProductSugguest(sProdSugGUID, sRecMainGUID, sAnsGUID, sAnsName, sSugNote, sCareerNo, siType, sStoreNo, sExpendDate);
    }




    //線上建議卡資料更新======================================================================
    //用餐資訊
    public bool UpdSC_IQMainData(string sIQRecMGUID, string sEmail, string sMemberUID, string sInsertMan)
    {
        return DBSuggestCard.UpdSC_IQMainData(sIQRecMGUID, sEmail, sMemberUID, sInsertMan);
    }

    public bool UpdSC_IQMainData(string sIQRecMGUID, string sEmail)
    {
        return DBSuggestCard.UpdSC_IQMainData(sIQRecMGUID, sEmail);
    }

    //全部意見
    public bool UpdSC_RecAns2Par(string sRecAnsGUID, string sAnsGUIDGroup, string sAnsCodeGroup)
    {
        return DBSuggestCard.UpdSC_RecAns2Par(sRecAnsGUID, sAnsGUIDGroup, sAnsCodeGroup);
    }
}