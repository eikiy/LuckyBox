<%@ Page Language="C#" AutoEventWireup="true" CodeFile="survey_login.aspx.cs" Inherits="survey_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<title>hot7</title>
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
    (function(i, s, o, g, r, a, m) {
        i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function() {
            (i[r].q = i[r].q || []).push(arguments)
        }, i[r].l = 1 * new Date(); a = s.createElement(o),
  m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
    })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

    ga('create', 'UA-70997142-1', 'auto');
    ga('send', 'pageview');

</script>


</head>
<body>
<form id="form2" runat="server">
<div class="head">
  <div class="logo"><a href="index.html"><img src="member/img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line">
          <h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe819;</i>參加抽獎登入會員</h4></td>
        </tr>
        <tr>
          <td><div class="flt_r form_tx"><a href="survey_nonlog.aspx"><i class="demo-icon c_or">&#xe812;</i>不參加抽獎送出問卷</a></div></td>
        </tr>
      </tbody>
    </table>
    <table border="0" cellspacing="0" cellpadding="0" class="tbl">
      <tbody>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>e-mail帳號</div>
            <div class="form_span flt_r">
            <i class="demo-icon input_icon">&#xe82d;</i>
            <%--<input type="text" class="input_field">--%>
            <input name="txtEmail2" type="text" class="input_field" id="txtEmail2" runat="server">
            
            </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>密 碼</div>
          <div class="form_span flt_r">
          <i class="demo-icon input_icon">&#xe81b;</i>
         <%-- <input type="text" class="input_field">--%>
          <input name="txtPwd" type="password" MaxLength="8" placeholder="4 - 8 個字元" class="input_field" id="txtPwd" runat="server">
          
          </div></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
          <%--<input type="button" name="button" class="butn input_field form_tx" value="送出問卷 抽獎GO" onclick="location.href='survey_ok.html'">--%>
          <asp:Button ID="Button1" runat="server" Text="送出問卷 抽獎GO" 
                  CssClass="butn input_field form_tx" onclick="Button1_Click" />
          <asp:Label ID="lbl115_SC_IQType" runat="server" Visible="False"></asp:Label>
          </td>
        </tr>
      </tbody>
  </table>
  </div><div class="regbox_b" align="center">
    <div class="navbox2"><a href="member_join.aspx"> 註冊新帳號</a></div>
  <div class="navbox2"><a href="member_forget.aspx">忘記密碼</a></div>
  <div class="navbox2"><a href="member_reissue.aspx">補發確認信</a></div>
  </div>
</div>
</form>
</body>
    </html>


