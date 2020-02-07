using System;
using System.Collections.Generic;
using System.Web;
using System.IO;
using System.Configuration;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;

/// <summary>
/// 輸入資料檢查
/// </summary>
public class check_input
{

    #region 手機格式檢查不符合的話回傳false
    public static bool CheckPhone(string strPhone)
    {
        if (strPhone != string.Empty && !Regex.IsMatch(strPhone, "^[0-9]{4}[0-9]{6}$"))
            return false;
        else
            return true;
    }
    #endregion


    #region EMail格式檢查不符合的話回傳false
    public static bool CheckEMail(string strEMail)
    {
        if (Regex.IsMatch(strEMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$") == false)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    #endregion


    #region 檢查中文姓名要中文字，不符合的話回傳false
    public static bool CheckChineseName(string strChinese)
    {

        bool bresult = true;
        int dRange = 0;
        int dstringmax = Convert.ToInt32("9fff", 16);
        int dstringmin = Convert.ToInt32("4e00", 16);

        for (int i = 0; i < strChinese.Length; i++)
        {

            dRange = Convert.ToInt32(Convert.ToChar(strChinese.Substring(i, 1)));

            if (dRange >= dstringmin && dRange < dstringmax)
            {
                bresult = true;
                break;
            }

            else
            {
                bresult = false;
            }
        }

        return bresult;
    }
    #endregion


    #region 檢查FB連結要有facebook，不符合的話回傳false
    public static bool CheckFBlink(string strFBlink)
    {
        return !(strFBlink.ToLower().IndexOf("facebook") == -1);
    }
    #endregion


    #region 檢查日期格式是否正確，不符合回傳false
    public bool ValidDate(string sDate)
    {
        if (sDate == "") return true;

        try
        {
            DateTime.Parse(sDate);
        }
        catch
        {
            return false;
        }
        return true;
    }
    #endregion


    #region 檢查統一發票號碼，不符合回傳false
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
    #endregion

    //098177*************************************************************************************************//

    
    
    public string doCheck_Input(string code, int num)
	{
        //Email若有下列關鍵字則會無法導頁，故mark下列
        //string[] word = new string[] { "and", "exec", "insert", "select", "delete", "update", "count", "*", "truncate", "declare", "script", "--", "'", "alert"};
        //for (int i = 0; i < word.Length; i++)
        //{
        //   code = code.Replace(word[i], "");
        //}

        //if (code.Length > num)
        //{
        //    code = code.Substring(0, num);
        //}
        //code = HttpUtility.HtmlEncode(code);

        return code;
	}
}