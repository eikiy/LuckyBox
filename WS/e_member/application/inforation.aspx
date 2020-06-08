<%@ Page Language="C#" AutoEventWireup="true" CodeFile="inforation.aspx.cs" Inherits="e_member_application_inforation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<meta charset="utf-8">
<title>王品菁英獻禮</title>


<meta name="description" content="王品-只款待心中最重要的人">
<meta name="keywords" content="王品,牛排,菁英獻禮">
<meta property="og:title" content="王品菁英獻禮"/>
<meta property="og:description" content="王品-只款待心中最重要的人" />
<meta property="og:type" content="website" />

<!--手機解析度-->
<meta name="viewport" content="width=device-width, initial-scale=1.0">


<!--favor icon-->
<link rel="shortcut icon" href="../images/touch-icon/touch-icon-iphone.png" />


<!--touch_icon-->
<link rel="apple-touch-icon" href="../images/touch-icon/touch-icon-iphone.png" /> 
<link rel="apple-touch-icon" sizes="76x76" href="../images/touch-icon/touch-icon-ipad.png" /> 
<link rel="apple-touch-icon" sizes="120x120" href="../images/touch-icon/touch-icon-iphone-retina.png" />
<link rel="apple-touch-icon" sizes="152x152" href="../images/touch-icon/touch-icon-ipad-retina.png" />
<style type="text/css">
@import url("../css/reset.css");
</style>
<link href="../css/master.css" rel="stylesheet" type="text/css">
<!-- IE Fix for HTML5 Tags -->
<!--[if lt IE 9]>
<script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
<![endif]-->

<link rel="stylesheet" href="../css/font-awesome-4.6.1/css/font-awesome.min.css">

<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.2/jquery.min.js"></script>

<style>
@font-face {
/*明體*/
  font-family: 'cwTeXMing';
  font-style: normal;
  font-weight: 500;
  src: url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.eot);
  src: url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.eot?#iefix) format('embedded-opentype'),
       url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.woff2) format('woff2'),
       url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.woff) format('woff'),
       url(//fonts.gstatic.com/ea/cwtexming/v3/cwTeXMing-zhonly.ttf) format('truetype');
}

.form .bbtn
{
	border:1px solid #eea1a1;
	color:#eea1a1;
	padding:7px 25px;
	-webkit-transition:all .2s;
	transition:all .2s;
	text-decoration:none;
	background-color:#FFFFFF;

}


.form .bbtn:hover
{
	background-color:#eea1a1;
	color:#fff
}
</style>

<script src="scripts/default/modernizr.js"></script>
<script src="js/register.js"></script>
<link href="../css/application.css" rel="stylesheet" type="text/css">
</head>

<body>



<input id="hide_year2" name="hide_year2" type="hidden" value="" runat="server" />
<input id="hide_month2" name="hide_month2" type="hidden" value="" runat="server" />
<input id="hide_day2" name="hide_day2" type="hidden" value="" runat="server" />



<form id="Form1" class="form" runat=server>

<div class="mainBox">


<header class="clearfix">
<div class="wrap">
<h1 class="logo"><a href="http://www.wangsteak.com.tw/" target="_blank">王品-只款待心中最重要的人</a></h1>
<a class="m-menu"><i class="fa fa-bars" aria-hidden="true"></i></a>




<nav class="open"><div class="m-menubox">
<a class="m-menu-close"><i class="fa fa-times" aria-hidden="true"></i></a>
<ul class="submenu"><a href="../index.htm"><i class="fa fa-home" aria-hidden="true"></i>活動首頁</a></ul>
<ul class="menu">
<li class="application"><a href="../application/index.aspx">申請電子菁英禮讚</a></li>
<li class="coupon"><a href="../coupon/index.aspx">領取電子優惠</a></li>
<li class="preferential"><a href="../preferential/index.htm">菁英年度好康優惠</a></li>
<li class="faq"><a href="../faq/index.htm">常見問題</a></li>
</ul><!--menu-->
</div><!--m-menubox--></nav>




</div><!--wrap-->
</header>





<div class="mainArea">

<div class="containerBox"><div class="wrap">
<h2>會員基本資料</h2>
<div style="text-align:center;">
  <p>歡迎您申請電子菁英禮讚，為避免影響您個人權利，請重新確認並填入正確會員資料，以利領取電子優惠券。</p>
  <p>成為電子菁英會員，恕不再寄發紙本優惠券，E起環保愛地球。</p>
</div>

