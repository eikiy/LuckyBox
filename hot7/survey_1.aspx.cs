using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
public partial class survey_1 : System.Web.UI.Page
{
    #region 共用參數
    check_input _check = new check_input();//檢查
    blSuggestCard _blSuggestCard = new blSuggestCard();
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Request["115_SC_IQType"] != null)
            {
                lbl115_SC_IQType.Text = Request["115_SC_IQType"].ToString().Trim();
            }


            #region 頁面顯示:年月日
            //輸出年
            int y = 0;

            selectYear.Items.Add(new ListItem("1931(民國20年前)", "1931"));
            for (int i = 1932; i <= System.Convert.ToInt16(DateTime.Now.Year.ToString()); i++)
            {
                y = i - 1911;
                selectYear.Items.Add(new ListItem(i.ToString() + "(民國" + y.ToString() + "年)", i.ToString()));
            }

            //輸出月
            for (int i = 1; i <= 12; i++)
            {
                selectMonth.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日
            for (int i = 1; i <= 31; i++)
            {
                selectDay.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
            #endregion


            //年月預設
            selectYear.SelectedValue = DateTime.Now.Year.ToString();
            selectMonth.SelectedValue = DateTime.Now.Month.ToString();
            selectDay.SelectedValue = DateTime.Now.Day.ToString();

            //時段下拉選單
            blSuggestCard.BindTime(dropTime, Public.strP_ShopNo);

            //店鋪下拉選單Public.strP_ShopNo   
            blSuggestCard.BindStore(dropStore, Public.strP_ShopNo);

        }
    }



    #region 串消費日期
    private string BindSelExpendDate()
    {
        string sEatDate = "";
        string month = "";
        string day = "";

        if (selectMonth.SelectedValue.Trim().Length < 2)
        {
            month = "0" + selectMonth.SelectedValue.Trim();
        }
        else
            month = selectMonth.SelectedValue.Trim();
        if (selectDay.SelectedValue.Trim().Length < 2)
        {
            day = "0" + selectDay.SelectedValue.Trim();
        }
        else
            day = selectDay.SelectedValue.Trim();

        sEatDate = selectYear.SelectedValue.Trim() + "/" + month + "/" + day;

        return sEatDate;
    }
    #endregion

    #region 版本
    private void BindVersionID()
    {
        DataTable DT = new DataTable();


        //blIsForTest:true 只看得到發佈過的版本 false 可看到未發佈的版本------------------------------------
        //bool blIsForTest = false;
        //if (lbl115_SC_IQType.Text.ToString().Trim() != "")
        //    blIsForTest = true;
        bool blIsForTest = true;


        //false:11501，true:11500-P-------------------------------------------------------------------------
        DT = _blSuggestCard.BindVersionID(dropStore.SelectedValue, BindSelExpendDate(), blIsForTest, false);
        if (DT.Rows.Count <= 0)
        {
            DT = new DataTable();
            DT = _blSuggestCard.BindVersionID(dropStore.SelectedValue, BindSelExpendDate(), blIsForTest, true);
        }
        Session.Remove("115_SC_MainData");
        Session["115_SC_MainData"] = DT;
    }
    #endregion



    //[下一步]按鈕======================================================================================================
    protected void btnSend_Click(object sender, EventArgs e)
    {
        #region 輸入資料檢查
        if (BindSelExpendDate() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的用餐日期未選擇,請重新填寫..');</script>");
            return;
        }
        try
        {
            DateTime.Parse(BindSelExpendDate());
        }
        catch (Exception ex)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('消費日期格式有誤,請重新填寫!!..');</script>");
            return;

        }

        string DueDate = DateTime.Parse(BindSelExpendDate()).AddMonths(1).ToString("yyyy/MM/07");
        if (DateTime.Today > DateTime.Parse(DueDate))
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('輸入發票號碼截止時間為每次月7日,感謝您的支持!!..');</script>");
            return;
        }

        if (lbl115_SC_IQType.Text.ToString().Trim() == "")
        {
            if (DateTime.Today < DateTime.Parse(BindSelExpendDate()))
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('消費日期不可大於今天,請重新填寫!!..');</script>");
                return;
            }
        }

        if (dropTime.SelectedValue.Trim() == "請選擇")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的用餐時間未選擇,請重新填寫..');</script>");
            return;
        }

        if (dropStore.SelectedValue.Trim() == "請選擇")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的用餐店鋪未選擇,請重新填寫..');</script>");
            return;
        }

        if (txtInvoice.Text.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的用餐發票未輸入,請重新填寫..');</script>");
            return;
        }


        bool IsValid;
        IsValid = _check.CheckSalesNo(txtInvoice.Text.Trim());
        if (IsValid == false)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的用餐發票輸入格式錯誤,請重新填寫..');</script>");
            return;
        }
        #endregion


        BindVersionID();//建立版本!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        Session["115_SC_eatDate"] = DateTime.Parse(BindSelExpendDate()).ToString("yyyy/MM/dd");//日期
        Session["115_SC_eatTime"] = dropTime.SelectedValue.Trim();//時間
        Session["115_SC_Store"] = dropStore.SelectedValue.Trim();//店鋪
        Session["115_SC_Invoice"] = txtInvoice.Text;//發票
        Session["115_SC_Uid"] = "";//會員uid
        Session["115_SC_Email"] = "";//會員email



        Session.Remove("QAStep");
        Session["QAStep"] = "survey_1.aspx";

        if (lbl115_SC_IQType.Text.Trim() != "")
            Response.Redirect("survey_2.aspx?115_SC_IQType=" + lbl115_SC_IQType.Text.ToString().Trim());
        else
            Response.Redirect("survey_2.aspx");
    }

}
