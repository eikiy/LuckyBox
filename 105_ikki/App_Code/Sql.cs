using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Mail;
using System.Xml;
//using CrystalDecisions.CrystalReports.Engine;
//using CrystalDecisions.Shared;
using System.Data.SqlClient;
using System.Text;
/// <summary>
/// Sql 的摘要描述
/// </summary>
public class Sql
{
    #region 共用變數
    public ConnString ConnStr = new ConnString();
    public ParamString ParamStr = new ParamString();
    #endregion

    #region Sql
    public Sql()
    {
        //
        // TODO: 在此加入建構函式的程式碼
        //
    }
    #endregion

    #region class ConnString
    public class ConnString
    {
        public string messages = "user id=admin;password=2802836;initial catalog=messages;data source=datacenter;Connect Timeout=630";
        public string doc = "user id=admin;password=2802836;initial catalog=document;data source=datacenter;Connect Timeout=630";
        public string local = "Data Source=localhost;Initial Catalog=tw-airnet;user id=sa;password=1;Connect Timeout=630";
        public string permission = "user id=admin;password=2802836;initial catalog=messages;data source=datacenter;Connect Timeout=630";
        public string hr = "user id=admin;password=2802836;initial catalog=hr;data source=datacenter;Connect Timeout=630";
        public string transfer = "user id=admin;password=2802836;initial catalog=transfer;data source=datacenter;Connect Timeout=630";
        public string customer = "user id=admin;password=2802836;initial catalog=customer;data source=cancer;Connect Timeout=630";
        public string account = "user id=admin;password=2802836;initial catalog=account;data source=datacenter;Connect Timeout=630";
        public string classes = "user id=admin;password=2802836;initial catalog=classes;data source=datacenter;Connect Timeout=630";
        public string deduct = "user id=admin;password=2802836;initial catalog=deduct;data source=datacenter;Connect Timeout=630";
        public string purchase = "user id=admin;password=2802836;initial catalog=purchase;data source=192.168.1.1;Connect Timeout=630";
        public string website = System.Configuration.ConfigurationManager.ConnectionStrings["WebSiteConnectionString"].ConnectionString;//"user id=admin;password=2802836;initial catalog=website;data source=sunshine;Connection Timeout=630";
        public string wanggroup = "user id=admin;password=2802836;initial catalog=WangGroup;data source=cancer;Connection Timeout=630";
        public string paycash = "user id=admin;password=2802836;initial catalog=paycash;data source=datacenter;Connect Timeout=630";
        public string crm0800 = "user id=admin;password=2802836;initial catalog=crm0800;data source=datacenter;Connect Timeout=630";
        public string scm = "user id=admin;password=2802836;initial catalog=SCM;data source=datacenter;Connect Timeout=630";
        public string prs = "user id=admin;password=2802836;initial catalog=prs;data source=hrs.wanggroup.com;Connection Timeout=630";
        public string ecrm = "Data Source=localhost;Initial Catalog=ecrm;user id=sa;password=12321;Connect Timeout=630";
        public string suggestcard = "user id=admin;password=2802836;initial catalog=SuggestCard;data source=uisdb2;Connection Timeout=6300";

        public ConnString()
        {
            //
            // TODO: 在此加入建構函式的程式碼
            //
        }
    }
    #endregion

    #region class ParamString
    public class ParamString
    {
        public string _int = "int";
        public string _string = "string";
        public string _nvarchar = "nvarchar";
        public string _decimal = "decimal";
        public string _char = "char";
        public string _datetime = "datetime";
        public string _bit = "bit";
        public string _image = "image";
        public string _text = "text";
        public string _null = "null";

        public ParamString()
        {
            //
            // TODO: 在此加入建構函式的程式碼
            //
        }
    }
    #endregion

