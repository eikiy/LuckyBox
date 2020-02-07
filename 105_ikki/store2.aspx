<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store.aspx.cs" Inherits="store" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<META NAME="keywords" CONTENT="藝奇,新日本料理,藝奇 新日本料理, ikki, 藝奇餐廳地址,王品集團,藝奇網路會員優惠券,花旗您生日我請客"> 
<META NAME="description" CONTENT="玩味+創意x食藝。創新食藝~玩味,「藝」教於飲食文化。樂趣汲取~日本專注細節。講究~食材烹調精神。添加~西式調味手法。揉合~北歐簡約設計。以靈感、巧思加持激盪東京時尚料理新風貌。"> 

<title>藝奇 ikki 新日本料理</title>
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
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

</head>

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
		<li class="here"><a href="store_pass_1101.aspx"><span class="font_01">／</span> 尋訪藝奇</a></li>
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
	<div class="img"><img src="images/img_store.png" width="271" height="888"></div>
	<div class="word">
      <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea4" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea5" runat="server"></asp:Literal>
             <asp:Literal ID="LiteArea6" runat="server"></asp:Literal>
    </div>	
        
</div>

</div>
<!--footer-->
	<iframe src="/footer.html" width="100%" height="152" frameborder="0"></iframe>


</div>
</body>
</html>
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript"></script>
<script type="text/javascript">
<!--
_uacct = "UA-2488504-1";
urchinTracker();

function MM_openBrWindow(theURL,winName,features) { //v2.0
  window.open(theURL,winName,features);
}
//-->
</script>