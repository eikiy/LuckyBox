<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberPreferentialLogin2.aspx.cs" Inherits="memberPreferentialLogin2" %>

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
        <div id="main" class="page-memberPreferentialLogin lineBk">
            <section class="section box1">
                <div class="container xs">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">登入專屬優惠</h2>
                        <p class="wow fadeInUp">請輸入下方資料領取您的優惠下載。</p>
                    </div>
                    <div class="info clear">
                        <form class="form" runat=server>
                            <div class="form-group row">
                                <label for="account" class="col-sm-2 col-sm-offset-4 control-label">e-mail帳號:</label>
                                <div class="col-sm-3">
                                    <%--<input type="text" class="form-control w100" id="account">--%>
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control w100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="password" class="col-sm-2 col-sm-offset-4 control-label">密碼: </label>
                                <div class="col-sm-3">
                                   <%-- <input type="text" class="form-control w100" id="password">--%>
                                   <asp:TextBox ID="txtPwd" runat="server" MaxLength="8" TextMode="Password" placeholder="4 - 8 個字元" CssClass="form-control w100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="btnwp">
                                    <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                    <asp:Button ID="Button1" runat="server" Text="確認送出" CssClass="btn btn-primary" onclick="Button1_Click" />
                                    <%--<a href="memberForget.aspx" class="btn btn-primary">忘記密碼</a>--%>
                                    <asp:Button ID="Button2" runat="server" Text="忘記密碼" CssClass="btn btn-primary" onclick="Button2_Click" />
                                </div>
                            </div>
                        </form>
                    </div>
                </div>
            </section>
        </div>
        <!-- / main ================================================== -->
        <div pload="footer.html"></div>        
    </div>
</body>

</html>

