using System;
using System.Web.UI;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

//特殊工具
public class Tools
{
	#region 共用參數
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


    #region 字串MD5加密
    public string ADDMD5(string sStr)
    {
        string sReturnStr = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sStr, "md5").ToLower();//轉MD5碼
        //string Md5PassWord = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(YSCode, "MD5");//轉MD5碼
        return sReturnStr;
    }
    #endregion




    #region 字串DES加密
    public string ADDDES(string sStr)
    {
        string original = sStr;//要被加密的字串
        string key = "abcdefgh";
        string iv = "12345678";

        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
        des.Key = Encoding.ASCII.GetBytes(key);
        des.IV = Encoding.ASCII.GetBytes(iv);
        byte[] s = Encoding.ASCII.GetBytes(original);
        ICryptoTransform desencrypt = des.CreateEncryptor();
        return BitConverter.ToString(desencrypt.TransformFinalBlock(s, 0, s.Length)).Replace("-", string.Empty);  
    }
    #endregion



    #region  guid使用年月日時分秒毫秒
    public string CreateGUID()
    {
        //1.2 取當前年  
        string sY = System.DateTime.Now.Year.ToString();
        //1.3 取當前月  
        string sM = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
        //1.4 取當前日  
        string sD = System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        // 1.5 取當前時  
        string sHH = System.DateTime.Now.Hour.ToString();
        // 1.6 取當前分  
        string sSS = System.DateTime.Now.Minute.ToString();
        // 1.7 取當前秒  
        string sSSS = System.DateTime.Now.Second.ToString();
        // 1.8 取當前毫秒  
        string sSSSS = System.DateTime.Now.Millisecond.ToString();

        string sDate = sY + sM + sD + sHH + sSS + sSSS + sSSSS;
        string sGUID = "";
        sGUID = (sDate + (Guid.NewGuid().ToString().Replace("-", ""))).Substring(0, 40);

        return sGUID;
    }

    public string CreateGUID(int iLengh)
    {
        //1.2 取當前年  
        string sY = System.DateTime.Now.Year.ToString();
        //1.3 取當前月  

        string sM = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
        //1.4 取當前日  
        string sD = System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        // 1.5 取當前時  
        string sHH = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
        // 1.6 取當前分  
        string sSS = System.DateTime.Now.Minute.ToString();
        // 1.7 取當前秒  
        string sSSS = System.DateTime.Now.Second.ToString();
        // 1.8 取當前毫秒  
        string sSSSS = System.DateTime.Now.Millisecond.ToString();

        string sDate = sY + sM + sD + sHH + sSS + sSSS + sSSSS;
        string sGUID = "";
        sGUID = (sDate + (Guid.NewGuid().ToString().Replace("-", ""))).Substring(0, iLengh);

        return sGUID;
    }

    public string CreateGUID_Aid()//活動用:104 12 04 11962 29342 4
    {
        Random crandom = new Random();
        Random crandom2 = new Random();
        decimal drandom = crandom.Next(10000000) + crandom2.Next(100000000);
        decimal drandomUid = decimal.Parse(DateTime.Now.ToString("MMddHHmmssfff")) + drandom;
        string sChineseYear = (DateTime.Now.Year - 1911).ToString();
        string snewUid = (sChineseYear + drandomUid.ToString().Trim() + drandom.ToString()).Substring(0, 18);

        return snewUid;
    }

    public string CreateGUID_CareerUid()//加入會員用:
    {
        Random crandom = new Random();
        Random crandom2 = new Random();
        decimal drandom = crandom.Next(10000) + crandom2.Next(10000);
        decimal drandomUid = decimal.Parse(DateTime.Now.ToString("MMddHHmmssfff")) + drandom;
        string sChineseYear = (DateTime.Now.Year - 1911).ToString();
        string snewUid = ((Public.strP_ShopNo + sChineseYear) + drandomUid.ToString().Trim() + drandom.ToString()).Substring(0, 18);
        return snewUid;
    }



    #endregion
    
	
	
	#region 產生下拉年
    //產生下拉年
    public static void BindYear(DropDownList ddl, int intS_Year)
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
    //產生下拉年(無民國顯示)
    public static void BindYear2(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("請選擇", ""));
        intTmp = intS_Year - 1 + 1911;
        //ddl.Items.Add(new ListItem(string.Format("{0}以前(民國{1}年前)", intS_Year - 1 + 1911, intS_Year - 1), intTmp.ToString()));
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            //ddl.Items.Add(new ListItem(string.Format("{0}(民國{1}年)", i + 1911, i), intTmp.ToString()));
            ddl.Items.Add(new ListItem(string.Format("{0}", i + 1911, i), intTmp.ToString()));
        }
    }
    #endregion
	
	
    //098177*************************************************************************************************//	 
	

}