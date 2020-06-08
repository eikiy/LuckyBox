<%@ Page Language="C#" AutoEventWireup="true" CodeFile="coupon.aspx.cs" Inherits="e_member_coupon_coupon" %>

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
<link href="../css/coupon.css" rel="stylesheet" type="text/css">
</head>

<body>
    <form id="form2" runat="server">

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

<div class="containerBox">
<div class="wrap">
<h2>領取電子優惠</h2>
<div class="intro_txt">王品貴賓 <asp:Label ID="lblName" runat="server" Text=""></asp:Label> 您好，以下為您的電子優惠券</div><!--titlebox-->
</div><!--wrap-->
</div><!--containerBox-->

<asp:Panel ID="Panel_6QR" runat="server">
  
<div class="coupon"><div class="wrap">
<h3>第二客6折 優待券</h3>
<div class="txt">8/10~10/31憑券至王品牛排消費套餐尊享【第二客6折】款待<br/>
<span style="color:#e60021;">(貼心提醒：本券限平日使用，限用乙次且使用後立即失效)</span></div>


<div class="ticket-style01">
<div class="box clearfix">
<div class="Img clearfix">
<img src="images/img01.jpg" alt=""/></div><!--Img-->
<div class="Txt">
<div class="Qrcode">
<%--<img src="images/qrcode.png" alt=""/>--%>
<asp:Image ID="Image_6QR" runat="server" width="180" height="180"/>
<br><%--A07800000019--%>
<asp:Label ID="lblBarcode_6QR" runat="server" Text=""></asp:Label>
</div><!--Qrcode-->
<h6>這是給 <asp:Label ID="lblName_coupon" runat="server" Text=""></asp:Label> 的</h6>
<h5>第二客6折 優待券</h5><br>
注意事項：<br>
(1) 優惠券使用期限：2016/8/10~2016/10//31。<br>
(2) 憑券消費兩客套餐享第二客6折優惠。<br>
(3) 每券僅享乙客6折優惠，10%服務費另計。<br>
(4) 結帳時請出示本券，8/10~10/31每券限用乙次後即失效。<br>
(5) 本券限週一至週五平日使用，週六、週日及國定假日皆不適用。<br>
(6) 不適用外帶、禮券購買且不得與其它折扣優惠併用。<br>
(7) 專案活動恕不適用禮品兌換(生日/結婚/菁英禮品等)。<br>
(8)本券為有價證券，若使用後恕不補發，請妥善保存本券。<br>
(9)本券重複使用無效，如涉及偽造情節重大者，宜睿智慧(股)公司及王品集團將依法追究。
</div><!--Txt-->
</div><!--box-->
<div class="redbottom"><img src="images/logos.jpg" width="175" height="35" />　　　<span>使用資訊查詢　www.wangsteak.com.tw</span><span>免付費意見專線 0800-071-198</span><span>網路專用影印無效</span></div><!--redbottom-->
</div><!--ticker-style01-->


</div><!--wrap--></div><!--coupon-->

</asp:Panel>





  <div class="coupon"><div class="wrap">
<h3>菁英會員•專屬禮遇</h3>
<div class="txt">
  <p class="paragraph">您可以列印本券，憑券至全台王品消費套餐，尊享9折+菁英禮乙份款待。</p>
</div>



<div class="ticket-style02">
<div class="box clearfix">

<div class="Qrcode"><h5>菁英禮讚</h5>
<%--<img src="images/qrcode.png" alt=""/>--%>
<asp:Image ID="Image_e_member9" runat="server" width="180" height="180"/>
<br><%--A07800000019--%>
<asp:Label ID="lblBarcode_e_member9" runat="server" Text=""></asp:Label>
</div><!--Qrcode-->

<div class="Txt">
<h6>這是給<asp:Label ID="lblName_e_member9" runat="server" Text=""></asp:Label>的</h6>
<span style="font-size:26px; color:#e41c3c;">菁英獻禮</span><span style="font-size:26px;"> 優惠券</span><br><br>

<span class="list">憑券消費$1350套餐尊享【九折+菁英禮】乙份款待。</span>
<span class="list">每桌、每次消費限使用本券乙次，10%服務費另計。</span>
<span class="list">禮品以現場實物為主，限量贈送贈完改贈其它禮品</span>
<span class="list">本券不適用禮券購買且不與其它折扣優惠或網路下載券併用。</span>
<span class="list">本優惠券適用台灣直營店。</span>
<span class="list">使用期限至 
<asp:Label ID="lblExpiredDate_e_member9" runat="server" Text=""></asp:Label> </span>
</div><!--Txt-->

<div class="Img"><img src="images/conpon_e_member9.jpg" alt=""/></div><!--Img-->
</div><!--box-->
<div class="redbottom"><img src="images/logos.jpg" width="175" height="35" />　　　<span>使用資訊查詢　www.wangsteak.com.tw</span><span>免付費意見專線 0800-071-198</span><span>網路專用影印無效</span></div><!--redbottom-->
</div><!--ticker-style02-->




