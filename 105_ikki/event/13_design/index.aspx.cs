using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;


public partial class event_13_design_index : System.Web.UI.Page
{
    Sql s = new Sql();
    Public p = new Public();
    string sAction_No = "322";
    string sCareer = "ikki";
    int totalCouponCnt = 20;
    protected void Page_Load(object sender, EventArgs e)
    {

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list1><![CDATA[select [NumberCode],[CheckCode] from [wang_action_code] Where ActionNo='" + sAction_No + "' and IsDelete=0 and IsUsed='1' ]]></list1>"); 
        sb.Append("</select>");
        sb.Append("</sql>");


        string sError = "";
        DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        lblCnt.Text = Convert.ToString(DD.Tables["list1"].Rows.Count + 15000);


    }
}
