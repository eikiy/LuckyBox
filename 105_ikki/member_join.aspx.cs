using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_join : System.Web.UI.Page
{
    wowapi.Website2API wow = new wowapi.Website2API();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

        }
    }

    protected void Page_PreRenderComplete(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
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
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];

        if (name.Text == null || nickname.Text == null || email.Text == null || year1.SelectedValue == null || month1.SelectedValue == null || day1.SelectedValue == null || Request.Form["city"] == null || Request.Form["zipcode"] == null || pwd.Text == null || code.Text == null)
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='member_join.aspx';</script>");
            Response.End();
        }

        if (name.Text == "" || nickname.Text == "" || email.Text == "" || year1.SelectedValue == "" || month1.SelectedValue == "" || day1.SelectedValue == "" || Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || pwd.Text == "" || code.Text == "")
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='member_join.aspx';</script>");
            Response.End();
        }

        //檢查驗証碼
        if (Session["Valid"] == null)
        {
            Response.Write("<script language=javascript>alert(\"驗證碼錯誤!!\");location.replace('member_join.aspx');</script>");
            Response.End();
        }

        if (Session["Valid"] != null && code.Text.ToString().ToLower() != Session["Valid"].ToString().ToLower())
        {
            Response.Write("<script language=javascript>alert(\"驗證碼錯誤!!\");location.replace('member_join.aspx');</script>");
            Response.End();
        }

        string birthday = "";
        string marryday = "";
        string ip = "";
        int edm = 0;
        int allCareerMail = 0;
        string tMsg = "";
        string Source = "P";
        string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "register_success.aspx";
        check_input new_word = new check_input();

        birthday = year1.Text.ToString() + "/" + month1.Text.ToString() + "/" + day1.Text.ToString();
        if (year2.Text.ToString() != "" && month2.Text.ToString() != "" && day2.Text.ToString() != "")
        {
            marryday = year2.Text.ToString() + "/" + month2.Text.ToString() + "/" + day2.Text.ToString();
            try
            {
                Convert.ToDateTime(marryday);
            }
            catch (Exception ex)
            {
                Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('member_join.aspx');</script>");
                Response.End();
            }
        }

        //資料驗證
        string Name = new_word.doCheck_Input(name.Text.ToString(), 50);
        string PetName = new_word.doCheck_Input(nickname.Text.ToString(), 50);
        string Email = new_word.doCheck_Input(email.Text.ToString(), 100);
        string Pwd = new_word.doCheck_Input(pwd.Text.ToString(), 50);
        string Gender = new_word.doCheck_Input(Request.Form["sex"].ToString(), 5);
        string Birth = new_word.doCheck_Input(birthday, 10);
        string Marry = new_word.doCheck_Input(marryday, 10);
        string City = new_word.doCheck_Input(Request.Form["city"].ToString(), 50);
        string Zipcode = new_word.doCheck_Input(Request.Form["zipcode"].ToString(), 50);
        string Address = new_word.doCheck_Input(address.Text.ToString(), 50);
        string CellPhone = new_word.doCheck_Input(mobile.Text.ToString(), 50);
        string Store = new_word.doCheck_Input(Request.Form["store"].ToString(), 20);
        string Times = new_word.doCheck_Input(times.SelectedValue.ToString(), 10);
        string Job = new_word.doCheck_Input(job.SelectedValue.ToString(), 20);
        string Education = new_word.doCheck_Input(education.SelectedValue.ToString(), 20);

        try
        {
            Convert.ToDateTime(birthday);
        }
        catch (Exception ex)
        {
            Response.Write("<script language=javascript>alert(\"[生日日期]不正確,請重新選擇!!\");location.replace('member_join.aspx');</script>");
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

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        int res = wow.Wow_MemberJoin(out tMsg, CareerNo, dt, Source, WebSiteUrl);
        if (res == 0)
        {
            //事業處代碼 + session 名稱
            Session[CareerNo + "_name_s"] = Name;
            Session[CareerNo + "_email_s"] = Email;

            Response.Redirect("member_ok.aspx");
            Response.End();
        }
        else
        {
            Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='member_join.aspx';</script>");
            Response.End();
        }

        
    }
}