<div class="box" style="margin-top:30px;"><input type="button" value="列印" onClick="window.print()" class="btn btn-primary"></div>
 </div><!--wrap--></div><!--coupon-->

 <asp:Panel ID="Panel_birthday" runat="server">
 <div class="coupon"><div class="wrap">
<h3>生日券兌換</h3>
<div class="txt">
<p class="paragraph">王品祝您生日快樂~</p>
<p class="paragraph">您可以列印本券，憑券至全台王品消費套餐，壽星尊享75折乙客款待。</p>
</div>



<div class="ticket-style02">
<div class="box clearfix">

<div class="Qrcode">
  <h5>生日券</h5>
<%--<img src="images/qrcode.png" alt=""/>--%>
<asp:Image ID="Image_birthday" runat="server" width="180" height="180"/>
<br><%--A07800000019--%>
<asp:Label ID="lblBarcode_birthday" runat="server" Text=""></asp:Label>
</div><!--Qrcode-->

<div class="Txt">
<h6>致獻<asp:Label ID="lblName_birthday" runat="server" Text=""></asp:Label></h6>
<p><span style="font-size:26px;"> 生日祝福</span><span style="font-size:26px; color:#e41c3c;">75折款待</span><br>
  
    <span class="list">憑券並核對證件，壽星消費$1350套餐尊享75折乙客款待。</span>
  <span class="list">每桌每次消費限用本券乙張，10%服務費另計。</span>
  <span class="list">不適用外帶且不與其它折扣優惠併用，擇一優惠券使用。</span>
  <span class="list">本券為有價證券，若使用後恕不補發，請妥善保存本券。</span>
  <span class="list">適用於台灣王品直營店，如涉及偽造者將依法追究。</span></p>
<p>
  <span class="list">使用期限至 
    <asp:Label ID="lblExpiredDate_birthday" runat="server" Text=""></asp:Label>
  </span></p>
</div><!--Txt-->

<div class="Img"><img src="/styles/images/conpon-birthday.jpg" alt="" width="347" height="287"/></div><!--Img-->
</div><!--box-->
<div class="redbottom"><img src="images/logos.jpg" width="175" height="35" />　　　<span>使用資訊查詢　www.wangsteak.com.tw</span><span>免付費意見專線 0800-071-198</span><span>網路專用影印無效</span></div><!--redbottom--></div><!--ticker-style02-->




<div class="box" style="margin-top:30px;"><input type="button" value="列印" onClick="window.print()" class="btn btn-primary"></div>
 </div><!--wrap--></div><!--coupon-->

 </asp:Panel>




<asp:Panel ID="Panel_marry" runat="server">

<div class="coupon"><div class="wrap">
<h3>結婚券兌換</h3>
<div class="txt">
<p class="paragraph">王品祝您結婚快樂~</p>
<p class="paragraph">您可以列印本券，憑券至全台王品消費套餐，貼心禮遇結婚禮乙組。</p>
</div>



<div class="ticket-style02">
<div class="box clearfix">

<div class="Qrcode">
  <h5>結婚券</h5>
<%--<img src="images/qrcode.png" alt=""/>--%>
<asp:Image ID="Image_marryday" runat="server" width="180" height="180"/> <br>
<%--A07800000019--%>
<asp:Label ID="lblBarcode_marryday" runat="server" Text=""></asp:Label></div><!--Qrcode-->

<div class="Txt">
<h6>致獻
  <asp:Label ID="lblName_marryday" runat="server" Text=""></asp:Label>
</h6>
<span style="font-size:26px;"> 臻愛獻禮</span><span style="font-size:26px; color:#e41c3c;"> 栢司金禮品乙組款待</span><br>
<br>

<span class="list">憑券消費套餐致贈限量【結婚禮品】乙組(市價$800)。</span>
<span class="list">每桌每次消費限用本券乙次，適用於台灣王品直營店。</span>
<span class="list">禮品以實物為主，若送完則改贈其他等值禮品。</span>
<span class="list">本券不得再與折扣優惠併用，擇一優惠使用。</span>
<span class="list">使用期限至 
<asp:Label ID="lblExpiredDate_marryday" runat="server" Text=""></asp:Label></span>
</div><!--Txt-->

<div class="Img"><img src="/e_member/coupon/images/conpon-2017marry.jpg"></div><!--Img-->
</div><!--box-->
<div class="redbottom"><img src="images/logos.jpg" width="175" height="35" />　　　<span>使用資訊查詢　www.wangsteak.com.tw</span><span>免付費意見專線 0800-071-198</span><span>網路專用影印無效</span></div><!--redbottom-->
</div><!--ticker-style02-->




<div class="box" style="margin-top:30px;"><input type="button" value="列印" onClick="window.print()" class="btn btn-primary"></div>
 </div><!--wrap--></div><!--coupon-->

 </asp:Panel>





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

