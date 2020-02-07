<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talk.aspx.cs" Inherits="en_talk" %>
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
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="../js/talk_en.js"></script>
<link href="en.css" rel="stylesheet" type="text/css" />
</head>

<body>
<form id="form1" name="form1" method="post" onsubmit="return checkdata();" runat="server">
	<div class="wripper">
    <div class="menu">
    	<table border="0" cellpadding="0" cellspacing="0" width="240">
        	<tr>
            	<td><a href="index.html"><img src="images/logo.png" width="240" height="116" border="0"></a></td>
            </tr>
            <tr>
            	<td><a href="store.aspx"><img src="images/menu_02.png" onmouseover="this.src='images/menu_02c.png'" onmouseout="this.src='images/menu_02.png'" alt="Branch" width="240" height="33" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="menu.aspx"><img src="images/menu_03.png" onmouseover="this.src='images/menu_03c.png'" onmouseout="this.src='images/menu_03.png'" alt="Menu" width="240" height="33" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="menu_v_en.htm"><img src="images/menu_04.png" onmouseover="this.src='images/menu_04c.png'" onmouseout="this.src='images/menu_04.png'" alt="Vegetarian Menu" width="240" height="33" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><img src="images/menu_05c.png" alt="Contact Us" width="240" height="33" style="c; border: none;" /></a></td>
            </tr>
            <tr>
            	<td style="width:240px; height:142px; background:url(images/menu_06.png);">
                </td>
            </tr>
        </table>
    </div>
    
    <div class="time">
                Business time: <br>‧ 11:30 - 14:30<br>　(Last order time 14:00)<br>
                ‧ 17:30 - 22:00<br>　(Last order time 21:00)
    </div>
    	<table border="0" cellpadding="0" cellspacing="0" width="900">
        	<tr>
            	<td style="width:629px; background:#fff;">&nbsp;</td>
                <td><a href="/index.html"><img src="images/header_02.jpg" onmouseover="this.src='images/header_02c.jpg'" onmouseout="this.src='images/header_02.jpg'" alt="中文" width="86" height="49" style="cursor:pointer; border: none;" /></a></td>
                <td><a href="/jp/menu.aspx"><img src="images/header_03.jpg" onmouseover="this.src='images/header_03c.jpg'" onmouseout="this.src='images/header_03.jpg'" alt="日本語" width="86" height="49" style="cursor:pointer; border: none;" /></a></td>
                <td><img src="images/header_04c.jpg" alt="English" width="99" height="49" style=" border: none;" /></td>
                
            </tr>
            
        </table>
        <table border="0" cellpadding="0" cellspacing="0" class="word">
        	<tr>
            	<td style="width:300px;">&nbsp;</td>
                <td style="width:600px;">
   		  <table width="92%" cellpadding="0" cellspacing="0" class="talk_all">
                            <tr>
                              <td colspan="2" class="f_02" style="padding-bottom:20px;">We appreciate you visiting our website. If you have further question, lease leave your message as below. We will get back to you as soon as we can if necessary.<br>
                              (All column should be filled)</td>
                              </tr>
                            <tr>
                              <td width="25%" class="f_01"><strong>▌Your Name</strong></td>
                              <td width="80%"><span class="t12_dgray member_g1">
                                <asp:TextBox ID="name" runat="server" Columns="35" CssClass="en_txtboder" 
                        MaxLength="20"></asp:TextBox>
                              </span></td>
                            </tr>
                            <tr>
                              <td class="f_01"><strong>▌Gender</strong></td>
                              <td>
                              <asp:RadioButtonList ID="sex" runat="server" CssClass="en_gray13" 
                        RepeatDirection="Horizontal">
                        <asp:ListItem Value="man">Male</asp:ListItem>
                        <asp:ListItem Value="woman">Female</asp:ListItem>
                    </asp:RadioButtonList>
                              </td>
                            </tr>

                            <tr>
                              <td class="f_01"><strong>▌Phone No. <br /><img src="../images/space.gif" width="8" height="1" />or Mobile No.</strong></td>
                              <td><span class="pt13">
                                <asp:TextBox ID="phone" runat="server" Columns="35" CssClass="en_txtboder" 
                        MaxLength="20" 
                onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
                              </span>e.g.0910123456 or 0212345678</td>
                            </tr>

                            <tr>
                              <td class="f_01"><strong>▌Your email</strong></td>
                              <td><span class="pt13">
                                <asp:TextBox ID="email" runat="server" Columns="35" CssClass="en_txtboder" 
                        MaxLength="80"></asp:TextBox>
                              </span></td>
                            </tr>
                            <tr>
                              <td class="f_01"><strong>▌Subject</strong></td>
                              <td><span class="pt13">
                                <asp:TextBox ID="subject" runat="server" Columns="35" CssClass="en_txtboder" 
                        MaxLength="50"></asp:TextBox>
                              </span></td>
                            </tr>                            
                            <tr>
                              <td class="f_01"><strong>▌Suggestions</strong></td>
                              <td><span class="t12_dgray member_g1">
                                <asp:TextBox ID="content" runat="server" Columns="32" Rows="5" 
                        TextMode="MultiLine"></asp:TextBox>
                              </span></td>
                            </tr>
                          </table>
           		<table width="92%" border="0" cellpadding="5" cellspacing="0">
      <tr>
        <td colspan="4" height="80" style="border:none; text-align:center; vertical-align:middle;">
        <asp:ImageButton ID="ImageButton1" runat="server" 
                          onmouseover="this.src='images/icon_submiti_en.jpg'" onmouseout="this.src='images/icon_submit_en.jpg'"
                          ImageUrl="images/icon_submit_en.jpg" onclick="ImageButton1_Click" />
        </td>
        </tr>
     </table>
                
                
           		<br>
           		<br>
           		<br>
           		<br></td>
			</tr>
        </table>
</div>
</form>
</body>
</html>