<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store_print.aspx.cs" Inherits="store_print" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<META NAME="keywords" CONTENT="藝奇,新日本料理,藝奇 新日本料理, ikki, 藝奇餐廳地址,王品集團,藝奇網路會員優惠券,花旗您生日我請客"> 
<META NAME="description" CONTENT="經典日料 創藝呈現。嚴選當令新鮮食材，創新日式食藝玩味。汲取~日本專注細節。講究~當旬新鮮食材。添加~職人手藝創意。以靈感、巧思加持，激盪東京時尚料理新風貌。 "> 

<title>藝奇 ikki 新日本料理</title>
<link rel="stylesheet" type="text/css" href="css/main.css" />

<style>
.word {width:700px; margin:15px;}
.word table td{ padding:10px; vertical-align:top; border-bottom:1px #ccc dashed;}
.word a{ font-size:120%; color:#d6000f; text-decoration:none; }
.word a:hover{ color:#333; text-decoration:underline; }

.word_all{padding:30px 15px; width:92%;}
.word_all table{width:95%; margin:15px 0 30px 30px;}
.word_all table td{vertical-align:top; padding:7px;}

.info{width:400px;}
.info table{ margin-right:10px;}
.info td{ padding:10px; vertical-align:top; border-bottom:1px #ccc dashed;}

.font_02{color:#f00; font-size:120%; font-weight:bold;}
.font_01{color:#f00;}

</style>

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>

</head>

<body onLoad="javascript:window.print()" style="background:#fff;">
<table border="0" cellpadding="0" cellspacing="0" class="word">
        <tr>
       	  <td>
          <table border="0" cellpadding="0" cellspacing="0" class="info">
            <tr>
              <td colspan="2"class="font_02" >▍<asp:Literal ID="LiteName" runat="server"></asp:Literal> ▍</td>
            </tr>
             <asp:Literal ID="LiteNew" runat="server"></asp:Literal>
            <tr>
              <td width="25%">店址：</td>
              <td><asp:Literal ID="LiteAddress" runat="server"></asp:Literal></td>
            </tr>
            <tr>
              <td>電話：</td>
              <td><asp:Literal ID="LitePhone" runat="server"></asp:Literal></td>
            </tr>
            <tr>
              <td>營業時間：</td>
              <td><asp:Literal ID="LiteTime" runat="server"></asp:Literal></td>
            </tr>
            <asp:Literal ID="LiteContent" runat="server"></asp:Literal>
            <asp:Literal ID="LiteSeat" runat="server"></asp:Literal>
            <asp:Literal ID="LiteOther" runat="server"></asp:Literal>
          </table>

          </td>
       	  <td style="text-align:right; vertical-align:top;"><br><asp:Literal ID="LiteMap" runat="server"></asp:Literal><br></td>
   	    </tr>
    </table>
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
