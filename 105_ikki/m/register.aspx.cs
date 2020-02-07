using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class register : System.Web.UI.Page
{
    wowapi.Website2API wow = new wowapi.Website2API();

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoServerCaching();
        Response.Cache.SetCacheability(System.Web.HttpCacheability.NoCache);
        Response.Cache.SetNoStore();
        Response.Cache.SetExpires(new DateTime(1900, 1, 1, 0, 0, 0, 0));
        Response.Expires = 0;

        if (!IsPostBack)
        {

        }
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        if (IsPostBack)
        {
            //檢查來源
            //if (Request.UrlReferrer.ToString() != System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "m/register.aspx")
            //{
            //    Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='register.aspx';</script>");
            //    Response.End();
            //}

            if (Request.Form["name"] == null || Request.Form["nickname"] == null || Request.Form["email"].ToString() == "" || Request.Form["year1"] == null || Request.Form["month1"] == null || Request.Form["day1"] == null || Request.Form["mobile"] == null || Request.Form["city"] == null || Request.Form["zipcode"] == null || Request.Form["pwd"] == null || Request.Form["code"] == null)
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='register.aspx';</script>");
                Response.End();
            }

            if (Request.Form["name"].ToString() == "" || Request.Form["nickname"].ToString() == "" || Request.Form["email"].ToString() == "" || Request.Form["year1"].ToString() == "" || Request.Form["month1"].ToString() == "" || Request.Form["day1"].ToString() == "" || Request.Form["mobile"].ToString() == "" || Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || Request.Form["pwd"].ToString() == "" || Request.Form["code"].ToString() == "")
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='register.aspx';</script>");
                Response.End();
            }

            //檢查驗証碼
            if (Session["Valid"] == null)
            {
                Response.Write("<script language=javascript>alert(\"驗證碼錯誤!!\");location.replace('register.aspx');</script>");
                Response.End();
            }

            if (Session["Valid"] != null && Request.Form["code"].ToString().ToLower() != Session["Valid"].ToString().ToLower())
            {
                Response.Write("<script language=javascript>alert(\"驗證碼錯誤!!\");location.replace('register.aspx');</script>");
                Response.End();
            }

            string birthday = "";
            string marryday = "";
            string ip = "";
            int edm = 0;
            int allCareerMail = 0;
            string tMsg = "";
            string Source = "M";
            string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "m/register_success.aspx";
            check_input new_word = new check_input();

            birthday = Request.Form["year1"].ToString() + "/" + Request.Form["month1"].ToString() + "/" + Request.Form["day1"].ToString();
            if (Request.Form["year2"].ToString() != "" && Request.Form["month2"].ToString() != "" && Request.Form["day2"].ToString() != "")
            {
                marryday = Request.Form["year2"].ToString() + "/" + Request.Form["month2"].ToString() + "/" + Request.Form["day2"].ToString();
                try
                {
                    Convert.ToDateTime(marryday);
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('register.aspx');</script>");
                    Response.End();
                }
            }

            //資料驗證
            string Name = new_word.doCheck_Input(Request.Form["name"].ToString(), 50);
            string PetName = new_word.doCheck_Input(Request.Form["nickname"].ToString(), 50);
            string Email = new_word.doCheck_Input(Request.Form["email"].ToString(), 100);
            string Pwd = new_word.doCheck_Input(Request.Form["pwd"].ToString(), 50);
            string Gender = new_word.doCheck_Input(Request.Form["sex"].ToString(), 5);
            string Birth = new_word.doCheck_Input(birthday, 10);
            string Marry = new_word.doCheck_Input(marryday, 10);
            string City = new_word.doCheck_Input(Request.Form["city"].ToString(), 50);
            string Zipcode = new_word.doCheck_Input(Request.Form["zipcode"].ToString(), 50);
            string Address = new_word.doCheck_Input(Request.Form["address"].ToString(), 50);
            string CellPhone = new_word.doCheck_Input(Request.Form["mobile"].ToString(), 50);
            string Store = new_word.doCheck_Input(Request.Form["store"].ToString(), 20);
            string Times = new_word.doCheck_Input(Request.Form["times"].ToString(), 10);
            string Job = new_word.doCheck_Input(Request.Form["job"].ToString(), 20);
            string Education = new_word.doCheck_Input(Request.Form["education"].ToString(), 20);

            try
            {
                Convert.ToDateTime(birthday);
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert(\"[生日日期]不正確,請重新選擇!!\");location.replace('register.aspx');</script>");
                Response.End();
            }




              try
        {
            //判所client端是否有設定代理伺服器
            //if (Request.ServerVariables["HTTP_VIA"] == null)
            //{
            //    ip = Request.ServerVariables["REMOTE_ADDR"].ToString();
            //}
            //else
            //{
            //    ip = Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            //}
            ip = Request.ServerVariables.Get("REMOTE_ADDR");
        }
        catch (Exception ex)
        {
            ip = Request.ServerVariables.Get("REMOTE_ADDR");
        }
            if (Request.Form["edm1"].ToString() == "v1")
            {
                edm = 0;
            }
            else
            {
                edm = 1;
            }

            if (Request.Form["edm2"].ToString() == "v2")
            {
                allCareerMail = 1;
            }
            else
            {
                allCareerMail = 0;
            }

            if (Gender == "man")
            {
                Gender = "男";
            }

            if (Gender == "woman")
            {
                Gender = "女";
            }

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MemberData");
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
            dr["Birth"] = Convert.ToDateTime(birthday);

            if (marryday != "")
            {
                dr["Marry"] = Convert.ToDateTime(marryday);
            }
            else
            {
                dr["Marry"] = System.DBNull.Value;
            }
            dr["City"] = City;
            dr["Zipcode"] = Zipcode;
            dr["Address"] = Address;
            dr["CellPhone"] = CellPhone;
            dr["Phone_Area"] = "";
            dr["Phone_No"] = "";
            dr["Phone_Ext"] = "";
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


            /*Response.Write(dr["name"] + "," +  dr["PetName"] + "," + dr["Email"] + "," + dr["Pwd"] + "," +  dr["Gender"] + "," + dr["Birth"] + "," + dr["Marry"] + "," + dr["Marry"]);
            Response.Write( dr["City"] + ", "+ dr["Zipcode"] + "," + dr["Address"] + "," + dr["CellPhone"] + "," + dr["Phone_Area"] + "," + dr["Phone_No"] + "," + dr["Phone_Ext"]+ ","+ dr["Store"]);
            Response.Write(dr["Times"] + "," + dr["Job"] + "," + dr["Education"] + "," + dr["IP"] + "," + dr["Edm"]);
             */

            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            int res = wow.Wow_MemberJoin(out tMsg, CareerNo, dt, Source, WebSiteUrl);
            if (res == 0)
            {
                //事業處代碼 + session 名稱
                Session[CareerNo + "_name_s"] = Name;
                Session[CareerNo + "_email_s"] = Email;

                Response.Redirect("register_ok.aspx");
                Response.End();
            }
            else
            {
                Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='register.aspx';</script>");
                Response.End();
            }
        }
    }
}