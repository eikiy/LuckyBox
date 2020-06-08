using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Data;
using System.Text.RegularExpressions;

public partial class memberForget : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        Response.Cache.SetExpires(new DateTime(1900, 1, 1, 0, 0, 0, 0));
        Response.Expires = 0;

        if (!IsPostBack)
        {
            #region 判斷手機還是電腦
            //string u = Request.ServerVariables["HTTP_USER_AGENT"];
            //Regex b = new Regex(@"android.+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            //Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(di|rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);

            //if ((b.IsMatch(u) || v.IsMatch(u.Substring(0, 4))))//手機板---------------------------------
            //{
            //    code.Height = 100;//驗證碼欄位控制
            //    code.Width = 500;
            //}
            //else//電腦版---------------------------------------------------------------------------------
            //{

            //}
            #endregion
           
            Session["page"] = "memberForget";
        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        check_input new_word = new check_input();
        Website2API.Website2API wow = new Website2API.Website2API();
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string email = new_word.doCheck_Input(txtEmail.Text.Trim(), 100);

        //檢查必填欄位--------------------------------------------------------------------------------------
        if (txtEmail.Text.Trim() == "" || code.Text.Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('欄位未填寫完整!!');</script>");
            return;
        }
        //檢查email是否存在---------------------------------------------------------------------------------
        DataTable dt = new DataTable("MemberData");
        dt = wow.Wow_GetMemberData(CareerNo, txtEmail.Text.Trim());
        if (dt == null)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('此帳號非該品牌會員喔!!');</Script>");
            return;
        }
        //檢查驗證碼----------------------------------------------------------------------------------------
        if (Session["Valid"] != null && code.Text.ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            return;
        }

        //正式區修改===============================================================================================
        int res = wow.Wow_MemberForgetPwdNoPWD(CareerNo, email, 0);
        switch (res)
        {
            case 0:
                //Response.Write("<script language=javascript>alert('您將在幾分鐘後收到一封電子郵件，\\n請啟動信中連結，重新設定密碼。');location.href='memberForget.aspx';</script>");
                this.Response.Redirect("memberForgetSend.aspx");
                Response.End();
                break;
            case 1:
                Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='memberForget.aspx';</script>");
                Response.End();
                break;
            case 2:
                Response.Write("<script language=javascript>alert('該品牌查無此 Email 帳號');location.href='memberForget.aspx';</script>");
                Response.End();
                break;
            case 3:
                Response.Write("<script language=javascript>alert('尚未啟動帳號');location.href='memberForget.aspx';</script>");
                Response.End();
                break;
        }
    }
}
