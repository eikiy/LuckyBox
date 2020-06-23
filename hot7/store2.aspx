<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store2.aspx.cs" Inherits="store2" %>

<!doctype html>
<html lang="en"><!-- InstanceBegin template="/Templates/hot7.dwt" codeOutsideHTMLIsLocked="false" -->
  <!--<![endif]-->
  <head>
    <!-- InstanceBeginEditable name="doctitle" -->
    <title>hot 7 新鉄板料理 </title>
    <script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>
    <!-- InstanceEndEditable -->
    <!--meta info-->
    <meta charset="utf-8">
    <meta name="viewport" content="initial-scale=1.0,maximum-scale=1.0,user-scalable=no">
    <meta name="author" content="">
    <meta name="keywords" content="">
    <meta name="description" content="">
    <link rel="shortcut icon" type="image/x-icon" href="images/fav.png">
    <!--web fonts-->
    <link href='http://fonts.googleapis.com/css?family=Lato:100,300,400,700,900,100italic,300italic,400italic' rel='stylesheet' type='text/css'>
    <!--libs css-->
    <link rel="stylesheet" type="text/css" media="all" href="plugins/owl-carousel/owl.carousel.css">
    <link rel="stylesheet" type="text/css" media="all" href="plugins/owl-carousel/owl.transitions.css">
    <link rel="stylesheet" type="text/css" media="all" href="plugins/jackbox/css/jackbox.min.css">
    <link rel="stylesheet" type="text/css" media="screen" href="plugins/rs-plugin/css/settings.css">
    <!--theme css-->
    <link rel="stylesheet" type="text/css" media="all" href="css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" media="all" href="css/theme-animate.css">
    <link href="css/style.css" rel="stylesheet" type="text/css">
    <!--head libs-->
