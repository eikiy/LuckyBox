using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class store : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHmtl = "";
        string new_open = "";

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");

        DataTable dt2 = new DataTable("store_detail");
        
        dt = wow.Wow_GetAStoreList(CareerNo, "1");
        strHmtl = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                new_open = "：<br><span style=\"color:#ff0000\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                new_open = "";
            }
            strHmtl += "<table width=\"320\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
            strHmtl += "</tr>";
            strHmtl += "<tr onMouseOver=\"this.style.backgroundColor='#eeeeee';\" onMouseOut=\"this.style.backgroundColor='#ffffff';\" onClick=\"location.href='store_detail.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "'\">";
            strHmtl += "<td width=\"39\">&nbsp;</td>";
            strHmtl += "<td width=\"227\" height=\"54\" align=\"left\" class=\"area_txt\">" + dt2.Rows[0]["store_name"].ToString() + new_open + "</td>";
            strHmtl += "<td width=\"54\">&nbsp;</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";


            /*strHmtl += "<li class=\"store_line\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></li>";
            strHmtl += "<li class=\"store_list\"><a href=\"store_detail.aspx?id=" + dt.Rows[i]["store_id"].ToString() + "\">";
            strHmtl += "<div class=\"txt\">";
            strHmtl += "<span class=\"area_txt\">" + dt.Rows[i]["store_name"].ToString() + new_open + "</span>";
            strHmtl += "</div></a>";
            strHmtl += "</li>";
            strHmtl += "<li class=\"store_line\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></li>";*/
        }
        //strHmtl += "</ul>";
        LiteArea1.Text = strHmtl;

        dt = wow.Wow_GetAStoreList(CareerNo, "2");
        strHmtl = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                new_open = "：<span style=\"color:#ff0000\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                new_open = "";
            }
            strHmtl += "<table width=\"320\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
            strHmtl += "</tr>";
            strHmtl += "<tr onMouseOver=\"this.style.backgroundColor='#eeeeee';\" onMouseOut=\"this.style.backgroundColor='#ffffff';\" onClick=\"location.href='store_detail.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "'\">";
            strHmtl += "<td width=\"39\">&nbsp;</td>";
            strHmtl += "<td width=\"227\" height=\"54\" align=\"left\" class=\"area_txt\">" + dt2.Rows[0]["store_name"].ToString() + new_open + "</td>";
            strHmtl += "<td width=\"54\">&nbsp;</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";
        }
        
        LiteArea2.Text = strHmtl;

        dt = wow.Wow_GetAStoreList(CareerNo, "3");
        strHmtl = "";
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                new_open = "：<span style=\"color:#ff0000\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                new_open = "";
            }
            strHmtl += "<table width=\"320\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
            strHmtl += "</tr>";
            strHmtl += "<tr onMouseOver=\"this.style.backgroundColor='#eeeeee';\" onMouseOut=\"this.style.backgroundColor='#ffffff';\" onClick=\"location.href='store_detail.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "'\">";
            strHmtl += "<td width=\"39\">&nbsp;</td>";
            strHmtl += "<td width=\"227\" height=\"54\" align=\"left\" class=\"area_txt\">" + dt2.Rows[0]["store_name"].ToString() + new_open + "</td>";
            strHmtl += "<td width=\"54\">&nbsp;</td>";
            strHmtl += "</tr>";
            strHmtl += "<tr>";
            strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
            strHmtl += "</tr>";
            strHmtl += "</table>";
        }
        
        LiteArea3.Text = strHmtl;

        dt = wow.Wow_GetAStoreList(CareerNo, "4");
        strHmtl = "";
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
                if (dt2.Rows[0]["store_info"].ToString() != "")
                {
                    new_open = "：<span style=\"color:#ff0000\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
                }
                else
                {
                    new_open = "";
                }
                strHmtl += "<table width=\"320\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">";
                strHmtl += "<tr>";
                strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
                strHmtl += "</tr>";
                strHmtl += "<tr onMouseOver=\"this.style.backgroundColor='#eeeeee';\" onMouseOut=\"this.style.backgroundColor='#ffffff';\" onClick=\"location.href='store_detail.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "'\">";
                strHmtl += "<td width=\"39\">&nbsp;</td>";
                strHmtl += "<td width=\"227\" height=\"54\" align=\"left\" class=\"area_txt\">" + dt2.Rows[0]["store_name"].ToString() + new_open + "</td>";
                strHmtl += "<td width=\"54\">&nbsp;</td>";
                strHmtl += "</tr>";
                strHmtl += "<tr>";
                strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
                strHmtl += "</tr>";
                strHmtl += "</table>";
            }

            LiteArea4.Text = strHmtl;
        }
        else
        {
            area4.Visible = false;
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "5");
        
        if (dt.Rows.Count > 0)
        {
            strHmtl = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
                if (dt2.Rows[0]["store_info"].ToString() != "")
                {
                    new_open = "：<span style=\"color:#ff0000\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
                }
                else
                {
                    new_open = "";
                }
                strHmtl += "<table width=\"320\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">";
                strHmtl += "<tr>";
                strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
                strHmtl += "</tr>";
                strHmtl += "<tr onMouseOver=\"this.style.backgroundColor='#eeeeee';\" onMouseOut=\"this.style.backgroundColor='#ffffff';\" onClick=\"location.href='store_detail.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "'\">";
                strHmtl += "<td width=\"39\">&nbsp;</td>";
                strHmtl += "<td width=\"227\" height=\"54\" align=\"left\" class=\"area_txt\">" + dt2.Rows[0]["store_name"].ToString() + new_open + "</td>";
                strHmtl += "<td width=\"54\">&nbsp;</td>";
                strHmtl += "</tr>";
                strHmtl += "<tr>";
                strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
                strHmtl += "</tr>";
                strHmtl += "</table>";
            }
            LiteArea5.Text = strHmtl;
        }
        else
        {
            area5.Visible = false;
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "6");
        strHmtl = "";
        if (dt.Rows.Count > 0)
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
                if (dt2.Rows[0]["store_info"].ToString() != "")
                {
                    new_open = "：<span style=\"color:#ff0000\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
                }
                else
                {
                    new_open = "";
                }

                strHmtl += "<table width=\"320\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" bgcolor=\"#ffffff\">";
                strHmtl += "<tr>";
                strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
                strHmtl += "</tr>";
                strHmtl += "<tr onMouseOver=\"this.style.backgroundColor='#eeeeee';\" onMouseOut=\"this.style.backgroundColor='#ffffff';\" onClick=\"location.href='store_detail.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "'\">";
                strHmtl += "<td width=\"39\">&nbsp;</td>";
                strHmtl += "<td width=\"227\" height=\"54\" align=\"left\" class=\"area_txt\">" + dt2.Rows[0]["store_name"].ToString() + new_open + "</td>";
                strHmtl += "<td width=\"54\">&nbsp;</td>";
                strHmtl += "</tr>";
                strHmtl += "<tr>";
                strHmtl += "<td colspan=\"3\"><img src=\"images/store/line3.png\" width=\"320\" height=\"1\"></td>";
                strHmtl += "</tr>";
                strHmtl += "</table>";

            }

            LiteArea6.Text = strHmtl;
        }
        else
        {
            area6.Visible = false;
        }
    }
}