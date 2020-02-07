<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="event_14_spring_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇 花見‧春饗  主廚限定招待</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">

</head>

<body style="overflow-x:hidden;">
<div class="white" style="height:435px;">
<div class="wrapper">

	<div class="area">
        <img src="images/login_02.png" width="980" height="73" border="0" usemap="#Map">
        <map name="Map">
          <area shape="rect" coords="44,-1,257,55" href="http://www.ikki.com.tw/">
        </map>
        <a href="index.html"><img src="images/login_04a.png" width="980" height="201" /></a>
        <table border="0" cellpadding="0" cellspacing="0" style="background:url(images/login_05a.png) no-repeat; width:980px; height:248px;">
   	  <tr>
            	<td width="60%">
                
<form id="form1" name="form1" method="post" action="" runat="server">
         <div class="login-area">
 		<table width="80%" border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td style="height:50px;"></td>
              <td></td>
              <td></td>
              <td></td>
              <td></td>
            </tr>
            <tr>
              <td width="15%">&nbsp;</td>
              <td width="15%"><font color="#ff0000">▌</font>email 帳號</td>
              <td width="27%"><asp:TextBox ID="txtEmail" runat="server" Width="135px"></asp:TextBox></td>
              <td></td>
              <td rowspan="2">
                  <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/btn_01.png" OnClick="ImageButton1_Click" /></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><font color="#ff0000">▌</font>密碼</td>
              <td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" Width="135px"></asp:TextBox></td>
              <td><a href="http://www.ikki.com.tw/member_forget.aspx" target="_blank">忘記密碼？</a></td>
              </tr>
             <tr>
              <td style="height:30px;"></td>
              <td></td>
              <td></td>
              <td></td>
              <td></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td colspan="4" style="color:#fff; padding-top:10px;"> (參加活動請先 <a href="http://www.ikki.com.tw/member_join.aspx" target="_blank" style="color:#e4b91f;">加入網路會員</a> 謝謝!)<Br>當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~</td>
              </tr>
          </table>
  </div>
            </form>

                </td>
                <td width="40%"></td>
            </tr>
        </table>
    <div style="height:30px;"></div>
    </div>
    
</div>
</div>
<div class="line"></div>

</body>
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
_uacct = "UA-2488504-1";
urchinTracker();
</script>
</html>