<table class="inforationBox">
	<tr>
    	<td colspan="2">標示<span style="color:#e60021;">※</span>字為必填欄位</td>
    </tr>
    <tr>
    	<td  colspan="2" style="border-top:#ccc 1px solid; height:20px;"></td>
    </tr>
    <tr>
    	<td><b class="mandatory">姓　　名</b></td>
        <td><%--<input type="text">--%><asp:TextBox ID="name" runat="server"  MaxLength="20"></asp:TextBox></td>
    </tr>
    <tr>
    	<td><b class="mandatory">姓　　別</b></td>
        <td><%--<input type="text">--%><asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="M">男</asp:ListItem>
                <asp:ListItem Value="F">女</asp:ListItem>
                </asp:RadioButtonList></td>
    </tr>
    <tr>
    	<td><b class="mandatory">生　　日</b></td>
        <td><%--<input type="text">--%><asp:TextBox ID="birthday" runat="server"  MaxLength="20"></asp:TextBox>
        <span style="color:#888;">ex:2016/01/01</span></td>
    </tr>
    <tr>
    	<td><b class="mandatory">手　　機</b></td>
        <td><%--<input type="text">--%><asp:TextBox ID="mobile" runat="server"  MaxLength="10"></asp:TextBox><span style="color:#888;">ex:0900111222</span></td>
    </tr>
    <tr>
    	<td><b class="mandatory">詳細地址</b></td>
        <td><%--<select>
                                <option value="" selected="selected">請選擇縣市</option>
                                <option value="彰化縣">彰化縣</option>
                                </select>--%>
                                      <select id="city" name="city" onChange="get_zipcode(this.value);">
                                      <option value="">縣市別</option>
                                      <asp:Literal ID="LiteCity" runat="server"></asp:Literal>
                                      </select>
                                      
                                      
                                <%--<select>
                                <option value="" selected="selected">請選擇鄉鎮</option>
                                <option value="彰化市">彰化市</option>
                                </select>--%>
                                      <select id="zipcode" name="zipcode"  onChange="get_street(this.value);">
                                      <option value="">行政區</option>
                                      <asp:Literal ID="LiteZipcode" runat="server"></asp:Literal>
                                      </select>
                                      
                                      
                                      <select id="street" name="street">
                                      <option value="">街道/路名</option>
                                      <asp:Literal ID="LitersSreet" runat="server"></asp:Literal>
                                      </select>
                                      
                                <%--<input type="text" class="addess">--%>
                                <asp:TextBox ID="address" runat="server"  MaxLength="100"></asp:TextBox><span style="color:#888;">請再次確認個人聯絡地址，並全部重新選取至適合欄位。</span></td>
    </tr>
    <asp:Panel ID="Panelemail" runat="server">
    <tr>
    	<td><b class="mandatory">eMail</b></td>
        <td><asp:TextBox ID="email" runat="server"></asp:TextBox></td>
    </tr>
     </asp:Panel>
     <tr>
    	<td><b >&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;結婚紀念日</b></td>
        <td><%--<input type="text">--%>
        
        <asp:DropDownList ID="year2" runat="server">
        <asp:ListItem Value="">年</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="month2" runat="server">
        <asp:ListItem Value="">月</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="day2" runat="server">
        <asp:ListItem Value="">日</asp:ListItem>
        </asp:DropDownList>
        
        <%--<asp:TextBox ID="marryday" runat="server"  MaxLength="20"></asp:TextBox><span style="color:#888;">ex:2016/01/01</span>--%>
        
        
        </td>
  
    </tr> 
    <asp:Panel ID="Panelpwd" runat="server">
    <tr>
    	<td><b class="mandatory">密　　碼</b></td>
        <td><%--<input type="text" autocomplete="off">--%><asp:TextBox ID="pwd" runat="server"  MaxLength="8"></asp:TextBox><span style="color:#888;">4 - 8 個字元</span></td>
    </tr> 
    </asp:Panel>
    <tr>
    	<td><b class="mandatory">驗證碼</b></td>
        <td><%--<input type="text" placeholder="請在此輸入驗證碼，不分大小寫">--%>
<input id="txtCode" runat="server" maxlength="5" name="txtCode" size="10" type="text" />
<div>
    <%--<img src="../images/code.jpg" alt=""/><a href="#">←點此更換左側圖式</a>--%>
    <iframe id="imgcode"  scrolling="no" frameborder="0" src="../../img/code.aspx" width="120" height="50" ></iframe>
    <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();" class="R_title">←更換別組圖示</a>
</div>

</td>
    </tr> 
</table>

<!--<ul class="inforationBox">
<p>標示<span style="color:#e60021;">※</span>字為必填欄位</p>

<li><b class="mandatory">姓　　名</b></li>
<li><b class="mandatory">姓　　別</b></li>
<li><b class="mandatory">生　　日</b></li>
<li><b class="mandatory">手　　機</b></li>
<li><b class="mandatory">詳細地址</b></li>
<li></li>    
<li><b>結婚紀念日</b></li>
</li><li>
<b></b>                                   
</li>  
<li><b></b></li>
</ul>-->

<div style="text-align:center;">請確認並填入會員資料，以利領取電子優惠券</div>

<div style="padding-top:30px; width:116px; margin:0 auto;">
 
<%--<a href="success.htm" class="btn"><span>確認送出</span></a>--%>
<asp:LinkButton ID="LinkButton1" runat="server" Text=確認送出 CssClass="bbtn" 
        onclick="LinkButton1_Click"></asp:LinkButton>
</div>



</div><!--wrap--></div><!--containerBox-->



</div><!--mainArea-->




</div><!--mainBox-->


<footer class="copyright">王品牛排 © Wang Steak. All rights reserved.</footer>


<script type="text/javascript">

$('.m-menu').click(function(){
	$("nav").stop(false, true).removeClass("open");
});


$('.m-menu-close').click(function(){
	$("nav").stop(false, true).addClass("open");
});



</script>
</form>
</body>
</html>
