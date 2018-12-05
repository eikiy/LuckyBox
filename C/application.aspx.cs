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

public partial class application : cttBase
{

    protected void Page_Load(object sender, EventArgs e)
    {
        string img = string.Empty;
        string sql_select = "SELECT path,note FROM products WHERE status = '1' ORDER BY sorting";
        SqlDataReader sdr = db.ExecuteReader(sql_select);
        while (sdr.Read())
        {
            img = img + "{image: '" + "admin_img/" + sdr["path"].ToString() + "', title: '" + sdr["note"].ToString() + "', thumb: '" + "admin_img/" + sdr["path"].ToString() + "', url: '' },";
        }
        sdr.Close();

        
        lt_img.Text = "<script type=" + "'text/javascript'" + ">" +

            "jQuery(function ($) {" +

                "$.supersized({" +

                    // Functionality
                    "slide_interval: 5000," + 	// Length between transitions
                    "transition: 1," + 			// 0-None, 1-Fade, 2-Slide Top, 3-Slide Right, 4-Slide Bottom, 5-Slide Left, 6-Carousel Right, 7-Carousel Left
                    "transition_speed: 700," + 	// Speed of transition

                    // Components							
                    "slide_links: false," + // Individual links for each slide (Options: false, 'num', 'name', 'blank')
                    "slides: [" + img +

                    // Slideshow Images

//"{ image: 'img/bg/bg01.jpg', title: '廚房01', thumb: 'img/bg/bg01.jpg', url: '' }," +
//"{ image: 'img/bg/bg02.jpg', title: '廚房02', thumb: 'img/bg/bg02.jpg', url: '' }," +
//"{ image: 'img/bg/bg03.jpg', title: '廚房03', thumb: 'img/bg/bg03.jpg', url: '' }," +
//"{ image: 'img/bg/bg04.jpg', title: '廚房04', thumb: 'img/bg/bg04.jpg', url: '' }," +
//"{ image: 'img/bg/bg05.jpg', title: '廚房05', thumb: 'img/bg/bg05.jpg', url: '' }," +
//"{ image: 'img/bg/bg06.jpg', title: '廚房06', thumb: 'img/bg/bg06.jpg', url: '' }," +
//"{ image: 'img/bg/bg07.jpg', title: '廚房01', thumb: 'img/bg/bg07.jpg', url: '' }," +
//"{ image: 'img/bg/bg08.jpg', title: '廚房01', thumb: 'img/bg/bg08.jpg', url: '' }," +
//"{ image: 'img/bg/bg09.jpg', title: '廚房01', thumb: 'img/bg/bg09.jpg', url: '' }," +
//"{ image: 'img/bg/bg10.jpg', title: '廚房01', thumb: 'img/bg/bg10.jpg', url: '' }," +
//"{ image: 'img/bg/bg11.jpg', title: '廚房01', thumb: 'img/bg/bg11.jpg', url: '' }," +
//"{ image: 'img/bg/bg12.jpg', title: '廚房01', thumb: 'img/bg/bg12.jpg', url: '' }," +
//"{ image: 'img/bg/bg13.jpg', title: '廚房01', thumb: 'img/bg/bg13.jpg', url: '' }," +
//"{ image: 'img/bg/bg14.jpg', title: '廚房01', thumb: 'img/bg/bg14.jpg', url: '' }," +
//"{ image: 'img/bg/bg15.jpg', title: '廚房01', thumb: 'img/bg/bg15.jpg', url: '' }," +
//"{ image: 'img/bg/bg16.jpg', title: '廚房01', thumb: 'img/bg/bg16.jpg', url: '' }," +
//"{ image: 'img/bg/bg17.jpg', title: '廚房01', thumb: 'img/bg/bg17.jpg', url: '' }," +
//"{ image: 'img/bg/bg18.jpg', title: '廚房01', thumb: 'img/bg/bg18.jpg', url: '' }," +
//"{ image: 'img/bg/bg19.jpg', title: '廚房01', thumb: 'img/bg/bg19.jpg', url: '' }," +
//"{ image: 'img/bg/bg20.jpg', title: '廚房01', thumb: 'img/bg/bg20.jpg', url: '' }," +
//"{ image: 'img/bg/bg21.jpg', title: '廚房01', thumb: 'img/bg/bg21.jpg', url: '' }," +
//"{ image: 'img/bg/bg22.jpg', title: '廚房01', thumb: 'img/bg/bg22.jpg', url: '' }," +
//"{ image: 'img/bg/bg23.jpg', title: '廚房01', thumb: 'img/bg/bg23.jpg', url: '' }," +

                "]" +
                "});" +
            "});" +

        "</script>";
    }
}
