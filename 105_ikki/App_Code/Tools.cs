using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Text;
using System.Web.Mail;
using System.IO;
using System.Drawing;

/// <summary>
/// Tools 的摘要描述
/// </summary>
public class Tools
{
    
    #region 共用參數
    Sql s = new Sql();
    public Tools()
    {
        // TODO: 在此加入建構函式的程式碼		
    }
    #endregion

    #region REG_script產生小視窗
    public static void REG_script(Page page, string strScript)
    {
        page.ClientScript.RegisterStartupScript(page.GetType(), Guid.NewGuid().ToString(), strScript);
    }
    #endregion

    #region Time out錯誤處理
    public void CheckSession(System.Web.UI.Page webForm)
    {
        if (webForm.Session["user_Uid"] == null)
        {
            webForm.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Time out 請重新登入系統');</script>");
            webForm.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='Default.aspx';</script>");
        }
    }
    #endregion


    #region 產生下拉年
    //西元年============================================================
    public static void BindYear(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("請選擇", ""));
        intTmp = intS_Year - 1 + 1911;
        ddl.Items.Add(intTmp.ToString());
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            ddl.Items.Add(new ListItem(intTmp.ToString()));
        }
    }
    //民國年============================================================
    public static void BindChineseYear(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("請選擇", ""));
        intTmp = intS_Year - 1 + 1911;
        ddl.Items.Add(new ListItem(string.Format("{0}以前(民國{1}年前)", intS_Year - 1 + 1911, intS_Year - 1), intTmp.ToString()));
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            ddl.Items.Add(new ListItem(string.Format("{0}(民國{1}年)", i + 1911, i), intTmp.ToString()));
        }
    }
    #endregion



    //098177*************************************************************************************************//


    public string SmtpServer = "192.168.2.1";



























    public string UploadFilePath(System.Web.UI.Page webForm)
    {
        return webForm.Server.MapPath("~/AttachFiles");
    }

    public bool SendMail(string from, string to, string subject, string body, string SmtpServer)
    {
        bool bReturn = true;
        SmtpMail.SmtpServer = SmtpServer;
        MailMessage mail = new MailMessage();
        mail.BodyEncoding = Encoding.GetEncoding("big5");

        mail.From = from;
        mail.To = to;
        mail.Subject = subject;
        mail.Body = body;
        mail.BodyFormat = MailFormat.Html;

        try
        {
            SmtpMail.Send(mail);
        }
        catch
        {
            bReturn = false;
        }
        return bReturn;
    }
    public bool SendMail(string from, string to, string subject, string body, string SmtpServer, string encoding)
    {
        bool bReturn = true;
        SmtpMail.SmtpServer = SmtpServer;
        MailMessage mail = new MailMessage();
        if (encoding == "big5")
            mail.BodyEncoding = Encoding.GetEncoding("big5");
        else
            mail.BodyEncoding = Encoding.UTF8;

        mail.From = from;
        mail.To = to;
        mail.Subject = subject;
        mail.Body = body;
        mail.BodyFormat = MailFormat.Html;

        try
        {
            SmtpMail.Send(mail);
        }
        catch
        {
            bReturn = false;
        }
        return bReturn;
    }

    public bool CheckIdNo(string PID)
    {
        string sPID = PID.ToUpper();
        bool bChk = true;
        string ALP_STR = "ABCDEFGHJKLMNPQRSTUVXYWZIO";
        string NUM_STR = "0123456789";
        int iPIDLen = sPID.Length;
        int iChkNum = 0;
        if (iPIDLen != 10)
        {
            bChk = false;
        }
        else
        {
            string sChk = ALP_STR + NUM_STR;
            for (int i = 0; i < iPIDLen; i++)
            {
                if (sChk.IndexOf(sPID.Substring(i, 1)) == -1)
                {
                    bChk = false;
                    break;
                }
            }
        }

        if (bChk)
        {
            iChkNum = ALP_STR.IndexOf(sPID.Substring(0, 1));
            if (iChkNum == -1)
            {

                bChk = false;
            }
            else
            {
                iChkNum += 10;
                if ((sPID.IndexOf("1") != 1) && (sPID.IndexOf("2") != 1))
                {
                    bChk = false;
                }
            }
        }

        if (bChk)
        {
            iChkNum = (int)Math.Floor((decimal)iChkNum / 10) + (iChkNum % 10 * 9);
            for (int i = 1; i < iPIDLen - 1; i++)
            {
                iChkNum += Convert.ToInt16(sPID.Substring(i, 1)) * (9 - i);
            }

            int iLastNum = Convert.ToInt16(sPID.Substring(9, 1)) * 1;
            iChkNum += iLastNum;

            if ((iChkNum % 10) != 0)
            {
                bChk = false;
                for (int i = 0; i < 10; i++)
                {
                    int xRightAlpNum = iChkNum - iLastNum + i;
                    if ((xRightAlpNum % 10) == 0)
                    {

                    }
                }
            }
        }

        return bChk;
    }

    public bool CheckSalesNo(string No)
    {//檢查統一發票號碼
        string sNo = No.ToUpper();
        //bool bReturn=false;
        if (sNo.Length != 10 && sNo.Length != 14)
            return false;
        if (sNo.Length == 10)
        {
            if (65 > Convert.ToChar(sNo.Substring(0, 1)) || 90 < Convert.ToChar(sNo.Substring(0, 1)))
                return false;
            if (65 > Convert.ToChar(sNo.Substring(1, 1)) || 90 < Convert.ToChar(sNo.Substring(1, 1)))
                return false;
            for (int k = 2; k < 10; k++)
            {
                if (48 > Convert.ToChar(sNo.Substring(k, 1)) || 57 < Convert.ToChar(sNo.Substring(k, 1)))
                    return false;
            }
        }

        if (sNo.Length == 14)
        {
            for (int k = 0; k < 14; k++)
            {
                if (48 > Convert.ToChar(sNo.Substring(k, 1)) || 57 < Convert.ToChar(sNo.Substring(k, 1)))
                    return false;
            }
        }
        return true;
    }

    public bool CheckStoreNo(string No)
    {//檢查統一編號號碼
        string sNo = No;
        //bool bReturn=false;
        if (sNo.Length != 8)
            return false;
        for (int k = 0; k < 8; k++)
        {
            if (48 > Convert.ToChar(sNo.Substring(k, 1)) || 57 < Convert.ToChar(sNo.Substring(k, 1)))
                return false;
        }
        int[] aiNo = new int[8];
        int iWt;
        for (int k = 0; k < 8; k++)
            aiNo[k] = Convert.ToChar(sNo.Substring(k, 1)) - 48;

        iWt = aiNo[0] + aiNo[2] + aiNo[4] + aiNo[7];
        aiNo[1] = aiNo[1] * 2;
        aiNo[1] = (int)(aiNo[1] / 10) + aiNo[1] % 10;
        aiNo[3] = aiNo[3] * 2;
        aiNo[3] = (int)(aiNo[3] / 10) + aiNo[3] % 10;
        aiNo[5] = aiNo[5] * 2;
        aiNo[5] = (int)(aiNo[5] / 10) + aiNo[5] % 10;
        aiNo[6] = aiNo[6] * 4;
        aiNo[6] = (int)(aiNo[6] / 10) + aiNo[6] % 10;
        iWt = iWt + aiNo[1] + aiNo[3] + aiNo[5] + aiNo[6];
        if ((iWt % 10) == 0)
            return true;
        else
        {
            if (sNo.Substring(6, 1) == "7")
            {
                iWt = iWt - aiNo[6] + (int)(aiNo[6] / 10);
                if ((iWt % 10) == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        return false;
    }

    public string GetMaxId(string sKeyWord)
    {
        string sReturn = "";
        string sBit = "0000000000000000000000000000";
        string xmlString = "<sql><sp>"
            + "<Max>"
            + "<sp_name>UpdateMaxId</sp_name>"
            + "<param name=\"@word\" type=\"string\"><![CDATA[" + sKeyWord + "]]></param>"
            + "</Max>"
            + "</sp></sql>";
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.messages, xmlString, out sError);
        if (DS.Tables["Max"].Rows.Count > 0)
        {
            sReturn += DS.Tables["Max"].Rows[0]["head"].ToString().Trim();
            sBit = sBit.Substring(0, Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_idbit"].ToString().Trim()));
            if (DS.Tables["Max"].Rows[0]["no_year"].ToString().Trim() != "0")
                sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_year"].ToString().Trim()).ToString("0000");
            if (DS.Tables["Max"].Rows[0]["no_month"].ToString().Trim() != "0")
                sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_month"].ToString().Trim()).ToString("00");
            if (DS.Tables["Max"].Rows[0]["no_day"].ToString().Trim() != "0")
                sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_day"].ToString().Trim()).ToString("00");
            sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["max_id"].ToString().Trim()).ToString(sBit);
        }
        return sReturn;
    }

    public string GetMaxIdStore(string sKeyWord, string sStoreNo)
    {
        string sReturn = "";
        string sBit = "0000000000000000000000000000";
        string xmlString = "<sql><sp>"
            + "<Max>"
            + "<sp_name>UpdateMaxIdStore</sp_name>"
            + "<param name=\"@word\" type=\"string\"><![CDATA[" + sKeyWord + "]]></param>"
            + "<param name=\"@storeno\" type=\"string\"><![CDATA[" + sStoreNo + "]]></param>"
            + "</Max>"
            + "</sp></sql>";
        string sError = "";
        DataSet DS = s.Cmd2DS(s.ConnStr.messages, xmlString, out sError);
        if (DS.Tables["Max"].Rows.Count > 0)
        {
            sReturn += DS.Tables["Max"].Rows[0]["head"].ToString().Trim();
            sBit = sBit.Substring(0, Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_idbit"].ToString().Trim()));
            if (DS.Tables["Max"].Rows[0]["no_year"].ToString().Trim() != "0")
                sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_year"].ToString().Trim()).ToString("0000");
            if (DS.Tables["Max"].Rows[0]["no_month"].ToString().Trim() != "0")
                sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_month"].ToString().Trim()).ToString("00");
            if (DS.Tables["Max"].Rows[0]["no_day"].ToString().Trim() != "0")
                sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["no_day"].ToString().Trim()).ToString("00");
            sReturn += Convert.ToInt16(DS.Tables["Max"].Rows[0]["max_id"].ToString().Trim()).ToString(sBit);
        }
        return sReturn;
    }

    public string GetTimeId()
    {
        string sSN = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString("00") + DateTime.Today.Day.ToString("00") + DateTime.Now.Hour.ToString("00") + DateTime.Now.Minute.ToString("00") + DateTime.Now.Second.ToString("00") + DateTime.Now.Millisecond.ToString("000");
        return sSN;
    }

    public string GetHashId(string ID)
    {
        Random rnd = new Random();
        string sID = ShaHash(rnd.Next(1, 99999).ToString(), ID);
        return sID;
    }

    private string ShaHash(string StreamID, string Password)
    {
        Encoding ENCODING = Encoding.UTF8;
        SHA1 sha = SHA1.Create();
        byte[] hash = sha.ComputeHash(ENCODING.GetBytes(StreamID + Password));
        return HexString(hash);
    }
    private string HexString(byte[] buf)
    {
        StringBuilder sb = new StringBuilder();
        foreach (byte b in buf)
        {
            sb.Append(b.ToString("x2"));
        }
        return sb.ToString();
    }



    public int Str2Int(string str)
    {
        int i = 0;
        if (str != "") i = Convert.ToInt32(str);
        return i;
    }

    public double Str2Double(string str)
    {
        double d = 0;
        if (str != "") d = Convert.ToDouble(str);
        return d;
    }

    public string CheckDate(string date)
    {
        if (date == "") return "";
        DateTime dChech = DateTime.Parse("1900/1/1");
        string sReturn = DateTime.Parse(date).ToShortDateString().Trim();
        if (DateTime.Compare(dChech, DateTime.Parse(sReturn)) == 0)
            return "";
        //if(sReturn=="1900/1/1")
        //sReturn = "";
        return sReturn;
    }



    public string cWeekDay(string strDate)
    {
        string strWeekDay = "";
        try
        {
            DateTime.Parse(strDate);
        }
        catch (Exception exp)
        {
            return strWeekDay;
        }
        switch (Convert.ToDateTime(strDate).DayOfWeek)
        {
            case System.DayOfWeek.Sunday:
                strWeekDay = "日";
                break;
            case System.DayOfWeek.Monday:
                strWeekDay = "一";
                break;
            case System.DayOfWeek.Tuesday:
                strWeekDay = "二";
                break;
            case System.DayOfWeek.Wednesday:
                strWeekDay = "三";
                break;
            case System.DayOfWeek.Thursday:
                strWeekDay = "四";
                break;
            case System.DayOfWeek.Friday:
                strWeekDay = "五";
                break;
            case System.DayOfWeek.Saturday:
                strWeekDay = "六";
                break;
        }
        return strWeekDay;
    }

    public bool UploadFile(System.Web.UI.HtmlControls.HtmlInputFile InputFile, string sDir,out string sFileName)
    {
        int imgLen1 = InputFile.PostedFile.ContentLength;
        string imgFile1 = Path.GetFileName(InputFile.PostedFile.FileName);
        imgFile1 = imgFile1.Replace("+", "_");
        imgFile1 = imgFile1.Replace("-", "_");
        imgFile1 = imgFile1.Replace("/", "_");
        imgFile1 = imgFile1.Replace("'", "_");
        imgFile1 = imgFile1.Replace("\"", "_");
        imgFile1 = imgFile1.Replace(" ", "_");
        sFileName = imgFile1;
        if (imgLen1 == 0) return false;

        //string sDir = Server.MapPath("images\\files\\") + sSn;

        try
        {
            Directory.CreateDirectory(sDir);
            InputFile.PostedFile.SaveAs(sDir + "\\" + imgFile1);
        }
        catch
        {
            return false;
        }

        return true;
    }

    public bool UploadFile(System.Web.UI.WebControls.FileUpload InputFile, string sDir, out string sFileName)
    {
        string imgFile1 = InputFile.FileName; ;
        imgFile1 = imgFile1.Replace("+", "_");
        imgFile1 = imgFile1.Replace("-", "_");
        imgFile1 = imgFile1.Replace("/", "_");
        imgFile1 = imgFile1.Replace("'", "_");
        imgFile1 = imgFile1.Replace("\"", "_");
        imgFile1 = imgFile1.Replace(" ", "_");
        sFileName = imgFile1;
        if (!InputFile.HasFile) return false;

        //string sDir = Server.MapPath("images\\files\\") + sSn;

        try
        {
            Directory.CreateDirectory(sDir);
            InputFile.SaveAs(sDir + "\\" + imgFile1);
        }
        catch
        {
            return false;
        }

        return true;
    }

    public Color ColorTrans(string col)
    {
        return System.Drawing.ColorTranslator.FromHtml(col);
    }
    public string ColorTrans(Color col)
    {
        return System.Drawing.ColorTranslator.ToHtml(col);
    }
    public string BindRN(string sStr,double dRules)
    {
       // double dRules = 32;

        if (sStr.Length <= int.Parse(dRules.ToString()))
            return sStr;

        string sReturnStr = "";
        double dStrLen = sStr.Length;
        double dLen = 0;
        dLen = Math.Ceiling(dStrLen / dRules);
        int iSubstring = int.Parse(dRules.ToString());

        for (int i = 0; i < dLen; i++)
        {
            if (i == 0)
            {
                //第一行
                sReturnStr = sReturnStr + sStr.Substring(0, int.Parse(dRules.ToString())) + "<br>";
            }
            else if (i == dLen - 1)
            {
                //最後一行
                sReturnStr = sReturnStr + sStr.Substring(iSubstring, (sStr.Length - ((int.Parse(dRules.ToString())) * i))) + "<br>";
            }
            else
            {
                //其他行         
                sReturnStr = sReturnStr + sStr.Substring(iSubstring, int.Parse(dRules.ToString())) + "<br>";
                iSubstring = (iSubstring + int.Parse(dRules.ToString()));
            }
          


        }

        return sReturnStr;

    }
}
