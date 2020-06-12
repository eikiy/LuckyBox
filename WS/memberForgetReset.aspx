﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberForgetReset.aspx.cs" Inherits="memberForgetReset" %>

<!DOCTYPE html>
<html lang="zh-TW" xml:lang="zh-TW">
<head>
    <!-- Title and Meta
================================================== -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
<title>王品│只款待心中最重要的人</title>
    <meta name="author" content="">
    <meta name="description" content="" />
    <meta name="keywords" content="" />
    <!-- Facebook Open Graph Meta
================================================== -->
    <meta property="og:title" content="" />
    <meta property="og:url" content="" />
    <meta property="og:site_name" content="" />
    <meta property="og:description" content="" />
    <meta property="og:image" content="" />
    <!-- Mobile
================================================== -->
    <meta name="viewport" content="width=1280">
    <!-- CSS & Js 
================================================== -->
    <link rel="stylesheet" type="text/css" href="styles/style.css">
    <!--[if lt IE 9]>
    <script src="scripts/default/html5shiv.min.js"></script>
    <script src="scripts/default/respond.min.js"></script>
    <![endif]-->
    <script src="scripts/default/modernizr.js"></script>
</head>

<body>

	<!--官網ga-->
	<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488495-1', 'auto');
  ga('send', 'pageview');

  </script>
	<!--end官網ga-->

    <div class="wp page">
        <header id="header">
            <div class="navbar">
                <div class="container">
                    <a class="logo" href="index_PASS_1101.html" data-menu="index" title="王品">
                        <img src="styles/images/logo.png" alt="王品logo">
                        <h1 class="text-hide">王品</h1>
                    </a>
                    <nav class="nav">
                        <h1 class="text-hide">主選單</h1>
                        <ul class="columns inline top-nav">
                            <li class="contact"><a href="contact.html" title="聯絡我們">聯絡我們</a></li>
                            <li><a href="en/about.html" target="_blank" title="English">English</a></li>
