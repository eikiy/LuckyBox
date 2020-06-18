using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class survey_nonlog : System.Web.UI.Page
{

    #region 共用參數
    blSuggestCard _blSuggestCard = new blSuggestCard();
    string sError = "";
    #endregion


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["QAStep"] == null || Session["QAStep"] != "survey_2.aspx")
            {
                Response.Redirect("survey_1.aspx");
            }


            #region 頁面顯示:年月日
            //輸出年
            int y = 0;

            selebiryear.Items.Add(new ListItem("1931(民國20年前)", "1931"));
            for (int i = 1932; i <= System.Convert.ToInt16(DateTime.Now.Year.ToString()); i++)
            {
                y = i - 1911;
                selebiryear.Items.Add(new ListItem(i.ToString() + "(民國" + y.ToString() + "年)", i.ToString()));
            }

            //輸出月
            for (int i = 1; i <= 12; i++)
            {
                selebirmonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日
            for (int i = 1; i <= 31; i++)
            {
                selebirday.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
            #endregion
        }
    }


    //[送出]按鈕=====================================================================
    protected void Button1_Click(object sender, EventArgs e)
    {

        if (CheckBox_AgreedEmail.Checked == true)
        {


            #region 資料輸入檢查
            if (txtCName.Text == "")
            {
                Tools.REG_script(Page, "<script>alert('您的姓名未選擇,請重新填寫..');</script>");
                return;
            }

            if (rbtnGender.SelectedValue == "")
            {
                Tools.REG_script(Page, "<script>alert('您的性別未選擇,請重新填寫..');</script>");
                return;
            }

            if (selebiryear.SelectedValue.Trim() == "")
            {
                Tools.REG_script(Page, "<script>alert('您的出生年份未選擇,請重新填寫..');</script>");
                return;
            }

            if (selebirmonth.SelectedValue.Trim() == "")
            {
                Tools.REG_script(Page, "<script>alert('您的出生月份未選擇,請重新填寫..');</script>");
                return;
            }

            if (selebirday.SelectedValue.Trim() == "")
            {
                Tools.REG_script(Page, "<script>alert('您的出生日期未選擇,請重新填寫..');</script>");
                return;
            }
            try
            {
                DateTime.Parse(selebiryear.SelectedValue.Trim() + "/" + selebirmonth.SelectedValue.Trim() + "/" + selebirday.SelectedValue.Trim());
            }
            catch (Exception ex)
            {
                Tools.REG_script(Page, "<script>alert('您的出生年月日格式有誤,請重新填寫..');</script>");
            }
            DateTime dt = DateTime.Parse(selebiryear.SelectedValue.Trim() + "/" + selebirmonth.SelectedValue.Trim() + "/" + selebirday.SelectedValue.Trim());

            if (txtEmail.Text == "")
            {
                Tools.REG_script(Page, "<script>alert('您的email未選擇,請重新填寫..');</script>");
                return;
            }
            if (!check_input.CheckEMail(txtEmail.Text.ToString().Trim()))
            {
                Tools.REG_script(Page, "<script>alert('您輸入的e-mail不正確,請重新輸入..');</script>");
                return;
            }
            #endregion



            //填寫人資料=======================================================================================      
            string sNotMemberGUID = Guid.NewGuid().ToString().Trim();
            string sIQRecMGUID = Session["115_SC_IQRecMGUID"].ToString().Trim();
            string sCName = txtCName.Text;
            string sGender = rbtnGender.SelectedValue;
            DateTime sBirthday = dt;
            string sCareerNo = Public.strP_ShopNo;
            string sEmail = txtEmail.Text.Trim();

            #region 寫入非會員資料SC_NotMemberData(NotMemberGUID, IQRecMGUID, sCName, sGender, sBirthday, sCareerNo, sEmail)
            bool blReturn = true;
            blReturn = _blSuggestCard.InsertSC_NotMemberData(sNotMemberGUID, sIQRecMGUID, sCName, sGender, sBirthday, sCareerNo, sEmail);
            if (!blReturn)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                return;
            }
            #endregion

            #region 修改會員資料IQMainData(IQRecMGUID, Email)
            bool blReturn2 = true;
            blReturn2 = _blSuggestCard.UpdSC_IQMainData(Session["115_SC_IQRecMGUID"].ToString().Trim(), txtEmail.Text.Trim());
            if (!blReturn2)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                return;
            }
            #endregion



            //update 性別、年齡===================================================================================
            RadioButtonList rblQ9 = new RadioButtonList();
            RadioButtonList rblQ10 = new RadioButtonList();
            sError = BindQ9andQ10(rbtnGender.SelectedItem.Text.Trim(), dt.ToString("yyyy/MM/dd"), ref rblQ9, ref rblQ10);
            if (sError != "")
            {
                sError = "修改失敗!!請洽系統管理員~";
                return;
            }

            #region 修改RecAns_Sex
            //Q9----------------------------------------------------------------------------------
            string sAnsCode = "";
            DataRow[] rowA9 = (DataRow[])Session["115_SC_Q9_Sex"];
            for (int iQ9 = 0; iQ9 < rblQ9.Items.Count; iQ9++)
            {
                if (rblQ9.Items[iQ9].Selected)
                {
                    for (int iA9 = 0; iA9 < rowA9.Length; iA9++)
                    {
                        if (rowA9[iA9]["AnsGUID"].ToString() == rblQ9.Items[iQ9].Value.ToString())
                            sAnsCode = rowA9[iA9]["AnsCode"].ToString().Trim();
                    }

                    #region 修改RecAns
                    string sRecAnsGUID = Session["115_RecAnsGUID_Q9_Sex"].ToString();
                    string sAnsGUIDGroup = rblQ9.Items[iQ9].Value.Trim();
                    string sAnsCodeGroup = sAnsCode;
                    bool blReturn3 = true;
                    blReturn3 = _blSuggestCard.UpdSC_RecAns2Par(sRecAnsGUID, sAnsGUIDGroup, sAnsCodeGroup);
                    if (!blReturn3)
                    {
                        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                        return;
                    }
                    #endregion
                }
            }
            #endregion
            #region 修改RecAns_Age
            //Q10------------------------------------------------------------------------------------------
            sAnsCode = "";
            DataRow[] rowA10 = (DataRow[])Session["115_SC_Q10_Age"];
            for (int iQ10 = 0; iQ10 < rblQ10.Items.Count; iQ10++)
            {
                if (rblQ10.Items[iQ10].Selected)
                {
                    for (int iA10 = 0; iA10 < rowA10.Length; iA10++)
                    {
                        if (rowA10[iA10]["AnsGUID"].ToString() == rblQ10.Items[iQ10].Value.ToString())
                            sAnsCode = rowA10[iA10]["AnsCode"].ToString().Trim();
                    }

                    #region 修改RecAns
                    string sRecAnsGUID = Session["115_RecAnsGUID_Q10_Age"].ToString();
                    string sAnsGUIDGroup = rblQ10.Items[iQ10].Value.Trim();
                    string sAnsCodeGroup = sAnsCode;
                    bool blReturn3 = true;
                    blReturn3 = _blSuggestCard.UpdSC_RecAns2Par(sRecAnsGUID, sAnsGUIDGroup, sAnsCodeGroup);
                    if (!blReturn3)
                    {
                        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('修改失敗!!請洽系統管理員~');</script>");
                        return;
                    }
                    #endregion
                }
            }

            #endregion

        }






        Session.Remove("QAStep");
        Session["QAStep"] = "survey_nonlog.aspx";

        //轉換下一頁
        Response.Redirect("survey_ok.aspx");
    }



    private string BindQ9andQ10(string sTSex, string sTBirt, ref RadioButtonList rblQ9, ref RadioButtonList rblQ10)
    {
        string sError = "";
        try
        {
            if (Session["115_SC_Q9_Sex"] != null)
            {
                DataRow[] rowA9 = (DataRow[])Session["115_SC_Q9_Sex"];
                rblQ9 = new RadioButtonList();

                rblQ9.Items.Clear();
                for (int i9 = 0; i9 < rowA9.Length; i9++)
                {
                    string sName = rowA9[i9]["AnsName"].ToString().Trim();
                    string sGUID = rowA9[i9]["AnsGUID"].ToString().Trim();
                    rblQ9.Items.Insert(i9, new ListItem(sName, sGUID));
                }
                rblQ9.SelectedIndex = 0;

                if (sTSex != "")
                {
                    string sSex = sTSex;
                    if (sSex == "")
                        rblQ9.SelectedIndex = 0;
                    else
                    {
                        for (int iQ9 = 0; iQ9 < rblQ9.Items.Count; iQ9++)
                        {
                            if (rblQ9.Items[iQ9].Text == sSex)
                                rblQ9.SelectedIndex = iQ9;
                        }
                    }
                }
            }
            if (Session["115_SC_Q10_Age"] != null)
            {
                DataRow[] rowA10 = (DataRow[])Session["115_SC_Q10_Age"];
                rblQ10 = new RadioButtonList();
                rblQ10.Items.Clear();
                for (int i10 = 0; i10 < rowA10.Length; i10++)
                {
                    string sName = rowA10[i10]["AnsName"].ToString().Trim();
                    string sGUID = rowA10[i10]["AnsGUID"].ToString().Trim();
                    rblQ10.Items.Insert(i10, new ListItem(sName, sGUID));
                }
                rblQ10.SelectedIndex = 0;

                if (sTBirt != "")
                {
                    string sBir = sTBirt.Trim();
                    if (sBir == "")
                        rblQ10.SelectedIndex = 0;
                    else
                    {
                        int iBir = DateTime.Now.Year - DateTime.Parse(sBir.Trim()).Year;
                        rblQ10.SelectedIndex = 1;

                        for (int iQ10 = 1; iQ10 < rblQ10.Items.Count; iQ10++)
                        {
                            int iBirText = 0;
                            if (rblQ10.Items[iQ10].Text.Length >= 2)
                            {
                                iBirText = int.Parse(rblQ10.Items[iQ10].Text.Substring(0, 2));

                            }

                            if (iBir >= iBirText)
                            {
                                rblQ10.SelectedIndex = iQ10;
                            }
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            sError = ex.ToString();
        }
        return sError;
    }

}
