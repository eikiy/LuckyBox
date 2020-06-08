<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberJoinSend.aspx.cs" Inherits="memberJoinSend" %>

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
                        <h2 class="title">成功加入會員</h2>
                    </div>
                    <div class="info clear">
                        <form class="form" runat=server>
                            <p class="center"><asp:Label id="lblName" runat="server"></asp:Label>
                              貴賓： 您的會員認證資料已發送到 <%--yahoo@yahoo.com.tw--%>
                            <asp:Label id="labEmail" runat="server"></asp:Label>
                                <br> 請至此 email 信箱確認，歡迎您註冊成為王品網路會員，享受個人專屬優惠 。</p>
                            <div class="btnwp">
                                <button type="submit" class="btn btn-primary">回會員中心
                            </div>
                        </form>
                    </div>
                    <div class="oter">
                        <h3>是否一直沒收到確認信函?</h3>
                        <ul>
                            <li>首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。</li>
                            <li>倘若您一直沒收到確認信函，建議您可檢查您的 email 是否有錯誤。若發現任何錯誤,可再重新註冊一次即可。</li>
                            <li>建議您可檢查郵件信箱的垃圾郵件夾，檢查是否有 王品 的註冊確認信函。</li>
                            <li>若您一直無法收到確認信函，歡迎您可填寫 客服信箱 或 撥打免付費意見專線<strong> 0800-071-198</strong> 為您處理。 </li>
                        </ul>
                    </div>
                </div>
            </section>
        </div>
        <!-- / main ================================================== -->
        <div pload="footer.html"></div>
    </div>
</body>

</html>