    #region DS2XMLDoc
    public XmlDocument DS2XMLDoc(string conn, string XMLString)
    {
        string sError = "";
        DataSet DS = Cmd2DS(conn, XMLString, out sError);
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(HttpUtility.HtmlDecode(DS.GetXml()));
        return doc;
    }
    #endregion

    #region ParamXML
    public string ParamXML(string FieldName, string sValue)
    {
        if ((object)sValue == null)
            return "<param name=\"@" + FieldName + "\" type=\"null\"><![CDATA[]]></param>";
        return "<param name=\"@" + FieldName + "\" type=\"nvarchar\"><![CDATA[" + sValue + "]]></param>";
    }
    #endregion

    #region ParamXML
    public string ParamXML(string FieldName, int iValue)
    {
        if ((object)iValue == null)
            return "<param name=\"@" + FieldName + "\" type=\"null\"><![CDATA[]]></param>";
        return "<param name=\"@" + FieldName + "\" type=\"int\"><![CDATA[" + iValue.ToString() + "]]></param>";
    }
    #endregion

    #region ParamXML
    public string ParamXML(string FieldName, decimal dValue)
    {
        if ((object)dValue == null)
            return "<param name=\"@" + FieldName + "\" type=\"null\"><![CDATA[]]></param>";
        return "<param name=\"@" + FieldName + "\" type=\"decimal\"><![CDATA[" + dValue.ToString() + "]]></param>";
    }
    #endregion

    #region ParamXML
    public string ParamXML(string FieldName, DateTime dDate)
    {
        if ((object)dDate == null)
            return "<param name=\"@" + FieldName + "\" type=\"null\"><![CDATA[]]></param>";
        return "<param name=\"@" + FieldName + "\" type=\"datetime\"><![CDATA[" + dDate.ToString("yyyy/MM/dd HH:mm:ss") + "]]></param>";
    }
    #endregion

    #region ParamXML
    public string ParamXML(string FieldName, object oValue)
    {
        string sReturn = "";
        if (oValue == null)
            return "<param name=\"@" + FieldName + "\" type=\"null\"><![CDATA[]]></param>";
        switch (oValue.GetType().Name)
        {
            case "String":
                sReturn = "<param name=\"@" + FieldName + "\" type=\"nvarchar\"><![CDATA[" + ((string)oValue).ToString() + "]]></param>";
                break;
            case "Int32":
                sReturn = "<param name=\"@" + FieldName + "\" type=\"int\"><![CDATA[" + ((int)oValue).ToString() + "]]></param>";
                break;
            case "Decimal":
                sReturn = "<param name=\"@" + FieldName + "\" type=\"decimal\"><![CDATA[" + ((decimal)oValue).ToString() + "]]></param>";
                break;
            case "DateTime":
                sReturn = "<param name=\"@" + FieldName + "\" type=\"datetime\"><![CDATA[" + ((DateTime)oValue).ToString("yyyy/MM/dd HH:mm:ss") + "]]></param>";
                break;
        }
        return sReturn;
    }
    #endregion

