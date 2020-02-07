using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_15_testmeal_login_waiting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region 驗證頁面順序
        if (Session["437_iRBstage_in1"] == null)
            Response.Redirect("login.aspx");
        #endregion


        #region 釋放記憶體暫存資料
        Session.Remove("437_iRBstage_in1");
        Session.Remove("437_A_in1");
        Session.Remove("437_B_in1");
        #endregion
    }
}
