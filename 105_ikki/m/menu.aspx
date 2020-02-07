<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="menu" %>
<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title> 
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<meta http-equiv="Pragma" content="no-cache" />
<meta http-equiv="Cache-Control" content="no-cache" />
<meta http-equiv="Expires" content="0" />
<link rel="stylesheet" type="text/css" href="css/style_menu.css">
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>
</head>

<body>
<form id="form1" runat="server">
<div id="logo_warp">
	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
</div>
<div id="warp">
  	<div id="main">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tr>
            <td>
        <asp:Literal ID="LiteMenu" runat="server"></asp:Literal>
        <div class="meal"></div>
        <div class="meal"></div>
        </td>
          </tr>
        </table>
    </div>
    <div id="line3"></div>
</div>
<div id="footer_warp">
    <div id="footer">
          <div class="txt1"><img src="images/menu/footer.png" width="320" height="140" border="0" usemap="#Map2"></div>
    </div>
</div>
</form>
<map name="Map">
   <area shape="rect" coords="249,11,274,32" href="index.html">
</map>
<map name="Map2">
    <area shape="rect" coords="107,79,262,97" href="mailto:service@ikki.com.tw">
  <area shape="rect" coords="260,124,297,144" href="http://www.ikki.com.tw/index.html?m=1">
</map>
</body>
</html>