    #region Cmd2DS
    public DataSet Cmd2DS(string conn, string XMLString, out string Error)
    {
        /*傳入xml字串
        <sql>
            <insert>
                <table>passwd</table>
                <param name="@id" type="string"><![CDATA[darren]]></param>
            </insert>
            <update>
                <table>passwd</table>
                <param name="@id" type="string"><![CDATA[darren]]></param>
                <where field="sn"><![CDATA[value]]></where>
            </update>
            <delete>
                <table>passwd</table>
                <where field="sn"><![CDATA[value]]></where>
            </delete>
            <cmd>
                <cmd0><![CDATA[update project set value='5' where id=@id]]>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                </cmd0>
                <cmd1><![CDATA[delete project where id='1']]></cmd1>
            </cmd>
            <select>
                <ds_table0><![CDATA[select * from project where id=@id]]>
                <param name="@id" type="string"><![CDATA[darren]]></param>
                </ds_table0>
                <ds_table1><![CDATA[select * from require]]></ds_table1>
            </select>
            <sp>
                <ds_table0>
                    <sp_name>QueryUser</sp_name>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                </ds_table0>
            </sp>
        </sql>
        */
        Error = "";
        string sqlString = "";
        string sField = "";
        string sParam = "";
        string sWhere = "";
        DataSet myDataSet = new DataSet();

        //連線,取得資料庫資料
        SqlTransaction myTrans;
        SqlConnection myConnection = new SqlConnection(conn);
        myConnection.Open();
        myTrans = myConnection.BeginTransaction();
        SqlCommand myCommand = new SqlCommand();
        myCommand.Connection = myConnection;
        myCommand.Transaction = myTrans;

        SqlDataAdapter myDataAdapter = new SqlDataAdapter("", myConnection);

        //取得command節點
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(XMLString);

        try
        {
            foreach (System.Xml.XmlNode oNode in doc.DocumentElement.ChildNodes)
            {
                switch (oNode.Name.Trim().ToLower())
                {
                    case "insert":
                        sField = "";
                        sParam = "";
                        foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        {
                            sField += oNodeP.Attributes["name"].Value.Trim().Substring(1, oNodeP.Attributes["name"].Value.Trim().Length - 1) + ",";
                            sParam += oNodeP.Attributes["name"].Value.Trim() + ",";
                        }

                        sqlString = " insert into " + oNode.SelectSingleNode("table").InnerText.Trim() + " ( " + sField.Substring(0, sField.Length - 1) + " ) values ( " + sParam.Substring(0, sParam.Length - 1) + " );";
                        myCommand.Parameters.Clear();

                        foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        {
                            myCommand.Parameters.Add(GetSqlParam(oNodeP));
                        }

                        myCommand.CommandText = sqlString;
                        myCommand.ExecuteNonQuery();
                        break;

                    case "update":
                        sParam = "";
                        sWhere = "";
                        myCommand.Parameters.Clear();

                        foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        {
                            sParam += oNodeP.Attributes["name"].Value.Trim().Substring(1, oNodeP.Attributes["name"].Value.Trim().Length - 1) + "=" + oNodeP.Attributes["name"].Value.Trim() + ",";
                            myCommand.Parameters.Add(GetSqlParam(oNodeP));
                        }

                        foreach (System.Xml.XmlNode oNodeW in oNode.SelectNodes("where"))
                        {
                            sWhere += " and " + oNodeW.Attributes["field"].Value.Trim() + "='" + oNodeW.InnerText.Trim() + "' ";
                        }

                        sqlString = " update " + oNode.SelectSingleNode("table").InnerText.Trim() + " set " + sParam.Substring(0, sParam.Length - 1) + " where 1=1 " + sWhere;
                        myCommand.CommandText = sqlString;
                        myCommand.ExecuteNonQuery();
                        break;

                    case "delete":
                        sWhere = "";
                        foreach (System.Xml.XmlNode oNodeW in oNode.SelectNodes("where"))
                        {
                            sWhere += " and " + oNodeW.Attributes["field"].Value.Trim() + "='" + oNodeW.InnerText.Trim() + "' ";
                        }
                        sqlString = " delete " + oNode.SelectSingleNode("table").InnerText.Trim() + " where 1=1 " + sWhere;
                        myCommand.CommandText = sqlString;
                        myCommand.ExecuteNonQuery();
                        break;
                    case "cmd":
                        foreach (System.Xml.XmlNode oNodeC in oNode.ChildNodes)
                        {
                            foreach (System.Xml.XmlNode oNodeP in oNodeC.SelectNodes("param"))
                            {
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            }
                            sqlString = oNodeC.ChildNodes[0].InnerText;
                            myCommand.CommandText = sqlString;
                            myCommand.ExecuteNonQuery();
                        }
                        break;
                    case "select":
                        foreach (System.Xml.XmlNode oNodeQ in oNode.ChildNodes)
                        {
                            myCommand.Parameters.Clear();
                            foreach (System.Xml.XmlNode oNodeP in oNodeQ.SelectNodes("param"))
                            {
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            }
                            sqlString = oNodeQ.ChildNodes[0].InnerText;
                            myCommand.CommandText = sqlString;
                            myDataAdapter.SelectCommand = myCommand;
                            myDataAdapter.Fill(myDataSet, oNodeQ.Name);
                        }
                        break;
                    case "sp":
                        foreach (System.Xml.XmlNode oNodeS in oNode.ChildNodes)
                        {
                            sqlString = oNodeS.SelectSingleNode("sp_name").InnerText.Trim();
                            myCommand.Parameters.Clear();
                            myCommand.CommandText = sqlString;
                            myCommand.CommandType = CommandType.StoredProcedure;
                            foreach (System.Xml.XmlNode oNodeP in oNodeS.SelectNodes("param"))
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            myDataAdapter.SelectCommand = myCommand;
                            myDataAdapter.Fill(myDataSet, oNodeS.Name);
                        }
                        break;
                }
            }

            myTrans.Commit();
        }
        catch (Exception exp)
        {
            myTrans.Rollback();
            Error = exp.Message.ToString().Trim();
            throw exp;
        }
        finally
        {
            myDataSet.Dispose();
            myCommand.Dispose();
            myDataAdapter.Dispose();
            myConnection.Close();
            myConnection.Dispose();
        }
        return myDataSet;
    }
    #endregion

