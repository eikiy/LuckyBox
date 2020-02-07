using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Data;
using System.Xml;

/// <summary>
/// blAction 的摘要描述
/// </summary>
public class blAction
{
    #region 共用參數
    Sql s = new Sql();
    Public _Public = new Public();
    #endregion

    #region 共用參數
    dbAction DBAction = new dbAction();
    public blAction()
    {
        //
        // TODO: 在此加入建構函式的程式碼
        //
    }
    #endregion



    #region [xxx_members]
    //[會員資料表]========================================================================================
    //string
    #region 找該uid的啟動日期(2015.1.1新增foe不贈送啟動禮)
    public string Wow_GetMemberData_20150101(string sCareerName, string suid)//收(事業處名+uid)回傳(啟動時間)
    {
        string xmlString = "";

        string sReturnMsg = "";
        DataSet DS = new DataSet();

        DS = DBAction.Sel_Members_GetMemberData(sCareerName, suid, out sReturnMsg);
        xmlString = DateTime.Parse(DS.Tables[0].Rows[0]["啟動時間"].ToString().Trim()).ToString("yyyy/MM/dd");


        return xmlString;
    }
    #endregion


    #endregion


    #region [wang_action]

    //[活動資料庫]基本設定==============================================================================
    //string
    #region 確認活動是否開始/結束CheckActionDate123
    /// 收事業處&活動編號
    /// return 顯示的字幕
    public string CheckActionDate1(string strCareer, string strAction_No)
    {
        string strMes = "";
        string sReturnMsg = "";

        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangAction(strCareer, strAction_No, out sReturnMsg);


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

    public string CheckActionDate2(string strCareer, string strAction_No, out string Action_PostDate)
    {
        string strMes = "";
        Action_PostDate = "";
        string sReturnMsg = "";

        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangAction(strCareer, strAction_No, out sReturnMsg);

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
        Action_PostDate = dateStart.ToString();
        return strMes;
    }

    public string CheckActionDate3(string strCareer, string strAction_No, ref DataSet DSReturn)
    {
        string sError = "";
        string sReturnMsg = "";

        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangAction(strCareer, strAction_No, out sReturnMsg);


        if (DS.Tables[0].Rows.Count <= 0)
        {
            sError = "系統發生異常，請洽系統管理人員!";
            return sError;
        }
        DSReturn = new DataSet();
        DSReturn = DS;

        DateTime dateStart = DateTime.Parse(DS.Tables[0].Rows[0]["Action_PostDate"].ToString() == "" ? "2000/1/1" : DS.Tables[0].Rows[0]["Action_PostDate"].ToString());
        DateTime dateEnd = DateTime.Parse(DS.Tables[0].Rows[0]["Action_CloseDate"].ToString() == "" ? "2999/1/1" : DS.Tables[0].Rows[0]["Action_CloseDate"].ToString());
        if (dateStart > DateTime.Now)
        {
            sError = "活動尚未開始~~感謝您的愛護!!";
        }
        if (dateEnd < DateTime.Now)
        {
            sError = "活動已經結束囉~~感謝您的愛護!!";
        }

        return sError;
    }

    #endregion

    //int
    #region 檢查活動一天只能登入一次BindTotalCountByDay
    /// 收活動編號、email、輸入的時間
    /// returns:大於1代表當日已參加過
    public int BindTotalCountByDay(string sAction_NO, string sEmail, string sInputtime)
    {
        int iTCount = 0;
        string sReturnMsg = "";

        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers(sAction_NO, sEmail, sInputtime, out sReturnMsg);
        iTCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());

        return iTCount;
    }
    #endregion

    #endregion


    #region [wang_action_members]

    //[活動登入紀錄表:寫入]================================================================================
    //bool
    #region 寫入資料庫[登入]
    public bool InsertWangActionMembers_login(string sCareer, string sAction_No, string sUid, string sEmail)
    {
        return DBAction.Insert_WangActionMembers(sCareer, sAction_No, sUid, sEmail);
    }
    #endregion

    //bool
    #region 寫入資料庫[填資料+1]
    public bool InsertWangActionMembers_input(string sCareer, string sAction_No, string sUid, string sEmail, string Value1)
    {
        return DBAction.Insert_WangActionMembers1(sCareer, sAction_No, sUid, sEmail, Value1);
    }
    #endregion

