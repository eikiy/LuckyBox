using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_voucher : System.Web.UI.Page
{
    public string msg = string.Empty;   // "listwithsn", "detail"
    private string act = string.Empty;
    private string url = "http://cct.wowprime.com/cct/cctws/API/Voucher";
    private string app_secret = "aol71fde473739e4506acf127b0417f9a32f";
    //private string url = "http://192.168.4.1:8080/cct/cctws/API/Voucher";
    //private string app_secret = "66666666666666666666666666666666666";
    private string careerno = "103";
    private string uid = string.Empty;
    private string mobileno = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        act = Request["act"];
        uid = Request["uid"];
        mobileno = Request["mobileno"];

        switch (act)
        {
            case "listwithsn":
                msg = GetList();
                break;
            case "detail":
                msg = GetDetail(Request["vocr_id"]);        // vocr_id = 175c135b-abde-4c14-95af-a9dc2c295b0e
                //msg = GetDetail("175c135b-abde-4c14-95af-a9dc2c295b0e");
                break;
        }
    }

    private string GetList()
    {
        var wc = new WebClient();
        wc.QueryString.Add("act", act);
        wc.QueryString.Add("app_secret", app_secret);
        wc.QueryString.Add("careerno", careerno);
        wc.QueryString.Add("uid", uid);
        wc.QueryString.Add("mobileno", mobileno);
        var response = wc.UploadValues(url, "POST", wc.QueryString);
        return Encoding.UTF8.GetString(response);
    }

    private string GetDetail(string vocr_id)
    {
        var wc = new WebClient();
        wc.QueryString.Add("act", act);
        wc.QueryString.Add("app_secret", app_secret);
        wc.QueryString.Add("careerno", careerno);
        wc.QueryString.Add("uid", uid);
        wc.QueryString.Add("mobileno", mobileno);
        wc.QueryString.Add("vocr_id", vocr_id);
        var response = wc.UploadValues(url, "POST", wc.QueryString);
        return Encoding.UTF8.GetString(response);
    }
}