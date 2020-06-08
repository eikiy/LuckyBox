<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_reset_pw.aspx.cs" Inherits="member_reset_pw" %>
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
        <div id="main" class="page-memberForgetReset lineBk">
            <section class="section box1">
                <div class="container xs">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">重設密碼</h2>
                        <p class="wow fadeInUp">請填寫下方欄位完成密碼更換動作。</p>
                    </div>
                    <div class="info clear">
                        <form id="Form1" class="form" runat=server>
                            <div class="form-group row">
                                <label for="account" class="col-sm-2 col-sm-offset-4 control-label">新密碼</label>
                                <div class="col-sm-3">
                                   <%-- <input type="text" class="form-control w60" id="account"><span class="note">4 - 8 個字元</span>--%>
                                   <asp:TextBox ID="pwd" runat="server" CssClass="form-control w60" MaxLength="8" 
                                     TextMode="Password"  placeholder="4 - 8 個字元"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="newpassword" class="col-sm-2 col-sm-offset-4 control-label">再輸入一次新密碼</label>
                                <div class="col-sm-3">
                                    <%--<input type="text" class="form-control w60" id="newpassword"><span class="note">4 - 8 個字元</span>--%>
                                    <asp:TextBox ID="chk_pwd" runat="server" CssClass="form-control w60" 
                                    MaxLength="8" TextMode="Password" placeholder="4 - 8 個字元"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="btnwp">
                                    <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                    <asp:Button ID="Button1" runat="server" Text="確定更換密碼"  
                                     CssClass="btn btn-primary" onclick="Button1_Click" />
          
                                      <asp:HiddenField ID="hidfFid" runat="server" />
                                      <asp:HiddenField ID="hidUid" runat="server" />
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
