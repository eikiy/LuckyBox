<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginok.aspx.cs" Inherits="event_15_spring_loginok" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇新日本料理 春祭 一起玩味</title>
<meta property="og:url" content="http://www.ikki.com.tw/event/15_spring/index.aspx"/>
<meta property="og:image" content="http://www.ikki.com.tw/event/15_spring/images/fb02.gif"/>
<meta property="og:site_name" content="藝奇新日本料理 春祭。一起玩味"/>
<meta property="og:description" content="我拿到了藝奇春遊優惠券，和我一起分享賞櫻景點，有機會同樂承億文旅!"/>
		<LINK href="css/main.css" type="text/css" rel="stylesheet">
		<LINK href="css/style.css" type="text/css" rel="stylesheet">
		<LINK href="css/fb.css" type="text/css" rel="stylesheet">        

</head>

<body style="background:none;">
<form id="form" runat="server">
<div class="keyin"><a name="ok"></a>
                                <table cellSpacing="0" cellPadding="0" border="0">
                                    <tr>
										<td colspan="2" align="left" vAlign="top">
                                        <span class="font-agree">
                                          <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                                          貴賓，
                                        恭喜您獲得本活動雙重優惠！ <a href="#" title="列印本頁" onclick="window.print(); return false;">請按此列印春遊優惠券</a>
                                          <br>
                                        本活動中獎公佈時間：2015/5/8 (五) 
                                        預祝您幸運中獎! 
                                        <br>
                                        <a href="javascript: void(window.open('http://www.facebook.com/share.php?u='.concat(encodeURIComponent(location.href)) ));">歡迎邀請FB親朋好友一起分享同樂! </a></span></td>
									</tr>
									<tr>
										<td colspan="2"><img src="images/coupon.gif" width="520" height="250"></td>
									</tr>
                                    <tr>
										<td style="font-size:18px; text-align:right; color:#000;" width="40%">
										
										
										<div><asp:Label ID="lblBarCode" runat="server"></asp:Label></div>
										
										
									  </td>
										<td><img id="imgQRCode" src="images/code.gif" width="100" height="100" runat="server" /></td>
									</tr>
								</table>
</div> 
</form>                           
</body>
</html>