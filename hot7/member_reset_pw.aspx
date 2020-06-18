<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_reset_pw.aspx.cs" Inherits="member_reset_pw" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">




<head>
<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<title>hot7</title>
<link href="css/style.css" rel="stylesheet" type="text/css">
<script src="js/jquery.min.js"></script>
<script src="js/jquery.placeholder.js"></script>
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
  <div class="logo"><a href="../index.html"><img src="img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe81b;</i>更換密碼</h4></td>
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
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>新密碼</div>
            <div class="form_span flt_r">
<i class="demo-icon input_icon">&#xe81b;</i>
<%--<input type="text" class="input_field" placeholder="4 - 8 個字元" >--%>
<asp:TextBox ID="pwd" runat="server" CssClass="input_field" MaxLength="8" 
                          TextMode="Password"  placeholder="4 - 8 個字元"></asp:TextBox>

</div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>再輸入一次</div>
            <div class="form_span flt_r"> <i class="demo-icon input_icon">&#xe81b;</i>
              <%--<input type="text" class="input_field" placeholder="4 - 8 個字元">--%>
              <asp:TextBox ID="chk_pwd" runat="server" CssClass="input_field" 
                          MaxLength="8" TextMode="Password" placeholder="4 - 8 個字元"></asp:TextBox>
              
              
              
            </div></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
          <%--<input type="button" name="button" class="butn input_field" value="確定更換密碼">--%>
              <asp:Button ID="Button1" runat="server" Text="確定更換密碼"  
                  CssClass="butn input_field" onclick="Button1_Click" />
          
                      <asp:HiddenField ID="hidfFid" runat="server" />
                      <asp:HiddenField ID="hidUid" runat="server" />
          
          </td>
        </tr>
      </tbody>
  </table>
  </div>
</div>
</form>
</body>





</html>

