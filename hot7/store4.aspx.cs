using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class store4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";
        string info = "";

        Website2API.Website2API wow = new Website2API.Website2API();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");
        DataTable dt2 = new DataTable("store_detail");



        #region  6高屏
        dt = wow.Wow_GetAStoreList(CareerNo, "6");

        //頭----------------------------------------------
        strHtml += "<div class=\"container responsive_animate m_bottom_25\"><div class=\"row m\">";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"col-lg-6 col-md-6 col-sm-6 m_bottom_10 m_xs_bottom_10\"><div class=\"accordion toggle\"><dl class=\"accordion_item r_corners wrapper m_bottom_5 tr_all\"><dt class=\"accordion_link relative color_dark tr_all\">"
                    + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon_wrap_size_1 circle d_block hide\"><i class=\"icon-minus\"></i></span><span class=\"icon_wrap_size_1 circle d_block show\"><i class=\"icon-plus\"></i></span></dt><dd class=\"fw_normal color_dark\"><div class=\"row m_bottom_15\"><div class=\"col-lg-5 col-md-5 col-sm-5\"><p class=\"m_bottom_10\"><div class=\"d_inline_m icon_wrap_size_1 color_red circle m_right_5\"><i class=\"icon-location\"></i></div>";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            strHtml += "</p><p class=\"m_bottom_10\"><div class=\"d_inline_m icon_wrap_size_1 color_red circle m_right_5\"><i class=\"icon-info\"></i></div>";

            //營業時間
            strHtml += dt2.Rows[0]["store_opening_hours"].ToString() + "<br>";
            strHtml += "</p><p class=\"m_bottom_10\"><div class=\"d_inline_m icon_wrap_size_1 color_red circle m_right_5\"><i class=\"icon-phone\"></i></div>";

            //電話
            strHtml += dt2.Rows[0]["store_tel"].ToString();
            strHtml += "</p><p class=\"m_bottom_10\"><div class=\"d_inline_m icon_wrap_size_1 color_red circle m_right_5\"><i class=\"icon-info\"></i></div>店舖介紹：<br>";

            //交通資訊(特色)
            strHtml += dt2.Rows[0]["store_content"].ToString();
            strHtml += "</p><p class=\"m_bottom_10\"><div class=\"d_inline_m icon_wrap_size_1 color_red circle m_right_5\"><i class=\"icon-info\"></i></div>停車資訊：<br>";

            //停車場
            strHtml += dt2.Rows[0]["store_parking_info"].ToString();
            strHtml += "</p></div><div class=\"col-lg-7 col-md-7 col-sm-7 m_top_15\"><img src=\"";

            //地圖照片
            strHtml += dt2.Rows[0]["store_map"].ToString();
            strHtml += "\" alt=\"\"/><div class=\"gmap\"><a href=\"";

            //google地圖
            strHtml += "https://www.google.com.tw/maps/place/";
            strHtml += dt2.Rows[0]["store_address_en"].ToString();
            strHtml += "\" target=\"_blank\"><img src=\"store/images/gmap.png\" alt=\"\"/></a></div></div></div><hr class=\"bg_color_green\"><div class=\"row m_top_20\"><div class=\"col-lg-5 col-md-5 col-sm-5\"><div class=\"d_inline_m icon_wrap_size_1 color_red circle m_right_5\"><i class=\"icon-comment\"></i></div>店主管的話：<br>";

            //店主管的話 
            strHtml += dt2.Rows[0]["store_equipment"].ToString();
            strHtml += "</div><div class=\"col-lg-7 col-md-7 col-sm-7\"><img src=\"";

            //圖片
            strHtml += dt2.Rows[0]["store_image"].ToString();
            strHtml += "\" alt=\"\"/></div></div></dd></dl></div></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div></div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea6.Text = strHtml;
        }
        #endregion
    
    }
}
