﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="talk.aspx.cs" Inherits="en_talk" %>



<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>hot 7 新鉄板料理</title>
<link href="/css/main.css" rel="stylesheet" type="text/css">
<link href="/css/style.css" rel="stylesheet" type="text/css">
<link href="/css/four.css" rel="stylesheet" type="text/css">
<script src="/js/jquery-1.7.min.js" type="text/javascript"></script>
<script src="/js/scroll_toolbar.js" type="text/javascript"></script>
</head>

<body>
<form id="form1" runat=server>
<div class="btn_01_en pos alp"><a href="store.aspx"><img src="images/f_01.png" width="98" height="96" onmouseover="this.src='images/f_01a.png'" onmouseout="this.src='images/f_01.png'" alt="" style="cursor:pointer; border: none;" /></a></div>
<div class="btn_02_en pos alp"><a href="menu.aspx"><img src="images/f_02.png" width="78" height="109" onmouseover="this.src='images/f_02a.png'" onmouseout="this.src='images/f_02.png'" alt="" style="cursor:pointer; border: none;" /></a></div>
<div class="btn_03_en pos alp"><a href="talk.aspx"><img src="images/f_03.png" width="105" height="111" onmouseover="this.src='images/f_03a.png'" onmouseout="this.src='images/f_03.png'" alt="" style="cursor:pointer; border: none;" /></a></div>


<div class="wrapper" style="clear:">
    <div class="container" style="clear:both;">
      <a href="../index.html"><div class="logo_m"></div></a>
      <div class="word" style="margin-top:180px; padding-bottom:30px;">      
        <div style="padding:20px 21px 0 20px;">
        <table width="95%" border="0" cellpadding="5" cellspacing="0" class="x_tb">
              <tr>
                <td class="x_f05" style="text-align:center;">Contact Us</td>
          </tr>
          <tr>
                <td class="x_line_y"></td>
          </tr>
          <tr>
                <td class="x_f04a">We appreciate you visiting our website. If you have further question, please leave your message as below. We will get back to you as soon as we can if necessary.<br>
                (All column should be filled)</td>
        </tr>
          </table>
   	<table width="95%" border="0" cellpadding="5" cellspacing="0" class="x_tb">
              <tr>
                <td width="35%" class="x_f10"><img src="/images/icn_01.png" width="18" height="25"> Your Name：</td>
                <td><asp:TextBox ID="name" runat="server" MaxLength="50"></asp:TextBox></td>
              </tr>
               <tr>
                <td colspan="2" class="x_line"></td>
              </tr>
              <tr>
                <td class="x_f10"><img src="/images/icn_01.png" width="18" height="25"> Gender</td>
                <td>
                  <asp:RadioButtonList ID="sex" runat="server"  
                        RepeatDirection="Horizontal">
                        <asp:ListItem Value="man">Male</asp:ListItem>
                        <asp:ListItem Value="woman">Female</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
              </tr>
               <tr>
                <td colspan="2" class="x_line"></td>
              </tr>
              <tr>
                <td class="x_f10"><img src="/images/icn_01.png" width="18" height="25"> Phone No. or 
                Mobile No.</td>
                <td><asp:TextBox ID="phone" runat="server"  
                        MaxLength="50" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox> e.g.0910123456 or 0212345678</td>
              </tr>
               <tr>
                <td colspan="2" class="x_line"></td>
              </tr>
              <tr>
                <td class="x_f10"><img src="/images/icn_01.png" width="18" height="25"> Your email</td>
                <td><asp:TextBox ID="email" runat="server"  MaxLength="80"></asp:TextBox></td>
              </tr>
               <tr>
                <td colspan="2" class="x_line"></td>
              </tr>
              <tr>
                <td class="x_f10"><img src="/images/icn_01.png" width="18" height="25"> Subject</td>
                <td><asp:TextBox ID="subject" runat="server" Columns="35" MaxLength="100"></asp:TextBox></td>
              </tr>
               <tr>
                <td colspan="2" class="x_line"></td>
              </tr>
              <tr>
                <td class="x_f10"><img src="/images/icn_01.png" width="18" height="25"> Suggestions</td>
                <td><label>
                      <asp:TextBox ID="content" runat="server" Columns="32" Rows="5" 
                        TextMode="MultiLine"></asp:TextBox>
                  </label></td>
              </tr>
               <tr>
                <td colspan="2" class="x_line"></td>
              </tr>
              <tr>
                <td colspan="2" style="text-align:center;">
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/btn_checka.png" 
                        onclick="ImageButton1_Click" />
                
                </td>
          </tr>
          </table>
        </div>
      </div>
  </div>
    
</div>
<div class="footer">
	<div style="background:url(../images/underline_bg.png) repeat-x; text-align:center;"><img src="../images/underline.png"></div><br>
    <img src="images/footer.png" width="761" height="72" border="0">
</div>
</form>
</body>
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>

</html>

