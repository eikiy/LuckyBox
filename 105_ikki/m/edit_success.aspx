<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit_success.aspx.cs" Inherits="edit_success" %>
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
  	<div id="part3">
          <asp:Literal ID="LiteName" runat="server"></asp:Literal>貴賓 <br />
您已經成功啟用您的e-mail帳號。<br />
感謝您對藝奇的愛護與支持~

    </div>
    
  	
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer.png" width="320" height="116" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
    </div>
    
  </div>
</div>
<map name="Map">
   <area shape="rect" coords="249,11,273,31" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="107,81,260,93" href="mailto:service@ikki.com.tw">
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