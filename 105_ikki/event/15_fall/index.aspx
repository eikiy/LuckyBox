﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="event_15_fall_index" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇新日本料理-柚見秋旬味</title>
<meta property='og:description' content='表謝意，饗蟹禮！快來下載蟹禮兌換券，免費共饗當旬秋蟹料理！'/>
<meta property='og:image' content='http://www.ikki.com.tw/event/15_fall/img/fb200.png'/>
<script type="text/javascript">
	$(function(){
	});
    function fbs_click() {
        u = 'http://www.ikki.com.tw/event/15_fall/index.aspx'; t = document.title; window.open('http://www.facebook.com/sharer.php?u=' + encodeURIComponent(u) + '&t=' + encodeURIComponent(t), 'sharer', 'toolbar=0,status=0,width=626,height=436'); return false;
     }
</script>





<script type="text/javascript">
        function OpenShow(wUrl) {
            $.fancybox({                
                'hideOnOverlayClick': false,
                'showCloseButton': true,
                                
		        'width': 381,
                'height': 700,
                'padding': 20,  
		        		       
                'href': "../15_fall/img/coupon.jpg",
//                'type': 'iframe',
//                iframe: {
//                    scrolling: 'yes'
//                }
            });
        }
</script>


    <script language="JavaScript">
<!--
        function CleanText() {
            var sText = document.all.txtSuggestion.value;
            if (sText == "有你一起...")
                document.all.txtSuggestion.value = "";
        }
//-->
    </script>





<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>
<link href="styles/style.css" rel="stylesheet" type="text/css">
	<link href="styles/animate.css" rel="stylesheet" type="text/css">
<!-- Javascript files -->
<script type="text/javascript" src="scripts/jquery.js"></script>
<script src="scripts/jquery.prettyPhoto.js" type="text/javascript"></script>
<script src="scripts/waypoints.min.js" type="text/javascript"></script>
<script src="scripts/main.js"></script>

<script type="text/javascript" src="scripts/easing.js"></script>
<script type="text/javascript" src="scripts/custom.js"></script>
<script type="text/javascript" src="scripts/box_custom.js"></script>

<!-- Add fancyBox main JS and CSS files -->
<script type="text/javascript" src="fancyBox/source/jquery.fancybox.js?v=2.1.5"></script>
<link rel="stylesheet" type="text/css" href="fancyBox/source/jquery.fancybox.css?v=2.1.5" media="screen" />

<!-- Add Button helper (this is optional) -->
<link rel="stylesheet" type="text/css" href="fancyBox/source/helpers/jquery.fancybox-buttons.css?v=1.0.5" />
<script type="text/javascript" src="fancyBox/source/helpers/jquery.fancybox-buttons.js?v=1.0.5"></script>

<!-- Add Thumbnail helper (this is optional) -->
<link rel="stylesheet" type="text/css" href="fancyBox/source/helpers/jquery.fancybox-thumbs.css?v=1.0.7" />
<script type="text/javascript" src="fancyBox/source/helpers/jquery.fancybox-thumbs.js?v=1.0.7"></script>
	<style type="text/css">
		.fancybox-custom .fancybox-skin {
			box-shadow: 0 0 50px #222;
		}
	</style>
    
<script><!--解決png在IE有黑邊的問題-->
$(function() {
    if(navigator.userAgent.indexOf("MSIE") != -1) {
        $('img').each(function() {
            if($(this).attr('src').indexOf('.png') != -1) {
                $(this).css({
                    'filter': 'progid:DXImageTransform.Microsoft.AlphaImageLoader(src="' +
                    $(this).attr('src') +
                    '", sizingMethod="scale");'
                });
            }
        });
    }
});
</script>

</head>

<body>
<form id="form" runat="server">
<div id="wrapper" align="center">
<!--head-->
<div id="head"><a href="http://www.ikki.com.tw/"><img src="img/logo.png" width="188" height="57" alt="" id="logo"/></a>
<a href="javascript:;" onclick="javascript: fbs_click()"><img src="img/fb.png" width="53" height="54" alt="" id="fb"/></a>
<img src="img/title.png" width="374" height="306" alt="" id="slogan" class="aitem a1"/>
<div class="animationStart">
<div class="nav">
  金牌主廚獻上暖心日式料理，特選當令食材，品嚐季節鮮味，讓秋天的美味在舌尖綻放
  <hr>
  <ul class="menu">
    <li><a href="#section1">旬の味</a></li>
    <li><a href="#section2">人氣料理</a></li>
    <li><a href="#section3" style="color:#FF0; font-weight:bold; font-size:120%;">秋蟹兌換券</a></li>
    <li><a href="#section4">立即訂位</a></li>
    <li><a class="fancybox fancybox.iframe" href="note.html">活動辦法</a></li>
  </ul>
