<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_edit.aspx.cs" Inherits="member_edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>


<head>
<meta charset="utf-8">
<title>hot 7會員</title>
<link href="member/css/style.css" rel="stylesheet" type="text/css">
<script src="member/js/jquery.min.js"></script>
<script src="member/js/jquery.placeholder.js"></script>
<script>
	// $.fn.hide = function() { return this; }
	$(function() {
		$('input, textarea').placeholder({customClass:'placeholder'});
	});
</script>
<script src="member/js/register.js"></script>


<script language="javascript">
    $(function() {
        var selectObj = document.form1.year2;
        for (var i = 0; i < selectObj.length; i++) {
            if (selectObj[i].value == $("#hide_year2").val())
                selectObj[i].selected = true;
            else
                selectObj[i].selected = false;
        }

        if (selectObj.value == "") {
            selectObj[0].selected = true;
        }

        selectObj = document.form1.month2;
        for (var i = 0; i < selectObj.length; i++) {
            if (selectObj[i].text == $("#hide_month2").val())
                selectObj[i].selected = true;
            else
                selectObj[i].selected = false;
        }

        if (selectObj.value == "") {
            selectObj[0].selected = true;
        }

        selectObj = document.form1.day2;
        for (var i = 0; i < selectObj.length; i++) {
            if (selectObj[i].text == $("#hide_day2").val())
                selectObj[i].selected = true;
            else
                selectObj[i].selected = false;
        }

        if (selectObj.value == "") {
            selectObj[0].selected = true;
        }
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
<form id="form1" runat="server">
<div class="head">
  <div class="logo"></div>
</div>
<div class="main">
  <div class="regbox" align="center">
  
  
              <input id="hide_year2" name="hide_year2" type="hidden" value="" runat="server" />
            <input id="hide_month2" name="hide_month2" type="hidden" value="" runat="server" />
            <input id="hide_day2" name="hide_day2" type="hidden" value="" runat="server" />
  
  
  
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe80d;</i> 修改會員資料</h4>
          <div class="form_tx flt_r">
          <i class="demo-icon c_or">&#xe846;</i>必填</div></td>
        </tr>
      </tbody>
    </table>
    <br>
    <table border="0" cellspacing="0" cellpadding="0" class="tbl">
      <tbody>
        <tr>
          <td><p class="tx_oops">&nbsp;</p></td>
        </tr>
        
        
        
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>姓 名</div>
            <div class="form_span flt_r">
            <%--<input name="textfield" type="text" class="input_field" id="textfield" maxlength="20">--%>
            <asp:TextBox ID="name" runat="server" CssClass="input_field" MaxLength="20"></asp:TextBox>
                   </div></td>
        </tr>
        
        <asp:Panel ID="Panel1" runat="server"  Visible="false">        
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>性 別</div>
            <div class="form_span flt_r">      
              <%--<input type="radio" name="radio" id="radio" value="male">
              <i class="demo-icon tx_xl">&#xe842;</i>&nbsp;&nbsp;&nbsp;&nbsp;
              <input type="radio" name="radio2" id="radio2" value="female">
              <i class="demo-icon tx_xl">&#xe843;</i>--%>
                            
              <asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="man"><i class="demo-icon tx_xl">&#xe842;</i>
                </asp:ListItem>
                <asp:ListItem Value="woman"><i class="demo-icon tx_xl">&#xe843;</i>
                </asp:ListItem>
                </asp:RadioButtonList>
              
            </div>            
            </td>
        </tr>
        </asp:Panel>
        
        
          
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>暱 稱</div>
          <div class="form_span flt_r">
            <%--<input name="textfield2" type="text" class="input_field" id="textfield2" maxlength="20">--%>
            <asp:TextBox ID="nickname" runat="server" CssClass="input_field" MaxLength="20"></asp:TextBox>
          </div></td>
        </tr>
        
        
        
        <asp:Panel ID="Panel2" runat="server" Visible="false">          
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>e-mail帳號</div>
          <div class="form_span flt_r">
          <%--<input type="text" class="input_field">--%>
          <asp:TextBox ID="email" runat="server" CssClass="input_field" MaxLength="80" BackColor="#FEECD3"></asp:TextBox>
          </div></td>
        </tr>
        </asp:Panel>
        
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_mid">&#xe812;</i>結婚紀念日</div>
          <div class="form_span flt_r">
          <%--<select name="year1" id="year1">
          <option selected>年</option>
          <option>1950</option>
          </select>
          <select name="month1"  id="month1">
          <option>月</option>
          <option>01</option>
          </select>
          <select name="day1"  id="day1">
          <option>日</option>
          <option>30</option>
          </select>--%>
          
          <asp:DropDownList ID="year2" runat="server">
          <asp:ListItem Value="">年</asp:ListItem>
          </asp:DropDownList>
          <asp:DropDownList ID="month2" runat="server">
          <asp:ListItem Value="">月</asp:ListItem>
          </asp:DropDownList>
          <asp:DropDownList ID="day2" runat="server">
          <asp:ListItem Value="">日</asp:ListItem>
          </asp:DropDownList>
          
          </div></td>
        </tr>
        <%--<tr>
          <td><div class="form_tx flt_l"><i class="demo-icon c_or">&#xe846;</i>聯絡電話</div>
          <div class="flt_l form_tx"> (手機、電話二擇一填寫)</div></td>
        </tr>--%>
        <tr>
          <td><div class="form_tx flt_l"><i class="demo-icon c_or">&#xe846;</i>手 機</div>
            <div class="form_span flt_r">
              <%--<input name="textfield8" type="text" class="input_field" id="textfield8" placeholder="例:0910123456" maxlength="10">--%>
              <asp:TextBox ID="mobile" runat="server" CssClass="input_field" MaxLength="10" placeholder="例:0910123456" ></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_mid">&#xe812;</i>市 話</div><div class="form_span flt_r">
            <label>
          <%--<input name="textfield5" type="text" id="textfield5" placeholder="區碼" size="5" maxlength="3">--%>
           <asp:TextBox ID="phone1" runat="server" MaxLength="3" size="5" onkeyup="this.value=this.value.replace(/[^\d]/g,'')" 
           placeholder="區碼" ></asp:TextBox>
        </label>
        -
        <%--<input name="textfield6" type="text" id="textfield6" size="12" maxlength="8">--%>
        <asp:TextBox ID="phone2" runat="server" MaxLength="8" size="12" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"></asp:TextBox>
        #
        <%--<input name="textfield7" type="text" id="textfield7" placeholder="分機" size="5" maxlength="5">--%>
        <asp:TextBox ID="phone3" runat="server" MaxLength="5" size="5" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
         placeholder="分機"></asp:TextBox>
        
        </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>地 址</div><div class="form_span flt_r">
          <%--<select id="Select1" name="city" onChange="get_zipcode(this.value);" runat="server">
          <option value="" selected>縣市別</option>
          </select>--%>
          <select id="city" name="city" onChange="get_zipcode(this.value);">
          <option value="">縣市別</option>
          <asp:Literal ID="LiteCity" runat="server"></asp:Literal>
          </select>
          
        &nbsp;
          <%--<select name="zipcode" id="zipcode" runat="server">
          <option value="">行政區</option>
          </select>--%>
          <select id="zipcode" name="zipcode">
          <option value="">行政區</option>
          <asp:Literal ID="LiteZipcode" runat="server"></asp:Literal>
          </select>
        
        
          </div></td>
        </tr>
        <tr>
          <td><div class="form_span flt_r">
            <%--<input name="textfield9" type="text" class="input_field" id="textfield9" maxlength="100" />--%>
            <asp:TextBox ID="address" runat="server" CssClass="input_field" MaxLength="100"></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>輸入密碼</div>
            <div class="form_span flt_r">
            <%--<input type="text" class="input_field" placeholder="4 - 8 個字元">--%>
            <asp:TextBox ID="pwd" runat="server" CssClass="input_field" MaxLength="8" 
                          TextMode="Password" placeholder="4 - 8 個字元"></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>確認密碼</div>
          <div class="form_span flt_r">
          <%--<input type="text" class="input_field" placeholder="4 - 8 個字元">--%>
          <asp:TextBox ID="chk_pwd" runat="server" CssClass="input_field" MaxLength="8"
                           TextMode="Password" placeholder="4 - 8 個字元"></asp:TextBox>
          
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx">
          <%--<input type="checkbox" checked>--%>
           <asp:CheckBox ID="CheckBox_v1" runat="server" Checked="true"/>
          </div> 
            <div class="flt_l form_tx">願意收到hot 7優惠</div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx">
          <%--<input name="checkbox" type="checkbox" id="checkbox" checked>--%>
           <asp:CheckBox ID="CheckBox_v2" runat="server" Checked="true"/>
          </div>
           <div class="flt_l form_tx">願意收到本公司所有餐廳優惠</div></td>
        </tr>
        <tr>
          <td><br>
            <%--<input type="button" name="button" class="butn input_field" value="確定送出">--%>
            <asp:Button ID="Button1" runat="server" Text="確定送出" CssClass="butn input_field" 
                  onclick="Button1_Click" />

          </td>
        </tr>
      </tbody>
  </table>
  </div>
</div>
</form>
</body>






</html>

