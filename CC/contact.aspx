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
    	  <li class="navAbout"><a href="about.html"></a></li>
          <li class="navProduct"><a href="product.html"></a></li>
          <li class="navApplication">
          <a href="application.aspx"></a>
          </li>
          <li class="navTech"><a href="tech.html"></a></li>
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
            <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3613.4925910138845!2d121.38148965089178!3d25.085181542312355!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3442a6ec053e7055%3A0x6f9611b072512525!2zMjQ05paw5YyX5biC5p6X5Y-j5Y2A5a-25p6X6LevMTA26Jmf!5e0!3m2!1szh-TW!2stw!4v1475494242661" width="370" height="220" frameborder="0" style="border:0" allowfullscreen></iframe>
            <br />
           <p> 康辰國際股份有限公司   KANG CHEN International Co.,Ltd.<br />
            T E L&nbsp;&nbsp;&nbsp; 02-8601-1589 <br />
            F A X&nbsp;&nbsp;&nbsp; 02-8601-1969<br />
            E-Mail&nbsp;&nbsp;<a href="mailto:kangchen5568@gmail.com">kangchen5568@gmail.com</a><br />
            地&nbsp;&nbsp;&nbsp;&nbsp;址         新北市林口區寶林路106-5號<br/>
            <br/>
            加工廠商 <br />
            <a href="http://www.comfortchic.com.tw" target="_new">連程實業</a> (02)2900-8756<br />
            東拓企業有限公司 (03)324-0667<br />
            南竹興有限公司     (07)352-9162<br />
            研強企業股份有限公司</a>(04)2335-8809 <br />
                峻晟實業股份有限公司(02)2608-0192 <br />  <br />

            </p><br /><br />
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
