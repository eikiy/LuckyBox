<%@ Page Language="C#" AutoEventWireup="true" CodeFile="email_resend.aspx.cs" Inherits="email_resend" %>
<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<link rel="stylesheet" type="text/css" href="css/style_email_resend.css">
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="js/forget.js"></script>
</head>

<body>
<form id="form1" name="form1" method="post" action="email_resend.aspx" onSubmit="return checkdata();" runat="server">
<div id="warp">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="title">
   		補發確認信函
    </div>
    <div id="forget">
    	<div class="fields"><input name="email" type="text" id="email" style="width:170px; height:20px; border:none;" value="" onKeyDown="change('check_email');" onBlur="check('email', 'check_email');" /></div>
    </div>
    <div id="txt">
		請輸入email 帳號，我們將補發會員確認信函到您的<br>
		email 信箱，謝謝！</div>
    <div id="button">
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="images/button.png" onclick="ImageButton1_Click" />
    </div>
  	<div id="part2">
    	<table width="295" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td valign="top">&nbsp;</td>
        <td align="left" class="title">是否一直沒收到確認信函？</td>
      </tr>
      <tr>
        <td colspan="2" valign="top" height="10"></td>
        </tr>
      <tr class="txt">
        <td align="left" valign="top">‧</td>
        <td align="left">首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。</td>
      </tr>
      <tr class="txt">
        <td align="left" valign="top">‧</td>
        <td align="left">建議您可檢查郵件信箱的【垃圾郵件夾】，檢查是否有藝奇的註冊確認信函</td>
      </tr>
      <tr class="txt">
        <td align="left" valign="top">‧</td>
        <td align="left">倘若您一直沒收到確認信函，建議您可檢查您的e-mail是否有錯誤。若發現任何錯誤,可再重新註冊一次即可。</td>
      </tr>
       <tr class="txt">
        <td align="left" valign="top">‧</td>
        <td align="left">若您一直無法收到確認信函，歡迎您可填寫<a href="mailto:service@ikki.com.tw"><span style="color:#d50000;"><u>連絡信箱</u></span></a>或撥打免付費意見專線0800-365-101為您處理。</td>
      </tr>
    </table>
    </div>
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer2.png" width="320" height="140" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
    </div>
    
  </div>
</div>
</form>
<map name="Map">
   <area shape="rect" coords="247,12,274,31" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="109,80,261,93" href="mailto:service@ikki.com.tw">
</map>
</body>
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>
</html>
