using System;
using System.Collections;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    /// <summary>
    /// Copyright (C) 2004-2008 LiTianPing 
    /// 資料訪問基礎類(基於SQLServer)
    /// 用戶可以修改滿足自己專案的需要。
    /// </summary>
    public class DBUtil
    {
        //資料庫連接字串(使用 web.config來配置)

        protected static string connectionString = string.Empty;
        protected SqlConnection rd_conn;
        protected SqlDataReader myReader;

        public DBUtil()
        {
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnStr_E_Root"].ConnectionString;
            
        }

        #region utility method

        public  int GetMaxID(string FieldName, string TableName)
        {
            string strsql = "select max(" + FieldName + ")+1 from " + TableName;
            object obj = GetSingle(strsql);
            if (obj == null)
            {
                return 1;
            }
            else
            {
                return int.Parse(obj.ToString());
            }
        }

        public bool Exists(string strSql, params SqlParameter[] cmdParms)
        {
            object obj = GetSingle(strSql, cmdParms);
            int cmdresult;
            if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
            {
                cmdresult = 0;
            }
            else
            {
                cmdresult = int.Parse(obj.ToString());
            }
            if (cmdresult == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 創建 SqlCommand 物件實例(用來返回一個整數值) 
        /// </summary>
        /// <param name="storedProcName">存儲過程名</param>
        /// <param name="parameters">存儲過程參數</param>
        /// <returns>SqlCommand 物件實例</returns>
        private SqlCommand BuildIntCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.Parameters.Add(new SqlParameter("ReturnValue",
             SqlDbType.Int, 4, ParameterDirection.ReturnValue,
             false, 0, 0, string.Empty, DataRowVersion.Default, null));
            return command;
        }

        /// <summary>
        /// 構建 SqlCommand 物件(用來返回一個結果集，而不是一個整數值)
        /// </summary>
        /// <param name="connection">資料庫連接</param>
        /// <param name="storedProcName">存儲過程名</param>
        /// <param name="parameters">存儲過程參數</param>
        /// <returns>SqlCommand</returns>
        private SqlCommand BuildQueryCommand(SqlConnection connection, string storedProcName, IDataParameter[] parameters)
        {
            SqlCommand command = new SqlCommand(storedProcName, connection);
            command.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter parameter in parameters)
            {
                command.Parameters.Add(parameter);
            }
            return command;
        }

        private void PrepareCommand(SqlCommand cmd, SqlConnection conn, SqlTransaction trans, string cmdText, SqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
                cmd.Transaction = trans;
            cmd.CommandType = CommandType.Text;//cmdType;
            if (cmdParms != null)
            {
                foreach (SqlParameter parm in cmdParms)
                    cmd.Parameters.Add(parm);
            }
        }

        #endregion

        #region  執行簡單語法


        /// <summary>
        /// 執行SQL語句，返回影響的記錄數
        /// </summary>
        /// <param name="SQLString">SQL語句</param>
        /// <returns>影響的記錄數</returns>
        public int ExecuteSql(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        int rows = cmd.ExecuteNonQuery();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException E)
                    {
                        connection.Close();
                        throw new Exception(E.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 執行多條SQL語句，實現資料庫事務。
        /// </summary>
        /// <param name="SQLStringList">多條SQL語句</param>  
        public void ExecuteSqlTran(ArrayList SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                SqlTransaction tx = conn.BeginTransaction();
                cmd.Transaction = tx;
                try
                {
                    for (int n = 0; n < SQLStringList.Count; n++)
                    {
                        string strsql = SQLStringList[n].ToString();
                        if (strsql.Trim().Length > 1)
                        {
                            cmd.CommandText = strsql;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    tx.Commit();
                }
                catch (System.Data.SqlClient.SqlException E)
                {
                    tx.Rollback();
                    throw new Exception(E.Message);
                }
            }
        }
        /// <summary>
        /// 執行帶一個存儲過程參數的的SQL語句。
        /// </summary>
        /// <param name="SQLString">SQL語句</param>
        /// <param name="content">參數內容,比如一個欄位是格式複雜的文章，有特殊符號，可以通過這個方式添加</param>
        /// <returns>影響的記錄數</returns>
        public int ExecuteSql(string SQLString, string content)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(SQLString, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@content", SqlDbType.NText);
                myParameter.Value = content;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException E)
                {
                    throw new Exception(E.Message);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }
        /// <summary>
        /// 向資料庫裏插入圖像格式的欄位(和上面情況類似的另一種實例)
        /// </summary>
        /// <param name="strSQL">SQL語句</param>
        /// <param name="fs">圖像位元組,資料庫的欄位類型為image的情況</param>
        /// <returns>影響的記錄數</returns>
        public int ExecuteSqlInsertImg(string strSQL, byte[] fs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(strSQL, connection);
                System.Data.SqlClient.SqlParameter myParameter = new System.Data.SqlClient.SqlParameter("@fs", SqlDbType.Image);
                myParameter.Value = fs;
                cmd.Parameters.Add(myParameter);
                try
                {
                    connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    return rows;
                }
                catch (System.Data.SqlClient.SqlException E)
                {
                    throw new Exception(E.Message);
                }
                finally
                {
                    cmd.Dispose();
                    connection.Close();
                }
            }
        }

        /// <summary>
        /// 執行一條計算查詢結果語句，返回查詢結果（object）。
        /// </summary>
        /// <param name="SQLString">計算查詢結果語句</param>
        /// <returns>查詢結果（object）</returns>
        public object GetSingle(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(SQLString, connection))
                {
                    try
                    {
                        connection.Open();
                        object obj = cmd.ExecuteScalar();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        connection.Close();
                        throw new Exception(e.Message);
                    }
                }
            }
        }
        /// <summary>
        /// 執行查詢語句，返回SqlDataReader
        /// </summary>
        /// <param name="strSQL">查詢語句</param>
        /// <returns>SqlDataReader</returns>
        public SqlDataReader ExecuteReader(string strSQL)
        {
           
            rd_conn = new SqlConnection(connectionString);
            
            
            using (SqlCommand cmd = new SqlCommand(strSQL, rd_conn))
                {
                    
                    try
                    {
                        rd_conn.Open();
                         myReader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                        //SqlDataReader myReader = cmd.ExecuteReader();
                        return myReader;
                        
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        
                        throw new Exception(e.Message);
                        rd_conn.Close();
                    }
                   

                        myReader.Dispose();
                        myReader.Close();
                        rd_conn.Close();
                        
                  
            }

           
        }
        public void closeconnection()
        {
            

            if (myReader != null)
            {
                if (myReader.IsClosed == false)
                {
                    myReader.Dispose();
                    myReader.Close();
                }
            }

            if (rd_conn != null)
            {
                rd_conn.Dispose();
                rd_conn.Close();
            }
            
        }

      
           

      
        /// <summary>
        /// 執行查詢語句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查詢語句</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string SQLString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet ds = new DataSet();
                try
                {
                    connection.Open();
                    SqlDataAdapter command = new SqlDataAdapter(SQLString, connection);
                    command.Fill(ds, "ds");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    throw new Exception(ex.Message);
                }
                return ds;
            }
        }


        #endregion

        #region 執行帶參數的SQL語句

        /// <summary>
        /// 執行SQL語句，返回影響的記錄數
        /// </summary>
        /// <param name="SQLString">SQL語句</param>
        /// <returns>影響的記錄數</returns>
        public    int ExecuteSql(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        int rows = cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                        return rows;
                    }
                    catch (System.Data.SqlClient.SqlException E)
                    {
                        throw new Exception(E.Message);
                    }
                }
            }
        }


        /// <summary>
        /// 執行多條SQL語句，實現資料庫事務。
        /// </summary>
        /// <param name="SQLStringList">SQL語句的哈希表（key為sql語句，value是該語句的SqlParameter[]）</param>
        public    void ExecuteSqlTran(Hashtable SQLStringList)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlTransaction trans = conn.BeginTransaction())
                {
                    SqlCommand cmd = new SqlCommand();
                    try
                    {
                        //迴圈
                        foreach (DictionaryEntry myDE in SQLStringList)
                        {
                            string cmdText = myDE.Key.ToString();
                            SqlParameter[] cmdParms = (SqlParameter[])myDE.Value;
                            PrepareCommand(cmd, conn, trans, cmdText, cmdParms);
                            int val = cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();

                            trans.Commit();
                        }
                    }
                    catch
                    {
                        trans.Rollback();
                        throw;
                    }
                }
            }
        }


        /// <summary>
        /// 執行一條計算查詢結果語句，返回查詢結果（object）。
        /// </summary>
        /// <param name="SQLString">計算查詢結果語句</param>
        /// <returns>查詢結果（object）</returns>
        public object GetSingle(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                        object obj = cmd.ExecuteScalar();
                        cmd.Parameters.Clear();
                        if ((Object.Equals(obj, null)) || (Object.Equals(obj, System.DBNull.Value)))
                        {
                            return null;
                        }
                        else
                        {
                            return obj;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException e)
                    {
                        throw new Exception(e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 執行查詢語句，返回SqlDataReader
        /// </summary>
        /// <param name="strSQL">查詢語句</param>
        /// <returns>SqlDataReader</returns>
        public    SqlDataReader ExecuteReader(string SQLString, params SqlParameter[] cmdParms)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand();
            try
            {
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                SqlDataReader myReader = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                return myReader;
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                throw new Exception(e.Message);
            }

        }

        /// <summary>
        /// 執行查詢語句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查詢語句</param>
        /// <returns>DataSet</returns>
        public    DataSet Query(string SQLString, params SqlParameter[] cmdParms)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                PrepareCommand(cmd, connection, null, SQLString, cmdParms);
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    try
                    {
                        da.Fill(ds, "ds");
                        cmd.Parameters.Clear();
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    return ds;
                }
            }
        }




        #endregion

        #region 存儲過程操作

        /// <summary>
        /// 執行存儲過程
        /// </summary>
        /// <param name="storedProcName">存儲過程名</param>
        /// <param name="parameters">存儲過程參數</param>
        /// <returns>SqlDataReader</returns>
        public    SqlDataReader doDataReaderQuery(string storedProcName, IDataParameter[] parameters)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataReader returnReader;
            connection.Open();
            SqlCommand command = BuildQueryCommand(connection, storedProcName, parameters);
            command.CommandType = CommandType.StoredProcedure;
            returnReader = command.ExecuteReader();
            return returnReader;
        }


        /// <summary>
        /// 執行存儲過程
        /// </summary>
        /// <param name="storedProcName">存儲過程名</param>
        /// <param name="parameters">存儲過程參數</param>
        /// <param name="tableName">DataSet結果中的表名</param>
        /// <returns>DataSet</returns>
        public    DataSet RunProcedure(string storedProcName, IDataParameter[] parameters, string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                connection.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter();
                sqlDA.SelectCommand = BuildQueryCommand(connection, storedProcName, parameters);
                sqlDA.Fill(dataSet, tableName);
                connection.Close();
                return dataSet;
            }
        }




        /// <summary>
        /// 執行存儲過程，返回影響的行數  
        /// </summary>
        /// <param name="storedProcName">存儲過程名</param>
        /// <param name="parameters">存儲過程參數</param>
        /// <param name="rowsAffected">影響的行數</param>
        /// <returns></returns>
        public    int RunProcedure(string storedProcName, IDataParameter[] parameters, out int rowsAffected)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                int result;
                connection.Open();
                SqlCommand command = BuildIntCommand(connection, storedProcName, parameters);
                rowsAffected = command.ExecuteNonQuery();
                result = (int)command.Parameters["ReturnValue"].Value;
                //Connection.Close();
                return result;
            }
        }



        #endregion

    }
}


