<%@ Page Language="C#" AutoEventWireup="true" CodeFile="survey_nonlog.aspx.cs" Inherits="survey_nonlog" %>

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
          <td class="bg_line">
          <h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe851;</i>不參加抽獎</h4></td>
        </tr>
        <tr>
          <td><div class="flt_r form_tx"><a href="survey_login.aspx"><i class="demo-icon c_or">&#xe812;</i>我是會員請由此登入</a></div></td>
        </tr>
      </tbody>
    </table>
    <table border="0" cellspacing="0" cellpadding="0" class="tbl">
      <tbody>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx">姓 名</div>
            <div class="form_span flt_r">
        <%--<input name="textfield" type="text" class="input_field" id="textfield" maxlength="20">--%>
        <asp:TextBox ID="txtCName" runat="server" CssClass="input_field" MaxLength="20"></asp:TextBox>
        </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx">性 別</div>
            <div class="form_span flt_r">
              <%--<input type="radio" name="radio" id="radio" value="male">
              男&nbsp;&nbsp;&nbsp;&nbsp;
              <input type="radio" name="radio2" id="radio2" value="female">
              女--%>
              
              <asp:RadioButtonList ID="rbtnGender" runat="server" RepeatDirection="Horizontal">
              <asp:ListItem Value="0">男&nbsp;&nbsp;&nbsp;</asp:ListItem>
              <asp:ListItem Value="1">女</asp:ListItem>
              </asp:RadioButtonList> 
              
              
            </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx">生 日</div><div class="form_span flt_r">
          <%--<select name="year1" id="year1">
          <option selected>年</option>
          <option>1950</option>
          </select>--%> 
          
          
          <%--<select name="month1"  id="month1">
          <option>月</option>
          <option>01</option>
          </select>--%>
          
          
          <%--<select name="day1"  id="day1">
          <option>日</option>
          <option>30</option>
        </select>--%>
          
             <asp:DropDownList ID="selebiryear" runat="server">
              <asp:ListItem Value="">年</asp:ListItem>
             </asp:DropDownList>                  
             <asp:DropDownList ID="selebirmonth" runat="server">
               <asp:ListItem Value="">月</asp:ListItem>
             </asp:DropDownList>           
             <asp:DropDownList ID="selebirday" runat="server">
               <asp:ListItem Value="">日</asp:ListItem>
             </asp:DropDownList>
        
        
        
        
        
        </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx">e-mail帳號</div><div class="form_span flt_r">
          <%--<input type="text" class="input_field">--%>
          <asp:TextBox ID="txtEmail" runat="server" CssClass="input_field"></asp:TextBox>
          
          </div></td>
        </tr>
        <tr>
          <td>
              <asp:CheckBox ID="CheckBox_AgreedEmail"  runat="server" checked=true Text="我同意基於提供服務或活動訊息之目的，填寫以上資料作為貴企業使用。"/>
            </td>
        </tr>
        <tr>
          <td>
          <%--<input type="button" name="button" class="butn input_field form_tx" value="不參加抽獎送出問卷" onclick="location.href='survey_ok.html'">--%>
              <asp:Button ID="Button1" runat="server" Text="不參加抽獎送出問卷" 
                  CssClass="butn input_field form_tx" onclick="Button1_Click" />
          
          </td>
        </tr>
      </tbody>
  </table>
  </div><div class="regbox_b" align="center">
    <div class="navbox2"><a href="member/member_join.html"> 註冊新帳號</a></div>
  <div class="navbox2"><a href="member/member_reset_pw1.html">忘記密碼</a></div>
  <div class="navbox2"><a href="member/member_reissue.html">補發確認信</a></div>
  </div>
</div>
</form>
</body>
    </html>


