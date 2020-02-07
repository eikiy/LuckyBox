<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_cancel.aspx.cs" Inherits="member_cancel" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<META NAME="keywords" CONTENT="藝奇,新日本料理,藝奇 ikki 新日本料理,藝奇餐廳地址,王品集團,藝奇網路會員優惠券,花旗您生日我請客"> 
<META NAME="description" CONTENT="經典日料 創藝呈現。嚴選當令新鮮食材，創新日式食藝玩味。汲取~日本專注細節。講究~當旬新鮮食材。添加~職人手藝創意。以靈感、巧思加持，激盪東京時尚料理新風貌。 "> 

<title>藝奇 ikki 新日本料理</title>
<script src="http://code.jquery.com/jquery-1.11.2.min.js"></script>
<script src="http://code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
<script type="text/javascript" src="js/jquery.vegas.js"></script>

<link rel="stylesheet" type="text/css" href="css/jquery.vegas.css" />
<link rel="stylesheet" type="text/css" href="css/main.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
<link rel="stylesheet" type="text/css" href="css/member.css" />
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
<script src="js/login.js" type="text/javascript"></script>

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
<form id="form1" runat="server" onsubmit="return checkdata();">
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
				<li><a href="http://partner.eztable.com/booking.php?page_name=ikki" target="_blank">24hr線上訂位</a></li>
			</ul>
		</li>
		<li><a href="menu.html"><span class="font_01">／</span> 食藝之美</a></li>
		<li><a href="event.html"><span class="font_01">／</span> 創藝優惠</a></li>
      <li class="here"><a href="member.html"><span class="font_01">／</span> 會員專區</a>
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
            	<td><a href="member.html#link01"><img src="images/member_02.jpg" onmouseover="this.src='images/membera_02.jpg'" onmouseout="this.src='images/member_02.jpg'" alt="專屬優惠" width="49" height="98" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="member_join.aspx"><img src="images/member_03.jpg" onmouseover="this.src='images/membera_03.jpg'" onmouseout="this.src='images/member_03.jpg'" alt="加入會員" width="49" height="98" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="member.html#link02"><img src="images/membera_04.jpg" alt="會員資訊" width="49" height="98" style="cursor:pointer; border: none;" /></a></td>
            </tr>
        </table>
</div>
    
<div class="content">
	<div class="img"><img src="images/img_member.png" width="271" height="888"></div>
	<div class="word" style="height:750px;">
      
      <span class="anchor" style="*margin-top:-30px;"></span>
      <img src="images/icon_cancel.png" width="630" height="45">
      <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="border:none;">請輸入會員資料即可取消訂閱！謝謝！</td>
            </tr>
      </table>

      <table border="0" cellpadding="0" cellspacing="0" style="margin-top:-20px;">
        <tr>
      <td width="20%" class="font_04">▍email 帳號</td>
      <td colspan="2" >
      <asp:TextBox 
                                  ID="txtEmail" class="member_inputtxt"  runat="server" MaxLength="80" Width="150px"></asp:TextBox>
      </td>
      </tr>
    <tr>
      <td class="font_04">▍密碼</td>
      <td colspan="2">
         <asp:TextBox 
                                  ID="txtPwd" class="member_inputtxt"  runat="server" MaxLength="8" TextMode="Password" Width="150px"></asp:TextBox>
      </td>
    </tr>
     <tr>
      <td class="font_04">▍驗證碼</td>
      <td>
         <asp:TextBox ID="code" runat="server" CssClass="member_year" MaxLength="5" 
                          Width="50px"></asp:TextBox><br>
                          <div style="height:10px; width:1px;"></div>
                          <iframe name="imgcode" id="imgcode" src="m/code.aspx" width="120" height="50" scrolling="no" frameborder="0"></iframe>
      </td>
      <td style="vertical-align:bottom;">
      <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();">&larr;更換別組圖示</a> <br />(請輸入圖片中文字，不分大小寫)
      </td>
     </tr>
        <tr>
          <td colspan="3">如果您<a href="member_forget.aspx">忘記密碼</a>，請提供 email 帳號，我們將以電子郵件的方式告知。</td>
        </tr>
    </table>   <asp:ImageButton  ID="ImageButton1" runat="server" 
            ImageUrl="images/submit.png" onmouseover="this.src='images/submit_a.png'" 
            onmouseout="this.src='images/submit.png'" alt="" width="285" height="51" 
            style="cursor:pointer; border: none; margin-left:180px" 
            onclick="ImageButton1_Click"/>
</div>	
</div>

</div>
<!--footer-->
	<iframe src="/footer.html" width="100%" height="152" frameborder="0"></iframe>
    <iframe src="/rights.html" width="100%" height="60" frameborder="0" style="margin-top:-38px;"></iframe>


</div>
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