<script src="js/jquery-2.1.0.min.js"></script>
<script src="plugins/jquery.queryloader2.min.js"></script>
<script src="plugins/modernizr.js"></script>
<script>
			$('html').addClass('d_none');
			$(document).ready(function(){
				$('html').show();
				$("body").queryLoader2({
					backgroundColor: '#fff',
					barColor : '#e50012',
					barHeight: 4,
					percentage:true,
					deepSearch:true,
					minimumTime:1000
				});
			});
		</script>
    <!-- InstanceBeginEditable name="head" -->
    <!-- InstanceEndEditable -->
  </head>
  <body class="sticky_menu">
    <!--side menu-->
    <!--layout-->
    <div class="wide_layout bg_light">
      <!--header markup-->
      <header role="banner" class="relative type_2">
        <span class="gradient_line">
        </span>
        <!--top part-->
        <section class="header_top_part">
          <div class="container">
            <div class="row">
              <!--language-->
              <div class="col-lg-2 col-md-2 col-sm-2 f_right ">
              <ul class="hr_list main_menu type_2 fw_normal t_align_l ">
                <li class="container3d relative f_xs_none m_xs_bottom_5 ">
                  <a class="color_green relative r_xs_corners border_none p_tb_7" href="#">中 文<i class="icon-angle-down d_inline_m"></i></a>
                  <ul class="sub_menu r_xs_corners bg_light vr_list tr_all tr_xs_none trf_xs_none bs_xs_none d_xs_none">
                    <li>
                    <a href="index.html" class="d_block color_grey relative">中 文</a>
                    </li>
                    <li>
                    <a href="menu_jp.html" class="d_block color_grey relative">日本語</a>
                    </li>
                    <li>
                    <a href="menu_en.html" class="d_block color_grey relative">English</a>
                    </li>
                  </ul>
               </li>
              </ul>
              </div>              
              </div>
            </div>
          
        </section>
        <!--header bottom part-->
        <section class="header_bottom_part type_3 bg_light">
          <div class="container">
            <!--logo-->
            <div class="t_align_c">
              <a href="index.html" class="d_inline_m m_top_8 m_bottom_5 m_xs_top_20 m_xs_bottom_20">
                <img src="images/logo.png" alt=""></a>
            </div>
          </div>
        </section>
        <hr class="d_xs_none">
        <section class="sticky_part bg_red">
          <div class="container t_align_c">
            <!--main navigation-->
            <button id="menu_button" class="r_corners tr_all color_green db_centered m_bottom_20 d_none d_xs_block">
              <i class="icon-menu"></i>
            </button>
            <!--main navigation-->
            <nav role="navigation" class="d_inline_m d_xs_none m_xs_right_0 m_right_15 m_sm_right_5 t_align_l m_xs_bottom_15">
              <ul class="hr_list main_menu type_2 fw_normal">
                <li class="container3d relative f_xs_none m_xs_bottom_5">
                  <a class="color_light fs_large relative r_xs_corners" href="#">hot初心
                    <i class="icon-angle-down d_inline_m"></i>		</a>
                  <ul class="sub_menu r_xs_corners bg_light vr_list tr_all tr_xs_none trf_xs_none bs_xs_none d_xs_none">
                    <li>
                    <a href="story.html" class="d_block color_grey relative">在地良食</a>
                </li>
                <li>
                <a href="chef.html" class="d_block color_grey relative">職人精神</a>
                </li>
              </ul>
              </li>
              <li class="container3d relative f_xs_none m_xs_bottom_5">
                <a class="color_light fs_large relative r_xs_corners" href="#">鉄板料理
                  <i class="icon-angle-down d_inline_m"></i></a>
              <ul class="sub_menu r_xs_corners bg_light vr_list tr_all tr_xs_none trf_xs_none bs_xs_none d_xs_none">
              <li>
                  <a href="menu.html" class="d_block color_grey relative">套餐</a>
              </li>
              <li>
                  <a href="menu-ALaCarte.html" class="d_block color_grey relative">單點</a>
              </li>
              </ul>
              </li>
              <li class="container3d relative f_xs_none m_xs_bottom_5">
                <a class="color_light fs_large relative r_xs_corners" href="event.html">活動新訊
                  <i class="icon-angle-down d_inline_m"></i></a>
              </li>
              <li class="container3d relative f_xs_none m_xs_bottom_5">
                <a class="color_light fs_large relative r_xs_corners" href="#">分店資訊
                  <i class="icon-angle-down d_inline_m"></i></a>
                <ul class="sub_menu r_xs_corners bg_light vr_list tr_all tr_xs_none trf_xs_none bs_xs_none d_xs_none">
                  <li>
                  <a href="store1.aspx" class="d_block color_grey relative">北北基</a>
              </li>
              <li>
              <a href="store2.aspx" class="d_block color_grey relative">桃竹苗</a>
              </li>
              <li>
              <a href="store3.aspx" class="d_block color_grey relative">中彰投</a>
              </li>
              <li>
              <a href="store4.aspx" class="d_block color_grey relative">高屏</a>
              </li>
              </ul>
              </li>
              <li class="container3d relative f_xs_none m_xs_bottom_5">
                <a class="color_light fs_large relative r_xs_corners" href="member.html">hot燒友
                  <i class="icon-angle-down d_inline_m"></i></a>
              </li>
              <li class="container3d relative f_xs_none m_xs_bottom_5 ">
                <a class="color_light fs_large relative r_xs_corners" href="talk.aspx">聯絡我們
                  <i class="icon-angle-down d_inline_m"></i></a>
              </li>
								<li class="container3d relative f_xs_none m_xs_bottom_5">
                <a class="color_light fs_large relative r_xs_corners" href="http://cct.wowprime.com/cct/cctapp/cctwebreservation.do?&prog=cctweb_reservation&brnd_fid=JQYWH&stor" target="_blank">線上訂位
                  <i class="icon-angle-down d_inline_m"></i></a>
                  <ul class="sub_menu r_xs_corners bg_light vr_list tr_all tr_xs_none trf_xs_none bs_xs_none d_xs_none">
                    
              </ul>
              </li>
								
              </ul>
            </nav>
          </div>
        </section>
      </header>
      <!-- InstanceBeginEditable name="EditRegion3" -->
        <!-- Google Tag Manager -->
<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-TP54J99');</script>
<!-- End Google Tag Manager -->

        <!--page title-->
        <!--revolution slider-->
        <section class="relative w_full">
        <div class="r_slider">
          <ul>
            <li data-transition="fade" data-slotamount="10">
              <img src="images/event_slide_01.jpg" alt="" data-bgfit="cover" data-bgposition="center center">
            </li>
            <li data-transition="fade" data-slotamount="10">
              <img src="images/event_slide_02.jpg" alt="" data-bgfit="cover" data-bgposition="center center">
            </li>
            <li data-transition="fade" data-slotamount="10">
              <img src="images/event_slide_03.jpg" alt="" data-bgfit="cover" data-bgposition="center center">
            </li>
            <li data-transition="fade" data-slotamount="10">
              <img src="images/event_slide_04.jpg" alt="" data-bgfit="cover" data-bgposition="center center">
            </li>
          </ul>
        </div>
      </section>
      <!-- Google Tag Manager (noscript) -->
