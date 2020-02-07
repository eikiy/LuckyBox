using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class m_store_detail : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";


        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");

        dt = wow.Wow_GetStoreDetail(Request.QueryString["id"]);

        if (dt.Rows[0]["store_info"].ToString() != "")
        {
            LiteName.Text = dt.Rows[0]["store_name"].ToString() + "：<span style=\"color:#F94624\">" + dt.Rows[0]["store_info"].ToString() + "</span>";
        }
        else
        {
            LiteName.Text = dt.Rows[0]["store_name"].ToString();
        }
        LiteAddress.Text = "<a href=\"http://maps.google.com/maps?f=q&hl=zh-TW&geocode=&q=" + dt.Rows[0]["store_address"].ToString() + "\">" + dt.Rows[0]["store_address"].ToString() + "</a>";
        LitePhone.Text = dt.Rows[0]["store_tel"].ToString();
        LiteMap.Text = "<a href=\"http://maps.google.com/maps?f=q&hl=zh-TW&geocode=&q=" + dt.Rows[0]["store_address"].ToString() + "\"><img src=\"" + dt.Rows[0]["store_map"].ToString() + "\" border=\"0\"></a>";
        LiteImg.Text = "<a href=\"tel:" + dt.Rows[0]["store_tel"].ToString() + "\"><img src=\"images/store/phone.png\" width=\"61\" height=\"67\" border=\"0\"></a>";

        if (dt.Rows[0]["store_opening_hours"].ToString() != "")
        {
            strHtml += "<div class=\"store\">營業時間：" + dt.Rows[0]["store_opening_hours"].ToString().Replace("\n", "<br>") + "</div><div class=\"line\"><img src=\"images/store/line.jpg\" width=\"229\" height=\"1\"></div>";
        }

        if (dt.Rows[0]["store_parking_info"].ToString() != "")
        {
            strHtml += "<div class=\"store\">" + dt.Rows[0]["store_parking_info"].ToString() + "</div><div class=\"line\"><img src=\"images/store/line.jpg\" width=\"229\" height=\"1\"></div>";
        }

        if (dt.Rows[0]["store_equipment"].ToString() != "")
        {
            strHtml += "<div class=\"store\">" + dt.Rows[0]["store_equipment"].ToString() + "</div><div class=\"line\"><img src=\"images/store/line.jpg\" width=\"229\" height=\"1\"></div>";
        }

        if (dt.Rows[0]["store_equipment2"].ToString() != "")
        {
            strHtml += "<div class=\"store\">" + dt.Rows[0]["store_equipment2"].ToString() + "</div><div class=\"line\"><img src=\"images/store/line.jpg\" width=\"229\" height=\"1\"></div>";
        }

        if (dt.Rows[0]["store_remark"].ToString() != "")
        {
            strHtml += "<div class=\"store\">" + dt.Rows[0]["store_remark"].ToString() + "</div><div class=\"line\"><img src=\"images/store/line.jpg\" width=\"229\" height=\"1\"></div>";
        }

        LiteOther.Text = strHtml;
    }
}