using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class survey_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["QAStep"] == null)
                Response.Redirect("survey_1.aspx");

            ClearIQSession();
        }
    }



    #region 清除Session:ClearIQSession()
    private void ClearIQSession()
    {
        //(第一頁)---------------------------------------------------------
        Session.Remove("115_SC_MainData");//[版本]
        Session.Remove("115_SC_eatDate"); //日期
        Session.Remove("115_SC_eatTime"); //時間
        Session.Remove("115_SC_Store");   //店鋪
        Session.Remove("115_SC_Invoice"); //發票
        Session.Remove("115_SC_Uid");     //會員uid
        Session.Remove("115_SC_Email");   //會員email


        //(第二頁)---------------------------------------------------------
        Session.Remove("115_SC_Ans");
        Session.Remove("115_SC_Q6_List");
        Session.Remove("115_SC_Q9_Sex");          //用於更新性別
        Session.Remove("115_SC_Q10_Age");         //用於更新生日
        Session.Remove("115_SC_IQRecMGUID");      //會員資料IQRecMGUID=問卷RecMainGUID
        Session.Remove("115_RecAnsGUID_Q9_Sex");
        Session.Remove("115_RecAnsGUID_Q10_Age");


        //(登入頁)---------------------------------------------------------
        Session.Remove("UpdateName");
        Session.Remove("UpdateGender");
        Session.Remove("UpdateBday");
        Session.Remove("UpdateCellphone");
        Session.Remove("Updatephone_area");
        Session.Remove("Updatephone_no");
        Session.Remove("Updatephone_ext");


        Session.Remove("QAStep");
    }
    #endregion

}
