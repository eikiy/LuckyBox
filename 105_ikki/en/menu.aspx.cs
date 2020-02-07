using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class en_menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";
        string title = "";
        string title_old = "";
        string package_id = "";
        

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Meal");

        dt = wow.Wow_GetMeal(CareerNo);

        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable("MealDetail");
        int k = 3;
        int a = 0;

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            if (Request.QueryString["id"] == null || Request.QueryString["id"] == "" && i == 0)
            {
                package_id = dt.Rows[0]["package_id"].ToString();
                a = 0;
            }
            else
            {
                if (Request.QueryString["id"].ToString() == dt.Rows[i]["package_id"].ToString())
                {
                    package_id = dt.Rows[i]["package_id"].ToString();
                    a = i;
                }
            }
            
            strHtml += "<tr>";
            strHtml += "<td><a href=\"menu.aspx?id=" + dt.Rows[i]["package_id"].ToString() + "\"><img src=\"images/menu_0" + k.ToString() + ".png\" onmouseover=\"this.src='images/menu_0" + k.ToString() + "c.png'\" onmouseout=\"this.src='images/menu_0" + k.ToString() + ".png'\" alt=\"Menu\" width=\"240\" height=\"33\" style=\"cursor:pointer; border: none;\" /></a></td>";
            strHtml += "</tr>";
            k++;
        }
        LiteMenu.Text = strHtml;
        strHtml = "";
        //Response.Write(package_id);

        dt2 = wow.Wow_GetMealDetail(package_id);
 
        //for (int i = 0; i < dt.Rows.Count; i++)
        //{
            strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"list\">";
            strHtml += "<tr>";
            strHtml += "<td colspan=\"2\" align=\"center\" style=\"border:none;\"><span class=\"f_title\">" + dt.Rows[0]["name_en"].ToString() + "</span><br>";
            strHtml += "<span class=\"f_p\">" + dt.Rows[a]["price_en"].ToString() + "</span></td>";
            strHtml += "</tr>";
           
            dt2 = wow.Wow_GetMealDetail(dt.Rows[a]["package_id"].ToString());

            title = "";
            title_old = "";
            string line = "";
            for (int j = 0; j < dt2.Rows.Count; j++)
            {
                //第1次, 指向舊的名稱, 第1次後指向新名稱
                if (j == 0)
                {
                    title_old = dt2.Rows[j]["class_en"].ToString();
                }
                else
                {
                    title = dt2.Rows[j]["class_en"].ToString();
                }

                //如果新舊名稱不一樣, 則輸出開始div, 一樣則直輸出菜單名細
                if (title != title_old)
                {
                    title_old = dt2.Rows[j]["class_en"].ToString();

                    if (j > 0)
                    {
                        if (line == "")
                        {
                            strHtml += "</td>";
                            strHtml += "</tr>";
                        }
                    }
                    if (dt2.Rows[j]["MealName_en"].ToString() != "")
                    {
                        strHtml += "<tr>";
                        strHtml += "<td width=\"25%\" class=\"f_01\">" + dt2.Rows[j]["class_en"].ToString() + "</td>";
                        strHtml += "<td>" + dt2.Rows[j]["MealName_en"].ToString();
                    }
                    else
                    {
                        line = "y";
                        strHtml += "<tr>";
                        strHtml += "<td colspan=\"2\" class=\"f_01\">" + dt2.Rows[j]["class_en"].ToString() + "</td></tr>";
                    }
                }
                else
                {
                    line = "";
                    if (dt2.Rows[j]["MealName_en"].ToString() != "")
                    {
                        strHtml += " / <br>" + dt2.Rows[j]["MealName_en"].ToString();
                    }
                }

                if ((j + 1) == dt2.Rows.Count)
                {
                    strHtml += "</td></tr>";
                }

            }

            if (dt.Rows[a]["remark_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td colspan=\"2\" class=\"f_01 f_02\"><span style=\"font-weight:normal;\">" + dt.Rows[a]["remark_en"].ToString() + "</span></td>";
                strHtml += "</tr>";
            }
             strHtml += "</table>";
        //}
        
        LiteContent.Text = strHtml;

    }
}