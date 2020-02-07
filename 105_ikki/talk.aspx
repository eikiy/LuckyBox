<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talk.aspx.cs" Inherits="talk" %>
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
<link rel="stylesheet" type="text/css" href="css/talk.css" />
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
<script src="http://code.jquery.com/jquery-1.11.2.min.js"></script>
<script src="js/talk.js"></script>

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>

</head>

<body>
<!-- Google Tag Manager -->
<noscript><iframe src="//www.googletagmanager.com/ns.html?id=GTM-TCF5FD"
height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'//www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-TCF5FD');</script>
<!-- End Google Tag Manager -->

<form id="form1" name="form1" method="post" onsubmit="return checkdata();" runat="server">
<input id="sex" name="sex" type="hidden" value="">
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
		<li><a href="store_pass_1101.aspx"><span class="font_01">／</span> 尋訪藝奇</a>
			<ul style="margin-left:111px;">
				<li><a href="store_pass_1101.aspx">全台店舖資訊</a></li>
				<li><a href="http://partner.eztable.com/booking.php?page_name=ikkicy_action_conver('1829850','8tc2ajor','109','2');" target="_blank">24hr線上訂位</a></li>
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
        <li class="here"><a href="talk.aspx"><span class="font_01">／</span> 一起分享</a></li>
</ul>    
</div>
</div>

<div class="list side">
    	<table border="0" cellpadding="0" cellspacing="0" style="margin-top:10px;">
        	<tr>
            	<td><img src="images/talk_01.jpg" alt="一起分享" width="49" height="145" style="border: none;" /></td>
            </tr>
        </table>
</div>
    
<div class="content">
<span class="anchor" style="*margin-top:-30px;"></span>
	<div class="img"><img src="images/img_talk.png" width="271" height="750" style="*margin-top:-130px;"></div>
	<div class="word">
          <table border="0" cellpadding="0" cellspacing="0">
            <tr>
              <th colspan="2">                親愛的顧客：
                  <br />
<!--<span style="color:#f00;">新春快樂！客服於春節期間(1/24～1/27)暫停服務，各分店營業狀況，請撥打分店專線查詢。謝謝～</span><br>-->
<br>
                您好！感謝您提供的寶貴意見， 讓我們有機會致力追求更極致的品味與服務。請您填寫正確連絡資料，我們將盡快以e-mail或電話方式與您聯繫，謝謝！<br><br>
             </th>
            </tr>
            <tr>
              <td colspan="2" class="ss" style="border:none;"></td>
            </tr>
            <tr>
                <td width="25%" class="font_04">▍姓名：</td>
                <td><span class="pt13">
                  <asp:TextBox ID="name" runat="server" CssClass="member_inputtxt" MaxLength="20"></asp:TextBox>
                </span></td>
            </tr>
            <tr>
                <td class="font_04">▍性別：</td>
                <td>
                    <TABLE border="0" cellpadding="0" cellspacing="0" id="Radlist" style="width:100%; margin:0;">
                  <tr>
                    <td width="7%" style="padding:0; border:0;"><a href="javascript:change_sex('woman');"><img name="woman" id="woman" src="images/woman1.png" width="35" height="39" border="0"></a></td>
                    <td style="padding:0; padding-left:10px; border:0;"><a href="javascript:change_sex('man');"><img name="man" id="man" src="images/man1.png" width="37" height="39" border="0"></a></td>
                 </tr>
      </TABLE>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="font_04">▍聯絡電話 (手機、電話二擇一填寫)：</td>
            </tr>
            <tr>
              <td class="font_04" style="padding-left:50px;">．手機：</td>
              <td><span class="t12_dgray member_g1">
                <asp:TextBox ID="mobile" runat="server" CssClass="member_inputtxt" 
                          MaxLength="10"></asp:TextBox>
              </span> 例如:0910123456</td>
            </tr>
            <tr>
              <td class="font_04" style="padding-left:50px;">．市話：</td>
              <td>區碼
                    (
                      <asp:TextBox ID="phone1" runat="server" CssClass="member_year" MaxLength="3" 
                          Width="15px" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
                    )
                      <asp:TextBox ID="phone2" runat="server" CssClass="member_year" MaxLength="8" 
                          Width="80px" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
                    #
                      <asp:TextBox ID="phone3" runat="server" CssClass="member_year" MaxLength="5" 
                          Width="40px" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
                    <br>例如:(02) 12345678#123
              </td>
            </tr>
            <tr>
              <td class="font_04">▍email 帳號：</td>
              <td><span class="pt13">
                <asp:TextBox ID="email" runat="server" CssClass="member_inputtxt" 
                          MaxLength="80"></asp:TextBox>
              </span></td>
            </tr>
            <tr>
              <td width="20%" class="font_04">▍店別：</td>
              <td><asp:DropDownList ID="store" runat="server" CssClass="talk_store">
                        </asp:DropDownList></td>
            </tr>
            <tr>
              <td class="font_04">▍主題：</td>
              <td><span class="pt13">
                <asp:TextBox ID="subject" runat="server" CssClass="member_inputtxt" 
                          MaxLength="50"></asp:TextBox>
              </span></td>
            </tr>
            <tr>
                <td class="font_04">▍內容：</td>
                <td><span class="t12_dgray member_g1">
                  <asp:TextBox ID="content" runat="server" Columns="40" CssClass="menu_text2" 
                          Rows="5" TextMode="MultiLine"></asp:TextBox>
                </span></td>
            </tr>
            <tr>
                <td colspan="2" style="padding:30px 0; border-bottom:none;"><asp:ImageButton ID="ImageButton1" runat="server" 
                          onmouseover="this.src='images/submit_a.png'" onmouseout="this.src='images/submit.png'"
                          ImageUrl="images/submit.png" onclick="ImageButton1_Click" style="border: none; margin-left:160px;" /></a></td>
            </tr>
	    </table>
    </div>	
        
</div>

</div>
<!--footer-->
	<iframe src="/footer.html" width="100%" height="152" frameborder="0"></iframe>


</div>
</form>
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