using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


public partial class en_storeInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";

        Website2API.Website2API wow = new Website2API.Website2API();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");
        DataTable dt2 = new DataTable("store_detail");


        #region  1 2 North Taiwan
        //頭----------------------------------------------
        strHtml = "<h3 id=\"store1\">North</h3>";
        //------------------------------------------------


        dt = wow.Wow_GetAStoreList(CareerNo, "1");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\"><div class=\"jqimgFill col-xs-12 col-sm-12 col-md-7 col-lg-7\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" style=\"top: 0px; max-height: 100%;\" /></div><div class=\"txt right col-xs-12 col-sm-12 col-md-5 col-lg-5\"><h4>";
            strHtml += dt2.Rows[0]["store_name_en"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>Address </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address_en"].ToString();
            strHtml += "<a href=\"../map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>Phone</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>Hours</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>Parketing </dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info_en"].ToString();
            strHtml += "</dd><dt>Features</dt><dd>";
            strHtml += dt2.Rows[0]["store_remark_en"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";
            strHtml += "<hr>";

        }



        dt = wow.Wow_GetAStoreList(CareerNo, "2");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\"><div class=\"jqimgFill col-xs-12 col-sm-12 col-md-7 col-lg-7\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" style=\"top: 0px; max-height: 100%;\" /></div><div class=\"txt right col-xs-12 col-sm-12 col-md-5 col-lg-5\"><h4>";
            strHtml += dt2.Rows[0]["store_name_en"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>Address </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address_en"].ToString();
            strHtml += "<a href=\"../map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>Phone</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>Hours</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>Parketing </dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info_en"].ToString();
            strHtml += "</dd><dt>Features</dt><dd>";
            strHtml += dt2.Rows[0]["store_remark_en"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";
            strHtml += "<hr>";
        }




        if (dt.Rows.Count > 0)
        {
            LiteArea1.Text = strHtml;
        }
        #endregion



        #region  3 4 Central Taiwan
        
        //頭----------------------------------------------
        strHtml = "<h3 id=\"store2\">Central</h3>";
        //------------------------------------------------
        
        dt = wow.Wow_GetAStoreList(CareerNo, "3");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\"><div class=\"jqimgFill col-xs-12 col-sm-12 col-md-7 col-lg-7\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" style=\"top: 0px; max-height: 100%;\" /></div><div class=\"txt right col-xs-12 col-sm-12 col-md-5 col-lg-5\"><h4>";
            strHtml += dt2.Rows[0]["store_name_en"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>Address </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address_en"].ToString();
            strHtml += "<a href=\"../map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>Phone</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>Hours</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>Parketing </dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info_en"].ToString();
            strHtml += "</dd><dt>Features</dt><dd>";
            strHtml += dt2.Rows[0]["store_remark_en"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";
            strHtml += "<hr>";
        }

        dt = wow.Wow_GetAStoreList(CareerNo, "4");
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\"><div class=\"jqimgFill col-xs-12 col-sm-12 col-md-7 col-lg-7\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" style=\"top: 0px; max-height: 100%;\" /></div><div class=\"txt right col-xs-12 col-sm-12 col-md-5 col-lg-5\"><h4>";
            strHtml += dt2.Rows[0]["store_name_en"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>Address </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address_en"].ToString();
            strHtml += "<a href=\"";
            strHtml += dt2.Rows[0]["store_map"].ToString();
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>Phone</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>Hours</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>Parketing </dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info_en"].ToString();
            strHtml += "</dd><dt>Features</dt><dd>";
            strHtml += dt2.Rows[0]["store_remark_en"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";
            strHtml += "<hr>";
        }



        if (dt.Rows.Count > 0)
        {
            LiteArea2.Text = strHtml;
        }
        #endregion


        #region  6 South Taiwan
        dt = wow.Wow_GetAStoreList(CareerNo, "6");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store3\">South</h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\"><div class=\"jqimgFill col-xs-12 col-sm-12 col-md-7 col-lg-7\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" style=\"top: 0px; max-height: 100%;\" /></div><div class=\"txt right col-xs-12 col-sm-12 col-md-5 col-lg-5\"><h4>";
            strHtml += dt2.Rows[0]["store_name_en"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>Address </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address_en"].ToString();
            strHtml += "<a href=\"../map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>Phone</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>Hours</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>Parketing </dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info_en"].ToString();
            strHtml += "</dd><dt>Features</dt><dd>";
            strHtml += dt2.Rows[0]["store_remark_en"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";
            strHtml += "<hr>";


        }

        if (dt.Rows.Count > 0)
        {
            LiteArea3.Text = strHtml;
        }
        #endregion


    }
}
