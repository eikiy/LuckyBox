<%@ Page Language="C#" AutoEventWireup="true" CodeFile="edit.aspx.cs" Inherits="edit" %>
<!DOCTYPE html>
<html lang="zh-tw">
<head>
<meta charset="utf-8">
<title>藝奇</title>
<meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable=0;">
<meta name="apple-mobile-web-app-capable" content="yes">
<link rel="stylesheet" type="text/css" href="css/style_edit.css">
<script src="http://code.jquery.com/jquery-1.10.1.min.js"></script>
<script src="js/edit.js"></script>
</head>
<body>
<form id="form1" name="form1" method="post" action="edit.aspx" onSubmit="return checkdata(this);" runat="server">
<input id="hide_year2" name="hide_year2" type="hidden" value="" runat="server">
<input id="hide_month2" name="hide_month2" type="hidden" value="" runat="server">
<input id="hide_day2" name="hide_day2" type="hidden" value="" runat="server">
<script language="javascript">
    $(function(){
        var selectObj = document.form1.year2;
		for (var i = 0; i < selectObj.length; i++) {
			if (selectObj[i].text == $("#hide_year2").val())
				selectObj[i].selected = true;
			else
				selectObj[i].selected = false;
		}
		
		if (selectObj.value == "")
		{
			selectObj[0].selected = true;
		}
		
		selectObj = document.form1.month2;
		for (var i = 0; i < selectObj.length; i++) {
			if (selectObj[i].text == $("#hide_month2").val())
				selectObj[i].selected = true;
			else
				selectObj[i].selected = false;
		}
		
		if (selectObj.value == "")
		{
			selectObj[0].selected = true;
		}
		
		selectObj = document.form1.day2;
		for (var i = 0; i < selectObj.length; i++) {
			if (selectObj[i].text == $("#hide_day2").val())
				selectObj[i].selected = true;
			else
				selectObj[i].selected = false;
		}
		
		if (selectObj.value == "")
		{
			selectObj[0].selected = true;
		}
    });
</script>
<div id="warp">
  <div id="main">
  	<div id="logo"><img src="images/logo.png" width="320" height="72" border="0" usemap="#Map"></div>
  	<div id="header">
    	<div class="txt">修改會員資料</div>
        <div class="line"></div>
        <div class="txt2">必填</div>
    
    </div>
  	<div id="edit1">
    	<div class="line">
        	<div class="name"><input name="name" type="text" id="name" style="width:178px; height:20px; border:none;padding-left:0px; " maxlength="50" runat="server" /></div>
            
        </div>
        <div class="line">
          <div class="fields"><input name="nickname" type="text" id="nickname" style="width:178px; height:20px; border:none;" value="" maxlength="50" runat="server" /></div>
        </div>
        <div class="line" style="display:none">
        	<div class="email" style="display:none"><input name="email" type="text" id="email" style="width:170px; height:20px; border:none;" onBlur="checkuser();" maxlength="80" runat="server" /></div>
        </div>
      <div class="line">
      	<div class="fields">
        <div style="margin-left:20px; margin-top:0px;"><select name="year2" class="select3" 
                style="width:70px;" runat="server" id="year2">
          <option value="">年</option>
        </select>
        <select name="month2" class="select3" style="width:60px;" runat="server" 
                id="month2">
          <option value="">月</option>
        </select>
        <select name="day2" class="select3" style="width:60px;" runat="server" id="day2">
          <option value="">日</option>
        </select></div>
        
        </div>
      </div>
       <div class="line">
      	<div class="fields"><input name="mobile" type="text" id="mobile" style="width:210px; height:20px; border:none;" maxlength="10" runat="server" /></div>
      </div>
      <div class="line">
      	<div class="fields">
        	<div style="margin-left:2px; margin-top:0px; text-align:left">
        	<input name="phone1" type="text" id="phone1" style="width:30px; height:20px; border:none;" size="4" maxlength="4" runat="server" />-<input name="phone2" type="text" id="phone2" style="width:70px; height:20px; border:none;" size="8" maxlength="8" runat="server" />#<input name="phone3" type="text" id="phone3" style="width:40px; height:20px; border:none;" size="5" maxlength="5" runat="server" />
       	  	</div>
        </div>
      </div>
      
      <div class="line">
      	<div class="city"><select id="city" name="city" class="select2" style="width:130px; border:none;" onChange="get_zipcode(this.value);">
      	  <option value="">縣市</option>
          <asp:Literal ID="LiteCity" runat="server"></asp:Literal>
      	</select></div>
        <div class="zone"><select id="zipcode" name="zipcode" class="select2" style="width:88px; border:none;">
          <option value="">行政區</option>
          <asp:Literal ID="LiteZipcode" runat="server"></asp:Literal>
        </select></div>
      </div>
      <div class="line2">
      	<div class="addr"><input name="address" type="text" id="address" style="width:260px; height:20px; border:none;" value="" maxlength="500" runat="server" /></div>
      </div>
     </div>
    
    
    <div id="edit2">
      <div class="line">
      	<div class="pwd"><asp:Literal ID="LitePwd" runat="server"></asp:Literal></div>
      </div>
      <div class="line">
      	<div class="chk_pwd"><asp:Literal ID="LiteChkPwd" runat="server"></asp:Literal></div>
      </div>
    </div>
    
    <div id="edit3">
        <div class="line">
       	  <div class="txt">願意收到藝奇優惠</div>
            <asp:Literal ID="LiteEdm1" runat="server"></asp:Literal>
        </div>
        <div class="line">
       	  <div class="txt2">願意收到本公司所有餐廳優惠</div>
            <asp:Literal ID="LiteEdm2" runat="server"></asp:Literal>
        </div>
    </div>
    
    
    <div id="button">
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/button.png" 
            onclick="ImageButton1_Click" />
    </div>
    <div id="footer">
   	  <div class="txt1"><img src="images/footer2.png" width="320" height="140" border="0" usemap="#Map2"></div>
      <div class="txt2">‧檢視: 手機版 | <a href="http://www.ikki.com.tw/index.html?m=1">電腦版</a></div>
      
    </div>
    
  </div>
  
</div>
</form>
<map name="Map">
   <area shape="rect" coords="247,11,275,29" href="index.htm">
</map>
<map name="Map2">
    <area shape="rect" coords="108,79,261,93" href="mailto:service@ikki.com.tw">
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