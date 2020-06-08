<%@ Page Language="C#" AutoEventWireup="true" CodeFile="storeInfo.aspx.cs" Inherits="storeInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

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
	
	<meta name="viewport" content="width=device-width, initial-scale=1">
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
                <div class="container">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">據點查詢</h2>
                        <ol class="nav columns">
                            <li>
                                <a href="#store1">北北基 </a>
                            </li>
                            <li>
                                <a href="#store2">桃竹苗</a>
                            </li>
                            <li>
                                <a href="#store3">中彰投</a>
                            </li>
                            <li>
                                <a href="#store4">雲嘉南</a>
                            </li>
                            <li>
                                <a href="#store5">高屏</a>
                            </li>
                        </ol>
                    </div>
                    <div class="info2">
                        
                        
                        
                        <%--<h3 id="store1">北北基</h3>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill">
                                <img src="styles/images/1505754adc60000003e4.JPG" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台北中山北店</h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd class="mpat">台北市中山區中山北路二段33號2樓
                                        <a href="styles/images/store-map.jpg" class="map" title="台北中山北店地圖" data-rel="lightcasepic:myCollection:slideshow"><img src="styles/images/store-map-icon.png" alt=""><span class="hidden">地圖</span></a>
                                    </dd>
                                    <dt>電話</dt>
                                    <dd>02-2536-1350</dd>
                                    <dt>營業時間</dt>
                                    <dd>午間：11:30~14:30 (最後點餐時間14:00)
                                        <br> 晚間：17:30~22:00 (最後點餐時間21:00)
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>停車場</dt>
                                    <dd>第一特約停車場、林森公園地下停車場、欣欣停車場、順安停車場、台壽金融大樓特約停車場。 消費用餐，可享停車優惠2小時</dd>
                                    <dt>特色介紹</dt>
                                    <dd>位於北市金融商業、精品購物以及文化藝術中心，捷運淡水信義線中山站3號出口，步行約5分鐘，近晶華及老爺酒店精品商圈；新光三越購物百貨，便利交通動線，是最具時尚風、觀光客雲集的王品。</dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.html" target="_blank" class="print btn2">列印</a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="styles/images/Image 001.png" width="1058" height="836" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台北南京東店</h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>台北市松山區南京東路四段169號
                                        <a href="styles/images/store-map.jpg" class="map" title="台北中山北店地圖" data-rel="lightcasepic:myCollection:slideshow"><img src="styles/images/store-map-icon.png" alt=""><span class="hidden">地圖</span></a>
                                    </dd>
                                    <dt>電話</dt>
                                    <dd>02-8770-7989</dd>
                                    <dt>營業時間</dt>
                                    <dd>午間：11:30~14:30 (最後點餐時間14:00)
                                        <br> 晚間：17:30~22:00 (最後點餐時間21:00)
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>停車場</dt>
                                    <dd>震旦21世紀大樓，特約停車場 消費用餐，可享停車優惠2小時</dd>
                                    <dt>特色介紹</dt>
                                    <dd>地處松山區商業金融中心，鄰近捷運松山新店線小巨蛋站5號出口，以堤頂大道連接內湖園區，精巧、雅緻的用餐空間，是商務及友人聚餐的首選。</dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.html" target="_blank" class="print btn2">列印</a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="styles/images/Image 002.png" width="1197" height="780" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>台北光復南店 <span>New open 璀璨新裝敬邀饗宴</span></h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>台北市大安區光復南路612號2樓
                                        <a href="styles/images/store-map.jpg" class="map" title="台北中山北店地圖" data-rel="lightcasepic:myCollection:slideshow"><img src="styles/images/store-map-icon.png" alt=""><span class="hidden">地圖</span></a>
                                    </dd>
                                    <dt>電話</dt>
                                    <dd>02-2325-3478</dd>
                                    <dt>營業時間</dt>
                                    <dd>午間：11:30~14:30 (最後點餐時間14:00)
                                        <br> 晚間：17:30~22:00 (最後點餐時間21:00)
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>停車場</dt>
                                    <dd>世紀金融，特約停車場 消費用餐可享停車優惠2小時</dd>
                                    <dt>特色介紹</dt>
                                    <dd>位於通化街、世貿中心商業金融地段，可搭乘淡水信義線，信義安和站3號出口，往光復南路方向步行約10分鐘，鄰近通化街夜市、101、新光三越信義新天地及誠品信義旗艦店等百貨商圈，2樓坐望光復南路大片窗景用餐區，無論商務或家庭聚餐，都是最愜意的餐廳。</dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.html" target="_blank" class="print btn2">列印</a>
                                </div>
                            </div>
                        </div>
                        <h3 id="store2">桃竹苗</h3>
                        <div class="list-item clear auto">
                            <div class="view left jqimgFill"><img src="styles/images/Image 003.png" width="1397" height="938" alt="" />
                            </div>
                            <div class="txt right">
                                <h4>新竹北大店</h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>新竹市北區北大路346號2樓
                                        <a href="styles/images/store-map.jpg" class="map" title="台北中山北店地圖" data-rel="lightcasepic:myCollection:slideshow"><img src="styles/images/store-map-icon.png" alt=""><span class="hidden">地圖</span></a>
                                    </dd>
                                    <dt>電話</dt>
                                    <dd>03-525-3236</dd>
                                    <dt>營業時間</dt>
                                    <dd>午間：11:30~14:30 (最後點餐時間14:00)
                                        <br> 晚間：17:30~22:00 (最後點餐時間21:00)
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                    </dd>
                                    <dt>停車場</dt>
                                    <dd>民富特約停車場(限高1.5公尺) 消費用餐，可享停車優惠2小時</dd>
                                    <dt>特色介紹</dt>
                                    <dd>鄰近新竹市中心，附近有知名古蹟景點及著名城隍廟，在品嚐美食後能便捷的沐浴在城市歷史文化氛圍，更是竹科園區招待商務客人的慎選餐廳。</dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.html" target="_blank" class="print btn2">列印</a>
                                </div>
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
        </div>
        </section>
    </div>
    <!-- / main ================================================== -->
    <div pload="footer.html"></div>
</body>

</html>

