using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


using System.IO;
using System.Security.Cryptography;
using System.Text;


/// <summary>
/// EdenredAPIDES_class 的摘要描述
/// </summary>
public class EdenredAPIDES_class
{
	public EdenredAPIDES_class()
	{
		//
		// TODO: 在此加入建構函式的程式碼
		//
	}


    public class DES
    {
        public static string _key = "3916491410B5F364";//"0A19B744E3BB2167";
        public static string _iv =  "3916491410B5F364";// "0A19B744E3BB2167";

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="_value"></param>
        /// <param name="_key"></param>
        /// <param name="_iv"></param>
        /// <returns></returns>
        public static string EncryptDES(string _value)
        {
            try
            {
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {

                    des.Key = StringToByteArray(_key);
                    des.IV = StringToByteArray(_iv);

                    byte[] s = Encoding.UTF8.GetBytes(_value);

                    MemoryStream ms = new MemoryStream();
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(s, 0, s.Length);
                        cs.FlushFinalBlock();
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch { return _value; }
        }

        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="hexString"></param>
        /// <param name="key"></param>
        /// <param name="iv"></param>
        /// <returns></returns>
        public static string DecryptDES(string _value)
        {
            try
            {
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    des.Key = StringToByteArray(_key);
                    des.IV = StringToByteArray(_iv);

                    byte[] s = Convert.FromBase64String(_value);

                    MemoryStream ms = new MemoryStream();
                    using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(s, 0, s.Length);
                        cs.FlushFinalBlock();
                    }
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch { return _value; }
        }


        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();

        }


    }

}
