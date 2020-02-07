<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_edit.aspx.cs" Inherits="member_edit" %>
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
<script src="js/edit.js"></script>

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
<form id="form1" name="form1" method="post" action="member_edit.aspx" onsubmit="return checkdata();" runat="server">
<input id="hide_year2" name="hide_year2" type="hidden" value="" runat="server" />
<input id="hide_month2" name="hide_month2" type="hidden" value="" runat="server" />
<input id="hide_day2" name="hide_day2" type="hidden" value="" runat="server" />
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
	<div class="word">
      
      <span class="anchor" style="*margin-top:-30px;"></span>
      <img src="images/icon_member_04.png" width="630" height="45">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="border:none;">提醒您~您所填寫的資料將成為日後網路活動中獎通知的依據，請務必正確填寫。
                </td>
            </tr>
      </table>
      <table border="0" cellpadding="0" cellspacing="0" style="margin-top:-20px;">
    <tr>
      <td colspan="3" class="font_04">▍必填的~</td>
      </tr>
    <tr>
      <td width="20%" class="font_04">▍姓名</td>
      <td colspan="2" ><span class="member_g1">
        <asp:TextBox ID="name" 
                          runat="server" CssClass="member_inputtxt" MaxLength="20"></asp:TextBox>
      </span></td>
      </tr>
    <tr>
      <td class="font_04">▍暱稱</td>
      <td colspan="2"><span class="member_g1">
        <asp:TextBox ID="nickname" runat="server" CssClass="member_inputtxt" 
                          MaxLength="20"></asp:TextBox>
      </span></td>
    </tr>
     <tr style="display:none;">
      <td class="font_04">▍email 帳號</td>
      <td colspan="2"><span class="t12_dgray member_g1">
        <asp:TextBox ID="email" runat="server" CssClass="member_inputtxt" 
                          MaxLength="80" onblur="checkuser();"></asp:TextBox>
      </span> 點選email信箱確認信函後,帳號即可啟用</td>
    </tr>
    <tr>
      <td class="font_04">．結婚紀念日</td>
      <td colspan="2">
     <asp:DropDownList ID="year2" runat="server" CssClass="member_year">
                          <asp:ListItem Value="">年</asp:ListItem>
                      </asp:DropDownList>
                      <asp:DropDownList ID="month2" runat="server" CssClass="member_year">
                          <asp:ListItem Value="">月</asp:ListItem>
                      </asp:DropDownList>
                        <asp:DropDownList ID="day2" runat="server" CssClass="member_year">
                          <asp:ListItem Value="">日</asp:ListItem>
                      </asp:DropDownList>
      </td>
    </tr>
    <tr>
      <td colspan="3" class="font_04">▍聯絡電話 (手機、電話二擇一填寫)</td>
      </tr>
    <tr>
      <td class="font_04">．手機</td>
      <td colspan="2"><span class="member_g1">
        <asp:TextBox ID="mobile" runat="server" CssClass="member_inputtxt" 
                          MaxLength="10"></asp:TextBox>
      </span> 例如:0910123456</td>
    </tr>
    <tr>
      <td class="font_04">．市話</td>
      <td colspan="2">區碼
                    (
                      <asp:TextBox ID="phone1" runat="server" CssClass="member_year" MaxLength="3" 
                          Width="15px" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
                    )
                      <asp:TextBox ID="phone2" runat="server" CssClass="member_year" MaxLength="8" 
                          Width="80px" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
                    #
                      <asp:TextBox ID="phone3" runat="server" CssClass="member_year" MaxLength="5" 
                          Width="40px" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
<br>
例如:(02) 12345678#123</td>
    </tr>
    <tr>
      <td class="font_04">▍地址</td>
      <td colspan="2"><select id="city" name="city" onChange="get_zipcode(this.value);">
                          <option value="">縣市別</option>
                          <asp:Literal ID="LiteCity" runat="server"></asp:Literal>
                      </select>
&nbsp;<select id="zipcode" name="zipcode">
          <option value="">行政區</option>
          <asp:Literal ID="LiteZipcode" runat="server"></asp:Literal>
        </select>
&nbsp;<asp:TextBox ID="address" runat="server" CssClass="member_inputtxt" MaxLength="100"></asp:TextBox>
      </td>
    </tr>
    <tr>
      <td class="font_04">▍密碼</td>
      <td colspan="2"><span class="t12_dgray member_g1">
        <asp:TextBox ID="pwd" runat="server" CssClass="member_inputtxt" MaxLength="8" 
                          TextMode="Password"></asp:TextBox>
      </span> 4 - 8 個字元 </td>
    </tr>
    <tr>
      <td class="font_04">▍確認密碼</td>
      <td colspan="2"><span class="member_g1">
        <asp:TextBox ID="chk_pwd" runat="server" CssClass="member_inputtxt" 
                          MaxLength="8" TextMode="Password"></asp:TextBox>
      </span></td>
    </tr>
    <tr>
      <td class="font_04">
      <td width="35%">‧ 願意收到藝奇優惠</td>
      <td>
        <asp:Literal ID="LiteEdm1" runat="server"></asp:Literal>
      </td>
      </tr>
    <tr>
      <td class="font_04"></td>
      <td>‧ 願意收到本公司所有餐廳優惠</td>
      <td>
        <asp:Literal ID="LiteEdm2" runat="server"></asp:Literal>      </td>
      </tr>
    </table>
    <asp:ImageButton ID="ImageButton1" runat="server" 
                          onmouseover="this.src='images/submit_a.png'" onmouseout="this.src='images/submit.png'"
                          ImageUrl="images/submit.png" onclick="ImageButton1_Click" style="border: none; margin-left:180px;" />
    </div>	
    <br><br>  
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