    #region Cmd2DS_NoTrans
    public DataSet Cmd2DS_NoTrans(string conn, string XMLString, out string Error)
    {
        /*傳入xml字串
        <sql>
            <insert>
                <table>passwd</table>
                <param name="@id" type="string"><![CDATA[darren]]></param>
            </insert>
            <update>
                <table>passwd</table>
                <param name="@id" type="string"><![CDATA[darren]]></param>
                <where field="sn"><![CDATA[value]]></where>
            </update>
            <delete>
                <table>passwd</table>
                <where field="sn"><![CDATA[value]]></where>
            </delete>
            <cmd>
                <cmd0><![CDATA[update project set value='5' where id=@id]]>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                </cmd0>
                <cmd1><![CDATA[delete project where id='1']]></cmd1>
            </cmd>
            <select>
                <ds_table0><![CDATA[select * from project]]>
                <param name="@id" type="string"><![CDATA[darren]]></param>
                </ds_table0>
                <ds_table1><![CDATA[select * from require]]></ds_table1>
            </select>
            <sp>
                <ds_table0>
                    <sp_name>QueryUser</sp_name>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                </ds_table0>
            </sp>
        </sql>
        */
        Error = "";
        string sqlString = "";
        string sField = "";
        string sParam = "";
        string sWhere = "";
        DataSet myDataSet = new DataSet();

        //連線,取得資料庫資料        
        SqlConnection myConnection = new SqlConnection(conn);
        myConnection.Open();
        SqlCommand myCommand = new SqlCommand();
        myCommand.Connection = myConnection;
        SqlDataAdapter myDataAdapter = new SqlDataAdapter("", myConnection);

        //取得command節點
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(XMLString);
        try
        {
            foreach (System.Xml.XmlNode oNode in doc.DocumentElement.ChildNodes)
            {
                switch (oNode.Name.Trim().ToLower())
                {
                    case "insert":
                        sField = "";
                        sParam = "";
                        foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        {
                            sField += oNodeP.Attributes["name"].Value.Trim().Substring(1, oNodeP.Attributes["name"].Value.Trim().Length - 1) + ",";
                            sParam += oNodeP.Attributes["name"].Value.Trim() + ",";
                        }

                        sqlString = " insert into " + oNode.SelectSingleNode("table").InnerText.Trim() + " ( " + sField.Substring(0, sField.Length - 1) + " ) values ( " + sParam.Substring(0, sParam.Length - 1) + " );";
                        myCommand.Parameters.Clear();

                        foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        {
                            myCommand.Parameters.Add(GetSqlParam(oNodeP));
                        }

                        myCommand.CommandText = sqlString;
                        myCommand.ExecuteNonQuery();
                        break;

                    case "update":
                        sParam = "";
                        sWhere = "";
                        myCommand.Parameters.Clear();

                        foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        {
                            sParam += oNodeP.Attributes["name"].Value.Trim().Substring(1, oNodeP.Attributes["name"].Value.Trim().Length - 1) + "=" + oNodeP.Attributes["name"].Value.Trim() + ",";
                            myCommand.Parameters.Add(GetSqlParam(oNodeP));
                        }

                        foreach (System.Xml.XmlNode oNodeW in oNode.SelectNodes("where"))
                        {
                            sWhere += " and " + oNodeW.Attributes["field"].Value.Trim() + "='" + oNodeW.InnerText.Trim() + "' ";
                        }

                        sqlString = " update " + oNode.SelectSingleNode("table").InnerText.Trim() + " set " + sParam.Substring(0, sParam.Length - 1) + " where 1=1 " + sWhere;
                        myCommand.CommandText = sqlString;
                        myCommand.ExecuteNonQuery();
                        break;

                    case "delete":
                        sWhere = "";
                        foreach (System.Xml.XmlNode oNodeW in oNode.SelectNodes("where"))
                        {
                            sWhere += " and " + oNodeW.Attributes["field"].Value.Trim() + "='" + oNodeW.InnerText.Trim() + "' ";
                        }
                        sqlString = " delete " + oNode.SelectSingleNode("table").InnerText.Trim() + " where 1=1 " + sWhere;
                        myCommand.CommandText = sqlString;
                        myCommand.ExecuteNonQuery();
                        break;
                    case "cmd":
                        foreach (System.Xml.XmlNode oNodeC in oNode.ChildNodes)
                        {
                            foreach (System.Xml.XmlNode oNodeP in oNodeC.SelectNodes("param"))
                            {
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            }
                            sqlString = oNodeC.ChildNodes[0].InnerText;
                            myCommand.CommandText = sqlString;
                            myCommand.ExecuteNonQuery();
                        }
                        break;
                    case "select":
                        foreach (System.Xml.XmlNode oNodeQ in oNode.ChildNodes)
                        {
                            foreach (System.Xml.XmlNode oNodeP in oNodeQ.SelectNodes("param"))
                            {
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            }
                            sqlString = oNodeQ.ChildNodes[0].InnerText;
                            myCommand.CommandText = sqlString;
                            myDataAdapter.SelectCommand = myCommand;
                            myDataAdapter.Fill(myDataSet, oNodeQ.Name);
                        }
                        break;
                    case "sp":
                        foreach (System.Xml.XmlNode oNodeS in oNode.ChildNodes)
                        {
                            sqlString = oNodeS.SelectSingleNode("sp_name").InnerText.Trim();
                            myCommand.Parameters.Clear();
                            myCommand.CommandText = sqlString;
                            myCommand.CommandType = CommandType.StoredProcedure;
                            foreach (System.Xml.XmlNode oNodeP in oNodeS.SelectNodes("param"))
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            myDataAdapter.SelectCommand = myCommand;
                            myDataAdapter.Fill(myDataSet, oNodeS.Name);
                        }
                        break;
                }
            }
        }
        catch (Exception exp)
        {
            Error = exp.Message.ToString().Trim();
            throw exp;
        }
        finally
        {
            myDataSet.Dispose();
            myCommand.Dispose();
            myDataAdapter.Dispose();
            myConnection.Close();
            myConnection.Dispose();
        }
        return myDataSet;
    }
    #endregion

