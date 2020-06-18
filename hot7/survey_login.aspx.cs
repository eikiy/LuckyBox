using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;

public partial class survey_login : System.Web.UI.Page
{
    #region 共用參數
    blSuggestCard _blSuggestCard = new blSuggestCard();
    blAction _blAction = new blAction();
    string sAction_No = "311";//活動編號[要改](原本是461，Andy接手改446 2016/12/09)
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["115_SC_IQType"] != null)
        {
            lbl115_SC_IQType.Text = Request["115_SC_IQType"].ToString().Trim();
        }
        if (Session["QAStep"] == null || Session["QAStep"] != "survey_2.aspx")
        {
            Response.Redirect("survey_1.aspx");
        }
    }


    //[送出]紐==========================================================================================
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sError = "";
        DataSet DS = new DataSet();
        Member.Member m = new Member.Member();//服務
        sError = m.ActionMemberLoginCheck(txtEmail2.Value.Trim(), txtPwd.Value.Trim(), Public.strP_Ename, Public.strP_ShopNo, out DS);
        if (sError != "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + sError + "');</script>");
            return;
        }
        Session["UpdateName"] = DS.Tables[0].Rows[0]["姓名"].ToString().Trim();
        Session["UpdateGender"] = DS.Tables[0].Rows[0]["性別"].ToString().Trim();
        Session["UpdateBday"] = DS.Tables[0].Rows[0]["生日"].ToString().Trim();
        Session["UpdateCellphone"] = DS.Tables[0].Rows[0]["手機"].ToString().Trim();
        Session["Updatephone_area"] = DS.Tables[0].Rows[0]["phone_area"].ToString().Trim();
        Session["Updatephone_no"] = DS.Tables[0].Rows[0]["phone_no"].ToString().Trim();
        Session["Updatephone_ext"] = DS.Tables[0].Rows[0]["phone_ext"].ToString().Trim();
        DateTime bday = DateTime.Parse(Session["UpdateBday"].ToString()).Date;




        #region 寫入抽獎(活動資料庫)
        if (lbl115_SC_IQType.Text == "")
        {
            string sExpendDate = Session["115_SC_eatDate"].ToString();
            string sIQInvoice = Session["115_SC_Invoice"].ToString();
            string sStoreNo = Session["115_SC_Store"].ToString();

            //檢查如果會員資料已經有此發票了，就不寫入
            if (!_blAction.CheckInvoice1(Public.strP_Ename, sAction_No, sIQInvoice, "value2", txtEmail2.Value.Trim()))
            {

                string strUid = DS.Tables[0].Rows[0]["uid"].ToString().Trim();
                string strEmail = DS.Tables[0].Rows[0]["email"].ToString().Trim();
                bool blReturn = true;
                blReturn = _blAction.InsertWangActionMembers_SuggestCard(Public.strP_Ename, sAction_No, strUid, strEmail, sExpendDate, sIQInvoice, "1", sStoreNo);
                if (!blReturn)
                {
                    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
                    return;
                }
            }
        }
        #endregion

        #region 修改會員資料IQMainData(Email、uid)
        if (lbl115_SC_IQType.Text == "")
        {
            bool blReturn = true;
            blReturn = _blSuggestCard.UpdSC_IQMainData(Session["115_SC_IQRecMGUID"].ToString(), txtEmail2.Value.Trim(), DS.Tables[0].Rows[0]["uid"].ToString().Trim(), DS.Tables[0].Rows[0]["uid"].ToString().Trim());
            if (!blReturn)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                return;
            }
        }
        #endregion

        #region 修改全部意見SC_RecAns2Par:性別
        if (lbl115_SC_IQType.Text == "")
        {
            StringBuilder sbD = new StringBuilder();
            string sQ9AnsGUID = "";
            string sQ9AnsCode = "";
            DataRow[] rowQ9 = (DataRow[])Session["115_SC_Q9_Sex"];
            for (int i9 = 0; i9 < rowQ9.Length; i9++)
            {
                if (Session["UpdateGender"].ToString().Trim() == rowQ9[i9]["AnsName"].ToString().Trim())
                {
                    sQ9AnsGUID = rowQ9[i9]["AnsGUID"].ToString().Trim();
                    sQ9AnsCode = rowQ9[i9]["AnsCode"].ToString().Trim();
                }
            }


            string sRecAnsGUID = Session["115_RecAnsGUID_Q9_Sex"].ToString();
            string sAnsGUIDGroup = sQ9AnsGUID;
            string sAnsCodeGroup = sQ9AnsCode;
            bool blReturn = true;
            blReturn = _blSuggestCard.UpdSC_RecAns2Par(sRecAnsGUID, sAnsGUIDGroup, sAnsCodeGroup);
            if (!blReturn)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                return;
            }
        }
        #endregion

        #region 修改全部意見SC_RecAns2Par:年齡
        if (lbl115_SC_IQType.Text == "")
        {
            StringBuilder sbDA = new StringBuilder();
            string sQ10AnsGUID = "";
            string sQ10AnsCode = "";
            DataRow[] rowQ10 = (DataRow[])Session["115_SC_Q10_Age"];
            int iBir = DateTime.Now.Year - DateTime.Parse(Session["UpdateBday"].ToString().Trim()).Year;
            // for (int iQ10 = rblQ10.Items.Count; iQ10 >= 1; iQ10--)
            for (int i10 = 0; i10 < rowQ10.Length; i10++)
            {
                int iBirText = 0;
                if (rowQ10[i10]["AnsName"].ToString().Trim().Length >= 2)
                {
                    iBirText = int.Parse(rowQ10[i10]["AnsName"].ToString().Trim().Substring(0, 2));
                }
                if (iBir >= iBirText)
                {
                    sQ10AnsGUID = rowQ10[i10]["AnsGUID"].ToString().Trim();
                    sQ10AnsCode = rowQ10[i10]["AnsCode"].ToString().Trim();
                }
            }

            string sRecAnsGUID = Session["115_RecAnsGUID_Q10_Age"].ToString();
            string sAnsGUIDGroup = sQ10AnsGUID;
            string sAnsCodeGroup = sQ10AnsCode;
            bool blReturn = true;
            blReturn = _blSuggestCard.UpdSC_RecAns2Par(sRecAnsGUID, sAnsGUIDGroup, sAnsCodeGroup);
            if (!blReturn)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                return;
            }
        }
        #endregion

        Session.Remove("QAStep");
        Session["QAStep"] = "survey_login.aspx";
        //轉換下一頁
        Response.Redirect("survey_ok.aspx");
    }
        

}
