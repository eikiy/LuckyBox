using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class store_print : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";
        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");

        dt = wow.Wow_GetStoreDetail(Request.QueryString["id"]);

        LiteName.Text = dt.Rows[0]["store_name"].ToString();
        LiteAddress.Text = dt.Rows[0]["store_address"].ToString();
        LitePhone.Text = dt.Rows[0]["store_tel"].ToString();
        LiteMap.Text = "<img src=\"" + dt.Rows[0]["store_map"].ToString() + "\" border=\"0\" class=\"banner\">";
        LiteTime.Text = dt.Rows[0]["store_opening_hours"].ToString().Replace("\n", "<br>");
        
        if (dt.Rows[0]["store_info"].ToString() != "")
        {
            LiteNew.Text = "<tr><td colspan=\"2\"><span class=\"font_01\">" + dt.Rows[0]["store_info"].ToString() + "</span></td></tr>";
        }

        if (dt.Rows[0]["store_content"].ToString() != "")
        {
            strHtml = "<tr>";
            strHtml += "<td >店鋪介紹:</td>";
            strHtml += "<td >" + dt.Rows[0]["store_content"].ToString() + "</td>";
            strHtml += "</tr>";
        }

        LiteContent.Text = strHtml;
            
        strHtml = "";

        if (dt.Rows[0]["store_seat"].ToString() != "")
        {
            strHtml = "<tr>";
            strHtml += "<td >客席數: </td><td >" + dt.Rows[0]["store_seat"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        LiteSeat.Text = strHtml;

        
        strHtml = "";

        if (dt.Rows[0]["store_parking_info"].ToString() != "")
        {
            strHtml = "<tr>";
            strHtml += "<td >停車資訊: </td><td >" + dt.Rows[0]["store_parking_info"].ToString() + "</td>";
            strHtml += "</tr>";
        }
        
        if (dt.Rows[0]["store_equipment"].ToString() != "")
        {
            strHtml += "<tr>";
            strHtml += "<td >電梯設備: </td><td >" + dt.Rows[0]["store_equipment"].ToString() + "</td>";
            strHtml += "</tr>";
        }

        if (dt.Rows[0]["store_equipment2"].ToString() != "")
        {
            strHtml += "<tr>";
            strHtml += "<td >無障礙空間: </td><td >" + dt.Rows[0]["store_equipment2"].ToString() + "</td>";
            strHtml += "</tr>";
        }

        if (dt.Rows[0]["store_remark"].ToString() != "")
        {
            strHtml += "<tr>";
            strHtml += "<td >備註: </td><td >" + dt.Rows[0]["store_remark"].ToString() + "</td>";
            strHtml += "</tr>";
        }

        LiteOther.Text = strHtml;
    }
}