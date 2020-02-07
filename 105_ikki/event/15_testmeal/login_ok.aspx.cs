using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_15_testmeal_login_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region 驗證頁面順序
        if (Session["437_iRBstage_in1"] == null)
            Response.Redirect("login.aspx");
        #endregion


        #region 顯示登入者
        //顯示登入者姓名(本名) 
        lblName.Text = Session["437_iName_in1"].ToString().Trim();   
        #endregion



        //設定編號==========================================================================
        LabelA.Text = Session["437_A_in1"].ToString();
        if (Session["437_B_in1"].ToString()!="")
        LabelB.Text = ","+Session["437_B_in1"].ToString();

        //設定場地==========================================================================
        if (Session["437_iRBstage_in1"].ToString() == "1")
        {
            Label_STAGE.Text = "6/16(二) 18:30~20:30 藝奇";
            HyperLink_STAGE.Text = "台北敦化北店";
            HyperLink_STAGE.NavigateUrl = "http://www.ikki.com.tw/store_all.aspx?#id10501";
        }
        if (Session["437_iRBstage_in1"].ToString() == "2")
        {
            Label_STAGE.Text = "6/17(三) 18:30~20:30 藝奇";
            HyperLink_STAGE.Text = "台中福雅店";
            HyperLink_STAGE.NavigateUrl = "http://www.ikki.com.tw/store_all.aspx?#id10510";
        }
        if (Session["437_iRBstage_in1"].ToString() == "3")
        {
            Label_STAGE.Text = "6/18(四) 18:30~20:30 藝奇";
            HyperLink_STAGE.Text = "仁德中山店";
            HyperLink_STAGE.NavigateUrl = "http://www.ikki.com.tw/store_all.aspx?#id10517";
        }

        #region 釋放記憶體暫存資料
        Session.Remove("437_iRBstage_in1");
        Session.Remove("437_A_in1");
        Session.Remove("437_B_in1");
        #endregion
    }
}
