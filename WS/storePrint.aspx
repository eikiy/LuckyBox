<%@ Page Language="C#" AutoEventWireup="true" CodeFile="storePrint.aspx.cs" Inherits="storePrint" %>

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

<body class="bk" onLoad="javascript:window.print()">
    <div class="wp page">
        <div id="main" class="page-store">
            <section class="section box1">
                <div class="container">
                    <div class="info2">
                        <div class="list-item clear auto">
                            <%--<div class="view left jqimgFill">
                                <img src="styles/images/1505754adc60000003e4.JPG" alt="" />
                            </div>--%>
                            
                            <asp:Literal ID="LiteArea_A" runat="server"></asp:Literal>
                            
                            <%--<div class="txt right">
                                <h4>新竹北大店</h4>
                                <dl class="dl-horizontal">
                                    <dt>地址 </dt>
                                    <dd>新竹市北區北大路346號2樓
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
                            </div>--%>
                        
                        
                        
                            <asp:Literal ID="LiteArea_B" runat="server"></asp:Literal>
                        
                        </div>
                    </div>
                </div>
        </div>
        </section>
    </div>
    <!-- / main ================================================== -->
    </div>
</body>

</html>

