<%@ Page Language="C#" AutoEventWireup="true" CodeFile="keyin.aspx.cs" Inherits="event_14_summertour_keyin" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>

<link rel="stylesheet" type="text/css" href="css/main.css">
<link rel="stylesheet" type="text/css" href="css/login.css">
</head>

<body style="background:#d7000f;">
<form id="form1" runat="server">
<div class="login-area">
<img src="images/step_02.jpg">
 		<table width="100%" border="0" cellpadding="0" cellspacing="0">
            <tr>
              <td width="10%">&nbsp;</td>
              <td width="15%"><font color="#000">▌</font>發票/抽獎憑證號碼</td>
              <td colspan="4">
                 <input name="txtIdNo" type="text" id="txtIdNo" size="20" maxlength="10" runat="server" />
                 &nbsp;(例如 AB12345678 共10碼)</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><font color="#000">▌</font>發票日期</td>
              <td colspan="4"> <asp:dropdownlist id="selebiryear" runat="server" Width="100px">
			                    <asp:ListItem Value="2014">2014</asp:ListItem>
                    </asp:dropdownlist>
			          年
			          <select id="selebirmonth" size="1" name="birthmonth" runat="server">
			            <option value="請選擇" selected>請選擇</option>
			            <option value="07">07</option>
			            <option value="08">08</option>			            
		            </select>
			          月
			          <select id="selebirday" size="1" name="birthday" runat="server">
			            <option value="請選擇" selected>請選擇</option>
			            <option value="1">1</option>
			            <option value="2">2</option>
			            <option value="3">3</option>
			            <option value="4">4</option>
			            <option value="5">5</option>
			            <option value="6">6</option>
			            <option value="7">7</option>
			            <option value="8">8</option>
			            <option value="9">9</option>
			            <option value="10">10</option>
			            <option value="11">11</option>
			            <option value="12">12</option>
			            <option value="13">13</option>
			            <option value="14">14</option>
			            <option value="15">15</option>
			            <option value="16">16</option>
			            <option value="17">17</option>
			            <option value="18">18</option>
			            <option value="19">19</option>
			            <option value="20">20</option>
			            <option value="21">21</option>
			            <option value="22">22</option>
			            <option value="23">23</option>
			            <option value="24">24</option>
			            <option value="25">25</option>
			            <option value="26">26</option>
			            <option value="27">27</option>
			            <option value="28">28</option>
			            <option value="29">29</option>
			            <option value="30">30</option>
			            <option value="31">31</option>
		            </select>
			          日</td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td><font color="#000">▌</font>本次消費總金額</td>
              <td colspan="4"> <input id="txtCost" type="text" maxlength="6" name="txtCost" runat="server" /></td>
            </tr>
            <tr>
              <td>&nbsp;</td>
              <td style="vertical-align:top;"><font color="#000">▌</font>請輸入驗證碼</td>
              <td style="vertical-align:top;" width="20%">
                  <input id="txtCode" runat="server" class="style5" maxlength="5" name="txtCode" 
                      size="10" type="text" /></td>
              <td width="15%"><iframe name="imgcode" id="imgcode" src="../../m/code.aspx" width="120" height="50" scrolling="no" frameborder="0"></iframe></td>
              <td colspan="2"><a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();" class="member_g1">&larr;更換別組圖示</a><br>
          (請輸入圖片中文字，不分大小寫)</td>
            </tr>
              <tr>
                <td>&nbsp;</td>
                <td colspan="5" style="padding:10px 0 10px 160px;">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="下一步" />
                    &nbsp;</td>
              </tr>
              <tr>
                <td style="text-align:right; vertical-align:top;" class="line">貼心提醒：</td>
                <td colspan="5" class="line">
                <ol>
                    <li>請妥善保管您所登錄的發票影本/抽獎憑證，作為日後中獎時核驗之用，遺失則無法兌獎。</li>
                    <li>為確保您的權益，請檢視登入資訊是否完整。</li>
                    <li>一張發票號碼/抽獎憑證限登入一次，重複輸入視同無效。</li>
                    <li>當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~</li>
                </ol>
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
