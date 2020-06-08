using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class citi_apply_online : System.Web.UI.Page
{
    blAction _blAction = new blAction();//活動的
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void btnSend_Click(object sender, ImageClickEventArgs e)
    {
        if (txtName.Value.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[姓名] 欄位不能空白');</script>");
            return;
        }
        if (txtMobile.Value.Trim().Length != 10)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[手機] 不正確');</script>");
            return;
        }
        if (!radSex1.Checked && !radSex0.Checked)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請選擇 [性別]');</script>");
            return;
        }
        string sCareer = Public.strP_Ename;
        string sAmPm = "";
        if (cbAm.Checked) sAmPm += "上午、";
        if (cbPm.Checked) sAmPm += "下午、";
        if (cbNm.Checked) sAmPm += "晚上、";
        if (sAmPm != "") sAmPm = sAmPm.Substring(0, sAmPm.Length - 1);
        string sSex = "先生";
        if (radSex0.Checked) sSex = "小姐";

        

        bool blReturn = true;
        blReturn = _blAction.Insert_Citi_apply(sCareer, txtName.Value.Trim(), txtOfficePhone.Value.Trim(), txtHomePhone.Value.Trim(),txtMobile.Value.Trim(),sAmPm,sSex);
        if (!blReturn)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
            return;
        }
        
        
        
        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('資料已送出~ 客服人員將於一週內為你服務，謝謝!');</script>");
        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.htm';</script>");
    }
}
