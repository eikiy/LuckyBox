<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forget.aspx.cs" Inherits="forget" %>
<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<link rel="stylesheet" type="text/css" href="css/style_forget.css">
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="js/forget.js"></script>
</head>

<body>
<form id="form1" name="form1" method="post" action="forget.aspx" onSubmit="return checkdata();" runat="server">
<div id="warp02">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="title">
   		忘記密碼
    </div>
    <div id="forget">
    	<div class="fields"><input name="email" type="text" id="email" style="width:170px; height:20px; border:none;" runat="server" /></div>
    </div>
    <br><br>
    <div id="login4">
    	<div class="img"><iframe name="imgcode" id="imgcode" src="code.aspx" width="120" height="50" scrolling="no" frameborder="0"></iframe></div>
        <div class="img_txt"><a href="javascript:;" onClick="document.getElementById('imgcode').contentWindow.location.reload();"><u>更換別組圖示</u></a><br><span style="color:#3e3e3e"> (不分大小寫)</span></div>
    	<div class="line">
        <div class="txt"><input name="code" type="text" id="code" style="width:200px; height:20px; border:none;" maxlength="5" runat="server" /></div>
        </div>
    </div>
    <div id="txt">
		請輸入帳號，我們將回覆【密碼重設通知信】到您 email 信箱中。
    </div>
  	<div id="button">
          <asp:ImageButton ID="ImageButton1" runat="server" 
              ImageUrl="images/button.png" onclick="ImageButton1_Click" />
    </div>
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer2.png" width="320" height="140" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
    </div>
    
  </div>
</div>
</form>
<map name="Map">
   <area shape="rect" coords="246,11,277,31" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="109,80,263,94" href="mailto:service@ikki.com.tw">
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