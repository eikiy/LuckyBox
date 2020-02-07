using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_15_summer_login_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["438_iName_in1"] == null)
                Response.Redirect("login.aspx");
            #endregion


            #region 顯示登入者
            //顯示登入者姓名(本名) 
            lblName.Text = Session["438_iName_in1"].ToString().Trim();
            #endregion


            //設定編號==========================================================================
            LabelA.Text = Session["438_A_in1"].ToString();
            if (Session["438_B_in1"].ToString() != "")
                LabelB.Text = "," + Session["438_B_in1"].ToString();

            //設定場地==========================================================================
            Label_STAGE.Text = "7/29(三) 11:00~13:00 ";
            HyperLink_STAGE.Text = Session["438_sStage_in1"].ToString();
            HyperLink_STAGE.NavigateUrl = Session["438_sStageH_in1"].ToString();


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
