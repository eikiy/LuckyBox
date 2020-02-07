using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Xml;
using System.IO;
using System.Web.Mail;

public partial class event_14_bathrobe_apply : System.Web.UI.Page
{
    #region 共用參數
    Sql s = new Sql();
    Public _Public = new Public();
    blAction blAt = new blAction();
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindCount();
        }
    }
    private void BindCount()
    {
        try
        {
            //StringBuilder sb1 = new StringBuilder();
            //sb1.Append("<sql>");
            //sb1.Append("<select>");
            //sb1.Append("<list><![CDATA[SELECT SUM(CNT) Icount FROM (select CASE WHEN value5='' THEN 1 ELSE 2 END AS CNT from wang_action_members where Action_NO=@Action_NO)BB ]]>");
            //sb1.Append(s.ParamXML("Action_NO", "372"));
            //sb1.Append("</list>");
            //sb1.Append("</select>");
            //sb1.Append("</sql>");
            //string sError = "";
            //DataSet DS2 = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);

            labCount.Text = blAt.BindTotal372().ToString().Trim();

            Panel1.Visible = false;
            aaclsPubSet.BindYear(drpyear1, 21);
            //輸出月
            drpmonth1.Items.Clear();
            drpmonth1.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 12; i++)
            {
                drpmonth1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日
            drpday1.Items.Clear();
            drpday1.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 31; i++)
            {
                drpday1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            aaclsPubSet.BindYear(drpyear2, 21);
            //輸出月
            drpmonth2.Items.Clear();
            drpmonth2.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 12; i++)
            {
                drpmonth2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日
            drpday2.Items.Clear();
            drpday2.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 31; i++)
            {
                drpday2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

        }
        catch (Exception ex)
        {


        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string sAction_No = "372";

        string sError = "";
        DataSet DS = new DataSet();
        Member.Member m = new Member.Member();

        #region 驗證是否開始或已經結束
        string sDateError = "";
        DataSet DSReturn = new DataSet();
        sDateError = _Public.CheckActionDate(aaclsPubSet.strP_Ename, sAction_No, ref DSReturn);
        if (sDateError != "")
        {
            aaclsPubSet.REG_script(Page, "<script>alert('" + sDateError + "');</script>");
            return;
        }
        #endregion

        //驗證是否已經參加過了
        int iJoinCount = 0;
        if (DSReturn.Tables[0].Rows.Count > 0)
            iJoinCount = int.Parse(DSReturn.Tables[0].Rows[0]["JoinCount"].ToString());
        if (iJoinCount > 0)
        {
            if (int.Parse(BindEmail(txtEmail.Text.Trim())) >= 1)
            {
                aaclsPubSet.REG_script(Page, "<script>alert('Oops! 這組Email已被報名過囉，建議您使用別組Email報名，謝謝您!');</script>");
                return;
            }
        }


        //檢查欄位
        string sFriendBirth1 = "";
        string sFriendBirthCheck1 = "";
        sFriendBirth1 = drpyear1.SelectedValue.Trim() + "/" + drpmonth1.SelectedValue.Trim() + "/" + drpday1.SelectedValue.Trim();
        sFriendBirthCheck1 = drpyear1.SelectedValue.Trim() + drpmonth1.SelectedValue.Trim() + drpday1.SelectedValue.Trim();
        //檢查姓名、電話、email、生日
        if (txtCName.Text == "" || txtmobile1.Text == "" || txtEmail.Text == "" || sFriendBirthCheck1.Trim() == "")
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');</script>");
            return;
        }
        if (!aaclsPubSet.CheckEMail(txtEmail.Text.Trim()))
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您輸入的e-mail不正確,請重新輸入..');</script>");
            return;
        }
        //檢查親友其中一個欄位填就必需全填
        string sFriendBirth2 = "";
        string sFriendBirthCheck2 = "";
        sFriendBirth2 = drpyear2.SelectedValue.Trim() + "/" + drpmonth2.SelectedValue.Trim() + "/" + drpday2.SelectedValue.Trim();
        sFriendBirthCheck2 = drpyear2.SelectedValue.Trim() + drpmonth2.SelectedValue.Trim() + drpday2.SelectedValue.Trim();
        // if (txtCName2.Text.Trim() != "" || txtmobile2.Text.Trim() != "" || sFriendBirthCheck2.Trim() != "")
        if (RadioButtonList1.SelectedValue == "2")
        {
            //檢查姓名
            if (txtCName2.Text.Trim() == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('同行者【姓名】空白,請重新填寫!!');</script>");
                return;
            }

            //檢查手機
            if (txtmobile2.Text.Trim() == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('同行者【手機】空白,請重新填寫!!');</script>");
                return;
            }
            //檢查生日
            try
            {
                DateTime.Parse(sFriendBirth2);
            }
            catch (Exception ex)
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('同行者【生日日期】不正確,請重新選擇!!');</script>");
                return;
            }

        }

        if (!CheckBox1.Checked)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您是否已經同意活動注意事項.');</script>");
            return;
        }

        int iActionCount = int.Parse(RadioButtonList1.SelectedValue.Trim());
        //*******************報名人數(iFinishCount)***********************
      //是否可以參加
        bool blReturn = blAt.BindTotalCount372();
        // int iFinishCount = 10;
        int iIsOK = 0;
        //在查一次數量
        labCount.Text = blAt.BindTotal372().ToString().Trim();

        if (blReturn)
        {
            iIsOK = 1;
        }
        else
            iIsOK = 0;

        //value1 姓名
        //value2 生日
        //value3 手機
        //value4 親友姓名
        //value5 親友生日
        //value6 親友手機        
        //value7 中獎了沒
        
        //序號、email序號
        int iCount = blAt.BindCount372() + 1;// int.Parse(labCount.Text.Trim()) + 1;
        string sNo = "A" + iCount.ToString("000").ToString() + "(" + txtCName.Text.Trim()+")";

        if (txtCName2.Text.Trim() != "")
        {
            sNo = sNo + " , B" + iCount.ToString("000").ToString() + "(" + txtCName2.Text.Trim() + ")";
        }

        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", aaclsPubSet.strP_Ename));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        // sb.Append(s.ParamXML("uid", labUid.Text.Trim()));
        sb.Append(s.ParamXML("email", txtEmail.Text.Trim()));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", txtCName.Text.Trim()));
        sb.Append(s.ParamXML("value2", sFriendBirthCheck1 == "" ? "" : sFriendBirth1.Trim()));
        sb.Append(s.ParamXML("value3", txtmobile1.Text.Trim()));
        sb.Append(s.ParamXML("value4", txtCName2.Text.Trim()));
        sb.Append(s.ParamXML("value5", sFriendBirthCheck2 == "" ? "" : sFriendBirth2.Trim()));
        sb.Append(s.ParamXML("value6", txtmobile2.Text.Trim()));
        sb.Append(s.ParamXML("value7", iIsOK));
        sb.Append(s.ParamXML("value8", iCount.ToString("000")));
        sb.Append("</insert>");
        sb.Append("</sql>");
        sError = "";
        try
        {
            sError = "";
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
            if (sError != "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
                return;
            }
            //寄送email
            if (iIsOK == 1)
                SendMail(txtCName.Text.Trim(), sNo);

        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
            return;
        }
        if (iIsOK == 0)
        {
            Session["372YESNo2"] = "No";
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='apply_end.aspx';</script>");
        }
        else
        {
            Session["372YESCName"] = txtCName.Text.Trim();
            Session["372YESCName2"] = txtCName2.Text.Trim();
            Session["372YESNo"] = iCount.ToString("000");
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='apply_ok.aspx';</script>");

        }
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RadioButtonList1.SelectedItem.Value == "2")
        {
            Panel1.Visible = true;
        }
        else
        {
            Panel1.Visible = false;
            txtCName2.Text = "";
            txtmobile2.Text = "";
            drpyear2.SelectedIndex = -1;
            drpmonth2.SelectedIndex = -1;
            drpday2.SelectedIndex = -1;
        }
    }
  

    /// <summary>
    /// 檢查email
    /// </summary>
    /// <param name="sEmail">email</param>
    /// <returns></returns>
    private string  BindEmail(string sEmail)
    {
        string sCount = "0";
        try
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("<sql>");
            sb1.Append("<select>");
            sb1.Append("<list><![CDATA[SELECT COUNT(*) Icount from wang_action_members where Action_NO=@Action_NO AND email=@email ]]>");
            sb1.Append(s.ParamXML("Action_NO", "372"));
            sb1.Append(s.ParamXML("email", sEmail));
            sb1.Append("</list>");
            sb1.Append("</select>");
            sb1.Append("</sql>");
            string sError = "";
            DataSet DS2 = s.Cmd2DS(s.ConnStr.website, sb1.ToString(), out sError);


            sCount = DS2.Tables["list"].Rows[0]["Icount"].ToString() == "" ? "0" : DS2.Tables["list"].Rows[0]["Icount"].ToString();

        }
        catch (Exception ex)
        {
        }

        return sCount;
    }
    /// <summary>
    /// 寄送mail通知
    /// </summary>
    /// <param name="sCName"></param>
    /// <param name="sNo"></param>
    private void SendMail(string sCName,string sNo)
    {
        //手動更改確認信函內容

        string sTitle = "";
        string sBody = "";
        string sMail = "<a href=mailto:" + txtEmail.Text.Trim() + ">" + txtEmail.Text.Trim() + "</a>";
        XmlDocument XmlDoc = new XmlDocument();
        XmlNode oNode;
        if (File.Exists(Server.MapPath("372mail.xml")))
        {
            XmlDoc.Load(Server.MapPath("372mail.xml"));
            oNode = XmlDoc.SelectSingleNode("//郵件主旨");
            if (oNode != null) sTitle = oNode.InnerText;
            oNode = XmlDoc.SelectSingleNode("//郵件內容");
            if (oNode != null)
            {
                sBody = oNode.InnerText;
                sBody = sBody.Replace("((CName))", sCName);
                sBody = sBody.Replace("((sNo))", sNo);
              
            }
        }

        MailMessage mail = new MailMessage();
        mail.From = "\"藝奇\"<service@ikki.com.tw>"; ;
        mail.To = txtEmail.Text.Trim();
        mail.Subject = sTitle;
        mail.Body = sBody;
        mail.BodyFormat = MailFormat.Html;
        SmtpMail.SmtpServer = "192.168.2.1";

        try
        {          
            SmtpMail.Send(mail);
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('您的【email帳號】不正確或無法送達,請重新填寫..~');</script>");
            return;
        }
    
    }
}
