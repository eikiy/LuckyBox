<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store_detail.aspx.cs" Inherits="m_store_detail" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
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
            <div id="left">
              	<div id="store_name"><asp:Literal ID="LiteName" runat="server"></asp:Literal></div>
                <div class="line"><img src="images/store/line.jpg" width="229" height="1"></div>
               	<div id="store_address"><asp:Literal ID="LiteAddress" runat="server"></asp:Literal></div>
                <div class="line"><img src="images/store/line.jpg" width="229" height="1"></div>
               	<div id="store_phone">
                    <div style="float:left; margin-left:0px; width:219px;"><u><asp:Literal ID="LitePhone" runat="server"></asp:Literal></u></div>
                    <div id="phone"><asp:Literal ID="LiteImg" runat="server"></asp:Literal></div>
                </div>
                <div class="line2"><img src="images/store/line.jpg" width="229" height="1"></div>
            	<div id="map"><asp:Literal ID="LiteMap" runat="server"></asp:Literal></div>
                <div class="line"><img src="images/store/line.jpg" width="229" height="1"></div>
                <asp:Literal ID="LiteOther" runat="server"></asp:Literal>
            </div>
            </td>
          </tr>
          <tr><td height="44"></td></tr>
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
   <area shape="rect" coords="248,11,274,33" href="index.html">
</map>
<map name="Map2">
    <area shape="rect" coords="106,79,264,96" href="mailto:service@ikki.com.tw">
  <area shape="rect" coords="259,126,295,141" href="http://www.ikki.com.tw/index.html?m=1" />
</map>
<map name="Map3">
	<area shape="rect" coords="40,12,91,33" href="store_list.aspx?area=1">
    <area shape="rect" coords="186,13,238,33" href="store_list.aspx?area=2">
    <area shape="rect" coords="40,44,93,64" href="store_list.aspx?area=3">
    <area shape="rect" coords="185,44,243,63" href="store_list.aspx?area=4">
    <area shape="rect" coords="38,73,90,93" href="store_list.aspx?area=5">
    <area shape="rect" coords="184,74,222,91" href="store_list.aspx?area=6">
</map>
</body>
</html>