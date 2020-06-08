<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberJoinSendOk.aspx.cs" Inherits="memberJoinSendOk" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html lang="zh-TW" xml:lang="zh-TW">

<head>
    <!-- Title and Meta
================================================== -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>王品</title>
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
    <link rel="stylesheet" type="text/css" href="~/styles/style.css">
    <!--[if lt IE 9]>
    <script src="scripts/default/html5shiv.min.js"></script>
    <script src="scripts/default/respond.min.js"></script>
    <![endif]-->
    <script src="~/scripts/default/modernizr.js"></script>
</head>

<body>
    <div class="wp page">
        <header id="header">
            <div class="navbar">
                <div class="container">
                    <a class="logo" href="index.html" data-menu="index" title="王品">
                        <img src="styles/images/logo.png" alt="王品logo">
                        <h1 class="text-hide">王品</h1>
                    </a>
                    <nav class="nav">
                        <h1 class="text-hide">主選單</h1>
                        <ul class="columns inline top-nav">
                            <li class="contact"><a href="contact.html" title="聯絡我們">聯絡我們</a></li>
                            <li><a href="en/about.htm" target="_blank" title="English">English</a></li>
<li><a href="JP/about.htm" target="_blank" title="日本語">日本語</a></li>
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
                            <li><a href="events.html" title="菁選活動">菁選活動</a></li>
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
        <div id="main" class="page-memberReissue lineBk">
            <section class="section box1">
                <div class="container sm">
                    <div class="hd">
                        <h2 class="title">成功啟用帳號</h2>
                    </div>
                    <div class="info clear">
                        <form class="form" action="member.html">
                            <p class="center">貴賓 <asp:Literal ID="LiteName2" runat="server"></asp:Literal> 您好：
                                <br> 您已經成功啟動您的帳號！歡迎您加入王品網站會員行列，您將會不定期收到促銷活動及優惠訊息。 您可以列印此兌換券，憑本券至王品消費，即可享優惠。
                            </p>
                        </form>
                    </div>
                    <div class="conpon" id="myDiv">
                        <h3 class="title">網路入會禮</h3>
                        <div class="qrcord">
                            <%--<img src="styles/images/qrcode.jpg" alt="">--%>
                            <asp:Literal ID="LiteQR" runat="server"></asp:Literal>
                            <br>
                            <asp:Literal ID="LiteNO" runat="server"></asp:Literal>
                        </div>
                        <div class="txt">
                            <p>這是給<asp:Literal ID="LiteName" runat="server"></asp:Literal>的</p>
                            <h4><span class="red">玫瑰馬克杯</span> 兌換券</h4>
                            <ul>
                                <li>憑本券消費套餐，即可兌換「玫瑰馬克杯」乙個</li>
                                <li>每桌每次消費限兌換乙張</li>
                                <li>贈品以實物為主，若送完則改贈其他等值禮品</li>
                                <li>本券適用於台灣王品直營店</li>
                                <li>使用期限至 <asp:Literal ID="LiteDate" runat="server"></asp:Literal></li>
                            </ul>
                        </div>
                        <div class="pic">
                            <img src="styles/images/conpon-bg.jpg" alt="">
                        </div>
                        <footer>
                            用餐資訊查詢 http://www.wangsteak.com.tw 免付費意見專線:0800-440-800 網路專用‧影印無效
                            <img src="styles/images/slogo.png" alt="王品" class="slogo">
                        </footer>
                    </div>
                    <div class="form">
                        <div class="center">
                            <a class="btn btn-primary" href="memberPreferentialPrint.html">列印</a>
                        </div>
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
                    <li><a href="events.html" title="菁選活動">菁選活動</a></li>
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
                    <p class="icon app"><a href="http://www.wowprime.com/event/app/index.html" target="_blank">瘋美食App</a></p>
                    <p class="icon mail icon-mail">想給我們意見, 想與我們合作,
                        <br> 請立即<a href="contact.html" class="fb">聯絡我們</a></p>
                    <p class="txt"><a href="privacyTerms.html">使用條款</a></p>
                    <p class="txt"><a href="privacy.html">隱私權政策</a></p>
                    <p class="copyright">© 2016 Wang Steak All Rights Reserved.</p>
                </div>
            </div>
        </footer>
    </div>
    <!-- javascript ================================================== -->
    <script src="scripts/js.js"></script>
</body>

</html>
