<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<link rel="stylesheet" type="text/css" href="css/style_edit_email.css">
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="js/login.js" type="text/javascript"></script>
</head>

<body>
<form id="form1" name="form1" method="post" action="login.aspx" onSubmit="return checkdata();" runat="server">
<div id="warp">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="title">
   		修改資料
    </div>
    <div id="part1">
    	<div class="line">
         <div class="fields"><input name="email" type="text" id="email" style="width:160px; height:20px; border:none;" value="" maxlength="80" /></div>
        </div>
        <div class="line">
        <div class="fields2"><input name="pwd" type="password" id="pwd" style="width:210px; height:20px; border:none;" value="" maxlength="8" /></div>
        </div>
    </div>
  	<div id="button">
          <asp:ImageButton ID="ImageButton1" runat="server" 
              ImageUrl="images/button.png" onclick="ImageButton1_Click" />
    </div>
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer.png" width="320" height="116" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
    </div>
    
  </div>
</div>
</form>
<map name="Map">
   <area shape="rect" coords="245,12,275,32" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="107,81,261,93" href="mailto:service@ikki.com.tw">
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

