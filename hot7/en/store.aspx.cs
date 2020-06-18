using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class en_store : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
      
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";
        string info = "";
        int phone_length = 0;

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");

        DataTable dt2 = new DataTable("store_detail");

        //area2.Visible = false;
        //area3.Visible = false;
        //area4.Visible = false;
       
      string sArea="";
      int iHtmlHead = 0;
        for (int a = 1; a <= 6; a++)
        {
            //1+2,3+4,5,6 把同一區的放在一起
            dt = wow.Wow_GetAStoreList(CareerNo, a.ToString());
           
                if (a == 1 || a == 3 || a == 6 || a == 5)
                {
                    sArea="";
                    strHtml = "";
                    if (dt.Rows.Count > 0)
                    {
                        iHtmlHead = iHtmlHead + 1;
                        strHtml += "<table width=\"90%\" border=\"0\" cellpadding=\"5\" cellspacing=\"0\" class=\"x_tb\">";
                    }
                }
           
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());

                string sname_en = "";
                string saddress_en = "";
                string stel = "";
                string sparking_info_en = "";
                string sequipment_en = "";
                string sequipment2_en = "";
                string sremark_en = "";
              
                string store_seat_en = "";
              
                sname_en = dt2.Rows[0]["store_name_en"].ToString();
                saddress_en = dt2.Rows[0]["store_address_en"].ToString();
                phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;
                stel = "+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length);
             
                sparking_info_en = dt2.Rows[0]["store_parking_info_en"].ToString();
                sequipment_en = dt2.Rows[0]["store_equipment_en"].ToString();
                store_seat_en = dt2.Rows[0]["store_seat_en"].ToString();
                sequipment2_en = dt2.Rows[0]["store_equipment2_en"].ToString();
                sremark_en = dt2.Rows[0]["store_remark_en"].ToString();
                strHtml += BindText(sname_en, saddress_en, stel, sparking_info_en, sequipment_en, store_seat_en, sequipment2_en, sremark_en);

            }
           
                if (a == 2 || a == 4 || a == 6 || a == 5)
                {
                    if (iHtmlHead  >= 1)
                    strHtml += "</table>";

                    iHtmlHead = 0;
                }
          
            
            //1+2,3+4,5,6
            switch (a)
            {
                case 2:
                         sArea = "<table width=\"90%\" border=\"0\" cellpadding=\"5\" cellspacing=\"0\" class=\"x_tb\" id=\"area1\">";
                        sArea += "<tr>";
                        sArea += "<td class=\"x_f09\">";
                        sArea += "<a name=\"01\"></a>North Taiwan";
                        sArea += "</td>";
                        sArea += "</tr>";
                        sArea += "</table>";
                        LiteArea1.Text = sArea + strHtml;

                    break;
                case 4:
                    if (strHtml!="")
                    {
                        sArea = "<table width=\"90%\" border=\"0\" cellpadding=\"5\" cellspacing=\"0\" class=\"x_tb\" id=\"area2\">";
                        sArea += "<tr>";
                        sArea += "<td class=\"x_f09\">";
                        sArea += "<a name=\"02\"></a>Central Taiwan";
                        sArea += "</td>";
                        sArea += "</tr>";
                        sArea += "</table>";

                        LiteArea2.Text = sArea + strHtml;
                        //area2.Visible = true;
                    }
                    break;
                case 5:
                    if (strHtml != "")
                    {
                        sArea = "<table width=\"90%\" border=\"0\" cellpadding=\"5\" cellspacing=\"0\" class=\"x_tb\" id=\"area4\">";
                        sArea += "<tr>";
                        sArea += "<td class=\"x_f09\">";
                        sArea += "<a name=\"04\"></a>East Taiwan";
                        sArea += "</td>";
                        sArea += "</tr>";
                        sArea += "</table>";

                        LiteArea4.Text = sArea+strHtml;
                        // area4.Visible = true;
                    }
                    break;
                case 6:
                    if (strHtml != "")
                    {
                        sArea = "<table width=\"90%\" border=\"0\" cellpadding=\"5\" cellspacing=\"0\" class=\"x_tb\" id=\"area3\">";
                        sArea += "<tr>";
                        sArea += "<td class=\"x_f09\">";
                        sArea += "<a name=\"03\"></a>South Taiwan";
                        sArea += "</td>";
                        sArea += "</tr>";
                        sArea += "</table>";
                        LiteArea3.Text = sArea + strHtml;
                       // area3.Visible = true;
                    }
                    break;
                default:
                    break;
            }
           
        }
       // LiteList.Text = strHtml;

    }
    //顯示前端資訊html

    private string BindText(string sname_en, string saddress_en, string stel,  string sparking_info_en, string sequipment_en, string store_seat_en, string sequipment2_en, string sremark_en)
    {
        string strHtml = "";
        strHtml += "<tr>";
        strHtml += "<td width=\"4%\">";
        strHtml += "<img src=\"../images/icn_01.png\">";
        strHtml += "</td>";
        strHtml += " <td colspan=\"2\" class=\"x_f04 x_f04t\">";
        strHtml += sname_en;
        strHtml += " </td>";
        strHtml += "  </tr>";
        strHtml += " <tr>";
        strHtml += "<td>&nbsp;";
        strHtml += "</td>";
        strHtml += "<td>";
        strHtml += "<img src=\"images/home.png\">";
        strHtml += "</td>";
        strHtml += "<td>";
        strHtml += saddress_en;
        strHtml += "</td>";
        strHtml += "</tr>";
        strHtml += "<tr>";
        strHtml += "<td width=\"4%\">&nbsp;";
        strHtml += "</td>";
        strHtml += "<td style=\"letter-spacing: normal;\">";
        strHtml += " <img src=\"images/tel.png\">";
        strHtml += " </td>";
        strHtml += "<td style=\"letter-spacing: normal;\">";
        strHtml += stel;
        strHtml += "</td>";
        strHtml += "</tr>";


        if (sequipment_en != "")
        {
            strHtml += "<tr>";
            strHtml += "<td width=\"4%\">&nbsp;";
            strHtml += "</td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += "";
            strHtml += " </td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += sequipment_en;
            strHtml += "</td>";
            strHtml += "</tr>";
        }
        if (store_seat_en != "")
        {
            strHtml += "<tr>";
            strHtml += "<td width=\"4%\">&nbsp;";
            strHtml += "</td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += "";
            strHtml += " </td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += store_seat_en;
            strHtml += "</td>";
            strHtml += "</tr>";
        }
        if (sequipment2_en != "")
        {
            strHtml += "<tr>";
            strHtml += "<td width=\"4%\">&nbsp;";
            strHtml += "</td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += "";
            strHtml += " </td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += sequipment2_en;
            strHtml += "</td>";
            strHtml += "</tr>";
        }
        if (sremark_en != "")
        {
            strHtml += "<tr>";
            strHtml += "<td width=\"4%\">&nbsp;";
            strHtml += "</td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += "";
            strHtml += " </td>";
            strHtml += "<td style=\"letter-spacing: normal;\">";
            strHtml += sremark_en;
            strHtml += "</td>";
            strHtml += "</tr>";
        }

        //strHtml += "</table>";


        return strHtml;

    }
}