    #region 寫入資料庫[非會員填資料+1+2+3]
    public bool InsertWangActionMembers_UNinput(string sCareer, string sAction_No, string Value1, string Value2, string Value3)
    {
        return DBAction.Insert_WangActionMembers3_2(sCareer, sAction_No, Value1, Value2, Value3);
    }
    #endregion

    //bool
    #region 寫入資料庫[留言+1+2+3]
    public bool InsertWangActionMembers_message(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3)
    {
        return DBAction.Insert_WangActionMembers3(sCareer, sAction_No, sUid, sEmail, Value1, Value2, Value3);
    }
    #endregion

    //bool
    #region 寫入資料庫[發票+1+2+3+5]
    //[value1:發票日期  value2:發票號碼   value3:消費客數 value5:消費金額]
    public bool InsertWangActionMembers_Invoice(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3, string Value5)
    {
        return DBAction.Insert_WangActionMembers4(sCareer, sAction_No, sUid, sEmail, Value1, Value2, Value3, Value5);
    }
    #endregion

    //bool
    #region 寫入資料庫[建議卡+1+2+3+6]
    public bool InsertWangActionMembers_SuggestCard(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3, string Value6)
    {
        return DBAction.Insert_WangActionMembers4_2(sCareer, sAction_No, sUid, sEmail, Value1, Value2, Value3, Value6);
    }
    #endregion

    //bool
    #region 寫入資料庫[all]
    public bool InsertWangActionMembers_all(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12)
    {
        return DBAction.Insert_WangActionMembersALL(sCareer, sAction_No, sUid, sEmail, Value1, Value2, Value3, Value4, Value5, Value6, Value7, Value8, Value9, Value10, Value11, Value12);
    }
    #endregion





    //[活動登入紀錄表:查詢_發票類]==================================================================================
    //bool
    #region 發票檢查重複性(1)[活動資料庫]一張發票可以多人登入
    /// 收[事業處][活動編號][發票][VALUE][email]
    /// returns: TRUE:已登錄 FALSE:未登錄
    public bool CheckInvoice1(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName, string sEmail)
    {
        bool blReturn = false;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers(sCareerName, sAction_NO, sInvoice, sCloumnName, sEmail, out sReturnMsg);
        if (DS.Tables[0].Rows.Count > 0)
            blReturn = true;

        return blReturn;
    }
    #endregion

    //bool
    #region 發票檢查重複性(2)[活動資料庫]一張發票只能登入一次
    /// 收事業處、活動編號、發票、VALUE
    /// returns: TRUE:已登錄 FALSE:未登錄
    public bool CheckInvoice2(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName)
    {
        bool blReturn = false;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers(sCareerName, sAction_NO, sInvoice, sCloumnName, out sReturnMsg);
        if (DS.Tables[0].Rows.Count > 0)
            blReturn = true;

        return blReturn;
    }
    #endregion

    //bool
    #region 發票檢查重複性(3) 410小資年菜外帶發票檢查是否重複[even資料庫]
    /// 使用[even資料庫]
    /// 收事業處編號、發票
    /// returns: TRUE:已登錄 FALSE:未登錄
    public bool CheckInvoice3(string sCareerNo, string sInvoice)
    {
        bool blReturn = false;
        int sume = 0;

        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_Event(sCareerNo, sInvoice, out sReturnMsg);
        if (DS.Tables[0].Rows.Count > 0)
        {
            sume = Int32.Parse(DS.Tables[0].Rows[0]["總計"].ToString());//抓資料表ds裡面的”總計”欄位
            if (sume > 0)
                blReturn = true;
        }

        return blReturn;
    }
    #endregion

    //bool
    #region 憑證檢查重複性(4)比對同一登入者，兩個欄位
    /// 收[事業處][活動編號][發票][VALUE][email][消費日期][VALUE2]
    /// returns: TRUE:已登錄 FALSE:未登錄
    public bool CheckInvoice4(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName, string sEmail, string sDay, string sCloumnName2)
    {
        bool blReturn = false;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers(sCareerName, sAction_NO, sInvoice, sCloumnName, sEmail, sDay, sCloumnName2, out sReturnMsg);
        if (DS.Tables[0].Rows.Count > 0)
            blReturn = true;

        return blReturn;
    }
    #endregion


