<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="event_15_testmeal_login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇 新日本料理 1+1双主餐 感恩粉絲試吃會 網路報名</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">

</head>

<body>
<form id="form" runat="server">
<div class="wrapper">
	<table border="0" cellpadding="0" cellspacing="0" style="width:60%; margin:0 auto;">
         <tr>
          <td>
        <div class="login-area">
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td>以下資料請確實填寫，以利寄送試吃邀請函<span class="font02">(皆為必填)</span></td>
              </tr>
          </table><br><br>
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#ff0">▌</font>參加場次(請擇一)：</td>
              <td>
              <%--<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
              	<tr>
                	<td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        </asp:RadioButtonList>
                	<input name="" type="radio" value="">
                	6/16(二) 18:30~20:30 藝奇
                	<a href="http://www.ikki.com.tw/store_all.aspx?#id10501" target="_blank">台北敦化北店</a></td>
                </tr>
                <tr>
                	<td>
                	<input name="" type="radio" value="">
                	6/17(三) 18:30~20:30 藝奇
                	<a href="http://www.ikki.com.tw/store_all.aspx?#id10510" target="_blank">台中福雅店</a></td>
                </tr>
                <tr>
                	<td>
                	<input name="" type="radio" value="">
                	6/18(四) 18:30~20:30 藝奇
                	<a href="http://www.ikki.com.tw/store_all.aspx?#id10517" target="_blank">仁德中山店</a></td>
                </tr>
              </table>--%>
              
                   <asp:RadioButtonList ID="RB_stage" runat="server" >
                      <asp:ListItem  Value="1" Selected="True">6/16(二) 18:30~20:30 藝奇
                      <a href="http://www.ikki.com.tw/store_all.aspx?#id10501" target="_blank">台北敦化北店</a>
                      </asp:ListItem>                      
                      <asp:ListItem Value="2">6/17(三) 18:30~20:30 藝奇
                      <a href="http://www.ikki.com.tw/store_all.aspx?#id10510" target="_blank">台中福雅店</a>
                      </asp:ListItem>
                      <asp:ListItem Value="3">6/18(四) 18:30~20:30 藝奇
                      <a href="http://www.ikki.com.tw/store_all.aspx?#id10517" target="_blank">仁德中山店</a>
                      </asp:ListItem>
                    </asp:RadioButtonList>
              
              </td>
            </tr>
          </table>

        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
                <td>&nbsp;</td>
                <td colspan="3" style="border-bottom:#eee 2px solid;">&nbsp;</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#ff0">▌</font>我要報名：</td>
              <td>
              <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
              	<tr>
                	<%--<td width="20%"><input name="" type="radio" value=""> 1人</td>
                	<td><input name="" type="radio" value=""> 2人</td>--%>
                	<td>
                	<asp:RadioButtonList ID="RB_sum" runat="server" RepeatDirection="Horizontal" Width="110px" AutoPostBack="True"
                	onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" >
                      <asp:ListItem Selected="True" Value="1">1人</asp:ListItem>
                      <asp:ListItem Value="2">2人</asp:ListItem>
                    </asp:RadioButtonList>
                	</td>
                </tr>
              </table>
              </td>
              </tr>
          </table>
        <br>
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#ff0">▌</font>姓名：</td>
              <td>
                <%--<input type="text" name="textfield" id="textfield">--%>
                <asp:TextBox ID="TEX_name1" runat="server"></asp:TextBox>
                
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>FB帳號：</td>
                <td>
                <%--<input type="text" name="textfield2" id="textfield2"> --%>
                <asp:TextBox ID="TEX_fb" runat="server"></asp:TextBox>
                (請填寫FB顯示名稱)</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>手機：</td>
                <td>
                <%--<input type="text" name="textfield" id="textfield">--%>
                <asp:TextBox ID="TEX_phone1" runat="server" MaxLength="10"></asp:TextBox>
                </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td style="vertical-align:top;"><font color="#ff0">▌</font>出生年月日：</td>
                <td>
                 <%--<select name="select" id="select"></select>
                 &nbsp;                 
                 <select name="select" id="select"></select>
                 &nbsp;<select name="select" id="select"></select>--%>
                 
                 
                    <asp:DropDownList ID="DDL_year1" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">年</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="DDL_month1" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">月</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="DDL_day1" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">日</asp:ListItem>
                    </asp:DropDownList>
                    <br>
                  
                (ex.1900年1月1日)</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>email：</td>
                <td>                
                <%--<input type="text" name="textfield" id="textfield">--%> 
                <asp:TextBox ID="TEX_email" runat="server"></asp:TextBox>                
                  </td>
              </tr>
              <tr>
                <td>&nbsp;</td>

                <td colspan="2" style="border-bottom:#eee 2px solid;">&nbsp;</td>
              </tr>
          </table>
          
          
            <!-- (若勾選2人，show出以下此表格，Email以報名者為主)-->
            <asp:Panel ID="Panel1" runat="server"> 
                <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
              <td>&nbsp;</td>
            </tr>
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#ff0">▌</font>同行者姓名：</td>
              <td>
              <%--<input type="text" name="textfield" id="textfield">--%>              
              <asp:TextBox ID="TEX_name2" runat="server"></asp:TextBox>
       
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>同行者手機：</td>
                <td>
                <%--<input type="text" name="textfield" id="textfield">--%>
                <asp:TextBox ID="TEX_phone2" runat="server" MaxLength="10"></asp:TextBox>                
                </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td style="vertical-align:top;"><font color="#ff0">▌</font>同行者出生年月日：</td>
                <td>
                
                  <%--<select name="select" id="select">
                  </select>&nbsp;
                  <select name="select" id="select">
                  </select>&nbsp;
                  <select name="select" id="select">
                  </select>--%>
                  
                  <asp:DropDownList ID="DDL_year2" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">年</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="DDL_month2" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">月</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="DDL_day2" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">日</asp:ListItem>
                    </asp:DropDownList>
                    <br>
                  
                  (ex.1900年1月1日)</td>
                </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2" style="border-bottom:#eee 2px solid;">&nbsp;</td>
              </tr>
          </table>
            </asp:Panel>
     
          <!-- (若勾選2人，show出以上此表格，Email以報名者為主)-->
       
          
          
          <br><br> 
          <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="18%" style="vertical-align:top; color:#ff0;">※報名須知：</td>
              <td><ol>
                  <li>每人有乙次報名機會，每人限報2名。</li>
                  <li>報名後將寄發通知函告知是否報名成功，<br>請確實提供完整資訊以利活動小組作業。</li>
              </ol>
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
              <tr>
                <td><br></td>
                <td colspan="2" align="center">
                  <img src="images/ending.png">
                  
                  <!--<asp:ImageButton ID="ImageButton1" runat="server" 
                 ImageUrl="images/btn_apply.png"  
                 onmouseover="this.src='images/btn_applya.png'" 
                 onmouseout="this.src='images/btn_apply.png'"
                 alt="" width="239" height="93" style="cursor:pointer; border: none; margin:0 auto;" 
                  onclick="ImageButton1_Click" />-->
                  
                </td>
              </tr>
          </table>
      </div>
            
            </td>
        </tr>
        <tr>
        	<td><br />
        	  <br />
        	  <br /></td>
        </tr>
    </table>
</div>
</form>
</body>
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488504-1', 'auto');
  ga('send', 'pageview');

</script>
</html>
