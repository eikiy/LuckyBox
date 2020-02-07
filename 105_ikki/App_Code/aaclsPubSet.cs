using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// aaclsPubSet 的摘要描述
/// </summary>
public class aaclsPubSet
{
    #region 站台共用參數
    public static string strP_ShopNo = "105";
    public static string strP_Cname = "藝奇";
    public static string strP_Ename = "ikki";
    public static string strP_Ename2 = "Ikki";
    //public static string strP_WWW = "www.famonn.com";
    //public static string strP_EMail = "service@famonn.com";
    //public static string strP_0800 = "0800-099-779";
    #endregion

    #region aaclsPubSet
    public aaclsPubSet()
    {
    }
    #endregion

    #region REG_script
    public static void REG_script(Page page, string strScript)
    {
        page.ClientScript.RegisterStartupScript(page.GetType(), Guid.NewGuid().ToString(), strScript);
    }
    #endregion

    #region 產生下拉縣市
    public static void BindCity(DropDownList ddl)
    {
        Sql s = new Sql();
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select no,name from city order by LEN(no),no]]>");
        //sb.Append(s.ParamXML("city", sCity));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        ddl.DataSource = DS;
        ddl.DataMember = "list";
        ddl.DataTextField = "name";
        ddl.DataValueField = "no";
        ddl.DataBind();
        //
        ddl.Items.Insert(0, new ListItem("請選擇", ""));
    }
    #endregion

    #region 產生下拉區
    public static void BindCity2Area(DropDownList ddl, string strCity)
    {
        Sql s = new Sql();
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[select zip+area as name,zip from area where city=@city]]>");
        sb.Append(s.ParamXML("city", strCity));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        ddl.DataSource = DS;
        ddl.DataMember = "list";
        ddl.DataTextField = "name";
        ddl.DataValueField = "zip";
        ddl.DataBind();
        //
        ddl.Items.Insert(0, new ListItem("請選擇", ""));
    }
    #endregion

    #region 產生下拉年
    /// <summary>
    /// 西元年
    /// </summary>
    /// <param name="ddl">控制項名稱</param>
    /// <param name="intS_Year">幾年</param>
    public static void BindYear(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("請選擇", ""));
        intTmp = intS_Year - 1 + 1911;
        ddl.Items.Add(intTmp.ToString());
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            ddl.Items.Add(new ListItem(intTmp.ToString()));
        }
    }
    public static void BindChineseYear(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("請選擇", ""));
        intTmp = intS_Year - 1 + 1911;
        ddl.Items.Add(new ListItem(string.Format("{0}以前(民國{1}年前)", intS_Year - 1 + 1911, intS_Year - 1), intTmp.ToString()));
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            ddl.Items.Add(new ListItem(string.Format("{0}(民國{1}年)", i + 1911, i), intTmp.ToString()));
        }
    }
    #endregion

    #region 產生下拉門市
    public static void BindStore(DropDownList ddl, string strStoreNo)
    {
        Sql s = new Sql();
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append(string.Format("<list><![CDATA[select StoreNo,StoreName from Cancer.wanggroup.dbo.Store_View where CareerNo='{0}' and StoreNo<>'{0}00' AND ISNULL(CloseDate,'')='' AND OpenDate <=GETDATE() ORDER BY ZipCode ASC]]>", strStoreNo));
        sb.Append("</list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.wanggroup, sb.ToString(), out sError);
        ddl.DataSource = DS;
        ddl.DataMember = "list";
        ddl.DataTextField = "StoreName";
        ddl.DataValueField = "StoreNo";
        ddl.DataBind();
        ddl.Items.Insert(0, new ListItem("請選擇", ""));
    }
    #endregion

    #region Email檢核
    public static bool CheckEMail(string strEMail)
    {
        if (Regex.IsMatch(strEMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    #endregion
}