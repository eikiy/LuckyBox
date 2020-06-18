using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class en_menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string remark = "";
        string strHtml = "";
        string title = "";
        string title_old = "";
        string name = "";
        string package_id = "";

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Meal");

        dt = wow.Wow_GetMeal(CareerNo);

        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable("MealDetail");

        //上方主餐與金額

        strHtml += "<table width=\"95%\" border=\"0\" cellpadding=\"5\" cellspacing=\"0\" class=\"x_tb\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {

            if (Request.QueryString["id"] == null || Request.QueryString["id"] == "" && i == 0)
            {
                package_id = dt.Rows[0]["package_id"].ToString();
               // remark = dt.Rows[i]["remark_en"].ToString();
            }
            else
            {
                if (Request.QueryString["id"].ToString() == dt.Rows[i]["package_id"].ToString())
                {
                    package_id = dt.Rows[i]["package_id"].ToString();

                }
            }
            remark = dt.Rows[i]["remark_en"].ToString();
            strHtml += "<tr>";
            strHtml += "<td class=\"x_f05\" style=\"text-align:center;\">" + dt.Rows[i]["name_en"].ToString() + "</td>";
            strHtml += "</tr>";
            strHtml += " <tr>";
            strHtml += " <td class=\"x_f04a\" style=\"text-align:center;\">" + dt.Rows[i]["price_en"].ToString() + "</td>";
            strHtml += "</tr>";
            strHtml += " <tr>";
            strHtml += "   <td class=\"x_line_y\"></td>";
            strHtml += " </tr>";
            strHtml += " <tr>";
            strHtml += " <td style=\"padding-right:30px; text-align:right;\"><a href=\"/menu.html\">中文</a>　<a href=\"/jp/menu.aspx\">日本語</a></td>";
            strHtml += " </tr>";
        }

        strHtml += "</table>";

        LiteMenu.Text = strHtml;


        dt2 = wow.Wow_GetMealDetail(package_id);
        strHtml = "";

        //顯示前端資訊html(各項餐點內容)ex:主餐/XXXXXXX
        for (int j = 0; j < dt2.Rows.Count; j++)
        {
            //第1次, 指向舊的名稱, 第1次後指向新名稱
            title = dt2.Rows[j]["class_en"].ToString();

            //如果新舊名稱不一樣
            if (title != title_old)
            {
                title_old = dt2.Rows[j]["class_en"].ToString();
               
                strHtml += "<tr>";
                strHtml += "<td width=\"35%\" class=\"x_f04\" style=\"border-top:2px dotted #999;\">";
                strHtml += "<img src=\"../images/four/icn_01.png\" width=\"18\" height=\"25\"> " + dt2.Rows[j]["class_en"].ToString() + "<br>";
                strHtml += "<span class=\"x_f07\">" + dt2.Rows[j]["Class_Remark_EN"].ToString() + "</span></td>";
                strHtml += "<td class=\"x_f06\" style=\"border-top:2px dotted #999;\">" + dt2.Rows[j]["MealName_en"].ToString();
               
            }
            else
            {
                strHtml +="/<br>"+dt2.Rows[j]["MealName_en"].ToString();
            }

            if ((j + 1) == dt2.Rows.Count)
            {
                strHtml +=  "</td></tr>";
                strHtml += "<tr>";
                strHtml += " <td colspan=\"2\" class=\"x_line\"></td>";
                strHtml += "</tr> ";
            }
            title_old = dt2.Rows[j]["class_en"].ToString();

        }

        if (dt.Rows[0]["remark_en"].ToString() != "")
        {

            strHtml += "<tr>";
            strHtml += "<td colspan=\"2\" class=\"x_f08\">";
            string[] list_array = remark.Split(new char[] { '●' }, StringSplitOptions.RemoveEmptyEntries);

            for (int k = 0; k < list_array.Length; k++)
            {
                strHtml += "●" + list_array[k].ToString() + "<br>";
            }
           // strHtml += dt.Rows[0]["remark_en"].ToString();
            strHtml += "</td>";
            strHtml += "</tr>";         
        }
        LiteContent.Text = strHtml;

    }

   
   
}
