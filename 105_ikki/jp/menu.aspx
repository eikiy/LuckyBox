<%@ Page Language="C#" AutoEventWireup="true" CodeFile="menu.aspx.cs" Inherits="en_menu" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<META NAME="keywords" CONTENT="藝奇,新日本料理,藝奇 新日本料理, ikki, 藝奇餐廳地址,王品集團,藝奇網路會員優惠券,花旗您生日我請客"> 
<META NAME="description" CONTENT="玩味+創意x食藝。創新食藝~玩味,「藝」教於飲食文化。樂趣汲取~日本專注細節。講究~食材烹調精神。添加~西式調味手法。揉合~北歐簡約設計。以靈感、巧思加持激盪東京時尚料理新風貌。"> 

<title>藝奇 ikki 新日本料理</title>
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
    _uacct = "UA-2488504-1";
    urchinTracker();
</script>
<link href="../en/en.css" rel="stylesheet" type="text/css" />
</head>

<body>
	<div class="wripper">
    <div class="menu">
    	<table border="0" cellpadding="0" cellspacing="0" width="240">
        	<tr>
            	<td><a href="/en/index.html"><img src="../en/images/logo.png" width="240" height="116" border="0"></a></td>
            </tr>
            <asp:Literal ID="LiteMenu" runat="server"></asp:Literal>
            <tr>
            	<td style="width:240px; height:142px; background:url(../en/images/menu_06.png);">
                </td>
            </tr>
        </table>
    </div>
    
    <div class="time" style="top:335px;">
                Business time: <br>‧ 11:30 - 14:30<br>　(Last order time 14:00)<br>
                ‧ 17:30 - 22:00<br>　(Last order time 21:00)
    </div>
    	<table border="0" cellpadding="0" cellspacing="0" width="900">
        	<tr>
            	<td style="width:629px; background:#fff;">&nbsp;</td>
                <td><a href="/menu.html"><img src="../en/images/header_02.jpg" onmouseover="this.src='../en/images/header_02c.jpg'" onmouseout="this.src='../en/images/header_02.jpg'" alt="中文" width="86" height="49" style="cursor:pointer; border: none;" /></a></td>
                <td><img src="../en/images/header_03c.jpg" alt="日本語" width="86" height="49" style="border: none;" /></td>
                <td><a href="/en/menu.aspx"><img src="../en/images/header_04.jpg" onmouseover="this.src='../en/images/header_04c.jpg'" onmouseout="this.src='../en/images/header_04.jpg'" alt="English" width="99" height="49" style="cursor:pointer; border: none;" /></a></td>                
            </tr>
            
        </table>
        <table border="0" cellpadding="0" cellspacing="0" class="word">
        	<tr>
            	<td style="width:300px; background:url(../en/images/bg02.png) center no-repeat;">&nbsp;</td>
                <td style="width:600px; font-size:12px;">
                    <asp:Literal ID="LiteContent" runat="server"></asp:Literal>
           		<br>
           		<br></td>
			</tr>
        </table>
</div>
</body>
</html>
