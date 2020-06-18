<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_cancel.aspx.cs" Inherits="member_cancel" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>hot 7 新鉄板料理</title>
<link href="css/main.css" rel="stylesheet" type="text/css">
<link href="css/style.css" rel="stylesheet" type="text/css">
<script src="js/jquery-1.7.min.js" type="text/javascript"></script>
<script src="js/scroll_toolbar.js" type="text/javascript"></script>

<script type="text/javascript">

    function EvImageOverChange(name, action) {
        switch (action) {
            case 'in':
                name.src = "images/btn_checka.png";
                break;
            case 'out':
                name.src = "images/btn_check.png";
                break;
        }
    }
</script>
</head>

<body>
<div class="btn_01 pos alp"><a href="store.aspx"><img src="images/f_01.png" onmouseover="this.src='images/f_01a.png'" onmouseout="this.src='images/f_01.png'" alt="" style="cursor:pointer; border: none;" /></a></div>
<div class="btn_02 pos alp"><a href="menu_PASS.html"><img src="images/f_02.png" onmouseover="this.src='images/f_02a.png'" onmouseout="this.src='images/f_02.png'" alt="" style="cursor:pointer; border: none;" /></a></div>
<div class="btn_03 pos alp"><a href="member.html"><img src="images/f_03.png" onmouseover="this.src='images/f_03a.png'" onmouseout="this.src='images/f_03.png'" alt="" style="cursor:pointer; border: none;" /></a></div>
<div class="btn_04 pos alp"><a href="talk.aspx"><img src="images/f_04.png" onmouseover="this.src='images/f_04a.png'" onmouseout="this.src='images/f_04.png'" alt="" style="cursor:pointer; border: none;" /></a></div>
<div class="btn_06 pos alp"><a href="qa_step01.aspx"><img src="images/f_06.png" onmouseover="this.src='images/f_06a.png'" onmouseout="this.src='images/f_06.png'" alt="" style="cursor:pointer; border: none;" /></a></div>


<div class="wrapper">
    <div class="container">
      <a href="index.html"><div class="logo_m"></div></a>
      <div class="word" style=" background:url(images/title-member.png) top no-repeat;">
          <form id="Form1" runat="server">
          <br><br>
            <table width="600" border="0" cellspacing="3" class="tb_qa">
                 <tr>
                   <td colspan="2" class="font_01"><span class="font_w">取消訂閱eDM</span></td>
                 </tr>
                 <tr>
                   <td colspan="2" class="font_01" style="padding:10px 0;">請輸入會員資料即可取消訂閱！謝謝！</td>
                 </tr>
                 <tr>
                   <td class="font_01" width="25%">▌email帳號</td>
                   <td><asp:TextBox 
                                  ID="txtEmail" class="member_inputtxt"  runat="server" MaxLength="80" Width="150px"></asp:TextBox></td>
                 </tr>
                 <tr>
                   <td class="font_01">▌密碼</td>
                   <td><asp:TextBox 
                                  ID="txtPwd" class="member_inputtxt"  runat="server" MaxLength="8" TextMode="Password" Width="150px"></asp:TextBox> <a href="http://www.hot-7.com/member_forget.aspx" target="_blank">忘記密碼</a></td>
               </tr>
                     <tr>
                       <td class="font_01" style="vertical-align:top;">▌驗證碼</td>
                       <td> <asp:TextBox ID="code" runat="server" CssClass="member_year" MaxLength="5" 
                          Width="50px"></asp:TextBox>
									<iframe name="imgcode" id="imgcode" src="m/code.aspx" width="120" height="50" scrolling="no" frameborder="0"></iframe></td>
                     </tr>
                     <tr>
                       <td></td>
                       <td> <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();">↑更換別組圖示</a> (請輸入圖片中文字，不分大小寫)</td>
                     </tr>
                     <tr>
                       <td></td>
                       <td>&nbsp;</td>
                     </tr>
                     <tr>
                        <td></td>
                     <td style="padding:30px 0 0 20px;"><asp:ImageButton 
                             ID="ImageButton1" runat="server" ImageUrl="images/btn_check.png" 
                             width="106" height="45" onMouseOver="this.src='images/btn_checka.png'" 
                             onMouseOut="this.src='images/btn_check.png'" alt="" 
                             style="cursor:pointer; border: none;" onclick="ImageButton1_Click"/>
                         </a>
                        &nbsp;</td>
                     </tr>
       </table>            
                <br>
          </form>
      </div>
    </div>
    
</div>
<div class="footer">
	<div style="background:url(images/underline_bg.png) repeat-x; text-align:center;"><img src="images/underline.png"></div>
    <img src="images/footer.png" width="761" height="72" border="0" usemap="#Map2">
            <map name="Map2">
      	<area shape="rect" coords="382,41,441,61" href="job.html">
      	<area shape="rect" coords="507,42,564,61" href="en/menu.aspx">
        <area shape="rect" coords="446,41,505,60" href="link.html">
        <area shape="rect" coords="280,20,563,40" href="contact.html">
        <area shape="rect" coords="313,41,376,61" href="token_ch.aspx">
      </map>
	<br>
  <div class="rightss">
      © 2015 hot 7, Inc. All Rights Reserved.<img src="images/space.gif" width="200" height="1">
      <span style="border-bottom:#090 dotted 1px; font-size:100%;"><a href="rule.html" onclick="MM_openBrWindow('rule.htm','','scrollbars=yes,width=550,height=600')">使用條款</a></span> / 
      <span style="border-bottom:#090 dotted 1px; font-size:100%;"><a href="rights.html" onclick="MM_openBrWindow('rights.htm','','scrollbars=yes,width=550,height=600')">隱私權政策</a></span>
  </div>
</div>
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