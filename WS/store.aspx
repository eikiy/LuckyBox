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
                       <!-- <%--  -->
                        <div class="list-item">
                            <h3 id="store1">
                                北北基
                            </h3>
                            <div class="list tbl">
                                <div class="row">
                                    <a href="storeInfo.aspx#store1">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            台北羅斯福店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            台北市中正區羅斯福路二段9號
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='02-2393-4689'">
                                                02-2393-4689
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store1">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            台北中山北店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            台北市中山區中山北路二段33號2樓
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='02-2536-1350'">
                                                02-2536-1350
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store1">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            台北南京東店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            台北市松山區南京東路四段169號
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='02-8770-7989'">
                                                02-8770-7989
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store1">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            台北光復南店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            台北市大安區光復南路612號2樓
                                            <br>
                                            <em>
                                                台北光復南店營業至5/31，6/1起將由台北羅斯福店為您服務!
                                            </em>
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='02-2325-3478'">
                                                02-2325-3478
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store1">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            板橋縣民大道店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            新北市板橋區縣民大道一段189號2樓
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='02-2272-2016'">
                                                02-2272-2016
                                            </span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <div class="list-item">
                            <h3 id="store2">
                                桃竹苗
                            </h3>
                            <div class="list tbl">
                                <div class="row">
                                    <a href="storeInfo.aspx#store2">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            新竹北大店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            新竹市北區北大路346號2樓
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='03-525-3236'">
                                                03-525-3236
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store2">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            中壢延平店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            桃園市中壢區延平路552號2樓
                                            <br>
                                            <em>
                                                新裝打造「航空城」向地方致敬
                                            </em>
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='03-425-9009'">
                                                03-425-9009
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store2">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            桃園同德店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            桃園市桃園區同德五街69號3樓
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='03-356-1887'">
                                                03-356-1887
                                            </span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <div class="list-item">
                            <h3 id="store3">
                                中彰投
                            </h3>
                            <div class="list tbl">
                                <div class="row">
                                    <a href="storeInfo.aspx#store3">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            台中文心店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            台中市西屯區寧夏路233號
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='04-2313-6430'">
                                                04-2313-6430
                                            </span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <div class="list-item">
                            <h3 id="store4">
                                雲嘉南
                            </h3>
                            <div class="list tbl">
                                <div class="row">
                                    <a href="storeInfo.aspx#store4">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            台南健康店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            台南市中西區健康路一段24號
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='06-2137966'">
                                                06-2137966
                                            </span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                        <br>
                        <br>
                        <div class="list-item">
                            <h3 id="store6">
                                高屏
                            </h3>
                            <div class="list tbl">
                                <div class="row">
                                    <a href="storeInfo.aspx#store6">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            高雄中正店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            高雄市新興區中正三路88號
                                            <br>
                                            <em>
                                                新裝打造「工業藝廊」向地方致敬
                                            </em>
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='07-236-3536'">
                                                07-236-3536
                                            </span>
                                        </div>
                                    </a>
                                </div>
                                <div class="row">
                                    <a href="storeInfo.aspx#store6">
                                        <div class="col-sm-2 tbl-content tbl-title">
                                            高雄博愛店
                                            <span class="icon-search-more">
                                                <img src="images/icon-search.png" />
                                                看更多
                                            </span>
                                        </div>
                                        <div class="col-sm-7 tbl-content addr">
                                            高雄市左營區博愛二路360-2號
                                        </div>
                                        <div class="col-sm-3 tbl-content">
                                            <span class="telbtn" onclick="location.href='07-557-6557'">
                                                07-557-6557
                                            </span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
          <!-- --%> -->
                   
                   
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

