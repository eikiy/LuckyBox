<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login_ok.aspx.cs" Inherits="event_15_testmeal_login_ok" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>1+1双主餐 感恩粉絲試吃會 網路報名</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">

</head>

<body>
<form id="form" runat="server">
<div class="wrapper">
	<table border="0" cellpadding="0" cellspacing="0" style="width:60%; margin:0 auto;">
         <tr>
          <td>
        <div class="login-area">
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
            <td width="5%">&nbsp;</td>
              <td><span class="font01">報名成功！</span></td>
              </tr>
          </table><br><br>
          
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td colspan="2">
                  <%--王小明 --%>
                  <asp:Label ID="lblName" runat="server" Text="Label"></asp:Label>
                  貴賓  您好：<br />您已成功報名1+1双主餐感恩粉絲試吃會，預祝您嚐鮮愉快！<br />以下為活動當日注意事項：
              </td>
              </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="3" style="border-bottom:#eee 2px solid;">&nbsp;</td>
              </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="20%"><font color="#ff0">▌</font>報到編號：</td>
              <td><span class="font01">
                  <%--A01, B01--%>
                   <asp:Label ID="LabelA" runat="server" ></asp:Label>
                   <asp:Label ID="LabelB" runat="server" ></asp:Label>
                  </span></td>
              </tr>
          </table>
        <br>
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="20%"><font color="#ff0">▌</font>場次時間：</td>
              <td>
              <%--6/16(二) 18:30~20:30 藝奇<a href="http://www.ikki.com.tw/store_all.aspx?#id10501" target="_blank">台北敦化北店</a>--%>
              <asp:Label ID="Label_STAGE" runat="server" ></asp:Label>
              <asp:HyperLink ID="HyperLink_STAGE" runat="server">HyperLink</asp:HyperLink>
              
              </td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td style="vertical-align:top;"><font color="#ff0">▌</font>入場需知：
              </td>
              <td><ol>
                <li>請攜帶身份證明文件，並出示【本試吃邀請函】(<a href="#" title="列印本頁" onclick="window.print(); return false;">列印</a> / 儲存畫面)<br />
                  18:30前完成報到進場。</li>
                  <li>活動小組將事前準備，當日若不克前往或有其他問題，<br>請於<span class="font03">6/12</span>前主動來信告知活動小組：<a href="mailto:marketing@ikki.com.tw">marketing@ikki.com.tw</a><br>
                  感謝您的配合。　　　　　　　　　　　　</li>
              </ol></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td colspan="2" style="border-bottom:#eee 2px solid;">&nbsp;</td>
              </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td colspan="2">我們的用心，期待您的光臨，謝謝！</td>
              </tr>
            </table>
          
      </div>
            
            </td>
        </tr>
        <tr>
        	<td><br />
       	    <br />
       	    <br /></td>
        </tr>
    </table>
</div>
</form>
</body>
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>
</html>

