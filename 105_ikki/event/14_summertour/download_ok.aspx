<%@ Page Language="C#" AutoEventWireup="true" CodeFile="download_ok.aspx.cs" Inherits="event_14_summertour_download_ok" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/login.css">
</head>

<body style="background:#d7000f;">
<form id="form1" runat="server">
<div class="login-area">
<img src="images/step_04.jpg">
 		<table width="100%" border="0" cellpadding="0" cellspacing="0">
              <tr>
                <td width="10%" style="text-align:right; vertical-align:top;" class="line">&nbsp;</td>
                <td width="15%" colspan="4" class="line">  <asp:Label ID="labCName" runat="server"></asp:Label> 貴賓，<br>
                  登入成功！感謝您的下載！(請點選券面直接列印) </td>
                <td class="line">&nbsp;</td>
              </tr>
              <tr>
                <td style="text-align:right; vertical-align:top;">&nbsp;</td>
                <td colspan="4"><a href="#" title="列印本頁" onclick="window.print(); return false;"><img src="images/coupon.jpg" width="500" height="250" style="border:1px dotted #ccc;"></a></td>
                <td>&nbsp;</td>
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
