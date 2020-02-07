<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="event_14_summertour_login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">

<html>
<head>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/login.css">
</head>

<body style="background:#d7000f;">
    <form id="form1" runat="server">
<div class="login-area">
	<img src="images/step_01.jpg">
 		<table width="100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td width="15%">&nbsp;</td>
              <td width="10%"><font color="#000">▌</font>email 帳號</td>
              <td width="20%">
                  &nbsp;<asp:TextBox ID="txtEmail" runat="server" Width="180px" MaxLength="80"  class="member_inputtxt"></asp:TextBox>
                </td>
              <td colspan="2">                 
              </td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><font color="#000">▌</font>密碼</td>
              <td>&nbsp;<asp:TextBox ID="txtPwd" runat="server" TextMode="Password" class="member_inputtxt"  maxlength="8" Width="180px"></asp:TextBox></td>
              <td colspan="2"><a href="/member_forget.aspx" target="_blank">忘記密碼？</a></td>
            </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="4" style="padding:10px 0 10px 160px;">
                  <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="下一步" />
                    &nbsp;</td>
              </tr>
              <tr>
                <td style="text-align:right; vertical-align:top;" class="line">貼心提醒：</td>
                <td colspan="4" class="line">
                <ol>
                    <li>參加活動請先 <a href="/member_join.aspx" target="_blank">加入網路會員</a> 謝謝!</li>
                    <li>每消費乙客套餐有一次抽獎機會，消費越多，中獎機會越大。</li>
                    <li>每張發票只能輸入一次，重複輸入視同無效。</li>
                    <li>請您妥善保留發票影本，以便日後中獎驗證之用。</li>
                    <li style="color:#FF0; font-weight:bold;">
                        登錄最後時間點：請於8/17(日)23:59前，上網完成登錄發票，即可具備抽獎資格。</li>
                    <li>當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~</li>
                </ol>
                </td>
              </tr>
          </table>
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
