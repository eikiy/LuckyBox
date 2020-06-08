<%@ Page Language="C#" AutoEventWireup="true" CodeFile="memberJoin.aspx.cs" Inherits="memberJoin" %>

<!DOCTYPE html>
<html lang="zh-TW" xml:lang="zh-TW">
<head>
<meta http-equiv="refresh" content="0;url='https://www.wangsteak.com.tw/member/'" />

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
<script src="https://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="js/register.js"></script>   
<script>
    $(function () {
        $("table.radio-group label").addClass("radio-inline");
    })
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
                        <h2 class="title wow fadeInDown">加入會員</h2>
                        <p class="wow fadeInUp">即刻成為王品網路會員，不定期接收為您準備的貼心驚喜與優惠資訊</p>
                        <p class="wow fadeInUp">獨享會員專屬優惠券下載〈 生日禮、結婚紀念禮等〉。</p>
                        <p class="wow fadeInUp"><span class="red">※</span> 為必填</p>
                    </div>
                    <div class="info clear">
                        <form class="form" runat="server"  action="memberJoin.aspx" onsubmit="return checkdata();" method="post">
                            <div class="form-group row">
                                <label for="name" class="col-sm-2 control-label"><span class="red">※</span> 姓名：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control" id="text">--%>
                                    <asp:TextBox ID="name" runat="server" CssClass="form-control" MaxLength="20"></asp:TextBox>
                                </div>
                                <label for="name" class="col-sm-1 control-label">暱稱： </label>
                                <div class="col-sm-2">
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
                                <div class="col-sm-2">
                                <asp:Panel ID="Panel1" runat="server" Height="20px" >
                                            <asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" RepeatDirection="Horizontal"  CssClass="radio-group">
                                            <asp:ListItem Value="man" Selected=True> 男
                                            </asp:ListItem>
                                            <asp:ListItem Value="woman"> 女
                                            </asp:ListItem>
                                            </asp:RadioButtonList>
                                </asp:Panel>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="mail" class="col-sm-2 control-label"><span class="red">※</span> e-mail 帳號：</label>
                                <div class="col-sm-4">
                                    <%--<input type="text" class="form-control w40" id="mail"> --%>
                                    <asp:TextBox ID="email" runat="server" CssClass="form-control w40" 
                                    onblur="checkuser();"></asp:TextBox>
                                </div>
                                <div class="col-sm-4">
                                    <span class="note">點選email信箱可啟動帳號 (不可修改)</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="store" class="col-sm-2 control-label"><span class="red">※</span> 生日：</label>
                                <div class="col-sm-10">
                                    <div class="input-group col-sm-6">
                                    <%--<select id="disabledSelect" class="form-control w20">
                                        <option>年</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>月</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>日</option>
                                    </select>--%>
                                    <asp:DropDownList ID="year1" runat="server" CssClass="form-control w2">
                                      <asp:ListItem Value="">年</asp:ListItem>
                                  </asp:DropDownList>
                                  <span class="input-group-addon">/</span>                        
                                  <asp:DropDownList ID="month1" runat="server" CssClass="form-control w2">
                                       <asp:ListItem Value="">月</asp:ListItem>
                                   </asp:DropDownList>     
                                   <span class="input-group-addon">/</span>           
                                   <asp:DropDownList ID="day1" runat="server" CssClass="form-control w2">
                                       <asp:ListItem Value="">日</asp:ListItem>
                                   </asp:DropDownList>
                                   </div>
                                 </div>
                            </div>
                            <div class="form-group row">
                                <label for="store" class="col-sm-2 control-label">結婚紀念日：</label>
                                <div class="col-sm-10">
                                    <div class="input-group col-sm-6">
                                    <%--<select id="disabledSelect" class="form-control w20">
                                        <option>年</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>月</option>
                                    </select>
                                    <select id="disabledSelect" class="form-control w10">
                                        <option>日</option>
                                    </select>--%>
                                    <asp:DropDownList ID="year2" runat="server" CssClass="form-control w2">
                                          <asp:ListItem Value="">年</asp:ListItem>
                                      </asp:DropDownList> 
                                      <span class="input-group-addon">/</span>                
                                      <asp:DropDownList ID="month2" runat="server" CssClass="form-control w2">
                                           <asp:ListItem Value="">月</asp:ListItem>
                                       </asp:DropDownList>       
                                       <span class="input-group-addon">/</span>     
                                       <asp:DropDownList ID="day2" runat="server" CssClass="form-control w2">
                                           <asp:ListItem Value="">日</asp:ListItem>
                                       </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="phone" class="col-sm-2 control-label"><span class="red">※</span>手機：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w50" id="phone">--%>
                                    <asp:TextBox ID="mobile" runat="server" CssClass="form-control w50" MaxLength="10"></asp:TextBox>
                                </div>
                                <div class="col-sm-2">
                                    <span class="note">例如 : 0910123456</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="tel" class="col-sm-2 control-label">市話：</label>
                                <div class="col-sm-6">
                                    <div class="input-group">
                                    <%--<input type="text" class="form-control" id="tel1" pattern="[0-9]" size="3">--%> 
                                     <asp:TextBox ID="phone1" runat="server" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                                     placeholder="區碼" size="5" maxlength="3" CssClass="form-control"></asp:TextBox> 
                                    <span class="input-group-addon" id="basic-addon3">-</span>
                                    <%--<input type="text" class="form-control" id="tel2" pattern="[0-9]" size="10"> --%>
                                    <asp:TextBox ID="phone2" runat="server" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                                     size="12" maxlength="8" CssClass="form-control"></asp:TextBox>
                                    <span class="input-group-addon" id="Span1">#</span>
                                    <%--<input type="text" class="form-control" id="tel3" size="5">--%>
                                    <asp:TextBox ID="phone3" runat="server" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                                      placeholder="分機" size="5" maxlength="5" CssClass="form-control"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <span class="note">例如 : (02) 12345678#123</span>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="addr" class="col-sm-2 control-label"><span class="red">※</span> 地址</label>
                                <div class="col-sm-3">
                                    <div class="input-group">
                                    <%--<select id="disabledSelect" class="form-control w15">
                                        <option>縣市別</option>
                                    </select>--%>
                                   <select id="city" name="city" onChange="get_zipcode(this.value);" runat="server" class="form-control w15">
                                          <option value="">縣市別</option>
                                   </select>
                                   <span class="input-group-addon"></span>    
                                    <%--<select id="disabledSelect" class="form-control w15">
                                        <option>行政區</option>
                                    </select>--%>
                                     <select id="zipcode" name="zipcode" runat="server" class="form-control w15">
                                           <option value="">行政區</option>
                                      </select>
                                    </div>
                                </div>
                                <div class="col-sm-4">
                                    <%--<input type="text" class="form-control w70" id="addr">--%>
                                    <asp:TextBox ID="address" runat="server" CssClass="form-control w70" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="password" class="col-sm-2 control-label"><span class="red">※</span> 輸入密碼：</label>
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
                                <label for="password2" class="col-sm-2 control-label"><span class="red">※</span> 確認密碼：</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w40" id="password2">--%>
                                    <asp:TextBox ID="chk_pwd" runat="server" CssClass="form-control w40" 
                                    MaxLength="8" TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                            <hr class="line">
                            <div class="form-group row">
                                <div class="col-sm-2 col-sm-offset-2">
                                    <%--<select id="q1" class="form-control w20">
                                        <option>職業 </option>
                                    </select>--%>
                                    <asp:DropDownList ID="job" runat="server" CssClass="form-control w20">
                                        <asp:ListItem Value="">職業</asp:ListItem>
                                        <asp:ListItem value="1">企業負責人</asp:ListItem>
                                        <asp:ListItem value="2">中高階層主管</asp:ListItem>
                                        <asp:ListItem value="3">基層主管</asp:ListItem>
                                        <asp:ListItem value="4">一般職員</asp:ListItem>
                                        <asp:ListItem value="7">公教人員</asp:ListItem>
                                        <asp:ListItem value="10">家管</asp:ListItem>
                                        <asp:ListItem value="14">學生</asp:ListItem>
                                        <asp:ListItem value="18">其他</asp:ListItem>
                                      </asp:DropDownList>
                                 </div>   
                                 <div class="col-sm-2">   
                                    <%--<select id="q2" class="form-control w20">
                                        <option>教育程度</option>
                                    </select>--%>
                                    <asp:DropDownList ID="education" runat="server" CssClass="form-control w20">
                                          <asp:ListItem value="">教育程度</asp:ListItem>
	                                      <asp:ListItem value="14">國中以下</asp:ListItem>
                                          <asp:ListItem value="9">高中職</asp:ListItem>
                                          <asp:ListItem value="10">專科</asp:ListItem>
                                          <asp:ListItem value="11">大專院校</asp:ListItem>
                                          <asp:ListItem value="12">研究所</asp:ListItem>
                                          <asp:ListItem value="13">其他</asp:ListItem>
                                      </asp:DropDownList>
                                 </div>   
                                 <div class="col-sm-2">   
                                    <%--<select id="q3" class="form-control w20">
                                        <option>最常去的店</option>
                                    </select>--%>
                                    <select id="store" name="store" class="form-control w20" runat="server">
                                         <option value="">最常去的店</option>
                                      </select>
                                 </div>     
                                 <div class="col-sm-3">     
                                    <%--<select id="q4" class="form-control w40">
                                        <option>請問您半年內第幾次到王品用餐</option>
                                    </select>--%>
                                    <asp:DropDownList ID="times" runat="server" CssClass="form-control w40">
                                      <asp:ListItem value="">請問您半年內第幾次到王品用餐</asp:ListItem>
                                      <asp:ListItem value="0">無</asp:ListItem>
                                      <asp:ListItem value="1">1次</asp:ListItem>
                                      <asp:ListItem value="2">2次</asp:ListItem>
                                      <asp:ListItem value="3">3次</asp:ListItem>
                                      <asp:ListItem value="4">4次</asp:ListItem>
                                      <asp:ListItem value="5">5次</asp:ListItem>
                                      <asp:ListItem value="6">6次以上</asp:ListItem>
                                      </asp:DropDownList>
                                </div>
                            </div>
                            <div class="form-group row">
                                    <label for="q4" class="col-sm-3 control-label col-sm-offset-2" style="text-align:left;">願意收到王品優惠：</label>
                                    <%--<label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" id="q4-1" value="1"> 是
                                    </label>
                                    <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" id="q4-2" value="2"> 否
                                    </label>--%>
                                 <div class="col-sm-2">   
                                    <asp:RadioButtonList ID="Career" runat="server" RepeatDirection="Horizontal" CssClass="radio-group">
                                    <asp:ListItem Value="Career_yes">是
                                    </asp:ListItem>
                                    <asp:ListItem Value="Career_no">否
                                    </asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                            <div class="form-group row">
                                
                                    <label for="q5" class="col-sm-3 control-label col-sm-offset-2" style="text-align:left;">願意收到本公司所有餐廳優惠：</label>
                                    <%--<label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" id="q5-1" value="1"> 是
                                    </label>
                                    <label class="radio-inline">
                                        <input type="radio" name="inlineRadioOptions" id="q5-2" value="2"> 否
                                    </label>--%>
                                <div class="col-sm-2">     
                                    <asp:RadioButtonList ID="Company" runat="server" RepeatDirection="Horizontal"  CssClass="radio-group">
                                    <asp:ListItem Value="Company_yes">是
                                    </asp:ListItem>
                                    <asp:ListItem Value="Company_no">否
                                    </asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                            </div>
                            <hr class="line">
                            <div class="form-group row">
                                <label for="code" class="col-sm-2 control-label">驗證碼</label>
                                <div class="col-sm-2">
                                    <%--<input type="text" class="form-control w20" id="code">--%> 
                                    <asp:TextBox ID="code" runat="server" MaxLength="5" size="15" CssClass="form-control w20"></asp:TextBox>
                                

                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-2 col-sm-offset-2">
                                    <%--<img src="styles/images/code.png" alt="">--%>
                                    <iframe name="imgcode" id="imgcode" src="img/code.aspx"  scrolling="no" frameborder="0" width="150" height="50">
                                    </iframe>
                                </div>
                                <div class="col-sm-7">
                                    <%--<span class="ch"><button>更換別組圖示 </button> (請輸入驗證碼，不分大小寫)</span>--%>
                                    <span class="ch">
                                    <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();" class="chA">更換別組圖示</a>
                                     (請輸入驗證碼，不分大小寫)</span>
                                </div>
                            </div>

                            <div class="form-group row">
                                <div class="col-sm-12 col-sm-offset-2">
                                請詳細閱讀 <a href="privacyTerms.html" class="red">隱私權條款</a>
                                 <asp:CheckBox ID="rule" runat="server" /> 我已閱讀，充分了解並同意
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-12">
                                    <div class="btnwp">
                                        <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>
                                        <asp:Button ID="Button1" runat="server" Text="確定送出" CssClass="btn" 
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

