using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Drawing;

public partial class code : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string str = "";
        string code_str = "";
        code_str = CreateValidate(5);
        Random ranObj = new Random();
        string txt = ranObj.Next(1, 3).ToString();
        string bg = ranObj.Next(1, 13).ToString();

        str = "<table width=\"120\" border=\"0\" cellspacing=\"0\" cellpadding=\"0\">";
        str += "<tr>";
        str += " <td height=\"50\" align=\"center\" background=\"images/code/check_bg" + bg + ".gif\"><img src=\"images/code/" + txt + "-" + code_str.Substring(0, 1) + ".png\" width=\"19\" height=\"37\" /><img src=\"images/code/" + txt + "-" + code_str.Substring(1, 1) + ".png\" width=\"20\" height=\"37\" /><img src=\"images/code/" + txt + "-" + code_str.Substring(2, 1) + ".png\" width=\"20\" height=\"37\" /><img src=\"images/code/" + txt + "-" + code_str.Substring(3, 1) + ".png\" width=\"20\" height=\"37\" /><img src=\"images/code/" + txt + "-" + code_str.Substring(4, 1) + ".png\" width=\"20\" height=\"37\" /></td>";
        str += "</tr>";
        str += "</table>";
        LiteCode.Text = str;
    }
   
    private string CreateValidate(int count)
    {
        //定義驗證碼中所有的字元
        string allchar = "2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,p,q,r,s,t,u,w,x,y,z";
        //將驗證碼中所有的字元儲存在字串陣列中
        string[] allchararray = allchar.Split(',');
        //初始化亂數
        string randomcode = "";
        int temp = -1;
        //產生隨機物件
        Random rand = new Random();

        //根據驗證碼位數的迴圈
        for (int i = 0; i < count; i++)
        {
            //防止產生相同的驗證碼
            if (temp != -1)
            {
                //加入時間刻度
                rand = new Random(i * temp * ((int)DateTime.Now.Ticks));
            }
            int t = rand.Next(32);
            if (temp == t)
            {
                //相同的話重新再產生一次
                return CreateValidate(count);
            }
            temp = t;
            randomcode += allchararray[t];
        }

        //在Session中保存隨機驗證碼
        Session["Valid"] = randomcode;
        //傳回隨機字元
        return randomcode;
    }
}