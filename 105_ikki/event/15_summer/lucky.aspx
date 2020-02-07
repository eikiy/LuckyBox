<%@ Page Language="C#" AutoEventWireup="true" CodeFile="lucky.aspx.cs" Inherits="event_15_summer_lucky" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>

<head>

<title>藝奇 新日本料理 十周年感恩祭 729浴衣饗口福 網路報名</title>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">
<script type="text/javascript">
<!--
function MM_openBrWindow(theURL,winName,features) { //v2.0
  window.open(theURL,winName,features);
}
//-->
</script>
</head>

<body>
<form id="form" runat="server">
<br><br>
	<table border="0" cellpadding="0" cellspacing="0" style="width:800px; margin:0 auto;">
         <tr>
          <td>
        <div class="login-area">
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="20%"><font color="#f00">▌</font>email 帳號：</td>
              <td>
                <%--<input type="text" name="textfield" id="textfield"> --%>
                <asp:TextBox ID="txtEmail" CssClass ="text" runat="server"></asp:TextBox>

                (請填寫藝奇會員email帳號)</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#f00">▌</font>密碼：</td>
                <td>
                
               <%-- <input type="text" name="textfield" id="textfield"> --%>
                <asp:TextBox ID="txtPwd" runat="server" CssClass="text" MaxLength="8" TextMode="Password" ></asp:TextBox>
                
                 (<A href="/member_forget.aspx" target="_blank">忘記密碼</A>)
                </td>
              </tr>
          </table>
          
          <br><br> 
          <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td>
              ※ 參加活動請先<A href="/member_join.aspx" target="_blank">加入藝奇網路會員</A>。<br>
              ※ 凡於留言牆Tag好友完成留言後同步發表於個人FB，並登入藝奇網站會員者即有抽獎資格。<br>
              ※ 每組會員帳號有乙次抽獎機會，當週若未中獎，抽獎機會可累積至下週，中獎後即不再具抽獎資格。<br>
              ※ 7/10、7/17、7/24、7/31於活動頁面公告中獎名單，請確實填寫資料，以利獎項順利寄達。<br>
              ※ 如有問題請來信：<a href="mailto:marketing@ikki.com.tw">marketing@ikki.com.tw</a>。<br>
			  ※ 當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~<br>
              ※ <a href="#" class="member_p1" onclick="MM_openBrWindow('tips01.html','','scrollbars=yes,width=550,height=600')">更多注意事項請點我</a></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
              </tr>
              <tr>
                <td><br></td>
                <td style="text-align:center;">
                 <%--<a href="lucky_ok.aspx">                 
                 <img src="images/btn_lucky.png" 
                 onmouseover="this.src='images/btn_luckya.png'"
                  onmouseout="this.src='images/btn_lucky.png'" 
                  alt="" width="233" height="84" style="cursor:pointer; border: none; margin:0 auto;" />
                 </a> --%>
                 
                 
                 <asp:ImageButton ID="ImageButton1" runat="server" 
                 ImageUrl="images/btn_lucky.png"  
                 onmouseover="this.src='images/btn_luckya.png'" 
                 onmouseout="this.src='images/btn_lucky.png'" onclick="ImageButton1_Click"
                 alt="" width="233" height="84" style="cursor:pointer; border: none; margin:0 auto;"/>            
                  
                  </td>
              </tr>
          </table>
      </div>
            
            </td>
        </tr>
    </table>
</form>
</body>
<!-- Google Tag Manager -->
<noscript><iframe src="//www.googletagmanager.com/ns.html?id=GTM-TCF5FD"
height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'//www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-TCF5FD');</script>
<!-- End Google Tag Manager -->
</html>

