<%@ Page Language="C#" AutoEventWireup="true" CodeFile="survey_ok.aspx.cs" Inherits="survey_ok" %>

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
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

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
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe80d;</i> 填寫完成</h4></td>
        </tr>
      </tbody>
    </table>
    <br>
    <table border="0" cellspacing="0" cellpadding="0" class=" tbl">
      <tbody>
        <tr>
          <td align="left"><div class="c_or">
            <p class="tx_oops">貴賓：</p>
            <p class="tx_oops">您已成功送出~ <br>
              再次感謝您光臨hot7！ <br />
              <br>
              您的建議與指教，是讓我們不斷進步的動力！<br />
              您的滿意是hot7努力的目標，<br />
              再次謝謝您給我們寶貴的意見與指教。<br />
            </p>
          </div></td>
        </tr>
      </tbody>
    </table>
  </div>
</div>
</form>
</body>
    </html>

