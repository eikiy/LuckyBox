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


public partial class event_13_design_books_ok : System.Web.UI.Page
{
    Sql s = new Sql();
    Public p = new Public();
    string sAction_No = "322";
    string sCareer = "ikki";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("<sql>");
            sb.Append("<select>");
            sb.Append("<list><![CDATA[select [NumberCode],[CheckCode] from [wang_action_code] Where ActionNo='" + sAction_No + "' and IsDelete=0 and IsUsed='0' ]]></list>");
            sb.Append("</select>");
            sb.Append("</sql>");
            string sError = "";
            DataSet DD = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);


            if (DD.Tables["list"].Rows.Count > 0)
                lblCnt.Text = Convert.ToString(Convert.ToInt16(DD.Tables["list"].Rows.Count) / 2);
            else
                lblCnt.Text = "0";


            //lblTotCnt

            if (Session["322_Coupon1"] == null || Session["322_Coupon2"] == null)
                Response.Redirect("books.aspx"); 


            lblCoupon1.Text = Session["322_Coupon1"].ToString().Trim();
            lblCoupon2.Text = Session["322_Coupon2"].ToString().Trim();

            Session.Remove("322_Coupon1");
            Session.Remove("322_Coupon2");

        }

    }
}
