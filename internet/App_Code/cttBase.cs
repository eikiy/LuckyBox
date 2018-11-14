using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Text;

/// <summary>
/// inter_function 的摘要描述
/// </summary>
public class cttBase : System.Web.UI.Page
{
    protected SqlDataReader datareader;
    protected SqlDataReader sdr;
    protected DAL.DBUtil db = new DAL.DBUtil();
    protected string filePath = "/upload/";
    protected string imgPath = "/intranet/images/";
    protected string newsPath = "/cont_att/";
    protected string role_id = string.Empty;
    //protected string system_email = ConfigurationManager.AppSettings["system_email"];
    public cttBase()
	{
		//
        // TODO: 在此加入建構函式的程式碼
        //
    }


    public string AlertStr(string str, string RedirectPath)
    {
        string return_value;
        return_value = "<Script Language=JavaScript>";
        return_value += "alert('" + str + "');";
        return_value += "window.location ='" + RedirectPath + "';";
        return_value += "</" + "script>";
        return return_value;
    }


    protected void gvNews_OnRowCreated(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            if (e.Row.RowState == DataControlRowState.Alternate)
            {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#EFFBFB';");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#F2F2F2';");
            }
            else
            {
                e.Row.Attributes.Add("onmouseover", "this.style.backgroundColor='#EFFBFB';");
                e.Row.Attributes.Add("onmouseout", "this.style.backgroundColor='#FFFFFF';");
            }
        }
    }

   


    protected string AppSettings(string Key)
    {
        string str = "";
        try
        {
            str = ConfigurationManager.AppSettings[Key];
        }
        catch
        {
            str = "";
        }

        return str;
    }


}
