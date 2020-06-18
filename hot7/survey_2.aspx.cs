using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class survey_2 : System.Web.UI.Page
{
    #region 共用參數
    blSuggestCard _blSuggestCard = new blSuggestCard();
    Tools _Tools = new Tools();//小工具
    string sError = "";

    int aCoont_unLike = 1;
    int aCoont_Like = 1;
    int aCoont = 1;//增加意見欄位計數
    #endregion




    protected void Page_Load(object sender, EventArgs e)
    {
        Page.MaintainScrollPositionOnPostBack = true;

        //當網頁載入時從HiddenField中讀取值(意見欄位計數) 
        /*
        if (coontGV_Like.Value != "")
        {
            aCoont_Like = Convert.ToInt32(coontGV_Like.Value);
        }
        if (coontGV_unLike.Value != "")
        {
            aCoont_unLike = Convert.ToInt32(coontGV_unLike.Value);
        }
        if (coontGV.Value != "")
        {
            aCoont = Convert.ToInt32(coontGV.Value);
        }
         * */

        if (!IsPostBack)
        {
            //順序驗證
            if (Request["115_SC_IQType"] != null)
            {
                lbl115_SC_IQType.Text = Request["115_SC_IQType"].ToString().Trim();
            }
            if (Session["QAStep"] == null || Session["QAStep"].ToString() != "survey_1.aspx")
            {
                Response.Redirect("survey_1.aspx");
            }

            //2015/09/08          
            BindQuestion();//載入滿意度問卷內容


            /**
            //載入喜歡的三道
            DataTable dt_Like = new DataTable();
            DoGridViewDataBind_Like(true, dt_Like);

            //載入不喜歡的三道
            DataTable dt_unLike = new DataTable();
            DoGridViewDataBind_unLike(true, dt_unLike);
            */

            //載入其他意見
            DataTable dt = new DataTable();
            DoGridViewDataBind(true, dt);

            //會不會介紹原因預設上鎖
            //if (rblQ8.SelectedIndex < 0)//未選擇
            //{
            //    chkQ12.Enabled = false;
            //}
             
        }
    }


    /***************************************************************************************************************************************/
    #region <<建議卡Q1~Q11題目>>

    #region 載入滿意度問卷內容BindQuestion(Q1~Q11)
    private void BindQuestion()
    {
        DataTable DTStept2M = new DataTable();
        DTStept2M = (DataTable)Session["115_SC_MainData"];
        if (DTStept2M.Rows.Count <= 0) return;

        lblMainDataGUID.Text = DTStept2M.Rows[0]["MainDataGUID"].ToString();      //457133f5-25d2-416d-888b-41676fa497dc
        lblVersionID.Text = DTStept2M.Rows[0]["VersionID"].ToString().Trim();     //11500201510-001
        lblVersionName.Text = DTStept2M.Rows[0]["VersionName"].ToString().Trim(); //套餐
        //撈題目
        DataTable DTQ = new DataTable();
        DTQ = _blSuggestCard.BindSC_Question(lblMainDataGUID.Text.Trim(), out sError);

        DataRow rowQ1 = DTQ.Select("QuestionOrder=1")[0];  //[是否第一次]
        DataRow rowQ2 = DTQ.Select("QuestionOrder=2")[0];  //[半年幾次]  
        DataRow rowQ3 = DTQ.Select("QuestionOrder=3")[0];  //[如何知道]
        //DataRow rowQ4 = DTQ.Select("QuestionOrder=4")[0];//[目的]
        DataRow rowQ5 = DTQ.Select("QuestionOrder=5")[0];  //[主餐]
        DataRow rowQ6 = DTQ.Select("QuestionOrder=6")[0];  //[滿意~不滿意]
        DataRow rowQ7 = DTQ.Select("QuestionOrder=7")[0];  //[兩樣特色]
        DataRow rowQ8 = DTQ.Select("QuestionOrder=8")[0];  //[會不會]
        DataRow rowQ9 = DTQ.Select("QuestionOrder=9")[0];  //[姓別]
        DataRow rowQ10 = DTQ.Select("QuestionOrder=10")[0];//[消費時間]
        DataRow rowQ11 = DTQ.Select("QuestionOrder=11")[0];//[年齡]
        //DataRow rowQ12 = DTQ.Select("QuestionOrder=12")[0];//[特殊題]

        lblQ1.Text = rowQ1["QuestionGUID"].ToString();  //是否第一次 a2435072-46cc-4571-a004-698cf56770fb
        lblQ2.Text = rowQ2["QuestionGUID"].ToString();  //半年幾次   e4581a31-082c-42ac-92cf-f25b97d363e1
        lblQ3.Text = rowQ3["QuestionGUID"].ToString();  //如何知道  
        //lblQ4.Text = rowQ4["QuestionGUID"].ToString();//目的 
        lblQ5.Text = rowQ5["QuestionGUID"].ToString();  //
        lblQ6.Text = rowQ6["QuestionGUID"].ToString();  //         
        lblQ7.Text = rowQ7["QuestionGUID"].ToString();  //兩樣特色  
        lblQ8.Text = rowQ8["QuestionGUID"].ToString();  //會不會    
        if (rowQ9 != null)
            lblQ9.Text = rowQ9["QuestionGUID"].ToString();      
        if (rowQ10 != null)
            lblQ10.Text = rowQ10["QuestionGUID"].ToString();   
        if (rowQ11 != null)
            lblQ11.Text = rowQ11["QuestionGUID"].ToString();    
        //lblQ12.Text = rowQ12["QuestionGUID"].ToString();       

        //撈答案
        DataTable DTA = new DataTable();
        Session["115_SC_Ans"] = _blSuggestCard.BindSC_Ans(lblMainDataGUID.Text.Trim(), out sError);
        DTA = (DataTable)Session["115_SC_Ans"];

        //題目-------------------------------------------------------------------------------------

        #region OK===================1題是否第一次來店=======================================
        DataRow[] rowA1 = DTA.Select("QuestionGUID='" + lblQ1.Text.Trim() + "'", "AnsOrder");
        rblQ1.Items.Clear();
        for (int i1 = 0; i1 < rowA1.Length; i1++)
        {
            string sName = rowA1[i1]["AnsName"].ToString().Trim();
            string sGUID = rowA1[i1]["AnsGUID"].ToString().Trim();
            if (i1 == 0)
                sName = sName + "(請跳到第3題)";


            rblQ1.Items.Insert(i1, new ListItem(sName, sGUID));
        }

        rblQ1.Items.Clear();
        for (int j1 = 0; j1 < rowA1.Length; j1++)
        {
            string sName = rowA1[j1]["AnsName"].ToString().Trim();
            string sGUID = rowA1[j1]["AnsGUID"].ToString().Trim();
            if (j1 == 0)
                sName = sName + "(請跳到第3題)";
            rblQ1.Items.Insert(j1, new ListItem(sName, sGUID));
        }
        #endregion

        #region OK===================2題用餐次數=============================================
        DataRow[] rowA2 = DTA.Select("QuestionGUID='" + lblQ2.Text.Trim() + "'", "AnsOrder");
        drpQ2.Items.Clear();

        for (int i2 = 0; i2 < rowA2.Length; i2++)
        {
            string sName = rowA2[i2]["AnsName"].ToString().Trim();
            string sGUID = rowA2[i2]["AnsGUID"].ToString().Trim();
            drpQ2.Items.Insert(i2, new ListItem(sName, sGUID));
        }
        drpQ2.Items.Insert(0, new ListItem("請選擇", ""));
        #endregion

        #region OK===================3題消息來源=============================================
        DataRow[] rowA3 = DTA.Select("QuestionGUID='" + lblQ3.Text.Trim() + "'", "AnsOrder");
        chkQ3.Items.Clear();
        for (int i3 = 0; i3 < rowA3.Length; i3++)
        {
            string sName = rowA3[i3]["AnsName"].ToString().Trim();
            string sGUID = rowA3[i3]["AnsGUID"].ToString().Trim();
            chkQ3.Items.Insert(i3, new ListItem(sName, sGUID));
        }
        #endregion

        #region OK===================4目的===================================================
        /*
        DataRow[] rowA4 = DTA.Select("QuestionGUID='" + lblQ4.Text.Trim() + "'", "AnsOrder");
        rblQ4.Items.Clear();
        for (int i4 = 0; i4 < rowA4.Length; i4++)
        {
            string sName = rowA4[i4]["AnsName"].ToString().Trim();
            string sGUID = rowA4[i4]["AnsGUID"].ToString().Trim();
            rblQ4.Items.Insert(i4, new ListItem(sName, sGUID));
        }
         * */
        #endregion


        #region ===================5題主餐=================================================        
        DataRow[] rowA5 = DTA.Select("QuestionGUID='" + lblQ5.Text.Trim() + "'", "AnsOrder");
        drpQ5.Items.Clear();
        for (int i5 = 0; i5 < rowA5.Length; i5++)
        {
            string sName = rowA5[i5]["AnsName"].ToString().Trim();
            string sGUID = rowA5[i5]["AnsGUID"].ToString().Trim();
            drpQ5.Items.Insert(i5, new ListItem(sName, sGUID));
        }
        drpQ5.Items.Insert(0, new ListItem("請選擇", ""));  
        #endregion

        #region OK===================6題滿意度===============================================
        // DataRow[] rowA6 = DTA.Select("QuestionGUID='" + lblQ6.Text.Trim() + "'", "AnsOrder");
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSC_Satisfaction(lblMainDataGUID.Text.Trim(), out sError);

        grdQ6.DataKeyNames = new string[] { "AnsGUID", "AnsName", "AnsOrder", "AnsLocal", "SatisfactionY0" };
        grdQ6.DataSource = DTS;
        grdQ6.DataBind();

        for (int i = 0; i < grdQ6.Rows.Count; i++)
        {
            ((DropDownList)(grdQ6.Rows[i].FindControl("drpQ6"))).Items.Insert(0, new ListItem("請選擇", ""));
            for (int d = 0; d <= 5; d++)
            {
                string SatisfactionName = DTS.Rows[i]["SatisfactionName" + d].ToString();
                string SatisfactionGUID = DTS.Rows[i]["SatisfactionGUID" + d].ToString();
                string code = DTS.Rows[i]["SatisfactionCode" + d].ToString();
                //20150819新增如果是單選主餐就要新增，不是就不新增無的答案
                if (code != "")
                    ((DropDownList)(grdQ6.Rows[i].FindControl("drpQ6"))).Items.Insert(int.Parse(code), new ListItem(SatisfactionName, SatisfactionGUID));

            }
        }
        Session["115_SC_Q6_List"] = DTS;
        #endregion

        #region OK===================7題兩項特色==============================================
        DataRow[] rowA7 = DTA.Select("QuestionGUID='" + lblQ7.Text.Trim() + "'", "AnsOrder");
        chkQ7.Items.Clear();
        for (int i7 = 0; i7 < rowA7.Length; i7++)
        {
            string sName = rowA7[i7]["AnsName"].ToString().Trim();
            string sGUID = rowA7[i7]["AnsGUID"].ToString().Trim();
            chkQ7.Items.Insert(i7, new ListItem(sName, sGUID));
        }
        #endregion

        #region OK===================8題會不會介紹===========================================
        DataRow[] rowA8 = DTA.Select("QuestionGUID='" + lblQ8.Text.Trim() + "' AND AnsOrder<>0", "AnsOrder ");
        rblQ8.Items.Clear();
        for (int i8 = 0; i8 < rowA8.Length; i8++)
        {
            string sName = rowA8[i8]["AnsName"].ToString().Trim();
            string sGUID = rowA8[i8]["AnsGUID"].ToString().Trim();
            rblQ8.Items.Insert(i8, new ListItem(sName, sGUID));
        }
        #endregion

        #region OK===================12題不會介紹的原因=======================================
        /*
        DataRow[] rowA12 = DTA.Select("QuestionGUID='" + lblQ12.Text.Trim() + "'", "AnsOrder");
        chkQ12.Items.Clear();
        for (int i12 = 0; i12 < rowA12.Length; i12++)
        {
            string sName = rowA12[i12]["AnsName"].ToString().Trim();
            string sGUID = rowA12[i12]["AnsGUID"].ToString().Trim();
            chkQ12.Items.Insert(i12, new ListItem(sName, sGUID));
        }
         * */
        #endregion


        //其他項目----------------------------------------------------------------------------------

        #region OK===================9題性別=================================================
        //0無 1男 2女      
        if (lblQ9.Text.Trim() != "")
        {
            DataRow[] rowA9 = DTA.Select("QuestionGUID='" + lblQ9.Text.Trim() + "' ", "AnsOrder");
            rblQ9.Items.Clear();
            for (int i9 = 0; i9 < rowA9.Length; i9++)
            {
                string sName = rowA9[i9]["AnsName"].ToString().Trim();
                string sGUID = rowA9[i9]["AnsGUID"].ToString().Trim();
                rblQ9.Items.Insert(i9, new ListItem(sName, sGUID));
            }
            rblQ9.SelectedIndex = 0;
            Session["115_SC_Q9_Sex"] = rowA9;
        }
        #endregion

        #region OK===================10題年齡================================================
        //0無(預設)       
        if (lblQ10.Text.Trim() != "")
        {
            DataRow[] rowA10 = DTA.Select("QuestionGUID='" + lblQ10.Text.Trim() + "'", "AnsOrder");
            rblQ10.Items.Clear();
            for (int i10 = 0; i10 < rowA10.Length; i10++)
            {
                string sName = rowA10[i10]["AnsName"].ToString().Trim();
                string sGUID = rowA10[i10]["AnsGUID"].ToString().Trim();
                rblQ10.Items.Insert(i10, new ListItem(sName, sGUID));
            }
            rblQ10.SelectedIndex = 0;

            Session["115_SC_Q10_Age"] = rowA10;
        }
        #endregion

        #region OK===================11題消費時間============================================
        DataRow[] rowA11 = DTA.Select("QuestionGUID='" + lblQ11.Text.Trim() + "'", "AnsOrder");
        drpQ11.Items.Clear();

        for (int i11 = 0; i11 < rowA11.Length; i11++)
        {
            string sName = rowA11[i11]["AnsName"].ToString().Trim();
            string sGUID = rowA11[i11]["AnsGUID"].ToString().Trim();
            drpQ11.Items.Insert(i11, new ListItem(sName, sGUID));
        }

        if (Session["115_SC_eatTime"] != null)
        {
            int iTime = int.Parse(Session["115_SC_eatTime"].ToString().Trim());
            if (drpQ11.Items.Count > iTime - 1)
                drpQ11.SelectedIndex = iTime - 1;
        }
        #endregion
    }

    #endregion

    //Q1:是否第一次來店(是，鎖第二個問題)
    protected void rblQ1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rblQ1.SelectedIndex == 0)
        {
            drpQ2.SelectedIndex = 1;
            drpQ2.Enabled = false;
        }
        else
        {
            drpQ2.Enabled = true;
        }
    }

    //Q7:兩樣特色(限填兩項)
    protected void chkQ7_SelectedIndexChanged(object sender, EventArgs e)
    {
        int j = 0;
        for (int i = 0; i < chkQ7.Items.Count; ++i)
        {
            if (chkQ7.Items[i].Selected)
            {
                j = j + 1;
            }
        }

        lblAlertQ7.Visible = false;

        if (j > 2)
        {
            lblAlertQ7.Visible = true;
        }
    }

    //Q6:表格顏色
    protected void grdQ6_RowDataBound1(object sender, GridViewRowEventArgs e)
    {
        //if (e.Row.RowType == DataControlRowType.DataRow)
        //{
        //    if (e.Row.RowIndex % 2 == 0)

        //        e.Row.BackColor = System.Drawing.Color.LightGray;
        //}
    }

    //Q8:是否會介紹(否，鎖第12個問題)
    protected void rblQ8_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*
        if (rblQ8.SelectedIndex == 0)//會-----------
        {
            chkQ12.Enabled = false;
            chkQ12.SelectedIndex = -1;
        }
        else//不會----------------------------------
        {
            chkQ12.Enabled = true;
        }
         * */
    }

    //Q12:不願介紹的原因(限填兩項)
    protected void chkQ12_SelectedIndexChanged(object sender, EventArgs e)
    {
        /*
        int j = 0;
        for (int i = 0; i < chkQ12.Items.Count; ++i)
        {
            if (chkQ12.Items[i].Selected)
            {
                j = j + 1;
            }
        }

        lblAlertQ12.Visible = false;

        if (j > 2)
        {
            lblAlertQ12.Visible = true;
        }
         * */
    }

    #endregion


    /***************************************************************************************************************************************/
   
    /*
    #region <<最喜歡三道>>

    #region 最喜歡三道(下拉選單分類)DoGridViewDataBind_Like=======================================================
    public void DoGridViewDataBind_Like(bool blAdd, DataTable dtSession)
    {
        int nRows = 1;

        // 新增行數
        if (blAdd == true)
        {
            nRows = grdAnalysisData_Like.Rows.Count + 1;
        }

        DataTable dt_Like = new DataTable();
        dt_Like = dtSession;
        if (dt_Like.Rows.Count <= 0)
        {
            dt_Like.Columns.Add("sDOGUID_Like", System.Type.GetType("System.String"));
            dt_Like.Columns.Add("sSugType_Like", System.Type.GetType("System.String"));
            dt_Like.Columns.Add("sAnalysisMain_Like", System.Type.GetType("System.String"));
            dt_Like.Columns.Add("iOrder_Like", typeof(int));
        }


        int nRowCount = 1;
        int Rows = (nRows > nRowCount) ? nRows : nRowCount;

        //for (int i = 0; i < Rows; i++)
        //{
        DataRow dr = dt_Like.NewRow();
        dr["sDOGUID_Like"] = _Tools.CreateGUID(20);
        dr["sSugType_Like"] = "";
        dr["sAnalysisMain_Like"] = "";
        dr["iOrder_Like"] = 99 + nRows;
        dt_Like.Rows.Add(dr);
        //}

        grdAnalysisData_Like.DataSource = dt_Like;
        grdAnalysisData_Like.DataBind();
    }
    #endregion

    //最喜歡三道(下拉選單分類):選擇類別
    protected void drpSugType_SelectedIndexChanged_Like(object sender, EventArgs e)
    {
        GridViewRow row = (GridViewRow)((DropDownList)sender).NamingContainer;
        DropDownList drpSugType_Like = ((DropDownList)row.FindControl("drpSugType_Like"));
        DropDownList drpAnalysisMain_Like = ((DropDownList)row.FindControl("drpAnalysisMain_Like"));
        BindSSF_AnalysisDetail(drpAnalysisMain_Like, drpSugType_Like.SelectedValue.Trim());
    }

    //最喜歡三道(下拉選單分類):產生項目菜色的dropdownlist
    protected void grdAnalysisData_RowDataBound_Like(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)//不是在畫表頭跟表尾
        {

            GridViewRow row = (GridViewRow)e.Row;
            DropDownList drpSugType_Like = ((DropDownList)row.FindControl("drpSugType_Like"));
            DropDownList drpAnalysisMain_Like = ((DropDownList)row.FindControl("drpAnalysisMain_Like"));

            HiddenField hidSugType_Like = ((HiddenField)row.FindControl("hidSugType_Like"));
            HiddenField hidAnalysisMain_Like = ((HiddenField)row.FindControl("hidAnalysisMain_Like"));


            //項目-----------------------------------------------------------------------
            BindSSF_AnalysisMain_Like(drpSugType_Like);
            if (hidSugType_Like.Value != "")//SETVALUE
                drpSugType_Like.SelectedValue = hidSugType_Like.Value;

            //菜色-----------------------------------------------------------------------
            BindSSF_AnalysisDetail_Like(drpAnalysisMain_Like, drpSugType_Like.SelectedValue.Trim());
            if (hidAnalysisMain_Like.Value != "")//SETVALUE
                drpAnalysisMain_Like.SelectedValue = hidAnalysisMain_Like.Value;
        }
    }



    #region 最喜歡三道:項目
    private void BindSSF_AnalysisMain_Like(DropDownList drpSugType_Like)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_AnalysisMain_onFood(Public.strP_ShopNo, out sError);
        drpSugType_Like.Items.Clear();
        if (DTS.Rows.Count < 0)
        {
            drpSugType_Like.Items.Insert(0, new ListItem("項目", ""));
            return;
        }
        drpSugType_Like.DataSource = DTS;
        drpSugType_Like.DataTextField = "AnalyMName";
        drpSugType_Like.DataValueField = "AnalyMGUID";
        drpSugType_Like.DataBind();
        drpSugType_Like.Items.Insert(0, new ListItem("項目", ""));
    }
    #endregion

    #region 最喜歡三道:菜色
    private void BindSSF_AnalysisDetail_Like(DropDownList drpAnalysisMain_Like, string sAnalyMGUID)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_AnalysisDetail(sAnalyMGUID, lblVersionID.Text.Substring(12, 3), out sError);
        drpAnalysisMain_Like.Items.Clear();
        if (DTS.Rows.Count <= 0)
        {
            drpAnalysisMain_Like.Items.Insert(0, new ListItem("菜色", ""));
            return;
        }

        drpAnalysisMain_Like.DataSource = DTS;
        drpAnalysisMain_Like.DataTextField = "AnalyDName";
        drpAnalysisMain_Like.DataValueField = "AnalyDGUID";
        drpAnalysisMain_Like.DataBind();
        drpAnalysisMain_Like.Items.Insert(0, new ListItem("菜色", ""));
    }
    #endregion



    //[按鈕]新增一筆最喜歡三道
    protected void LinkButton_AddRow_Click_Like(Object sender, EventArgs e)
    {
        aCoont_Like = aCoont_Like + 1;
        coontGV_Like.Value = Convert.ToString(aCoont_Like);//將累計過的值寫回HiddenField中 

        if (aCoont_Like <= 3)
        {
            //Session["SugTable"] = "";
            DataTable dt_Like = new DataTable();
            //DataBind
            dt_Like = AddSessionTable_Like();
            DoGridViewDataBind_Like(true, dt_Like);
        }
    }



    //先把資料存在暫存記憶體內
    private DataTable AddSessionTable_Like()
    {
        //新增一個talbe
        string sDOGUID_Like = "";
        string txtsugcate_Like = "";
        string txtAnalysisMain_Like = "";
        DataTable dt_Like = new DataTable();

        dt_Like.Columns.Add("sDOGUID_Like", System.Type.GetType("System.String"));
        dt_Like.Columns.Add("sSugType_Like", System.Type.GetType("System.String"));
        dt_Like.Columns.Add("sAnalysisMain_Like", System.Type.GetType("System.String"));
        dt_Like.Columns.Add("iOrder_Like", typeof(int));

        for (int iga = 0; iga < grdAnalysisData_Like.Rows.Count; iga++)
        {
            HiddenField hidDOGUID_Like = ((HiddenField)grdAnalysisData_Like.Rows[iga].FindControl("hidDOGUID_Like"));
            DropDownList drpSugType_Like = ((DropDownList)grdAnalysisData_Like.Rows[iga].FindControl("drpSugType_Like"));
            DropDownList drpAnalysisMain_Like = ((DropDownList)grdAnalysisData_Like.Rows[iga].FindControl("drpAnalysisMain_Like"));

            //有寫意見或只有選擇意見內容

            sDOGUID_Like = hidDOGUID_Like.Value.Trim();
            txtsugcate_Like = drpSugType_Like.SelectedValue.Trim();
            txtAnalysisMain_Like = drpAnalysisMain_Like.SelectedValue.Trim();

            //手填或手選其他意見儲存(不等於空的才新增)if (txtsug.Trim() != "" || txtAnalysisDetail != "")
            if (sDOGUID_Like.Trim() != "")
            {
                DataRow dr = dt_Like.NewRow();

                dr["sDOGUID_Like"] = sDOGUID_Like;
                dr["sSugType_Like"] = txtsugcate_Like;
                dr["sAnalysisMain_Like"] = txtAnalysisMain_Like;
                dr["iOrder_Like"] = iga;
                dt_Like.Rows.Add(dr);
            }

        }
        return dt_Like;

    }
    #endregion

    #region <<最不喜歡三道>>

    #region 最不喜歡三道(下拉選單分類)DoGridViewDataBind_unLike=======================================================
    public void DoGridViewDataBind_unLike(bool blAdd, DataTable dtSession)
    {
        int nRows = 1;

        // 新增行數
        if (blAdd == true)
        {
            nRows = grdAnalysisData_unLike.Rows.Count + 1;
        }

        DataTable dt_unLike = new DataTable();
        dt_unLike = dtSession;
        if (dt_unLike.Rows.Count <= 0)
        {
            dt_unLike.Columns.Add("sDOGUID_unLike", System.Type.GetType("System.String"));
            //dt_unLike.Columns.Add("sSugTypeM_unLike", System.Type.GetType("System.String"));
            dt_unLike.Columns.Add("sSugType_unLike", System.Type.GetType("System.String"));
            dt_unLike.Columns.Add("sAnalysisMain_unLike", System.Type.GetType("System.String"));
            //dt_unLike.Columns.Add("sAnalysisDetail_unLike", System.Type.GetType("System.String"));
            //dt_unLike.Columns.Add("sSugText_unLike", System.Type.GetType("System.String"));
            dt_unLike.Columns.Add("iOrder_unLike", typeof(int));
        }


        int nRowCount = 1;
        int Rows = (nRows > nRowCount) ? nRows : nRowCount;

        //for (int i = 0; i < Rows; i++)
        //{
        DataRow dr = dt_unLike.NewRow();
        dr["sDOGUID_unLike"] = _Tools.CreateGUID(20);
        //dr["sSugTypeM_unLike"] = "";
        dr["sSugType_unLike"] = "";
        dr["sAnalysisMain_unLike"] = "";
        //dr["sAnalysisDetail_unLike"] = "";
        //dr["sSugText_unLike"] = "限300字以內";
        dr["iOrder_unLike"] = 99 + nRows;
        dt_unLike.Rows.Add(dr);
        //}

        grdAnalysisData_unLike.DataSource = dt_unLike;
        grdAnalysisData_unLike.DataBind();
    }
    #endregion

    //最不喜歡三道(下拉選單分類):選擇類別
    protected void drpSugType_SelectedIndexChanged_unLike(object sender, EventArgs e)
    {
        GridViewRow row = (GridViewRow)((DropDownList)sender).NamingContainer;
        DropDownList drpSugType_unLike = ((DropDownList)row.FindControl("drpSugType_unLike"));
        DropDownList drpAnalysisMain_unLike = ((DropDownList)row.FindControl("drpAnalysisMain_unLike"));
        //DropDownList drpAnalysisDetail_unLike = ((DropDownList)row.FindControl("drpAnalysisDetail_unLike"));
        BindSSF_AnalysisDetail(drpAnalysisMain_unLike, drpSugType_unLike.SelectedValue.Trim());
        //drpAnalysisDetail_unLike.Items.Clear();
        //drpAnalysisDetail_unLike.Items.Insert(0, new ListItem("意見內容", ""));
    }

    //最不喜歡三道(下拉選單分類):選擇品項
    //protected void drpAnalysisMain_SelectedIndexChanged_unLike(object sender, EventArgs e)
    //{
    //    GridViewRow row = (GridViewRow)((DropDownList)sender).NamingContainer;
    //    DropDownList drpSugType_unLike        = ((DropDownList)row.FindControl("drpSugType_unLike"));
    //    DropDownList drpAnalysisDetail_unLike = ((DropDownList)row.FindControl("drpAnalysisDetail_unLike"));

    //    BindSSF_SuggestionDetail(drpAnalysisDetail_unLike, drpSugType_unLike.SelectedValue.Trim());
    //}

    //最不喜歡三道(下拉選單分類):產生意見類別、品項、內容的dropdownlist
    protected void grdAnalysisData_RowDataBound_unLike(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)//不是在畫表頭跟表尾
        {

            GridViewRow row = (GridViewRow)e.Row;
            //DropDownList drpSugTypeM_unLike = ((DropDownList)row.FindControl("drpSugTypeM_unLike"));
            DropDownList drpSugType_unLike = ((DropDownList)row.FindControl("drpSugType_unLike"));
            DropDownList drpAnalysisMain_unLike = ((DropDownList)row.FindControl("drpAnalysisMain_unLike"));
            //DropDownList drpAnalysisDetail_unLike = ((DropDownList)row.FindControl("drpAnalysisDetail_unLike"));

            HiddenField hidSugType_unLike = ((HiddenField)row.FindControl("hidSugType_unLike"));
            HiddenField hidAnalysisMain_unLike = ((HiddenField)row.FindControl("hidAnalysisMain_unLike"));
            //HiddenField hidAnalysisDetail_unLike = ((HiddenField)row.FindControl("hidAnalysisDetail_unLike"));

            //建議方向-------------------------------------------------------------------  
            //BindSuggestType(drpSugTypeM_unLike);

            //類別-----------------------------------------------------------------------
            BindSSF_AnalysisMain_unLike(drpSugType_unLike);
            if (hidSugType_unLike.Value != "")//SETVALUE
                drpSugType_unLike.SelectedValue = hidSugType_unLike.Value;

            //品項-----------------------------------------------------------------------
            BindSSF_AnalysisDetail_unLike(drpAnalysisMain_unLike, drpSugType_unLike.SelectedValue.Trim());
            if (hidAnalysisMain_unLike.Value != "")//SETVALUE
                drpAnalysisMain_unLike.SelectedValue = hidAnalysisMain_unLike.Value;

            //意見內容-------------------------------------------------------------------
            //BindSSF_SuggestionDetail(drpAnalysisDetail_unLike, drpSugType_unLike.SelectedValue.Trim());
            //if (hidAnalysisDetail_unLike.Value != "")//SETVALUE
            //    drpAnalysisDetail_unLike.SelectedValue = hidAnalysisDetail_unLike.Value;

        }
    }



    #region 最不喜歡三道:項目
    private void BindSSF_AnalysisMain_unLike(DropDownList drpSugType_unLike)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_AnalysisMain_onFood(Public.strP_ShopNo, out sError);
        drpSugType_unLike.Items.Clear();
        if (DTS.Rows.Count < 0)
        {
            drpSugType_unLike.Items.Insert(0, new ListItem("項目", ""));
            return;
        }
        drpSugType_unLike.DataSource = DTS;
        drpSugType_unLike.DataTextField = "AnalyMName";
        drpSugType_unLike.DataValueField = "AnalyMGUID";
        drpSugType_unLike.DataBind();
        drpSugType_unLike.Items.Insert(0, new ListItem("項目", ""));
    }
    #endregion

    #region 最不喜歡三道:菜色
    private void BindSSF_AnalysisDetail_unLike(DropDownList drpAnalysisMain_unLike, string sAnalyMGUID)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_AnalysisDetail(sAnalyMGUID, lblVersionID.Text.Substring(12, 3), out sError);
        drpAnalysisMain_unLike.Items.Clear();
        if (DTS.Rows.Count <= 0)
        {
            drpAnalysisMain_unLike.Items.Insert(0, new ListItem("菜色", ""));
            return;
        }

        drpAnalysisMain_unLike.DataSource = DTS;
        drpAnalysisMain_unLike.DataTextField = "AnalyDName";
        drpAnalysisMain_unLike.DataValueField = "AnalyDGUID";
        drpAnalysisMain_unLike.DataBind();
        drpAnalysisMain_unLike.Items.Insert(0, new ListItem("菜色", ""));
    }
    #endregion



    //[按鈕]新增一筆最不喜歡三道
    protected void LinkButton_AddRow_Click_unLike(Object sender, EventArgs e)
    {
        aCoont_unLike = aCoont_unLike + 1;
        coontGV_unLike.Value = Convert.ToString(aCoont_unLike);//將累計過的值寫回HiddenField中 

        if (aCoont_unLike <= 3)
        {
            //Session["SugTable"] = "";
            DataTable dt_unLike = new DataTable();
            //DataBind
            dt_unLike = AddSessionTable_unLike();
            DoGridViewDataBind_unLike(true, dt_unLike);
        }
    }



    //先把資料存在暫存記憶體內
    private DataTable AddSessionTable_unLike()
    {
        //新增一個talbe
        string sDOGUID_unLike = "";
        //string txtSugTypeM_unLike = "";
        string txtsugcate_unLike = "";
        string txtAnalysisMain_unLike = "";
        //string txtAnalysisDetail_unLike = "";
        //string txtsug_unLike = "";
        DataTable dt_unLike = new DataTable();

        dt_unLike.Columns.Add("sDOGUID_unLike", System.Type.GetType("System.String"));
        //dt_unLike.Columns.Add("sSugTypeM_unLike", System.Type.GetType("System.String"));
        dt_unLike.Columns.Add("sSugType_unLike", System.Type.GetType("System.String"));
        dt_unLike.Columns.Add("sAnalysisMain_unLike", System.Type.GetType("System.String"));
        //dt_unLike.Columns.Add("sAnalysisDetail_unLike", System.Type.GetType("System.String"));
        //dt_unLike.Columns.Add("sSugText_unLike", System.Type.GetType("System.String"));
        dt_unLike.Columns.Add("iOrder_unLike", typeof(int));

        for (int iga = 0; iga < grdAnalysisData_unLike.Rows.Count; iga++)
        {
            HiddenField hidDOGUID_unLike = ((HiddenField)grdAnalysisData_unLike.Rows[iga].FindControl("hidDOGUID_unLike"));
            //DropDownList drpSugTypeM_unLike = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpSugTypeM_unLike"));
            DropDownList drpSugType_unLike = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpSugType_unLike"));
            DropDownList drpAnalysisMain_unLike = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpAnalysisMain_unLike"));
            //DropDownList drpAnalysisDetail = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpAnalysisDetail_unLike"));
            //TextBox txtSuggestion = ((TextBox)grdAnalysisData_unLike.Rows[iga].FindControl("txtSuggestion_unLike"));

            //有寫意見或只有選擇意見內容

            sDOGUID_unLike = hidDOGUID_unLike.Value.Trim();
            //txtSugTypeM_unLike = drpSugTypeM_unLike.SelectedValue.Trim();
            txtsugcate_unLike = drpSugType_unLike.SelectedValue.Trim();
            txtAnalysisMain_unLike = drpAnalysisMain_unLike.SelectedValue.Trim();
            //txtAnalysisDetail_unLike = drpAnalysisDetail_unLike.SelectedValue.Trim();
            //txtsug_unLike = txtSuggestion_unLike.Text.Trim();

            //手填或手選其他意見儲存(不等於空的才新增)if (txtsug.Trim() != "" || txtAnalysisDetail != "")
            if (sDOGUID_unLike.Trim() != "")
            {
                DataRow dr = dt_unLike.NewRow();

                dr["sDOGUID_unLike"] = sDOGUID_unLike;
                //dr["sSugTypeM_unLike"] = txtSugTypeM_unLike;
                dr["sSugType_unLike"] = txtsugcate_unLike;
                dr["sAnalysisMain_unLike"] = txtAnalysisMain_unLike;
                //dr["sAnalysisDetail_unLike"] = txtAnalysisDetail_unLike;
                //dr["sSugText_unLike"] = txtsug_unLike.Trim();
                dr["iOrder_unLike"] = iga;
                dt_unLike.Rows.Add(dr);
            }

        }
        return dt_unLike;

    }
    #endregion

    * */



    #region <<其他意見>>

    #region 其他意見(下拉選單分類)DoGridViewDataBind=======================================================
    public void DoGridViewDataBind(bool blAdd, DataTable dtSession)
    {
        int nRows = 1;

        // 新增行數
        if (blAdd == true)
        {
            nRows = grdAnalysisData.Rows.Count + 1;
        }

        DataTable dt = new DataTable();
        dt = dtSession;
        if (dt.Rows.Count <= 0)
        {
            dt.Columns.Add("sDOGUID", System.Type.GetType("System.String"));
            dt.Columns.Add("sSugTypeM", System.Type.GetType("System.String"));
            dt.Columns.Add("sSugType", System.Type.GetType("System.String"));
            dt.Columns.Add("sAnalysisMain", System.Type.GetType("System.String"));
            dt.Columns.Add("sAnalysisDetail", System.Type.GetType("System.String"));
            dt.Columns.Add("sSugText", System.Type.GetType("System.String"));
            dt.Columns.Add("iOrder", typeof(int));
        }


        int nRowCount = 1;
        int Rows = (nRows > nRowCount) ? nRows : nRowCount;

        //for (int i = 0; i < Rows; i++)
        //{
        DataRow dr = dt.NewRow();
        dr["sDOGUID"] = _Tools.CreateGUID(20);
        dr["sSugTypeM"] = "";
        dr["sSugType"] = "";
        dr["sAnalysisMain"] = "";
        dr["sAnalysisDetail"] = "";
        dr["sSugText"] = "限300字以內";
        dr["iOrder"] = 99 + nRows;
        dt.Rows.Add(dr);
        //}

        grdAnalysisData.DataSource = dt;
        grdAnalysisData.DataBind();
    }
    #endregion

    //其他意見(下拉選單分類):選擇類別2015/08/26
    protected void drpSugType_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = (GridViewRow)((DropDownList)sender).NamingContainer;
        DropDownList drpSugType = ((DropDownList)row.FindControl("drpSugType"));
        DropDownList drpAnalysisMain = ((DropDownList)row.FindControl("drpAnalysisMain"));
        DropDownList drpAnalysisDetail = ((DropDownList)row.FindControl("drpAnalysisDetail"));
        BindSSF_AnalysisDetail(drpAnalysisMain, drpSugType.SelectedValue.Trim());
        drpAnalysisDetail.Items.Clear();
        drpAnalysisDetail.Items.Insert(0, new ListItem("意見內容", ""));
    }

    //其他意見(下拉選單分類):選擇品項2015/08/26 ex雪花牛肉、冬瓜茶
    protected void drpAnalysisMain_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridViewRow row = (GridViewRow)((DropDownList)sender).NamingContainer;
        DropDownList drpSugType = ((DropDownList)row.FindControl("drpSugType"));
        DropDownList drpAnalysisDetail = ((DropDownList)row.FindControl("drpAnalysisDetail"));

        BindSSF_SuggestionDetail(drpAnalysisDetail, drpSugType.SelectedValue.Trim());
    }

    //其他意見(下拉選單分類):產生意見類別、品項、內容的dropdownlist
    protected void grdAnalysisData_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)//不是在畫表頭跟表尾
        {

            GridViewRow row = (GridViewRow)e.Row;
            DropDownList drpSugTypeM = ((DropDownList)row.FindControl("drpSugTypeM"));
            DropDownList drpSugType = ((DropDownList)row.FindControl("drpSugType"));
            DropDownList drpAnalysisMain = ((DropDownList)row.FindControl("drpAnalysisMain"));
            DropDownList drpAnalysisDetail = ((DropDownList)row.FindControl("drpAnalysisDetail"));

            HiddenField hidSugType = ((HiddenField)row.FindControl("hidSugType"));
            HiddenField hidAnalysisMain = ((HiddenField)row.FindControl("hidAnalysisMain"));
            HiddenField hidAnalysisDetail = ((HiddenField)row.FindControl("hidAnalysisDetail"));

            //建議方向-------------------------------------------------------------------  
            BindSuggestType(drpSugTypeM);

            //類別-----------------------------------------------------------------------
            BindSSF_AnalysisMain(drpSugType);
            if (hidSugType.Value != "")//SETVALUE
                drpSugType.SelectedValue = hidSugType.Value;

            //品項-----------------------------------------------------------------------
            BindSSF_AnalysisDetail(drpAnalysisMain, drpSugType.SelectedValue.Trim());
            if (hidAnalysisMain.Value != "")//SETVALUE
                drpAnalysisMain.SelectedValue = hidAnalysisMain.Value;

            //意見內容-------------------------------------------------------------------
            BindSSF_SuggestionDetail(drpAnalysisDetail, drpSugType.SelectedValue.Trim());
            if (hidAnalysisDetail.Value != "")//SETVALUE
                drpAnalysisDetail.SelectedValue = hidAnalysisDetail.Value;

        }
    }

    #region 建議方向 BindSuggestType
    private void BindSuggestType(DropDownList drpSugTypeM)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_SuggestType(Public.strP_ShopNo, out sError);
        drpSugTypeM.Items.Clear();

        drpSugTypeM.DataSource = DTS;
        drpSugTypeM.DataTextField = "SugMName";
        drpSugTypeM.DataValueField = "SugMGUID";
        drpSugTypeM.DataBind();
    }
    #endregion

    #region 建議類別 BindSSF_AnalysisMain
    private void BindSSF_AnalysisMain(DropDownList drpSugType)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_AnalysisMain(Public.strP_ShopNo, out sError);
        drpSugType.Items.Clear();
        if (DTS.Rows.Count < 0)
        {
            drpSugType.Items.Insert(0, new ListItem("類別", ""));
            return;
        }
        drpSugType.DataSource = DTS;
        drpSugType.DataTextField = "AnalyMName";
        drpSugType.DataValueField = "AnalyMGUID";
        drpSugType.DataBind();
        drpSugType.Items.Insert(0, new ListItem("類別", ""));
    }
    #endregion

    #region 建議品項 BindSSF_AnalysisDetail
    private void BindSSF_AnalysisDetail(DropDownList drpAnalysisMain, string sAnalyMGUID)
    {
        DataTable DTS = new DataTable();
        DTS = _blSuggestCard.BindSSF_AnalysisDetail(sAnalyMGUID, lblVersionID.Text.Substring(12, 3), out sError);
        drpAnalysisMain.Items.Clear();
        if (DTS.Rows.Count <= 0)
        {
            drpAnalysisMain.Items.Insert(0, new ListItem("菜色", ""));//品項
            return;
        }

        drpAnalysisMain.DataSource = DTS;
        drpAnalysisMain.DataTextField = "AnalyDName";
        drpAnalysisMain.DataValueField = "AnalyDGUID";
        drpAnalysisMain.DataBind();
        drpAnalysisMain.Items.Insert(0, new ListItem("菜色", ""));//品項
    }
    #endregion

    #region 意見內容 BindSSF_SuggestionDetail
    /// <summary>
    /// 意見細項SSF_SuggestionDetail
    /// </summary>
    /// <param name="drpAnalysisDetail"></param>
    /// <param name="sAnalysisMain"></param>
    private void BindSSF_SuggestionDetail(DropDownList drpAnalysisDetail, string sAnalysisMain)
    {
        DataTable DTD = new DataTable();
        DTD = _blSuggestCard.BindSSF_SuggestionDetail(sAnalysisMain, lblVersionID.Text.ToString().Substring(12, 3), out sError);
        drpAnalysisDetail.Items.Clear();
        if (DTD.Rows.Count <= 0)
        {
            drpAnalysisDetail.Items.Insert(0, new ListItem("意見內容", ""));
            return;
        }
        drpAnalysisDetail.DataSource = DTD;
        drpAnalysisDetail.DataTextField = "SugDName";
        drpAnalysisDetail.DataValueField = "SugDGUID";
        drpAnalysisDetail.DataBind();
        drpAnalysisDetail.Items.Insert(0, new ListItem("意見內容", ""));
    }
    #endregion

    //[按鈕]新增一筆其他意見:2015/08/26
    protected void LinkButton_AddRow_Click(Object sender, EventArgs e)
    {
        aCoont = aCoont + 1;
        coontGV.Value = Convert.ToString(aCoont);//將累計過的值寫回HiddenField中 

        if (aCoont <= 10)
        {
            //Session["SugTable"] = "";
            DataTable dt = new DataTable();
            //DataBind
            dt = AddSessionTable();
            DoGridViewDataBind(true, dt);
        }
    }

    //先把資料存在暫存記憶體內
    private DataTable AddSessionTable()
    {
        //新增一個talbe
        string txtsugcate = "";
        string txtsug = "";
        string txtAnalysisMain = "";
        string txtAnalysisDetail = "";
        string txtSugTypeM = "";
        string sDOGUID = "";
        DataTable dt = new DataTable();
        dt.Columns.Add("sDOGUID", System.Type.GetType("System.String"));
        dt.Columns.Add("sSugTypeM", System.Type.GetType("System.String"));
        dt.Columns.Add("sSugType", System.Type.GetType("System.String"));
        dt.Columns.Add("sAnalysisMain", System.Type.GetType("System.String"));
        dt.Columns.Add("sAnalysisDetail", System.Type.GetType("System.String"));
        dt.Columns.Add("sSugText", System.Type.GetType("System.String"));
        dt.Columns.Add("iOrder", typeof(int));

        for (int iga = 0; iga < grdAnalysisData.Rows.Count; iga++)
        {
            HiddenField hidDOGUID = ((HiddenField)grdAnalysisData.Rows[iga].FindControl("hidDOGUID"));
            DropDownList drpSugTypeM = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpSugTypeM"));
            DropDownList drpSugType = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpSugType"));
            DropDownList drpAnalysisMain = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpAnalysisMain"));
            DropDownList drpAnalysisDetail = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpAnalysisDetail"));
            TextBox txtSuggestion = ((TextBox)grdAnalysisData.Rows[iga].FindControl("txtSuggestion"));

            //有寫意見或只有選擇意見內容
            sDOGUID = hidDOGUID.Value.Trim();
            txtSugTypeM = drpSugTypeM.SelectedValue.Trim();
            txtsugcate = drpSugType.SelectedValue.Trim();
            txtAnalysisMain = drpAnalysisMain.SelectedValue.Trim();
            txtAnalysisDetail = drpAnalysisDetail.SelectedValue.Trim();
            txtsug = txtSuggestion.Text.Trim();

            //手填或手選其他意見儲存(不等於空的才新增)
            if (txtsug.Trim() != "" || txtAnalysisDetail != "")
            {
                DataRow dr = dt.NewRow();
                dr["sDOGUID"] = sDOGUID;
                dr["sSugTypeM"] = txtSugTypeM;
                dr["sSugTypeM"] = txtSugTypeM;
                dr["sSugType"] = txtsugcate;
                dr["sAnalysisMain"] = txtAnalysisMain;
                dr["sAnalysisDetail"] = txtAnalysisDetail;
                dr["sSugText"] = txtsug.Trim();
                dr["iOrder"] = iga;
                dt.Rows.Add(dr);
            }
        }
        return dt;
    }

    #endregion














    /***************************************************************************************************************************************/
    #region 送出問券    抽獎
    protected void sendY_btn_Click1(object sender, EventArgs e)
    {
        if (Session["115_SC_Uid"] == null)
            Response.Redirect("survey_1.aspx.aspx");

        string sError = "";
        sError = QaCheck();
        if (sError != "")
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "Error", "alert('" + sError + "');", true);
            //Page.ClientScript.RegisterStartupScript(Page.GetType(), "Error", "alert('" + sError + "');", true);
            return;
        }

        QaStore();

        Session.Remove("QAStep");
        Session["QAStep"] = "survey_2.aspx";

        if (lbl115_SC_IQType.Text.Trim() != "")
            Response.Redirect("survey_login.aspx?115_SC_IQType=" + lbl115_SC_IQType.Text.ToString().Trim());
        else
            Response.Redirect("survey_login.aspx");

    }
    #endregion

    #region 送出問卷  不抽獎
    protected void sendN_btn_Click1(object sender, EventArgs e)
    {
        if (Session["115_SC_Uid"] == null)
            Response.Redirect("survey_1.aspx");

        string sError = "";
        sError = QaCheck();
        if (sError != "")
        {
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "Error", "alert('" + sError + "');", true);
            //Page.ClientScript.RegisterStartupScript(Page.GetType(), "Error", "alert('" + sError + "');", true);
            return;
        }

        QaStore();

        Session.Remove("QAStep");
        Session["QAStep"] = "survey_2.aspx";

        if (lbl115_SC_IQType.Text.Trim() != "")
            Response.Redirect("survey_nonlog.aspx?115_SC_IQType=" + lbl115_SC_IQType.Text.ToString().Trim());
        else
            Response.Redirect("survey_nonlog.aspx");
    }
    #endregion




    #region 判斷答案是否完整QaCheck()
    protected string QaCheck()
    {
        #region 1.是否第一次來店用餐===========================================================================================
        if (rblQ1.SelectedValue.Trim() == "")
        {
            return "您的『第一次到 hot 7 消費嗎?』未選擇,請重新填寫";
        }
        #endregion

        #region 2.來店次數=====================================================================================================
        if (drpQ2.SelectedValue.Trim() == "")
        {
            return "您的『請問您最近半年總共到 hot 7 用餐幾次?』未選擇,請重新填寫";
        }
        #endregion

        #region 3.如何知道本店=================================================================================================
        int iQ3 = 0;
        for (int i = 0; i < chkQ3.Items.Count; ++i)
        {
            if (chkQ3.Items[i].Selected)
            {
                iQ3 = iQ3 + 1;
            }
        }
        if (iQ3 == 0)
        {
            return "您的『請問您是如何知道本店?』未選擇,請重新填寫";
        }
        #endregion

        #region 4.用餐目的=====================================================================================================
        //if (rblQ4.SelectedValue.Trim() == "")
        //{
        //    return "您的『到 hot 7 用餐的目的』未選擇,請重新填寫";
        //}
        #endregion

        #region 5.主餐勾選=====================================================================================================
        if (drpQ5.SelectedIndex == 0)
        {
            return "您的『請問您個人點的餐點是?』未選擇,請重新填寫";
        }
        #endregion

        #region 6.用餐感覺=====================================================================================================
        bool bCheck = false;
        for (int i = 0; i < grdQ6.Rows.Count; i++)
        {
            bCheck = false;
            if (((DropDownList)(grdQ6.Rows[i].FindControl("drpQ6"))).SelectedValue.Trim() != "")
                bCheck = true;
            if (!bCheck)
            {
                return "您的『請問您對 hot 7 …』不完整,請重新填寫";
            }
        }
        #endregion

        #region 喜惡三道菜=====================================================================================================
        /*
        string txtsugcate_Like = "";
        string txtAnalysisMain_Like = "";
        for (int iga = 0; iga < grdAnalysisData_Like.Rows.Count; iga++)
        {
            DropDownList drpSugType_Like = ((DropDownList)grdAnalysisData_Like.Rows[iga].FindControl("drpSugType_Like"));
            DropDownList drpAnalysisMain_Like = ((DropDownList)grdAnalysisData_Like.Rows[iga].FindControl("drpAnalysisMain_Like"));

            //手填或手選其他意見儲存(不等於空的才新增)
            txtsugcate_Like = drpSugType_Like.SelectedValue.Trim();
            txtAnalysisMain_Like = drpAnalysisMain_Like.SelectedValue.Trim();

            if (txtsugcate_Like == "")
            {
                return "請選擇第6題最喜歡三道的『項目』,謝謝";
            }
            if (txtAnalysisMain_Like == "")
            {
                return "請選擇第6題最喜歡三道的『菜色』,謝謝";
            }
            if (txtAnalysisMain_Like == "")
            {
                txtsugcate_Like = "";
                txtAnalysisMain_Like = "";
            }
        }






        string txtsugcate_unLike = "";
        string txtAnalysisMain_unLike = "";
        for (int iga = 0; iga < grdAnalysisData_unLike.Rows.Count; iga++)
        {
            DropDownList drpSugType_unLike = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpSugType_unLike"));
            DropDownList drpAnalysisMain_unLike = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpAnalysisMain_unLike"));

            //手填或手選其他意見儲存(不等於空的才新增)
            txtsugcate_unLike = drpSugType_unLike.SelectedValue.Trim();
            txtAnalysisMain_unLike = drpAnalysisMain_unLike.SelectedValue.Trim();

            if (txtsugcate_unLike == "")
            {
                return "請選擇第6題最不喜歡三道的『項目』,謝謝";
            }
            if (txtAnalysisMain_unLike == "")
            {
                return "請選擇第6題最不喜歡三道的『菜色』,謝謝";
            }
            if (txtAnalysisMain_unLike == "")
            {
                txtsugcate_unLike = "";
                txtAnalysisMain_unLike = "";
            }
        }
         * */
        #endregion

        #region 7.兩項特色勾選=================================================================================================
        int iQ7 = 0;
        for (int i = 0; i < chkQ7.Items.Count; ++i)
        {
            if (chkQ7.Items[i].Selected)
            {
                iQ7 = iQ7 + 1;
            }
        }
        if (iQ7 > 2)
        {
            return "您的『 hot 7 最吸引人的特色已超過2項』,請重新填寫";
        }
        else if (iQ7 == 0)
        {
            return "您的『 hot 7 最吸引人的2項特色是?』未選擇,請重新填寫";
        }
        #endregion

        #region 8.會不會介紹===================================================================================================
        if (rblQ8.SelectedValue.Trim() == "")
        {
            return "您的『會不會介紹朋友來本店消費?』未選擇,請重新填寫";
        }
        #endregion

        #region 12.特殊調查====================================================================================================
        /*
        int iQ12 = 0;
        for (int i = 0; i < chkQ12.Items.Count; ++i)
        {
            if (chkQ12.Items[i].Selected)
            {
                iQ12 = iQ12 + 1;
            }
        }
        if (rblQ8.SelectedIndex != 0)//>>>>>>>第八題有勾選不會介紹
        {
            if (iQ12 > 2)
            {
                return "您的『 不願意介紹朋友的原因? 已超過2項 』,請重新填寫";
            }
            else if (iQ12 == 0)
            {
                return "您的『 不願意介紹朋友的原因? 』未選擇,請重新填寫";
            }
        }
         * */
        #endregion


        #region 其他意見
        //意見類別        
        string txtsugcate = "";
        string txtAnalysisMain = "";
        string txtsug = "";

        //檢查類別、意見品項
        for (int iga = 0; iga < grdAnalysisData.Rows.Count; iga++)
        {

            DropDownList drpSugType = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpSugType"));
            DropDownList drpAnalysisMain = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpAnalysisMain"));
            TextBox txtSuggestion = ((TextBox)grdAnalysisData.Rows[iga].FindControl("txtSuggestion"));

            //手填或手選其他意見儲存(不等於空的才新增)
            txtsugcate = drpSugType.SelectedValue.Trim();
            txtAnalysisMain = drpAnalysisMain.SelectedValue.Trim();
            txtsug = txtSuggestion.Text.Trim().Replace("限300字以內", "");

            if (txtsug.Trim() != "")
            {
                if (txtsug != "" && txtsugcate == "")
                {
                    return "請選擇第10題的『建議方向』,謝謝";

                }
                if (txtsug != "" && txtsugcate != "" && txtAnalysisMain == "")
                {
                    return "請選擇第10題的『類別』,謝謝";
                }
                if (txtsug.Length > 300)
                {
                    return "建議限300字以內";
                }
                if (txtsug == "")
                {
                    txtsug = "";
                    txtsugcate = "";
                    txtAnalysisMain = "";
                }
            }
        }
        #endregion
        return "";
    }


    #endregion

    #region 儲存答案:QaStore()
    private void QaStore()
    {
        //版本----------------------------------------------------------------------
        string sMainDataGUID = lblMainDataGUID.Text.Trim(); //GUID=e811c98b-8bc6-4b2c-9b16-3a9c8a0682fa     
        string sVersionID = lblVersionID.Text.Trim();       //ID=11500201510-001
        string sVersionName = lblVersionName.Text.Trim();   //Name=單點

        //第一頁資訊----------------------------------------------------------------
        string sExpendDate = Session["115_SC_eatDate"].ToString().Trim(); //日期
        string sEatTime = drpQ11.SelectedItem.Text.Trim(); // Session["115_SC_eatTime"].ToString().Trim(); //時間=1
        string sStoreNo = Session["115_SC_Store"].ToString().Trim();   //店鋪=11501
        string sInvoice = Session["115_SC_Invoice"].ToString().Trim(); //發票
        string sCName = Session["115_SC_Uid"].ToString().Trim();     //會員uid=''       
        string sMemberUID = Session["115_SC_Uid"].ToString().Trim();     //會員uid ='' 
        string sEmail = Session["115_SC_Email"].ToString().Trim();       //會員email=''

        string sDOGUID = "";
        string sRecMainGUID = _Tools.CreateGUID(40); Session["115_SC_IQRecMGUID"] = sRecMainGUID;
        string sDOGUIDMax = "";

        #region 寫入全部意見:SC_RecMainData2Par-------------------------------------------------------------------------------------
        string sError = "";
        sError = iQSave(sMainDataGUID, sRecMainGUID, sVersionID, sStoreNo, sExpendDate, sCName, sEatTime);
        if (sError != "")
        {
            Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
            return;
        }
        #endregion


        if (lbl115_SC_IQType.Text.Trim() == "")//如果是品牌部測試，就不新增意見
        {
            #region 寫入其他意見:SSF_Daily_OtherSuggest------------------------------------------------------------------------------
            string txtSugTypeM = "";
            string txtsugcate = "";
            string txtAnalysisMain = "";
            string txtAnalysisDetail = "";
            string txtsug = "";

            //跑每一個gridview的item           
            for (int iga = 0; iga < grdAnalysisData.Rows.Count; iga++)
            {
                HiddenField hidDOGUID = ((HiddenField)grdAnalysisData.Rows[iga].FindControl("hidDOGUID"));
                DropDownList drpSugTypeM = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpSugTypeM"));
                DropDownList drpSugType = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpSugType"));
                DropDownList drpAnalysisMain = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpAnalysisMain"));
                DropDownList drpAnalysisDetail = ((DropDownList)grdAnalysisData.Rows[iga].FindControl("drpAnalysisDetail"));
                TextBox txtSuggestion = ((TextBox)grdAnalysisData.Rows[iga].FindControl("txtSuggestion"));


                txtsugcate = drpSugType.SelectedValue.Trim();       //分類GUID:6a2d4134-191c-4a06-832f-2a7d9df296fb         
                txtAnalysisMain = drpAnalysisMain.SelectedValue.Trim();  //品項GUID:cccbebbc-c708-403a-b7a7-eee5f0c0e291
                txtAnalysisDetail = drpAnalysisDetail.SelectedValue.Trim();//細節GUID:4d7fb09d-99a8-4ab3-9306-4abd506b98e7
                txtsug = txtSuggestion.Text.Trim().Replace("限300字以內", "");//特色小吃一品醉蝦太油
                txtSugTypeM = drpSugTypeM.SelectedValue.Trim();
                //手填或手選其他意見儲存(不等於空的才新增)
                if (txtAnalysisMain.Trim() != "" || txtAnalysisDetail != "")
                {
                    sError = "";
                    sDOGUID = hidDOGUID.Value.Trim();// CreateGUID();
                    sDOGUIDMax = sDOGUIDMax + sDOGUID + ",";

                    sError = iQ_SuggestTypeSave(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, sDOGUID, txtSugTypeM, txtsug, txtsugcate, txtAnalysisMain, txtAnalysisDetail);

                    if (sError != "")
                    {
                        Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
                        return;
                    }
                }
            }
            #endregion


            #region 寫入喜惡三道:SC_ProductSugguest------------------------------------------------------------------------------

            string txtsugcateGUID = "";
            string sAnalysisMainName = "";
            string sAnalysisDetailName = "";
            /*

            //喜歡三道=================================================================================================  
            for (int iga = 0; iga < grdAnalysisData_Like.Rows.Count; iga++)
            {
                HiddenField hidDOGUID = ((HiddenField)grdAnalysisData_Like.Rows[iga].FindControl("hidDOGUID_Like"));
                DropDownList drpSugType = ((DropDownList)grdAnalysisData_Like.Rows[iga].FindControl("drpSugType_Like"));
                DropDownList drpAnalysisMain = ((DropDownList)grdAnalysisData_Like.Rows[iga].FindControl("drpAnalysisMain_Like"));
                txtsugcateGUID = drpSugType.SelectedValue.Trim();          //分類GUID
                sAnalysisMainName = drpSugType.SelectedItem.ToString();       //分類名字
                sAnalysisDetailName = drpAnalysisMain.SelectedItem.ToString();  //品項名字

                //手填或手選其他意見儲存(不等於空的才新增)
                if (drpSugType.SelectedValue.Trim() != "" && drpAnalysisMain.SelectedValue.Trim() != "")
                {
                    sError = "";
                    sDOGUID = hidDOGUID.Value.Trim();// CreateGUID();

                    sError = iQ_ProductSugguest(sDOGUID, sRecMainGUID, txtsugcateGUID, sAnalysisMainName, sAnalysisDetailName, Public.strP_ShopNo, "Like", sStoreNo, sExpendDate);

                    if (sError != "")
                    {
                        Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
                        return;
                    }
                }
            }


            //討厭三道=================================================================================================            
            for (int iga = 0; iga < grdAnalysisData_unLike.Rows.Count; iga++)
            {
                HiddenField hidDOGUID = ((HiddenField)grdAnalysisData_unLike.Rows[iga].FindControl("hidDOGUID_unLike"));
                DropDownList drpSugType = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpSugType_unLike"));
                DropDownList drpAnalysisMain = ((DropDownList)grdAnalysisData_unLike.Rows[iga].FindControl("drpAnalysisMain_unLike"));
                txtsugcateGUID = drpSugType.SelectedValue.Trim();          //分類GUID
                sAnalysisMainName = drpSugType.SelectedItem.ToString();       //分類名字
                sAnalysisDetailName = drpAnalysisMain.SelectedItem.ToString();  //品項名字

                //手填或手選其他意見儲存(不等於空的才新增)
                if (drpSugType.SelectedValue.Trim() != "" && drpAnalysisMain.SelectedValue.Trim() != "")
                {
                    sError = "";
                    sDOGUID = hidDOGUID.Value.Trim();// CreateGUID();

                    sError = iQ_ProductSugguest(sDOGUID, sRecMainGUID, txtsugcateGUID, sAnalysisMainName, sAnalysisDetailName, Public.strP_ShopNo, "UnLike", sStoreNo, sExpendDate);

                    if (sError != "")
                    {
                        Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
                        return;
                    }
                }
            }
            */
            #endregion

            #region 寫入會員資料:SC_IQMainData---------------------------------------------------------------------------------------
            //2015/08/26: DOGUID不填值，直接使用recmainguid去join otherguid)            
            //把逗號去除
            if (sDOGUIDMax.Length >= 1)
                sDOGUIDMax = sDOGUIDMax.Substring(0, sDOGUIDMax.Length - 1);
            sError = "";
            sError = iQ_InvoiceSave(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, txtsugcate, sDOGUIDMax, sEmail, sMemberUID, sInvoice);
            if (sError != "")
            {
                Tools.REG_script(Page, "<script>alert('" + sError + "');</script>");
                return;
            }
            #endregion
        }
    }
    #endregion





    #region 寫入問卷資料:iQSave()-----------------寫入SC_RecMainData2Par
    private string iQSave(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sStoreNo, string sExpendDate, string sCName, string sEatTime)
    {
        try
        {
            bool blOReturn = false;
            blOReturn = _blSuggestCard.InsertSC_RecMainData2Par(sMainDataGUID, sRecMainGUID, sVersionID, sStoreNo, sExpendDate, sCName, sEatTime);

            #region 1.是否第一次----------------------------------------------------------------------------------------------
            sError = iQ_Ans(sRecMainGUID, lblQ1.Text.Trim(), rblQ1.SelectedValue.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
            #endregion
            #region 2.半年內次數----------------------------------------------------------------------------------------------
            sError = iQ_Ans(sRecMainGUID, lblQ2.Text.Trim(), drpQ2.SelectedValue.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
            #endregion
            #region 3.來源資訊------------------------------------------------------------------------------------------------
            for (int iQ3 = 0; iQ3 < chkQ3.Items.Count; iQ3++)
            {
                if (chkQ3.Items[iQ3].Selected)
                {
                    sError = iQ_Ans(sRecMainGUID, lblQ3.Text.Trim(), chkQ3.Items[iQ3].Value.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
                }
            }
            #endregion
            #region 4.用餐目的------------------------------------------------------------------------------------------------
            //sError = iQ_Ans(sRecMainGUID, lblQ4.Text.Trim(), rblQ4.SelectedValue.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
            #endregion
            
            #region 6.滿意度--------------------------------------------------------------------------------------------------???
            string sQ5SaCode = "";
            string sQ6AnsName = "";
            string sQ6AnsGUID = "";
            string sQ6SaGUID = "";
            string sQ6SaCode = "";
            string sQ6AnsScore = "";
            for (int i = 0; i < grdQ6.Rows.Count; ++i)
            {
                sQ6AnsName = ((Label)grdQ6.Rows[i].FindControl("lblQ6AnsName")).Text.Trim();
                sQ6AnsGUID = ((Label)grdQ6.Rows[i].FindControl("lblQ6AnsGUID")).Text.Trim();
                sQ6AnsScore = ((Label)grdQ6.Rows[i].FindControl("lblQ6AnsScore")).Text.Trim();

                sQ6SaGUID = ((DropDownList)(grdQ6.Rows[i].FindControl("drpQ6"))).SelectedValue.ToString();
                sQ6SaCode = "0" + ((DropDownList)(grdQ6.Rows[i].FindControl("drpQ6"))).SelectedIndex.ToString();
                sError = iQ_Ans(sRecMainGUID, lblQ6.Text.Trim(), sQ6AnsGUID, 1, sQ6SaGUID, sQ6SaCode, sStoreNo, sExpendDate, "");
                if (sQ6AnsScore == "-1")
                {
                    sQ5SaCode = sQ6SaCode;
                }
            }
            #endregion

            #region 5.--------------------------------------------------------------------------------------------------------
            sError = iQ_Ans(sRecMainGUID, lblQ5.Text.Trim(), drpQ5.SelectedValue.Trim(), 0, "", sQ5SaCode, sStoreNo, sExpendDate, "");
            #endregion
            #region 7.兩樣特色------------------------------------------------------------------------------------------------
            for (int iQ7 = 0; iQ7 < chkQ7.Items.Count; iQ7++)
            {
                if (chkQ7.Items[iQ7].Selected)
                {
                    sError = iQ_Ans(sRecMainGUID, lblQ7.Text.Trim(), chkQ7.Items[iQ7].Value.Trim(), 0, "", "", sStoreNo, sExpendDate, "");

                }
            }
            #endregion
            #region 8.會不會介紹----------------------------------------------------------------------------------------------
            for (int iQ8 = 0; iQ8 < rblQ8.Items.Count; iQ8++)
            {
                if (rblQ8.Items[iQ8].Selected)
                {
                    sError = iQ_Ans(sRecMainGUID, lblQ8.Text.Trim(), rblQ8.Items[iQ8].Value.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
                }
            }
            #endregion
            #region 9.(性別)--------------------------------------------------------------------------------------------------
            for (int iQ9 = 0; iQ9 < rblQ9.Items.Count; iQ9++)
            {
                if (rblQ9.Items[iQ9].Selected)
                {
                    sError = iQ_Ans(sRecMainGUID, lblQ9.Text.Trim(), rblQ9.Items[iQ9].Value.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
                }
            }
            #endregion
            #region 10.(年齡)-------------------------------------------------------------------------------------------------
            for (int iQ10 = 0; iQ10 < rblQ10.Items.Count; iQ10++)
            {
                if (rblQ10.Items[iQ10].Selected)
                {
                    sError = iQ_Ans(sRecMainGUID, lblQ10.Text.Trim(), rblQ10.Items[iQ10].Value.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
                }
            }
            #endregion
            #region 11.(時間)-------------------------------------------------------------------------------------------------
            sError = iQ_Ans(sRecMainGUID, lblQ11.Text.Trim(), drpQ11.SelectedValue, 0, "", "", sStoreNo, sExpendDate, "");
            #endregion
            #region 12.不介紹原因---------------------------------------------------------------------------------------------
            /*
            for (int iQ12 = 0; iQ12 < chkQ12.Items.Count; iQ12++)
            {
                if (chkQ12.Items[iQ12].Selected)
                {
                    sError = iQ_Ans(sRecMainGUID, lblQ12.Text.Trim(), chkQ12.Items[iQ12].Value.Trim(), 0, "", "", sStoreNo, sExpendDate, "");
                }
            }
             * */
            #endregion
        }
        catch (Exception ex)
        {

            sError = "資料修改失敗!!請洽系統管理員~";
        }
        return sError;
    }
    #endregion




    #region 寫入會員資料:iQ_InvoiceSave()---------寫入SC_IQMainData
    private string iQ_InvoiceSave(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sSugMGUID, string sDOGUID, string sEmail, string sMemberUID, string sInvoice)
    {
        bool blQReturn = false;
        blQReturn = _blSuggestCard.InsertSC_IQMainData(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, sSugMGUID, sDOGUID, sEmail, sMemberUID, sInvoice, drpQ11.SelectedItem.Text.Trim());


        if (sError != "")
        {
            sError = "修改失敗!!請洽系統管理員~";
        }
        return sError;
    }
    #endregion

    #region 寫入全部意見:iQ_Ans()-----------------寫入SC_RecAns2Par(1/2/3/4/5/6/7/8/9/10/11/12)
    private string iQ_Ans(string sRecMainGUID, string sQuestionGUID, string sAnsGUID, int iIssa, string sSatisGUID, string sSatisCode, string sStoreNo, string sExpendDate, string sCName)
    {
        string sError = "";
        try
        {
            string RecAnsGUID = Guid.NewGuid().ToString().Trim();
            DataTable DTM = (DataTable)Session["115_SC_Ans"];
            DataRow[] rowA = DTM.Select("AnsGuid='" + sAnsGUID + "'");
            string sAnsCode = "";
            for (int iRow = 0; iRow < rowA.Length; iRow++)
            {
                sAnsCode = rowA[iRow]["AnsCode"].ToString().Trim();
                if (iIssa == 1)
                    sAnsCode = sSatisCode;
                bool blOReturn = false;
                blOReturn = _blSuggestCard.InsertSC_RecAns2Par(RecAnsGUID, sRecMainGUID, sQuestionGUID, sAnsGUID, sAnsCode, iIssa, sSatisGUID == "" ? sSatisCode : sSatisGUID, sStoreNo, sExpendDate, sCName);
            }
            if (sQuestionGUID == lblQ9.Text.Trim())//9.性別
            {
                Session["115_RecAnsGUID_Q9_Sex"] = RecAnsGUID;
            }
            if (sQuestionGUID == lblQ10.Text.Trim())//10.年齡
            {
                Session["115_RecAnsGUID_Q10_Age"] = RecAnsGUID;
            }
        }
        catch (Exception ex)
        {
            sError = ex.ToString().Trim();
        }
        return sError;
    }

    #endregion

    #region 寫入其他意見:iQ_SuggestTypeSave()-----寫入SSF_Daily_OtherSuggest(類別留言...)
    private string iQ_SuggestTypeSave(string sMainDataGUID, string sRecMainGUID, string sVersionID, string sVersionName, string sStoreNo, string sExpendDate, string sCName, string sDOGUID, string sSugType, string sSuggest, string sAnalyMGUID, string sAnalyDGUID, string sSugDGUIDl)
    {
        bool blOReturn = false;
        blOReturn = _blSuggestCard.InsertSSF_Daily_OtherSuggest(sMainDataGUID, sRecMainGUID, sVersionID, sVersionName, sStoreNo, sExpendDate, sCName, sDOGUID, sSugType, sSuggest, sAnalyMGUID, sAnalyDGUID, sSugDGUIDl);

        sError = "";
        if (!blOReturn)
        {
            sError = "修改失敗!!請洽系統管理員~";
        }
        return sError;
    }
    #endregion

    #region 寫入喜惡三道:-----寫入SC_ProductSugguest
    private string iQ_ProductSugguest(string sProdSugGUID, string sRecMainGUID, string sAnsGUID, string sAnsName, string sSugNote, string sCareerNo, string siType, string sStoreNo, string sExpendDate)
    {
        bool blOReturn = false;
        blOReturn = _blSuggestCard.InsertSC_ProductSugguest(sProdSugGUID, sRecMainGUID, sAnsGUID, sAnsName, sSugNote, sCareerNo, siType, sStoreNo, sExpendDate);

        sError = "";
        if (!blOReturn)
        {
            sError = "修改失敗!!請洽系統管理員~";
        }
        return sError;
    }
    #endregion

}
