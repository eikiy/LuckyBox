<%@ Page Language="C#" AutoEventWireup="true" CodeFile="food.aspx.cs" Inherits="food" %>

<!DOCTYPE html>
<html lang="zh-TW" xml:lang="zh-TW">
<head>

<!-- Global site tag (gtag.js) - Google Analytics -->
<script async src="https://www.googletagmanager.com/gtag/js?id=UA-119765785-1"></script>
<script>
  window.dataLayer = window.dataLayer || [];
  function gtag(){dataLayer.push(arguments);}
  gtag('js', new Date());

  gtag('config', 'UA-119765785-1');
</script>


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
    #header .nav .main-nav>li>a {
	    color: #444 !important;
    }
    </style>

    <script>
        $(function () {
            $("table.radio-group label").addClass("radio-inline");
        })
    </script>
</head>

<body>
    <div class="wp page">
		<header id="header">
			<div pload="pmenu_1.html"></div>

			<div class="banner">
				<div class="slogo wow fadeIn center">
					<h1 class="title-en">
						<div>Board</div>
					</h1>
				</div>
				<div class="bannerimg" data-focus-x="0" data-focus-y="0" style="background-image: url(styles/images/food-banner.jpg)"></div>
			</div>
		</header>
        <!--main ================================================== -->
        <div id="main" class="page-food lineBk">
            <section class="section box1">
                <div class="container sm">
                    <div class="hd">
                        <h2 class="title wow fadeInDown">美食漫談</h2>
                        <p class="wow fadeInUp"><strong>親愛的顧客您好：<br>                       
                      
                        <strong>感謝您分享寶貴的意見，我們將儘快與您聯繫，謝謝！</strong>
                        <p class="wow fadeInUp">請填寫正確聯絡資訊，我們將儘快與您連繫 </p>
													
                    </div>
                    <div class="info clear">
                        <form class="form" runat=server>
                            <div class="form-group row">
                                <label for="name" class="col-sm-2 control-label">姓名：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control" id="text">--%>
                                    <asp:TextBox ID="name" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                                <label for="sex" class="col-sm-2 control-label">性別：</label>
                                <div class="col-sm-2">
                                    <%--<label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" id="sex1" value="1"> 男
                                    </label>
                                    <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" id="sex2" value="2"> 女
                                    </label>--%>

                                    <asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" 
                                        RepeatDirection="Horizontal" CssClass="radio-group">
                                    <asp:ListItem Value="man" Selected=True>男
                                    </asp:ListItem>
                                    <asp:ListItem Value="woman">女
                                    </asp:ListItem>
                                    </asp:RadioButtonList>
   
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="mail" class="col-sm-2 control-label">e-mail 帳號：</label>
                                <div class="col-sm-4">
                                    <%--<input type="text" class="form-control w70" id="mail">--%>
                                    <asp:TextBox ID="email" runat="server" CssClass="form-control w70" MaxLength="80"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-12">
                                    <p class="note">聯絡電話　(手機、電話二擇一填寫)</p>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="phone" class="col-sm-2 control-label">手機：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w50" id="phone"><span class="note">例如 : 0910123456</span>--%>
                                    <asp:TextBox ID="mobile" runat="server" CssClass="form-control w50"  MaxLength="10"></asp:TextBox>
                                </div>
                                <div class="col-sm-4">
                                    <span class="note">例如 : 0910123456</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="tel" class="col-sm-2 control-label">市話：</label>
                                <div class="col-sm-4">
                                    <div class="input-group">
                                    <%--<input type="text" class="form-control" id="tel1" pattern="[0-9]" size="3"> ---%>
                                    <asp:TextBox ID="phone1" runat="server" MaxLength="3" size="5" onkeyup="this.value=this.value.replace(/[^\d]/g,'')" CssClass="form-control" placeholder="區碼"></asp:TextBox>
                                    <span class="input-group-addon" id="basic-addon3">-</span>
                                    <%--<input type="text" class="form-control" id="tel2" pattern="[0-9]" size="10"> #--%>
                                    <asp:TextBox ID="phone2" runat="server" MaxLength="8" size="12"  onkeyup="this.value=this.value.replace(/[^\d]/g,'')" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-addon" id="Span1">#</span>
                                    <%--<input type="text" class="form-control" id="tel3" size="5"><span class="note">例如 : (02) 12345678#123</span>--%>
                                    <asp:TextBox ID="phone3" runat="server" MaxLength="5" size="5" onkeyup="this.value=this.value.replace(/[^\d]/g,'')" CssClass="form-control" placeholder="分機"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4"><span class="note">例如 : (02) 12345678#123</span></div>
                            </div>
                            <div class="form-group row">
                                <label for="store" class="col-sm-2 control-label">店別：</label>
                                <div class="col-sm-2">
                                    <%--<select id="disabledSelect" class="form-control">
                                        <option>請選擇</option>
                                    </select>--%>
                                    <asp:DropDownList ID="store" runat="server" CssClass="form-control">
                                    </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="title" class="col-sm-2 control-label">主題：</label>
                                <div class="col-sm-8">
                                    <%--<input type="text" class="form-control w80" id="title">--%>
                                    <asp:TextBox ID="subject" runat="server" CssClass="form-control w80" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="info" class="col-sm-2 control-label">內容：</label>
                                <div class="col-sm-8">
                                    <%--<textarea rows="8" cols="20" class="form-control w80"></textarea>--%>
                                    <asp:TextBox ID="content" runat="server" Columns="40" CssClass="form-control w80" 
                                     Rows="5" TextMode="MultiLine"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-12">
                                    <div class="btnwp">
                                        <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                        <asp:Button ID="Button1" runat="server"  class="btn btn-primary" text="確定送出" 
                                        onclick="Button1_Click" />
                                    </div>
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
