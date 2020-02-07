<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="register" %>
<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<meta http-equiv="Pragma" content="no-cache" />
<meta http-equiv="Cache-Control" content="no-cache" />
<meta http-equiv="Expires" content="0" />
<link rel="stylesheet" type="text/css" href="css/style.css">
<script src="https://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="js/reg.js"></script>
</head>

<body>
<form id="form1" name="form1" method="post" action="register.aspx" onSubmit="return checkdata();" runat="server">
<input id="sex" name="sex" type="hidden" value="">
<input id="edm1" name="edm1" type="hidden" value="v1">
<input id="edm2" name="edm2" type="hidden" value="v2">
<div id="warp">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="header">
    	<div class="txt">加入會員</div>
        <div class="line"></div>
        <div class="txt2">必填</div>
  	</div>
  	<div id="login1">
    	<div class="line">
        	<div class="name"><input name="name" type="text" id="name" style="width:120px; height:20px; border:none;" maxlength="50" runat="server" /></div>
          <div class="sex1"><a href="javascript:change_sex('woman');"><img src="images/woman.png" name="woman" width="35" height="39" id="woman" border="0"></a></div>
        <div class="sex2"><a href="javascript:change_sex('man');"><img src="images/man.png" name="man" width="37" height="39" id="man" border="0"></a></div>
        </div>
        <div class="line">
          <div class="fields"><input name="nickname" type="text" id="nickname" style="width:215px; height:20px; border:none;" value="" maxlength="50" runat="server" /></div>
        </div>
        <div class="line">
        	<div class="email"><input name="email" type="text" id="email" style="width:180px; height:20px; border:none;" maxlength="80" runat="server" onBlur="checkuser();" /></div>
        </div>
      <div class="line">
        <div class="birthday"><div style="margin-left:40px; margin-top:3px;">
        <select name="year1" class="select3" style="width:70px;" id="year1" runat="server">
          <option value="">年</option>
        </select>
        &nbsp;<select name="month1" class="select3" style="width:60px;" id="month1" runat="server">
          <option value="">月</option>
        </select>
        &nbsp;<select name="day1" class="select3" style="width:60px;" id="day1" runat="server">
          <option value="">日</option>
        </select></div></div>
      </div>
      
      <div class="line">
      	<div class="birthday"><div style="margin-left:40px; margin-top:3px;">
        <select name="year2" class="select3" style="width:70px;" id="year2" runat="server">
          <option value="">年</option>
		</select>
        &nbsp;<select name="month2" class="select3" style="width:60px;" id="month2" runat="server">
          <option value="">月</option>
        </select>
        &nbsp;<select name="day2" class="select3" style="width:60px;" id="day2" runat="server">
          <option value="">日</option>
        </select></div>
        </div>
        
      </div>
       <div class="line">
      	<div class="fields"><input name="mobile" type="text" id="mobile" style="width:215px; height:20px; border:none;" maxlength="10" runat="server" /></div>
      </div>
      
      <div class="line">
      	<div class="city"><select id="city" name="city" class="select2" style="width:130px;" onChange="get_zipcode(this.value);" runat="server">
      	  <option value="">縣市</option>
      	</select>
      	
      	</div>
        <div class="zone"><select id="zipcode" name="zipcode" class="select2" style="width:88px;" runat="server">
          <option value="">行政區</option>
        </select></div>
      </div>
      <div class="line2">
      	<div class="addr"><input name="address" type="text" id="address" style="width:250px; height:20px; border:none;" value="" maxlength="500" runat="server" /></div>
      </div>
     </div>
    
    
    <div id="login2">
      <div class="line">
      	<div class="pwd"><input name="pwd" type="password" id="pwd" style="width:150px; height:20px; border:none;" maxlength="8" runat="server" /></div>
      </div>
      <div class="line">
      	<div class="chk_pwd"><input name="chk_pwd" type="password" id="chk_pwd" style="width:185px; height:20px; border:none;" maxlength="8" runat="server" /></div>
      </div>
    </div>
    
    <div id="login3">
    	<div class="line">
        	<div class="job"><select id="job" name="job" class="select" runat="server">
        	    <option value="">職業</option>
                <option value="1">企業負責人</option>
                <option value="2">中高階層主管</option>
                <option value="3">基層主管</option>
                <option value="4">一般職員</option>
                <option value="5">家管</option>
                <option value="6">學生</option>
                <option value="7">其他</option>
       	  </select></div>
        </div>
        <div class="line">
        	<div class="fields"><select id="education" name="education" class="select" runat="server">
        	  <option value="">教育程度</option>
        	  <option value="14">國中以下</option>
                <option value="9">高中職</option>
                <option value="10">專科</option>
                <option value="11">大專院校</option>
                <option value="12">研究所</option>
                <option value="13">其他</option>
   	      </select></div>
        </div>
        <div class="line">
        	<div class="fields"><select id="store" name="store" class="select" runat="server">
        	  <option value="">最常去的店</option>
       	  </select> </div>
        </div>
        <div class="line">
        	<div class="fields"><select id="times" name="times" class="select" runat="server">
        	  <option value="">請問您半年內第幾次到藝奇用餐</option>
        	  <option value="0">無</option>
        	  <option value="1">1次</option>
        	  <option value="2">2次</option>
        	  <option value="3">3次</option>
        	  <option value="4">4次</option>
        	  <option value="5">5次</option>
        	  <option value="6">6次以上</option>
   	      </select></div>
        </div>
        <div class="line">
       	  <div class="txt">願意收到藝奇優惠</div>
            <div class="checkbox1"><a href="javascript:change_checkbox('v1', 'x1');"><img id="v1" src="images/v-2.png" width="21" height="24" border="0"></a></div>
          <div class="checkbox2"><a href="javascript:change_checkbox('x1', 'v1');"><img id="x1" src="images/x.png" width="21" height="24" border="0"></a></div>
        </div>
        <div class="line">
       	  <div class="txt">願意收到本公司所有餐廳優惠</div>
            <div class="checkbox1"><a href="javascript:change_checkbox2('v2', 'x2');"><img id="v2" src="images/v-2.png" width="21" height="24" border="0"></a></div>
          <div class="checkbox2"><a href="javascript:change_checkbox2('x2', 'v2');"><img id="x2" src="images/x.png" width="21" height="24" border="0"></a></div>
        </div>
    </div>
    <div id="login4">
    	<div class="img"><iframe name="imgcode" id="imgcode" src="code.aspx" width="120" height="50" scrolling="no" frameborder="0"></iframe></div>
        <div class="img_txt"><a href="javascript:;" onClick="document.getElementById('imgcode').contentWindow.location.reload();"><u>更換別組圖示</u></a><br><span style="color:#3e3e3e"> (不分大小寫)</span></div>
    	<div class="line">
        <div class="txt"><input name="code" type="text" id="code" style="width:200px; height:20px; border:none;" maxlength="5" runat="server" /></div>
        </div>
    </div>
    
    <div id="button">
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/button.png" OnClick="ImageButton1_Click" />
    </div>
    
    <div id="rule"><img src="images/rule.png" width="245" height="13" border="0" usemap="#Map3">
    </div>
    
    <div id="footer">
   	  <div class="txt1"><img src="images/footer.png" width="320" height="116" border="0" usemap="#Map2"></div>
      <div class="txt2">(訂位請撥各店電話)‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
      
    </div>
    
  </div>
  
</div>
</form>
<map name="Map">
   <area shape="rect" coords="246,10,276,33" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="106,77,263,91" href="mailto:service@ikki.com.tw">
</map>
 <map name="Map3">
        <area shape="rect" coords="70,0,138,11" href="http://www.ikki.com.tw/rights.htm" target="_blank">
      </map>
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