    //int
    #region 計算發票抽獎累計次數
    public int BindtableCount(string sAction_No, string sEmail, string sCloumnName)
    {
        int iTCount = 0;
        try
        {
            string sReturnMsg = "";
            DataSet DS = new DataSet();
            DS = DBAction.Sel_WangActionMembers_countRaffle(sAction_No, sEmail, sCloumnName, out sReturnMsg);
            iTCount = int.Parse(DS.Tables["table"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["table"].Rows[0]["Icount"].ToString());
        }
        catch (Exception ex)
        {
        }

        return iTCount;
    }
    #endregion



    //[活動登入紀錄表:查詢_留言類]===================================================================================
    //DataSet
    #region 留言內容顯示
    public DataSet Sel_WangActionMembers_message(string sAction_No, string sCareer, out string sReturnMsg)
    {
        return DBAction.Sel_WangActionMembers(sAction_No, sCareer, out sReturnMsg);
    }
    #endregion




    //[活動登入紀錄表:查詢_參加次數]===============================================================================

    //int
    #region 計算該活動總人數(回傳數字)BindTotalCount
    /// 收活動代碼
    /// returns:iTCount總數
    public int BindTotalCount(string sAction_No)
    {
        int iTCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_count(sAction_No, out sReturnMsg);
        if (DS.Tables[0].Rows.Count > 0)
            iTCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());


        return iTCount;
    }
    #endregion

    //int
    #region 計算該活動email帳號重複次數(回傳數字)BindEmailCount
    /// 收活動編號、email
    /// 回傳email在資料庫的總和
    public int BindEmailCount(string sAction_NO, string sEmail)
    {
        int iTCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_countEmail(sAction_NO, sEmail, out sReturnMsg);
        iTCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());

