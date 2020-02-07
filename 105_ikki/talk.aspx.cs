using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class talk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
            wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
            DataSet ds = wow.Wow_BindStore(CareerNo);
            store.Items.Add(new ListItem("請選擇", ""));
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                store.Items.Add(new ListItem(ds.Tables[0].Rows[i]["StoreName"].ToString().Trim(), ds.Tables[0].Rows[i]["StoreNo"].ToString().Trim()));
            }
        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string tMsg = "";

        if (name.Text == null || Request.Form["sex"] == null || email.Text == null || store.SelectedValue == null || subject.Text == null || content.Text == null)
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='talk.aspx';</script>");
            Response.End();
        }

        if (name.Text == "" || Request.Form["sex"] == "" || email.Text == "" || store.SelectedValue == "" || subject.Text == "" || content.Text == "")
        {
            Response.Write("<script language=javascript>alert('欄位未填寫完整!!');location.href='talk.aspx';</script>");
            Response.End();
        }

        check_input new_word = new check_input();

        //資料驗證
        string Name = new_word.doCheck_Input(name.Text.ToString(), 50);
        string Email = new_word.doCheck_Input(email.Text.ToString(), 100);
        string Gender = new_word.doCheck_Input(Request.Form["sex"].ToString(), 5);
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

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        int res = wow.Wow_MemberTalk(out tMsg, CareerNo, dt, "TW");
        if (res == 0)
        {
            Session[CareerNo + "_talk_s"] = "yes";
            
            Response.Redirect("talk_ok.aspx");
            Response.End();
        }
        else
        {
            Response.Write("<script language=javascript>alert('" + tMsg + "');location.href='talk.aspx';</script>");
            Response.End();
        }

    }
}