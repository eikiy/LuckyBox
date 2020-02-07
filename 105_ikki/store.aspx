<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store.aspx.cs" Inherits="store" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<META NAME="keywords" CONTENT="藝奇,新日本料理,藝奇 新日本料理, ikki, 藝奇餐廳地址,王品集團,藝奇網路會員優惠券,花旗您生日我請客"> 
<META NAME="description" CONTENT="經典日料 創藝呈現。嚴選當令新鮮食材，創新日式食藝玩味。汲取~日本專注細節。講究~當旬新鮮食材。添加~職人手藝創意。以靈感、巧思加持，激盪東京時尚料理新風貌。 "> 

<title>藝奇 ikki 新日本料理</title>
<script src="http://code.jquery.com/jquery-1.11.2.min.js"></script>
<script src="http://code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
<script type="text/javascript" src="js/jquery.vegas.js"></script>

<link rel="stylesheet" type="text/css" href="css/jquery.vegas.css" />
<link rel="stylesheet" type="text/css" href="css/main.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
<link rel="stylesheet" type="text/css" href="css/store.css" />
<link rel="stylesheet" type="text/css" href="css/footer_i.css" />

<script>

/* 以下為menu================*/



$(function(){
	// 幫 #menu li 加上 hover 事件
	$('#menu li').hover(function(){
		// 先找到 li 中的子選單
		var _this = $(this),
			_subnav = _this.children('ul');
 
		// 變更目前母選項的背景顏色
		// 同時淡入子選單(如果有的話)
		_this.css('backgroundColor', '#f00');
		_subnav.stop(true, true).fadeIn(400);
		
	} , function(){
		// 變更目前母選項的背景顏色
		// 同時淡出子選單(如果有的話)
		// 也可以把整句拆成上面的寫法
		$(this).css('backgroundColor', '').children('ul').stop(true, true).fadeOut(400);
	});
 
	// 取消超連結的虛線框
	$('a').focus(function(){
		this.blur();
	});
});


</script>

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>

<script type="text/javascript">

function MM_openBrWindow(theURL,winName,features) { //v2.0
  window.open(theURL,winName,features);
}
//-->
</script>

</head>

<!--<body onload="MM_openBrWindow('event/popup.htm','aa','toolbar=yes,location=yes,status=yes,menubar=yes,scrollbars=no,resizable=yes,width=720,height=216')">-->

<body>
<div class="wrapper">
<div class="logo"><a href="/index.html"><img src="images/logo.png" width="231" height="114"></a></div>
<div class="header"> 
<div style="background:#000; height:130px;">   
<ul id="menu">
        <li><a href="about.html"><span class="font_01">／</span> 關於藝奇</a>
			<ul>
				<li><a href="brand.html">品牌精神</a></li>
				<li><a href="charity.html">文創公益</a></li>
				<li><a href="art.html">嚐於藝</a></li>
			</ul>
		</li>
		<li class="here"><a href="store.aspx"><span class="font_01">／</span> 尋訪藝奇</a>
            <ul style="margin-left:111px;">
            	<li><a href="store.aspx">全台店舖資訊</a></li>
				<li><a href="http://cct.wowprime.com/cct/cctapp/cctwebreservation.do?&prog=cctweb_reservation&brnd_fid=MSJUW&stor" target="_blank" onClick=cy_action_conver('1829850','8tc2ajor','109','2'); "ga('send', 'event', { eventCategory: 'index', eventAction: 'click', eventLabel: 'ikpc_online_order'});" target="_blank">24hr線上訂位</a></li>
			</ul>
		</li>
		<li><a href="menu.html"><span class="font_01">／</span> 食藝之美</a></li>
		<li><a href="event.html"><span class="font_01">／</span> 創藝優惠</a></li>
        <li><a href="member.html"><span class="font_01">／</span> 會員專區</a>
        	<ul style="margin-left:270px;">
				<li><a href="member.html#link01">專屬優惠</a></li>
				<li><a href="member_join.aspx">加入會員</a></li>
				<li><a href="member.html#link02">會員資訊</a></li>
			</ul>
        </li>
        <li><a href="talk.aspx"><span class="font_01">／</span> 一起分享</a></li>
</ul>    
</div>
</div>

<div class="list side">
    	<table border="0" cellpadding="0" cellspacing="0" style="margin-top:20px;">
        	<tr>
            	<td><a href="#link01"><img src="images/area_02.jpg" onmouseover="this.src='images/areaa_02.jpg'" onmouseout="this.src='images/area_02.jpg'" alt="北北基" width="49" height="82" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="#link02"><img src="images/area_03.jpg" onmouseover="this.src='images/areaa_03.jpg'" onmouseout="this.src='images/area_03.jpg'" alt="桃竹苗" width="49" height="82" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="#link03"><img src="images/area_04.jpg" onmouseover="this.src='images/areaa_04.jpg'" onmouseout="this.src='images/area_04.jpg'" alt="中彰投" width="49" height="82" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="#link04"><img src="images/area_05.jpg" onmouseover="this.src='images/areaa_05.jpg'" onmouseout="this.src='images/area_05.jpg'" alt="雲嘉南" width="49" height="82" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="#link06"><img src="images/area_06.jpg" onmouseover="this.src='images/areaa_06.jpg'" onmouseout="this.src='images/area_06.jpg'" alt="高屏" width="49" height="82" style="cursor:pointer; border: none;" /></a></td>
            </tr>
        </table>
</div>
    
<div class="content">
	<div class="img">
	  <p><a href="http://cct.wowprime.com/cct/cctapp/cctwebreservation.do?&prog=cctweb_reservation&brnd_fid=MSJUW&stor" target="_blank" onClick=cy_action_conver('1829850','8tc2ajor','109','2'); "ga('send', 'event', { eventcategory: 'index', eventaction: 'click', eventlabel: 'ikpc_online_order'});"><img src="event/images/icon_eztable.png" width="271" height=""><a href="" target="_blank"></a></p>
	    <img src="images/menu/160516/img_store.png" width="271" height="888">
	    
	    <a href="http://cct.wowprime.com/cct/cctapp/cctwebreservation.do?&prog=cctweb_reservation&brnd_fid=MSJUW&stor" target="_blank" onClick=cy_action_conver('1829850','8tc2ajor','109','2'); "ga('send', 'event', { eventCategory: 'index', eventAction: 'click', eventLabel: 'ikpc_online_order'});"><br>
        <img src="event/images/icon_18tripadvisor.png" width="271" height="306"></a></p>
	</div>
    
	<div class="word">
	  <!--<span style="color:#f00; font-size:120%;">2/4(一)全台各店除夕公休一天，若有不便，敬請見諒！</span>-->

	  <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea4" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea5" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea6" runat="server"></asp:Literal>
    </div>	
        
</div>

</div>
<p><!--footer-->
</p>
<iframe src="/footer.html" width="100%" height="152" frameborder="0"></iframe>
    <iframe src="/rights.html" width="100%" height="60" frameborder="0" style="margin-top:-38px;"></iframe>


</div>

<!--歐米爾行銷CODE-->

<script type="text/javascript" class="Cym_dmp_tag">
var cy_src = 'pt.cymmetrics.com.tw/acjs/cyd_ikki.js';
var cym_ct = document.createElement('script');
var src = (location.protocol == 'https:') ? 'https://' : 'http://';
cym_ct.setAttribute('src',src+cy_src); cym_ct.charset = 'utf-8';
var cym_cts = document.getElementsByTagName('script')[0];
cym_cts.parentNode.insertBefore(cym_ct, cym_cts);
</script>


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