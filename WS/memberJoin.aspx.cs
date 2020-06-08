using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


using System.Net.Mail;
using System.Data;
using System.Text.RegularExpressions;

public partial class memberJoin : System.Web.UI.Page
{
    Website2API.Website2API wow = new Website2API.Website2API();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
        
    }


    //下拉選單資料建立-年月日==================================================================================================
    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        
            #region 判斷手機還是電腦
            string u = Request.ServerVariables["HTTP_USER_AGENT"];
            Regex b = new Regex(@"android.+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|symbian|treo|up\.(browser|link)|vodafone|wap|windows (ce|phone)|xda|xiino", RegexOptions.IgnoreCase | RegexOptions.Multiline);
            Regex v = new Regex(@"1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(di|rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-", RegexOptions.IgnoreCase | RegexOptions.Multiline);

            if ((b.IsMatch(u) || v.IsMatch(u.Substring(0, 4))))//手機板---------------------------------
            {
                code.Height = 100;//驗證碼欄位控制
            }
            else//電腦版---------------------------------------------------------------------------------
            {

            }
            #endregion

            #region 頁面顯示:店鋪下拉選單
            string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
            DataSet ds = wow.Wow_BindStore(CareerNo.ToString());
            //store.Items.Add(new ListItem("請選擇", ""));
            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    store.Items.Add(new ListItem(ds.Tables[0].Rows[i]["StoreName"].ToString().Trim(), ds.Tables[0].Rows[i]["StoreNo"].ToString().Trim()));
            //}   
            #endregion

            #region 頁面顯示:生日年月日
            //輸出年
            int y = 0;

            year1.Items.Add(new ListItem("1931(民國20年前)", "1931"));
            for (int i = 1932; i <= System.Convert.ToInt16(DateTime.Now.Year.ToString()); i++)
            {
                y = i - 1911;
                year1.Items.Add(new ListItem(i.ToString() + "(民國" + y.ToString() + "年)", i.ToString()));
            }

            //輸出月
            for (int i = 1; i <= 12; i++)
            {
                month1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }

            //輸出日
            for (int i = 1; i <= 31; i++)
            {
                day1.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
            #endregion

            #region 頁面顯示:結婚年月日
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
            #endregion
    }

    //[確認送出]按鈕==================================================================================================
    protected void Button1_Click(object sender, EventArgs e)
    {
        int res = 0;
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string Name = "";
        string Email = "";
        string tMsg = "";
        string PetName = "";
        string Pwd = "";
        string Gender = "";//性別
        string Birth = "";
        string Marry = "";
        string City = "";
        string Zipcode = "";
        string Address = "";
        string CellPhone = "";
        string Store = "";
        string Times = "";
        string Job = "";
        string Education = "";
        string birthday = "";
        string marryday = "";
        string ip = "";
        int edm = 0;//該事業處
        int allCareerMail = 0;//全集團
        string Source = "P";
        string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "memberJoinSendOk.aspx";//認證頁
        check_input new_word = new check_input();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable("MemberData");


        try
        {

            #region 檢查必填資料欄位(用這種頁面資料會異動)
            //if (name.Text == null || mobile.Text == null || nickname.Text == null || email.Text == null || year1.SelectedValue == null || month1.SelectedValue == null || day1.SelectedValue == null || Request.Form["city"] == null || Request.Form["zipcode"] == null || pwd.Text == null || code.Text == null)
            //{
            //    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('欄位未填寫完整!!');</script>");
            //    return;
            //}

            //if (name.Text == "" || mobile.Text == "" || nickname.Text == "" || email.Text == "" || year1.SelectedValue == "" || month1.SelectedValue == "" || day1.SelectedValue == "" || Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || pwd.Text == "" || code.Text == "")
            //{
            //    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('欄位未填寫完整!!');</script>");
            //    return;
            //}
            #endregion


            #region 檢查驗証碼(用這種頁面資料會異動)
            //if (Session["Valid"] == null)
            //{
            //    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            //    return;
            //}

            //if (Session["Valid"] != null && code.Text.ToString().ToLower() != Session["Valid"].ToString().ToLower())
            //{
            //    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('驗證碼錯誤!!');</script>");
            //    return;
            //}
            #endregion



            #region 生日/結婚字串串接
            //生日-------------------------------------------------------
            birthday = year1.SelectedValue.ToString() + "/" + month1.SelectedValue.ToString() + "/" + day1.SelectedValue.ToString();
            //結婚-------------------------------------------------------
            if (year2.SelectedValue.ToString() != "" && month2.SelectedValue.ToString() != "" && day2.SelectedValue.ToString() != "")
            {
                marryday = year2.SelectedValue.ToString() + "/" + month2.SelectedValue.ToString() + "/" + day2.SelectedValue.ToString();
                try
                {
                    DateTime.Parse(marryday);
                }
                catch (Exception ex)
                {
                    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[結婚日期]不正確,請重新選擇!!');</script>");
                    return;
                }
            }
            #endregion


            try
            {
                #region 資料驗證
                Name = new_word.doCheck_Input(name.Text.ToString(), 20);
                PetName = new_word.doCheck_Input(nickname.Text.ToString(), 20);
                Email = new_word.doCheck_Input(email.Text.ToString(), 100);
                Pwd = new_word.doCheck_Input(pwd.Text.ToString(), 10);
                Gender = new_word.doCheck_Input(RadioButtonList_Gender.SelectedValue.ToString(), 5);//性別
                Birth = new_word.doCheck_Input(birthday, 10);//生日
                Marry = new_word.doCheck_Input(marryday, 10);//結婚
                City = new_word.doCheck_Input(Request.Form["city"].ToString(), 2);
                Zipcode = new_word.doCheck_Input(Request.Form["zipcode"].ToString(), 5);
                Address = new_word.doCheck_Input(address.Text.ToString(), 100);
                CellPhone = new_word.doCheck_Input(mobile.Text.ToString(), 12);
                Store = new_word.doCheck_Input(Request.Form["store"].ToString(), 20);
                Times = new_word.doCheck_Input(times.SelectedValue.ToString(), 10);
                Job = new_word.doCheck_Input(job.SelectedValue.ToString(), 20);
                Education = new_word.doCheck_Input(education.SelectedValue.ToString(), 20);

                try
                {
                    //Convert.ToDateTime(birthday);
                    DateTime.Parse(birthday);
                }
                catch (Exception ex)
                {
                    this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[生日日期]不正確,請重新選擇!!');</script>");
                    return;
                }
                if (marryday.ToString() != "")
                {
                    try
                    {
                        DateTime.Parse(marryday);
                        //Convert.ToDateTime(marryday);
                    }
                    catch (Exception ex)
                    {
                        this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('[結婚日期]不正確,請重新選擇!!');</script>");
                        return;
                    }
                }
                #endregion


                #region 判所client端是否有設定代理伺服器
                try
                {
                    //if (Request.ServerVariables["HTTP_VIA"] == null)
                    //{
                    //    ip = Request.ServerVariables["REMOTE_ADDR"].ToString();//Request.ServerVariables.Get("REMOTE_ADDR")
                    //}
                    //else
                    //{
                    //    ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                    //}
                    ip = Request.ServerVariables.Get("REMOTE_ADDR");
                }
                catch (Exception ex)
                {
                    SendMail(ex.Message + "資料驗證_IP" + Email);
                    ip = Request.ServerVariables.Get("REMOTE_ADDR");
                }
                #endregion


                #region 是否願意接收廣告信?
                /******************************
                 * nomail(該事業處)     :要[0]/不要[1]
                 * allCareerMail(全集團):要[1]/不要[0]
                 * **********************************/
                if (Career.SelectedValue == "Career_yes")//有勾選
                {
                    edm = 0;//要該事業處
                }
                else if (Career.SelectedValue == "Career_no")
                {
                    edm = 1;//不要該事業處
                }

                if (Company.SelectedValue == "Company_yes")//有勾選
                {
                    allCareerMail = 1;//要全集團
                }
                else if (Company.SelectedValue == "Company_no")
                {
                    allCareerMail = 0;//不要全集團
                }

                #endregion


                #region 性別?
                if (Gender == "man")
                {
                    Gender = "男";
                }

                if (Gender == "woman")
                {
                    Gender = "女";
                }
                #endregion
            }
            catch (Exception ex)
            {
                //錯誤資料串接
                SendMail(ex.Message + "資料驗證" + Name + ";" + PetName + ";" + Email + ";" + Pwd + ";" + Gender + ";" + Birth + ";" + Marry + ";" + City + ";" + Zipcode + ";" + Address + ";" + CellPhone + ";" + Store + ";" + Times + ";" + Job + ";" + Education + ";" + allCareerMail + ";" + edm + ";" + ip);
            }

            try
            {
                ds.Tables.Add(dt);
                dt.Columns.Add("Name", typeof(String));
                dt.Columns.Add("PetName", typeof(String));
                dt.Columns.Add("Email", typeof(String));
                dt.Columns.Add("Pwd", typeof(String));
                dt.Columns.Add("Gender", typeof(String));
                dt.Columns.Add("Birth", typeof(System.DateTime));
                dt.Columns.Add("Marry", typeof(System.DateTime));
                dt.Columns.Add("City", typeof(String));
                dt.Columns.Add("Zipcode", typeof(String));
                dt.Columns.Add("Address", typeof(String));
                dt.Columns.Add("CellPhone", typeof(String));
                dt.Columns.Add("Phone_Area", typeof(String));
                dt.Columns.Add("Phone_No", typeof(String));
                dt.Columns.Add("Phone_Ext", typeof(String));
                dt.Columns.Add("Store", typeof(String));
                dt.Columns.Add("Times", typeof(int));
                dt.Columns.Add("Job", typeof(String));
                dt.Columns.Add("Education", typeof(String));
                dt.Columns.Add("IP", typeof(String));
                dt.Columns.Add("Edm", typeof(int));
                dt.Columns.Add("AllCareerMail", typeof(String));

                DataRow dr = dt.NewRow();
                dr["name"] = Name;
                dr["PetName"] = PetName;
                dr["Email"] = Email;
                dr["Pwd"] = Pwd;
                dr["Gender"] = Gender;
                dr["Birth"] = DateTime.Parse(birthday);//Convert.ToDateTime(birthday);

                if (marryday != "")
                {
                    dr["Marry"] = DateTime.Parse(marryday);//Convert.ToDateTime(marryday);
                }
                else
                {
                    dr["Marry"] = System.DBNull.Value;
                }
                dr["City"] = City;
                dr["Zipcode"] = Zipcode;
                dr["Address"] = Address;
                dr["CellPhone"] = CellPhone;

                if (phone1.Text != "")
                {
                    dr["Phone_Area"] = new_word.doCheck_Input(phone1.Text, 3);
                }
                else
                {
                    dr["Phone_Area"] = "";
                }
                if (phone2.Text != "")
                {
                    dr["Phone_No"] = new_word.doCheck_Input(phone2.Text, 8);
                }
                else
                {
                    dr["Phone_No"] = "";
                }

                if (phone3.Text != "")
                {
                    dr["Phone_Ext"] = new_word.doCheck_Input(phone3.Text, 5);
                }
                else
                {
                    dr["Phone_Ext"] = "";
                }

                dr["Store"] = Store;
                if (Times != "")
                {
                    dr["Times"] = System.Convert.ToInt16(Times);
                }
                else
                {
                    dr["Times"] = System.DBNull.Value;
                }
                dr["Job"] = Job;
                dr["Education"] = Education;
                dr["IP"] = ip;
                dr["Edm"] = edm;
                dr["AllCareerMail"] = allCareerMail.ToString();
                dt.Rows.Add(dr);
            }
            catch (Exception ex)
            {
                SendMail(ex.Message + "資料Add至DataTable" + "Email:" + Email + "生日:" + birthday + "結婚:" + marryday);
            }
            //餵入資料:117,資料,p,http://www.putien.com.tw/register_success.aspx,
            res = wow.Wow_MemberJoin(CareerNo, dt, Source, WebSiteUrl, out tMsg);
        }
        catch (Exception ex)
        {
            SendMail(ex.Message + "儲存檔案" + Email);
        }
        if (res == 0)
        {
            //事業處代碼 + session 名稱
            Session[CareerNo + "_name_s"] = Name;
            Session[CareerNo + "_email_s"] = Email;

            Response.Redirect("memberJoinSend.aspx", false);
            //Response.End();
            HttpContext.Current.ApplicationInstance.CompleteRequest();
        }

        else
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('" + tMsg + "!!');</script>");
            return;
        }
    }

    //寄送email======================================================================================================
    private void SendMail(string errMsg)
    {
        try
        {
            MailMessage mail = new MailMessage();
            SmtpClient _SmtpClient = new SmtpClient("192.168.2.1");
            mail.From = new MailAddress(Public.strP_EMail, Public.strP_Ename + " " + "王品");
            mail.To.Add("amy.tsai@wowprime.com");
            mail.Subject = "王品加入會員失敗";
            mail.Body = errMsg + "From PC";
            mail.IsBodyHtml = true;
            _SmtpClient.Send(mail);
        }
        catch (Exception ex)
        {
        }
    }
}
