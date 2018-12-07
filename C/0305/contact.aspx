﻿<%@ Page Language="C#"  ValidateRequest="false" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<link rel="shortcut icon" href="images/favicon.ico" type="images/favicon.ico"> 
<link href="css/layout.css" rel="stylesheet" type="text/css" />
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8/jquery.min.js"></script>
<script type="text/javascript" src="js/supersized.2.0.js"></script>
<script type="text/javascript" src="js/background_trans.js"></script>
<script type="text/javascript" src="js/menu.js"></script>
<script type="text/javascript" src="js/contact.js"></script>
<!---->
     <link href="css/antiscroll.css" rel="stylesheet" type="text/css" />
    <script src="js/jquery-mousewheel.js"></script>
    <script src="js/antiscroll.js"></script>
<title>COMPAC</title>
</head>

<body id="contact">
<div id="wrapper">

  <div class="nav" id="menunav">
    	<h1><a href="index.aspx"></a></h1>
        <ul>
    	  <li class="navAbout"><a href="about.aspx"></a></li>
          <li class="navProduct"><a href="product.aspx"></a></li>
          <li class="navApplication">
          <a href="application.aspx"></a>
          </li>
          <li class="navTech"><a href="tech.aspx"></a></li>
          <li class="navContact"><a href="contact.aspx"></a></li>
          <li class="navScroll"></li>
    	</ul>
	</div>
  
        <!--<div id="fix_close"></div>-->
       
      
  <div class="contact">
    <div class="title2"></div>
    
<form id="contactForm" runat="server">
<asp:Panel ID="Panel1" runat="server">
      		<div class="form">
            <p class="title1"> 公司名稱<br/>
              連絡人<br/>
              電 話<br/>
              地 址<br/>
              E-mail </p>
            <p class="inputBox">
              
    <asp:TextBox ID="tb_companyName" runat="server" CssClass="input"></asp:TextBox>
    <asp:TextBox ID="tb_contact" runat="server" CssClass="input"></asp:TextBox>
    <asp:TextBox ID="tb_number" runat="server" CssClass="input"></asp:TextBox>
    <asp:TextBox ID="tb_address" runat="server" CssClass="input"></asp:TextBox>
    <asp:TextBox ID="tb_email" runat="server" CssClass="input"></asp:TextBox>
              </li>
              </ul>
            </p>
            <p class="askBox">詢問內容<br />
              
    <asp:TextBox ID="tb_ask" runat="server" CssClass="input_ask" TextMode="MultiLine"></asp:TextBox>
            <asp:LinkButton ID="lb_Ok" runat="server" CssClass="btnOK" onclick="lb_Ok_Click"></asp:LinkButton>
            </p>
          </div>
          
          <div class="address">
            <iframe width="370" height="250" frameborder="0" scrolling="no" marginheight="0" marginwidth="0" src="https://maps.google.com/maps?f=q&amp;source=s_q&amp;hl=zh-TW&amp;geocode=&amp;q=243%E6%96%B0%E5%8C%97%E5%B8%82%E6%B3%B0%E5%B1%B1%E5%8D%80%E5%85%A8%E8%88%88%E8%B7%AF226%E8%99%9F1%E6%A8%93&amp;sll=37.0625,-95.677068&amp;sspn=40.409448,93.076172&amp;ie=UTF8&amp;hq=&amp;hnear=%E5%8F%B0%E7%81%A3%E6%96%B0%E5%8C%97%E5%B8%82%E5%85%A8%E8%88%88%E8%B7%AF226%E8%99%9F&amp;t=m&amp;ll=25.0573,121.433258&amp;spn=0.019438,0.031672&amp;z=14&amp;iwloc=A&amp;output=embed"></iframe>
            <br />
            康辰國際股份有限公司   KANG CHEN International Co.,Ltd.<br />
            T E L&nbsp;&nbsp;&nbsp; 02-2900-5568 <br />
            F A X&nbsp;&nbsp;&nbsp; 02-2900-2268<br />
            E-Mail&nbsp;&nbsp;<a href="mailto:kangchen5568@gmail.com">kangchen5568@gmail.com</a><br />
            地&nbsp;&nbsp;&nbsp;&nbsp;址         243新北市泰山區全興路226號1樓<br/>
            <br/>
            加工廠商 <a href="http://www.comfortchic.com.tw" target="_new">連程實業</a>
            </p>
          </div>
</asp:Panel>
          </form>
  </div>	<!---contact end-->
        
    <div class="footer">
      <p class="copyright"></p>
    </div><!--footer end-->
</div><!--wrapper end-->
</body>
</html>