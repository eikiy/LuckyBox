using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

using System.Xml;
using System.IO;
using System.Web.Mail;

using System.Text.RegularExpressions;

public partial class e_member_application_inforation : System.Web.UI.Page
{
    Crm2WebMember.Crm2WebMember crm = new Crm2WebMember.Crm2WebMember();
    Website2API.Website2API wow = new Website2API.Website2API();
    blAction _blAction = new blAction();

    DataSet DS_member;
    string sType;
    


    protected void Page_Load(object sender, EventArgs e)
    {
        Page.MaintainScrollPositionOnPostBack = true;

        if (!IsPostBack)
        {
            #region 驗證頁面順序
            if (Session["DS_member"] == null)//暫存???
                Response.Redirect("index.aspx");//第一頁???
            #endregion

        
            #region 判斷手機還是電腦
            string u = Request.ServerVariables["HTTP_USER_AGENT"];
            Regex b = new Regex(@"android.+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(di|rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);

            if ((b.IsMatch(u) || v.IsMatch(u.Substring(0, 4))))//手機板---------------------------------
            {
                //imgcode.Height = 100;//驗證碼欄位控制
            }
            else//電腦版---------------------------------------------------------------------------------
            {

            }
            #endregion


            sType = Session["DS_type"].ToString().Trim();
            DS_member = (DataSet)Session["DS_member"];

            if (sType == "websiteMember")//建立網路會員資料
            {
                Bind_websiteMember();
            }

            if (sType == "CrmMember")//建立舊白金會員資料
            {
                Bind_CrmMember();
            }
       }

    }


    //建立頁面會員資料:參考網路會員============================================================
    private void Bind_websiteMember()
    {
        #region 姓　　名
        if (DS_member.Tables[0].Rows[0]["姓名"].ToString() != "")
        {
            name.Text = DS_member.Tables[0].Rows[0]["姓名"].ToString();
        }
        #endregion

        #region 性別
        if (DS_member.Tables[0].Rows[0]["性別"].ToString() == "男")
        {
            RadioButtonList_Gender.SelectedValue = "M";
        }
        if (DS_member.Tables[0].Rows[0]["性別"].ToString() == "女")
        {
            RadioButtonList_Gender.SelectedValue = "F";
        }
        #endregion


        #region 生　　日
        try
        {
            Convert.ToDateTime(DS_member.Tables[0].Rows[0]["生日"].ToString());
            if (DS_member.Tables[0].Rows[0]["生日"].ToString() != "")
            {
                birthday.Text = DateTime.Parse(DS_member.Tables[0].Rows[0]["生日"].ToString()).ToString("yyyy/MM/dd");
            }

        }
        catch
        {
        }
        #endregion

        #region 手　　機
        if (DS_member.Tables[0].Rows[0]["手機"].ToString() != "")
        {
            mobile.Text = DS_member.Tables[0].Rows[0]["手機"].ToString();
        }
        #endregion

        #region 地    址
        DataSet ds = new DataSet();
        string strHtml = "";

        //縣市---------------------------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["縣市"].ToString() != "")
        {
            ds = wow.Wow_BindCity();
            strHtml = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["no"].ToString().Trim() == DS_member.Tables[0].Rows[0]["縣市"].ToString())
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["no"].ToString().Trim() + "\" selected>" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
                else
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["no"].ToString().Trim() + "\">" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
            }
            LiteCity.Text = strHtml;

        }


