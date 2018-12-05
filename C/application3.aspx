<%@ Page Language="C#"  ValidateRequest="false" AutoEventWireup="true" CodeFile="application3.aspx.cs" Inherits="application3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
<head>
		<title>COMPAC</title>
		<link rel="shortcut icon" href="images/favicon.ico" type="images/favicon.ico"> 
        <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
		<link rel="stylesheet" href="css/supersized.css" type="text/css" media="screen" />
		<link rel="stylesheet" href="theme/supersized.shutter.css" type="text/css" media="screen" />
	    <link href="css/layout.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8/jquery.min.js"></script>
		<script type="text/javascript" src="js/jquery.easing.min.js"></script>
		<script type="text/javascript" src="js/menu.js"></script>
		<script type="text/javascript" src="js/supersized.3.2.7.min.js"></script>
		<script type="text/javascript" src="theme/supersized.shutter.min.js"></script>
		
		
    <asp:Literal ID="lt_img" runat="server"></asp:Literal>
    
    
    
    

	</head>
	
	 <style type="text/css">
        ul#demo-block {
            margin: 0 15px 15px 15px;
        }

            ul#demo-block li {
                margin: 0 0 10px 0;
                padding: 10px;
                display: inline;
                float: left;
                clear: both;
                color: #aaa;
                background: url('img/bg-black.png');
                font: 11px Helvetica, Arial, sans-serif;
            }

                ul#demo-block li a {
                    color: #eee;
                    font-weight: bold;
                }
    </style>


<body>
	<!--文字區塊-->
   <div class="shop">
        <div class="title"></div>
        <div class="text"></div>
    </div>
	<!--選單列-->
    <div class="nav" id="menunav">
    	<h1><a href="index.html"></a></h1>
        <ul>
    	  <li class="navAbout"><a href="about.html">公司簡介</a></li>
          <li class="navProduct"><a href="product.html">產品介紹</a></li>
          <li class="navApplication">
	          <a>產品應用</a>
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



	<!--Thumbnail Navigation-->
	<div id="prevthumb"></div>
	<div id="nextthumb"></div>
	
	<!--Arrow Navigation-->
    <!--
	<a id="prevslide" class="load-item"></a>
	<a id="nextslide" class="load-item"></a>
    -->
	
  <div id="thumb-tray" class="load-item">
		<div id="thumb-back"></div>
		<div id="thumb-forward"></div>
	</div>
	
	<!--Time Bar-->
	<!--<div id="progress-back" class="load-item">
		<div id="progress-bar"></div>
	</div>
	
	<!--Control Bar-->
   <div id="controls-wrapper" class="load-item">
		<div id="controls">
			
			<!--<a id="play-button"><img id="pauseplay" src="img/pause.png"/></a>-->
		
			<!--Slide counter
		<div id="slidecounter">
				<span class="slidenumber"></span><span class="totalslides"></span>
			</div>-->
			
			
			<!--Thumb Tray button-->
			<a id="tray-button"><img id="tray-arrow" src="img/button-tray-up.png"/></a>
			
			<!--Navigation
			<ul id="slide-list"></ul>-->
			
		</div>
</div>
	
<!--	<div class="footer"><p class="copyright">©COMPAC.ALL Rights Reserved</p></div>-->

</body>
</html>
