<%@ Page Language="C#" AutoEventWireup="true" CodeFile="reset_pw.aspx.cs" Inherits="m_reset_pw" %>

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
<form id="form1" name="form1" method="post" action="reset_pw.aspx" runat="server">
<div id="warp03">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="title">
   		▍更換新密碼：
    </div>
    <div id="forget02">
    	<div class="fields"><input name="pwd" type="password" id="pwd" style="width:170px; height:20px; border:none;" value="" />　<span class="fp">(4-8 個字元)</span></div>
    </div>
    <div id="title">
   		▍請再輸入一次：
    </div>
    <div id="forget02">
    	<div class="fields"><input name="chk_pwd" type="password" id="chk_pwd" style="width:170px; height:20px; border:none;" value="" />　<span class="fp">(4-8 個字元)</span></div>
    </div>
  	<div id="button">
          <asp:ImageButton ID="ImageButton1" runat="server" 
              ImageUrl="images/button.png" onclick="ImageButton1_Click" />
              <br>
                <asp:HiddenField ID="hidfFid" runat="server" />
    <asp:HiddenField ID="hidUid" runat="server" />

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
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
    _uacct = "UA-2488504-1";
    urchinTracker();
</script>

</html>