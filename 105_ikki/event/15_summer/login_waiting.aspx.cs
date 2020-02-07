using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_15_summer_login_waiting : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["438_iName_in1"] == null)
                Response.Redirect("login.aspx");
            #endregion


            #region 釋放記憶體暫存資料
            Session.Remove("438_iName_in1");
            Session.Remove("438_A_in1");
            Session.Remove("438_B_in1");
            Session.Remove("438_sStage_in1");
            Session.Remove("438_sStageH_in1");
            #endregion
        }
    }
}
