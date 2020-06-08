using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class e_member_application_success2 : System.Web.UI.Page
{
    blAction _blAction = new blAction();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["name"] == null)//暫存???
                Response.Redirect("index.aspx");//第一頁???
            #endregion
            Label1.Text = Session["name"].ToString();
            Label2.Text = Session["email"].ToString();
        }
    }

}
