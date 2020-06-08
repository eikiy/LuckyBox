<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberForgetSend.aspx.cs" Inherits="memberForgetSend" %>

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
        <div id="main" class="page-memberForget lineBk">
            <section class="section box1">
                <div class="container sm">
                    <div class="hd">
                        <h2 class="title">忘記密碼</h2>
                    </div>
                    <div class="info clear">
                        <form class="form" action="member.html">
                            <p class="center">您的密碼已寄發至您的信箱，請至您的信箱收取【密碼重設通知信】</p>
                            <div class="btnwp">
                                <button type="submit" class="btn btn-primary">回會員中心
                                </button>
                            </div>
                        </form>
                    </div>
            </section>
            </div>
            <!-- / main ================================================== -->
            <div pload="footer.html"></div>
        </div>
</body>

</html>
