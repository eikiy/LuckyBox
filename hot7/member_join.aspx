<%@ Page Language="C#" AutoEventWireup="true" CodeFile="member_join.aspx.cs" Inherits="member_join" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">



<meta charset="utf-8">
<title>hot7會員</title>
<link href="member/css/style.css" rel="stylesheet" type="text/css">


<script src="https://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="member/js/register.js"></script>

<script src="member/js/jquery.min.js"></script>
<script src="member/js/jquery.placeholder.js"></script>
<script>
	// $.fn.hide = function() { return this; }
	$(function() {
	$('input, textarea').placeholder({ customClass: 'placeholder' });
    });		
</script>


<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>


</head>
<body>
<form id="form1" name="form1" method="post" action="member_join.aspx" onsubmit="return checkdata();" runat="server">





<div class="head">
  <div class="logo"><a href="index.html"><img src="member/img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe807;</i> 加入會員</h4>
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
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>性 別</div>
            <div class="form_span flt_r">
            
              <%--<input type="radio" name="radio" id="radio" value="male">
              男&nbsp;&nbsp;&nbsp;&nbsp;
              <input type="radio" name="radio2" id="radio2" value="female">
              女--%>
                <%--<asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="man">男&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp&nbsp;&nbsp;&nbsp;&nbsp</asp:ListItem>
                <asp:ListItem Value="woman">女</asp:ListItem>
                </asp:RadioButtonList>--%>
                
                
                <asp:RadioButtonList ID="RadioButtonList_Gender" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="man" Selected=True><i class="demo-icon tx_xl">&#xe842;</i>
                </asp:ListItem>
                <asp:ListItem Value="woman"><i class="demo-icon tx_xl">&#xe843;</i>
                </asp:ListItem>
                </asp:RadioButtonList>
              
            </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>暱 稱</div>
          <div class="form_span flt_r">            
            <%--<input name="textfield2" type="text" class="input_field" id="textfield2" maxlength="20">--%>
            <asp:TextBox ID="nickname" runat="server" CssClass="input_field" MaxLength="20"></asp:TextBox>            
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>e-mail帳號~<strong>點選email信箱可啟動帳號 (不可修改)</strong></div>
          <div class="form_span flt_r">
          <%--<input type="text" class="input_field" placeholder="輸入email信箱，接收啟動確認信函">--%>
          <asp:TextBox ID="email" runat="server" CssClass="input_field" 
           placeholder="輸入email信箱，接收啟動確認信函" MaxLength="80"  onblur="checkuser();"></asp:TextBox>       
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>生 日</div>
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
          <asp:DropDownList ID="year1" runat="server">
              <asp:ListItem Value="">年</asp:ListItem>
          </asp:DropDownList>                  
          <asp:DropDownList ID="month1" runat="server">
               <asp:ListItem Value="">月</asp:ListItem>
           </asp:DropDownList>           
           <asp:DropDownList ID="day1" runat="server">
               <asp:ListItem Value="">日</asp:ListItem>
           </asp:DropDownList>
          
          
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_mid">&#xe812;</i>結婚紀念日</div>
          <div class="form_span flt_r">
          <%--
          <select name="year1" id="year1">
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
              <%--<input name="textfield8" type="text" class="input_field" id="textfield8" placeholder="例:0910123456" maxlength="10" onblur="checkuser_mobile();">--%>
              <asp:TextBox ID="mobile" runat="server" CssClass="input_field" MaxLength="10" placeholder="例:0910123456" ></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_mid">&#xe812;</i>市 話</div><div class="form_span flt_r">
            <label>
                  <%--<input name="textfield5" type="text" id="textfield5" placeholder="區碼" size="5" maxlength="3">--%>
                  <asp:TextBox ID="phone1" runat="server" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                      placeholder="區碼" size="5" maxlength="3"></asp:TextBox>                 
            </label>
            -
                  <%--<input name="textfield6" type="text" id="textfield6" size="12" maxlength="8">--%>
                  <asp:TextBox ID="phone2" runat="server" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                  size="12" maxlength="8"></asp:TextBox>
            #
                  <%--<input name="textfield7" type="text" id="textfield7" placeholder="分機" size="5" maxlength="5"> --%>
                  <asp:TextBox ID="phone3" runat="server" onkeyup="this.value=this.value.replace(/[^\d]/g,'')"
                   placeholder="分機" size="5" maxlength="5"></asp:TextBox>
                  
                  
        </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>地 址</div>
          <div class="form_span flt_r">
          
          
          <%--<select id="Select1" name="city" onchange="get_zipcode(this.value);" runat="server">
          <option value="">縣市別</option>
          </select>          
          &nbsp;
          <select name="zipcode" id="zipcode" runat="server">
          <option value="">行政區</option>
          </select>--%>
          <select id="city" name="city" onChange="get_zipcode(this.value);" runat="server">
              <option value="">縣市別</option>
          </select>
          &nbsp;
          <select id="zipcode" name="zipcode" runat="server">
               <option value="">行政區</option>
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
                          TextMode="Password"  placeholder="4 - 8 個字元"></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>確認密碼</div>
          <div class="form_span flt_r">
          <%--<input type="text" class="input_field" placeholder="4 - 8 個字元">--%>
          <asp:TextBox ID="chk_pwd" runat="server" CssClass="input_field" 
                          MaxLength="8" TextMode="Password" placeholder="4 - 8 個字元"></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="form_span flt_r">
              <%--<select name="select" class="input_field">
                <option value="">職業</option>
                <option value="1">企業負責人</option>
                <option value="2">中高階層主管</option>
                <option value="3">基層主管</option>
                <option value="4">一般職員</option>
                <option value="5">家管</option>
                <option value="6">學生</option>
                <option value="7">其他</option>
              </select>--%>
              
              <asp:DropDownList ID="job" runat="server" CssClass="input_field">
                <asp:ListItem Value="">職業</asp:ListItem>
                <asp:ListItem value="1">企業負責人</asp:ListItem>
                <asp:ListItem value="2">中高階層主管</asp:ListItem>
                <asp:ListItem value="3">基層主管</asp:ListItem>
                <asp:ListItem value="4">一般職員</asp:ListItem>
                <asp:ListItem value="7">公教人員</asp:ListItem>
                <asp:ListItem value="10">家管</asp:ListItem>
                <asp:ListItem value="14">學生</asp:ListItem>
                <asp:ListItem value="18">其他</asp:ListItem>
              </asp:DropDownList>
              
              
          </div></td>
        </tr>
        <tr>
          <td><div class="form_span flt_r">
              <%--<select name="select2" class="input_field">
                <option value="">教育程度</option>
                <option value="14">國中以下</option>
                <option value="9">高中職</option>
                <option value="10">專科</option>
                <option value="11">大專院校</option>
                <option value="12">研究所</option>
                <option value="13">其他</option>
              </select>--%>
              <asp:DropDownList ID="education" runat="server" CssClass="input_field">
                  <asp:ListItem value="">教育程度</asp:ListItem>
	              <asp:ListItem value="14">國中以下</asp:ListItem>
                  <asp:ListItem value="9">高中職</asp:ListItem>
                  <asp:ListItem value="10">專科</asp:ListItem>
                  <asp:ListItem value="11">大專院校</asp:ListItem>
                  <asp:ListItem value="12">研究所</asp:ListItem>
                  <asp:ListItem value="13">其他</asp:ListItem>
              </asp:DropDownList>
          </div></td>
        </tr>
        <tr>
          <td><div class="form_span flt_r">
              <%--<select name="select3" class="input_field">
                <option>最常去的店</option>
              </select>--%>
              <select id="store" name="store" class="input_field" runat="server">
                 <option value="">最常去的店</option>
              </select>
                                      
                                      
              <%--<asp:DropDownList ID="store" runat="server" CssClass="input_field"></asp:DropDownList>--%>
          </div></td>
        </tr>
        <tr>
          <td><div class="form_span flt_r">
           
          <%--<select class="input_field">
          <option>請問您半年內第幾次到hot7用餐 </option>
          <option value="0">無</option>
	      <option value="1">1次</option>
	      <option value="2">2次</option>
	      <option value="3">3次</option>
	      <option value="4">4次</option>
	      <option value="5">5次</option>
	      <option value="6">6次以上</option>
          </select>--%>
          <asp:DropDownList ID="times" runat="server" CssClass="input_field">
          <asp:ListItem value="">請問您半年內第幾次到hot7用餐</asp:ListItem>
          <asp:ListItem value="0">無</asp:ListItem>
          <asp:ListItem value="1">1次</asp:ListItem>
          <asp:ListItem value="2">2次</asp:ListItem>
          <asp:ListItem value="3">3次</asp:ListItem>
          <asp:ListItem value="4">4次</asp:ListItem>
          <asp:ListItem value="5">5次</asp:ListItem>
          <asp:ListItem value="6">6次以上</asp:ListItem>
          </asp:DropDownList>
          
          
          </div>
          </td>
        </tr>
        
        
        
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>優惠訊息</div>
          <div class="form_span flt_r">
              <asp:CheckBox ID="CheckBox_v1" runat="server" Checked="true"/>願意收到hot7優惠<br>
              <asp:CheckBox ID="CheckBox_v2" runat="server" Checked="true"/>願意收到本公司所有餐廳優惠
          </div></td>
        </tr>
        
        
        
        
        
        <tr>
        <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i><span class="member_p1">請詳細閱讀</span>
        <a href="member/rights.html" target="_blank" class="member_p1">隱私權條款</a>
        <asp:CheckBox ID="rule" runat="server" /><label>&nbsp;我已閱讀，充分了解並同意</label>
        </div>
        </td>
        </tr>
        
        
        <tr>
          <td>
          <div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>驗證碼</div>
          <div class="flt_l form_tx"> (請輸入圖片中文字，不分大小寫)</div>  
         
         
          <%--認證碼欄位/更換圖片--%>        
          <div class="flt_l">
          <asp:TextBox ID="code" runat="server" MaxLength="5" size="15"></asp:TextBox><br>
          <a href="javascript:;" onclick="document.getElementById('imgcode').contentWindow.location.reload();" >更換別組圖示</a>
          </div>
          
          <%--認證碼圖片--%>
          <div class="flt_l form_tx">
          <%--<img src="m/images/code/check_bg8.gif" width="120" height="50" id="checkcode"/> --%>
          <iframe name="imgcode" id="imgcode" src="member/img/code.aspx"  scrolling="no" frameborder="0">
          </iframe></div>
          
          </td>
        </tr>

        
       
        
        <tr>
          <td>
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
