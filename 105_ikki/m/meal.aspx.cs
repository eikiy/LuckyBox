using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class m_meal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string remark = "";
        string strHtml = "";
        string title = "";
        string title_old = "";

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Meal");

        dt = wow.Wow_GetMeal(CareerNo);

        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable("MealDetail");

        check_input new_word = new check_input();

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (new_word.doCheck_Input(Request.QueryString["id"].ToString(), 50) == dt.Rows[i]["package_id"].ToString())
            {
                dt2 = wow.Wow_GetMealDetail(dt.Rows[i]["package_id"].ToString());
                strHtml += "<div class=\"meal\">";
                strHtml += "<div class=\"txt1\">" + dt.Rows[i]["name"].ToString() + "</div>";
                strHtml += "<div class=\"txt2\">" + dt.Rows[i]["price"].ToString() + "</div>";
                strHtml += "<div class=\"line1\"><img src=\"images/menu/line1.jpg\" width=\"320\" height=\"1\"></div>";
                strHtml += "</div>";
                Image1.ImageUrl = dt.Rows[i]["image"].ToString();
                remark = dt.Rows[i]["remark"].ToString();
            }
        }


        title = "";
        title_old = "";
        for (int j = 0; j < dt2.Rows.Count; j++)
        {
            //第1次, 指向舊的名稱, 第1次後指向新名稱
            if (j == 0)
            {
                title_old = dt2.Rows[j]["class"].ToString();
            }
            else
            {
                title = dt2.Rows[j]["class"].ToString();
            }

            //如果新舊名稱不一樣, 則輸出開始div, 一樣則直輸出菜單名細
            if (title != title_old)
            {
                title_old = dt2.Rows[j]["class"].ToString();

                //第1次只要輸出開始div, 第1次後要加上結束div
                if (j == 0)
                {
                    strHtml += "<div class=\"meal_detail\">";
                }
                else
                {
                    strHtml += "</span></div><div class=\"line1\"><img src=\"images/menu/line1.jpg\" width=\"320\" height=\"1\"></div>";
                    strHtml += "<div class=\"meal_detail\">";
                }
                strHtml += "<span style=\"color:#d50000;font-weight:bold;\">" + dt2.Rows[j]["class"].ToString() + "</span><br>";
                strHtml += "<span style=\"color:#000000\">" + dt2.Rows[j]["MealName"].ToString();
            }
            else
            {
                strHtml += " / " + dt2.Rows[j]["MealName"].ToString();
            }
            if ((j + 1) == dt2.Rows.Count)
            {
                strHtml += "</span></div>";
            }
        }
        if (remark != "")
        {
            strHtml += "<div class=\"line1\"><img src=\"images/menu/line1.jpg\" width=\"320\" height=\"1\"></div><div id=\"remark\">";
            strHtml += "<div class=\"txt\"><ul>";

            string[] list_array = remark.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int k = 0; k < list_array.Length; k++)
            {
                strHtml += "<li>" + list_array[k].ToString() + "</li>";
            }
            strHtml += "</ul></div>";
            strHtml += "</div>";
        }
        
        LiteMenu.Text = strHtml;
    }
}