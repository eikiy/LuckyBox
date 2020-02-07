<%@ Page Language="C#" AutoEventWireup="true" CodeFile="coupon.aspx.cs" Inherits="coupon" %>
<!DOCTYPE html>
<html lang="zh-tw">
<head>
<META NAME="GOOGLEBOT" CONTENT="NOSNIPPET"> 
<META NAME="ROBOTS" CONTENT="NOARCHIVE">

<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<link rel="stylesheet" type="text/css" href="css/style_coupon.css">
</head>

<body>
<div id="warp">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="part1">
    <asp:Literal ID="LiteName" runat="server"></asp:Literal>貴賓 ~<br>
    感謝您！您已經成功啟用您的帳號。<br>
    請出示本頁面至藝奇消費，即可兌換。
    </div>
    <div id="barcode">
    <asp:Literal ID="LiteBarcode" runat="server"></asp:Literal>
    </div>
    
  	<div id="part2">
        ‧憑本券消費套餐或單點主餐即可兌換<br>
		&nbsp;&nbsp;【入會禮】乙份<br>
        ‧每桌每次限兌換本券一張<br>
       ‧本券不得與其他優惠合併使用<br>
        ‧使用期限至<asp:Literal ID="LiteDate" runat="server"></asp:Literal> <br>
        ‧贈品以實物為主，若贈完則改贈其他等值禮品
    </div>
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer2.png" width="320" height="140" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
    </div>
    
  </div>
</div>
<map name="Map">
   <area shape="rect" coords="246,10,275,30" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="108,80,262,92" href="mailto:service@ikki.com.tw">
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

