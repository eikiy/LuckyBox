using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class search : System.Web.UI.Page
{
    Common.Common cn = new Common.Common();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtCode.Text.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的【禮券編號】未填寫,請填寫..');</script>");
            return;
        }
        int iLEN = txtCode.Text.Trim().Length;
        string sError = "";
        DataSet DSCupon = new DataSet();
        sError = cn.Cupon_Query(Public.strP_ShopNo, txtCode.Text.ToString().Trim(), out DSCupon);
        GridView1.DataSource = DSCupon;
        GridView1.DataBind();
    }

}
