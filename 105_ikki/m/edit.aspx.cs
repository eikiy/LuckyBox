using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (Session[CareerNo + "_email_s"] == null || Session[CareerNo + "_email_s"].ToString() == "")
        {
            Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='login.aspx';</script>");
            Response.End();
        }

        if (!IsPostBack)
        {
            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            string Email = Session[CareerNo + "_email_s"].ToString();
            string strHtml = "";
            decimal Uid;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MemberData");
            dt = wow.Wow_GetMemberData(CareerNo, Email);
            Uid = Convert.ToDecimal(dt.Rows[0]["Uid"].ToString());
            if (dt.Rows[0]["Name"].ToString() != "")
            {
                name.Value = dt.Rows[0]["Name"].ToString();
            }

            if (dt.Rows[0]["PetName"].ToString() != "")
            {
                nickname.Value = dt.Rows[0]["PetName"].ToString();
            }

            if (dt.Rows[0]["Email"].ToString() != "")
            {
                email.Value = dt.Rows[0]["Email"].ToString();
            }
            if (dt.Rows[0]["Marry"].ToString() != "")
            {
                string[] marray_array = string.Format("{0:yyyy\\/M\\/d}", System.Convert.ToDateTime(dt.Rows[0]["Marry"].ToString())).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                hide_year2.Value = marray_array[0];
                hide_month2.Value = marray_array[1];
                hide_day2.Value = marray_array[2];
            }


            if (dt.Rows[0]["Pwd"].ToString() != "")
            {
                LitePwd.Text = "<input name=\"pwd\" type=\"password\" id=\"pwd\" style=\"width:150px; height:20px; border:none;\" maxlength=\"8\" value=\"\" />";
                LiteChkPwd.Text = "<input name=\"chk_pwd\" type=\"password\" id=\"chk_pwd\" style=\"width:180px; height:20px; border:none;\" maxlength=\"8\" value=\"\" />";
            }

            if (dt.Rows[0]["City"].ToString() != "")
            {
                ds = wow.Wow_BindCity();
                strHtml = "";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["no"].ToString().Trim() == dt.Rows[0]["City"].ToString())
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

            if (dt.Rows[0]["Zipcode"].ToString() != "")
            {
                ds = wow.Wow_BindCity2Area(dt.Rows[0]["City"].ToString());
                strHtml = "";
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    if (ds.Tables[0].Rows[i]["zip"].ToString().Trim() == dt.Rows[0]["Zipcode"].ToString())
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


            if (dt.Rows[0]["Address"].ToString() != "")
            {
                address.Value = dt.Rows[0]["Address"].ToString();
            }

            if (dt.Rows[0]["CellPhone"].ToString() != "")
            {
                mobile.Value = dt.Rows[0]["CellPhone"].ToString();
            }

            if (dt.Rows[0]["Phone_No"].ToString() != "")
            {
                phone1.Value = dt.Rows[0]["Phone_Area"].ToString();
                phone2.Value = dt.Rows[0]["Phone_No"].ToString();
                phone3.Value = dt.Rows[0]["Phone_Ext"].ToString();
            }

            if (dt.Rows[0]["Edm"].ToString() == "0")
            {
                strHtml = "<div class=\"checkbox1\"><a href=\"javascript:change_checkbox('v1', 'x1');\"><img id=\"v1\" src=\"images/v-2.png\" width=\"21\" height=\"24\" border=\"0\"></a></div>";
                strHtml += "<div class=\"checkbox2\"><a href=\"javascript:change_checkbox('x1', 'v1');\"><img id=\"x1\" src=\"images/x.png\" width=\"21\" height=\"24\" border=\"0\"></a></div><input id=\"edm1\" name=\"edm1\" type=\"hidden\" value=\"v1\">";
            }

            if (dt.Rows[0]["Edm"].ToString() == "1")
            {
                strHtml = "<div class=\"checkbox1\"><a href=\"javascript:change_checkbox('v1', 'x1');\"><img id=\"v1\" src=\"images/v.png\" width=\"21\" height=\"24\" border=\"0\"></a></div>";
                strHtml += "<div class=\"checkbox2\"><a href=\"javascript:change_checkbox('x1', 'v1');\"><img id=\"x1\" src=\"images/x-2.png\" width=\"21\" height=\"24\" border=\"0\"></a></div><input id=\"edm1\" name=\"edm1\" type=\"hidden\" value=\"x1\">";
            }
            LiteEdm1.Text = strHtml;
            strHtml = "";
            //Response.Write(dt.Rows[0]["AllCareerMail"].ToString());
            if (dt.Rows[0]["AllCareerMail"].ToString() == "1")
            {
                strHtml = "<div class=\"checkbox1\"><a href=\"javascript:change_checkbox2('v2', 'x2');\"><img id=\"v2\" src=\"images/v-2.png\" width=\"21\" height=\"24\" border=\"0\"></a></div>";
                strHtml += "<div class=\"checkbox2\"><a href=\"javascript:change_checkbox2('x2', 'v2');\"><img id=\"x2\" src=\"images/x.png\" width=\"21\" height=\"24\" border=\"0\"></a></div><input id=\"edm2\" name=\"edm2\" type=\"hidden\" value=\"v2\">";
            }

            if (dt.Rows[0]["AllCareerMail"].ToString() == "0")
            {
                strHtml = "<div class=\"checkbox1\"><a href=\"javascript:change_checkbox2('v2', 'x2');\"><img id=\"v2\" src=\"images/v.png\" width=\"21\" height=\"24\" border=\"0\"></a></div>";
                strHtml += "<div class=\"checkbox2\"><a href=\"javascript:change_checkbox2('x2', 'v2');\"><img id=\"x2\" src=\"images/x-2.png\" width=\"21\" height=\"24\" border=\"0\"></a></div><input id=\"edm2\" name=\"edm2\" type=\"hidden\" value=\"x2\">";
            }
            LiteEdm2.Text = strHtml;
        }
        
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (IsPostBack)
        {
            //檢查來源
            if (Request.UrlReferrer.ToString() != System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "m/edit.aspx")
            {
                Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='register.aspx';</script>");
                Response.End();
            }

            if (Request.Form["name"] == null || Request.Form["nickname"] == null || Request.Form["email"].ToString() == "" || Request.Form["city"] == null || Request.Form["zipcode"] == null || Request.Form["pwd"] == null)
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='edit.aspx';</script>");
                Response.End();
            }
			
			if(Request.Form["mobile"] == null && (Request.Form["phone1"] == null || Request.Form["phone2"] == null))
			{
				Response.Write("<script language=javascript>alert('手機或電話至少填寫一項,請重新輸入!!');location.href='edit.aspx';</script>");
                Response.End();
			}

            if (Request.Form["name"].ToString() == "" || Request.Form["nickname"].ToString() == "" || Request.Form["email"].ToString() == "" || Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || Request.Form["pwd"].ToString() == "")
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='edit.aspx';</script>");
                Response.End();
            }
			if (Request.Form["mobile"].ToString() == "" && (Request.Form["phone1"].ToString() == "" || Request.Form["phone2"].ToString() == ""))
			{
				Response.Write("<script language=javascript>alert('手機或電話至少填寫一項,請重新輸入!!');location.href='edit.aspx';</script>");
                Response.End();
			}
					

            string marryday = "";
            int edm = 0;
            int allCareerMail = 0;
            string tMsg = "";
            string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "m/edit_success.aspx";
            decimal Uid;
            string Email = Session[CareerNo + "_email_s"].ToString();

            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            DataTable dt = new DataTable("MemberData");
            dt = wow.Wow_GetMemberData(CareerNo, Email);
            Uid = Convert.ToDecimal(dt.Rows[0]["Uid"].ToString());

            check_input new_word = new check_input();

            if (Request.Form["year2"].ToString() != "" && Request.Form["month2"].ToString() != "" && Request.Form["day2"].ToString() != "")
            {
                marryday = Request.Form["year2"].ToString() + "/" + Request.Form["month2"].ToString() + "/" + Request.Form["day2"].ToString();
                try
                {
                    Convert.ToDateTime(marryday);
                }
                catch (Exception ex)
                {
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('edit.aspx');</script>");
                    Response.End();
                }
            }

            //資料驗證
            string Name = new_word.doCheck_Input(Request.Form["name"].ToString(), 50);
            string PetName = new_word.doCheck_Input(Request.Form["nickname"].ToString(), 50);
            Email = new_word.doCheck_Input(Request.Form["email"].ToString(), 100);
            string Pwd = new_word.doCheck_Input(Request.Form["pwd"].ToString(), 50);
            string Marry = new_word.doCheck_Input(marryday, 10);
            string City = new_word.doCheck_Input(Request.Form["city"].ToString(), 50);
            string Zipcode = new_word.doCheck_Input(Request.Form["zipcode"].ToString(), 50);
            string Address = new_word.doCheck_Input(Request.Form["address"].ToString(), 50);
            string CellPhone = new_word.doCheck_Input(Request.Form["mobile"].ToString(), 50);
            string Phone1 = new_word.doCheck_Input(Request.Form["phone1"].ToString(), 3);
            string Phone2 = new_word.doCheck_Input(Request.Form["phone2"].ToString(), 10);
            string Phone3 = new_word.doCheck_Input(Request.Form["phone3"].ToString(), 10);

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



            DataSet ds = new DataSet();

            ds = new DataSet();
            DataTable dt2 = new DataTable("MemberData");
            ds.Tables.Add(dt2);
            dt2.Columns.Add("Uid", typeof(decimal));
            dt2.Columns.Add("Name", typeof(String));
            dt2.Columns.Add("PetName", typeof(String));
            dt2.Columns.Add("Email", typeof(String));
            dt2.Columns.Add("Pwd", typeof(String));
            dt2.Columns.Add("Marry", typeof(System.DateTime));
            dt2.Columns.Add("City", typeof(String));
            dt2.Columns.Add("Zipcode", typeof(String));
            dt2.Columns.Add("Address", typeof(String));
            dt2.Columns.Add("CellPhone", typeof(String));
            dt2.Columns.Add("Phone_Area", typeof(String));
            dt2.Columns.Add("Phone_No", typeof(String));
            dt2.Columns.Add("Phone_Ext", typeof(String));
            dt2.Columns.Add("Edm", typeof(int));
            dt2.Columns.Add("AllCareerMail", typeof(String));

            DataRow dr = dt2.NewRow();
            dr["Uid"] = Uid;
            dr["Name"] = Name;
            dr["PetName"] = PetName;
            dr["Email"] = Email;
            dr["Pwd"] = Pwd;

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
            dr["Phone_Area"] = Phone1;
            dr["Phone_No"] = Phone2;
            dr["Phone_Ext"] = Phone3;

            dr["Edm"] = edm;
            dr["AllCareerMail"] = allCareerMail.ToString();
            dt2.Rows.Add(dr);

            /*Response.Write("Uid:" + dt2.Rows[0]["Uid"].ToString() + "<br>");
            Response.Write("name:" + dt2.Rows[0]["Name"].ToString() + "<br>");
            Response.Write("PetName:" + dt2.Rows[0]["PetName"].ToString() + "<br>");
            Response.Write("Email:" + dt2.Rows[0]["Email"].ToString() + "<br>");
            Response.Write("Pwd:" + dt2.Rows[0]["Pwd"].ToString() + "<br>");
            Response.Write("Marry:" + dt2.Rows[0]["Marry"].ToString() + "<br>");
            Response.Write("Zipcode:" + dt2.Rows[0]["Zipcode"].ToString() + "<br>");
            Response.Write("Address:" + dt2.Rows[0]["Address"].ToString() + "<br>");
            Response.Write("CellPhone:" + dt2.Rows[0]["CellPhone"].ToString() + "<br>");
            Response.Write("Phone_Area:" + dt2.Rows[0]["Phone_Area"].ToString() + "<br>");
            Response.Write("Phone_No:" + dt2.Rows[0]["Phone_No"].ToString() + "<br>");
            Response.Write("Phone_Ext:" + dt2.Rows[0]["Phone_Ext"].ToString() + "<br>");
            Response.Write("Edm:" + dt2.Rows[0]["Edm"].ToString() + "<br>");
            Response.Write("AllCareerMail:" + dt2.Rows[0]["AllCareerMail"].ToString() + "<br>");*/

            int res = wow.Wow_MemberModify(out tMsg, CareerNo, dt2, WebSiteUrl);
            if (res == 0)
            {
                Session[CareerNo + "_name_s"] = Name;
                if (Email != Session[CareerNo + "_email_s"].ToString())
                {
                    Session[CareerNo + "_email_s"] = Email;
                    Response.Write("<script language=javascript>location.href='edit_ok.aspx?t=1';</script>");
                    Response.End();
                }
                else
                {
                    Session[CareerNo + "_email_s"] = Email;
                    Response.Write("<script language=javascript>location.href='edit_ok.aspx?t=2';</script>");
                    Response.End();
                }

            }
            else
            {
                Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='edit.aspx';</script>");
                Response.End();
            }
        }
    }
}