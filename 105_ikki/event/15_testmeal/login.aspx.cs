using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;
//mail要用
using System.Xml;
using System.IO;
using System.Web.Mail;

public partial class event_15_testmeal_login : System.Web.UI.Page
{

    #region 共用參數
    Sql s = new Sql();//資料庫的
    Public _Public = new Public();//共用的
    blAction _blAction = new blAction();//活動的
    check_input _check = new check_input();//檢查
    Tools _Tools = new Tools();
    string sAction_No = "437";//活動編號[要改]
    string sCareer = Public.strP_Ename;//事業處[要改]
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];//事業處編號
    #endregion


    string sAnum = "";
    string sBnum = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Panel1.Visible = false;//一開始不顯示第二階段資料
            BindYMD();
        }
    }


    //建立年月日下拉選單=========================================================
    private void BindYMD()
    {
        try
        {     
            //輸出年1
            Tools.BindYear(DDL_year1, 21);//???????????????????????????21
            
            
            //輸出月1
            DDL_month1.Items.Clear();
            DDL_month1.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 12; i++)
            {
                DDL_month1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日1
            DDL_day1.Items.Clear();
            DDL_day1.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 31; i++)
            {
                DDL_day1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出年2
            Tools.BindYear(DDL_year2, 21);//???????????????????????????21
            
            
            //輸出月2
            DDL_month2.Items.Clear();
            DDL_month2.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 12; i++)
            {
                DDL_month2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日2
            DDL_day2.Items.Clear();
            DDL_day2.Items.Add(new ListItem("請選擇", ""));
            for (int i = 1; i <= 31; i++)
            {
                DDL_day2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

        }
        catch (Exception ex)
        {
        }
    }
    

    //點選人數，判斷是否顯示第二塊欄位===========================================
    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (RB_sum.SelectedItem.Value == "2")
        {
            Panel1.Visible = true;
        }
        else//欄位還原
        {
            Panel1.Visible = false;
            TEX_name2.Text = "";
            TEX_phone2.Text = "";
            DDL_year2.SelectedIndex = -1;
            DDL_month2.SelectedIndex = -1;
            DDL_day2.SelectedIndex = -1;
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
        if (TEX_name1.Text.ToString().Trim() == ""){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [姓名]');</script>");
            return;
        }
        if (!check_input.CheckChineseName(TEX_name1.Text.ToString().Trim())){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[姓名]要是中文字喔');</script>");
            return;
        }


        if (TEX_fb.Text.ToString().Trim() == ""){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [FB帳號]');</script>");
            return;
        }


        if (TEX_phone1.Text.ToString().Trim() == ""){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [手機]');</script>");
            return;
        }
        if (!check_input.CheckPhone(TEX_phone1.Text.ToString().Trim())){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[手機]格式不正確喔');</script>");
            return;
        }


        if (DDL_year1.SelectedValue == "" || DDL_month1.SelectedValue == "" || DDL_day1.SelectedValue == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [出生年月日]');</script>");
            return;
        }


        if (TEX_email.Text.ToString().Trim() == ""){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [Email]');</script>");
            return;
        }
        if (!check_input.CheckEMail(TEX_email.Text.ToString().Trim())){
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[Email]格式不正確喔');</script>");
            return;
        }

        if (RB_sum.SelectedItem.Value == "2")//有兩個人報名
        {

            if (TEX_name1.Text.ToString().Trim() == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者姓名]');</script>");
                return;
            }
            if (!check_input.CheckChineseName(TEX_name1.Text.ToString().Trim()))
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[同行者姓名]要是中文字喔');</script>");
                return;
            }


            if (TEX_phone1.Text.ToString().Trim() == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者手機]');</script>");
                return;
            }
            if (!check_input.CheckPhone(TEX_phone1.Text.ToString().Trim()))
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[同行者手機]格式不正確喔');</script>");
                return;
            }


            if (DDL_year2.SelectedValue == "" || DDL_month2.SelectedValue == "" || DDL_day2.SelectedValue == "")
            {
                this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [同行者出生年月日]');</script>");
                return;
            }
        }
        #endregion


        #region 帳號參加次數控管(手機，欄位value5-報名者手機)
        //此活動一個手機(輸入的資料)只能參加一次
        string sData = "";
        sData = TEX_phone1.Text.ToString().Trim();
        
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
        sData2 = TEX_phone2.Text.ToString().Trim();
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

     /* *************************************
     * RB_stage    
     * RB_sum      
     * TEX_name1     
     * TEX_fb        
     * TEX_phone1    
     * DDL_year1   DDL_month1   DDL_day1
     * TEX_email     
     * TEX_name2    
     * TEX_phone2   
     * DDL_year2   DDL_month2   DDL_day2
     * *************************************/
        #region 寫入活動登入資料表 
        //製造廠地
        string sStage = "";
        if (RB_stage.SelectedValue == "1")
        {
            sStage ="台北敦化北店";
        }
        if (RB_stage.SelectedValue == "2")
        {
            sStage = "台中福雅店";
        }
        if (RB_stage.SelectedValue == "3")
        {
            sStage = "仁德中山店";
        }

        
        //製造編號
        int iTotalCountSet = _blAction.BindValueCount(sAction_No, "value1", sStage);//單場報名組數
        int iTotalCountPeople = _blAction.BindTotalCount_people(sAction_No, "value2", "value1", sStage);//單場報名總人數        
        
        if (iTotalCountPeople >= 40)
        {
            sAnum = "A" +"候補";
            sBnum = "B" +"候補";
        }else
        { 
            sAnum = "A" + (iTotalCountSet+1).ToString();
            if (RB_sum.SelectedItem.Value == "2")//有兩個人報名
            {
                sBnum = "B" + (iTotalCountSet + 1).ToString();
            }
        }
        

        //生日資料轉換
        string birthday1 = "";
        birthday1 = DDL_year1.Text.ToString() + "/" + DDL_month1.Text.ToString() + "/" + DDL_day1.Text.ToString();
        string birthday2 = "";
        birthday2 = DDL_year2.Text.ToString() + "/" + DDL_month2.Text.ToString() + "/" + DDL_day2.Text.ToString();
        
        
        //暫存場地&編號
        Session["437_iName_in1"] = TEX_name1.Text.ToString().Trim();
        Session["437_iRBstage_in1"] = RB_stage.SelectedValue;
        Session["437_A_in1"] = sAnum;
        Session["437_B_in1"] = sBnum;

        //記名子直接寫進資料庫++++++++++++++++++++++++++++++++++++++++++++++++
        string sError = "";
        StringBuilder sb = new StringBuilder();
        sb.Append("<sql>");
        sb.Append("<insert>");
        sb.Append("<table><![CDATA[[wang_action_members]]]></table>");
        sb.Append(s.ParamXML("Career", Public.strP_Ename));
        sb.Append(s.ParamXML("Action_NO", sAction_No));
        sb.Append(s.ParamXML("email", TEX_email.Text.ToString().Trim()));
        sb.Append(s.ParamXML("input_time", DateTime.Now));
        sb.Append(s.ParamXML("value1", sStage));
        sb.Append(s.ParamXML("value2", RB_sum.SelectedValue.ToString().Trim()));
        sb.Append(s.ParamXML("value3", TEX_fb.Text.ToString().Trim()));

        sb.Append(s.ParamXML("value4", TEX_name1.Text.ToString().Trim()));
        sb.Append(s.ParamXML("value5", TEX_phone1.Text.ToString().Trim()));
        sb.Append(s.ParamXML("value6", birthday1));
        sb.Append(s.ParamXML("value7", sAnum));//編號A

        if (RB_sum.SelectedItem.Value == "2")//有兩個人報名
        {
            sb.Append(s.ParamXML("value8", TEX_name2.Text.ToString().Trim()));
            sb.Append(s.ParamXML("value9", TEX_phone2.Text.ToString().Trim()));
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
        if (sAnum == "A候補")
        {
            SendMail(TEX_email.Text.ToString());
            Response.Redirect("login_waiting.aspx");//候補頁面
        }
        else
        {
            SendMail(TEX_email.Text.ToString().Trim(), TEX_name1.Text.ToString().Trim(), sAnum, sBnum, RB_stage.SelectedValue.ToString());
            Response.Redirect("login_ok.aspx");//成功頁面
        }
        #endregion

    }




    // 寄送mail通知(報成功)===========================================================
    //收參數:收信地址、寄給誰、信件夾帶內容參數
    private void SendMail(string sToEmail, string sToName, string sToNo1, string sToNo2, string RB_stage)
    {
        if (RB_sum.SelectedItem.Value == "2")
            sToNo2="，"+sToNo2;
        
        
        string sStageTime="";//時間 
        string sStageAddress="";//地址
        string sStageStor="";//店名
       
        if (RB_stage == "1")
        {
            sStageTime="6/16(二) 18:30~20:30 藝奇";            
            sStageAddress="http://www.ikki.com.tw/store_all.aspx?#id10501";
            sStageStor="台北敦化北店";
        }
        if (RB_stage == "2")
        {
            sStageTime="6/17(三) 18:30~20:30 藝奇";            
            sStageAddress="http://www.ikki.com.tw/store_all.aspx?#id10510";
            sStageStor="台中福雅店";
        }
        if (RB_stage == "3")
        {
            sStageTime="6/18(四) 18:30~20:30 藝奇";            
            sStageAddress="http://www.ikki.com.tw/store_all.aspx?#id10517";
            sStageStor="仁德中山店";
        }
        
        
        
        
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
                sBody = sBody.Replace("((sStageTime))", sStageTime);
                sBody = sBody.Replace("((sStageAddress))", sStageAddress);
                sBody = sBody.Replace("((sStageStor))", sStageStor);
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

}
