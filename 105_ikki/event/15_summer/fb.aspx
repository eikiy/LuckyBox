<%@ Page Language="C#" ContentType="text/html" ResponseEncoding="utf-8" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html xmlns:og='http://ogp.me/ns#'>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇 ikki 新日本料理 十周年感恩祭</title>
<meta property="og:title" content="藝奇 ikki 新日本料理 十周年感恩祭"></meta>
<meta property="og:url" content="http://www.ikki.com.tw/event/15_summer/fb.aspx"></meta>
<meta property="og:image" content="http://www.ikki.com.tw/event/15_summer/images/fb.png"></meta>
<meta property="og:description" content="得獎型廚團隊の自信作，週週招待您！快留言並邀請朋友一同品賞，即有機會抽套餐禮券，和朋友一起嚐鮮主廚心藝料理！"/>
<meta property="og:site_name" content="藝奇 ikki 新日本料理 十周年感恩祭"/>

<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/index.css">

    <script type="text/javascript" src="js/jquery-1.9.1.min.js"></script>
    <script type="text/javascript" src="js/jssor.js"></script>
    <script type="text/javascript" src="js/jssor.slider.js"></script>
    <script type="text/javascript" src="js/j01.js"></script>


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

<body>
<div class="wrapper">
  <table width="0" cellpadding="0" cellspacing="0">
    	<tr>
        	<td rowspan="2"><a href="index.html"><img src="images/index_02.gif" width="390" height="363"></a></td>
            <td rowspan="2"><img src="images/fb_03.gif" width="134" height="363"></td>
           <td><a href="info.html"><img src="images/index_04.gif" onmouseover="this.src='images/index_04a.gif'" onmouseout="this.src='images/index_04.gif'" alt="期間限定餐" width="161" height="96" style="cursor:pointer; border: none;" /></a></td>
            <td><img src="images/index_05a.gif" alt="暖心嚐" width="119" height="96" style="border: none;" /></td>
            <td><a href="bath.aspx"><img src="images/index_06.gif" onmouseover="this.src='images/index_06a.gif'" onmouseout="this.src='images/index_06.gif'" alt="饗口福" width="119" height="96" style="cursor:pointer; border: none;" /></a></td>
            <td><img src="images/index_07.gif" width="57" height="96"></td>
        </tr>
        <tr>
        	<td colspan="4"><img src="images/fb_13.gif" width="455" height="267"></td>
        </tr>
    </table>
    <img src="images/fb_16.gif" width="980" height="86">
    <div id="slider1_container" style="position: relative; top: 0px; left: 0px; width: 980px; height: 600px; overflow: hidden; ">

        <!-- Loading Screen -->
        <div u="loading" style="position: absolute; top: 0px; left: 0px;">
            <div style="filter: alpha(opacity=70); opacity:0.7; position: absolute; display: block;
                background-color: #000000; top: 0px; left: 0px;width: 100%;height:100%;">
            </div>
            <div style="position: absolute; display: block; background: url(photo/loading.gif) no-repeat center center;
                top: 0px; left: 0px;width: 100%;height:100%;">
            </div>
        </div>

        <!-- Slides Container -->
        <div u="slides" style="cursor: move; position: absolute; left: 0px; top: 0px; width: 980px; height: 600px; overflow: hidden;">
            <div>
                <img u="image" src="photo/00.jpg" />
            </div>
            <div>
                <img u="image" src="photo/01.jpg" />
            </div>
            <div>
                <img u="image" src="photo/02.jpg" />
            </div>
            <div>
                <img u="image" src="photo/03.jpg" />
            </div>
            <div>
                <img u="image" src="photo/04.jpg" />
            </div>
            <div>
                <img u="image" src="photo/05.jpg" />
            </div>
        </div>
        
        <!--#region Bullet Navigator Skin Begin -->
        <!-- Help: http://www.jssor.com/development/slider-with-bullet-navigator-jquery.html -->
        <style>
            /* jssor slider bullet navigator skin 05 css */
            /*
            .jssorb05 div           (normal)
            .jssorb05 div:hover     (normal mouseover)
            .jssorb05 .av           (active)
            .jssorb05 .av:hover     (active mouseover)
            .jssorb05 .dn           (mousedown)
            */
            .jssorb05 {
                position: absolute;
            }
            .jssorb05 div, .jssorb05 div:hover, .jssorb05 .av {
                position: absolute;
                /* size of bullet elment */
                width: 16px;
                height: 16px;
                background: url(photo/b05.png) no-repeat;
                overflow: hidden;
                cursor: pointer;
            }
            .jssorb05 div { background-position: -7px -7px; }
            .jssorb05 div:hover, .jssorb05 .av:hover { background-position: -37px -7px; }
            .jssorb05 .av { background-position: -67px -7px; }
            .jssorb05 .dn, .jssorb05 .dn:hover { background-position: -97px -7px; }
        </style>
        <!-- bullet navigator container -->
        <div u="navigator" class="jssorb05" style="bottom: 16px; right: 6px;">
            <!-- bullet navigator item prototype -->
            <div u="prototype"></div>
        </div>
        <!--#endregion Bullet Navigator Skin End -->
        
        <!--#region Arrow Navigator Skin Begin -->
        <!-- Help: http://www.jssor.com/development/slider-with-arrow-navigator-jquery.html -->
        <style>
            /* jssor slider arrow navigator skin 12 css */
            /*
            .jssora12l                  (normal)
            .jssora12r                  (normal)
            .jssora12l:hover            (normal mouseover)
            .jssora12r:hover            (normal mouseover)
            .jssora12l.jssora12ldn      (mousedown)
            .jssora12r.jssora12rdn      (mousedown)
            */
            .jssora12l, .jssora12r {
                display: block;
                position: absolute;
                /* size of arrow element */
                width: 30px;
                height: 46px;
                cursor: pointer;
                background: url(photo/a12.png) no-repeat;
                overflow: hidden;
            }
            .jssora12l { background-position: -16px -37px; }
            .jssora12r { background-position: -75px -37px; }
            .jssora12l:hover { background-position: -136px -37px; }
            .jssora12r:hover { background-position: -195px -37px; }
            .jssora12l.jssora12ldn { background-position: -256px -37px; }
            .jssora12r.jssora12rdn { background-position: -315px -37px; }
        </style>
        <!-- Arrow Left -->
        <span u="arrowleft" class="jssora12l" style="top: 323px; left: 0px;">
        </span>
        <!-- Arrow Right -->
        <span u="arrowright" class="jssora12r" style="top: 323px; right: 0px;">
        </span>
        <!--#endregion Arrow Navigator Skin End -->
        <a style="display: none" href="http://www.jssor.com">Bootstrap Slider</a>
    </div>
    <img src="images/fb_step.gif" width="980" height="150">
<div class="way">
    	<span class="font04">活動期間：</span>即日起~2015/7/31止<br>
        <span class="font04">抽獎時間與獎項：</span>7/10、7/17、7/24、7/31每週五抽三組，5:30PM前公佈於本網頁 
        <a href="#" onclick="MM_openBrWindow('names.html','','scrollbars=yes,width=550,height=600')">【中獎名單】</a><br>
        <span class="font04">獎項：</span>每組贈2張藝奇新日本料理套餐禮券(價值1,536元)，共計12組<br>
      <span class="font04">請於下方FB牆留言：</span>”<span class="font05">我最想邀______(請Tag好友)一起到藝奇吃__________(請寫出自信作菜名)</span>”<br>
        舉例：我最想邀 (朋友名字)吃日式辣味牛，留言牆請以「 @+(朋友FB名稱)」邀約朋友
      
        <iframe src="message.html" width="95%" height="400" frameborder="0" style="overflow-y: scroll; overflow-x: hidden;"></iframe><br><br>
        <iframe src="lucky.aspx" width="95%" height="450" frameborder="0" style="overflow-y: scroll; overflow-x: hidden; border-top:1px solid #ccc;"></iframe>
      
  </div>
    
</div>
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