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
    <script>
        $(function(){
            $('.store1').click(function(){ $('html,body').animate({scrollTop:$('#store1').offset().top - 90}, 800); });
            $('.store2').click(function(){ $('html,body').animate({scrollTop:$('#store2').offset().top - 90}, 800); });
            $('.store3').click(function(){ $('html,body').animate({scrollTop:$('#store3').offset().top - 90}, 800); });
            $('.store4').click(function(){ $('html,body').animate({scrollTop:$('#store4').offset().top - 90}, 800); });
            $('.store5').click(function(){ $('html,body').animate({scrollTop:$('#store6').offset().top - 90}, 800); });
            return false;
        });
    </script>
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
                            <li class="store-btn">
                                <a class="store1">北北基 </a>
                            </li>
                            <li class="store-btn">
                                <a class="store2">桃竹苗</a>
                            </li>
                            <li class="store-btn">
                                <a class="store3">中彰投</a>
                            </li>
                            <li class="store-btn">
                                <a class="store4">雲嘉南</a>
                            </li>
                            <li class="store-btn">
                                <a class="store5">高屏</a>
                            </li>
                        </ol>
                    </div>
                    <div class="info2">
                        <h3 id="store1">北北基</h3>
                        <div class="list-item clear auto" id="10308">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10308.png"alt="台北羅斯福店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    台北羅斯福店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        台北市中正區羅斯福路二段9號
                                        <a href="map.htm?filename=15a4a2a79af000007fe2.jpg" class="map" title="台北羅斯福店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        02-2393-4689
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        凡消費用餐可享免費停車優惠2小時。
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        捷運松山新店線古亭站6號出口，直行羅斯福路約5分鐘可達，臨近鬧區西門町搭乘計程車與捷運皆十分便利，店裝以私廚為概念，紅色竱瓦堆沏入口意象，搭配開放式廚房與繁星點點燈光設計，彷彿置身於葡萄樹下用餐的氛圍。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10308" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto" id="10307">
                            <div class="left jqimgFill">
                               <img src="styles/images/store/103_10307.png"alt="台北中山北店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    台北中山北店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        台北市中山區中山北路二段33號2樓
                                        <a href="map.htm?filename=15c337486b3000002a25.png" class="map" title="台北中山北店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        02-2536-1350
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        第一特約停車場、林森公園地下停車場、台壽金控翔浩停車場B3/B4、中山北路二段42巷(中山ㄧ場停車場)、中山北路二段44巷(中山二場停車場)。消費用餐，可享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        位於北市金融商業、精品購物以及文化藝術中心，捷運淡水信義線中山站3號出口，步行約5分鐘，近晶華及老爺酒店精品商圈；新光三越購物百貨，便利交通動線，是最具時尚風、觀光客雲集的王品。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10307" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto" id="10306">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10306.png"alt="台北南京東店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    台北南京東店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        台北市松山區南京東路四段169號
                                        <a href="map.htm?filename=155299cd664000004f56.png" class="map" title="台北南京東店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        02-8770-7989
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        震旦21世紀大樓(建康路156號)，特約停車場消費用餐，可享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        地處松山區商業金融中心，鄰近捷運松山新店線小巨蛋站5號出口，以堤頂大道連接內湖園區，精巧、雅緻的用餐空間，是商務及友人聚餐的首選。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10306" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <!-- <div class="list-item clear auto" id="10314">
                            <div class="left jqimgFill">
                                <img src="http://wowfoods.wowprime.com/download?parent=store&filename=155299fdaf5000000388.png"alt="" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    台北光復南店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        台北市大安區光復南路612號2樓
                                        <a href="map.htm?filename=16d86bedfc2000005f2b.png" class="map" title="台北光復南店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        02-2325-3478
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        ．無特約停車場，可停放於週邊停車場及街邊車格，消費用餐可享停車優惠2小時。
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        位於通化街、世貿中心商業金融地段，可搭乘淡水信義線，信義安和站3號出口，往光復南路方向步行約10分鐘，鄰近通化街夜市、101、新光三越信義新天地及誠品信義旗艦店等百貨商圈，2樓坐望光復南路大片窗景用餐區，無論商務或家庭聚餐，都是最愜意的餐廳。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10314" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div> -->
                        <div class="list-item clear auto" id="10313">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10313.png"alt="板橋縣民大道店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    板橋縣民大道店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        新北市板橋區縣民大道一段189號2樓
                                        <a href="map.htm?filename=163291aea0400000bdfd.jpg" class="map" title="板橋縣民大道店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        02-2272-2016
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        南門商業大樓停車場、府中停車場凡消費用餐，可享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        台北捷運府中捷運站1號，位於馥都飯店2樓，位居交通便捷的三鐵共構樞紐，坐擁著板橋最繁華的百貨商圈，空間設計簡約而溫馨、高貴而內斂，提供新北市饕客們，品嚐美食饗宴的最佳選擇。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10313" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <h3 id="store2">桃竹苗</h3>
                        <div class="list-item clear auto" id="10311">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10311.png"alt="新竹北大店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    新竹北大店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        新竹市北區北大路346號2樓
                                        <a href="map.htm?filename=1680cb6b83200000a6f5.jpg" class="map" title="新竹北大店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        03-525-3236
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        民富停車場(限高1.5公尺，立體停車場)，延平停車場及仁德停車場，皆享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        鄰近新竹市中心，附近有知名古蹟景點及著名城隍廟，在品嚐美食後能便捷的沐浴在城市歷史文化氛圍，更是竹科園區招待商務客人的慎選餐廳。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10311" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto" id="10317">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10317.png"alt="中壢延平店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    中壢延平店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        桃園市中壢區延平路552號2樓
                                        <a href="map.htm?filename=15529a1005f000007f05.png" class="map" title="中壢延平店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        03-425-9009
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        延平路公有停車場，凡消費用餐，可享停車優惠2小時。因Google地圖定位偏差，請以本官網手繪地圖為準。
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        坐落於貫穿桃園、中壢市區交通便利的省道上，環抱著年輕潮流聖地中平商圈，提供中壢市民，品味經典美食饗宴的最佳選擇，餐後還可便利的逛街購物。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10317" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto" id="10304">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10304.png"alt="桃園同德店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    桃園同德店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        桃園市桃園區同德五街69號3樓
                                        <a href="map.htm?filename=155299c42fc000007b16.png" class="map" title="桃園同德店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        03-356-1887
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        中茂新天地B2特約停車場，凡消費用餐即享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        桃園頂級商務地段，中正藝文特區為最核心商圈，「桃園中茂新天地」位於藝文特區同德五街、中正路，近南桃園與南崁交流道，交通網絡發達。店裝與設計師合作營造低調奢華的用餐氣氛，呈現私人招待所的氣勢。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10304" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <h3 id="store3">中彰投</h3>
                        <div class="list-item clear auto" id="10301">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10301.png"alt="台中文心店" />
                            </div>
                            <div class="txt right">
                                <h4>台中文心店</h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        台中市西屯區寧夏路233號
                                        <a href="map.htm?filename=155299846380000030b1.png" class="map" title="台中文心店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        04-2313-6430
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        消費用餐，可享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        王品第一家店，於1993年開幕，近逢甲商圈與文教學區，是王品文化與都會新裝共譜的協奏曲，傳承著台中市民最愛的美食饗宴。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10301" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <h3 id="store4">雲嘉南</h3>
                        <div class="list-item clear auto" id="10322">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10322.png"alt="台南健康店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    台南健康店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        台南市中西區健康路一段24號
                                        <a href="map.htm?filename=16ed0ec1990000003098.jpg" class="map" title="台南健康店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        06-2137966
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間*除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        提供優惠停車場：五妃街及府連路口停車場、忠烈祠廣場停車場
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        首間由老宅翻新的「經典王品」餐廳，內部保留老宅原有的空間配置及物件－如沙龍交誼廳、水晶吊燈、幾何鏤刻鐵窗花、拱門、拱窗等特色，並融入Art
                                        Deco裝飾藝術風格，復古氛圍、華麗不凡。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10322" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <br>
                        <h3 id="store6">雲嘉南</h3>
                        <div class="list-item clear auto" id="10302">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10302.png"alt="高雄中正店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    高雄中正店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        高雄市新興區中正三路88號
                                        <a href="map.htm?filename=155299ab8b70000067a7.png" class="map" title="高雄中正店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        07-236-3536
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        財稅大樓地下停車場、仁愛特約停車場凡消費用餐，可享停車優惠2小時
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        位於捷運美麗島站8號出口及信義國小站1號出口間的美麗婚紗街，近六合夜市、新崛江等熱鬧商圈，用完餐後，還可逛逛城市光廊、中央公園，感受年輕活力，是城市漫步的好去處。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10302" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                        <div class="list-item clear auto" id="10316">
                            <div class="left jqimgFill">
                                <img src="styles/images/store/103_10316.png"alt="高雄博愛店" />
                            </div>
                            <div class="txt right">
                                <h4>
                                    高雄博愛店
                                </h4>
                                <dl class="dl-horizontal">
                                    <dt>
                                        地址
                                    </dt>
                                    <dd class="mpat">
                                        高雄市左營區博愛二路360-2號
                                        <a href="map.htm?filename=15a5b15426d0000016e5.jpg" class="map" title="高雄博愛店地圖"
                                        data-rel="lightcasepic:myCollection:slideshow">
                                            <img src="styles/images/store-map-icon.png" alt="">
                                            <span class="hidden">
                                                地圖
                                            </span>
                                        </a>
                                    </dd>
                                    <dt>
                                        電話
                                    </dt>
                                    <dd>
                                        07-557-6557
                                    </dd>
                                    <dt>
                                        營業時間
                                    </dt>
                                    <dd>
                                        午間：11:30~14:30(最後點餐時間14:00)晚間：17:30~22:00(最後點餐時間21:00)*國定/例假日，彈性延長服務時間，除夕公休
                                    </dd>
                                    <dt>
                                        停車場
                                    </dt>
                                    <dd>
                                        臨近三民家商/青雨/壹誠停車場，凡消費用餐可享停車優惠$100元
                                    </dd>
                                    <dt>
                                        特色介紹
                                    </dt>
                                    <dd>
                                        臨近高雄巨蛋購物廣場對面，為向國際港都致敬，新裝以遊艇為設計軸心，致力成為高雄的驕傲，璀璨新裝萬眾矚目敬邀蒞臨。
                                    </dd>
                                </dl>
                                <div class="text-right">
                                    <a href="storePrint.aspx?store_id=10316" target="_blank" class="print btn2">
                                        列印
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
        </div>
        </section>
    </div>
    <!-- / main ================================================== -->
    <div pload="footer.html"></div>
</body>

</html>

