<%@ Page Language="C#" AutoEventWireup="true" CodeFile="cancel.aspx.cs" Inherits="cancel" %>

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
                <div class="container xs">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">取消訂閱eDM</h2>
                    </div>
                    <div class="info clear">
                        <form id="Form2" class="form" runat=server >
                            <div class="form-group row">
                                <label for="txtEmail" class="col-sm-2 col-sm-offset-4 control-label">e-mail帳號:</label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control w100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="txtPwd" class="col-sm-2 col-sm-offset-4 control-label">密碼: </label>
                                <div class="col-sm-3">
                                    <asp:TextBox ID="txtPwd" runat="server" MaxLength="8" TextMode="Password" placeholder="4 - 8 個字元" CssClass="form-control w100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="code" class="col-sm-2 col-sm-offset-4 control-label">驗證碼: </label>
                                <div class="col-sm-3">
                                	<asp:TextBox ID="code" runat="server" CssClass="form-control w20" MaxLength="5"></asp:TextBox>
                                	<iframe name="imgcode" id="imgcode" src="img/code.aspx" width="120" height="50" scrolling="no" frameborder="0"></iframe>
                                	<span class="ch">
                                   		<a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();">&nbsp;更換別組圖示</a> (請輸入驗證碼，不分大小寫)
                                    </span>
                                </div>
                            </div>
                            <div class="form-group row">
                            	<div class="btnwp">
                            		<a href="memberForget.aspx">忘記密碼</a>：如果您忘記密碼， 請提供 e - mail 帳號，我們將以電子郵件的方式告知
                            	</div>
                            </div>
                            <div class="form-group row">
                                <div class="btnwp">
                                    <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                    <asp:Button ID="Button1" runat="server" Text="確認送出" CssClass="btn btn-primary" onclick="Button1_Click" />
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
