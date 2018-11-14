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
using System.Net.Mail;
using System.Globalization;
/// <summary>
/// inter_function 的摘要描述
/// </summary>
public class _Base : System.Web.UI.Page
{
  
    protected DAL.DBUtil db = new DAL.DBUtil();

    //動物園
    protected double BR13_lo = 121.579338;
    protected double BR13_la = 24.998197;
    //木柵
    protected double BR12_lo = 121.573162;
    protected double BR12_la = 24.998233;
    //萬芳社區
    protected double BR11_lo = 121.568098;
    protected double BR11_la = 24.998583;
    //萬芳醫院
    protected double BR10_lo = 121.558099;
    protected double BR10_la = 24.999633;
    //辛亥
    protected double BR9_lo = 121.557107;
    protected double BR9_la = 25.005475;
    //麟光
    protected double BR8_lo = 121.558785;
    protected double BR8_la = 25.018534;
    //六張犁
    protected double BR7_lo = 121.553121;
    protected double BR7_la = 25.023784;
    //科技大樓
    protected double BR6_lo = 121.543422;
    protected double BR6_la = 25.026117;
    //大安
    protected double BR5_lo = 121.543551;
    protected double BR5_la = 25.032943;
    //忠孝復興
    protected double BR4_lo = 121.543808;
    protected double BR4_la = 25.041593;
    //南京東路
    protected double BR3_lo = 121.544011;
    protected double BR3_la = 25.052319;
    //中山國中
    protected double BR2_lo = 121.544237;
    protected double BR2_la = 25.060838;
    //松山機場
    protected double BR1_lo = 121.551996;
    protected double BR1_la = 25.063;
    
    //protected string system_email = ConfigurationManager.AppSettings["system_email"];
    public _Base()
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

    protected string convertDate(string _date)
    {
        if (_date != "")
        {
            if (_date != "4000/01/01")
            {
                return DateTime.Parse(_date).ToString("yyyy/MM/dd") + "<br /> (" + DateTime.Parse(_date).ToString("ddd") + ")";
            }
            else
            {
                return "注意事項<br />";
            }
        }
        else
        {
            return "";
        }
    }

    protected string convertDatePDF(string _date)
    {
        if (_date != "")
        {
            if (_date != "4000/01/01")
            {
                return DateTime.Parse(_date).ToString("yyyy/MM/dd") + "\n(" + DateTime.Parse(_date).ToString("ddd") + ")";
            }
            else
            {
                return "注意事項";
            }
        }
        else
        {
            return "";
        }
    }


    protected string convertDate2(string _date)
    {
        if (_date != "")
        {
            if (_date != "4000/01/01")
            {
                return DateTime.Parse(_date).ToString("yyyy/MM/dd") + " (" + DateTime.Parse(_date).ToString("ddd") + ") ";
            }
            else
            {
                return "<br />注意事項</br />";
            }
        }
        else
        {
            return "";
        }
    }

