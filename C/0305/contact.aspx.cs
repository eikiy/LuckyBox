using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class contact : cttBase
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lb_Ok_Click(object sender, EventArgs e)
    {
        string sql_insert = "INSERT INTO ask (company, contact, address, number, email, ask) VALUES ('" +
            tb_companyName.Text + "','" + tb_contact.Text + "','" + tb_address.Text + "','" + tb_number.Text + "','" +
            tb_email.Text + "','" + tb_ask.Text + "')";
        if (tb_ask.Text.Length > 250)
        {
            Alert.Show("類別名稱勿超過250個字");
        }
        else
        {
            if (db.ExecuteSql(sql_insert) > 0)
            {
                Response.Redirect("index.aspx");
            }
            else
            {
                Alert.Show("error");
                //lbl_error.Text = "<span class='tip'>新增失敗</span>";
            }
            //Alert.Show(sql_insert);
            db.closeconnection();
            //Alert.Show("test");
        }
    }
}
