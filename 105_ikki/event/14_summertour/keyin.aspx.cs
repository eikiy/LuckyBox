using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

public partial class event_14_summertour_keyin : System.Web.UI.Page
{
    Sql s = new Sql();
    Tools t = new Tools();
    blAction bla = new blAction();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["2014_377Uid"] == null)
            Response.Redirect("login.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sCareer = aaclsPubSet.strP_Ename;
        string sAction_No = "377";
        string sCode = "";
        string sSessCode = "";
        sCode = txtCode.Value.ToUpper();
        sSessCode = Session["Valid"].ToString().Trim().ToUpper();

        // if (Session["CheckImageCode"].ToString().Trim() != txtCode.Value.Trim())
        //檢查驗証碼
        if (Session["Valid"] == null)
        {
            Response.Write("<script language=javascript>alert(\"驗證碼錯誤!!\");</script>");
            return;
        }

        if (Session["Valid"] != null && Request.Form["txtcode"].ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            Response.Write("<script language=javascript>alert(\"驗證碼錯誤!!\");</script>");
            return;
        }
        string sExpendDate = "";
        sExpendDate = selebiryear.SelectedValue.ToString() + "/" + selebirmonth.Value.ToString() + "/" + selebirday.Value.ToString();

        if (sExpendDate.ToString().Trim() == "")
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('發票日期未輸入,請重新填寫..');</script>");
            return;
        }

        try
        {
            DateTime.Parse(sExpendDate.ToString().Trim());

           // -------------------------------上線要加上去
            if (DateTime.Parse(sExpendDate.ToString().Trim()) > DateTime.Today)
            {
                txtCode.Value = "";
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('發票日期錯誤,請重新填寫..');</script>");
                return;
            }
            if (DateTime.Parse(sExpendDate.ToString().Trim()) < DateTime.Parse("2014/07/12") || DateTime.Parse(sExpendDate.ToString().Trim()) > DateTime.Parse("2014/08/15"))
            {
                txtCode.Value = "";
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('發票日期錯誤,請填寫【2014/07/12~2014/08/15】期間的發票日期..');</script>");
                return;
            }

        }
        catch (Exception exp)
        {

            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('發票日期錯誤,請重新填寫..');</script>");
            return;
        }


        if (txtIdNo.Value.ToString().Trim() == "")
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('發票號碼未輸入,請重新填寫..');</script>");
            return;
        }
        if (!t.CheckSalesNo(txtIdNo.Value.ToString().Trim()))
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('發票號碼錯誤,請重新填寫..');</script>");
            return;
        }

        bool blReturn = bla.CheckInvoice(sCareer, sAction_No, txtIdNo.Value.Trim(), "value2", Session["2014_377Email"].ToString());
        if (blReturn)
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('此發票號碼已登入過,請重新填寫..');</script>");
            return;
        }      

        if (txtCost.Value.ToString().Trim() == "")
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('消費金額未輸入,請重新填寫..');</script>");
            return;
        }
        if (txtCost.Value.ToString().Trim() == "0")
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('消費金額不可為0,請重新填寫..');</script>");
            return;
        }
        try { int.Parse(txtCost.Value.Trim()); }
        catch
        {
            txtCode.Value = "";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('消費金額,請填入數字格式!例如:1200');</script>");
            return;
        }
       
        string sExpendDate2 = DateTime.Parse(sExpendDate).ToString("yyyy/MM/dd");		
        string sError = "";        //計算消費客數
        int iCount = 0;
        iCount = (int.Parse(txtCost.Value.Trim()) / 430);
        ////value1:發票日期  value2:發票號碼   value3:消費客數 value5:消費金額
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", sCareer));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("uid", Session["2014_377Uid"].ToString().Trim()));
        sb.Append(s.ParamXML("email", Session["2014_377Email"].ToString().Trim()));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", sExpendDate2.Trim()));
        sb.Append(s.ParamXML("value2", txtIdNo.Value.ToString().Trim()));
        sb.Append(s.ParamXML("value3", iCount));
        sb.Append(s.ParamXML("value5", txtCost.Value.ToString().Trim()));
        sb.Append("</insert>");
        sb.Append("</sql>");

        try
        {
            sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
            if (sError != "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
                return;
            }
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
            return;
        }

        //this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('謝謝您的參加！祝您幸運中獎~');</script>");
        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='keyin_ok.aspx';</script>");

        Session["2014_PrintCName"] = Session["2014_377CName"].ToString();

        Session.Remove("2014_377Uid");
        Session.Remove("2014_377Email");
        Session.Remove("2014_377CName");
    }


}