<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-TP54J99"
height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
<!-- End Google Tag Manager (noscript) -->

        <!--content-->
        <section class="section_offset">
        <div class="container t_align_c m_bottom_40" >
          <h3 class=" fw_light color_grey m_bottom_25">
          <!--<span style="font-size:60%; color:#f00;">2/4(一)除夕公休一天，2/5(二)初一起正常營業<br>部分門店營業時間略有不同，請直接撥打門店專線查詢營業狀況，謝謝～</span><br /><br />-->
            <span class="color_green">｜
            </span>&nbsp;分店資訊 -桃竹苗&nbsp;
            <span class="color_green">｜
            </span></h3>
        <img src="images/spoon.png" alt="" width="42" height="43"/>        </div>
        
        
        
        <%--<div class="container responsive_animate m_bottom_25">
          <div class="row m">
            <!--toggle-->
            <div class="col-lg-6 col-md-6 col-sm-6 m_bottom_10 m_xs_bottom_10">
              <div class="accordion toggle">
                <dl class="accordion_item r_corners wrapper m_bottom_5 tr_all">
                  <dt class="accordion_link relative color_dark tr_all">中壢中美店
                    <span class="icon_wrap_size_1 circle d_block hide">
                      <i class="icon-minus"></i>
                    </span>
                    <span class="icon_wrap_size_1 circle d_block show">
                      <i class="icon-plus"></i>
                    </span>
                  </dt>
                  <dd class="fw_normal color_dark">
                    <div class="row m_bottom_15">
                      <div class="col-lg-5 col-md-5 col-sm-5">
                        <p class="m_bottom_10">
                          <div class="d_inline_m icon_wrap_size_1 color_red circle m_right_5">
                            <i class="icon-location"></i>
                          </div>桃園市中壢區中美路一段12號2樓
                        </p>
                        <p class="m_bottom_10">
                          <div class="d_inline_m icon_wrap_size_1 color_red circle m_right_5">
                            <i class="icon-phone"></i>
                          </div>03-426-5922
                        </p>
                        <p class="m_bottom_10">
                          <div class="d_inline_m icon_wrap_size_1 color_red circle m_right_5">
                            <i class="icon-info"></i>
                          </div>交通資訊：<br>
								鄰近中壢火車站，位於中美路與延平路口中美村商場2樓。
                        </p>
                        <p class="m_bottom_10">
                          <div class="d_inline_m icon_wrap_size_1 color_red circle m_right_5">
                            <i class="icon-info"></i>
                          </div>停車資訊：<br>
								非特約停車場 - 中美村商場後方中美路與恩德街口停車場。
                        </p>
                      </div>
                      <div class="col-lg-7 col-md-7 col-sm-7">
                        <img src="images/map/map_06.png" alt=""/>
                      </div>
                    </div>
                    <hr class="bg_color_green">
                    <div class="row m_top_20">
                      <div class="col-lg-5 col-md-5 col-sm-5">
                        <div class="d_inline_m icon_wrap_size_1 color_red circle m_right_5">
                          <i class="icon-comment"></i>
                        </div>店長的話：<br>
								找對的方向 做對的事情
                      </div>
                      <div class="col-lg-7 col-md-7 col-sm-7">
                        <img src="images/chef-01.png" alt=""/>
                      </div>
                    </div>
                  </dd>
                </dl>
              </div>
            </div>
          </div>
        </div>--%>
       
       
       
       <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
       
       
       
        <!-- InstanceEndEditable -->
      <!--footer-->
      <footer role="contentinfo" class="bg_wood" id="#footer_1">
        <!--top part-->
        <section class="footer_top_part">
          <div class="container">
            <div class="row">
              <div class=" m_bottom_20 m_top_20" align="center">
                <img src="images/sloga.png" alt=""/>
              </div>
            </div>
            <div class="row">
              <!--info-->
              <div class="col-lg-1 col-md-1 col-sm-1">
              </div>
              <div class="col-lg-6 col-md-6 col-sm-6 m_bottom_55 m_top_20 t_align_r">
                <div class="row t_align_l m_left_55">
                  <ul class="fw_normal w_break m_xs_bottom_8">
                    <li class="m_bottom_8 f_left m_right_10">
                      <div class="d_inline_m icon_wrap_size_2 circle icon_color m_right_5">
                        <i class="icon-gift"></i>
                      </div>
                      <a class="color_light fs_large relative jackbox" href="token_ch.aspx" data-group="token" data-title="">
                        <span class="p_jackbox color_black">禮券查詢　
                        </span> </a>
                    </li>
                    <li class="m_bottom_8 f_left m_right_10">
                      <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                        <i class="icon-link"></i>
                      </div>
                      <a class="color_light fs_large relative jackbox" href="link.html" data-group="link" data-title="">
                        <span class="p_jackbox color_black">好站連結　
                        </span> </a>
                    </li>
                    <li class="m_bottom_8 f_left m_right_10">
                      <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                        <i class="icon-male"></i>
                      </div>
                      <a class="color_light fs_large relative jackbox" href="job.html" data-group="job" data-title="">
                        <span class="p_jackbox color_black">人才招募　
                        </span> </a>
                    <li class="m_bottom_8 f_left m_right_10">
                        <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                          <i class="icon-mobile"></i>
                        </div>
                        <a href="http://wowfoods.cc/100/" target="_blank" class="color_black">王品瘋美食</a>
                    </li>
                      <li class="m_bottom_8 f_left m_right_10">
                        <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                          <i class="icon-doc-text"></i>
                        </div>
                        <a class="color_light fs_large relative jackbox" href="rule.html" data-group="rule" data-title="">
                          <span class="p_jackbox color_black">使用條款　
                          </span>	</a>
                        <a href="#" class="color_black"></a>
                      </li>
                      <li class="m_bottom_8 f_left m_right_10">
                        <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                          <i class="icon-pencil"></i>
                        </div>
                        <a class="color_light fs_large relative jackbox" href="contact.html" data-group="contact" data-title="">
                          <span class="p_jackbox color_black">給我們意見
                          </span>		</a>
                      </li>
                      <li class="m_bottom_8 f_left m_right_10">
                        <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                          <i class="icon-user"></i>
                        </div>
                        <a class="color_light fs_large relative jackbox" href="rights.html" data-group="rights" data-title="">
                          <span class="p_jackbox color_black">會員權益　
                          </span>	</a>
                      </li>
										
										<li class="m_bottom_8 f_left m_right_10">
                        <div class="d_inline_m icon_wrap_size_2 icon_color circle m_right_5">
                          <i class="icon-pencil"></i>
                        </div>
                        <a class="color_light fs_large relative jackbox" href="http://cct.wowprime.com/cct/cctapp/cctwebreservation.do?&prog=cctweb_reservation&brnd_fid=JQYWH&stor" target="_blank" data-group="rights" data-title="">
                          <span class="p_jackbox color_black">線上訂位　
                          </span>	</a>
                      </li>
										
                  </ul>
                  <!--open time--></div>
              </div>
              <div class="col-lg-4 col-md-4 col-sm-4 fw_normal m_bottom_55 m_top_20 m_xs_left_55">
                <ul>
                  <li >
                    <span class="color_red">
                      <i class="icon-clock"></i>&nbsp;營業時間
                    </span>
                  </li>
                  <li class="m_top_0 m_bottom_8 color_black fs_medium">	11：30 ~ 14：30 最後點餐時間14：00
                    <br>17：30 ~ 22：00 最後點餐時間21：00
                  </li>
                  <li class="m_top_0 m_bottom_8 color_black fs_medium"></li>
                  <a href="https://www.facebook.com/hot7.tw/"><img src="images/icon_fbbutton.png" alt=""/></a>
                </ul>
              </div>
            </div>
          </div>
        </section>
        <!--bottom part-->
        <section class="footer_bottom_part t_align_c color_red bg_light fw_light">
          <p>© 2016 hot 7, Inc. All Rights Reserved
          </p>
        </section>
      </footer>
    </div>
    <!--back to top button-->
    <button id="back_to_top" class="circle icon_wrap_size_2 color_green_hover color_grey_light_4 tr_all d_md_none">
      <i class="icon-angle-up fs_large"></i>
    </button>
    <!--Libs-->
<script src="plugins/flexslider/jquery.flexslider-min.js"></script>
<script src="plugins/jquery.appear.js"></script>
<script src="plugins/afterresize.min.js"></script>
<script src="plugins/jquery.easytabs.min.js"></script>
<script src="plugins/owl-carousel/owl.carousel.min.js"></script>
<script src="plugins/jackbox/js/jackbox-packed.min.js"></script>
<script src="plugins/twitter/jquery.tweet.min.js"></script>
<script src="plugins/jquery.easing.1.3.js"></script>
<script src="plugins/rs-plugin/js/jquery.themepunch.plugins.min.js"></script>
<script src="plugins/rs-plugin/js/jquery.themepunch.revolution.min.js"></script>
    <!--Theme Initializer-->
<script src="js/theme.plugins.js"></script>
<script src="js/theme.js"></script>
  </body>
<!-- InstanceEnd --></html>
