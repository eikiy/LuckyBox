<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="event_14_summer_login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇新日本料理 夏日嚐鮮祭 美味發表 優惠双享</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">

</head>

<body style="overflow-x:hidden;">
  <form id="form1" runat="server">
<div class="wrapper">
	<table border="0" cellpadding="0" cellspacing="0">
    	<tr>
        	<td><img src="images/index_02.jpg" border="0" usemap="#Map">
        	  <map name="Map">
       	        <area shape="rect" coords="12,403,225,547" href="http://www.coolpix.com.tw/shop/shop_digital_detail.php?shop_digital_ID=260&show_menu=S4" target="_blank">
                <area shape="rect" coords="195,89,496,400" href="index.html" />
      	    </map>
            </td>
            <td><img src="images/index_03.gif" border="0" usemap="#Map3">
            <map name="Map3">
                  <area shape="poly" coords="73,37,80,286,329,279,430,184,433,35,130,17" href="share.html">
                  <area shape="poly" coords="432,194,291,324,134,322,131,449,478,447,478,204" href="login.aspx">
            </map>
            </td>
        </tr>
        <tr>
        	<td colspan="2"><img src="images/login_05.jpg" border="0" width="980" height="251">
            </td>
        </tr>
         <tr>
        	<td colspan="2">
            
            <div class="login-area">
 		<table width="100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td width="10%">&nbsp;</td>
              <td width="12%"><font color="#000">▌</font>email 帳號</td>
              <td width="20%">
                  <asp:TextBox ID="txtEmail" runat="server" Width="180px" MaxLength="80"  class="member_inputtxt"></asp:TextBox>
                </td>
              <td width="10%"></td>
              <td rowspan="4">
                  <asp:ImageButton ID="ImageButton1" runat="server" 
                      ImageUrl="images/btn_download.png" onclick="ImageButton1_Click" />
                </td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><font color="#000">▌</font>密碼</td>
              <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" class="member_inputtxt"  maxlength="8" Width="180px"></asp:TextBox></td>
              <td><a href="/member_forget.aspx" target="_blank">忘記密碼？</a></td>
            </tr>
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><br></td>
                <td colspan="3"><span style="padding-top:10px;">(參加活動請先 <a href="/member_join.aspx" target="_blank">加入網路會員</a> 謝謝!)<br>
                當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~</span></td>
              </tr>
          </table>
      </div>
            
            </td>
        </tr>
        <tr>
        	<td colspan="2"><img src="images/login_07.jpg" usemap="#Map2">
            <map name="Map2">
              <area shape="rect" coords="711,50,850,118" href="http://tw.openrice.com/northern/restaurant/index.htm" target="_blank">
              <area shape="rect" coords="856,45,929,118" href="http://www.coolpix.com.tw/complex_activity11/activity_ifo.php?ikki" target="_blank">
            </map>
            </td>
        </tr>
    </table>
</div>
</div>
</form>
</body>
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
_uacct = "UA-2488504-1";
urchinTracker();
</script>
</html>
