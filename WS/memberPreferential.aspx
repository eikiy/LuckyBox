<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberPreferential.aspx.cs" Inherits="memberPreferential" %>

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

<form id="form1" runat="server">
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
        <div id="main" class="page-memberPreferential lineBk">
            <section class="section box1">
                <div class="container sm">
                    <div class="hd">
                        <h2 class="title  wow fadeInDown">生日禮券兌換</h2>
                        <p>
                          <asp:Label ID="lblName2" runat="server" Text=""></asp:Label>
                          貴賓
                        
                        您好：
                            <br> 王品祝您生日快樂~
                            <br> 您可以列印此兌換券，憑本券至全台王品消費，獨享生日驚喜優惠款待。
                        </p>
                    </div>
                </div>
            </section>
            <section class="section box2 bg2">
                <div class="conpon" id="myDiv">
                    <h3 class="title">&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp生日禮</h3>
                    <div class="qrcord" align="left">
                        <%--<img src="styles/images/qrcode.jpg" alt="">--%>
                        <asp:Image ID="Image1" runat="server" width="180" height="180"/> 
                        <br>
                        <asp:Label ID="lblBarcode" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="txt">
                      <p>這是給
                        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
                        的</p>
                        <h4><span>生日祝福 9折款待</span></h4>
                        <p>&nbsp;</p>
                        <ul>
                          <li>憑券消費$1350套餐尊享【9折】</li>
                            <li>每桌每次消費限用本券乙次，10%服務費另計。</li>
                            <li>不適用外帶、禮券購買且不與其它折扣優惠併用。</li>
                            <li>本券適用於台灣王品直營店</li>

                            <li>使用期限至 <asp:Label ID="lblExpiredDate" runat="server" Text=""></asp:Label> </li>
                      </ul>
                    </div>
                    <div class="pic">
                        <img src="styles/images/conpon-birthday.jpg" alt="">
                    </div>
                    <footer>
                        用餐資訊查詢 https://www.wangsteak.com.tw 免付費意見專線:0800-071-198網路專用‧影印無效
                        <img src="styles/images/slogo.png" alt="王品" class="slogo">
                    </footer>
                </div>
                <div class="form">
                    <div class="center">
                        <%--<a class="btn btn-primary" href="memberPreferentialPrint.html">列印</a>--%>                        
                        <input type="button" value="列印" onClick="window.print()" class="btn btn-primary"> 
                    </div>
                </div>
            </section>
        </div>
        <!-- / main ================================================== -->
        <div pload="footer.html"></div>
    </div>
    </form>
</body>

</html>
