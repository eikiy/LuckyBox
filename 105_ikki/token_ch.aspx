<%@ Page Language="C#" AutoEventWireup="true" CodeFile="token_ch.aspx.cs" Inherits="token_ch" %>
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
<link rel="stylesheet" type="text/css" href="css/about.css" />
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

</head>
<body>
<div class="wrapper"><div class="logo"><a href="/index.html"><img src="images/logo.png" width="231" height="114"></a></div>
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
    	<table border="0" cellpadding="0" cellspacing="0" style="margin-top:10px;">
        	<tr>
            	<td><img src="images/ticket_01.jpg" alt="禮券查詢" width="49" height="145" style="border: none;" /></td>
            </tr>
        </table>
</div>


    
<div class="content">
	<div class="img"><img src="images/img_other.png" width="271" height="888"></div>
	<div class="word">
      <span class="anchor" id="link01" style="*margin-top:-30px;"></span>
      <img src="images/icon_token.png" width="630" height="45">
      <div style="margin:20px 0 0 10px;">
   <form id="form1" runat="server">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td colspan="3" class="ss" style="border:none;"></td>
            </tr>
            <tr>
                <td width="30%" class="font_04">▍請輸入禮券編號：</td>
              <td style="line-height:30px;"><label>
             <asp:TextBox ID="txtCode" 
                      runat="server"></asp:TextBox>
                  ex:0010505001
              </label></td>
              <td style="line-height:30px;">
                  <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="送出" 
                      Width="40px" />
                  <label>
                  &nbsp;</label></td>
          </tr>
            <tr>
            
              <th colspan="3" align=center>  <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                                                                                                                BorderColor="LightGray" BorderWidth="1px" CellPadding="5" CellSpacing="0" Width="550px">
                                                                                                                <Columns>
                                                                                                                    <asp:BoundField DataField="CuponNo" HeaderText="禮卷編號" />
                                                                                                                    <asp:BoundField DataField="Price" HeaderText="面額" />
                                                                                                                    <asp:BoundField DataField="SalesDate" HeaderText="銷售日期" />
                                                                                                                    <asp:BoundField DataField="Status" HeaderText="禮券狀態" />
                                                                                                                    <asp:BoundField DataField="RetDate" HeaderText="保證截止" />
                                                                                                                    <asp:BoundField DataField="BankName" HeaderText="保證銀行" />
                                                                                                                </Columns>
                                                                                                                <HeaderStyle BorderColor="Transparent" BackColor="#CCCCCC" Height="20px" 
                                                                                                                    HorizontalAlign="Center" />
                                                                                                </asp:GridView></th>
            </tr>
            <tr>
              <th colspan="3"><br>
              <ul style="line-height:30px; margin-left:20px;">
                <li>本公司所有銷售之禮券無使用期限。 </li>
                <li>本公司自2009/2/01起，已依行政院衛生署『餐飲業等商品（服務）禮券定型化契約』規定，對當日起銷售之禮券由銀行提供履約保證責任。 </li>
                <li>凡持本公司所發行乙張商品禮券，可享有禮券所記載之套餐乙客(已含服務費)。</li>
                <li>本商品禮券若因季節更替調整菜單或營業型態改變，可兌換等值商品；但不同價格之套餐不在此限，須補足禮券面額之差額始能兌換。 </li>
                <li>本商品禮券如有遺失、被竊或毀損，變形致無法辨識者，概不掛失或補發，但本商品禮券如因毀損或變形，而其重要內容仍可辨認者，得請求交付商品或換發。</li>
                <li>本商品禮券出售時已開立統一發票，兌換商品時則不再開立發票。 </li>
                <li>本商品禮券經店鋪蓋作廢章後，則視同已兌換，不得再重覆使用。 </li>
                <li>本商品禮券出售後若欲辦理禮券退回時，請持禮券及原購買禮券發票或消費明細至原購買門市辦理，並以禮券所載之面額為之；非直接向門市購買者，請向原購買單位辦理。 </li>
                <li>若買受人為個人且該交易金額全數退回，需收回原始發票並開立退貨折讓單。 </li>
                <li>若買受人為個人且該交易金額部份退回，直接開立退貨折讓單。 </li>
                <li>若買受人為公司請開立退貨折讓單，並需加蓋公司代表章。 </li>
                <li>退貨價格有面額以面額金額退款，無面額依原始出售金額為退款。 </li>
                <li>以信用卡購買者，由店舖辦理信用卡退刷，將款項退回原信用卡帳戶；依信用卡作業規定，恕無法以現金退還。 </li>
                <li>以現金購買者，如門市現金不足時，將由總公司代匯款至指定帳戶。 </li>
                
                  
              </ul></th>
            </tr>
	    </table>
   </form></div>
    </div>	
        
</div>

</div>
<!--footer-->

<iframe src="/footer.html" width="100%" height="152" frameborder="0"></iframe>


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