    #region GetSqlParam
    private SqlParameter GetSqlParam(System.Xml.XmlNode oNodeP)
    {
        SqlParameter param = new SqlParameter();
        param.ParameterName = oNodeP.Attributes["name"].Value;
        if (oNodeP.Attributes["type"] != null)
        {
            switch (oNodeP.Attributes["type"].Value.Trim().ToLower())
            {
                case "int":
                    param.SqlDbType = SqlDbType.Int;
                    param.Value = Convert.ToInt32(oNodeP.InnerText);
                    //如果值是空字串 把它設為null
                    if (oNodeP.InnerText == "") param.Value = DBNull.Value;
                    break;
                case "string":
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = oNodeP.InnerText;
                    break;
                case "nvarchar":
                    param.SqlDbType = SqlDbType.NVarChar;
                    param.Value = oNodeP.InnerText;
                    break;
                case "decimal":
                    param.SqlDbType = SqlDbType.Decimal;
                    param.Value = Convert.ToDecimal(oNodeP.InnerText);
                    //如果值是空字串 把它設為null
                    if (oNodeP.InnerText == "") param.Value = DBNull.Value;
                    break;
                case "char":
                    param.SqlDbType = SqlDbType.Char;
                    param.Value = oNodeP.InnerText;
                    break;
                case "datetime":
                    param.SqlDbType = SqlDbType.DateTime;
                    param.Value = oNodeP.InnerText;
                    //如果值是空字串 把它設為null
                    if (oNodeP.InnerText == "") param.Value = DBNull.Value;
                    break;
                case "bit":
                    param.SqlDbType = SqlDbType.Bit;
                    param.Value = oNodeP.InnerText;
                    //如果值是空字串 把它設為null
                    if (oNodeP.InnerText == "") param.Value = DBNull.Value;
                    break;
                case "image":
                    param.SqlDbType = SqlDbType.Image;
                    param.Value = oNodeP.InnerText;
                    break;
                case "text":
                    param.SqlDbType = SqlDbType.Text;
                    param.Value = oNodeP.InnerText;
                    break;
                case "null":
                    param.Value = DBNull.Value;
                    break;
                default:
                    param.Value = oNodeP.InnerText;
                    break;
            }
        }
        else
            param.Value = oNodeP.InnerText;

        return param;
    }
    #endregion