    protected string outPutScheduleSiteNameNew(string _s_id, string _site_name, string _site_tel, string _site_address, string _b_hour, string _longitude, string _latitude, string _c_name, string _c_address, string _c_tel, string _c_desc, string _c_longitude, string _c_latitude)
    {

        if (_s_id != "0")
        {
            string rtn_val = string.Empty;


            if (_site_tel != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "電話：" + _site_tel : "電話：" + _site_tel);
            }

            if (_site_address != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_site_address) + " [ 經度：" + _longitude + " 緯度：" + _latitude + "]" : "地址：" + replaceAddressWithBold(_site_address) + "[經度：" + _longitude + " 緯度：" + _latitude + "]");
            }

            if (_b_hour != "")
            {
                rtn_val += ((rtn_val != "") ? " <br />開放時間：" + _b_hour : _b_hour);
            }
            return "<a href='site_detail.aspx?s_id=" + _s_id + "' target='_blank' class='asd7'>" + _site_name + "</a><br />" + rtn_val;
        }
        else
        {
            string rtn_val = string.Empty;


            if (_c_tel != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "電話：" + _c_tel : "電話：" + _c_tel);
            }

            if (_c_address != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_c_address) + " [ 經度：" + _c_longitude + " 緯度：" + _c_latitude + "]" : "地址：" + replaceAddressWithBold(_c_address) + "[經度：" + _c_longitude + " 緯度：" + _c_latitude + "]");
            }

          
            return "<span class='asd7'>" + _c_name + "</span><br />" + rtn_val;
        }
    }

    protected string outPutScheduleSiteName(string _s_id, string _site_name, string _site_tel, string _site_address, string _b_hour, string _longitude, string _latitude)
    {
        string rtn_val = string.Empty;


        if (_site_tel != "")
        {
            rtn_val += ((rtn_val != "") ? " | " + "電話：" + _site_tel : "電話：" + _site_tel);
        }

        if (_site_address != "")
        {
            rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_site_address) + " [ 經度：" + _longitude + " 緯度：" + _latitude + "]" : "地址：" + replaceAddressWithBold(_site_address) + "[經度：" + _longitude + " 緯度：" + _latitude + "]");
        }

        if (_b_hour != "")
        {
            rtn_val += ((rtn_val != "") ? " <br />開放時間：" + _b_hour : _b_hour);
        }
        return "<a href='site_detail.aspx?s_id=" + _s_id + "' target='_blank' class='asd7'>" + _site_name + "</a><br />" + rtn_val;
    }

    protected string outPutScheduleSiteNamePDF(string _site_tel, string _site_address, string _b_hour, string _longitude, string _latitude)
    {
        string rtn_val = string.Empty;


        if (_site_tel != "")
        {
            rtn_val += ((rtn_val != "") ? " | " + "電話：" + _site_tel : "電話：" + _site_tel);
        }

        if (_site_address != "")
        {
            rtn_val += ((rtn_val != "") ? " \n" + "地址：" + _site_address + " [ 經度：" + _longitude + " 緯度：" + _latitude + "]" : "地址：" + _site_address + "[經度：" + _longitude + " 緯度：" + _latitude + "]");
        }

        if (_b_hour != "")
        {
            rtn_val += ((rtn_val != "") ? " \n開放時間：" + _b_hour : _b_hour);
        }
        return rtn_val;
    }

    protected string outPutScheduleSiteNameCheckNew(string _s_d_id, string _sorting, string _s_id, string _site_name, string _site_tel, string _site_address, string _b_hour, string _longitude, string _latitude, string _mon, string _tue, string _wed, string _thu, string _fri, string _sat, string _sun, string _c_name, string _c_address, string _c_tel, string _c_desc, string _c_longitude, string _c_latitude)
    {
        if (_s_id != "0")
        {
            string rtn_val = string.Empty;
            bool isDuplicate = false;
            bool isOpen = true;
            string _date = string.Empty;
            string sql = "SELECT count(*) AS _count FROM iutw_schedule_site WHERE schedule_date_id = '" + _s_d_id + "' AND site_id = '" + _s_id + "' AND sorting < '" + _sorting + "'";

            SqlDataReader sdr = db.ExecuteReader(sql);

            if (sdr.Read())
            {
                if (int.Parse(sdr["_count"].ToString()) > 0)
                {
                    isDuplicate = true;
                }
            }

            sdr.Close();

            string sql_date = "SELECT schedule_date FROM iutw_schedule_date WHERE schedule_date_id = '" + _s_d_id + "'";

            SqlDataReader sdr2 = db.ExecuteReader(sql_date);

            if (sdr2.Read())
            {
                _date = DateTime.Parse(sdr2["schedule_date"].ToString()).ToString("dddd", CultureInfo.InvariantCulture);

                if (_date == "Monday" && _mon == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Tuesday" && _tue == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Wednesday" && _wed == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Thursday" && _thu == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Friday" && _fri == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Saturday" && _sat == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Sunday" && _sun == "n")
                {
                    isOpen = false;
                }

            }

            sdr2.Close();

            if (_site_tel != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "電話：" + _site_tel : "電話：" + _site_tel);
            }

            if (_site_address != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_site_address) + " [ 經度：" + _longitude + " 緯度：" + _latitude + "]" : "地址：" + replaceAddressWithBold(_site_address) + "[經度：" + _longitude + " 緯度：" + _latitude + "]");
            }

            if (_b_hour != "")
            {
                rtn_val += ((rtn_val != "") ? " <br />開放時間：" + _b_hour : _b_hour);
            }
            return "<a href='site_detail.aspx?s_id=" + _s_id + "' target='_blank' class='asd7'>" + _site_name + " <a href='/target_list.aspx?t_id=" + _s_id + "#target_start'><img src='/images/b7_s.png' border='0' align='middle'></a> " + ((isDuplicate) ? "<span class='tip2'>(已重複)</span>" : "") + ((!isOpen) ? "<span class='tip2'>[本日未開放]</span>" : "") + "</a><br />" + rtn_val;
        }
        else
        {
            string rtn_val = string.Empty;

            if (_c_tel != "")
            {
                rtn_val +=  "電話：" + _c_tel;
            }

            rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_c_address) + " [ 經度：" + _c_longitude + " 緯度：" + _c_latitude + "]" : "地址：" + replaceAddressWithBold(_c_address) + " [ 經度：" + _c_longitude + " 緯度：" + _c_latitude + "]");

            if (_c_desc != "")
            {
                rtn_val += "<br />" + _c_desc;
            }

            return "<span class='asd7'>" + _c_name + "</span> <a href='/target_c_list.aspx?t_id=" + _s_id + "'><img src='/images/b7_s.png' border='0' align='middle' ></a><br />" + rtn_val;
        }
    }


    protected string outPutScheduleSiteNameCheck(string _s_d_id, string _sorting, string _s_id, string _site_name, string _site_tel, string _site_address, string _b_hour, string _longitude, string _latitude, string _mon, string _tue, string _wed, string _thu, string _fri, string _sat, string _sun)
    {
       
            string rtn_val = string.Empty;
            bool isDuplicate = false;
            bool isOpen = true;
            string _date = string.Empty;
            string sql = "SELECT count(*) AS _count FROM iutw_schedule_site WHERE schedule_date_id = '" + _s_d_id + "' AND site_id = '" + _s_id + "' AND sorting < '" + _sorting + "'";

            SqlDataReader sdr = db.ExecuteReader(sql);

            if (sdr.Read())
            {
                if (int.Parse(sdr["_count"].ToString()) > 0)
                {
                    isDuplicate = true;
                }
            }

            sdr.Close();

            string sql_date = "SELECT schedule_date FROM iutw_schedule_date WHERE schedule_date_id = '" + _s_d_id + "'";

            SqlDataReader sdr2 = db.ExecuteReader(sql_date);

            if (sdr2.Read())
            {
                _date = DateTime.Parse(sdr2["schedule_date"].ToString()).ToString("dddd", CultureInfo.InvariantCulture);

                if (_date == "Monday" && _mon == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Tuesday" && _tue == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Wednesday" && _wed == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Thursday" && _thu == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Friday" && _fri == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Saturday" && _sat == "n")
                {
                    isOpen = false;
                }
                else if (_date == "Sunday" && _sun == "n")
                {
                    isOpen = false;
                }

            }

            sdr2.Close();

            if (_site_tel != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "電話：" + _site_tel : "電話：" + _site_tel);
            }

            if (_site_address != "")
            {
                rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_site_address) + " [ 經度：" + _longitude + " 緯度：" + _latitude + "]" : "地址：" + replaceAddressWithBold(_site_address) + "[經度：" + _longitude + " 緯度：" + _latitude + "]");
            }

            if (_b_hour != "")
            {
                rtn_val += ((rtn_val != "") ? " <br />開放時間：" + _b_hour : _b_hour);
            }
            return "<a href='site_detail.aspx?s_id=" + _s_id + "' target='_blank' class='asd7'>" + _site_name + ((isDuplicate) ? "<span class='tip2'>(已重複)</span>" : "") + ((!isOpen) ? "<span class='tip2'>[本日未開放]</span>" : "") + "</a><br />" + rtn_val;
        
       
    }

    protected string outPrintScheduleSiteName(string _s_id, string _site_name, string _site_tel, string _site_address, string _b_hour, string _longitude, string _latitude)
    {
        string rtn_val = string.Empty;


        if (_site_tel != "")
        {
            rtn_val += ((rtn_val != "") ? " | " + "電話：" + _site_tel : "電話：" + _site_tel);
        }

        if (_site_address != "")
        {
            rtn_val += ((rtn_val != "") ? " | " + "地址：" + replaceAddressWithBold(_site_address) + " [ 經度：" + _longitude + " 緯度：" + _latitude + "]" : "地址：" + replaceAddressWithBold(_site_address) + "[經度：" + _longitude + " 緯度：" + _latitude + "]");
        }

        if (_b_hour != "")
        {
            rtn_val += ((rtn_val != "") ? " <br />開放時間：" + _b_hour : _b_hour);
        }
        return "<b>" + _site_name + "</b><br />" + rtn_val;
    }

    protected double distance(double lat1, double lon1, double lat2, double lon2, char unit) 
    { 
        double theta = lon1 - lon2; 
        double dist = Math.Sin(deg2rad(lat1)) * Math.Sin(deg2rad(lat2)) + Math.Cos(deg2rad(lat1)) * Math.Cos(deg2rad(lat2)) * Math.Cos(deg2rad(theta)); 
        dist = Math.Acos(dist); 
        dist = rad2deg(dist); 
        dist = dist * 60 * 1.1515; 
        if (unit == 'K') 
        { 
            dist = dist * 1.609344; 
        } else if (unit == 'N') 
        { 
            dist = dist * 0.8684; 
        } 
        return (dist); 
    }
    //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://::  This function converts decimal degrees to radians             ::://:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    private double deg2rad(double deg) {  return (deg * Math.PI / 180.0);}
    //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::://::  This function converts radians to decimal degrees             ::://:::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
    private double rad2deg(double rad) {  return (rad / Math.PI * 180.0);}

    //四捨五入取小數點後兩位
    protected double hRound(double val)
    {
        return Math.Round(val, 2, MidpointRounding.AwayFromZero);
    }

    protected string getDistanceNew(string _s_id, string _s_d_id, string _s_s_id, string _latitude, string _longitude, string _c_latitude, string _c_longitude, string _type)
    {
        if (_s_id != "0")
        {
            string rtn_val = string.Empty;
            string destin_site_name = string.Empty;
            string sql_site = "SELECT b.site_name FROM iutw_schedule_site a, iutw_site b WHERE a.site_id = b.site_id AND a.schedule_site_id = '" + _s_s_id + "'";

            SqlDataReader datareader = db.ExecuteReader(sql_site);

            if (datareader.Read())
            {
                destin_site_name = datareader["site_name"].ToString();
            }

            datareader.Close();

            
            string sql = "SELECT top 1 b.latitude, b.longitude, b.site_name, a.site_id, a.c_latitude, a.c_longitude, a.c_name FROM iutw_schedule_site a LEFT JOIN iutw_site b"
                       + " ON a.site_id = b.site_id WHERE a.schedule_date_id = '" + _s_d_id + "' AND a.sorting < (SELECT sorting FROM iutw_schedule_site WHERE schedule_site_id = '" + _s_s_id + "')"
                       + " ORDER BY a.sorting DESC";

            SqlDataReader sdr = db.ExecuteReader(sql);

            if (sdr.Read())
            {
                if (sdr["site_id"].ToString() != "0")
                {
                    if (sdr["latitude"].ToString() != "" && sdr["longitude"].ToString() != "")
                    {
                        if (_type == "1")
                        {
                            rtn_val += "<tr><td class='tip' align='left' colspan='2' valign='top'><table border='0' width='100%'><tr><td width='10%'></td><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td></tr>";
                        }
                        else if (_type == "2")
                        {
                            rtn_val += "<tr><td class='tip' valign='top'><table border='0' width='100%'><tr><td width='20%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left' width='30%'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                        }
                        else if (_type == "3")
                        {
                            rtn_val += "<tr><td class='tip' valign='top'><table border='0' width='100%'><tr><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                        }
                    }
                }
                else
                {
                    if (sdr["c_latitude"].ToString() != "" && sdr["c_longitude"].ToString() != "")
                    {
                        if (_type == "1")
                        {
                            rtn_val += "<tr><td class='tip' align='left' colspan='2' valign='top'><table border='0' width='100%'><tr><td width='10%'></td><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["c_latitude"].ToString()), double.Parse(sdr["c_longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["c_latitude"].ToString() + "," + sdr["c_longitude"].ToString() + "(" + sdr["c_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td></tr>";
                        }
                        else if (_type == "2")
                        {
                            rtn_val += "<tr><td class='tip' valign='top'><table border='0' width='100%'><tr><td width='20%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["c_latitude"].ToString()), double.Parse(sdr["c_longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left' width='30%'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["c_latitude"].ToString() + "," + sdr["c_longitude"].ToString() + "(" + sdr["c_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                        }
                        else if (_type == "3")
                        {
                            rtn_val += "<tr><td class='tip' valign='top'><table border='0' width='100%'><tr><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["c_latitude"].ToString()), double.Parse(sdr["c_longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["c_latitude"].ToString() + "," + sdr["c_longitude"].ToString() + "(" + sdr["c_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                        }
                    }
                }
                

            }

            sdr.Close();
            return rtn_val;
        }
        else
        {
            string rtn_val = string.Empty;
            string destin_site_name = string.Empty;
            string sql_site = "SELECT c_name FROM iutw_schedule_site WHERE schedule_site_id = '" + _s_s_id + "'";

            SqlDataReader datareader = db.ExecuteReader(sql_site);

            if (datareader.Read())
            {
                destin_site_name = datareader["c_name"].ToString();
            }

            datareader.Close();

            string sql = "SELECT top 1 b.latitude, b.longitude, b.site_name FROM iutw_schedule_site a, iutw_site b"
                       + " WHERE a.site_id = b.site_id AND a.schedule_date_id = '" + _s_d_id + "' AND a.sorting < (SELECT sorting FROM iutw_schedule_site WHERE schedule_site_id = '" + _s_s_id + "')"
                       + " ORDER BY a.sorting DESC";

            SqlDataReader sdr = db.ExecuteReader(sql);

            if (sdr.Read())
            {
                if (sdr["latitude"].ToString() != "" && sdr["longitude"].ToString() != "")
                {
                    if (_type == "1")
                    {
                        rtn_val += "<tr><td class='tip' align='left' colspan='2'><table border='0' width='100%'><tr><td width='10%'></td><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_c_latitude), double.Parse(_c_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_c_latitude + ", " + _c_longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td></tr>";
                    }
                    else if (_type == "2")
                    {
                        rtn_val += "<tr><td class='tip'><table border='0' width='100%'><tr><td width='20%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_c_latitude), double.Parse(_c_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left' width='30%'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_c_latitude + ", " + _c_longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                    }
                    else if (_type == "3")
                    {
                        rtn_val += "<tr><td class='tip' valign='middle'><table border='0' width='100%'><tr><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_c_latitude), double.Parse(_c_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_c_latitude + ", " + _c_longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                    }
                }
            }

            sdr.Close();
            return rtn_val;
        }


        

    }

    protected string getDistance(string _s_d_id, string _s_s_id, string _latitude, string _longitude, string _type)
    {
        string rtn_val = string.Empty;
        string destin_site_name = string.Empty;
        string sql_site = "SELECT b.site_name FROM iutw_schedule_site a, iutw_site b WHERE a.site_id = b.site_id AND schedule_site_id = '" + _s_s_id + "'";

        SqlDataReader datareader = db.ExecuteReader(sql_site);

        if (datareader.Read())
        {
            destin_site_name = datareader["site_name"].ToString();
        }

        datareader.Close();

        string sql = "SELECT top 1 b.latitude, b.longitude, b.site_name FROM iutw_schedule_site a, iutw_site b"
                   + " WHERE a.site_id = b.site_id AND a.schedule_date_id = '" + _s_d_id + "' AND a.sorting < (SELECT sorting FROM iutw_schedule_site WHERE schedule_site_id = '" + _s_s_id + "')"
                   + " ORDER BY a.sorting DESC";

        SqlDataReader sdr = db.ExecuteReader(sql);

        if (sdr.Read())
        {
            if (sdr["latitude"].ToString() != "" && sdr["longitude"].ToString() != "")
            {
                if (_type == "1")
                {
                    rtn_val += "<tr><td class='tip' align='left' colspan='2'><table border='0' width='100%'><tr><td width='10%'>&nbsp;</td><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left' width='25%'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td></tr>";
                }
                else if (_type == "2")
                {
                    rtn_val += "<tr><td class='tip'><table border='0' width='100%'><tr><td width='20%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left' width='30%'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                }
                else if (_type == "3")
                {
                    rtn_val += "<tr><td class='tip' valign='middle'><table border='0' width='100%'><tr><td width='15%' align='left' valign='middle'>&#8593;&nbsp;約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), double.Parse(sdr["latitude"].ToString()), double.Parse(sdr["longitude"].ToString()), 'K')).ToString() + "公里&nbsp;&#8595;</td><td align='left'><a href='http://maps.google.com.tw/maps?f=q&hl=zh-tw&saddr=" + Server.UrlEncode(sdr["latitude"].ToString() + "," + sdr["longitude"].ToString() + "(" + sdr["site_name"].ToString() + ")") + "&daddr=" + Server.UrlEncode(_latitude + ", " + _longitude + "(" + destin_site_name + ")") + "' target='_blank'><img src='/images/btn_how.jpg' border='0' /></a></td><td width='50%'><img src='/images/arrow.gif'></td></tr></table></td><td></td></tr>";
                }
            }
        }

        sdr.Close();

        return rtn_val;

    }

    protected string getDistanceFromDownTown(string _county_code, string _latitude, string _longitude)
    {
        if (_county_code == "1")
        {
            return "(台北車站)約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), 25.048281, 121.515656, 'K')).ToString() + "公里";
        }
        else if (_county_code == "2")
        {
            return "(台北車站)約" + hRound(distance(double.Parse(_latitude), double.Parse(_longitude), 25.048281, 121.515656, 'K')).ToString() + "公里";
        }
        else
        {
            return "";
        }
    }

    protected string getDistanceFromTarget(string _t_name, string _t_latitude, string _t_longitude, string _latitude, string _longitude)
    {

        return "<b>約" + hRound(distance(double.Parse(_t_latitude), double.Parse(_t_longitude), double.Parse(_latitude), double.Parse(_longitude), 'K')).ToString() + "公里</b>";
       
    }

    private string replaceAddressWithBold(string _address)
    {
        string rtn_val = string.Empty;
        rtn_val = _address.Replace("台北市", "<b>台北市</b>");
        rtn_val = rtn_val.Replace("新北市", "<b>新北市</b>");
        rtn_val = rtn_val.Replace("基隆市", "<b>基隆市</b>");
        rtn_val = rtn_val.Replace("宜蘭縣", "<b>宜蘭縣</b>");
        rtn_val = rtn_val.Replace("桃園縣", "<b>桃園縣</b>");
        rtn_val = rtn_val.Replace("新竹縣", "<b>新竹縣</b>");
        rtn_val = rtn_val.Replace("新竹市", "<b>新竹市</b>");
        rtn_val = rtn_val.Replace("苗栗縣", "<b>苗栗縣</b>");
        rtn_val = rtn_val.Replace("台中市", "<b>台中市</b>");
        rtn_val = rtn_val.Replace("彰化縣", "<b>彰化縣</b>");
        rtn_val = rtn_val.Replace("南投縣", "<b>南投縣</b>");
        rtn_val = rtn_val.Replace("雲林縣", "<b>雲林縣</b>");
        rtn_val = rtn_val.Replace("嘉義市", "<b>嘉義市</b>");
        rtn_val = rtn_val.Replace("嘉義縣", "<b>嘉義縣</b>");
        rtn_val = rtn_val.Replace("台南市", "<b>台南市</b>");
        rtn_val = rtn_val.Replace("高雄市", "<b>高雄市</b>");
        rtn_val = rtn_val.Replace("屏東縣", "<b>屏東縣</b>");
        rtn_val = rtn_val.Replace("花蓮縣", "<b>花蓮縣</b>");
        rtn_val = rtn_val.Replace("台東縣", "<b>台東縣</b>");
        rtn_val = rtn_val.Replace("澎湖縣", "<b>澎湖縣</b>");
        rtn_val = rtn_val.Replace("連江縣", "<b>連江縣</b>");
        rtn_val = rtn_val.Replace("金門縣", "<b>金門縣</b>");

      
        return rtn_val;
    }

    public bool mailSend(string MailFrom, string MailTo, string MailSub, string MailBody)
    {
        try
        {
            MailMessage mms = new MailMessage(MailFrom, MailTo);
            //MailAddress copy1 = new MailAddress(MailCC); 
            //mms.CC.Add(copy1);
            mms.Body = MailBody;
            mms.Subject = MailSub;
            mms.IsBodyHtml = true;

            SmtpClient client = new SmtpClient(AppSettings("smtp_server"));
            client.Credentials = new System.Net.NetworkCredential(AppSettings("SMTPsendusername"), AppSettings("SMTPsendpassword"));

            //client.Credentials = new NetworkCredential("youremail@gmail.com", "yourpassword");
            //client.Port = 587; //or use 465            
            //client.Host = "smtp.gmail.com";
            //client.EnableSsl = true;


            client.Send(mms);
            return true;
        }
        catch
        {
            return false;
        }
    }

    public string getContactType(string _type)
    {
        string rtn_val = string.Empty;
        if (_type == "1")
        {
            rtn_val = "網站內容";
        }
        else if (_type == "2")
        {
            rtn_val = "建議景點";
        }
        else if (_type == "3")
        {
            rtn_val = "廣告業務";
        }
        else if (_type == "4")
        {
            rtn_val = "店家邀約";
        }
        else if (_type == "5")
        {
            rtn_val = "合作提案";
        }
        else if (_type == "6")
        {
            rtn_val = "其他";
        }

        return rtn_val;
    }


    protected string showBrand(string _site_id)
    {
        string rtn_val = string.Empty;

        string sql_select = "SELECT TOP 6 brand, img_file FROM iutw_site_brand WHERE site_id = '" + _site_id + "'";

        SqlDataReader sdr = db.ExecuteReader(sql_select);

        rtn_val += "<table border='0'>";

        int i = 0;
        int check = 0;
        while (sdr.Read())
        {
            if (i == 0)
            {
                rtn_val += "<tr>";
            }

            rtn_val += "<td width='30'></td><td><img src='/brand_img/" + sdr["img_file"].ToString() + "' width='80' height='80' /></td>";

            i = i + 1;

            check = check + 1;
            if (i == 3)
            {
                rtn_val += "</tr>";
                i = 0;
            }

        }

        sdr.Close();

        if (i != 0)
        {
            rtn_val += "</tr>";
        }

        rtn_val += "</table>";

        if (check > 0)
        {
            rtn_val = "<tr><td>" + rtn_val + "</td></tr>";
        }
        else
        {
            rtn_val = "";
        }

        return rtn_val;
    }

    protected string showSubSite(string _site_id)
    {
        string rtn_val = string.Empty;

        string sql_select = "SELECT TOP 6 site_id, site_name, index_flickr FROM iutw_site WHERE p_id = '" + _site_id + "'";

        SqlDataReader sdr = db.ExecuteReader(sql_select);

        rtn_val += "<tr><td><table border='0'>";

        int i = 0;
        int check = 0;
        while (sdr.Read())
        {
            if (i == 0)
            {
                rtn_val += "<tr>";
            }

            rtn_val += "<td width='30'></td><td><img src='" + sdr["index_flickr"].ToString() + "' width='80' height='80' alt='" + sdr["site_name"].ToString() + "' /></td>";

            i = i + 1;

            check = check + 1;
            if (i == 3)
            {
                rtn_val += "</tr>";
                i = 0;
            }

        }

        sdr.Close();

        if (i != 0)
        {
            rtn_val += "</tr>";
        }

        rtn_val += "</table></td></tr>";

        if (check > 0)
        {
            rtn_val = "<tr><td>" + rtn_val + "</td></tr><tr><td align='right'><a href='/sub_list.aspx?p_id=" + _site_id + "'><img src='/images/bt_more2.png' border='0' onmouseover=\"this.src='/images/bt_more2_over.png'\" onmouseout=\"this.src='/images/bt_more2.png'\" /></a>&nbsp;&nbsp;&nbsp;</td></tr>";
        }
        else
        {
            rtn_val = "";
        }

        return rtn_val;
    }

    public string showScheduleList(string _sc_d_id)
    {
        string rtn_val = string.Empty;

        string sql_select = "SELECT TOP 8 b.site_id, b.site_name, b.county_code, b.index_flickr FROM iutw_schedule_site a LEFT JOIN iutw_site b ON a.site_id = b.site_id WHERE a.schedule_date_id = '" + _sc_d_id + "' ORDER BY a.sorting";

        SqlDataReader sdr = db.ExecuteReader(sql_select);

        int count = 0;

        while (sdr.Read())
        {
            if (count == 0)
            {
                rtn_val += "<a href='/site_detail.aspx?s_id=" + sdr["site_id"].ToString() + "' class='link1' target='_blank'><b>" + sdr["site_name"].ToString() + "</b>[" + getCountyName(sdr["county_code"].ToString(), "tw") + "]</a>";
            }
            else
            {
                rtn_val += " &gt; <a href='/site_detail.aspx?s_id=" + sdr["site_id"].ToString() + "' class='link1' target='_blank'><b>" + sdr["site_name"].ToString() + "</b>[" + getCountyName(sdr["county_code"].ToString(), "tw") + "]</a>";
            }
            count = count + 1;
        }

        sdr.Close();

        return rtn_val;
    }


    protected string showScheduleListAll(string _sc_d_id)
    {
        string rtn_val = string.Empty;

        string sql_select = "SELECT b.site_id, b.site_name, b.county_code, b.index_flickr FROM iutw_schedule_site a LEFT JOIN iutw_site b ON a.site_id = b.site_id WHERE a.schedule_date_id = '" + _sc_d_id + "' ORDER BY a.sorting";

        SqlDataReader sdr = db.ExecuteReader(sql_select);

        int count = 0;

        while (sdr.Read())
        {
            if (count == 0)
            {
                rtn_val += "<a href='/site_detail.aspx?s_id=" + sdr["site_id"].ToString() + "' class='link1' target='_blank'><b>" + sdr["site_name"].ToString() + "</b>[" + getCountyName(sdr["county_code"].ToString(), "tw") + "]</a>";
            }
            else
            {
                rtn_val += " <img src='/images/s_arrow.png' /> <a href='/site_detail.aspx?s_id=" + sdr["site_id"].ToString() + "' class='link1' target='_blank'><b>" + sdr["site_name"].ToString() + "</b>[" + getCountyName(sdr["county_code"].ToString(), "tw") + "]</a>";
            }
            count = count + 1;
        }

        sdr.Close();

        return rtn_val;
    }


    protected string showScheduleListImg(string _s_id)
    {
        string rtn_val = string.Empty;

        string sql_select = "SELECT TOP 1 c.index_flickr, c.site_name FROM iutw_schedule a, iutw_schedule_site b LEFT JOIN iutw_site c ON b.site_id = c.site_id WHERE a.schedule_id = b.schedule_id AND a.schedule_id = '" + _s_id + "' ORDER BY NEWID()";

        SqlDataReader sdr = db.ExecuteReader(sql_select);

        int count = 0;

        if (sdr.Read())
        {
            if (sdr["index_flickr"].ToString() != "")
            {
                rtn_val = "<img src='" + getImage(sdr["index_flickr"].ToString()) + "' alt='" + sdr["site_name"].ToString() + "' /><br /><br />" + sdr["site_name"].ToString();
            }
            else
            {
                rtn_val = "<img src='" + getImage(sdr["index_flickr"].ToString()) + "' />";
            }
        }

        sdr.Close();

        return rtn_val;
    }


    public string getLocation(string _location)
    {
        string rtn_val = string.Empty;
        if (_location == "CHN")
        {
            rtn_val = "中國大陸";
        }
        else if (_location == "TWN")
        {
            rtn_val = "台灣";
        }
        else if (_location == "HKG")
        {
            rtn_val = "香港";
        }
       

        return rtn_val;
    }


    protected string getDayNumber(string _dayNumber, string _date_type)
    {
        string rtn_val = string.Empty;

        if (_date_type == "t")
        {
            rtn_val = "<span class='asd4'>第" + _dayNumber + "天</span><br />";
        }

        return rtn_val;
    }

    protected string getDayNumberPDF(string _dayNumber, string _date_type)
    {
        string rtn_val = string.Empty;

        if (_date_type == "t")
        {
            rtn_val = "第" + _dayNumber + "天";
        }

        return rtn_val;
    }

    protected string getImage(string _image_file)
    {
        if (_image_file == "")
        {
            return "/images/none.gif";
        }
        else
        {
            return _image_file;
        }
    }

    protected string getPublicTrans(string _wh, string _ts, string _tn, string _xd, string _lc, string _xc, string _ch, string _nq, string _bq, string _tc, string _mk, string _mrt_station)
    {
        string rtn_val = string.Empty;
        string train_line1 = string.Empty;
        string train_line2 = string.Empty;
        if (_wh == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=wh' class='asd15'>文湖線</a>&nbsp;";
        }

        if (_ts == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=ts' class='asd15'>淡水線</a>&nbsp;";
        }

        if (_tn == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=tn' class='asd15'>小南門線</a>&nbsp;";
        }

        if (_xd == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=xd' class='asd15'>新店線</a>&nbsp;";
        }

        if (_lc == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=lc' class='asd15'>蘆洲線</a>&nbsp;";
        }

        if (_xc == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=xc' class='asd15'>新莊線</a>&nbsp;";
        }

        if (_ch == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=ch' class='asd15'>中和線</a>&nbsp;";
        }

        if (_nq == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=nq' class='asd15'>南港線</a>&nbsp;";
        }

        if (_bq == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=bq' class='asd15'>板橋線</a>&nbsp;";
        }

        if (_tc == "y")
        {
            train_line1 += "<a href='mrt_list.aspx?line=tc' class='asd15'>土城線</a>&nbsp;";
        }

        if (train_line1 != "")
        {
            train_line1 = "台北&nbsp;" + train_line1;
            rtn_val += train_line1;
        }

        return rtn_val;

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
    

}
