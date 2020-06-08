<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="e_member_application_index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<meta charset="utf-8">
<title>王品菁英獻禮</title>


<meta name="description" content="王品-只款待心中最重要的人">
<meta name="keywords" content="王品,牛排,菁英獻禮">
<meta property="og:title" content="王品菁英獻禮"/>
<meta property="og:description" content="王品-只款待心中最重要的人" />
<meta property="og:type" content="website" />

<!--手機解析度-->
<meta name="viewport" content="width=device-width, initial-scale=1.0">


<!--favor icon-->
<link rel="shortcut icon" href="../images/touch-icon/touch-icon-iphone.png" />


<!--touch_icon-->
<link rel="apple-touch-icon" href="../images/touch-icon/touch-icon-iphone.png" /> 
<link rel="apple-touch-icon" sizes="76x76" href="../images/touch-icon/touch-icon-ipad.png" /> 
<link rel="apple-touch-icon" sizes="120x120" href="../images/touch-icon/touch-icon-iphone-retina.png" />
<link rel="apple-touch-icon" sizes="152x152" href="../images/touch-icon/touch-icon-ipad-retina.png" />
<style type="text/css">
@import url("../css/reset.css");
</style>
<link href="../css/master.css" rel="stylesheet" type="text/css">
<!-- IE Fix for HTML5 Tags -->
<!--[if lt IE 9]>
<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->

<link rel="stylesheet" href="../css/font-awesome-4.6.1/css/font-awesome.min.css">

<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>
<style>
@font-face {
/*明體*/
  font-family: 'cwTeXMing';
  font-style: normal;
  font-weight: 500;
  src: url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.eot);
  src: url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.eot?#iefix) format('embedded-opentype'),
       url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.woff2) format('woff2'),
       url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.woff) format('woff'),
       url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.ttf) format('truetype');
}
</style>
<link href="../css/application.css" rel="stylesheet" type="text/css">
</head>

<body>
<form class="form" runat="server">

<div class="mainBox">


<header class="clearfix">
<div class="wrap">
<h1 class="logo"><a href="http://www.wangsteak.com.tw/" target="_blank">王品-只款待心中最重要的人</a></h1>
<a class="m-menu"><i class="fa fa-bars" aria-hidden="true"></i></a>




<nav class="open"><div class="m-menubox">
<a class="m-menu-close"><i class="fa fa-times" aria-hidden="true"></i></a>
<ul class="submenu"><a href="../index.htm"><i class="fa fa-home" aria-hidden="true"></i>活動首頁</a></ul>
<ul class="menu">
<li class="application"><a href="../application/index.aspx">申請電子菁英禮讚</a></li>
<li class="coupon"><a href="../coupon/index.aspx">領取電子優惠</a></li>
<li class="preferential"><a href="../preferential/index.htm">菁英年度好康優惠</a></li>
<li class="faq"><a href="../faq/index.htm">常見問題</a></li>
</ul><!--menu-->
</div><!--m-menubox--></nav>




</div><!--wrap-->
</header>





<div class="mainArea">

<div class="containerBox"><div class="wrap">
<h2>申請電子菁英禮讚</h2>


<div class="intro_txt">
<p class="paragraph">若您曾收過我們郵寄寄送的<strong>『菁英禮讚本』</strong>或<strong>『生日、結婚賀卡』</strong>，</p>
<p class="paragraph">您已經是菁英會員囉，登入手機與專屬條碼，即可領取電子優惠券。</p>
若您是王品網路會員請登入會員立即升等，領取電子優惠。
</div>

<ul class="loginbox">
<li class="clearfix"><h3>菁英會員</h3>
<h4 class="clearfix">會員手機<%--<input type="text">--%>
<asp:TextBox ID="Crm_Phone" runat="server"></asp:TextBox>
</h4>
<h4 class="clearfix">會員專屬條碼<%--<input type="text">--%>
<asp:TextBox ID="Crm_BarCode" runat="server"></asp:TextBox>
</h4>
<a href="../faq/#select08">什麼是專屬條碼？</a>

<div class="botton">
<%--<a href="inforation.htm">登入</a>--%>
<asp:Button ID="Button1" runat="server" Text="登入" onclick="Button1_Click1" />
</div>
</li>

<li class="clearfix"><h3>網路會員</h3>
若您是王品牛排網路會員，登入後即可成為菁英會員，領取專屬優惠。
<h4 class="clearfix">會員Email<%--<input type="text">--%>
<asp:TextBox ID="websiteMember_Email" runat="server"></asp:TextBox>
</h4>
<h4 class="clearfix">會員密碼<%--<input type="text">--%>
<asp:TextBox ID="websiteMember_PassWord" runat="server" TextMode="Password"></asp:TextBox>
</h4>

<div class="botton">
<%--<a href="fail.htm">登入</a>--%>
<asp:Button ID="Button2" runat="server" Text="登入" onclick="Button2_Click" />
</div>
</li>
</ul>


<div style="text-align:center;">
參加活動請先<a href="../../memberJoin.aspx" target="_blank">註冊</a>為網路會員
</div>



</div><!--wrap--></div><!--containerBox-->



</div><!--mainArea-->





</div><!--mainBox-->


<footer class="copyright">王品牛排 © Wang Steak. All rights reserved.</footer>


<script type="text/javascript">

$('.m-menu').click(function(){
	$("nav").stop(false, true).removeClass("open");
});


$('.m-menu-close').click(function(){
	$("nav").stop(false, true).addClass("open");
});



</script>
</form>
</body>
</html>