    #region ExeCmd
    public int ExeCmd(string conn, string XMLString)
    {
        /*傳入xml字串
        <nonquery>
            <update><![CDATA[update project set value='5' where id='1']]></update>
            <delete><![CDATA[delete project where id='1']]></delete>
        </nonquery>
        */
        string sqlString = "";
        int icount = 0;

        //連線,取得資料庫資料
        SqlTransaction myTrans;
        SqlConnection myConnection = new SqlConnection(conn);
        myConnection.Open();
        myTrans = myConnection.BeginTransaction();
        SqlCommand myCommand = new SqlCommand();
        myCommand.Connection = myConnection;
        myCommand.Transaction = myTrans;

        //取得command節點
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(XMLString);
        System.Xml.XmlNode oNodeSQL = doc.SelectSingleNode("//nonquery");

        try
        {
            foreach (System.Xml.XmlNode oNode in oNodeSQL.ChildNodes)
            {
                sqlString = oNode.InnerText;
                myCommand.CommandText = sqlString;
                icount += myCommand.ExecuteNonQuery();
            }
            myTrans.Commit();
        }
        catch (Exception exp)
        {
            myTrans.Rollback();
            throw exp;
        }
        finally
        {
            myCommand.Dispose();
            myConnection.Close();
            myConnection.Dispose();
        }
        return icount;
    }
    #endregion

