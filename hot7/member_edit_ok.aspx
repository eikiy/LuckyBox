<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_edit_ok.aspx.cs" Inherits="member_edit_ok" %>

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
<div class="head">
  <div class="logo"><a href="index.html"><img src="member/img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe80d;</i> 修改會員資料</h4></td>
        </tr>
      </tbody>
    </table>
    <br>
    <table border="0" cellspacing="0" cellpadding="0" class=" tbl">
      <tbody>
        <tr>
          <td><div class="c_or">
             
            <%--<p class="tx_oops">貴賓您好：</p>
            <p class="tx_oops"><span class="member_tit"> 資料已修改完成，謝謝！ </FONT></span></p>--%>
            <asp:Literal ID="LiteOut" runat="server"></asp:Literal>
            
          </div><hr></td>
        </tr>
      </tbody>
    </table>
  </div>
</div>
</body>




</html>
