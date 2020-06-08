using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;

public partial class food : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
            Website2API.Website2API wow = new Website2API.Website2API();


            //店鋪下拉選單Public.strP_ShopNo            
            blSuggestCard.BindStore(store, Public.strP_ShopNo);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string tMsg = "";

        if (name.Text == null || email.Text == null || store.SelectedValue == null || subject.Text == null || content.Text == null)
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='food.aspx';</script>");
            Response.End();
        }

        if (name.Text == "" || email.Text == "" || store.SelectedValue == "" || subject.Text == "" || content.Text == "")
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='food.aspx';</script>");
            Response.End();
        }

        check_input new_word = new check_input();

        //資料驗證
        string Name = new_word.doCheck_Input(name.Text.ToString(), 50);
        string Email = new_word.doCheck_Input(email.Text.ToString(), 100);
        //string Gender = new_word.doCheck_Input(Request.Form["sex"].ToString(), 5);
        string Gender = new_word.doCheck_Input(RadioButtonList_Gender.SelectedValue.ToString(), 5);
        string CellPhone = new_word.doCheck_Input(mobile.Text.ToString(), 50);
        string Phone = "";

        string StoreNo = new_word.doCheck_Input(store.SelectedValue.ToString(), 20);
        string StoreName = new_word.doCheck_Input(store.SelectedItem.Text.ToString(), 30);
        string Subject = new_word.doCheck_Input(subject.Text.ToString(), 100);
        string Content = new_word.doCheck_Input(content.Text.ToString(), 5000);
        if (Gender == "man")
        {
            Gender = "男";
        }

        if (Gender == "woman")
        {
            Gender = "女";
        }

        DataSet ds = new DataSet();
        DataTable dt = new DataTable("MemberTalk");
        ds.Tables.Add(dt);
        dt.Columns.Add("Name", typeof(String));
        dt.Columns.Add("Gender", typeof(String));
        dt.Columns.Add("CellPhone", typeof(String));
        dt.Columns.Add("Phone", typeof(String));
        dt.Columns.Add("Email", typeof(String));
        dt.Columns.Add("StoreNo", typeof(String));
        dt.Columns.Add("StoreName", typeof(String));
        dt.Columns.Add("Subject", typeof(String));
        dt.Columns.Add("Contents", typeof(String));

        DataRow dr = dt.NewRow();
        dr["name"] = Name;
        dr["Gender"] = Gender;
        dr["CellPhone"] = CellPhone;

        if (phone1.Text != "")
        {
            Phone = new_word.doCheck_Input(phone1.Text, 3) + "-" + new_word.doCheck_Input(phone2.Text, 8);
        }

        if (phone3.Text != "")
        {
            Phone = Phone + "#" + new_word.doCheck_Input(phone3.Text, 5);
        }

        dr["Phone"] = Phone;
        dr["Email"] = Email;
        dr["StoreNo"] = StoreNo;
        dr["StoreName"] = StoreName;
        dr["Subject"] = Subject;
        dr["Contents"] = Content;

        dt.Rows.Add(dr);

        Website2API.Website2API wow = new Website2API.Website2API();
        int res = wow.Wow_MemberTalk(CareerNo, dt, "", out tMsg);
        if (res == 0)
        {
            Session[CareerNo + "_talk_s"] = "yes";

            Response.Redirect("foodSend.aspx");
            Response.End();
        }
        else
        {
            Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='food.aspx';</script>");
            Response.End();
        }
    }
}
