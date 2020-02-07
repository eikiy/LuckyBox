<%@ Page Language="C#" AutoEventWireup="true" CodeFile="meal.aspx.cs" Inherits="m_meal" %>

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
<link rel="stylesheet" type="text/css" href="css/style_meal.css">
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
    	<div id="img"><asp:Image ID="Image1" runat="server" Height="175px" Width="320px" /></div>
        <asp:Literal ID="LiteMenu" runat="server"></asp:Literal>
        <div id="line2"><img src="images/menu/line2.jpg" width="320" height="2"></div>
        <div id="fb">
        <script>            (function (d, s, id) {
                var js, fjs = d.getElementsByTagName(s)[0];
                if (d.getElementById(id)) return;
                js = d.createElement(s); js.id = id;
                js.src = "//connect.facebook.net/zh_TW/all.js#xfbml=1";
                fjs.parentNode.insertBefore(js, fjs);
            } (document, 'script', 'facebook-jssdk'));</script>
				<div class="fb-like" data-action="like"  data-send="false" data-layout="button_count" data-width="180" data-show-faces="true"></div>
        </div>
        <div id="line"> <a href="http://line.naver.jp/R/msg/text/?藝奇菜單%0D%0Ahttp://m.ikki.com.tw/m/menu.aspx" rel="nofollow" ><img src="images/menu/Line.jpg" width="205" height="40" border="0"></a> </div>
  	</div>
</div>
<div id="footer_warp">
    <div id="footer">
          <div class="txt1"><img src="images/menu/footer.png" width="320" height="140" border="0" usemap="#Map2"></div>
    </div>
</div>
</form>
<map name="Map">
   <area shape="rect" coords="249,10,274,35" href="index.html">
</map>
<map name="Map2">
    <area shape="rect" coords="106,81,260,94" href="mailto:service@ikki.com.tw">
  <area shape="rect" coords="257,125,298,140" href="http://www.ikki.com.tw/index.html?m=1">
</map>
</body>
</html>