<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_login_anniversary.aspx.cs" Inherits="member_login_anniversary" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<META NAME="keywords" CONTENT="���_,�s�饻�Ʋz,���_ �s�饻�Ʋz, ikki, ���_�\�U�a�},���~����,���_�����|���u�f��,��X�z�ͤ�ڽЫ�"> 
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
    <form id="form1" runat="server">
<div class="wrapper">
<div class="logo"><a href="/index.html"><img src="images/logo.png" width="231" height="114"></a></div>
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
	<div class="img"><img src="images/img_member.png" width="271" height="888"></div>
	<div class="word">
      
      <span class="anchor" style="*margin-top:-30px;"></span>
      <img src="images/icon_member_01.png" width="630" height="45">
      <table border="0" cellpadding="0" cellspacing="0">
            <tr>
                <td style="border:none;">���z���B������ּ֡I �еn�J�z���b���αK�X~�Y�i�U���M�ݧI����I</td>
            </tr>
      </table>
      <table border="0" cellpadding="0" cellspacing="0">
      </table>
      <table border="0" cellpadding="0" cellspacing="0" style="margin-top:-20px;">
        <tr>
      <td width="20%" class="font_04">�lemail �b��</td>
      <td colspan="2" > <asp:TextBox id="txtEmail" runat="server" Width="226px" class="member_inputtxt"></asp:TextBox>
                                 </td>
      </tr>
    <tr>
      <td class="font_04">�l�K�X</td>
      <td colspan="2"><asp:TextBox id="txtPwd" runat="server"  class="member_inputtxt" Width="128px"  MaxLength="8" TextMode="Password"></asp:TextBox></td>
    </tr>
        <tr>
          <td colspan="3">�p�G�z<a href="member_forget.aspx">�ѰO�K�X</a>�A�д��� email �b���A�ڭ̱N�H�q�l�l�󪺤覡�i���C</td>
        </tr>
    </table>    
        <asp:ImageButton ID="ImageButton1" src="images/submit.png" 
            onmouseover="this.src='images/submit_a.png'" 
            onmouseout="this.src='images/submit.png'" alt="�T�w�e�X" width="285" height="51" 
            style="cursor:pointer; border: none; margin-left:180px;" runat="server" 
            onclick="ImageButton1_Click" />
    </div>	
</div>

</div>
<!--footer-->
	<iframe src="/footer.html" width="100%" height="152" frameborder="0"></iframe>
    <iframe src="/rights.html" width="100%" height="60" frameborder="0" style="margin-top:-38px;"></iframe>


</div>
    </form>
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