        return iTCount;
    }
    #endregion

    //int
    #region 計算該活動特定欄位(手機)重複次數(回傳數字)BindValueCount/BindValueCount2
    /// 收活動編號、欄位、欄位值
    /// 回傳欄位值在資料庫的總和
    public int BindValueCount(string sAction_NO, string sCloumnName, string sData)
    {
        int iTCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_countValue(sAction_NO, sCloumnName, sData, out sReturnMsg);
        iTCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());

        return iTCount;
    }


    /// 收活動編號、欄位*2、欄位值*2
    /// 回傳欄位值在資料庫的總和
    public int BindValueCount2(string sAction_NO, string sCloumnName, string sData, string sCloumnName2, string sData2)
    {
        int iTCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_countValue(sAction_NO, sCloumnName, sData, sCloumnName2, sData2, out sReturnMsg);
        iTCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());

        return iTCount;
    }
    #endregion





    //[活動登入紀錄表:查詢_特殊活動]================================================================================

    //int
    #region 該活動email是否中獎過"value1"0/1(回傳數字)BindEmailWinCount......2015.02for原燒兒盟活動
    ///  回傳符合條件的是否>1(條件:活動編號/email/valueN=1)
    public int BindEmailWinCount(string sAction_NO, string sEmail, string sCloumnName)
    {
        int winCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_EmailWinCount(sAction_NO, sEmail, sCloumnName, out sReturnMsg);
        winCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());

        return winCount;
    }
    #endregion

    //int
    #region 該活動、該場人數加總(回傳數字)BindTotalCount_people.....2015.05 for藝奇浴衣活動報名
    ///收活動編號、人數欄位、場地欄位、場地值
    ///回傳單場人數總和
    public int BindTotalCount_people(string sAction_NO, string sCloumnName_SUM, string sCloumnName, string sStage)
    {
        int iTCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_PeopleCount(sAction_NO, sCloumnName_SUM, sCloumnName, sStage, out sReturnMsg);
        iTCount = int.Parse(DS.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["Icount"].ToString());

        return iTCount;
    }
    #endregion

    //int
    #region 該活動、特定場次、報名成功'組數'(回傳數字)BindTotalCount_okset.....2015.06 for藝奇浴衣活動報名
    ///收活動編號、欄位值1、欄位值7
    ///回傳成功組數總和
    public int BindTotalCount_WaitSet(string sAction_NO, string sValue1, string sValue7)
    {
        int iTCount = 0;
        string sReturnMsg = "";
        DataSet DS = new DataSet();
        DS = DBAction.Sel_WangActionMembers_PeopleCountSet(sAction_NO, sValue1, sValue7, out sReturnMsg);
        iTCount = int.Parse(DS.Tables["list"].Rows[0]["總和"].ToString() == "" ? "0" : DS.Tables["list"].Rows[0]["總和"].ToString());

        return iTCount;
    }
    #endregion


    #endregion




    //098177*************************************************************************************************//	 
	














    /// <summary>
    /// 檢查總參加人數
    /// </summary>
    public bool BindTotalCount372()
    {
        bool blReturn = false;
        try
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("<sql>");
            sb1.Append("<select>");
            sb1.Append("<list><![CDATA[SELECT SUM(CNT) Icount FROM (select CASE WHEN value5='' THEN 1 ELSE 2 END AS CNT from wang_action_members where Action_NO=@Action_NO AND value7=1)BB ]]>");
            sb1.Append(s.ParamXML("Action_NO", "372"));
            sb1.Append("</list>");
            sb1.Append("</select>");
            sb1.Append("</sql>");
            string sError = "";
            DataSet DS2 = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);
            
            int iTCount = int.Parse(DS2.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS2.Tables["list"].Rows[0]["Icount"].ToString());
            //*************總參加人數(iFinishCount)************
            int iFinishCount = 40;
          
          
            //接受總人數加1的數量
            if ((iTCount) <= (iFinishCount - 1))
            {
                blReturn = true;              
            }
            else
                blReturn = false;



        }
        catch (Exception ex)
        {


        }
        return blReturn;
    }

    public int BindTotal372()
    {
        int iTCount = 0;
        try
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("<sql>");
            sb1.Append("<select>");
            sb1.Append("<list><![CDATA[SELECT SUM(CNT) Icount FROM (select CASE WHEN value5='' THEN 1 ELSE 2 END AS CNT from wang_action_members where Action_NO=@Action_NO AND value7=1)BB ]]>");
            sb1.Append(s.ParamXML("Action_NO", "372"));
            sb1.Append("</list>");
            sb1.Append("</select>");
            sb1.Append("</sql>");
            string sError = "";
            DataSet DS2 = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);

            iTCount = int.Parse(DS2.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS2.Tables["list"].Rows[0]["Icount"].ToString());
           
        }
        catch (Exception ex)
        {


        }
        return iTCount;
    }
 
    public int BindCount372()
    {
        int iTCount = 0;
        try
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("<sql>");
            sb1.Append("<select>");
            sb1.Append("<list><![CDATA[SELECT COUNT(*) Icount FROM wang_action_members where Action_NO=@Action_NO  ]]>");
            sb1.Append(s.ParamXML("Action_NO", "372"));
            sb1.Append("</list>");
            sb1.Append("</select>");
            sb1.Append("</sql>");
            string sError = "";
            DataSet DS2 = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);

            iTCount = int.Parse(DS2.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS2.Tables["list"].Rows[0]["Icount"].ToString());

        }
        catch (Exception ex)
        {


        }
        return iTCount;
    }
   
    /// <summary>
    /// 檢查發票是否登入過 TRUE:已登錄 FALSE:未登錄
    /// </summary>
    /// <param name="sCareerName">ikki</param>
    /// <param name="sAction_NO"></param>
    /// <param name="sInvoice"></param>
    /// <param name="sCloumnName">value4</param>
    /// <param name="sEmail"></param>
    /// <returns></returns>
   
    public bool CheckInvoice(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName, string sEmail)
    {
        bool blReturn = false;
        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[select uid from wang_action_members where Career=@Career and Action_NO=@Action_NO and email=@email and " + sCloumnName + "=@Invoice]]>");
            sb.Append(s.ParamXML("Career", sCareerName));
            sb.Append(s.ParamXML("Action_NO", sAction_NO));
            sb.Append(s.ParamXML("Invoice", sInvoice));
            sb.Append(s.ParamXML("email", sEmail));
            sb.Append("</list>");
            sb.Append("</select>");
            sb.Append("</sql>");
            string sError = "";
            DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);

            blReturn = false;
            if (DS.Tables[0].Rows.Count > 0)
                blReturn = true;


        }
        catch (Exception ex)
        {

        }

        return blReturn;
    }
}