</div>
</div>
<div id="hidden_menu">
 <div id="hidden_items">
 <ul>                                                                          
    <li><a href="#head">TOP</a></li>
    <li><a href="#section1">旬の味</a></li>
    <li><a href="#section2">人氣料理</a></li>
    <li><a href="#section3">秋蟹兌換券</a></li>
    <li><a href="#section4">立即訂位</a></li>
</ul>
  </div>
</div>
</div>
<!--section1-->
  <div id="section1">
    <div class="content">
      <table width="100%" border="0" cellspacing="0" cellpadding="0">
        <tbody>
          <tr>
            <td height="140">&nbsp;</td>
          </tr>
          <tr>
            <td align="center">
              <div class="subtitle1"><h2>旬の味</h2></div> 
              <h3 class="c-cafe">秋蟹の鮮 ‧ 柚子の香 ‧ 栗子の甘 </h3>
            </td>
          </tr>
        </tbody>
        </table>
      <img src="img/maple.png" width="440" height="210" alt="" id="maple"/> 
      <img src="img/crab2.png" width="845" height="443" alt="" id="crab"/>
      <img src="img/pomelo.png" width="295" height="286" alt="" id="pomelo"/></div>
  </div>
<!--section2-->
<div id="section2">

  <div class="content">
  <table width="100%" border="0" cellspacing="0" cellpadding="0">
    <tbody>
      <tr>
        <td height="90">&nbsp;</td>
        </tr>
      <tr>
        <td height="100" align="center" valign="top">
          <div class="subtitle2"><h2>人氣料理：期間限定</h2></div> 
          </td>
        </tr>
      </tbody>
  </table>
  <div class="maindish"><img src="img/dish-1.jpg" width="490" height="350" alt="" class="flt_l"/>
    <table width="370" border="0" cellspacing="0" cellpadding="0">
      <tbody>
        <tr>
          <td height="350" valign="middle"><h3 class="c-red">柚見秋蟹</h3>
            主廚嚴選當令旭蟹，鮮甜飽滿的蟹肉佐特製橙醋，令人吮指回味。搭配風味細緻迷人的柚子醋飲，組合出秋季絕妙滋味。<br><span style="font-size:90%; color:#999;">(憑券兌換，未販售)</span></td>
        </tr>
      </tbody>
    </table>
  </div>
<div align="center">
  <div class="maindish"><img src="img/dish-2.jpg" width="490" height="350" alt="" class="flt_r"/>
    <table width="370" border="0" cellspacing="0" cellpadding="0">
      <tbody>
        <tr>
          <td height="350" valign="middle"><h3 class="c-red">香柚鯖魚沙拉</h3>
            新鮮多汁的葡萄柚、細緻鮮美的鹽烤鯖魚，淋上主廚特調柚子和風醬汁，清爽不膩口。</td>
        </tr>
      </tbody>
    </table>
  </div>
  <div class="maindish line-b"><img src="img/dish-3.jpg" width="490" height="350" alt="" class="flt_l"/>
    <table width="370" border="0" cellspacing="0" cellpadding="0">
      <tbody>
        <tr>
          <td height="350" valign="middle"><h3 class="c-red">栗子雞肉釜飯</h3>
            特選在地好米「馥米」，以高湯炊煮而成，口感<span lang="EN-US">Q</span>彈。搭配當令栗子及雞肉，令人玩味的暖心日式佳餚。</td>
        </tr>
      </tbody>
    </table>
  </div>
</div>

    </div>

  <div class="content">
    <div align="center">
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td height="60" align="center" valign="middle">&nbsp;</td>
    </tr>
    <tr>
      <td height="120" align="center" valign="middle">
        <div class="subtitle2">
          <h2>人氣定番料理</h2></div> 
        </td>
    </tr>
  </tbody>
</table>
      <table width="890" border="0" cellspacing="0" cellpadding="0">
        <tbody>
          <tr>
            <td width="33%" align="center"><img src="img/dish-4.png" width="250" height="250" alt=""/></td>
            <td width="33%" align="center"><img src="img/dish-5.png" width="250" height="250" alt=""/></td>
            <td width="34%" align="center"><img src="img/dish-6.png" width="250" height="250" alt=""/></td>
          </tr>
          <tr>
            <td align="center"><h4>季節鮮魚刺身</h4></td>
            <td align="center"><h4>牛肉箬竹燒</h4></td>
            <td align="center"><h4>醬燒羊排</h4></td>
          </tr>
          <tr>
            <td height="50">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
        </tbody>
  </table>
    </div>
  </div>
