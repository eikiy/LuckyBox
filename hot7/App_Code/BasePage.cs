using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
/// <summary>
/// BasePage 的摘要描述
/// </summary>
public class BasePage : System.Web.UI.Page
{
    #region 共用變數
    public Sql s = new Sql();
    public Tools t = new Tools();
    public Form f = new Form();
    public Public p = new Public();
    #endregion

    #region BasePage
    public BasePage()
    {
        //
        // TODO: 在此加入建構函式的程式碼
        //
    }
    #endregion

    #region OnLoad
    protected override void OnLoad(EventArgs e)
    {
        if (this.Session.IsNewSession)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='index.htm';</script>");
        }

        base.OnLoad(e);
    }
    #endregion

    #region CheckSession
    public void CheckSession()
    {
        if (Session["115_CheckSession"] == null)
        {
            Session.RemoveAll();
            System.Web.Security.FormsAuthentication.SignOut();
            //this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Time out 請重新登入系統');</script>");
            Response.Redirect("iq_CtrlF5.aspx");

        }

    }

    public void CheckSessionM()
    {
        if (Session["115_MCheckSession"] == null)
        {
            Session.RemoveAll();
            System.Web.Security.FormsAuthentication.SignOut();
            //this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Time out 請重新登入系統');</script>");
            Response.Redirect("~/m/fq1.aspx");

        }

    }

    #endregion


}