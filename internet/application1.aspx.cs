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

public partial class application1 : cttBase
{

     protected void Page_Load(object sender, EventArgs e)
    {
        string lit_js = string.Empty;
       
        lit_js = "<script type='text/javascript'>";

        lit_js += "jQuery(function ($) { ";

        lit_js += "$.supersized({ ";

                
        lit_js += "slide_interval: 3000, ";		
        lit_js += "transition: 1, "; 			
        lit_js += "transition_speed: 700, ";

               				
        lit_js += "slide_links: false, ";
        lit_js += "slides: [ ";
        
        
        string sql_select = "SELECT path, note, img_title FROM products where cata = '1' AND status ='1' ORDER BY sorting";
        SqlDataReader sdr = db.ExecuteReader(sql_select);
        while (sdr.Read())
        {
            lit_js += "{ image: 'admin_img/" + sdr["path"].ToString() + "', url: '', thumb: 'admin_img/" + sdr["path"].ToString() + "', title: {title: '" + sdr["img_title"].ToString() + "',desc: '" + sdr["note"].ToString().Replace("\r\n","<br />") + "'} }, ";
        }
        sdr.Close();                       
                            
        lit_js += " ] ";
        lit_js += " }); ";
            
        lit_js += "theme.beforeAnimation = function () { ";                
        lit_js += "var slideTitle = api.getField('title'); ";
        lit_js += "$('.shop').fadeOut(200, function (e) { ";
        lit_js += "$('.shop .title').text(slideTitle.title); ";
        lit_js += "$('.shop .text').html(slideTitle.desc); ";
        lit_js += "$(this).fadeIn(500); ";
        lit_js += "}); ";
        lit_js += "}; ";

        lit_js += "}); ";

		lit_js += "</script> ";
		
		lt_img.Text = lit_js;

        
      
    }
   
}
