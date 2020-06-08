<%@ Page Language="C#" AutoEventWireup="true" CodeFile="storeInfo.aspx.cs" Inherits="en_storeInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html lang="jp" xml:lang="jp">
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

<body class="jp">

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

<form>
    <div class="wp page">
		<header id="header">
			<div pload="pmenu_1.html"></div>
				
			<div class="banner">
				<div class="slogo wow fadeIn center">
					<h1 class="title-en">
						<div>Stores</div>
					</h1>
				</div>
				<div class="bannerimg" data-focus-x="0" data-focus-y="0" style="background-image: url(styles/images/store-banner.jpg)"></div>
			</div>
		</header>
        <!--main ================================================== -->
        <div id="Div1" class="page-store lineBk bg2">
            <section class="section box1">
                <div class="container">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">店舖案內</h2>
                        <ol class="nav columns inline">
                            <li>
                                <a href="#store1">North Taiwan 北台湾</a>
                            </li>
                            <li>
                                <a href="#store2">Central Taiwan 中台湾</a>
                            </li>
                            <li>
                                <a href="#store3">South Taiwan 南台湾</a>
                            </li>
                        </ol>
                    </div>
                    <div class="info2">
                          <%--
                        <h3 id="store1">北台湾</h3>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill">
                                <img src="../styles/images/1505754adc60000003e4.JPG" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台北中山北店</h4>
                                <dl class="dl-horizontal">
                                    <dt>アドレス</dt>
                                    <dd class="mpat">台北市中山區中山北路二段33號2樓</dd>
                                    <dt>電話</dt>
                                    <dd>+886 2-2536-1350</dd>
                                    <dt>営業時間</dt>
                                    <dd>午間：11:30~14:30
                                        <br> 晚間：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>駐車場</dt>
                                    <dd>ご来店のお客様に、2時間無料のパーキングサービスをご提供いたします。</dd>
                                    <dt>機能の説明</dt>
                                    <dd>MRT中山駅から徒步約5分</dd>
                                </dl>
                            </div>
                        </div>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="../styles/images/Image 001.png" width="1058" height="836" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台北南京東店</h4>
                                <dl class="dl-horizontal">
                                    <dt>アドレス</dt>
                                    <dd>台北市松山區南京東路四段169號</dd>
                                    <dt>電話</dt>
                                    <dd>+886 2-8770-7989</dd>
                                    <dt>営業時間</dt>
                                    <dd>午間：11:30~14:30
                                        <br> 晚間：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>駐車場</dt>
                                    <dd>ご来店のお客様に、2時間無料のパーキングサービスをご提供いたします。</dd>
                                </dl>
                            </div>
                        </div>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="../styles/images/Image 002.png" width="1197" height="780" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台北光復南店 <span>New open 璀璨新裝敬邀饗宴</span></h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>台北市大安區光復南路612號2樓</dd>
                                    <dt>電話</dt>
                                    <dd>+886 2-2325-3478</dd>
                                    <dt>営業時間</dt>
                                    <dd>午間：11:30~14:30
                                        <br> 晚間：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>駐車場</dt>
                                    <dd>ご来店のお客様に、2時間無料のパーキングサービスをご提供いたします。</dd>
                                    <dt>機能の説明</dt>
                                    <dd>TAIPEI 101 購物中心から徒步約15分</dd>
                                </dl>
                            </div>
                        </div>
                        <h3 id="store2">中台湾</h3>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="../styles/images/Image 003.png" width="1397" height="938" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台中五權店</h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>台中市五權路131號</dd>
                                    <dt>電話</dt>
                                    <dd>+886 4-2201-2012</dd>
                                    <dt>営業時間</dt>
                                    <dd>午間：11:30~14:30
                                        <br> 晚間：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>停車場</dt>
                                    <dd>ご来店のお客様に、2時間無料のパーキングサービスをご提供いたします。</dd>
                                </dl>
                            </div>
                        </div>
                        <h3 id="store3">南台湾</h3>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="../styles/images/Image 003.png" width="1397" height="938" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台南中華東店</h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>台南市東區中華東路一段92號1樓</dd>
                                    <dt>電話</dt>
                                    <dd>+886 6-275-8979</dd>
                                    <dt>営業時間</dt>
                                    <dd>午間：11:30~14:30
                                        <br> 晚間：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>停車場</dt>
                                    <dd>ご来店のお客様に、2時間無料のパーキングサービスをご提供いたします。</dd>
                                </dl>
                            </div>
                        </div>
                    
                    --%>
                    
                    
                    
                    
                          <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
                              
                    </div>
                </div>
        </div>
        </section>
    </div>
    <!-- / main ================================================== -->
    <div pload="footer.html"></div>
    </form>
</body>

</html>
