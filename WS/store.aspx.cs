using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class store : System.Web.UI.Page
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



        #region  1北北基
        dt = wow.Wow_GetAStoreList(CareerNo, "1");

        //頭----------------------------------------------
        strHtml = "<div class=\"list-item\">";
        strHtml += "<h3 id=\"store1\">北北基</h3>";
        strHtml += "<div class=\"list tbl\" >";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"row\"><a href=\"storeInfo.aspx#store1\"><div class=\"col-sm-2 tbl-content tbl-title\">" + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon-search-more\"><img src=\"images/icon-search.png\"/>看更多</span></div><div class=\"col-sm-7 tbl-content addr\">";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            //註解
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br><em>" + dt2.Rows[0]["store_info"].ToString() + "</em>";
            }
            else
            {
                info = "";
            }
            strHtml += info;
            //電話
            strHtml += "</div><div class=\"col-sm-3 tbl-content\"><span class=\"telbtn\" onclick=\"location.href='"+ dt2.Rows[0]["store_tel"].ToString() +"'\">"+dt2.Rows[0]["store_tel"].ToString()+"</span></div></a></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div>";
        strHtml += "</div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea1.Text = strHtml;
        }
        #endregion


        #region  2桃竹苗
        dt = wow.Wow_GetAStoreList(CareerNo, "2");

        //頭----------------------------------------------
        strHtml = "<div class=\"list-item\">";
        strHtml += "<h3 id=\"store2\">桃竹苗</h3>";
        strHtml += "<div class=\"list tbl\" >";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"row\"><a href=\"storeInfo.aspx#store2\"><div class=\"col-sm-2 tbl-content tbl-title\">" + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon-search-more\"><img src=\"images/icon-search.png\"/>看更多</span></div><div class=\"col-sm-7 tbl-content addr\">";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            //註解
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br><em>" + dt2.Rows[0]["store_info"].ToString() + "</em>";
            }
            else
            {
                info = "";
            }
            strHtml += info;
            //電話
            strHtml += "</div><div class=\"col-sm-3 tbl-content\"><span class=\"telbtn\" onclick=\"location.href='" + dt2.Rows[0]["store_tel"].ToString() + "'\">" + dt2.Rows[0]["store_tel"].ToString() + "</span></div></a></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div>";
        strHtml += "</div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea2.Text = strHtml;
        }
        #endregion


        #region  3中彰投
        dt = wow.Wow_GetAStoreList(CareerNo, "3");

        //頭----------------------------------------------
        strHtml = "<div class=\"list-item\">";
        strHtml += "<h3 id=\"store3\">中彰投</h3>";
        strHtml += "<div class=\"list tbl\" >";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"row\"><a href=\"storeInfo.aspx#store3\"><div class=\"col-sm-2 tbl-content tbl-title\">" + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon-search-more\"><img src=\"images/icon-search.png\"/>看更多</span></div><div class=\"col-sm-7 tbl-content addr\">";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            //註解
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br><em>" + dt2.Rows[0]["store_info"].ToString() + "</em>";
            }
            else
            {
                info = "";
            }
            strHtml += info;
            //電話
            strHtml += "</div><div class=\"col-sm-3 tbl-content\"><span class=\"telbtn\" onclick=\"location.href='" + dt2.Rows[0]["store_tel"].ToString() + "'\">" + dt2.Rows[0]["store_tel"].ToString() + "</span></div></a></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div>";
        strHtml += "</div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea3.Text = strHtml;
        }
        #endregion


        #region  4雲嘉南
        dt = wow.Wow_GetAStoreList(CareerNo, "4");

        //頭----------------------------------------------
        strHtml = "<div class=\"list-item\">";
        strHtml += "<h3 id=\"store4\">雲嘉南</h3>";
        strHtml += "<div class=\"list tbl\" >";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"row\"><a href=\"storeInfo.aspx#store4\"><div class=\"col-sm-2 tbl-content tbl-title\">" + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon-search-more\"><img src=\"images/icon-search.png\"/>看更多</span></div><div class=\"col-sm-7 tbl-content addr\">";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            //註解
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br><em>" + dt2.Rows[0]["store_info"].ToString() + "</em>";
            }
            else
            {
                info = "";
            }
            strHtml += info;
            //電話
            strHtml += "</div><div class=\"col-sm-3 tbl-content\"><span class=\"telbtn\" onclick=\"location.href='" + dt2.Rows[0]["store_tel"].ToString() + "'\">" + dt2.Rows[0]["store_tel"].ToString() + "</span></div></a></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div>";
        strHtml += "</div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea4.Text = strHtml;
        }
        #endregion


        #region  5
        dt = wow.Wow_GetAStoreList(CareerNo, "5");

        //頭----------------------------------------------
        strHtml = "<div class=\"list-item\">";
        strHtml += "<h3 id=\"store5\"></h3>";
        strHtml += "<div class=\"list tbl\" >";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"row\"><a href=\"storeInfo.aspx#store5\"><div class=\"col-sm-2 tbl-content tbl-title\">" + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon-search-more\"><img src=\"images/icon-search.png\"/>看更多</span></div><div class=\"col-sm-7 tbl-content addr\">";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            //註解
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br><em>" + dt2.Rows[0]["store_info"].ToString() + "</em>";
            }
            else
            {
                info = "";
            }
            strHtml += info;
            //電話
            strHtml += "</div><div class=\"col-sm-3 tbl-content\"><span class=\"telbtn\" onclick=\"location.href='" + dt2.Rows[0]["store_tel"].ToString() + "'\">" + dt2.Rows[0]["store_tel"].ToString() + "</span></div></a></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div>";
        strHtml += "</div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea5.Text = strHtml;
        }
        #endregion


        #region  6高屏
        dt = wow.Wow_GetAStoreList(CareerNo, "6");
        //頭----------------------------------------------
        strHtml = "<div class=\"list-item\">";
        strHtml += "<h3 id=\"store6\">高屏</h3>";
        strHtml += "<div class=\"list tbl\" >";
        //------------------------------------------------
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

            //名字
            strHtml += "<div class=\"row\"><a href=\"storeInfo.aspx#store6\"><div class=\"col-sm-2 tbl-content tbl-title\">" + dt.Rows[i]["store_name"].ToString() + "<span class=\"icon-search-more\"><img src=\"images/icon-search.png\"/>看更多</span></div><div class=\"col-sm-7 tbl-content addr\">";
            //地址
            strHtml += dt2.Rows[0]["store_address"].ToString();
            //註解
            if (dt2.Rows[0]["store_info"].ToString() != "")
            {
                info = "<br><em>" + dt2.Rows[0]["store_info"].ToString() + "</em>";
            }
            else
            {
                info = "";
            }
            strHtml += info;
            //電話
            strHtml += "</div><div class=\"col-sm-3 tbl-content\"><span class=\"telbtn\" onclick=\"location.href='" + dt2.Rows[0]["store_tel"].ToString() + "'\">" + dt2.Rows[0]["store_tel"].ToString() + "</span></div></a></div>";
        }
        //尾----------------------------------------------
        strHtml += "</div>";
        strHtml += "</div>";
        //------------------------------------------------
        if (dt.Rows.Count > 0)
        {
            LiteArea6.Text = strHtml;
        }
        #endregion

    }
}
