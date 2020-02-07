using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_14_bathrobe_apply_ok : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["372YESCName"] == null)
            {
                Response.Redirect("apply.aspx");
                return;
            }

            labCName.Text = Session["372YESCName"].ToString().Trim();
            labNo.Text = Session["372YESNo"].ToString().Trim();
            //有親友的情況，需帶入親友的資訊
            if (Session["372YESCName"].ToString().Trim() != "")
            {
                labCName.Text = Session["372YESCName"].ToString().Trim();
                //if (Session["372YESCName2"].ToString().Trim() != "")
                //    labCName.Text = labCName.Text + " , " + Session["372YESCName2"].ToString().Trim();

                labNo.Text = "A" + Session["372YESNo"].ToString().Trim() + "(" + Session["372YESCName"].ToString().Trim() + ")";
                if (Session["372YESCName2"].ToString().Trim() != "")
                    labNo.Text = labNo.Text + " , "+ "B" + Session["372YESNo"].ToString().Trim() +"("+ Session["372YESCName2"].ToString().Trim()+")";
            }

            Session.Remove("372YESCName");
            Session.Remove("372YESCName2");
            Session.Remove("372YESNo");
        }
    }
}
