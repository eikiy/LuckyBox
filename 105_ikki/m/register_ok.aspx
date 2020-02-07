<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register_ok.aspx.cs" Inherits="register_ok" %>

<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<link rel="stylesheet" type="text/css" href="css/style_reg_ok.css">
</head>

<body>
<div id="warp">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="part1">
    <asp:Literal ID="LiteName" runat="server"></asp:Literal> 貴賓： <br>
    您的會員確認信函已發送到<br>
    <asp:Literal ID="LiteEmail" runat="server"></asp:Literal>信箱。<br>
    請至此信箱收信，點選連結完成認證手續，<br>
    即可正式成為藝奇網路會員。
    </div>
    <div id="line"></div>
  	<div id="part2">
    	<table width="295" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td valign="top">&nbsp;</td>
        <td align="left" class="title">是否一直沒收到確認信函？</td>
      </tr>
      <tr>
        <td colspan="2" valign="top" height="13"></td>
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
        <td align="left">若您一直無法收到確認信函，歡迎您可填寫<a href="mailto:service@ikki.com.tw"><span style="color:#d50000;"><u>連絡信箱</u></span></a>或撥打免付費意見專線0800-365-000為您處理。</td>
      </tr>
    </table>
    </div>
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer2.png" width="320" height="140" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
    </div>
    
  </div>
</div>
<map name="Map">
   <area shape="rect" coords="248,10,277,33" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="106,81,263,92" href="mailto:service@ikki.com.tw">
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
