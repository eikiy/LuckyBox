<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_forget.aspx.cs" Inherits="member_forget" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">



<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<title>hot7會員</title>
<link href="member/css/style.css" rel="stylesheet" type="text/css">
<script src="member/js/jquery.min.js"></script>
<script src="member/js/jquery.placeholder.js"></script>
<script>
	// $.fn.hide = function() { return this; }
	$(function() {
		$('input, textarea').placeholder({customClass:'placeholder'});
	});
</script>

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>



</head>
<body>
 <form id="form1" runat="server">
<div class="head">
  <div class="logo"><a href="index.html"><img src="member/img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe81b;</i>忘記密碼</h4></td>
        </tr>
      </tbody>
    </table>
    <br>
    <table border="0" cellspacing="0" cellpadding="0" class="tbl">
      <tbody>
        <tr>
          <td><p class="tx_oops">&nbsp;</p></td>
        </tr>
        <tr>
          <td>
              <div class="flt_l form_tx">
              <i class="demo-icon c_or">&#xe846;</i>e-mail 帳號</div>
              
              <div class="form_span flt_r">
              <i class="demo-icon input_icon">&#xe82d;</i>
              <%--<input type="text" class="input_field">--%>
              <asp:TextBox ID="txtEmail" runat="server" CssClass="input_field" 
               MaxLength="80"></asp:TextBox></div>
          </td>
        </tr>
        
        <tr>
          <td><div class="flt_l form_tx">
              <i class="demo-icon c_or">&#xe846;</i>驗證碼</div>
              <div class="flt_l form_tx"> (請輸入圖片中文字，不分大小寫)</div>
          </td>
        </tr>
        
        <tr>
          <td>
          
          
          <%--認證碼欄位/更換圖片--%>
          <div class="flt_l">
          <%--<input type="text" size="15"> --%>
          <asp:TextBox ID="code" runat="server" CssClass="member_inputtxt" MaxLength="5" Width="70px"></asp:TextBox>
          <br>
          <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();" >更換別組圖示</a>
          </div>
          
          <%--認證碼圖片--%>
          <div class="flt_l form_tx">
          <%--<img src="m/images/code/check_bg8.gif" width="120" height="50" id="checkcode"/> --%>
          <iframe name="imgcode" id="imgcode" src="member/img/code.aspx"  scrolling="no" frameborder="0">
          </iframe></div>
          
          
          </td>
        </tr>

        <tr>
          <td>
          <%--<input type="button" name="button" class="butn input_field" value="重設密碼">--%>
              <asp:Button ID="Button1" runat="server" Text="重設密碼" CssClass="butn input_field" 
                  onclick="Button1_Click" />
          
          </td>
        </tr>
      </tbody>
  </table>
  </div>
  <div class="regbox_b" align="center">
    <div class="navbox2"><a href="member_join.aspx"> 註冊新帳號</a></div>
    <div class="navbox2"><a href="member_forget.aspx">忘記密碼</a></div>
    <div class="navbox2"><a href="member_reissue.aspx">補發確認信</a></div>
  </div>
</div>
</form>
</body>



</html>

