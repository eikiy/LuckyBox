<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_anniversary_print.aspx.cs" Inherits="member_anniversary_print" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<META NAME="keywords" CONTENT="���_,�s�饻�Ʋz,���_ ikki �s�饻�Ʋz,���_�\�U�a�},���~����,���_�����|���u�f��,��X�z�ͤ�ڽЫ�"> 
<META NAME="description" CONTENT="�g���� �����e�{�C�Y���O�s�A�����A�зs�馡���������C�V��~�饻�M�`�Ӹ`�C���s~���s�A�����C�K�[~¾�H�����зN�C�H�F�P�B����[���A�E���F�ʮɩ|�Ʋz�s�����C "> 

<title>���_ ikki �s�饻�Ʋz</title>
<script src="http://code.jquery.com/jquery-1.11.2.min.js"></script>
<script src="http://code.jquery.com/jquery-migrate-1.2.1.min.js"></script>
<script type="text/javascript" src="js/jquery.vegas.js"></script>

<link rel="stylesheet" type="text/css" href="css/jquery.vegas.css" />
<link rel="stylesheet" type="text/css" href="css/main.css" />
<link rel="stylesheet" type="text/css" href="css/style.css" />
<link rel="stylesheet" type="text/css" href="css/member.css" />
<link rel="stylesheet" type="text/css" href="css/footer_i.css" />

<script>

/* �H�U��menu================*/


$(function(){
	// �� #menu li �[�W hover �ƥ�
	$('#menu li').hover(function(){
		// ����� li �����l���
		var _this = $(this),
			_subnav = _this.children('ul');
 
		// �ܧ�ثe���ﶵ���I���C��
		// �P�ɲH�J�l���(�p�G������)
		_this.css('backgroundColor', '#f00');
		_subnav.stop(true, true).fadeIn(400);
		
	} , function(){
		// �ܧ�ثe���ﶵ���I���C��
		// �P�ɲH�X�l���(�p�G������)
		// �]�i�H���y��W�����g�k
		$(this).css('backgroundColor', '').children('ul').stop(true, true).fadeOut(400);
	});
 
	// �����W�s������u��
	$('a').focus(function(){
		this.blur();
	});
});


</script>

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>

</head>
<body>
<div class="wrapper"><div class="logo"><a href="/index.html"><img src="images/logo.png" width="231" height="114"></a></div>
<div class="header"> 
<div style="background:#000; height:130px;">   
<ul id="menu">
        <li><a href="about.html"><span class="font_01">��</span> �������_</a>
			<ul>
				<li><a href="brand.html">�~�P�믫</a></li>
				<li><a href="charity.html">��Ф��q</a></li>
				<li><a href="art.html">�|����</a></li>
			</ul>
		</li>
		<li><a href="store_pass_1101.aspx"><span class="font_01">��</span> �M�X���_</a>
			<ul style="margin-left:111px;">
				<li><a href="store_pass_1101.aspx">���x���E��T</a></li>
				<li><a href="http://partner.eztable.com/booking.php?page_name=ikki" target="_blank">24hr�u�W�q��</a></li>
			</ul>
		</li>
		<li><a href="menu.html"><span class="font_01">��</span> ��������</a></li>
		<li><a href="event.html"><span class="font_01">��</span> �����u�f</a></li>
      <li class="here"><a href="member.html"><span class="font_01">��</span> �|���M��</a>
        	<ul style="margin-left:270px;">
				<li><a href="member.html#link01">�M���u�f</a></li>
				<li><a href="member_join.aspx">�[�J�|��</a></li>
				<li><a href="member.html#link02">�|����T</a></li>
			</ul>
        </li>
        <li><a href="talk.aspx"><span class="font_01">��</span> �@�_����</a></li>
</ul>    
</div>
</div>

<div class="list side">
    	<table border="0" cellpadding="0" cellspacing="0" style="margin-top:20px;">
        	<tr>
            	<td><a href="member.html#link01"><img src="images/membera_02.jpg" alt="�M���u�f" width="49" height="98" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="member_join.aspx"><img src="images/member_03.jpg" onmouseover="this.src='images/membera_03.jpg'" onmouseout="this.src='images/member_03.jpg'" alt="�[�J�|��" width="49" height="98" style="cursor:pointer; border: none;" /></a></td>
            </tr>
            <tr>
            	<td><a href="member.html#link02"><img src="images/member_04.jpg" onmouseover="this.src='images/membera_04.jpg'" onmouseout="this.src='images/member_04.jpg'" alt="�|����T" width="49" height="98" style="cursor:pointer; border: none;" /></a></td>
            </tr>
        </table>
</div>
    
<div class="content">
	<!--<div class="img"><img src="images/img_member.png" width="271" height="888"></div>-->
	<div class="word">
      
      <span class="anchor" style="*margin-top:-30px;"></span>
      <img src="images/icon_member_01.png" width="630" height="45">
        <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="border:none;"><asp:Label id="lblCName" runat="server"></asp:Label>  �Q�� �z�n�G<br><Br>
  ���_ ���z ���B������ּ�~<BR>  �z�i�H�C�L���I����A�̥���� ���_ ���O�A�Y�i�K�O�I�����B�n§�C</td>
            </tr>
      </table>
          <!--coupon���e-->
          <div style="margin-left:60px;">
            <div style="position:relative; width:500px; height:250px; z-index:9990;">
                        <div style="position:absolute; top:10px; left:45px; z-index:8999;">�������B§</div>
                        <div style="position:absolute; top:165px; left:45px; z-index:8998;" class="qrcode_14"><asp:Literal ID="LiteNO" runat="server"></asp:Literal></div>
                        <div style="position:absolute; top:10px; left:16px; z-index:8995;"><asp:Literal ID="LiteQR" runat="server"></asp:Literal></div>
                        <div style="position:absolute; top:25px; left:220px; z-index:8996;">�o�O�� <asp:Literal ID="LiteName2" runat="server"></asp:Literal> �Q����</div>
                        <div style="position:absolute; top:124px; left:280px; z-index:8997;"><asp:Literal ID="LiteDate" runat="server"></asp:Literal></div>
            <img src="event/images/anniversary_coupon.jpg" width="500" height="230" style="z-index:1;" class="banner"/></div>
           </div>
           <!--coupon���e  end-->
           <div style="width:100%; text-align:center;">[ <a href="javascript:window.print()">�C�L</a> ]</div>
       </div>	
</div>

</div>


</div>
</body>

<!-- Google Tag Manager -->
<noscript><iframe src="//www.googletagmanager.com/ns.html?id=GTM-TCF5FD"
height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'//www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-TCF5FD');</script>
<!-- End Google Tag Manager -->

</html>