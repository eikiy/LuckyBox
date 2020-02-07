using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class event_14_bathrobe_index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        blAction blAt = new blAction();
        //查總參加人數
        bool blReturn = blAt.BindTotalCount372();

        if (blReturn)
        {
            ImageButton1.Enabled = true;
            Response.Redirect("b710.html");
        }
        else
            ImageButton1.Enabled = false;
      
    }
}
