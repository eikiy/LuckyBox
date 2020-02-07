using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class member_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (Session[CareerNo + "_email_s"] == null || Session[CareerNo + "_email_s"].ToString() == "")
        {
            Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='member_login.aspx';</script>");
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
                name.Text = dt.Rows[0]["Name"].ToString();
            }

            if (dt.Rows[0]["PetName"].ToString() != "")
            {
                nickname.Text = dt.Rows[0]["PetName"].ToString();
            }

            if (dt.Rows[0]["Email"].ToString() != "")
            {
                email.Text = dt.Rows[0]["Email"].ToString();
            }
            if (dt.Rows[0]["Marry"].ToString() != "")
            {
                string[] marray_array = string.Format("{0:yyyy\\/M\\/d}", System.Convert.ToDateTime(dt.Rows[0]["Marry"].ToString())).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                hide_year2.Value = marray_array[0];
                hide_month2.Value = marray_array[1];
                hide_day2.Value = marray_array[2];
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
                address.Text = dt.Rows[0]["Address"].ToString();
            }

            if (dt.Rows[0]["CellPhone"].ToString() != "")
            {
                mobile.Text = dt.Rows[0]["CellPhone"].ToString();
            }

            if (dt.Rows[0]["Phone_No"].ToString() != "")
            {
                phone1.Text = dt.Rows[0]["Phone_Area"].ToString();
                phone2.Text = dt.Rows[0]["Phone_No"].ToString();
                phone3.Text = dt.Rows[0]["Phone_Ext"].ToString();
            }

            if (dt.Rows[0]["Edm"].ToString() == "0")
            {
                strHtml = "<table width=\"95\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
                strHtml += "<tr>";
                strHtml += "<td width=\"23%\" style=\"border:none;\"><a href=\"javascript:change_checkbox('v1', 'x1');\"><img id=\"v1\" src=\"images/v-2.png\" border=\"0\"></a></td>";
                strHtml += "<td width=\"77%\" style=\"border:none;\"><a href=\"javascript:change_checkbox('x1', 'v1');\"><img id=\"x1\" src=\"images/x.png\" border=\"0\"></a></td>";
                strHtml += "</tr>";
                strHtml += "</table><input id=\"edm1\" name=\"edm1\" type=\"hidden\" value=\"v1\">";
            }

            if (dt.Rows[0]["Edm"].ToString() == "1")
            {
                strHtml = "<table width=\"95\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
                strHtml += "<tr>";
                strHtml += "<td width=\"23%\" style=\"border:none;\"><a href=\"javascript:change_checkbox('v1', 'x1');\"><img id=\"v1\" src=\"images/v.png\" border=\"0\"></a></td>";
                strHtml += "<td width=\"77%\" style=\"border:none;\"><a href=\"javascript:change_checkbox('x1', 'v1');\"><img id=\"x1\" src=\"images/x-2.png\" border=\"0\"></a></td>";
                strHtml += "</tr>";
                strHtml += "</table><input id=\"edm1\" name=\"edm1\" type=\"hidden\" value=\"x1\">";
            }
            LiteEdm1.Text = strHtml;
            strHtml = "";
            
            if (dt.Rows[0]["AllCareerMail"].ToString() == "1")
            {
                strHtml = "<table width=\"95\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
                strHtml += "<tr>";
                strHtml += "<td width=\"23%\" style=\"border:none;\"><a href=\"javascript:change_checkbox2('v2', 'x2');\"><img id=\"v2\" src=\"images/v-2.png\" border=\"0\"></a></td>";
                strHtml += "<td width=\"77%\" style=\"border:none;\"><a href=\"javascript:change_checkbox2('x2', 'v2');\"><img id=\"x2\" src=\"images/x.png\" border=\"0\"></a></td>";
                strHtml += "</tr>";
                strHtml += "</table><input id=\"edm2\" name=\"edm2\" type=\"hidden\" value=\"v2\">";
            }

            if (dt.Rows[0]["AllCareerMail"].ToString() == "0")
            {
                strHtml = "<table width=\"95\" border=\"0\" cellpadding=\"0\" cellspacing=\"0\">";
                strHtml += "<tr>";
                strHtml += "<td width=\"23%\" style=\"border:none;\"><a href=\"javascript:change_checkbox2('v2', 'x2');\"><img id=\"v2\" src=\"images/v.png\" border=\"0\"></a></td>";
                strHtml += "<td width=\"77%\" style=\"border:none;\"><a href=\"javascript:change_checkbox2('x2', 'v2');\"><img id=\"x2\" src=\"images/x-2.png\" border=\"0\"></a></td>";
                strHtml += "</tr>";
                strHtml += "</table><input id=\"edm2\" name=\"edm2\" type=\"hidden\" value=\"x2\">";
            }
            LiteEdm2.Text = strHtml;
        }

    }

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
        }
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (IsPostBack)
        {
            string marryday = "";
            int edm = 0;
            int allCareerMail = 0;
            string tMsg = "";
            string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "member_edit_success.aspx";
            decimal Uid;
            string Email = Session[CareerNo + "_email_s"].ToString();


            if (name.Text == null || nickname.Text == null || Request.Form["city"] == null || Request.Form["zipcode"] == null || pwd.Text == null)
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='member_join.aspx';</script>");
                Response.End();
            }

            if (name.Text == "" || nickname.Text == "" || Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || pwd.Text == "")
            {
                Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='member_join.aspx';</script>");
                Response.End();
            }


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
                    Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('member_edit.aspx');</script>");
                    Response.End();
                }
            }

            //資料驗證
            string Name = new_word.doCheck_Input(name.Text.ToString(), 50);
            Email = new_word.doCheck_Input(email.Text.ToString(), 100);
            string PetName = new_word.doCheck_Input(nickname.Text.ToString(), 50);
            string Pwd = new_word.doCheck_Input(Request.Form["pwd"].ToString(), 50);
            string Marry = new_word.doCheck_Input(marryday, 10);
            string City = new_word.doCheck_Input(Request.Form["city"].ToString(), 50);
            string Zipcode = new_word.doCheck_Input(Request.Form["zipcode"].ToString(), 50);
            string Address = new_word.doCheck_Input(address.Text.ToString(), 50);
            string CellPhone = new_word.doCheck_Input(mobile.Text.ToString(), 50);
            string Phone1 = new_word.doCheck_Input(phone1.Text.ToString(), 3);
            string Phone2 = new_word.doCheck_Input(phone2.Text.ToString(), 10);
            string Phone3 = new_word.doCheck_Input(phone3.Text.ToString(), 10);

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

            int res = wow.Wow_MemberModify(out tMsg, CareerNo, dt2, WebSiteUrl);
            if (res == 0)
            {
                Session[CareerNo + "_name_s"] = Name;
                if (Email != Session[CareerNo + "_email_s"].ToString())
                {
                    Session[CareerNo + "_email_s"] = Email;
                    Response.Write("<script language=javascript>location.href='member_edit_ok.aspx?t=1';</script>");
                    Response.End();
                }
                else
                {
                    Session[CareerNo + "_email_s"] = Email;
                    Response.Write("<script language=javascript>location.href='member_edit_ok.aspx?t=2';</script>");
                    Response.End();
                }

            }
            else
            {
                Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='member_edit.aspx';</script>");
                Response.End();
            }
        }
    }
}