using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class menu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("Meal");

        dt = wow.Wow_GetMeal(CareerNo);

        DataSet ds2 = new DataSet();
        DataTable dt2 = new DataTable("MealDetail");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            strHtml += "<a href=\"meal.aspx?id=" + dt.Rows[i]["package_id"].ToString() + "\"><div class=\"meal\"><div class=\"txt\">";
            strHtml += "<div class=\"txt1\">" + dt.Rows[i]["name"].ToString() + "</div>";
            strHtml += "<div class=\"txt2\">" + dt.Rows[i]["price"].ToString() + "</div></div>";
            strHtml += "<div class=\"arrow\"><img src=\"images/menu/arrow.png\" width=\"17\" height=\"19\" border=\"0\"></div>";
            strHtml += "<div class=\"line1\"><img src=\"images/menu/line1.jpg\" width=\"320\" height=\"1\" border=\"0\"></div>";
            strHtml += "</div></a>";
        }

        LiteMenu.Text = strHtml;
    }
}