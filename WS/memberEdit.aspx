<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberEdit.aspx.cs" Inherits="memberEdit" %>
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

    <script src="js/register.js"></script>
    <script language="javascript">
        $(function () {

         $("table.radio-group label").addClass("radio-inline");

         var selectObj = document.form1.year2;
         for (var i = 0; i < selectObj.length; i++) {
             if (selectObj[i].value == $("#hide_year2").val())
                 selectObj[i].selected = true;
             else
                 selectObj[i].selected = false;
         }

         if (selectObj.value == "") {
             selectObj[0].selected = true;
         }

         selectObj = document.form1.month2;
         for (var i = 0; i < selectObj.length; i++) {
             if (selectObj[i].text == $("#hide_month2").val())
                 selectObj[i].selected = true;
             else
                 selectObj[i].selected = false;
         }

         if (selectObj.value == "") {
             selectObj[0].selected = true;
         }

         selectObj = document.form1.day2;
         for (var i = 0; i < selectObj.length; i++) {
             if (selectObj[i].text == $("#hide_day2").val())
                 selectObj[i].selected = true;
             else
                 selectObj[i].selected = false;
         }

         if (selectObj.value == "") {
             selectObj[0].selected = true;
         }

     });
</script>   
    
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
<input id="hide_year2" name="hide_year2" type="hidden" value="" runat="server" />
<input id="hide_month2" name="hide_month2" type="hidden" value="" runat="server" />
<input id="hide_day2" name="hide_day2" type="hidden" value="" runat="server" />
                


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
        <div id="main" class="page-memberJoin lineBk">
            <section class="section box1">
                <div class="container sm">
                
                
                
            
                
                    <div class="hd">
                        <h2 class="title wow fadeInDown">修改會員資料</h2>
                    </div>
                    <div class="info clear">
                        <form id="Form1" class="form" runat=server>
                            <div class="form-group row">
                                <div class="inline w40">
                                    <label for="name" class="col-sm-2 control-label">姓名：</label>
                                    <div class="col-sm-2">
                                        <%--<input type="text" class="form-control" id="text">--%>
                                        <asp:TextBox ID="name" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                    </div>
                                </div>
                                    <label for="name" class="col-sm-1 control-label">暱稱： </label>
                                    <div class="col-sm-2 no">
                                        <%--<input type="text" class="form-control w70" id="text">--%>
                                        <asp:TextBox ID="nickname" runat="server" CssClass="form-control w70" MaxLength="20"></asp:TextBox>
                                    </div>
                                    <label for="sex" class="col-sm-1 control-label">性別：</label>
                                    
                                        <%--<label class="radio-inline">
                                            <input type="radio" name="inlineRadioOptions" id="sex1" value="1"> 男
                                        </label>
                                        <label class="radio-inline">
                                            <input type="radio" name="inlineRadioOptions" id="sex2" value="2"> 女
                                        </label>--%>
                                        <asp:Panel ID="Panel1" runat="server" Height="20px" >
                                        <asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" RepeatDirection="Horizontal"   CssClass="radio-group">
                                        <asp:ListItem Value="man">男
                                        </asp:ListItem>
                                        <asp:ListItem Value="woman">女
                                        </asp:ListItem>
                                        </asp:RadioButtonList>
                                        </asp:Panel>
                            </div>
                            <div class="form-group row">
                                <label for="mail" class="col-sm-2 control-label">e-mail 帳號：</label>
                                <div class="col-sm-4">
                                    <%--<input type="text" class="form-control w40" id="mail"> --%>
                                    <asp:TextBox ID="email" runat="server" CssClass="form-control w40" MaxLength="80" ></asp:TextBox>
                                </div>
							    <div class="col-sm-6">
								    <span class="note">點選email信箱確認信函後,帳號即可啟用</span>
							    </div>
                            </div>
                            <%--<div class="form-group">
                                <label for="store" class="label">生日：</label>
                                <div class="col">
                                    <select id="disabledSelect" class="form-control w20">
                                        <option>年</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>月</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>日</option>
                                    </select>
                                </div>
                            </div>--%>
                            <div class="form-group row">
                                <label for="store" class="col-sm-2 control-label">結婚紀念日：</label>
                                    <%--<select id="disabledSelect" class="form-control w20">
                                        <option>年</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>月</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>日</option>
                                    </select>--%>
                                <div class="col-sm-2">
                                    <asp:DropDownList ID="year2" runat="server" CssClass="form-control">
                                      <asp:ListItem Value="">年</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-sm-2">
                                    <asp:DropDownList ID="month2" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="">月</asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <div class="col-sm-2">
                                    <asp:DropDownList ID="day2" runat="server" CssClass="form-control">
                                        <asp:ListItem Value="">日</asp:ListItem>
                                    </asp:DropDownList>
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
                                    <%--<input type="text" class="form-control w50" id="phone">--%>
                                    <asp:TextBox ID="mobile" runat="server" CssClass="form-control w50" MaxLength="10" ></asp:TextBox>
                                </div>
                                <div class="col-sm-2">
                                    <span class="note">例如 : 0910123456</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="tel" class="col-sm-2 control-label">市話：</label>
                                <div class="col-sm-1">
                                    <%--<input type="text" class="form-control" id="tel1" pattern="[0-9]" size="3"> ---%>
                                    <asp:TextBox ID="phone1" runat="server" MaxLength="3" size="5" onkeyup="this.value=this.value.replace(/[^\d]/g,'')" 
                                    placeholder="區碼" CssClass="form-control"></asp:TextBox>
							    </div>
							    <div class="col-sm-1">-</div>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control" id="tel2" pattern="[0-9]" size="10"> #--%>
                                    <asp:TextBox ID="phone2" runat="server" MaxLength="8" size="12" onkeyup="this.value=this.value.replace(/[^\d]/g,'')" CssClass="form-control"></asp:TextBox>
							    </div>
							    <div class="col-sm-1">#</div>
							    <div class="col-sm-1">
                                    <%--<input type="text" class="form-control" id="tel3" size="5">--%>
                                    <asp:TextBox ID="phone3" runat="server" MaxLength="5" size="5" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                                     placeholder="分機" CssClass="form-control"></asp:TextBox>
							    </div>
							    <div class="col-sm-4">                                    
                                    <span class="note">例如 : (02) 12345678#123</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="addr" class="col-sm-2 control-label">地址</label>
                                <div class="col-sm-2">    
                                    <%--<select id="disabledSelect" class="form-control w15">
                                        <option>縣市別</option>
                                    </select>--%>
                                
                                    <select id="city" name="city"  onChange="get_zipcode(this.value);" class="form-control">
                                      <option value="">縣市別</option>
                                      <asp:Literal ID="LiteCity" runat="server"></asp:Literal>
                                    </select>
                                </div>      
                                <div class="col-sm-2">       
                                    <%--<select id="disabledSelect" class="form-control w15">
                                        <option>行政區</option>
                                    </select>--%>
                                    <select id="zipcode" name="zipcode" class="form-control w15">
                                      <option value="">行政區</option>
                                      <asp:Literal ID="LiteZipcode" runat="server"></asp:Literal>
                                    </select>
                                </div>
                                <div class="col-sm-5">   
                                    <%--<input type="text" class="form-control w70" id="addr">--%>
                                    <asp:TextBox ID="address" runat="server" CssClass="form-control w70" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="password" class="col-sm-2 control-label">輸入密碼：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w40" id="password"> --%>
                                    <asp:TextBox ID="pwd" runat="server" CssClass="form-control w40" MaxLength="8" 
                                    TextMode="Password"></asp:TextBox>
                                    
                                </div>
                                <div class="col-sm-2">
                                    <span class="note">4 - 8 個字元</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="password2" class="col-sm-2 control-label">確認密碼：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w40" id="password2">--%>
                                    <asp:TextBox ID="chk_pwd" runat="server" CssClass="form-control w40" MaxLength="8"
                                     TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <hr class="line">
                            <div class="form-group row">
                                    <label for="q4" class="col-sm-3 control-label">願意收到王品優惠：</label>
                                    <div class="col-sm-2">
                                        <%--<label class="radio-inline">
                                            <input type="radio" name="inlineRadioOptions" id="q4-1" value="1">
                                        </label>
                                        <label class="radio-inline">
                                            <input type="radio" name="inlineRadioOptions" id="q4-2" value="2">
                                        </label>--%>
                                        <asp:RadioButtonList ID="Career" runat="server" RepeatDirection="Horizontal"   CssClass="radio-group">
                                        <asp:ListItem Value="Career_yes">是
                                        </asp:ListItem>
                                        <asp:ListItem Value="Career_no">否
                                        </asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                            </div>
                            <div class="form-group row">
                                    <label for="q5" class="col-sm-3 control-label">願意收到本公司所有餐廳優惠：</label>
                                    <div class="col-sm-2">
                                        <%--<label class="radio-inline">
                                            <input type="radio" name="inlineRadioOptions" id="q5-1" value="1"> 是
                                        </label>
                                        <label class="radio-inline">
                                            <input type="radio" name="inlineRadioOptions" id="q5-2" value="2"> 否
                                        </label>--%>
                                        <asp:RadioButtonList ID="Company" runat="server" RepeatDirection="Horizontal"   CssClass="radio-group">
                                        <asp:ListItem Value="Company_yes">是
                                        </asp:ListItem>
                                        <asp:ListItem Value="Company_no">否
                                        </asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                            </div>
						    <div class="form-group row">
							    <div class="col-sm-12">
                                    <div class="btnwp">
                                        <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                        <asp:Button ID="Button1" runat="server" Text="確定送出" CssClass="btn btn-primary" 
                                           onclick="Button1_Click" />
                                    </div>
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
