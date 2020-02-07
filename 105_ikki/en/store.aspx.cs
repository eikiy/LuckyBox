using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class en_store : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string strHtml = "";
        int phone_length = 0;

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("store");
        DataTable dt3 = new DataTable("store2");

        DataTable dt2 = new DataTable("store_detail");

        dt = wow.Wow_GetAStoreList(CareerNo, "1");

        strHtml += "<tr>";
        strHtml += "<td colspan=\"3\" height=\"40\" style=\"background:url(images/store_t_bg.png) left no-repeat;\"><a name=\"a1\" id=\"a1\"></a>";
        strHtml += "  <table width=\"200\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"store_area\">";
        strHtml += " <tr>";
        strHtml += "		<td><strong>North Taiwan</strong></td>";
        strHtml += "    </tr>";
        strHtml += "</table>";
        strHtml += "</td>";
        strHtml += "</tr>";
        strHtml += "<tr>";
        strHtml += "<td colspan=\"3\" class=\"gt12\" align=\"right\">";
        
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
            phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;

            strHtml += "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"store_all\">";
            strHtml += "<tr>";
            strHtml += "<td colspan=\"2\" class=\"f_01\"><strong>▌" + dt2.Rows[0]["store_name_en"].ToString() + "</strong></td>";
            strHtml += "</tr>";
            strHtml += "<tr>";
            strHtml += "<td width=\"75%\">" + dt2.Rows[0]["store_address_en"].ToString() + "</td>";
            strHtml += "<td width=\"24%\">+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length) + "</td>";
            strHtml += "</tr>";
            if (dt2.Rows[0]["store_parking_info_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>" + dt2.Rows[0]["store_parking_info_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_equipment_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>" + dt2.Rows[0]["store_equipment_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_equipment2_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>Accessible Space</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_remark_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td class=\"f_02\">" + dt2.Rows[0]["store_remark_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            strHtml += "</table>";
        }
                
        dt = wow.Wow_GetAStoreList(CareerNo, "2");

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
            phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;

            strHtml += "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"store_all\">";
            strHtml += "<tr>";
            strHtml += "<td colspan=\"2\" class=\"f_01\"><strong>▌" + dt2.Rows[0]["store_name_en"].ToString() + "</strong></td>";
            strHtml += "</tr>";
            strHtml += "<tr>";
            strHtml += "<td width=\"75%\">" + dt2.Rows[0]["store_address_en"].ToString() + "</td>";
            strHtml += "<td width=\"24%\">+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length) + "</td>";
            strHtml += "</tr>";
            if (dt2.Rows[0]["store_parking_info_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>" + dt2.Rows[0]["store_parking_info_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_equipment_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>" + dt2.Rows[0]["store_equipment_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_equipment2_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>Accessible Space</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_remark_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td class=\"f_02\">" + dt2.Rows[0]["store_remark_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            strHtml += "</table>";
        }
        strHtml += "</td>";
        strHtml += "</tr>";

        dt = wow.Wow_GetAStoreList(CareerNo, "3");

        strHtml += "<tr>";
        strHtml += "<td colspan=\"3\" height=\"40\" style=\"background:url(images/store_t_bg.png) left no-repeat;\"><a name=\"a2\" id=\"a2\"></a>";
        strHtml += "  <table width=\"200\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"store_area\">";
        strHtml += " <tr>";
        strHtml += "		<td><strong>Central Taiwan</strong></td>";
        strHtml += "    </tr>";
        strHtml += "</table>";
        strHtml += "</td>";
        strHtml += "</tr>";
        strHtml += "<tr>";
        strHtml += "<td colspan=\"3\" class=\"gt12\" align=\"right\">";

        for (int i = 0; i < dt.Rows.Count; i++)
        {
            dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
            phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;

            strHtml += "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"store_all\">";
            strHtml += "<tr>";
            strHtml += "<td colspan=\"2\" class=\"f_01\"><strong>▌" + dt2.Rows[0]["store_name_en"].ToString() + "</strong></td>";
            strHtml += "</tr>";
            strHtml += "<tr>";
            strHtml += "<td width=\"75%\">" + dt2.Rows[0]["store_address_en"].ToString() + "</td>";
            strHtml += "<td width=\"24%\">+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length) + "</td>";
            strHtml += "</tr>";
            if (dt2.Rows[0]["store_parking_info_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>" + dt2.Rows[0]["store_parking_info_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_equipment_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>" + dt2.Rows[0]["store_equipment_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_equipment2_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td>Accessible Space</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            if (dt2.Rows[0]["store_remark_en"].ToString() != "")
            {
                strHtml += "<tr>";
                strHtml += "<td class=\"f_02\">" + dt2.Rows[0]["store_remark_en"].ToString() + "</td>";
                strHtml += "<td>&nbsp;</td>";
                strHtml += "</tr>";
            }
            strHtml += "</table>";
        }
        strHtml += "</td>";
        strHtml += "</tr>";
       
        dt = wow.Wow_GetAStoreList(CareerNo, "4");
        dt3 = wow.Wow_GetAStoreList(CareerNo, "6");
        if (dt.Rows.Count > 0 || dt3.Rows.Count > 0)
        {
            strHtml += "<tr>";
            strHtml += "<td colspan=\"3\" height=\"40\" style=\"background:url(images/store_t_bg.png) left no-repeat;\"><a name=\"a3\" id=\"a3\"></a>";
            strHtml += "  <table width=\"200\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"store_area\">";
            strHtml += " <tr>";
            strHtml += "		<td><strong>South Taiwan</strong></td>";
            strHtml += "    </tr>";
            strHtml += "</table>";
            strHtml += "</td>";
            strHtml += "</tr>";
            strHtml += "<tr>";
            strHtml += "<td colspan=\"3\" class=\"gt12\" align=\"right\">";
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
                phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;

                strHtml += "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"store_all\">";
                strHtml += "<tr>";
                strHtml += "<td colspan=\"2\" class=\"f_01\"><strong>▌" + dt2.Rows[0]["store_name_en"].ToString() + "</strong></td>";
                strHtml += "</tr>";
                strHtml += "<tr>";
                strHtml += "<td width=\"75%\">" + dt2.Rows[0]["store_address_en"].ToString() + "</td>";
                strHtml += "<td width=\"24%\">+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length) + "</td>";
                strHtml += "</tr>";
                if (dt2.Rows[0]["store_parking_info_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>" + dt2.Rows[0]["store_parking_info_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_equipment_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>" + dt2.Rows[0]["store_equipment_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_equipment2_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>Accessible Space</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_remark_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td class=\"f_02\">" + dt2.Rows[0]["store_remark_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                strHtml += "</table>";
            }

            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt3.Rows[i]["store_id"].ToString());
                phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;

                strHtml += "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"store_all\">";
                strHtml += "<tr>";
                strHtml += "<td colspan=\"2\" class=\"f_01\"><strong>▌" + dt2.Rows[0]["store_name_en"].ToString() + "</strong></td>";
                strHtml += "</tr>";
                strHtml += "<tr>";
                strHtml += "<td width=\"75%\">" + dt2.Rows[0]["store_address_en"].ToString() + "</td>";
                strHtml += "<td width=\"24%\">+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length) + "</td>";
                strHtml += "</tr>";
                if (dt2.Rows[0]["store_parking_info_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>" + dt2.Rows[0]["store_parking_info_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_equipment_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>" + dt2.Rows[0]["store_equipment_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_equipment2_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>Accessible Space</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_remark_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td class=\"f_02\">" + dt2.Rows[0]["store_remark_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                strHtml += "</table>";
            }
            strHtml += "</td>";
            strHtml += "</tr>";
        }
                
        dt = wow.Wow_GetAStoreList(CareerNo, "5");
        if (dt.Rows.Count > 0)
        {
            strHtml += "<tr>";
            strHtml += "<td colspan=\"3\" height=\"40\" style=\"background:url(images/store_t_bg.png) left no-repeat;\"><a name=\"a4\" id=\"a4\"></a>";
            strHtml += "  <table width=\"200\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\" class=\"store_area\">";
            strHtml += " <tr>";
            strHtml += "		<td><strong>East Taiwan</strong></td>";
            strHtml += "    </tr>";
            strHtml += "</table>";
            strHtml += "</td>";
            strHtml += "</tr>";
            strHtml += "<tr>";
            strHtml += "<td colspan=\"3\" class=\"gt12\" align=\"right\">";
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt2 = wow.Wow_GetStoreDetail(dt.Rows[i]["store_id"].ToString());
                phone_length = dt2.Rows[0]["store_tel"].ToString().Length - 1;

                strHtml += "<table width=\"100%\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"store_all\">";
                strHtml += "<tr>";
                strHtml += "<td colspan=\"2\" class=\"f_01\"><strong>▌" + dt2.Rows[0]["store_name_en"].ToString() + "</strong></td>";
                strHtml += "</tr>";
                strHtml += "<tr>";
                strHtml += "<td width=\"75%\">" + dt2.Rows[0]["store_address_en"].ToString() + "</td>";
                strHtml += "<td width=\"24%\">+886 " + dt2.Rows[0]["store_tel"].ToString().Substring(1, phone_length) + "</td>";
                strHtml += "</tr>";
                if (dt2.Rows[0]["store_parking_info_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>" + dt2.Rows[0]["store_parking_info_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_equipment_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>" + dt2.Rows[0]["store_equipment_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_equipment2_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td>Accessible Space</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                if (dt2.Rows[0]["store_remark_en"].ToString() != "")
                {
                    strHtml += "<tr>";
                    strHtml += "<td class=\"f_02\">" + dt2.Rows[0]["store_remark_en"].ToString() + "</td>";
                    strHtml += "<td>&nbsp;</td>";
                    strHtml += "</tr>";
                }
                strHtml += "</table>";
            }
            strHtml += "</td>";
            strHtml += "</tr>";
        }
        LiteList.Text = strHtml;

        
    }
}