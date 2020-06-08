<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberJoinSendOk.aspx.cs" Inherits="memberJoinSendOk" %>

<!DOCTYPE html>
<html lang="zh-TW" xml:lang="zh-TW">
<head>
<!-- Title and Meta
	================================================== -->
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge" />
	<meta http-equiv="X-UA-Compatible" content="IE=9" />
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
	<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
	<link rel="stylesheet" type="text/css" href="styles/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="styles/style.css">
	<!--[if lt IE 9]>
	    <script src="scripts/default/html5shiv.min.js"></script>
	    <script src="scripts/default/respond.min.js"></script>
	<![endif]-->
	<script src="scripts/default/modernizr.js"></script>
	<script src="scripts/js.js"></script>
	<script src='scripts/plugins/wow.min.js'></script>
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
		<div pload="pmenu_1.html"></div>
		
		<div class="banner">
			<div class="slogo wow fadeIn center">
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
                            <h4><span class="red">主廚私房菜</span> 兌換券</h4>
                            <ul>
                              <li>憑券消費套餐，款待「主廚私房菜乙份」</li>
                                <li>點餐時請主動出示本兌換券</li>
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
                            用餐資訊查詢 https://www.wangsteak.com.tw 免付費意見專線:0800-071-198 網路專用‧影印無效
                            <img src="styles/images/slogo.png" alt="王品" class="slogo">
                        </footer>
                    </div>
                    <div class="form">
                        <div class="center">
                            <%--<a class="btn btn-primary" href="memberPreferentialPrint.html">列印</a>--%>
                            <input type="button" value="列印" onClick="window.print()" class="btn btn-primary">

                        </div>
                    </div>
                </div>
            </section>
        </div>
        <!-- / main ================================================== -->
        <div pload="footer.html"></div>
    </div>
</body>

</html>
