using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;


public partial class en_talk : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        string CareerNo = System.Web.Configuration.WebConfigurationManager.AppSettings["CareerNo"];
        string tMsg = "";

        if (name.Text == null || Request.Form["sex"] == null || email.Text == null || subject.Text == null || content.Text == null)
        {
            //Response.Write("<script language=javascript>alert('error!!');location.href='talk.aspx';</script>");
            //Response.End();
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('error!!');</script>");
            return;
        }

        if (name.Text == "" || Request.Form["sex"] == "" || email.Text == "" || subject.Text == "" || content.Text == "")
        {
            this.RegisterStartupScript(Guid.NewGuid().ToString(), "<script>alert('error!!');</script>");
            return;
            //Response.Write("<script language=javascript>alert('error!!');location.href='talk.aspx';</script>");
            //Response.End();
        }

        check_input new_word = new check_input();

        //資料驗證
        string Name = new_word.doCheck_Input(name.Text.ToString(), 50);
        string Email = new_word.doCheck_Input(email.Text.ToString(), 100);
        string Gender = new_word.doCheck_Input(sex.SelectedValue.ToString(), 10);
        string Phone = new_word.doCheck_Input(phone.Text.ToString(), 50);
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
        dr["CellPhone"] = "";
        dr["Phone"] = Phone;
        dr["Email"] = Email;
        dr["StoreNo"] = "";
        dr["StoreName"] = "";
        dr["Subject"] = Subject;
        dr["Contents"] = Content;

        dt.Rows.Add(dr);

        wowapi.Website2APISoapClient wow = new wowapi.Website2APISoapClient();
        int res = wow.Wow_MemberTalk( out tMsg,CareerNo, dt, "EN");
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
