<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberReissue.aspx.cs" Inherits="memberReissue" %>

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
            <section class="section box1 bg2">
                <div class="container sm">
                    <div class="hd">
                        <h2 class="title  wow fadeInDown">補發確認信</h2>
                        <p class="wow fadeInUp">請輸入 email 帳號，我們會儘快補發會員確認信函回覆到您 email 信箱中。</p>
                    </div>
                    <div class="info clear">
                        <form class="form" runat=server >
                            <div class="form-group row">
                                <label for="mail" class="col-sm-2 col-sm-offset-4 control-label">e-mail 帳號</label>
                                <div class="col-sm-3">
                                    <%--<input type="text" class="form-control w100" id="mail">--%>
                                    <asp:TextBox ID="email" runat="server" CssClass="form-control w100" 
                                     MaxLength="80"></asp:TextBox>
                                </div>
                            </div>
							<div class="form-group row">
								<div class="col-sm-12">
                                    <div class="btnwp">
                                        <%--<button type="submit" class="btn btn-primary">確認送出
                                        </button>--%>
                                        <asp:Button ID="Button1" runat="server" Text="送出" CssClass="btn btn-primary" 
                                        onclick="Button1_Click" />
                                    </div>
                                </div>
                            </div>
                        </form>
                    </div>
                    <div class="oter">
                        <h3>是否一直沒收到確認信函
?</h3>
                        <ul>
                            <li>首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。</li>
                            <li>倘若您一直沒收到確認信函，建議您可檢查您的 email 是否有錯誤。若發現任何錯誤，可再重新註冊一次即可。</li>
                            <li>建議您可檢查郵件信箱的垃圾郵件夾，檢查是否有 王品 的註冊確認信函。</li>
                            <li>若您一直無法收到確認信函，歡迎您可填寫 客服信箱 或 撥打免付費意見專線<strong> 0800-071-198</strong>為您處理。 </li>
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
