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
public class _ControlBase : System.Web.UI.UserControl
{
  
    protected DAL.DBUtil db = new DAL.DBUtil();
   
    public _ControlBase()
	{
		//
        // TODO: 在此加入建構函式的程式碼
        //
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


    protected string Capital(string str)
    {
        return str.ToUpper();
    }


    //get county name
    protected string getCountyName(string _county_code, string _lan)
    {
        string rtn_val = string.Empty;
        if (_lan == "tw")
        {
            if (_county_code == "1")
            {
                rtn_val = "台北市";
            }
            else if (_county_code == "2")
            {
                rtn_val = "新北市";
            }
            else if (_county_code == "3")
            {
                rtn_val = "基隆市";
            }
            else if (_county_code == "4")
            {
                rtn_val = "宜蘭縣";
            }
            else if (_county_code == "5")
            {
                rtn_val = "桃園縣";
            }
            else if (_county_code == "6")
            {
                rtn_val = "新竹縣";
            }
            else if (_county_code == "7")
            {
                rtn_val = "新竹市";
            }
            else if (_county_code == "8")
            {
                rtn_val = "苗栗縣";
            }
            else if (_county_code == "9")
            {
                rtn_val = "台中市";
            }
            else if (_county_code == "10")
            {
                rtn_val = "彰化縣";
            }
            else if (_county_code == "11")
            {
                rtn_val = "南投縣";
            }
            else if (_county_code == "12")
            {
                rtn_val = "雲林縣";
            }
            else if (_county_code == "13")
            {
                rtn_val = "嘉義市";
            }
            else if (_county_code == "14")
            {
                rtn_val = "嘉義縣";
            }
            else if (_county_code == "15")
            {
                rtn_val = "台南市";
            }
            else if (_county_code == "16")
            {
                rtn_val = "高雄市";
            }
            else if (_county_code == "17")
            {
                rtn_val = "屏東縣";
            }
            else if (_county_code == "18")
            {
                rtn_val = "花蓮縣";
            }
            else if (_county_code == "19")
            {
                rtn_val = "台東縣";
            }
            else if (_county_code == "20")
            {
                rtn_val = "澎湖縣";
            }
            else if (_county_code == "21")
            {
                rtn_val = "連江縣";
            }
            else if (_county_code == "22")
            {
                rtn_val = "金門縣";
            }

        }

        return rtn_val;
    }



    protected static string GetClientClick(string _value)
    {

        return String.Format("showDiv('{0}');", _value);

    }

    public string string_substring(string str, int num)
    {
        if (str.Length > num)
        {
            return str.Substring(0, num) + "..";
        }
        else
        {
            return str;
        }
    }

    public string showScheduleList(string _sc_d_id)
    {
        string rtn_val = string.Empty;

        string sql_select = "SELECT TOP 4 b.site_id, b.site_name, b.county_code, b.index_flickr FROM iutw_schedule_site a LEFT JOIN iutw_site b ON a.site_id = b.site_id WHERE a.schedule_date_id = '" + _sc_d_id + "' ORDER BY a.sorting";

        SqlDataReader sdr = db.ExecuteReader(sql_select);

        int count = 0;

        while (sdr.Read())
        {
            if (count == 0)
            {
                rtn_val += "<a href='/site_detail.aspx?s_id=" + sdr["site_id"].ToString() + "' class='link1' target='_blank'><b>" + string_substring(sdr["site_name"].ToString(), 6) + "</b>[" + getCountyName(sdr["county_code"].ToString(), "tw") + "]</a>";
            }
            else
            {
                rtn_val += " <img src='/images/s_arrow.png' /> <a href='/site_detail.aspx?s_id=" + sdr["site_id"].ToString() + "' class='link1' target='_blank'><b>" + string_substring(sdr["site_name"].ToString(), 6) + "</b>[" + getCountyName(sdr["county_code"].ToString(), "tw") + "]</a>";
            }
            count = count + 1;
        }

        sdr.Close();
        if (rtn_val != "")
        {
            return rtn_val + " <img src='/images/s_arrow.png' /> ....";
        }
        else
        {
            return rtn_val;
        }
    }
}
