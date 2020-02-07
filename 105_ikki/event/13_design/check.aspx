<%@ Page Language="C#" AutoEventWireup="true" CodeFile="check.aspx.cs" Inherits="event_13_design_check" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇 ikki 新日本料理 城市創藝 × 藝奇同饗</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">
<!--<script Language="JavaScript">
location.href= ('check.html');
</script>-->

<script language='javascript' type="text/javascript" >
    function EvImageOverChange(name, action)
    {   
        switch(action)
        {
            case 'in':
                name.src = "images/btn_logina.png";
            break;
            case 'out':
                name.src = "images/btn_login.png";
            break;
        }
    }
    </script>
    
    
    
</head>

<body>
 <form id="form1" name="form1" method="post" action="" runat="server">
<div class="wrapper">
  <table border="0" cellpadding="0" cellspacing="0">
    	<tr>
        	<td>
            <img src="images/13_design_02.jpg" border="0" usemap="#Map">
            <map name="Map">
              <area shape="rect" coords="0,-3,179,98" href="http://www.ikki.com.tw">
            </map>
            </td>
            <td><a href="index.html"><img src="images/13_design_03.jpg" onMouseOver="this.src='images/13_design_03a.jpg'" onMouseOut="this.src='images/13_design_03.jpg'" alt="" width="78" height="98" style="cursor:pointer; border: none;" /></a></td>
            <td><img src="images/13_design_04.jpg"></td>
        </tr>
  </table>
    
    <table border="0" cellpadding="0" cellspacing="0" style="*margin-top:-3px;">
    	<tr>
        	<td><a href="hat.html"><img src="images/menu_06.jpg" onMouseOver="this.src='images/menu_06a.jpg'" onMouseOut="this.src='images/menu_06.jpg'" alt="" width="188" height="80" style="cursor:pointer; border: none;" /></a></td>
            <td><a href="books.aspx"><img src="images/menu_07.jpg" onmouseover="this.src='images/menu_07a.jpg'" onmouseout="this.src='images/menu_07.jpg'" alt="" width="175" height="80" style="cursor:pointer; border: none;" /></a></td>
            <td><a href="fb.html"><img src="images/menu_08.jpg" onMouseOver="this.src='images/menu_08a.jpg'" onMouseOut="this.src='images/menu_08.jpg'" alt="" width="174" height="80" style="cursor:pointer; border: none;" /></a></td>
            <td><a href="redblack.html"><img src="images/menu_09.jpg" onMouseOver="this.src='images/menu_09a.jpg'" onMouseOut="this.src='images/menu_09.jpg'" alt="" width="173" height="80" style="cursor:pointer; border: none;" /></a></td>
            <td><img src="images/13_design_10n.jpg" width="270" height="80"></td>
      </tr>
  </table>
    
	<img src="images/13_design_check_11.jpg">    
    <div style="background:url(images/13_design_12.jpg) no-repeat; height:230px;">
    <table border="0" cellpadding="0" cellspacing="0" class="login-bg">
    	<tr>
        	<td width="17%" height="10" align="right">&nbsp;</td>
        	    <td width="16%" >&nbsp;</td>
       	      <td rowspan="3" style="vertical-align:bottom; padding:0 0 8px 10px;">
              <%--<a href="check_ok.aspx"><img src="images/btn_login.png" onmouseover="this.src='images/btn_logina.png'" onmouseout="this.src='images/btn_login.png'" alt="" width="74" height="21" style="cursor:pointer; border: none;" /></a>--%>  
               <asp:ImageButton runat="server" ID="IBtnSend" ImageUrl="images/btn_login.png" BorderColor="0" OnClick="IBtnSend_Click"  />                              
              
             </td>
      </tr>
       	    <tr>
        	  <td align="right"><font color="#ff0000">▌</font>Email帳號 :</td>
        	  <td >  <asp:TextBox runat="server" ID="txtEmail" Width="150px" ></asp:TextBox>  </td>
       	  </tr>
        	<tr>
            	<td align="right"><font color="#ff0000">▌</font>密碼 :</td>
                <td><label>
                    <asp:TextBox runat="Server" ID="txtPwd" TextMode="password" Width="150px"></asp:TextBox> 
                </label></td>
            </tr>
            <tr>
              <td></td>
              <td style="vertical-align:top;">(<a href="http://www.ikki.com.tw/member_forget.aspx" target="_blank">忘記密碼?</a>)</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td colspan="3" style="padding-left:100px;">&nbsp;</td>
            </tr>
            <tr>
            	<td colspan="3" style="padding-left:100px;">當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~</td>
        </tr>
    </table>
  </div>
    
    <!--<table border="0" cellpadding="0" cellspacing="0">
    	<tr>
        	<td><img src="images/13_design_13.jpg"></td>
            <td><a href="fb.html"><img src="images/13_design_14.jpg" onmouseover="this.src='images/13_design_14a.jpg'" onmouseout="this.src='images/13_design_14.jpg'" alt="" width="265" height="119" style="cursor:pointer; border: none;" /></a></td>
            <td><img src="images/13_design_15.jpg"></td>
        </tr>
    </table>-->
</div>
<div class="footer_bg" style="height:400%;">
  <div class="footer">
   	<table border="0" cellpadding="0" cellspacing="0">
        	<tr>
            	<td><img src="images/footer_16.jpg" width="351" height="50" style="border: none;" /></td>
                <td><a href="story.html"><img src="images/footer_17.jpg" onmouseover="this.src='images/footer_17a.jpg'" onmouseout="this.src='images/footer_17.jpg'" alt="" width="281" height="50" style="cursor:pointer; border: none;" /></a></td>
                <td><a href="tips.html"><img src="images/footer_18.jpg" onmouseover="this.src='images/footer_18a.jpg'" onmouseout="this.src='images/footer_18.jpg'" alt="" width="348" height="50" style="cursor:pointer; border: none;" /></a></td>
            </tr>
    </table>
  </div>
</div>
<div class="link">
        <img src="images/footer_19.jpg" border="0" usemap="#Map2">
                <map name="Map2">
          <area shape="rect" coords="195,33,312,73" href="http://www.books.com.tw/" target="_blank">
          <area shape="rect" coords="385,31,656,71" href="http://www.designexpo.org.tw/" target="_blank">
          <area shape="rect" coords="168,76,306,137" href="http://www.larche100.org/" target="_blank">
          <area shape="rect" coords="307,76,454,137" href="http://www.kangfu.org.tw/" target="_blank">
          <area shape="rect" coords="457,77,578,137" href="https://www.facebook.com/pages/%E6%A8%82%E6%B4%BB%E8%82%B2%E5%B9%BC%E9%99%A2/142081229246320" target="_blank">
          <area shape="rect" coords="676,23,769,131" href="https://www.facebook.com/pages/%E8%97%9D%E5%A5%87%E6%96%B0%E6%97%A5%E6%9C%AC%E6%96%99%E7%90%86_ikki/196280158629?fref=ts" target="_blank">
        </map>
</div>
</form>
</body>

<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
_uacct = "UA-2488504-1";
urchinTracker();
</script>
</html>
