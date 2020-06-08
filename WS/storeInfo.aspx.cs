using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class storeInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";

        Website2API.Website2API wow = new Website2API.Website2API();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");
        DataTable dt2 = new DataTable("store_detail");


        #region  1北北基
        dt = wow.Wow_GetAStoreList(CareerNo, "1");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store1\">北北基</h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml +="<div class=\"list-item clear auto\" id=\""+dt.Rows[i]["store_id"].ToString()+"\"><div class=\"view left jqimgFill\"><img src=\"";
            strHtml +=dt2.Rows[0]["store_image"].ToString();
            strHtml +="\" alt=\"\" /></div><div class=\"txt right\"><h4>";
            strHtml +=dt2.Rows[0]["store_name"].ToString();
            strHtml +="</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd class=\"mpat\">";
            strHtml +=dt2.Rows[0]["store_address"].ToString();
            strHtml +="<a href=\"map.htm?filename=";                        
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);
            strHtml +="\" class=\"map\" title=\"";
            strHtml +=dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";            
            strHtml +=dt2.Rows[0]["store_tel"].ToString();
            strHtml +="</dd><dt>營業時間</dt><dd>";                        
            strHtml +=dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml +="</dd><dt>停車場</dt><dd>";
            strHtml +=dt2.Rows[0]["store_parking_info"].ToString();
            strHtml +="</dd><dt>特色介紹</dt><dd>";
            strHtml +=dt2.Rows[0]["store_content"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";

                                
        }

        if (dt.Rows.Count > 0)
        {
            LiteArea1.Text = strHtml;
        }
        #endregion



        #region  2桃竹苗
        dt = wow.Wow_GetAStoreList(CareerNo, "2");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store2\">桃竹苗</h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\" id=\"" + dt.Rows[i]["store_id"].ToString() + "\"><div class=\"view left jqimgFill\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" /></div><div class=\"txt right\"><h4>";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address"].ToString();
            strHtml += "<a href=\"map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            //strHtml += "地圖\" ><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>營業時間</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>停車場</dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info"].ToString();
            strHtml += "</dd><dt>特色介紹</dt><dd>";
            strHtml += dt2.Rows[0]["store_content"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";



        }

        if (dt.Rows.Count > 0)
        {
            LiteArea2.Text = strHtml;
        }
        #endregion


        #region  3中彰投
        dt = wow.Wow_GetAStoreList(CareerNo, "3");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store3\">中彰投</h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\" id=\"" + dt.Rows[i]["store_id"].ToString() + "\"><div class=\"view left jqimgFill\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" /></div><div class=\"txt right\"><h4>";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address"].ToString();
            strHtml += "<a href=\"map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);                        
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            //strHtml += "地圖\" ><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>營業時間</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>停車場</dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info"].ToString();
            strHtml += "</dd><dt>特色介紹</dt><dd>";
            strHtml += dt2.Rows[0]["store_content"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";



        }

        if (dt.Rows.Count > 0)
        {
            LiteArea3.Text = strHtml;
        }
        #endregion


        #region  4雲嘉南
        dt = wow.Wow_GetAStoreList(CareerNo, "4");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store4\">雲嘉南</h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\" id=\"" + dt.Rows[i]["store_id"].ToString() + "\"><div class=\"view left jqimgFill\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" /></div><div class=\"txt right\"><h4>";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address"].ToString();
            strHtml += "<a href=\"map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);                        
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            //strHtml += "地圖\" ><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>營業時間</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>停車場</dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info"].ToString();
            strHtml += "</dd><dt>特色介紹</dt><dd>";
            strHtml += dt2.Rows[0]["store_content"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";



        }

        if (dt.Rows.Count > 0)
        {
            LiteArea4.Text = strHtml;
        }
        #endregion



        #region  5
        dt = wow.Wow_GetAStoreList(CareerNo, "5");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store6\"></h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\" id=\"" + dt.Rows[i]["store_id"].ToString() + "\"><div class=\"view left jqimgFill\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" /></div><div class=\"txt right\"><h4>";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address"].ToString();
            strHtml += "<a href=\"";
            strHtml += "<a href=\"map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);                        
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";            
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>營業時間</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>停車場</dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info"].ToString();
            strHtml += "</dd><dt>特色介紹</dt><dd>";
            strHtml += dt2.Rows[0]["store_content"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";



        }

        if (dt.Rows.Count > 0)
        {
            LiteArea5.Text = strHtml;
        }
        #endregion


        #region  6高屏
        dt = wow.Wow_GetAStoreList(CareerNo, "6");

        //頭----------------------------------------------
        strHtml = "<h3 id=\"store6\">雲嘉南</h3>";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            strHtml += "<div class=\"list-item clear auto\" id=\"" + dt.Rows[i]["store_id"].ToString() + "\"><div class=\"view left jqimgFill\"><img src=\"";
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\" /></div><div class=\"txt right\"><h4>";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd class=\"mpat\">";
            strHtml += dt2.Rows[0]["store_address"].ToString();
            strHtml += "<a href=\"map.htm?filename=";
            strHtml += dt2.Rows[0]["store_map"].ToString().Substring(dt2.Rows[0]["store_map"].ToString().IndexOf("filename") + 9, dt2.Rows[0]["store_map"].ToString().Length - dt2.Rows[0]["store_map"].ToString().IndexOf("filename") - 9);                        
            strHtml += "\" class=\"map\" title=\"";
            strHtml += dt2.Rows[0]["store_name"].ToString();
            strHtml += "地圖\" data-rel=\"lightcasepic:myCollection:slideshow\"><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            //strHtml += "地圖\" ><img src=\"styles/images/store-map-icon.png\" alt=\"\"><span class=\"hidden\">地圖</span></a></dd><dt>電話</dt><dd>";
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</dd><dt>營業時間</dt><dd>";
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString();
            //<br> 晚間：17:30~22:00 (最後點餐時間21:00)
            //<br>
            //<span class="red">*國定/例假日，彈性延長 服務時間</span>
            strHtml += "</dd><dt>停車場</dt><dd>";
            strHtml += dt2.Rows[0]["store_parking_info"].ToString();
            strHtml += "</dd><dt>特色介紹</dt><dd>";
            strHtml += dt2.Rows[0]["store_content"].ToString();
            strHtml += "</dd></dl><div class=\"text-right\"><a href=\"storePrint.aspx?store_id=" + dt.Rows[i]["store_id"].ToString() + "\" target=\"_blank\" class=\"print btn2\">列印</a></div></div></div>";



        }

        if (dt.Rows.Count > 0)
        {
            LiteArea6.Text = strHtml;
        }
        #endregion

    }
}
