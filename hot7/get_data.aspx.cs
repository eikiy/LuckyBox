using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class get_data : System.Web.UI.Page
{
    wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        

        if (System.Convert.ToInt32(Request.Form["t"].ToString()) == 1)
        {
            DataSet ds = wow.Wow_BindCity();
            string outstr = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                outstr += ds.Tables[0].Rows[i]["name"].ToString().Trim() + "," + ds.Tables[0].Rows[i]["no"].ToString().Trim() + ";";
            }
            Response.Write(outstr);
        }

        if (System.Convert.ToInt32(Request.Form["t"].ToString()) == 2)
        {

            DataSet ds = wow.Wow_BindCity2Area(HttpUtility.HtmlEncode(Request.Form["city"].ToString()));
            string outstr = "";
            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                outstr += ds.Tables[0].Rows[i]["name"].ToString().Trim() + "," + ds.Tables[0].Rows[i]["zip"].ToString().Trim() + ";";
            }
            Response.Write(outstr);
        }

        if (System.Convert.ToInt32(Request.Form["t"].ToString()) == 3)
        {

            DataSet ds = wow.Wow_BindStore(CareerNo.ToString());
            string outstr = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                outstr += ds.Tables[0].Rows[i]["StoreName"].ToString().Trim() + "," + ds.Tables[0].Rows[i]["StoreNo"].ToString().Trim() + ";";
            }
            Response.Write(outstr);
        }
    }
}