    #region GetDS
    public DataSet GetDS(string conn, string XMLString)
    {
        /*傳入xml字串
        <query>
            <project><![CDATA[select * from project]]></project>
            <require><![CDATA[select * from require]]></require>
        </query>
        */
        string sqlString = "";
        DataSet myDataSet = new DataSet();

        //連線,取得資料庫資料
        SqlConnection myConnection = new SqlConnection(conn);
        myConnection.Open();
        SqlCommand myCommand = new SqlCommand();
        myCommand.Connection = myConnection;
        myCommand.CommandTimeout = 30000;

        SqlDataAdapter myDataAdapter = new SqlDataAdapter("", conn);

        //取得command節點
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(XMLString);
        System.Xml.XmlNode oNodeSQL = doc.SelectSingleNode("//query");

        try
        {
            foreach (System.Xml.XmlNode oNode in oNodeSQL.ChildNodes)
            {
                sqlString = oNode.InnerText;
                myCommand.CommandText = sqlString;
                myDataAdapter.SelectCommand = myCommand;
                myDataAdapter.Fill(myDataSet, oNode.Name);
            }
        }
        catch (Exception exp)
        {
            throw exp;
        }
        finally
        {
            myDataSet.Dispose();
            myCommand.Dispose();
            myDataAdapter.Dispose();
            myConnection.Close();
            myConnection.Dispose();
        }
        return myDataSet;
    }
    #endregion

