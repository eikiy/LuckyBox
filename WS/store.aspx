<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store.aspx.cs" Inherits="store" %>

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
	
<!-- 201805Global site tag (gtag.js) - Google Analytics -->
<script async src="https://www.googletagmanager.com/gtag/js?id=UA-119765785-1"></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'UA-119765785-1');
</script>
<!-- Global site tag (gtag.js) - END -->

    </head>
<body>

<form id="form1" runat="server">
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
        
        <div id="main" class="page-store lineBk bg2">
            <section class="section box1">
                <div class="container sm">
                    <div class="hd">
                    <!--<h2 class="title wow fadeInDown"><span style="color:red;">因受瑪莉亞颱風影響，提醒您於出門前打電話確認餐廳是否營業，謝謝!</span></h2>-->
                        <h2 class="title wow fadeInDown">據點查詢</h2>
                        <ol class="nav columns">
                            <li class="store-btn">
                                <a href="#store1">北北基 </a>
                            </li>
                            <li class="store-btn">
                                <a href="#store2">桃竹苗</a>
                            </li>
                            <li class="store-btn">
                                <a href="#store3">中彰投</a>
                            </li>
                            <li class="store-btn">
                                <a href="#store4">雲嘉南</a>
                            </li>
                            <li class="store-btn">
                                <a href="#store5">高屏</a>
                            </li>
                        </ol>
                        <script>
                            $(function () {
                                $(".store-btn:first").css({	
                                    "background-color": "#ab1c15"
                                });
                                $(".store-btn:first a").css({
                                    "color": "#FFFFFF"
                                });
                                $(".store-btn").click(function () {
                                    $(".store-btn:first").removeAttr("style");
                                    $(".store-btn:first a").removeAttr("style");
                                });
                            })
                        </script>
                    </div>
                    <div class="info">
                    
                    
                      
                       <%-- <div class="list-item">
                            <h3 id="store1">北北基</h3>
                            <div class="list">
                                <a href="storeInfo.html"><h4>台北中山北店</h4>
                                    <p><span class="addr">台北市中山區中山北路二段33號2樓                                    </span><span class="telbtn" onclick="location.href='tel:02-2536-1350'">02-2536-1350</span></p></a>
                                <a href="storeInfo.html"><h4>台北南京東店</h4>
                                    <p><span class="addr">台北市松山區南京東路四段169號<br><em>New open 璀璨新裝敬邀饗宴</em></span><span class="telbtn" onclick="location.href='tel:02-8770-7989'">02-8770-7989</span></p></a>
                                <a href="storeInfo.html"><h4>台北光復南店</h4>
                                    <p><span class="addr">台北市大安區光復南路612號2樓                                       </span><span class="telbtn" onclick="location.href='tel:02-2325-3478'">02-2325-3478</span></p></a>
                                <a href="storeInfo.html"><h4>台北和平東店</h4>
                                    <p><span class="addr">台北市大安區和平東路一段177號</span><span class="telbtn" onclick="location.href='tel:02-2393-4689'">02-2393-4689</span></p></a>
                                <a href="storeInfo.html"><h4>板橋縣民大道店</h4>
                                    <p><span class="addr">新北市板橋區縣民大道一段189號2樓<br><em>New open 璀璨新裝敬邀饗宴(馥都飯店2樓；府中捷運站1號出口)</em></span><span class="telbtn" onclick="location.href='tel:02-2272-2016'">02-2272-2016</span></p></a>
                            </div>
                        </div>
                        <div class="list-item">
                            <h3 id="store2">桃竹苗</h3>
                            <div class="list">
                                <a href="storeInfo.html"><h4>新竹北大店</h4>
                                    <p><span class="addr">新竹市北區北大路346號2樓</span><span class="telbtn" onclick="location.href='tel:03-525-3236'">03-525-3236</span></p></a>
                                <a href="storeInfo.html"><h4>中壢延平店</h4>
                                        <p><span class="addr">桃園市中壢區延平路552號2樓</span><span class="telbtn" onclick="location.href='tel:03-425-9009'">03-425-9009</span></p></a>
                                <a href="storeInfo.html"><h4>桃園中山店</h4>
                                    <p><span class="addr">桃園市桃園區中山路546號</span><span class="telbtn" onclick="location.href='tel:03-339-1650'">03-339-1650</span></p></a>
                            </div>
                        </div>
                        <div class="list-item">
                            <h3 id="store3">中彰投</h3>
                            <div class="list">
                                <a href="storeInfo.html"><h4>台中五權店</h4>
                                    <p><span class="addr">台中市西區五權路131號</span><span class="telbtn" onclick="location.href='tel:04-2201-2012'">04-2201-2012</span></p></a>
                                <a href="storeInfo.html"><h4>台中文心店</h4>
                                    <p><span class="addr">台中市西屯區寧夏路233號</span><span class="telbtn" onclick="location.href='tel:04-2313-6430'">04-2313-6430</span></p></a>
                                <a href="storeInfo.html"><h4>台中台灣大道店</h4>
                                    <p><span class="addr">台中市西屯區台灣大道四段771號2樓</span><span class="telbtn" onclick="location.href='tel:04-2355-3155'">04-2355-3155</span></p></a>
                            </div>
                        </div>
                        <div class="list-item">
                            <h3 id="store4">雲嘉南</h3>
                            <div class="list">
                                <a href="storeInfo.html"><h4>台南中華東店</h4>
                                    <p><span class="addr">台南市東區中華東路一段92號1樓</span><span class="telbtn" onclick="location.href='tel:06-275-8979'">06-275-8979</span></p></a>
                            </div>
                        </div>
                        <div class="list-item">
                            <h3 id="store5">高屏</h3>
                            <div class="list">
                                <a href="storeInfo.html"><h4>高雄中正店 </h4>
                                    <p><span class="addr">高雄市新興區中正三路88號 </span><span class="telbtn" onclick="location.href='tel: 07-236-3536'">07-236-3536</span></p></a>
                                <a href="storeInfo.html"><h4>高雄明誠店</h4>
                                    <p><span class="addr">高雄市左營區明誠二路476號 </span><span class="telbtn" onclick="location.href='tel:07-557-6557'">07-557-6557</span></p></a>
                            </div>
                        </div>
          --%>
                   
                   
                          <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea4" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea5" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea6" runat="server"></asp:Literal>
                   
                   
                   
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

