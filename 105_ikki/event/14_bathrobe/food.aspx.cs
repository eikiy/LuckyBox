using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using System.Xml;

public partial class event_14_bathrobe_food : System.Web.UI.Page
{
    #region 共用參數
    //Sql s = new Sql();
    //Public _Public = new Public();
    #endregion
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
