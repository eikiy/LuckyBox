using System;
using System.Web.UI;
using System.Text;
using System.Data;
using System.Web.UI.WebControls;
using System.Security.Cryptography;

//�S��u��
public class Tools
{
	#region �@�ΰѼ�
    public Tools()
	{
		// TODO: �b���[�J�غc�禡���{���X		
	}
	#endregion
		

    #region REG_script���ͤp����
    public static void REG_script(Page page, string strScript)
    {
        page.ClientScript.RegisterStartupScript(page.GetType(), Guid.NewGuid().ToString(), strScript);
    }
    #endregion

	
	#region Time out���~�B�z
    public void CheckSession(System.Web.UI.Page webForm)
    {
        if (webForm.Session["user_Uid"] == null)
        {
            webForm.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('Time out �Э��s�n�J�t��');</script>");
            webForm.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>window.location.href='Default.aspx';</script>");
        }
    }
    #endregion


    #region �r��MD5�[�K
    public string ADDMD5(string sStr)
    {
        string sReturnStr = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(sStr, "md5").ToLower();//��MD5�X
        //string Md5PassWord = System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(YSCode, "MD5");//��MD5�X
        return sReturnStr;
    }
    #endregion




    #region �r��DES�[�K
    public string ADDDES(string sStr)
    {
        string original = sStr;//�n�Q�[�K���r��
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



    #region  guid�ϥΦ~���ɤ���@��
    public string CreateGUID()
    {
        //1.2 ����e�~  
        string sY = System.DateTime.Now.Year.ToString();
        //1.3 ����e��  
        string sM = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
        //1.4 ����e��  
        string sD = System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        // 1.5 ����e��  
        string sHH = System.DateTime.Now.Hour.ToString();
        // 1.6 ����e��  
        string sSS = System.DateTime.Now.Minute.ToString();
        // 1.7 ����e��  
        string sSSS = System.DateTime.Now.Second.ToString();
        // 1.8 ����e�@��  
        string sSSSS = System.DateTime.Now.Millisecond.ToString();

        string sDate = sY + sM + sD + sHH + sSS + sSSS + sSSSS;
        string sGUID = "";
        sGUID = (sDate + (Guid.NewGuid().ToString().Replace("-", ""))).Substring(0, 40);

        return sGUID;
    }

    public string CreateGUID(int iLengh)
    {
        //1.2 ����e�~  
        string sY = System.DateTime.Now.Year.ToString();
        //1.3 ����e��  

        string sM = System.DateTime.Now.Month.ToString().PadLeft(2, '0');
        //1.4 ����e��  
        string sD = System.DateTime.Now.Day.ToString().PadLeft(2, '0');
        // 1.5 ����e��  
        string sHH = System.DateTime.Now.Hour.ToString().PadLeft(2, '0');
        // 1.6 ����e��  
        string sSS = System.DateTime.Now.Minute.ToString();
        // 1.7 ����e��  
        string sSSS = System.DateTime.Now.Second.ToString();
        // 1.8 ����e�@��  
        string sSSSS = System.DateTime.Now.Millisecond.ToString();

        string sDate = sY + sM + sD + sHH + sSS + sSSS + sSSSS;
        string sGUID = "";
        sGUID = (sDate + (Guid.NewGuid().ToString().Replace("-", ""))).Substring(0, iLengh);

        return sGUID;
    }

    public string CreateGUID_Aid()//���ʥ�:104 12 04 11962 29342 4
    {
        Random crandom = new Random();
        Random crandom2 = new Random();
        decimal drandom = crandom.Next(10000000) + crandom2.Next(100000000);
        decimal drandomUid = decimal.Parse(DateTime.Now.ToString("MMddHHmmssfff")) + drandom;
        string sChineseYear = (DateTime.Now.Year - 1911).ToString();
        string snewUid = (sChineseYear + drandomUid.ToString().Trim() + drandom.ToString()).Substring(0, 18);

        return snewUid;
    }

    public string CreateGUID_CareerUid()//�[�J�|����:
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
    
	
	
	#region ���ͤU�Ԧ~
    //���ͤU�Ԧ~
    public static void BindYear(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("�п��", ""));
        intTmp = intS_Year - 1 + 1911;
        ddl.Items.Add(new ListItem(string.Format("{0}�H�e(����{1}�~�e)", intS_Year - 1 + 1911, intS_Year - 1), intTmp.ToString()));
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            ddl.Items.Add(new ListItem(string.Format("{0}(����{1}�~)", i + 1911, i), intTmp.ToString()));
        }
    }
    //���ͤU�Ԧ~(�L�������)
    public static void BindYear2(DropDownList ddl, int intS_Year)
    {
        int intTmp;
        ddl.Items.Clear();
        ddl.Items.Add(new ListItem("�п��", ""));
        intTmp = intS_Year - 1 + 1911;
        //ddl.Items.Add(new ListItem(string.Format("{0}�H�e(����{1}�~�e)", intS_Year - 1 + 1911, intS_Year - 1), intTmp.ToString()));
        for (int i = intS_Year; i <= DateTime.Now.Year - 1911; i++)
        {
            intTmp = i + 1911;
            //ddl.Items.Add(new ListItem(string.Format("{0}(����{1}�~)", i + 1911, i), intTmp.ToString()));
            ddl.Items.Add(new ListItem(string.Format("{0}", i + 1911, i), intTmp.ToString()));
        }
    }
    #endregion
	
	
    //098177*************************************************************************************************//	 
	

}