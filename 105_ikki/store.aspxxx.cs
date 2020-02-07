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
        string strHtml = "";
        string info = "";

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");

        DataTable dt2 = new DataTable("store_detail");

        dt = wow.Wow_GetAStoreList(CareerNo, "1");

        strHtml = "<span class=\"anchor\" id=\"link01\" style=\"*margin-top:-30px;\"></span>";
        strHtml += "<img src=\"images/icon_store_01.png\" width=\"630\" height=\"45\">";
        strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
        strHtml += "</table><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<tr>";
            strHtml += "<td width=\"28%\"class=\"font_01\"> ▍<a href=\"store_all.aspx?#id" + dt.Rows[i]["store_id"].ToString() + "\" class=\"green_13\">" + dt.Rows[i]["store_name"].ToString() + "</a> ▍</td>";

            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br /><span class=\"font_01\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                info = "";
            }

            strHtml += "<td width=\"52%\">" + dt2.Rows[0]["store_address"].ToString() + info + "</td>";
            strHtml += "<td width=\"20%\">" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        strHtml += "</table>";

       

        if (dt.Rows.Count > 0)
        {
            LiteArea1.Text = strHtml;
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "2");
        strHtml = "<span class=\"anchor\" id=\"link02\"></span>";
        strHtml += "<img src=\"images/icon_store_02.png\" width=\"630\" height=\"45\">";
        strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
        strHtml += "</table><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<tr>";
            strHtml += "<td width=\"28%\"class=\"font_01\"> ▍<a href=\"store_all.aspx?#id" + dt.Rows[i]["store_id"].ToString() + "\" class=\"green_13\">" + dt.Rows[i]["store_name"].ToString() + "</a> ▍</td>";

            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br /><span class=\"font_01\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                info = "";
            }

            strHtml += "<td width=\"52%\">" + dt2.Rows[0]["store_address"].ToString() + info + "</td>";
            strHtml += "<td width=\"20%\">" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        strHtml += "</table>";

        if (dt.Rows.Count > 0)
        {
            LiteArea2.Text = strHtml;
        }
        
        dt = wow.Wow_GetAStoreList(CareerNo, "3");
        strHtml = "<span class=\"anchor\" id=\"link03\"></span>";
        strHtml += "<img  src=\"images/icon_store_03.png\" width=\"630\" height=\"45\">";
        strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
        strHtml += "</table><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<tr>";
            strHtml += "<td width=\"28%\"class=\"font_01\"> ▍<a href=\"store_all.aspx?#id" + dt.Rows[i]["store_id"].ToString() + "\" class=\"green_13\">" + dt.Rows[i]["store_name"].ToString() + "</a> ▍</td>";

            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br /><span class=\"font_01\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                info = "";
            }

            strHtml += "<td width=\"52%\">" + dt2.Rows[0]["store_address"].ToString() + info + "</td>";
            strHtml += "<td width=\"20%\">" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
            strHtml += "</tr>";

        }
        strHtml += "</table>";
        if (dt.Rows.Count > 0)
        {
            LiteArea3.Text = strHtml;
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "4");
        strHtml += "<span class=\"anchor\" id=\"link04\"></span>";
        strHtml += "<img src=\"images/icon_store_04.png\" width=\"630\" height=\"45\">";
        strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
        strHtml += "</table><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<tr>";
            strHtml += "<td width=\"28%\"class=\"font_01\"> ▍<a href=\"store_all.aspx?#id" + dt.Rows[i]["store_id"].ToString() + "\" class=\"green_13\">" + dt.Rows[i]["store_name"].ToString() + "</a> ▍</td>";

            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br /><span class=\"font_01\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                info = "";
            }

            strHtml += "<td width=\"52%\">" + dt2.Rows[0]["store_address"].ToString() + info + "</td>";
            strHtml += "<td width=\"20%\">" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        strHtml += "</table>";
        if (dt.Rows.Count > 0)
        {
            LiteArea4.Text = strHtml;
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "5");
        strHtml = "<span class=\"anchor\" id=\"link05\"></span>";
        strHtml += "<img src=\"images/icon_store_05.png\" width=\"630\" height=\"45\">";
        strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
        strHtml += "</table><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<tr>";
            strHtml += "<td width=\"28%\"class=\"font_01\"> ▍<a href=\"store_all.aspx?#id" + dt.Rows[i]["store_id"].ToString() + "\" class=\"green_13\">" + dt.Rows[i]["store_name"].ToString() + "</a> ▍</td>";

            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br /><span class=\"font_01\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                info = "";
            }

            strHtml += "<td width=\"52%\">" + dt2.Rows[0]["store_address"].ToString() + info + "</td>";
            strHtml += "<td width=\"20%\">" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        strHtml += "</table>";
        if (dt.Rows.Count > 0)
        {
            LiteArea5.Text = strHtml;
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "6");
        strHtml = "<span class=\"anchor\" id=\"link06\"></span>";
        strHtml = "<img src=\"images/icon_store_06.png\" width=\"630\" height=\"45\">";
        strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
        strHtml += "</table><table border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<tr>";
            strHtml += "<td width=\"28%\"class=\"font_01\"> ▍<a href=\"store_all.aspx?#id" + dt.Rows[i]["store_id"].ToString() + "\" class=\"green_13\">" + dt.Rows[i]["store_name"].ToString() + "</a> ▍</td>";

            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br /><span class=\"font_01\">" + dt2.Rows[0]["store_info"].ToString() + "</span>";
            }
            else
            {
                info = "";
            }

            strHtml += "<td width=\"52%\">" + dt2.Rows[0]["store_address"].ToString() + info + "</td>";
            strHtml += "<td width=\"20%\">" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        strHtml += "</table>";

        if (dt.Rows.Count > 0)
        {
            LiteArea6.Text = strHtml;
        }

    }
}