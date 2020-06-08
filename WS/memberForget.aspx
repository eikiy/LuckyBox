<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberForget.aspx.cs" Inherits="memberForget" %>

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
<style type="text/css">
    #imgcode
    {
        height: 50px;
        width: 129px;
    }
</style>
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
        <div id="main" class="page-memberForget lineBk">
            <section class="section box1">
                <div class="container sm
">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">忘記密碼</h2>
                        <p class="wow fadeInUp">請輸入帳號，我們將回覆【密碼重設通知信】到您email 信箱中。</p>
                    </div>
                    <div class="info clear">
                        <%--<form class="form" action="memberForgetSend.html" runat="server">--%>
                        <form id="Form1" class="form" runat="server">
                            <div class="form-group row">
                                <label for="mail" class="col-sm-3 control-label">e-mail 帳號</label>
                                <div class="col-sm-8">
                                    <%--<input type="text" class="form-control w100" id="mail">--%>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" 
                                     MaxLength="80"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="code" class="col-sm-3 control-label">驗證碼</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w20" id="code">--%>
                                    <asp:TextBox ID="code" runat="server" CssClass="form-control w20" MaxLength="5"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-2 col-sm-offset-3">
                                    <%--<img src="styles/images/code.png" alt="">--%>
                                    <iframe name="imgcode" id="imgcode" src="img/code.aspx"  scrolling="no" frameborder="0">
                                    </iframe> 
                                </div>
                                <div class="col-sm-7">
                                     <%--<span class="ch"><button onclick="document.getElementById('imgcode').contentWindow.location.reload();">更換別組圖示 </button> (請輸入驗證碼，不分大小寫)</span>--%>
                                     <span class="ch">    
                                     <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();" class="chA">更換別組圖示</a>
                                     (請輸入驗證碼，不分大小寫)</span>
                                </div>
                            </div>
                            <div class="form-group row row">
                                <div class="btnwp">
                                    <%--<button type="submit" class="btn btn-primary">確認送出
                                    </button>--%>
                                    <asp:Button ID="Button1" runat="server" Text="重設密碼" CssClass="btn btn-primary" 
                                     onclick="Button1_Click" />
                                </div>
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