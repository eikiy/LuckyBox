using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;


/// <summary>
/// DBBaseClass 的摘要描述
/// </summary>
public class DBBaseClass
{
    private static string strSqlConn = "";
    private static System.Data.SqlClient.SqlConnection SqlConn;




    //uisdb2.[SuggestCard]-------------------------------------------
    protected System.Data.SqlClient.SqlCommand SQC;
    protected System.Data.SqlClient.SqlDataAdapter SDA;

    //sunshine.[Website]-------------------------------------------
    protected System.Data.SqlClient.SqlCommand SQC_Website;
    protected System.Data.SqlClient.SqlDataAdapter SDA_Website;


    //Cancer.[wanggroup]-------------------------------------------
    protected System.Data.SqlClient.SqlCommand SQC_wanggroup;
    protected System.Data.SqlClient.SqlDataAdapter SDA_wanggroup;

    protected SqlTransaction trans;
    

	public DBBaseClass()
    {
        #region SuggestCard連線字串
        /*檢查
        if (sys.Trim() == "")
            strSqlConn = System.Configuration.ConfigurationManager.ConnectionStrings["SuggestCardConnectionString"].ConnectionString;
        else
        {
            //檢查主機是否存在
            string[] strSession = sys.Split(';');
            for (int i = 0; i < strSession.Length; i++)
            {
                if (strSession[i].ToUpper().IndexOf("DATA SOURCE") != -1)
                {

                }
            }
            strSqlConn = sys;
        }
         * */
        strSqlConn = System.Configuration.ConfigurationManager.ConnectionStrings["SuggestCardConnectionString"].ConnectionString;
        SqlConn = new System.Data.SqlClient.SqlConnection(strSqlConn);
        this.SDA = new SqlDataAdapter();
        this.SDA.SelectCommand = new System.Data.SqlClient.SqlCommand("", SqlConn);
        this.SDA.SelectCommand.CommandTimeout = 1200;
        SQC = new SqlCommand("", SqlConn);
        SQC.CommandTimeout = 1200;
        #endregion

        #region Website連線字串
        strSqlConn = System.Configuration.ConfigurationManager.ConnectionStrings["WebSiteConnectionString"].ConnectionString;
        SqlConn = new System.Data.SqlClient.SqlConnection(strSqlConn);
        this.SDA_Website = new SqlDataAdapter();
        this.SDA_Website.SelectCommand = new System.Data.SqlClient.SqlCommand("", SqlConn);
        this.SDA_Website.SelectCommand.CommandTimeout = 1200;
        SQC_Website = new SqlCommand("", SqlConn);
        SQC_Website.CommandTimeout = 1200;
        #endregion

        #region SDA_wanggroup連線字串
        strSqlConn = System.Configuration.ConfigurationManager.ConnectionStrings["wanggroupConnectionString"].ConnectionString;
        SqlConn = new System.Data.SqlClient.SqlConnection(strSqlConn);
        this.SDA_wanggroup = new SqlDataAdapter();
        this.SDA_wanggroup.SelectCommand = new System.Data.SqlClient.SqlCommand("", SqlConn);
        this.SDA_wanggroup.SelectCommand.CommandTimeout = 1200;
        SQC_wanggroup = new SqlCommand("", SqlConn);
        SQC_wanggroup.CommandTimeout = 1200;
        #endregion

    }


	
	
	
	#region (wSample)SuggestCard資料庫
    protected object SQC_commandExecuteScalar()
    {
        object ob = null;
        string strMsg = "";
        try
        {
            SQC.Connection.Open();
            ob = SQC.ExecuteScalar();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
        }
        catch (Exception ex)
        {
            strMsg = ex.Message;
            if (SQC.Connection.State == ConnectionState.Open)
            {
                SQC.Connection.Close();
            }
            SQC.Parameters.Clear();

        }
        return ob;
    }

    protected object SQC_commandExecuteScalarTransaction()
    {
        object ob = null;
        string strMsg = "";
        try
        {
            ob = SQC.ExecuteScalar();
            SQC.Parameters.Clear();
        }
        catch (Exception ex)
        {
            strMsg = ex.Message;
            SQC.Parameters.Clear();

        }
        return ob;
    }

