using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Text;
using System.Data;

/// <summary>
/// dbAction 的摘要描述
/// </summary>
public class dbAction:DBBaseClass
{
	#region 共用參數
    Tools _Tools = new Tools();//小工具

	public dbAction()
	{
		//
		// TODO: 在此加入建構函式的程式碼
		//
    }
    #endregion

    //(1)會員資料表[xxx_members]====================================================================
    #region 搜尋xxx_members(事業處/活動編號)
    public DataSet Sel_Members_GetMemberData(string sCareerName, string suid, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@uid", suid.Trim());

            //sb.Append(@"SELECT [啟動時間]
            //                        FROM [" + sCareerName + "_members]");
            //sb.Append(@"WHERE uid=@uid");
            sb.Append(@"SELECT [啟動時間]
                        FROM [Wang2SMS].[dbo].[websiteMember]");
             sb.Append(@"WHERE uid=@uid");

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


    #region 搜尋email未啟動帳號
    public DataSet Sel_noMembers_GetMemberData_mail(string sCareerNo,string sMail, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo.Trim());
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Mail", sMail.Trim());

            sb.Append(@"SELECT *
                        FROM [Wang2SMS].[dbo].[websiteMember]");
            sb.Append(@"WHERE [email]=@Mail and [CareerNo]=@CareerNo and [啟動]='0'");

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




    //(2)活動資料表[dbo].[wang_action]==============================================================
    #region 搜尋WangAction(事業處/活動編號)
    public DataSet Sel_WangAction(string strCareer, string strAction_No, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_No", strAction_No);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Career", strCareer);

            sb.Append(@"SELECT [Action_PostDate],[Action_CloseDate],[JoinCount] 
                        FROM [dbo].[wang_action]");
            sb.Append(@"WHERE [Action_No]=@Action_No AND [Career]=@Career");

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


    //(3-1)活動登入紀錄表[dbo].[wang_action_members]================================================
    #region 搜尋---------------------------------------------------------------------



    #region 搜尋wang_action_members:總參加人數(活動編號)
    public DataSet Sel_WangActionMembers_count(string sAction_No, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_No);

            sb.Append(@"SELECT COUNT(*) Icount 
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE [Action_NO]=@Action_NO");

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

    #region 搜尋wang_action_members:單人參加人數(活動編號/email)
    public DataSet Sel_WangActionMembers_countEmail(string sAction_No, string sEmail, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_No);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@email", sEmail);

            sb.Append(@"SELECT COUNT(*) Icount
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE Action_NO=@Action_NO AND email=@email");

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




    #region 搜尋wang_action_members:該場發票抽獎累計次數(活動編號/email/次數欄位)
    public DataSet Sel_WangActionMembers_countRaffle(string sAction_NO, string sEmail, string sCloumnName, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@sCloumnName", sCloumnName);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Email", sEmail);

            sb.Append(@"SELECT SUM(CNT) Icount
                        FROM (select convert(int,isnull(@sCloumnName,0)) AS CNT from wang_action_members where Action_NO=@Action_NO and email=@Email)BB");

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

    #region 搜尋wang_action_members:欄位重複次數*1(活動編號、欄位、欄位值)
    public DataSet Sel_WangActionMembers_countValue(string sAction_NO, string sCloumnName, string sData, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Data", sData);

            sb.Append(@"SELECT COUNT(*) Icount
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE Action_NO=@Action_NO AND " + sCloumnName + "=@Data");

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

    #region 搜尋wang_action_members:欄位重複次數*1(活動編號、欄位、欄位值、欄位2、欄位值3)
    public DataSet Sel_WangActionMembers_countValue(string sAction_NO, string sCloumnName, string sData, string sCloumnName2, string sData2, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Data", sData);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Data2", sData2);

            sb.Append(@"SELECT COUNT(*) Icount
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE  Action_NO=@Action_NO AND " + sCloumnName + "=@Data  AND " + sCloumnName2 + "=@Data2");

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



    #region 搜尋wang_action_members:該帳號的欄位=1狀況(活動編號/email/valueN=1)原燒兒盟
    public DataSet Sel_WangActionMembers_EmailWinCount(string sAction_NO, string sEmail, string sCloumnName, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@email", sEmail);

            sb.Append(@"SELECT COUNT(*) Icount
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE Action_NO=@Action_NO 
                          AND email=@email 
                          AND " + sCloumnName + "='1'");

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

    #region 搜尋wang_action_members:特定場的人數總和(活動編號、人數欄位、場地欄位、場地值)藝奇浴衣
    public DataSet Sel_WangActionMembers_PeopleCount(string sAction_NO, string sCloumnName_SUM, string sCloumnName, string sStage, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@sCloumnName_SUM", sCloumnName_SUM);  
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);  
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Data", sStage);

            sb.Append(@"SELECT SUM(CONVERT (int,@sCloumnName_SUM)) FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE  Action_NO=@Action_NO AND " + sCloumnName + "=@Data");

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

    #region 搜尋wang_action_members:報名成功'組數'(活動編號、欄位值1、欄位值7)藝奇浴衣
    public DataSet Sel_WangActionMembers_PeopleCountSet(string sAction_NO, string sValue1, string sValue7, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Value1", sValue1);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Value7", sValue7);

            sb.Append(@"SELECT COUNT(*) as[總和]
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE  [Action_NO]=@Action_NO AND [Value1]=@Value1 AND CHARINDEX(@Value7,value7)>0");

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



    #region 搜尋wang_action_members(活動編號/郵件/輸入時間)
    public DataSet Sel_WangActionMembers(string sAction_NO, string sEmail, string sInputtime, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Email", sEmail);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Inputtime", sInputtime);

            sb.Append(@"SELECT COUNT(*) Icount 
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE Action_NO=@Action_NO  AND CONVERT(VARCHAR(10),input_time,111)=@Inputtime  AND Email=@Email");

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

    #region 搜尋wang_action_members(事業處/活動編號/發票/VALUE)
    public DataSet Sel_WangActionMembers(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Career", sCareerName);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Invoice", sInvoice);

            sb.Append(@"SELECT [uid] 
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE [Career]=@Career 
                            AND [Action_NO]=@Action_NO 
                            AND " + sCloumnName + "=@Invoice");

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

    #region 搜尋wang_action_members(事業處/活動編號/發票/VALUE/email)
    public DataSet Sel_WangActionMembers(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName, string sEmail, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Career", sCareerName);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Invoice", sInvoice);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@email", sEmail);

            sb.Append(@"SELECT [uid] 
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE [Career]=@Career 
                            AND [Action_NO]=@Action_NO 
                            AND [email]=@email 
                            AND " + sCloumnName + "=@Invoice");

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

    #region 搜尋wang_action_members(事業處/活動編號/發票/VALUE/email/消費日期/VALUE2)
    public DataSet Sel_WangActionMembers(string sCareerName, string sAction_NO, string sInvoice, string sCloumnName, string sEmail, string sDay, string sCloumnName2, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Career", sCareerName);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_NO", sAction_NO);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@email", sEmail);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Invoice", sInvoice);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Day", sDay);

            sb.Append(@"SELECT [uid] 
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE [Career]=@Career and [Action_NO]=@Action_NO and [email]=@email and " + sCloumnName + "=@Invoice and " + sCloumnName2 + "=@Day");

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





    #region 搜尋wang_action_members:留言內容
    public DataSet Sel_WangActionMembers(string sAction_No, string sCareer, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_No", sAction_No);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Career", sCareer);

            sb.Append(@"SELECT value1 ,value2 ,value3  
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE  [action_no]=@Action_No AND [Career]=@Career ");
            sb.Append("ORDER BY  aCONVERT(INT,value1) DESC ");

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



    #region 搜尋wang_action_members:all
    public DataSet Sel_WangActionMembers_all(string sAction_No, string sEmail, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Action_No", sAction_No);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@sEmail", sEmail);

            sb.Append(@"SELECT * 
                        FROM [dbo].[wang_action_members]");
            sb.Append(@"WHERE  [action_no]=@Action_No AND [Email]=@sEmail ");

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



    #endregion


    //(3-2)活動頁面使用 [dbo].[wang_action_members](寫入):==========================================
    #region 寫入---------------------------------------------------------------------

    #region 寫入wang_action_members:登入
    public bool Insert_WangActionMembers(string sCareer, string sAction_No, string sUid, string sEmail)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,uid,email,input_time)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@uid,@email,@input_time)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@uid", sUid);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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

    #region 寫入wang_action_members:填資料  (+1)
    public bool Insert_WangActionMembers1(string sCareer, string sAction_No, string sUid, string sEmail, string Value1)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,uid,email,input_time,value1)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@uid,@email,@input_time,@value1)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@uid", sUid);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@value1", Value1);//資料

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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

    #region 寫入wang_action_members:留言    (+1.2.3)
    //Value1:活動留言編號
    //Value2:活動小名
    //Value3:留言的內容
    public bool Insert_WangActionMembers3(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,uid,email,input_time,value1,value2,value3)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@uid,@email,@input_time,@value1,@value2,@value3)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@uid", sUid);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@value1", Value1);//活動留言編號
            SQC_Website.Parameters.AddWithValue("@value2", Value2);//活動小名
            SQC_Website.Parameters.AddWithValue("@value3", Value3);//留言的內容!!

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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

    #region 寫入wang_action_members:資料    (+1.2.3)
    //Value1:
    //Value2:
    //Value3:
    public bool Insert_WangActionMembers3_2(string sCareer, string sAction_No, string Value1, string Value2, string Value3)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,input_time,value1,value2,value3)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@input_time,@value1,@value2,@value3)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@value1", Value1);//活動留言編號
            SQC_Website.Parameters.AddWithValue("@value2", Value2);//活動小名
            SQC_Website.Parameters.AddWithValue("@value3", Value3);//留言的內容!!

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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

    #region 寫入wang_action_members:登入發票(+1.2.3.5)
    //[value1:發票日期  value2:發票號碼   value3:消費客數 value5:消費金額]
    public bool Insert_WangActionMembers4(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3, string Value5)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,uid,email,input_time,value1,value2,value3,value5)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@uid,@email,@input_time,@value1,@value2,@value3,@value5)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@uid", sUid);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@value1", Value1);//日期
            SQC_Website.Parameters.AddWithValue("@value2", Value2);//發票
            SQC_Website.Parameters.AddWithValue("@value3", Value3);//客數
            SQC_Website.Parameters.AddWithValue("@value5", Value5);//金額

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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

    #region 寫入wang_action_members:建議卡  (+1.2.3.6)
    public bool Insert_WangActionMembers4_2(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3, string Value6)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,uid,email,input_time,value1,value2,value3,value6)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@uid,@email,@input_time,@value1,@value2,@value3,@value6)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@uid", sUid);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@value1", Value1);
            SQC_Website.Parameters.AddWithValue("@value2", Value2);
            SQC_Website.Parameters.AddWithValue("@value3", Value3);
            SQC_Website.Parameters.AddWithValue("@value6", Value6);

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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


    #region 寫入wang_action_members:全欄位  (all)
    public bool Insert_WangActionMembersALL(string sCareer, string sAction_No, string sUid, string sEmail, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[wang_action_members](aid,Career,Action_NO,uid,email,input_time,value1,value2,value3,value4,value5,value6,value7,value8,value9,value10,value11,value12)");
            sb.Append("VALUES(@CreateGUID,@Career,@Action_NO,@uid,@email,@input_time,@value1,@value2,@value3,@value4,@value5,@value6,@value7,@value8,@value9,@value10,@value11,@value12)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@CreateGUID", _Tools.CreateGUID_Aid());
            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Action_NO", sAction_No);
            SQC_Website.Parameters.AddWithValue("@uid", sUid);
            SQC_Website.Parameters.AddWithValue("@email", sEmail);
            SQC_Website.Parameters.AddWithValue("@input_time", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@value1", Value1);
            SQC_Website.Parameters.AddWithValue("@value2", Value2);
            SQC_Website.Parameters.AddWithValue("@value3", Value3);
            SQC_Website.Parameters.AddWithValue("@value4", Value4);
            SQC_Website.Parameters.AddWithValue("@value5", Value5);
            SQC_Website.Parameters.AddWithValue("@value6", Value6);
            SQC_Website.Parameters.AddWithValue("@value7", Value7);
            SQC_Website.Parameters.AddWithValue("@value8", Value8);
            SQC_Website.Parameters.AddWithValue("@value9", Value9);
            SQC_Website.Parameters.AddWithValue("@value10", Value10);
            SQC_Website.Parameters.AddWithValue("@value11", Value11);
            SQC_Website.Parameters.AddWithValue("@value12", Value12);

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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


    #endregion



    //(4)事件紀錄表[dbo].[event]====================================================================
    #region 搜尋event(事業處/發票)十二鍋小資火鍋
    public DataSet Sel_Event(string sCareerNo, string sInvoice, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@CareerNo", sCareerNo);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@Invoice", sInvoice);

            sb.Append(@"SELECT COUNT(invoice) AS[總計] 
                        FROM [dbo].[event]");
            sb.Append(@"WHERE  CareerNo=@CareerNo
                         AND invoice=@Invoice");

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




    //(5)菁英禮讚相關===============================================================================
    #region 搜尋網路會員email，有沒有存在白金crm中[Wang2SMS].[dbo].[WM_Customer]
    public DataSet Sel_WM_Customer_CellPhone(string sPhone, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@sPhone", sPhone);

            sb.Append(@"SELECT *
                        FROM [Wang2SMS].[dbo].[WM_Customer]");
            sb.Append(@"WHERE  [CM_CellPhone]=@sPhone ");

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



    #region 搜尋Members2App的這個事業處,這個email帳號,已經是菁英/vip的成員
    public DataSet Sel_Members2App_email(string sCareerNo, string sEmail, out string sReturnMsg)
    {
        sReturnMsg = "";
        DataSet DS = new DataSet();
        try
        {
            StringBuilder sb = new StringBuilder();
            SDA_Website.SelectCommand.CommandType = System.Data.CommandType.Text;
            SDA_Website.SelectCommand.Parameters.Clear();
            SDA_Website.SelectCommand.Parameters.AddWithValue("@sCareerNo", sCareerNo);
            SDA_Website.SelectCommand.Parameters.AddWithValue("@sEmail", sEmail);

            sb.Append(@"SELECT *
                        FROM [Wang2SMS].[dbo].[wang_Members2App]");
            sb.Append(@"WHERE    CareerNo=@sCareerNo and email=@sEmail and Status='2' ");

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




    //(6)花旗信用卡留言=======================================================================
    #region citi_apply
    public bool Insert_Citi_apply(string sCareer, string sName, string sOfficePhone, string sHomePhone, string sMobile, string sAmPm, string sSex)
    {
        bool blReturn;
        StringBuilder sb = new StringBuilder();
        try
        {
            SQC_Website.CommandType = System.Data.CommandType.Text;
            sb.Append("INSERT INTO [dbo].[citi_apply](Career,Name,OfficePhone,HomePhone,Mobile,AmPm,InputTime,Sex)");
            sb.Append("VALUES(@Career,@Name,@OfficePhone,@HomePhone,@Mobile,@AmPm,@InputTime,@Sex)");
            SQC_Website.CommandText = sb.ToString();
            SQC_Website.Parameters.Clear();

            SQC_Website.Parameters.AddWithValue("@Career", sCareer);
            SQC_Website.Parameters.AddWithValue("@Name", sName);
            SQC_Website.Parameters.AddWithValue("@OfficePhone", sOfficePhone);
            SQC_Website.Parameters.AddWithValue("@HomePhone", sHomePhone);
            SQC_Website.Parameters.AddWithValue("@Mobile", sMobile);
            SQC_Website.Parameters.AddWithValue("@AmPm", sAmPm);
            SQC_Website.Parameters.AddWithValue("@InputTime", DateTime.Now);
            SQC_Website.Parameters.AddWithValue("@Sex", sSex);

            SQC_Website.Connection.Open();
            //this.SQC_Website.ExecuteNonQuery();
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


}