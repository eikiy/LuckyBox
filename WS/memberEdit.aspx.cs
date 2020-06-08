using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class memberEdit : System.Web.UI.Page
{

    Website2API.Website2API wow = new Website2API.Website2API();
    string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];


    protected void Page_Load(object sender, EventArgs e)
    {
        Page.MaintainScrollPositionOnPostBack = true;


        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        if (Session[CareerNo + "_email_s"] == null || Session[CareerNo + "_email_s"].ToString() == "")
        {
            Response.Write("<script language=javascript>alert('資料錯誤!!');location.href='memberLogin.aspx';</script>");
            Response.End();
        }

        if (!IsPostBack)
        {
            //email欄位上鎖
            email.Attributes.Add("ReadOnly", "ReadOnly");


            Website2API.Website2API wow = new Website2API.Website2API();
            string Email = Session[CareerNo + "_email_s"].ToString();
            string strHtml = "";
            decimal Uid;

            DataSet ds = new DataSet();
            DataTable dt = new DataTable("MemberData");
            dt = wow.Wow_GetMemberData2(CareerNo, Email);

            Uid = Convert.ToDecimal(dt.Rows[0]["Uid"].ToString());
            if (dt.Rows[0]["Name"].ToString() != "")
            {
                name.Text = dt.Rows[0]["Name"].ToString();
            }

            #region 性別
            if (dt.Rows[0]["Gender"].ToString() == "男")
            {
                RadioButtonList_Gender.SelectedValue = "man";
            }
            if (dt.Rows[0]["Gender"].ToString() == "女")
            {
                RadioButtonList_Gender.SelectedValue = "woman";
            }
            #endregion

            #region 暱稱
            if (dt.Rows[0]["PetName"].ToString() != "")
            {
                nickname.Text = dt.Rows[0]["PetName"].ToString();
            }
            #endregion

            #region email
            if (dt.Rows[0]["Email"].ToString() != "")
            {
                email.Text = dt.Rows[0]["Email"].ToString();
            }
            #endregion

            #region 結婚
            if (dt.Rows[0]["Marry"].ToString() != "")
            {
                string[] marray_array = string.Format("{0:yyyy\\/M\\/d}", System.Convert.ToDateTime(dt.Rows[0]["Marry"].ToString())).Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                hide_year2.Value = marray_array[0];
                hide_month2.Value = marray_array[1];
                hide_day2.Value = marray_array[2];
            }
            #endregion

            #region 縣市
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
            #endregion

            #region 郵遞區號
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
            #endregion

            #region 地址
            if (dt.Rows[0]["Address"].ToString() != "")
            {
                address.Text = dt.Rows[0]["Address"].ToString();
            }
            #endregion

            #region 手機
            if (dt.Rows[0]["CellPhone"].ToString() != "")
            {
                mobile.Text = dt.Rows[0]["CellPhone"].ToString();
            }
            #endregion

            #region 電話
            if (dt.Rows[0]["Phone_No"].ToString() != "")
            {
                phone1.Text = dt.Rows[0]["Phone_Area"].ToString();
                phone2.Text = dt.Rows[0]["Phone_No"].ToString();
                phone3.Text = dt.Rows[0]["Phone_Ext"].ToString();
            }
            #endregion

            #region 是否願意接收廣告信?
            if (dt.Rows[0]["Edm"].ToString() == "0")//要該事業處
            {
                //CheckBox_v1.Checked = true;
                Career.SelectedValue = "Career_yes";
            }

            if (dt.Rows[0]["Edm"].ToString() == "1")//不要該事業處
            {
                //CheckBox_v1.Checked = false;
                Career.SelectedValue = "Career_no";
            }

            if (dt.Rows[0]["AllCareerMail"].ToString() == "1")//要全集團
            {
                //CheckBox_v2.Checked = true;
                Company.SelectedValue = "Company_yes";
            }

            if (dt.Rows[0]["AllCareerMail"].ToString() == "0")//不要全集團
            {
                //CheckBox_v2.Checked = false;
                Company.SelectedValue = "Company_no";
            }
            #endregion
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


    protected void Button1_Click(object sender, EventArgs e)
    {
        string marryday = "";
        int edm = 0;
        int allCareerMail = 0;
        string tMsg = "";
        string WebSiteUrl = System.Web.Configuration.WebConfigurationManager.AppSettings["WebSiteUrl"] + "memberEditSend.aspx";//修改頁
        decimal Uid;
        string Email = Session[CareerNo + "_email_s"].ToString();

        #region 檢查必填資料欄位(用這種資料會異動)
        //if (name.Text == null || mobile.Text == null || nickname.Text == null || Request.Form["city"] == null || Request.Form["zipcode"] == null || pwd.Text == null)
        //{
        //    Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='memberEdit.aspx';</script>");
        //    Response.End();
        //}

        //if (name.Text == "" || mobile.Text == "" || nickname.Text == "" || Request.Form["city"].ToString() == "" || Request.Form["zipcode"].ToString() == "" || pwd.Text == "" || chk_pwd.Text == "")
        //{
        //    Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='memberEdit.aspx';</script>");
        //    Response.End();
        //}
        if (pwd.Text != chk_pwd.Text)
        {
            Response.Write("<script language=javascript>alert('密碼確認錯誤!!');location.href='memberEdit.aspx';</script>");
            Response.End();
        }
        #endregion



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
                Response.Write("<script language=javascript>alert(\"[結婚日期]不正確,請重新選擇!!\");location.replace('memberEdit.aspx');</script>");
                Response.End();
            }
        }

        //資料驗證
        string Name = new_word.doCheck_Input(name.Text.ToString(), 50);
        Email = new_word.doCheck_Input(email.Text.ToString(), 100);
        string PetName = new_word.doCheck_Input(nickname.Text.ToString(), 50);
        string Gender = new_word.doCheck_Input(RadioButtonList_Gender.SelectedValue.ToString(), 5);//性別
        string Pwd = new_word.doCheck_Input(Request.Form["pwd"].ToString(), 50);
        string Marry = new_word.doCheck_Input(marryday, 10);
        string City = new_word.doCheck_Input(Request.Form["city"].ToString(), 50);
        string Zipcode = new_word.doCheck_Input(Request.Form["zipcode"].ToString(), 50);
        string Address = new_word.doCheck_Input(address.Text.ToString(), 50);
        string CellPhone = new_word.doCheck_Input(mobile.Text.ToString(), 50);
        string Phone1 = new_word.doCheck_Input(phone1.Text.ToString(), 3);
        string Phone2 = new_word.doCheck_Input(phone2.Text.ToString(), 10);
        string Phone3 = new_word.doCheck_Input(phone3.Text.ToString(), 10);



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
        else if(Company.SelectedValue == "Company_no")
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




        DataSet ds = new DataSet();

        ds = new DataSet();
        DataTable dt2 = new DataTable("MemberData");
        ds.Tables.Add(dt2);
        dt2.Columns.Add("Uid", typeof(decimal));
        dt2.Columns.Add("Name", typeof(String));
        dt2.Columns.Add("Gender", typeof(String));
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
        dr["Gender"] = Gender;
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


        int res = wow.Wow_MemberModify2(CareerNo, dt2, WebSiteUrl, out tMsg);//資料不完整會回傳訊息
        if (res == 0)
        {
            Session[CareerNo + "_name_s"] = Name;
            if (Email != Session[CareerNo + "_email_s"].ToString())
            {
                Session[CareerNo + "_email_s"] = Email;
                Response.Write("<script language=javascript>location.href='memberEditSend.aspx?t=1';</script>");
                Response.End();
            }
            else
            {
                Session[CareerNo + "_email_s"] = Email;
                Response.Write("<script language=javascript>location.href='memberEditSend.aspx?t=2';</script>");
                Response.End();
            }
        }
        else
        {
            Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='memberEdit.aspx';</script>");
            Response.End();
        }
    }
}
