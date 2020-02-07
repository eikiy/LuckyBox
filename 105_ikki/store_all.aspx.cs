using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class store_all : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");

        DataTable dt2 = new DataTable("store_detail");

        check_input new_word = new check_input();

        string css = "";

        string info = "";
        for (int j = 1; j <= 6; j++)
        {
            dt = wow.Wow_GetAStoreList(CareerNo, j.ToString());
            if (dt.Rows.Count > 0)
            {

                if (j == 1)
                {
                    css = "style=\"*margin-top:-30px;\"";
                }
                else
                {
                    css = "";
                }
                strHtml += "<span class=\"anchor\" id=\"link0" + j + "\" " + css + "></span>";
                strHtml += "<img src=\"images/icon_store_0" + j + ".png\" width=\"651\" height=\"45\">";


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

                    if (dt2.Rows[0]["store_info"].ToString() != "")
                    {
                        info = dt2.Rows[0]["store_info"].ToString();
                    }
                    else
                    {
                        info = "";
                    }

                strHtml += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"word\">";
                strHtml += "  <tr>";
                strHtml += " 	  <td>";
                strHtml += "    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"info\">";
                strHtml += "  <tr>";
                strHtml += "    <td colspan=\"2\"class=\"font_02\" ><a name=\"id" + dt2.Rows[0]["store_id"].ToString() + "\" id=\"id" + dt2.Rows[0]["store_id"].ToString() + "\" class=\"anchor\" style=\"*margin-top:-30px;\" ></a>▍" + dt2.Rows[0]["store_name"].ToString() + " ▍</td>";
                strHtml += "    </tr>";
                if (info != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td colspan=\"2\"><span class=\"font_01\">" + info + "</span></td>";
                    strHtml += "    </tr>";
                }
                strHtml += "  <tr>";
                strHtml += "  	<td width=\"22%\">地址：</td>";
                strHtml += "  	<td>" + dt2.Rows[0]["store_address"].ToString() + "</td>";
                strHtml += " 	</tr>";
                strHtml += "  <tr>";
                strHtml += "    <td>電話：</td>";
                strHtml += "    <td>" + dt2.Rows[0]["store_tel"].ToString() + "</td>";
                strHtml += "  </tr>";
                strHtml += "  <tr>";
                strHtml += "    <td>營業時間：</td>";
                strHtml += "    <td>" + dt2.Rows[0]["store_opening_hours"].ToString().Replace("\n", "<br>") + "</td>";
                strHtml += "  </tr>";
                if (dt2.Rows[0]["store_content"].ToString() != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td>店舖介紹：</td>";
                    strHtml += " <td>" + dt2.Rows[0]["store_content"].ToString() + "</td>";
                    strHtml += "  </tr>";
                }
                if (dt2.Rows[0]["store_parking_info"].ToString() != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td>停車資訊：</td>";
                    strHtml += "    <td>" + dt2.Rows[0]["store_parking_info"].ToString() + "</td>";
                    strHtml += "  </tr>";
                }
                if (dt2.Rows[0]["store_equipment"].ToString() != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td>電梯設備：</td>";
                    strHtml += "    <td>" + dt2.Rows[0]["store_equipment"].ToString() + "</td>";
                    strHtml += "  </tr>";
                }
                if (dt2.Rows[0]["store_seat"].ToString() != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td>客席數：</td>";
                    strHtml += "    <td>" + dt2.Rows[0]["store_seat"].ToString() + "</td>";
                    strHtml += "  </tr>";
                }
                if (dt2.Rows[0]["store_equipment2"].ToString() != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td>無障礙空間：</td>";
                    strHtml += "    <td>" + dt2.Rows[0]["store_equipment2"].ToString() + "</td>";
                    strHtml += "  </tr>";
                }
                if (dt2.Rows[0]["store_remark"].ToString() != "")
                {
                    strHtml += "  <tr>";
                    strHtml += "    <td>交通資訊：</td>";
                    strHtml += "    <td>" + dt2.Rows[0]["store_remark"].ToString() + "</td>";
                    strHtml += "  </tr>";
                }
                strHtml += "</table>";

                strHtml += "    </td>";
                strHtml += " 	  <td style=\"text-align:right;\">";
                strHtml += "    <img src=\"" + dt2.Rows[0]["store_image"].ToString() + "\" width=\"290\" height=\"173\" class=\"banner\"><br>";
                strHtml += "      <img src=\"" + dt2.Rows[0]["store_map"].ToString() + "\" width=\"290\" height=\"173\" class=\"banner\"><br>";
                strHtml += "       <a href=\"javascript:;\" onClick=\"MM_openBrWindow('store_print.aspx?id=" + dt2.Rows[0]["store_id"].ToString() + "','','width=780,height=520')\"><img src=\"images/print.gif\" width=\"70\" height=\"30\" style=\"border:none; float:right;\"></a></td>";
                strHtml += "    </td>";
                strHtml += "</tr>";
                strHtml += "</table>";

                }
            }
                
        }

        LiteList.Text = strHtml;
    }
}