        //郵遞區號---------------------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["郵遞區號"].ToString() != "")
        {
            ds = wow.Wow_BindCity2Area(DS_member.Tables[0].Rows[0]["縣市"].ToString());
            strHtml = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["zip"].ToString().Trim() == DS_member.Tables[0].Rows[0]["郵遞區號"].ToString())
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["zip"].ToString().Trim() + "\" selected>" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
                else
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["zip"].ToString().Trim() + "\">" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
            }
            LiteZipcode.Text = strHtml;
        }



        //街道路名---------------------------------------------------------------------------------------------
        //(只是建立下拉選單)
        ds = wow.Wow_BindCity3Street(DS_member.Tables[0].Rows[0]["郵遞區號"].ToString());
        strHtml = "";
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
                strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["StreetNo"].ToString().Trim() + "\">" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";

        }
        LitersSreet.Text = strHtml;
     






        //地址------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["地址"].ToString() != "")
        {
            address.Text = DS_member.Tables[0].Rows[0]["地址"].ToString().Trim();
        }
        #endregion

        #region 結婚紀念日
        /*
        try
        {
            Convert.ToDateTime(DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString());
            if (DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString() != "")
            {
                marryday.Text = DateTime.Parse(DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString()).ToString("yyyy/MM/dd");
            }

        }
        catch
        {
        }
        */

        if (DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString() != "")
        {
            string[] marray_array = string.Format("{0:yyyy\\/M\\/d}", System.Convert.ToDateTime(DS_member.Tables[0].Rows[0]["結婚紀念日"].ToString())).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            hide_year2.Value = marray_array[0];
            hide_month2.Value = marray_array[1];
            hide_day2.Value = marray_array[2];
        }



        #endregion

        #region email
        Panelemail.Visible = false;//網路會員不能編輯email，所以不顯示
        if (DS_member.Tables[0].Rows[0]["email"].ToString() != "")
        {
            email.Text = DS_member.Tables[0].Rows[0]["email"].ToString();
        }
        #endregion

        #region 密碼
        Panelpwd.Visible = false;//網路會員不能編輯密碼，所以不顯示
        if (DS_member.Tables[0].Rows[0]["password"].ToString() != "")
        {
            pwd.Text = DS_member.Tables[0].Rows[0]["password"].ToString();
        }
        #endregion
    }

    //建立頁面會員資料:參考舊白金crm===========================================================
    private void Bind_CrmMember()
    {
        year2.Visible = false;

        #region 姓　　名
        if (DS_member.Tables[0].Rows[0]["CName"].ToString() != "")
        {
            name.Text = DS_member.Tables[0].Rows[0]["CName"].ToString();
        }
        #endregion

        #region 性別
        if (DS_member.Tables[0].Rows[0]["Gender"].ToString() == "M")
        {
            RadioButtonList_Gender.SelectedValue = "M";
        }
        if (DS_member.Tables[0].Rows[0]["Gender"].ToString() == "F")
        {
            RadioButtonList_Gender.SelectedValue = "F";
        }
        #endregion

        #region 生　　日
        try
        {
            Convert.ToDateTime(DS_member.Tables[0].Rows[0]["BirDate"].ToString());
            if (DS_member.Tables[0].Rows[0]["BirDate"].ToString() != "")
            {
                birthday.Text = DateTime.Parse(DS_member.Tables[0].Rows[0]["BirDate"].ToString()).ToString("yyyy/MM/dd");
            }
        }
        catch
        {
        }
        #endregion

        #region 手　　機
        if (DS_member.Tables[0].Rows[0]["MobileNo"].ToString() != "")
        {
            mobile.Text = DS_member.Tables[0].Rows[0]["MobileNo"].ToString();
        }
        #endregion

        #region 詳細地址
        DataSet ds = new DataSet();
        string strHtml = "";

        //縣市---------------------------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["CodCity"].ToString() != "")
        {
            ds = wow.Wow_BindCity();
            strHtml = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["no"].ToString().Trim() == DS_member.Tables[0].Rows[0]["CodCity"].ToString())
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["no"].ToString().Trim() + "\" selected>" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
                else
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["no"].ToString().Trim() + "\">" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
            }
            LiteCity.Text = strHtml;

        }


        //郵遞區號---------------------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["ZipCode"].ToString() != "")
        {
            ds = wow.Wow_BindCity2Area(DS_member.Tables[0].Rows[0]["CodCity"].ToString());
            strHtml = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["zip"].ToString().Trim() == DS_member.Tables[0].Rows[0]["ZipCode"].ToString())
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["zip"].ToString().Trim() + "\" selected>" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
                else
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["zip"].ToString().Trim() + "\">" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
            }
            LiteZipcode.Text = strHtml;
        }


        //街道路名---------------------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["CodStreet"].ToString() != "")
        {
            ds = wow.Wow_BindCity3Street(DS_member.Tables[0].Rows[0]["ZipCode"].ToString());
            strHtml = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                if (ds.Tables[0].Rows[i]["StreetNo"].ToString().Trim() == DS_member.Tables[0].Rows[0]["CodStreet"].ToString())
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["StreetNo"].ToString().Trim() + "\" selected>" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
                else
                {
                    strHtml += "<option value=\"" + ds.Tables[0].Rows[i]["StreetNo"].ToString().Trim() + "\">" + ds.Tables[0].Rows[i]["name"].ToString().Trim() + "</option>";
                }
            }
            LitersSreet.Text = strHtml;
        }


        //地址------------------------------------------------------------------------------
        if (DS_member.Tables[0].Rows[0]["Address"].ToString() != "")
        {
            address.Text = DS_member.Tables[0].Rows[0]["Address"].ToString().Trim();
        }
        #endregion

        #region 結婚紀念日
        /*
        try
        {
            Convert.ToDateTime(DS_member.Tables[0].Rows[0]["MerryDate"].ToString());
            if (DS_member.Tables[0].Rows[0]["MerryDate"].ToString() != "")
            {
                marryday.Text = DateTime.Parse(DS_member.Tables[0].Rows[0]["MerryDate"].ToString()).ToString("yyyy/MM/dd");
            }

        }
        catch
        {
        }
        */


        if (DS_member.Tables[0].Rows[0]["MerryDate"].ToString() != "")
        {
            string[] marray_array = string.Format("{0:yyyy\\/M\\/d}", System.Convert.ToDateTime(DS_member.Tables[0].Rows[0]["MerryDate"].ToString())).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            hide_year2.Value = marray_array[0];
            hide_month2.Value = marray_array[1];
            hide_day2.Value = marray_array[2];
        }


        #endregion

        #region email
        if (DS_member.Tables[0].Rows[0]["email"].ToString() != "")
        {
            email.Text = DS_member.Tables[0].Rows[0]["email"].ToString();
        }
        #endregion
    }


    //確認資料送出=============================================================================
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        sType = Session["DS_type"].ToString().Trim();


        #region 資料完整性
        if (name.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [姓　　名]');</script>");
            return;
        }

        if (birthday.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [生　　日]');</script>");
            return;
        }
        if (mobile.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [手　　機]');</script>");
            return;
        }

        if (Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || Request.Form["street"].ToString() == "" || address.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [詳細地址]');</script>");
            return;
        }

        if (email.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [e-mail]');</script>");
            return;
        }

        if (pwd.Text.ToString().Trim() == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('請輸入 [密碼]');</script>");
            return;
        }
        #endregion

        #region 日期格式檢查
        if (birthday.Text != "")
        {
            try
            {
                Convert.ToDateTime(birthday.Text);
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert(\"[生日日期]不正確,請重新選擇!!\");location.replace('inforation.aspx');</script>");
                Response.End();
            }
        }

        /*
        if (marryday.Text != "")
        {
            try
            {
                Convert.ToDateTime(marryday.Text);
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('inforation.aspx');</script>");
                Response.End();
            }
        }
         * */
        #endregion



        #region 檢查驗證碼----------------------------------------------------------------------------------------
        if (Session["Valid"] != null && txtCode.Value.ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            return;
        }
        #endregion



        string sCustID = "";
        if (Session["DS_type"].ToString().Trim() == "CrmMember")//建立舊白金會員資料
        {
            DS_member = (DataSet)Session["DS_member"];
            sCustID = DS_member.Tables[0].Rows[0]["CustID"].ToString();
        }



        string s_marryday_YMD = "";
        string s_marryday_MD  = "";

        #region 網路會員資料
        if (sType == "websiteMember")
        {
            if (Request.Form["year2"].ToString() != "" && Request.Form["month2"].ToString() != "" && Request.Form["day2"].ToString() != "")
            {
                s_marryday_YMD = Request.Form["year2"].ToString() + "/" + Request.Form["month2"].ToString().PadLeft(2, '0') + "/" + Request.Form["day2"].ToString().PadLeft(2, '0');
                try
                {
                    Convert.ToDateTime(s_marryday_YMD);
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('memberEdit.aspx');</script>");
                    Response.End();
                }
            }


            if (Request.Form["month2"].ToString() != "" && Request.Form["day2"].ToString() != "")
            {
                s_marryday_MD = Request.Form["month2"].ToString().PadLeft(2, '0') + "/" + Request.Form["day2"].ToString().PadLeft(2, '0');
                try
                {
                    Convert.ToDateTime(s_marryday_MD);
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('memberEdit.aspx');</script>");
                    Response.End();
                }
            }
        }
         #endregion
       
        #region 白金會員
        if (sType == "CrmMember")//建立舊白金會員資料
        {
            if (Request.Form["month2"].ToString() != "" && Request.Form["day2"].ToString() != "")
            {
                s_marryday_YMD = "1911/" + Request.Form["month2"].ToString().PadLeft(2, '0') + "/" + Request.Form["day2"].ToString().PadLeft(2, '0');
                try
                {
                    Convert.ToDateTime(s_marryday_YMD);
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('memberEdit.aspx');</script>");
                    Response.End();
                }
            }


            if (Request.Form["month2"].ToString() != "" && Request.Form["day2"].ToString() != "")
            {
                s_marryday_MD = Request.Form["month2"].ToString().PadLeft(2, '0') + "/" + Request.Form["day2"].ToString().PadLeft(2, '0');
                try
                {
                    Convert.ToDateTime(s_marryday_MD);
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('memberEdit.aspx');</script>");
                    Response.End();
                }
            }
        }
        #endregion

        bool returnbool = crm.CrmMemberUpdateProject_2016(name.Text
                                                      , mobile.Text
                                                      , Request.Form["zipcode"].ToString()
                                                      , Request.Form["city"].ToString()
                                                      , Request.Form["street"].ToString()
                                                      , address.Text
                                                      , birthday.Text
                                                      , s_marryday_YMD
                                                      , s_marryday_MD                                                      
                                                      , email.Text.Trim()
                                                      , pwd.Text.Trim()
                                                      , RadioButtonList_Gender.SelectedValue.ToString()
                                                       , sCustID);
        if (!returnbool)//sp執行不順利
        {
            Response.Write("<script language=javascript>alert(\"資料更新錯誤!!\");location.replace('inforation.aspx');</script>");
            Response.End();
        }
        else            //sp執行順利
        {
            string sErrorCrm = "";
            DataSet DS_NOmemberCrm = new DataSet();
            DS_NOmemberCrm = _blAction.Sel_noMembers_GetMemberData_mail(Public.strP_ShopNo, email.Text, out sErrorCrm);
            
            
            if (DS_NOmemberCrm.Tables[0].Rows.Count > 0)//有找到為認證資料，要寄送認證信
            {
                string snd=DS_NOmemberCrm.Tables[0].Rows[0]["啟動編號"].ToString().Trim();
                string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "e_member/coupon/index.aspx";//認證頁
                string sLink = "<a href=" + WebSiteUrl + "?sid=" + snd.Trim() + ">" + WebSiteUrl + "?sid=" + snd.Trim() + "</a>";

                SendEmail(email.Text, sLink);


                //刪除暫存
                Session.Remove("DS_type");
                Session.Remove("DS_member");

                //下一頁
                Session["name"] = name.Text;
                Session["email"] = email.Text;
                Session["pwd"] = pwd.Text;
                Response.Redirect("success2.aspx");
            }
        }




        //刪除暫存
        Session.Remove("DS_type");
        Session.Remove("DS_member");

        //下一頁
        Session["name"] = name.Text;
        Session["email"] = email.Text;
        Session["pwd"] = pwd.Text;
        Response.Redirect("success.aspx");
    }






    private void SendEmail(string email, string url)
    {
        //發送Mail
        //手動更改確認信函內容
        string Email = email;
        string sTitle = "歡迎加入王品網路會員";
        string sBody = "";
        string sMail = "<a href=mailto:" + email.Trim() + ">" + email.Trim() + "</a>";
        XmlDocument XmlDoc = new XmlDocument();
        XmlNode oNode;
        if (File.Exists(Server.MapPath("../mailXML/2016_Reward.xml")))
        {
            XmlDoc.Load(Server.MapPath("../mailXML/2016_Reward.xml"));
            oNode = XmlDoc.SelectSingleNode("//郵件主旨");
            if (oNode != null) sTitle = oNode.InnerText;
            oNode = XmlDoc.SelectSingleNode("//郵件內容");
            if (oNode != null)
            {
                sBody = oNode.InnerText;
                sBody = sBody.Replace("((member_email))", email.Trim());//email
                sBody = sBody.Replace("((member_url))", url.Trim());//url
            }
        }
        // Mail 相關屬性設定
        try
        {
            MailMessage mail = new MailMessage();
            mail.From = "\"王品\"service@wangsteak.com.tw";
            mail.To = Email;
            mail.Subject = sTitle;
            mail.Body = sBody;
            mail.BodyFormat = MailFormat.Html;
            SmtpMail.SmtpServer = "192.168.2.1";
            SmtpMail.Send(mail);
        }
        catch (System.Exception Err)
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('送出失敗!!請洽系統管理員~');</script>");
            return;
        }
    }



    //輸出年月日================================================================================================================
    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            int y = 0;
            //輸出年
            year2.Items.Add(new ListItem("1951(民國40年前)", "1951"));
            for (int i = 1952; i <= System.Convert.ToInt16(DateTime.Now.Year.ToString()); i++)
            {
                y = i - 1911;
                year2.Items.Add(new ListItem(i.ToString() + "(民國" + y.ToString() + "年)", i.ToString()));
            }

            //輸出月
            for (int i = 1; i <= 12; i++)
            {
                month2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日
            for (int i = 1; i <= 31; i++)
            {
                day2.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //取得資料，建立結婚日期
            year2.SelectedValue = hide_year2.Value;
            month2.SelectedValue = hide_month2.Value;
            day2.SelectedValue = hide_day2.Value;
        }
    }
}
