<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apply.aspx.cs" Inherits="event_14_bathrobe_apply" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>【藝奇新日本料理】一起穿浴衣  711款待您</title>
<meta property="og:title" content="【藝奇新日本料理】一起穿浴衣  711款待您"/>
<meta property="og:url" content="http://www.ikki.com.tw/event/14_bathrobe/index.aspx"/>
<meta property="og:image" content="http://www.ikki.com.tw/event/14_bathrobe/images/fbb.jpg"/>
<meta property="og:site_name" content="天大好消息！7/11(五)11:00~13:00穿日式浴衣至全台藝奇品新菜，每店前100名免費招待套餐乙客，走走走!相約賞味去!詳情快上www.ikki.com.tw "/>
<meta property="og:description" content="天大好消息！7/11(五)11:00~13:00穿日式浴衣至全台藝奇品新菜，每店前100名免費招待套餐乙客，走走走!相約賞味去!詳情快上www.ikki.com.tw "/>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">

</head>

<body style="background:#000 url(images/bg.jpg) repeat-x;">
<form id="form1" runat="server">
    <div style="position:absolute; top:390px; left:50%; margin-left:-450px;">
    	<a href="b710.html"><img src="images/btn_b_01.png" onmouseover="this.src='images/btn_b_01a.png'" onmouseout="this.src='images/btn_b_01.png'" style="cursor:pointer; border: none;" /></a>
    </div>
    <div style="position:absolute; top:520px; left:50%; margin-left:-450px;">
    	<a href="food.aspx"><img src="images/btn_b_02.png" onmouseover="this.src='images/btn_b_02a.png'" onmouseout="this.src='images/btn_b_02.png'" style="cursor:pointer; border: none;" /></a>
    </div>

<div class="wrapper">
	<table border="0" cellpadding="0" cellspacing="0">
        	<tr>
            	<td colspan="2"><a href="http://www.ikki.com.tw/"><img src="images/apply_02.jpg"></a></td>
            </tr>
            <tr>
            	<td colspan="2"><a href="index.aspx"><img src="images/apply_04.jpg"></a></td>
            </tr>
            <tr>
            	<td colspan="2"><img src="images/apply_05.jpg"></td>
            </tr>
            <tr>
              <td style="vertical-align:top;"><img src="images/apply_06.jpg"/></td>
              <td style="width:614px; background:url(images/apply_07.jpg) no-repeat; vertical-align:top;">
             		<table border="0" cellpadding="0" cellspacing="0" style="width:540px;">
         <tr>
          <td>
        <div class="login-area">
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="40%">報名填寫資料(以下欄位皆為必填)</td>
              <td style="text-align:right;">目前已有<span class="font01">
                  <asp:Label ID="labCount" runat="server"></asp:Label>
                  </span>&nbsp;人報名，共40位名額</td>
              </tr>
          </table><br><br>
       
 
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="25%"><font color="#ff0">▌</font>我要報名：</td>
              <td>
              	  <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                      onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                      RepeatDirection="Horizontal" Width="110px" AutoPostBack="True">
                      <asp:ListItem Selected="True" Value="1">1人</asp:ListItem>
                      <asp:ListItem Value="2">2人</asp:ListItem>
                  </asp:RadioButtonList>
              </td>
              </tr>
          </table>
        <br>
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="25%"><font color="#ff0">▌</font>姓名：</td>
              <td>
                  <asp:TextBox ID="txtCName" runat="server" CssClass="member_inputtxt" 
                      MaxLength="20"></asp:TextBox>
                  <label>
                &nbsp;</label></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>手機：</td>
                <td>
                    <asp:TextBox ID="txtmobile1" runat="server" CssClass="member_inputtxt" 
                        MaxLength="10"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td style="vertical-align:top;"><font color="#ff0">▌</font>出生年月日：</td>
                <td>
                    <asp:DropDownList ID="drpyear1" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">年</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="drpmonth1" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">月</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="drpday1" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">日</asp:ListItem>
                    </asp:DropDownList>
                    <br>
                (ex.1900年1月1日)</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>email：</td>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="member_inputtxt" 
                        MaxLength="80"></asp:TextBox>
                    <br>                  
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
              <td width="25%"><font color="#ff0">▌</font>同行者姓名：</td>
              <td>
                  <asp:TextBox ID="txtCName2" runat="server" CssClass="member_inputtxt" 
                      MaxLength="20"></asp:TextBox>
                  <label>
                &nbsp;</label></td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#ff0">▌</font>手機：</td>
                <td>
                    <asp:TextBox ID="txtmobile2" runat="server" CssClass="member_inputtxt" 
                        MaxLength="10"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td style="vertical-align:top;"><font color="#ff0">▌</font>出生年月日：</td>
                <td>
                    <asp:DropDownList ID="drpyear2" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">年</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="drpmonth2" runat="server" CssClass="member_year">
                        <asp:ListItem Value="">月</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                    <asp:DropDownList ID="drpday2" runat="server" CssClass="member_year">
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
                  <li>每人有乙次報名機會，每人限報2名，額滿為止。</li>
                  <li style="background:#F00;">為符合活動需求，請確認活動當日穿日式浴衣，方可入場同樂。</li>
                  <li>請填寫完整報名資訊，以利活動小組聯繫通知。</li>
              </ol>
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2" style="text-align:center; color:#ff0; font-size:150%;"><asp:CheckBox ID="CheckBox1" runat="server" />                                  &nbsp;為符合活動當日需求，我同意穿著日式浴衣進場狂歡！</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
              <tr>
                <td><br></td>
                <td colspan="2" style="text-align:center;">
                 <img src="images/ending.png" width="169" height="61" style="margin:0 auto;" />
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
    
    
              </td>
            </tr>
    </table>
</div>
</form>
</body>
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
_uacct = "UA-2488504-1";
urchinTracker();
</script>
</html>