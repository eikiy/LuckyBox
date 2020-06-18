using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class test : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            aaclsPubSet.BindCity(selecity);
        }
    }
    protected void selecity_SelectedIndexChanged(object sender, EventArgs e)
    {
        //StringBuilder sb = new StringBuilder();
        //sb.Append("<sql>");
        //sb.Append("<select>");
        //sb.Append("<list><![CDATA[select zip+area as name,zip from area where city='" + selecity.SelectedItem.Value.ToString().Trim() + "']]></list>");
        //sb.Append("</select>");
        //sb.Append("</sql>");
        //string sError = "";
        //DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        //cbozip.DataSource = DS;
        //cbozip.DataMember = "list";
        //cbozip.DataTextField = "name";
        //cbozip.DataValueField = "zip";
        //cbozip.DataBind();
        string sCity = selecity.SelectedItem.Value.ToString().Trim();
        cbozip.Items.Clear();
        if (sCity == "請選擇")
            return;
        aaclsPubSet.BindCity2Area(cbozip, sCity);
    }
}