    #region Exe2DS
    public DataSet Exe2DS(string conn, string XMLString)
    {
        /*傳入xml字串
        <sql>
            <cmdparam>
                <insert>
                    <table><![CDATA[passwd]]></table>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                </insert>
                <update>
                    <table><![CDATA[passwd]]></table>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                    <where field="sn"><![CDATA[value]]></where>
                </update>
                <delete>
                    <table><![CDATA[passwd]]></table>
                    <where field="sn"><![CDATA[value]]></where>
                </delete>
            </cmdparam>
            <nonquery>
                <update><![CDATA[update project set value='5' where id='1']]></update>
                <delete><![CDATA[delete project where id='1']]></delete>
            </nonquery>
            <query>
                <project><![CDATA[select * from project]]></project>
                <require><![CDATA[select * from require]]></require>
            </query>
            <sp>
                <ds_table>
                    <sp_name>QueryUser</sp_name>
                    <param name="@id" type="string"><![CDATA[darren]]></param>
                </ds_table>
            </sp>
        </sql>
        */
        string sqlString = "";
        string sField = "";
        string sParam = "";
        string sWhere = "";
        DataSet myDataSet = new DataSet();

        //連線,取得資料庫資料
        SqlTransaction myTrans;
        SqlConnection myConnection = new SqlConnection(conn);
        myConnection.Open();
        myTrans = myConnection.BeginTransaction();
        SqlCommand myCommand = new SqlCommand();
        myCommand.Connection = myConnection;
        myCommand.Transaction = myTrans;

        SqlDataAdapter myDataAdapter = new SqlDataAdapter("", myConnection);

        //取得command節點
        System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
        doc.LoadXml(XMLString);
        System.Xml.XmlNodeList oNodeInsert = doc.DocumentElement.SelectNodes("insert");
        System.Xml.XmlNodeList oNodeUpdate = doc.DocumentElement.SelectNodes("update");
        System.Xml.XmlNodeList oNodeDelete = doc.DocumentElement.SelectNodes("delete");
        System.Xml.XmlNode oNodeCmdParam = doc.DocumentElement.SelectSingleNode("cmdparam");
        System.Xml.XmlNode oNodeNon = doc.DocumentElement.SelectSingleNode("nonquery");
        System.Xml.XmlNode oNodeQry = doc.DocumentElement.SelectSingleNode("query");
        System.Xml.XmlNode oNodeSp = doc.DocumentElement.SelectSingleNode("sp");

        try
        {
            if (oNodeCmdParam != null)
            {
                foreach (System.Xml.XmlNode oNode in oNodeCmdParam.ChildNodes)
                {
                    switch (oNode.Name.Trim().ToLower())
                    {
                        case "insert":
                            sField = "";
                            sParam = "";
                            foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                            {
                                sField += oNodeP.Attributes["name"].Value.Trim().Substring(1, oNodeP.Attributes["name"].Value.Trim().Length - 1) + ",";
                                sParam += oNodeP.Attributes["name"].Value.Trim() + ",";
                            }

                            sqlString = " insert into " + oNode.SelectSingleNode("table").InnerText.Trim() + " ( " + sField.Substring(0, sField.Length - 1) + " ) values ( " + sParam.Substring(0, sParam.Length - 1) + " );";
                            myCommand.Parameters.Clear();

                            foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                            {
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            }

                            myCommand.CommandText = sqlString;
                            myCommand.ExecuteNonQuery();
                            break;
                        case "update":
                            sParam = "";
                            sWhere = "";
                            myCommand.Parameters.Clear();

                            foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                            {
                                sParam += oNodeP.Attributes["name"].Value.Trim().Substring(1, oNodeP.Attributes["name"].Value.Trim().Length - 1) + "=" + oNodeP.Attributes["name"].Value.Trim() + ",";
                                myCommand.Parameters.Add(GetSqlParam(oNodeP));
                            }

                            foreach (System.Xml.XmlNode oNodeW in oNode.SelectNodes("where"))
                            {
                                sWhere += " and " + oNodeW.Attributes["field"].Value.Trim() + "='" + oNodeW.InnerText.Trim() + "' ";
                            }

                            sqlString = " update " + oNode.SelectSingleNode("table").InnerText.Trim() + " set " + sParam.Substring(0, sParam.Length - 1) + " where 1=1 " + sWhere;
                            myCommand.CommandText = sqlString;
                            myCommand.ExecuteNonQuery();
                            break;
                        case "delete":
                            sWhere = "";
                            foreach (System.Xml.XmlNode oNodeW in oNode.SelectNodes("where"))
                            {
                                sWhere += " and " + oNodeW.Attributes["field"].Value.Trim() + "='" + oNodeW.InnerText.Trim() + "' ";
                            }
                            sqlString = " delete " + oNode.SelectSingleNode("table").InnerText.Trim() + " where 1=1 " + sWhere;
                            myCommand.CommandText = sqlString;
                            myCommand.ExecuteNonQuery();
                            break;
                    }
                }
            }

            if (oNodeNon != null)
            {
                foreach (System.Xml.XmlNode oNode in oNodeNon.ChildNodes)
                {
                    sqlString = oNode.InnerText;
                    myCommand.CommandText = sqlString;
                    myCommand.ExecuteNonQuery();

                }
            }
            if (oNodeQry != null)
            {
                foreach (System.Xml.XmlNode oNodeQ in oNodeQry.ChildNodes)
                {
                    sqlString = oNodeQ.InnerText;
                    myCommand.CommandText = sqlString;
                    myDataAdapter.SelectCommand = myCommand;
                    myDataAdapter.Fill(myDataSet, oNodeQ.Name);
                }
            }
            if (oNodeSp != null)
            {
                foreach (System.Xml.XmlNode oNode in oNodeSp.ChildNodes)
                {
                    sqlString = oNode.SelectSingleNode("sp_name").InnerText.Trim();
                    myCommand.Parameters.Clear();
                    myCommand.CommandText = sqlString;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    foreach (System.Xml.XmlNode oNodeP in oNode.SelectNodes("param"))
                        myCommand.Parameters.Add(GetSqlParam(oNodeP));
                    myDataAdapter.SelectCommand = myCommand;
                    myDataAdapter.Fill(myDataSet, oNode.Name);

                }
            }
            myTrans.Commit();
        }
        catch (Exception exp)
        {
            myTrans.Rollback();
            throw exp;
        }
        finally
        {
            myDataSet.Dispose();
            myCommand.Dispose();
            myDataAdapter.Dispose();
            myConnection.Close();
            myConnection.Dispose();
        }
        return myDataSet;
    }
    #endregion
}