using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;


public partial class event_15_spring_index : System.Web.UI.Page
{

    #region 共用參數
    Sql s = new Sql();//資料庫的
    Public _Public = new Public();//共用的
    blAction _blAction = new blAction();//活動的
    check_input _check = new check_input();//檢查
    string sAction_No = "417";//活動編號[要改]
    string sCareer = "ikki";//事業處[要改]
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];//事業處編號
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        int iCNT = _blAction.BindTotalCount(sAction_No);//取得目前資料庫數量


        txtName_01.Text = getNameValue2(iCNT.ToString()).ToString();
        txtName_02.Text = getNameValue2((iCNT - 1).ToString()).ToString();
        txtName_03.Text = getNameValue2((iCNT - 2).ToString()).ToString();
        txtName_04.Text = getNameValue2((iCNT - 3).ToString()).ToString();
        txtName_05.Text = getNameValue2((iCNT - 4).ToString()).ToString();
        txtName_06.Text = getNameValue2((iCNT - 5).ToString()).ToString();
        txtName_07.Text = getNameValue2((iCNT - 6).ToString()).ToString();
        txtName_08.Text = getNameValue2((iCNT - 7).ToString()).ToString();
        txtName_09.Text = getNameValue2((iCNT - 8).ToString()).ToString();
        txtName_10.Text = getNameValue2((iCNT - 9).ToString()).ToString();

        txtPlace_01.Text = getPlaceValue3(iCNT.ToString()).ToString();
        txtPlace_02.Text = getPlaceValue3((iCNT - 1).ToString()).ToString();
        txtPlace_03.Text = getPlaceValue3((iCNT - 2).ToString()).ToString();
        txtPlace_04.Text = getPlaceValue3((iCNT - 3).ToString()).ToString();
        txtPlace_05.Text = getPlaceValue3((iCNT - 4).ToString()).ToString();
        txtPlace_06.Text = getPlaceValue3((iCNT - 5).ToString()).ToString();
        txtPlace_07.Text = getPlaceValue3((iCNT - 6).ToString()).ToString();
        txtPlace_08.Text = getPlaceValue3((iCNT - 7).ToString()).ToString();
        txtPlace_09.Text = getPlaceValue3((iCNT - 8).ToString()).ToString();
        txtPlace_10.Text = getPlaceValue3((iCNT - 9).ToString()).ToString();

    }


    public string getNameValue2(string Value1)
    {


        string xmlString = "";

        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[select [value2] FROM [website].[dbo].[wang_action_members] where Action_NO='" + sAction_No + "' and value1='" + Value1 + "']]>");

            sb.Append("</list>");
            sb.Append("</select>");
            sb.Append("</sql>");
            string sError = "";
            DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);


            if (DS.Tables[0].Rows.Count > 0)
            {
                xmlString = DS.Tables[0].Rows[0]["value2"].ToString().Trim();  
            }

        }
        catch (Exception ex)
        {
            xmlString = "錯誤";
        }

        return xmlString;

    }


    public string getPlaceValue3(string Value1)
    {

        string xmlString = "";

        try
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[select [value3] FROM [website].[dbo].[wang_action_members] where Action_NO='" + sAction_No + "' and value1='" + Value1 + "']]>");

            sb.Append("</list>");
            sb.Append("</select>");
            sb.Append("</sql>");
            string sError = "";
            DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);


            if (DS.Tables[0].Rows.Count > 0)
            {
                xmlString = DS.Tables[0].Rows[0]["value3"].ToString().Trim();
            }

        }
        catch (Exception ex)
        {

        }

        return xmlString;
    }
}
