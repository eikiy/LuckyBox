using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
//mail要用!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
using System.Xml;
using System.IO;
using System.Web.Mail;


public partial class event_15_summer_login : System.Web.UI.Page
{
    #region 共用參數
    Sql s = new Sql();//資料庫的
    Public _Public = new Public();//共用的
    blAction _blAction = new blAction();//活動的
    check_input _check = new check_input();//檢查
    Tools _Tools = new Tools();
    string sAction_No = "438";//活動編號[要改]
    string sCareer = Public.strP_Ename;//事業處[要改]
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];//事業處編號
    #endregion

    //初始頁面===================================================================
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;//一開始不顯示第二階段資料(人數欄位)
            BindYMD();
            BindSTORE();
        }
    }


    //切換場次下拉選單
    protected void ddlArea_OnSelectedIndexChanged(object sender, EventArgs e)
    {
        BindSTORE();
    }

    //建立北中南下拉選單
    private void BindSTORE()
    {
        /*
        SELECT [PItemName]
        FROM [website].[dbo].[wang_action_ParameterItems]
        where [PTypeID]='store_438' AND [PTypeIDM]='中部場次'
        */
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<select>");
        sb.Append("<list><![CDATA[SELECT * FROM [dbo].[wang_action_ParameterItems] where [PTypeID]='store_438' AND [PTypeIDM]='" + ddlArea.SelectedValue.ToString() + "'  AND [PValue2]='0' ORDER BY [PItemOrder]]]></list>");
        sb.Append("</select>");
        sb.Append("</sql>");
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        ddlStore.DataSource = DS;
        ddlStore.DataTextField = "PItemName";//顯示的名字
        ddlStore.DataValueField = "PValue1";//網址
        if (DS != null)
        {
            ddlStore.DataBind();
        }
        ddlStore.Items.Insert(0, "請選擇場次");
    }
    
    //建立年月日下拉選單=========================================================
    private void BindYMD()
    {
        try
        {
            //輸出年1
            Tools.BindYear(ddlYear1, 21);
            //輸出月1
            ddlMonth1.Items.Clear();
            ddlMonth1.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 12; i++)
            {
                ddlMonth1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
            //輸出日1
            ddlDay1.Items.Clear();
            ddlDay1.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 31; i++)
            {
                ddlDay1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }
        catch (Exception ex)
        {
        }


        try
        {
            //輸出年2
            Tools.BindYear(ddlYear2, 21);
            //輸出月2
            ddlMonth2.Items.Clear();
            ddlMonth2.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 12; i++)
            {
                ddlMonth2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
            //輸出日2
            ddlDay2.Items.Clear();
            ddlDay2.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 31; i++)
            {
                ddlDay2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }
        catch (Exception ex)
        {
        }

    }


    //點選人數，判斷是否顯示第二塊欄位===========================================
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbSum.SelectedItem.Value == "2")
        {
            Panel1.Visible = true;
        }
        else//欄位還原
        {
            Panel1.Visible = false;
            txtName2.Text = "";
            txtPhone2.Text = "";
            ddlYear2.SelectedIndex = -1;
            ddlMonth2.SelectedIndex = -1;
            ddlDay2.SelectedIndex = -1;
        }
    }


    //[go]按鈕===================================================================
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        #region 驗證是否開始或已經結束
        string sDateError = "";
        DataSet DSReturn = new DataSet();
        sDateError = _blAction.CheckActionDate3(Public.strP_Ename, sAction_No, ref DSReturn);
        if (sDateError != "")
        {
            Tools.REG_script(Page, "<script>alert('" + sDateError + "');</script>");
            return;
        }
        #endregion 
   
        #region 輸入完整檢查
        if (ddlArea.SelectedValue == "請選擇區域")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請 [選擇區域]');</script>");
            return;
        }
        if (ddlStore.SelectedValue == "請選擇場次")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請 [選擇場次]');</script>");
            return;
        }
        
        if (txtName1.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [姓名]');</script>");
            return;
        }
        if (!check_input.CheckChineseName(txtName1.Text.ToString().Trim()))
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[姓名]要是中文字喔');</script>");
            return;
        }



        if (txtPhone1.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [手機]');</script>");
            return;
        }
        if (!check_input.CheckPhone(txtPhone1.Text.ToString().Trim()))
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[手機]格式不正確喔');</script>");
            return;
        }


        if (ddlYear1.SelectedValue == "" || ddlMonth1.SelectedValue == "" || ddlDay1.SelectedValue == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [出生年月日]');</script>");
            return;
        }


        if (txtEmail1.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [Email]');</script>");
            return;
        }
        if (!check_input.CheckEMail(txtEmail1.Text.ToString().Trim()))
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[Email]格式不正確喔');</script>");
            return;
        }

        if (rbSum.SelectedItem.Value == "2")//有兩個人報名
        {

            if (txtName2.Text.ToString().Trim() == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者姓名]');</script>");
                return;
            }
            if (!check_input.CheckChineseName(txtName2.Text.ToString().Trim()))
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[同行者姓名]要是中文字喔');</script>");
                return;
            }


            if (txtPhone2.Text.ToString().Trim() == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者手機]');</script>");
                return;
            }
            if (!check_input.CheckPhone(txtPhone2.Text.ToString().Trim()))
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[同行者手機]格式不正確喔');</script>");
                return;
            }


            if (ddlYear2.SelectedValue == "" || ddlMonth2.SelectedValue == "" || ddlDay2.SelectedValue == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者出生年月日]');</script>");
                return;
            }
        }
        #endregion

        #region 帳號參加次數控管(手機，欄位value5-報名者手機，欄位value9-夾帶者手機)
        //此活動一個手機(輸入的資料)只能參加一次
        string sData = "";
        sData = txtPhone1.Text.ToString().Trim();

        if (_blAction.BindValueCount(sAction_No, "value5", sData) >= 1)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Oops！" + sData + "這組手機號碼剛已報名過囉，建議您使用其他手機號碼報名，感謝您！');</script>");
            return;
        }
        else if (_blAction.BindValueCount(sAction_No, "value9", sData) >= 1)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Oops！" + sData + "這組手機號碼剛已報名過囉，建議您使用其他手機號碼報名，感謝您！');</script>");
            return;
        }

        string sData2 = "";
        sData2 = txtPhone2.Text.ToString().Trim();
        if (_blAction.BindValueCount(sAction_No, "value5", sData2) >= 1)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Oops！" + sData2 + "這組手機號碼剛已報名過囉，建議您使用其他手機號碼報名，感謝您！');</script>");
            return;
        }
        else if (_blAction.BindValueCount(sAction_No, "value9", sData2) >= 1)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Oops！" + sData2 + "這組手機號碼剛已報名過囉，建議您使用其他手機號碼報名，感謝您！');</script>");
            return;
        }
        #endregion

        #region 寫入活動登入資料表
        //製造廠地
        string sStage = "";
        sStage = ddlStore.SelectedItem.Text;//藝奇台北敦化北店
        string sStageH = "";
        sStageH = ddlStore.SelectedValue;

        //製造編號
        string sAnum = "";
        string sBnum = "";
        int iTotalCountSet = _blAction.BindValueCount(sAction_No, "value1", sStage);//單場報名'組數'
        int iTotalCountWaitSet = _blAction.BindTotalCount_WaitSet(sAction_No, sStage, "候補");//單場報名'候補組數'
        int iTotalCountPeople = _blAction.BindTotalCount_people(sAction_No, "value2", "value1", sStage);//單場報名總'人數'        

        if (iTotalCountPeople > 120)
        {
            //場次下拉選單註解維'1'表示滿額
            UPDwang_action_ParameterItems("store_438", sStage);
            
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('這個場次，正取額滿且備取額滿囉');</script>");
            return;
        }        
        else if (iTotalCountPeople > 100 && iTotalCountPeople<120)
        {
            sAnum = "A" + (iTotalCountWaitSet + 1).ToString() + "候補";
            sBnum = "B" + (iTotalCountWaitSet + 1).ToString() + "候補";
        }
        else
        {
            sAnum = "A" + (iTotalCountSet + 1).ToString();
            if (rbSum.SelectedItem.Value == "2")//有兩個人報名
            {
                sBnum = "B" + (iTotalCountSet + 1).ToString();
            }
        }


        //生日資料轉換
        string birthday1 = "";
        birthday1 = ddlYear1.Text.ToString() + "/" + ddlMonth1.Text.ToString() + "/" + ddlDay1.Text.ToString();
        string birthday2 = "";
        birthday2 = ddlYear2.Text.ToString() + "/" + ddlMonth2.Text.ToString() + "/" + ddlDay2.Text.ToString();


        //暫存場地&編號
        Session["438_iName_in1"] = txtName1.Text.ToString().Trim();
        Session["438_sStage_in1"] = sStage;//場次
        Session["438_sStageH_in1"] = sStageH;//場次連結
        Session["438_A_in1"] = sAnum;//編號A
        Session["438_B_in1"] = sBnum;//編號B

        

        //記名子直接寫進資料庫++++++++++++++++++++++++++++++++++++++++++++++++
        string sError = "";
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", Public.strP_Ename));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("email", txtEmail1.Text.ToString().Trim()));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", sStage)); //場次
        sb.Append(s.ParamXML("value2", rbSum.SelectedValue.ToString().Trim()));//人數
        sb.Append(s.ParamXML("value3", sStageH));//網址

        sb.Append(s.ParamXML("value4", txtName1.Text.ToString().Trim()));
        sb.Append(s.ParamXML("value5", txtPhone1.Text.ToString().Trim()));
        sb.Append(s.ParamXML("value6", birthday1));
        sb.Append(s.ParamXML("value7", sAnum));//編號A

        if (rbSum.SelectedItem.Value == "2")//有兩個人報名
        {
            sb.Append(s.ParamXML("value8", txtName2.Text.ToString().Trim()));
            sb.Append(s.ParamXML("value9", txtPhone2.Text.ToString().Trim()));
            sb.Append(s.ParamXML("value10", birthday2));
            sb.Append(s.ParamXML("value11", sBnum));//編號B
        }

        sb.Append("</insert>");
        sb.Append("</sql>");
        try
        {
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        }
        catch (Exception exp)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
            return;
        }
        #endregion

                
       
        #region 頁面轉換
        if (sAnum.ToLower().IndexOf("候補") == -1)//成功頁面
        {
            SendMail(txtEmail1.Text.ToString().Trim(), txtName1.Text.ToString().Trim(), sAnum, sBnum, sStage, sStageH);
            Response.Redirect("login_ok.aspx");
        }
        else//候補頁面
        {
            SendMail(txtEmail1.Text.ToString());
            Response.Redirect("login_waiting.aspx");
        }
        #endregion
    }






    // 寄送mail通知(報成功)===========================================================
    //收參數:收信地址、寄給誰、信件夾帶內容參數
    private void SendMail(string sToEmail, string sToName, string sToNo1, string sToNo2, string sStore, string sSoreAddress)
    {
        if ( rbSum.SelectedItem.Value == "2")
            sToNo2 = "，" + sToNo2;
               

        //[手動更改確認信函內容]
        string sTitle = "";
        string sBody = "";
        string sMail = "<a href=mailto:" + sToEmail + ">" + sToEmail + "</a>";
        XmlDocument XmlDoc = new XmlDocument();
        XmlNode oNode;
        if (File.Exists(Server.MapPath("mail_ok.xml")))//[設定mail檔案!!!]
        {
            XmlDoc.Load(Server.MapPath("mail_ok.xml"));//[設定mail檔案!!!]
            oNode = XmlDoc.SelectSingleNode("//郵件主旨");
            if (oNode != null) sTitle = oNode.InnerText;
            oNode = XmlDoc.SelectSingleNode("//郵件內容");
            if (oNode != null)
            {
                //[在這邊設定要夾帶的參數!!!]
                sBody = oNode.InnerText;
                sBody = sBody.Replace("((sToName))", sToName);
                sBody = sBody.Replace("((sToNo1))", sToNo1);
                sBody = sBody.Replace("((sToNo2))", sToNo2);
                sBody = sBody.Replace("((sStore))", sStore);
                sBody = sBody.Replace("((sSoreAddress))", sSoreAddress);                
            }
        }

        MailMessage mail = new MailMessage();
        mail.From = "\"藝奇\"<service@ikki.com.tw>"; ;
        mail.To = sToEmail;
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

    // 寄送mail通知(候補)=============================================================
    private void SendMail(string sToEmail)
    {
        //[手動更改確認信函內容]
        string sTitle = "";
        string sBody = "";
        string sMail = "<a href=mailto:" + sToEmail + ">" + sToEmail + "</a>";
        XmlDocument XmlDoc = new XmlDocument();
        XmlNode oNode;
        if (File.Exists(Server.MapPath("mail_waiting.xml")))//[設定mail檔案!!!]
        {
            XmlDoc.Load(Server.MapPath("mail_waiting.xml"));//[設定mail檔案!!!]
            oNode = XmlDoc.SelectSingleNode("//郵件主旨");
            if (oNode != null) sTitle = oNode.InnerText;
            oNode = XmlDoc.SelectSingleNode("//郵件內容");
            if (oNode != null)
            {
                //[在這邊設定要夾帶的參數!!!]
                sBody = oNode.InnerText;
            }
        }

        MailMessage mail = new MailMessage();
        mail.From = "\"藝奇\"<service@ikki.com.tw>"; ;
        mail.To = sToEmail;
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



    //更新[dbo].[wang_action_ParameterItems]============================================   
    public void UPDwang_action_ParameterItems(string sTypeID, string sItemName)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<update>");
        sb.Append("<table><![CDATA[[wang_action_ParameterItems]]]></table>");
        sb.Append(s.ParamXML("PValue2", "1"));
        sb.Append("<where field=\"PTypeID\"><![CDATA[" + sTypeID + "]]></where>");
        sb.Append("<where field=\"PItemName\"><![CDATA[" + sItemName + "]]></where>");
        sb.Append("</update>");
        sb.Append("</sql>");
        string sError = "";

        try
        {
            s.Cmd2DS(s.ConnStr.website, sb.ToString(), out sError);
        }
        catch (Exception ex)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('新增失敗!!請洽系統管理員~');</script>");
            return;
        }
    }
 }
