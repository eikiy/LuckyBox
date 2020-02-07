<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="event_15_summer_login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇 新日本料理 十周年感恩祭 729浴衣饗口福 網路報名</title>
<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/style.css">

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
<form id="form" runat="server"><br><br>
	<table border="0" cellpadding="0" cellspacing="0" style="width:570px; margin:0 auto;">
         <tr>
          <td>
        <div class="login-area">
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td>以下資料請確實填寫，以利寄送報名通知函<span class="font02">(皆為必填)</span></td>
              </tr>
          </table><br><br>
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td>&nbsp;</td>
              <td><font color="#f00">▌</font>活動時間：</td>
              <td>7/29 11:00~13:00</td>
            </tr>
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#f00">▌</font>參加場次：(請擇一)<br></td>
              <td>
              <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
              	
              	  <td>
              	  
              	    <%--<select name="select2" id="select2">
              	    <option>請選擇區域</option>
              	    <option>北部</option>
              	    <option>中部</option>
              	    <option>南部</option>
            	    </select>--%>
            
              	    　
              	    <%--<select name="select3" id="select3">
              	        <option selected>請選擇分店</option>
              	        <option>台北敦化北店</option>
              	        <option>台北衡陽店</option>
              	        <option>台北中山北店</option>
              	        <option>板橋麗寶店</option>
              	        <option>永和中山店</option>
              	        <option>桃園南華店</option>
              	        <option>竹北光明店</option>
              	        <option>中壢中山店</option>
              	        <option>蘆竹南崁店</option>
              	        <option>台中大墩店</option>
              	        <option>台中崇德店</option>
              	        <option>台中福雅店</option>
              	        <option>嘉義耐斯松屋店</option>
              	        <option>高雄中山店</option>
              	        <option>高雄夢時代店</option>
              	        <option>仁德中山店</option>
       	             </select>--%>
       	            
                        <asp:DropDownList ID="ddlArea" runat="server" OnSelectedIndexChanged="ddlArea_OnSelectedIndexChanged" AutoPostBack=true>
                        <asp:ListItem Value="請選擇區域">請選擇區域</asp:ListItem>
                        <asp:ListItem Value="北部場次">北部場次</asp:ListItem>
                        <asp:ListItem Value="中部場次">中部場次</asp:ListItem>
                        <asp:ListItem Value="南部場次">南部場次</asp:ListItem>
                        </asp:DropDownList>
       	            
                        <asp:DropDownList ID="ddlStore" runat="server">
                        </asp:DropDownList>
       	            
       	            
       	            </td>
            	  </tr>
                  <tr>
              	  <td><span style="color:#f00;">(如該分店已額滿, 將不顯示於選單中)</span></td>
            	  </tr>
              	</table>
              </td>
            </tr>
          </table>
        <br>
        <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#f00">▌</font>我要報名：</td>
              <td>
              <table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
              	<tr>
                	<td width="50%"><%--<input name="" type="radio" value=""> 1人--%>
                	
                	<asp:RadioButtonList ID="rbSum" runat="server" RepeatDirection="Horizontal" Width="110px" AutoPostBack="True"
                     onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" >
                    <asp:ListItem Selected="True" Value="1">1人</asp:ListItem>
                    <asp:ListItem Value="2">2人</asp:ListItem>
                    </asp:RadioButtonList>
                	
                	
                	<td><%--<input name="" type="radio" value=""> 2人--%></td>
                </tr>
              </table>
              </td>
              </tr>
          </table>
        <br>
 		<table border="0" cellpadding="0" cellspacing="0" style="width:100%;">
            <tr>
              <td width="5%">&nbsp;</td>
              <td width="28%"><font color="#f00">▌</font>中文姓名：</td>
              <td>
                <%--<input type="text" name="textfield" id="textfield">--%>
                <asp:TextBox ID="txtName1" runat="server"></asp:TextBox>
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#f00">▌</font>手機：</td>
                <td>
                <%--<input type="text" name="textfield" id="textfield">--%>
                <asp:TextBox ID="txtPhone1" runat="server" MaxLength="10"></asp:TextBox>
                </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td style="vertical-align:top;"><font color="#f00">▌</font>出生年月日：</td>
                <td>
                  <%--<select name="select" id="select"></select>
                 &nbsp;<select name="select" id="select"></select>&nbsp;<select name="select" id="select"></select> --%>
                <asp:DropDownList ID="ddlYear1" runat="server">
                <asp:ListItem Value="">年</asp:ListItem>
                </asp:DropDownList>                  
                <asp:DropDownList ID="ddlMonth1" runat="server" >
                <asp:ListItem Value="">月</asp:ListItem>
                </asp:DropDownList>                    
                <asp:DropDownList ID="ddlDay1" runat="server" >
                <asp:ListItem Value="">日</asp:ListItem>
                </asp:DropDownList>
                
                
                (例:1900年1月1日)</td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#f00">▌</font>email：</td>
                <td>                
                <%--<input type="text" name="textfield" id="textfield">  --%> 
                <asp:TextBox ID="txtEmail1" runat="server"></asp:TextBox>              
                  
                 
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
              <td width="28%"><font color="#f00">▌</font>同行者中文姓名：</td>
              <td>
              <%--<input type="text" name="textfield" id="textfield">--%>
              <asp:TextBox ID="txtName2" runat="server"></asp:TextBox>
              
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td><font color="#f00">▌</font>手機：</td>
                <td>
                <%--<input type="text" name="textfield" id="textfield">--%>
                <asp:TextBox ID="txtPhone2" runat="server" MaxLength="10"></asp:TextBox>
                </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td style="vertical-align:top;"><font color="#f00">▌</font>出生年月日：</td>
                <td>
                 <%-- <select name="select" id="select"></select>
                 &nbsp;<select name="select" id="select"></select>&nbsp;<select name="select" id="select"></select> --%>
                <asp:DropDownList ID="ddlYear2" runat="server">
                <asp:ListItem Value="">年</asp:ListItem>
                </asp:DropDownList>                  
                <asp:DropDownList ID="ddlMonth2" runat="server" >
                <asp:ListItem Value="">月</asp:ListItem>
                </asp:DropDownList>                    
                <asp:DropDownList ID="ddlDay2" runat="server" >
                <asp:ListItem Value="">日</asp:ListItem>
                </asp:DropDownList>
                
                (例:1900年1月1日)</td>
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
              <td width="18%" style="vertical-align:top; color:#f00;">※報名須知：</td>
              <td><ol>
                  <li>每人有乙次報名機會，每次限報2名。</li>
                  <li>報名後將寄發通知信告知是否報名成功，請確實提供完整資訊以利活動小組作業。</li>
                  <li>如遇報名問題，請來信詢問<a href="mailto:marketing@ikki.com.tw">活動小組</a>。</li>
              </ol>
              </td>
              </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="2">&nbsp;</td>
              </tr>
              <tr>
                <td><br></td>
                <td colspan="2" style="text-align:center;">
                
                 
                 <img src="images/ending.png" width="169" height="61" style="border: none; margin:0 auto;" />
                  
                  
                  <!--<asp:ImageButton ID="ImageButton1" runat="server" 
                 ImageUrl="images/btn_apply.png"  
                 onmouseover="this.src='images/btn_applya.png'" 
                 onmouseout="this.src='images/btn_apply.png'" onclick="ImageButton1_Click" 
                 alt="" width="233" height="84" style="cursor:pointer; border: none; margin:0 auto;"/>-->
                  
                  
                </td>
              </tr>
          </table>
      </div>
            
            </td>
        </tr>
    </table>
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