    protected bool SQC_ExecuteNonQuery(out string ErrorMsg)
    {
        bool bl = false;
        int icount = 0;
        string strMsg = "";
        ErrorMsg = "";
        try
        {

            SQC.Connection.Open();
            icount = SQC.ExecuteNonQuery();
            SQC.Connection.Close();
            SQC.Parameters.Clear();
            bl = true;

        }
        catch (Exception ex)
        {

            if (SQC.Connection.State == ConnectionState.Open)
            {
                SQC.Connection.Close();
            }

            SQC.Parameters.Clear();
            strMsg = ex.Message;
            bl = false;
            ErrorMsg = strMsg;
        }
        return bl;
    }

    protected bool SQC_ExecuteNonQueryTransaction(out string ErrorMsg)
    {
        bool bl = false;
        int icount = 0;
        string strMsg = "";
        ErrorMsg = "";
        try
        {
            icount = SQC.ExecuteNonQuery();
            SQC.Parameters.Clear();
            bl = true;
        }
        catch (Exception ex)
        {
            SQC.Parameters.Clear();
            strMsg = ex.Message;
            bl = false;
            ErrorMsg = strMsg;
        }

        return bl;
    }

    public void SQC_BeginTransaction()
    {
        SQC.Connection.Open();
        trans = SQC.Connection.BeginTransaction("PCStn");
        SQC.Transaction = trans;
    }

    public void SQC_CommitTransaction()
    {
        trans.Commit();
        SQC.Connection.Close();
        SQC.Parameters.Clear();
    }

    public void SQC_RollbackTransaction()
    {
        trans.Rollback();
        SQC.Connection.Close();
        SQC.Parameters.Clear();
    }

    #endregion

    #region Website資料庫
    protected object SQC_Website_commandExecuteScalar()
    {
        object ob = null;
        string strMsg = "";
        try
        {
            SQC_Website.Connection.Open();
            ob = SQC_Website.ExecuteScalar();
            SQC_Website.Connection.Close();
            SQC_Website.Parameters.Clear();

        }
        catch (Exception ex)
        {
            strMsg = ex.Message;
            if (SQC_Website.Connection.State == ConnectionState.Open)
            {
                SQC_Website.Connection.Close();
            }
            SQC_Website.Parameters.Clear();

        }
        return ob;
    }

    protected bool SQC_Website_ExecuteNonQuery(out string ErrorMsg)
    {
        bool bl = false;
        int icount = 0;
        string strMsg = "";
        ErrorMsg = "";
        try
        {
            SQC_Website.Connection.Open();
            icount = SQC_Website.ExecuteNonQuery();
            SQC_Website.Connection.Close();
            SQC_Website.Parameters.Clear();
            bl = true;

        }
        catch (Exception ex)
        {
            strMsg = ex.Message;
            bl = false;
            ErrorMsg = strMsg;
            if (SQC_Website.Connection.State == ConnectionState.Open)
            {
                SQC_Website.Connection.Close();
            }
            SQC_Website.Parameters.Clear();
        }
        return bl;
    }

    #endregion
		
    #region wanggroup資料庫
    protected object SQC_wanggroup_commandExecuteScalar()
    {
        object ob = null;
        string strMsg = "";
        try
        {
            SQC_wanggroup.Connection.Open();
            ob = SQC_wanggroup.ExecuteScalar();
            SQC_wanggroup.Connection.Close();
            SQC_wanggroup.Parameters.Clear();

        }
        catch (Exception ex)
        {
            strMsg = ex.Message;
            if (SQC_wanggroup.Connection.State == ConnectionState.Open)
            {
                SQC_wanggroup.Connection.Close();
            }
            SQC_wanggroup.Parameters.Clear();

        }
        return ob;
    }

    protected bool SQC_wanggroup_ExecuteNonQuery(out string ErrorMsg)
    {
        bool bl = false;
        int icount = 0;
        string strMsg = "";
        ErrorMsg = "";
        try
        {
            SQC_wanggroup.Connection.Open();
            icount = SQC_wanggroup.ExecuteNonQuery();
            SQC_wanggroup.Connection.Close();
            SQC_wanggroup.Parameters.Clear();
            bl = true;

        }
        catch (Exception ex)
        {
            strMsg = ex.Message;
            bl = false;
            ErrorMsg = strMsg;
            if (SQC_wanggroup.Connection.State == ConnectionState.Open)
            {
                SQC_wanggroup.Connection.Close();
            }
            SQC_wanggroup.Parameters.Clear();
        }
        return bl;
    }

    #endregion

	
}


