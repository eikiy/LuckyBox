<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_ok.aspx.cs" Inherits="member_ok" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">







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
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe807;</i> 加入會員</h4></td>
        </tr>
      </tbody>
    </table>
    <br>
    <table border="0" cellspacing="0" cellpadding="0" class=" tbl">
      <tbody>
        <tr>
          <td align="left"><div class="c_or">
            <p class="tx_oops">
            
            <asp:Label id="lblName" runat="server"></asp:Label> 
            
            貴賓：</p>
            <p class="tx_oops">您的會員認證資料已發送到這個信箱。
            <br>
            <asp:Label id="labEmail" runat="server"></asp:Label>
            <br>
              請至此 email 信箱確認成為hot 7的網路會員。謝謝。</p>
          </div><hr></td>
        </tr>
        <tr>
          <td align="left"><h5 class="c_blue">是否一直沒收到確認信函？</h5>
            <ul>
              <li>首先建議您再稍候片刻，信件會因應網路品質影響您收信的時間。 </li>
              <li>倘若您一直沒收到確認信函，建議您可檢查您的 email 是否有錯誤。若發現任何錯誤,可再重新註冊一次即可。</li>
              <li>建議您可檢查郵件信箱的垃圾郵件夾，檢查是否有 聚 的註冊確認信函。</li>
              <li>若您一直無法收到確認信函，歡迎您可填寫 客服信箱 或
                撥打免付費意見專線 0800-295-777 為您處理。</li>
            </ul>          </td>
        </tr>
      </tbody>
    </table>
  </div>
</div>
</body>








</html>