<li><a href="JP/about.html" target="_blank" title="日本語">日本語</a></li>
                        </ul>
                        <ul class="columns inline main-nav">
                            <li class="hasSub"><a href="about.html" title="關於王品">關於王品</a>
                                <ul class="columns inline sub-nav">
                                    <li><a href="about.html">王品服務</a></li>
                                    <li><a href="about2.html">經典饗宴</a></li>
                                    <li><a href="about3.html">玫瑰公益</a></li>
                                    <li><a href="about4.html">品牌榮耀</a></li>
                                </ul>
                            </li>
                            <li class="hasSub"><a href="store.aspx" title="據點查詢">王品版圖 </a>
                                <ul class="columns inline sub-nav">
                                    <li><a href="http://partner.eztable.com/booking.php?page_name=wangsteak" target="_blank">線上預約</a></li>
                                    <li><a href="store.aspx">據點查詢</a></li>
                                </ul>
                            </li>
                            <li><a href="menu.html" title="珍藏美饌">珍藏美饌</a></li>
                            <li><a href="event.html" title="菁選活動">菁選活動</a></li>
                            <li><a href="e_member/index.htm" target="_blank" title="菁英禮讚">菁英禮讚</a></li>
                            <li class="active"><a href="member.html" title="會員專區">會員專區</a></li>
                            <li><a href="food.aspx" title="美食漫談">美食漫談</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
            <div class="banner">
                <div class="slogo wow fadeIn">
                    <h1 class="title-en">
                       <div>Member area</div>
                    </h1>
                </div>
                <div class="jqimgFill pic" data-focus-x="0" data-focus-y="0">
                    <img src="styles/images/member-banner.jpg" title="王品">
                </div>
            </div>
        </header>
        <!--main ================================================== -->
        <div id="main" class="page-memberForgetReset lineBk">
            <section class="section box1">
                <div class="container xs">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">重設密碼</h2>
                        <p class="wow fadeInUp">請填寫下方欄位完成密碼更換動作。</p>
                    </div>
                    <div class="info clear">
                        <form class="form" runat=server>
                            <div class="form-group">
                                <label for="account" class="label">新密碼</label>
                                <div class="col">
                                   <%-- <input type="text" class="form-control w60" id="account"><span class="note">4 - 8 個字元</span>--%>
                                   <asp:TextBox ID="pwd" runat="server" CssClass="form-control w60" MaxLength="8" 
                                     TextMode="Password"  placeholder="4 - 8 個字元"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group">
                                <label for="newpassword" class="label">再輸入一次新密碼</label>
                                <div class="col">
                                    <%--<input type="text" class="form-control w60" id="newpassword"><span class="note">4 - 8 個字元</span>--%>
                                    <asp:TextBox ID="chk_pwd" runat="server" CssClass="form-control w60" 
                                    MaxLength="8" TextMode="Password" placeholder="4 - 8 個字元"></asp:TextBox>
                                </div>
                            </div>
                            <div class="btnwp">
                                <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                <asp:Button ID="Button1" runat="server" Text="確定更換密碼"  
                                 CssClass="btn btn-primary" onclick="Button1_Click" />
          
                                  <asp:HiddenField ID="hidfFid" runat="server" />
                                  <asp:HiddenField ID="hidUid" runat="server" />
                            </div>
                        </form>
                    </div>
                </div>
            </section>
        </div>
        <!-- / main ================================================== -->
        <footer id="footer">
            <div class="container">
                <ul class="columns inline footer-nav">
                    <li class="active hasSub"><a href="about.html" title="關於王品">關於王品</a>
                        <ul class="rows sub-nav">
                            <li><a href="about.html">王品服務</a></li>
                            <li><a href="about2.html">經典饗宴</a></li>
                            <li><a href="about3.html">玫瑰公益</a></li>
                            <li><a href="about4.html">品牌榮耀</a></li>
                        </ul>
                    </li>
                    <li class="hasSub"><a href="store.aspx" title="據點查詢">王品版圖 </a>
                        <ul class="rows sub-nav">
                            <li><a href="http://partner.eztable.com/booking.php?page_name=wangsteak" target="_blank">線上預約</a></li>
                            <li><a href="store.aspx">據點查詢</a></li>
                        </ul>
                    </li>
                    <li><a href="menu.html" title="珍藏美饌">珍藏美饌</a></li>
                    <li><a href="event.html" title="菁選活動">菁選活動</a></li>
                    <li><a href="e_member/index.htm" target="_blank" title="菁英禮讚">菁英禮讚</a></li>
                    <li class="hasSub"><a href="member.html" title="會員專區">會員專區</a>
                        <ul class="rows sub-nav">
                            <li><a href="memberJoin.aspx">加入會員</a></li>
                            <li><a href="memberPreferentialLogin.aspx">生日禮</a></li>
                            <li><a href="memberPreferentialLogin2.aspx">結婚禮</a></li>
                        </ul>
                    </li>
                    <li><a href="food.aspx" title="美食漫談">美食漫談</a></li>
                    <li class="hasSub"><a href="#" title="會員專區">其他服務</a>
                        <ul class="rows sub-nav">
                            <li><a href="search.aspx">禮券查詢</a></li>
                            <li><a href="links.html">友好連結</a></li>
                            <li><a href="recruit.html">人才招募</a></li>
                        </ul>
                    </li>
                </ul>
                <dl class="time">
                    <dt>營業時間</dt>
                    <dd>11：30 ~ 14：30 (最後點餐時間14：00)
                        <br> 17：30 ~ 22：00 (最後點餐時間21：00)
                        <br> ※ 國定/例假日，彈性延長服務時間</dd>
                </dl>
                <div class="oter">
                    <p class="icon fb icon-facebook"><a href="https://www.facebook.com/%E7%8E%8B%E5%93%81%E7%89%9B%E6%8E%92%E7%8E%AB%E7%91%B0%E5%82%B3%E6%84%9B-138567179519483/?fref=ts" target="_blank">粉絲團</a></p>
                    <p class="icon app"><a href="http://www.wowprime.com/event/app/index.html"  target="_blank">瘋美食App</a></p>
                    <p class="icon mail icon-mail">想給我們意見, 想與我們合作,
                        <br> 請立即<a href="contact.html" class="fb">聯絡我們</a></p>
                    <p class="txt"><a href="privacyTerms.html">使用條款</a></p>
                    <p class="txt"><a href="privacy.html">隱私權政策</a></p>
                    <p class="copyright">© 2016 Wang Steak All Rights Reserved.</p>
                </div>
            </div>
        </footer>
    </div>
</body>

</html>