</div>
<!--section3-->
<div id="section3">
  <div class="content">
    <img src="img/crab_icon.gif" width="112" height="67" alt="" id="crab_icon"/>
    <table width="100%" border="0" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td height="110">&nbsp;</td>
    </tr>
    <tr>
      <td align="center">
        <div class="subtitle1"><h2>表謝意&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;饗蟹禮</h2>
        </div> 
  <h3 class="c-cafe">11/30前4人同行，憑蟹禮兌換券，免費共饗當旬秋蟹料理！</h3>
      </td>
    </tr>
  </tbody>
</table>
    <div align="center">
      <table width="880" border="0" cellspacing="0" cellpadding="0">
        <tbody>
          <tr>
            <td width="411" height="360" align="left"><img src="img/coupon.png" width="392" height="314" alt=""/></td>
            <td width="469" align="left">在秋天這個豐收感恩的季節，想對誰說謝謝、想和誰饗秋蟹？<br>
              快輸入你的蟹(謝)意，即可下載兌換券！
                <br><span style="font-size:140%; color:#C00; font-weight:bold;">蟹謝</span>                
            
            
            
            
              <%--<input name="textfield" type="text" class="input_field" id="textfield" value="有你一起...">--%>
              <asp:TextBox ID="textfield" runat="server" CssClass="input_field"              
              OnFocus="javascript:if(this.value=='有你一起...') {this.value=''}"
              OnBlur="javascript:if(this.value==''){this.value='有你一起...'}" 
              Text='有你一起...'
              ></asp:TextBox>
              
              
              
              <%--<a  class="fancybox"  data-fancybox-group="gallery" href="img/coupon.jpg"></a> 
              <img src="img/gift-but.png" width="400" height="40" />  --%>         
              <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="img/gift-but.png" width="400" height="40" 
                 onclick="ImageButton1_Click" />
                 
                 
                 
                 
                 
                 
                 
                 
              <p align="right"><a class="fancybox fancybox.iframe" href="note.html">&#8250;活動辦法</a></p></td>
          </tr>
        </tbody>
  </table>
    </div>

  </div></div>
  <div id="section4">
    <div class="content">
      <table width="100%" border="0" cellspacing="0" cellpadding="0">
         <tbody>
           <tr>
             <td height="70">&nbsp;</td>
           </tr>
           <tr>
             <td height="100" align="center" valign="top"><div class="subtitle1">
               <h2>立即訂位</h2>
             </div></td>
           </tr>
         </tbody>
      </table>
      <div align="center">
        <table width="800" border="0" cellspacing="0" cellpadding="0">
          <tbody>
            <tr>
              <td width="123" align="left" valign="top"><h4>北部</h4></td>
              <td width="112" align="left" valign="top">&nbsp;</td>
              <td width="140" align="left" valign="top" class="line-l"><h4>中部</h4></td>
              <td width="140" align="left" valign="top" class="line-l"><h4>南部</h4></td>
              <td width="258" rowspan="2" align="left" valign="middle" class="line-l"><p><img src="img/spoon_s.png" width="100" height="100" alt=""/><br>
                日式旬味套餐 <span style="font-weight:bold; font-size:120%;"><a href="http://www.ikki.com.tw/menu.html">更多料理</a></span><br>
              <a href="http://www.ikki.com.tw/menu.html">www.ikki.com.tw/menu.html</a></p></td>
            </tr>
            <tr>
              <td align="left" valign="top">
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10503" target="_blank">台北衡陽店</a> <br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10508" target="_blank">台北中山北店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10501" target="_blank">台北敦化北店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10514" target="_blank">板橋麗寶店</a><br>
              </td>
              <td align="left" valign="top">
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10516" target="_blank">永和中山店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10511" target="_blank">中壢中山店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10506" target="_blank">桃園南華店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10509" target="_blank">竹北光明店</a><br>
              </td>
              <td width="140" align="left" valign="top" class="line-l">
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10513" target="_blank">台中崇德店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10510" target="_blank">台中福雅店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10504" target="_blank">台中大墩店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10515" target="_blank">嘉義耐斯松屋店</a><br>
              </td>
              <td width="140" align="left" valign="top" class="line-l">
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10517" target="_blank">仁德中山店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10505" target="_blank">高雄中山店</a><br>
              <a href="http://www.ikki.com.tw/store_all.aspx?#id10512" target="_blank">高雄夢時代店</a><br>
              </td>
            </tr>
          </tbody>
  </table>
      </div>

    </div>
  </div>
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
