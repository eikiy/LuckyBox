<%@ Page Language="C#" AutoEventWireup="true" CodeFile="books_ok.aspx.cs" Inherits="event_13_design_books_ok" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇 ikki 新日本料理 城市創藝 × 藝奇同饗</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">
</head>

<body>
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
    
<table border="0" cellpadding="0" cellspacing="0" style="background:url(images/13_design_login_11.jpg); height:123px;">
    	<tr>
        	<td width="505">&nbsp;</td>
            <td style="color:#fff; padding-bottom:15px;">剩餘名額 <asp:Label runat="server" ID="lblCnt"></asp:Label> </td>
        </tr>
    </table>
    <div style="background:url(images/13_design_12ok.jpg) no-repeat;">
    <table border="0" cellpadding="0" cellspacing="0" style="height:187px;" class="login-bg">
            <tr>
              <td></td>
            </tr>
            <tr>
            	<td style="padding-left:80px; font-size:16px; line-height:30px; "> 您可獲得博客來E-Coupon折價券50元(兩組25元)
                <br>
                電子序號-1：<span style="font-size:24px; font-weight:bold;color:#fff100;"> <asp:Label runat="server" ID="lblCoupon1"></asp:Label> </span>
                <br>
                電子序號-2：<span style="font-size:24px; font-weight:bold;color:#fff100;"> <asp:Label runat="server" ID="lblCoupon2"></asp:Label> </span>
                <br><br>
                博客來E-Coupon折價券使用須知:
                </td>
        </tr>
    </table>
			
            <ul style="margin-left:90px; font-size:12px; line-height:24px; color:#fff;">
                	<li>使用期限： 2013年9月1日 ~ 2013年11月30日</li>
                    <li>使用方式： 至博客來每筆訂單不限消費門檻，憑電子序號可折抵25元，合計可使用兩筆訂單</li>
                    <li>E-Coupon折價券50元由博客來提供兩組25元的電子序號，限量10,000組，送完為止</li>
                    <li>每筆訂單限使用1組電子序號兌換，訂單逾期則自動作廢，將不補發</li>
                    <li>本券不得兌換現金或找零，如有遺失、序號遭冒用、被竊或滅失，概不掛失或補發</li>
                    <li>詳細E-Coupon折價券使用說明以<a href="http://www.books.com.tw/web/qa/" target="_blank">博客來規範</a>為準</li>
            </ul>
             <br>
                      
  </div>
            
    <!--<table border="0" cellpadding="0" cellspacing="0">
    	<tr>
        	<td><img src="images/13_design_13.jpg"></td>
            <td><a href="fb.html"><img src="images/13_design_14.jpg" onmouseover="this.src='images/13_design_14a.jpg'" onmouseout="this.src='images/13_design_14.jpg'" alt="" width="265" height="119" style="cursor:pointer; border: none;" /></a></td>
            <td><img src="images/13_design_15ok.jpg"></td>
        </tr>
    </table>-->
</div>
<div class="footer_bg" style="height:400%;">
  <div class="footer">
   	<table border="0" cellpadding="0" cellspacing="0">
        	<tr>
            	<td><a href="http://www.books.com.tw/fashion/activity/2013/08/ikki/" target="_blank"><img src="images/footer_16.jpg" onmouseover="this.src='images/footer_16a.jpg'" onmouseout="this.src='images/footer_16.jpg'" alt="" width="351" height="50" style="cursor:pointer; border: none;" /></a></td>
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

</body>

<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
_uacct = "UA-2488504-1";
urchinTracker();
</script>
</html>