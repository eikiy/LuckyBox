<%@ Page Language="C#"  ValidateRequest="false" AutoEventWireup="true" CodeFile="contact.aspx.cs" Inherits="contact" %>

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
    	<h1><a href="index.html"></a></h1>
        <ul>
        <li class="navAbout"><a href="about.html">公司簡介</a></li>
          <li class="navProduct"><a href="product.html">產品介紹</a></li>
          <li class="navApplication"><a>產品應用</a>
            <ul>
              <li><a href="application1.aspx">居家應用</a></li>
              <li><a href="application2.aspx">商業空間</a></li>
              <li><a href="application3.aspx">康沛石專賣店</a></li>
              <li><a href="application4.aspx">活動紀事</a></li>
            </ul>
          </li>
          <li class="navTech"><a href="tech.html">技術規格</a></li>
          <li class="navContact"><a href="contact.aspx">聯絡我們</a></li>
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
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3613.3368996270538!2d121.37124941485065!3d25.090454583945927!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442a6c0effecaab%3A0xa3e24c5c100556d3!2zMjQ05paw5YyX5biC5p6X5Y-j5Y2A5a-25p6X6LevMTA2LTXomZ8!5e0!3m2!1szh-TW!2stw!4v1543928264548" width="370" height="220" frameborder="0" style="border:0" allowfullscreen></iframe>
            <br />
           <p> 康辰國際股份有限公司   KANG CHEN International Co.,Ltd.<br />
            T E L&nbsp;&nbsp;&nbsp; 02-8601-1589 <br />
            F A X&nbsp;&nbsp;&nbsp; 02-8601-1969<br />
            E-Mail&nbsp;&nbsp;<a href="mailto:kangchen5568@gmail.com">kangchen5568@gmail.com</a><br />
            地&nbsp;&nbsp;&nbsp;&nbsp;址         新北市林口區寶林路106-5號<br/>
            <br/>
            加工廠商<br>
            <b>北區</b><br />
            <a href="http://www.comfortchic.com.tw" target="_blank">連程實業</a> (02)2900-8756<br />
            田益實業有限公司 (03)928-2316<br />
            旺昌有限公司 (02)2602-1090<br />
            <a href="http://tongguh.com.tw" target="_blank">東固企業有限公司</a> (02)2909-0773<br />
            <a href="http://www.oecl.com.tw" target="_blank">東拓專業石英石加工</a> (03)324-0667<br />
            峻晟實業股份有限公司 (02)2608-0192-3<br />
            原創石材有限公司 (02)2608-9061-2<br />
            特葉有限公司 (03)359-7171<br />
            <br />
            <b>中區</b><br />
            峻砷實業有限公司 (04)887-6956<br />
            研強企業股份有限公司 (04)2335-8809 <br />
            龍樺石英加工廠 (049)256-3176<br />
            <br />
            <b>南區</b><br />
            峻益興業有限公司 (06)205-3386<br />
            基佳建材有限公司 (07)614-3243<br />
            </p>
          </div>
</asp:Panel>
          </form>
  </div>	<!---contact end-->

    <div class="footer">
      <p class="copyright">©COMPAC.ALL Rights Reserved</p>
    </div><!--footer end-->
</div><!--wrapper end-->
</body>
</html>
