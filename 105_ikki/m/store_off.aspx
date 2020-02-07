<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store.aspx.cs" Inherits="store" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<head>
<meta charset="utf-8">
<title>藝奇</title> 
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<meta http-equiv="Pragma" content="no-cache" />
<meta http-equiv="Cache-Control" content="no-cache" />
<meta http-equiv="Expires" content="0" />
<link rel="stylesheet" type="text/css" href="css/style_store.css">
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
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
        	<div id="area" style="text-align:center; height:250px;"><img src="event/images/14_off.gif"><br><br><img src="images/store/area.png" width="320" height="142" border="0" usemap="#Map3"></div>
            <div id="area1"><a name="area1"></a><img src="images/store/area1.png" width="320" height="40"></div>
            <div id="list">
                <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>
            </div>
            <div id="area2"><a name="area2"></a><img src="images/store/area2.png" width="320" height="40"></div>
            <div id="list">
                <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
            </div>
            <div id="area3"><a name="area3"></a><img src="images/store/area3.png" width="320" height="40"></div>
            <div id="list">
                <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
            </div>
            <div id="area4" runat="server"><a name="area4"></a><img src="images/store/area4.png" width="320" height="40"></div>
            <div id="list">
                <asp:Literal ID="LiteArea4" runat="server"></asp:Literal>
            </div>
            <div id="area5" runat="server"><a name="area5"></a><img src="images/store/area5.png" width="320" height="40"></div>
            <div id="list">
                <asp:Literal ID="LiteArea5" runat="server"></asp:Literal>
            </div>
            <div id="area6" runat="server"><a name="area6"></a><img src="images/store/area6.png" width="320" height="40"></div>
            <div id="list">
                <asp:Literal ID="LiteArea6" runat="server"></asp:Literal>
            </div>
           </td>
          </tr>
          
        </table>
    </div>
</div>
<div id="footer_warp">
    <div id="footer">
          <div class="txt1"><img src="images/menu/footer.png" width="320" height="140" border="0" usemap="#Map2"></div>
    </div>
</div>
</form>
<map name="Map">
   <area shape="rect" coords="249,12,275,32" href="index.html">
</map>
<map name="Map2">
    <area shape="rect" coords="104,80,259,93" href="mailto:service@ikki.com.tw">
  <area shape="rect" coords="258,124,297,137" href="http://www.ikki.com.tw/index.html?m=1">
</map>
<map name="Map3">
  <area shape="rect" coords="18,1,141,29" href="#area1">
  <area shape="rect" coords="162,1,284,29" href="#area2">
  <area shape="rect" coords="21,42,137,79" href="#area3">
  <area shape="rect" coords="161,47,286,78" href="#area4">
  <area shape="rect" coords="23,94,137,129" href="#area6">
</map>
</body>
</html>
