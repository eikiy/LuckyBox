using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class storePrint : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Website2API.Website2API wow = new Website2API.Website2API();
        DataTable dt2 = new DataTable("store_detail");
        dt2 = wow.Wow_GetStoreDetail(Request.QueryString["store_id"].ToString());

        string strHtmlpic = "";
        strHtmlpic += "<div class=\"view left jqimgFill\"><img src=\"";
        //strHtmlpic += dt2.Rows[0]["store_image"].ToString();
        strHtmlpic += dt2.Rows[0]["store_map"].ToString();
        strHtmlpic += "\" alt=\"\" /></div>";
        LiteArea_A.Text = strHtmlpic;
        
        string strHtml = "";
        strHtml+="<div class=\"txt right\"><h4>";
        strHtml +=dt2.Rows[0]["store_name"].ToString();
        strHtml+="</h4><dl class=\"dl-horizontal\"><dt>地址 </dt><dd>";
        strHtml +=dt2.Rows[0]["store_address"].ToString();
        strHtml+="</dd><dt>電話</dt><dd>";
        strHtml += dt2.Rows[0]["store_tel"].ToString();
        strHtml+="</dd><dt>營業時間</dt><dd>";
        strHtml +=dt2.Rows[0]["store_opening_hours"].ToString();
        strHtml+="</dd><dt>停車場</dt><dd>";
        strHtml +=dt2.Rows[0]["store_parking_info"].ToString();
        strHtml+="</dd><dt>特色介紹</dt><dd>";
        strHtml +=dt2.Rows[0]["store_content"].ToString();
        strHtml+="</dd></dl></div>";
        LiteArea_B.Text = strHtml;

               
                                    
    }
}
