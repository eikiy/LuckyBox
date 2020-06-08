<%@ Page Language="C#" AutoEventWireup="true" CodeFile="storeInfo.aspx.cs" Inherits="en_storeInfo" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en" xml:lang="en">
    <head>
	<!-- Title and Meta
	================================================== -->
	<meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge" />
	<meta http-equiv="X-UA-Compatible" content="IE=9" />
	<title>王品│只款待心中最重要的人</title>
	<meta name="author" content="">
	<meta name="description" content="" />
	<meta name="keywords" content="" />
	
	<meta name="viewport" content="width=device-width, initial-scale=1, user-scalable=no">
	<link rel="stylesheet" type="text/css" href="styles/bootstrap.css">
	<link rel="stylesheet" type="text/css" href="styles/style.css">
	<!--[if lt IE 9]>
	    <script src="scripts/default/html5shiv.min.js"></script>
	    <script src="scripts/default/respond.min.js"></script>
	<![endif]-->
	<script src="scripts/default/modernizr.js"></script>
	<script src="scripts/js.js"></script>
	<script src='scripts/plugins/wow.min.js'></script>
<!--官網ga-->
  <script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','https://www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-2488495-1', 'auto');
  ga('send', 'pageview');

  </script>
<!--end官網ga-->
    </head>
    <body class="en">
     <form id="form2" runat="server">
        <div class="wp page">
			<header id="header">
				<div pload="pmenu_1.html"></div>
				
				<div class="banner">
					<div class="slogo wow fadeIn center">
						<h1 class="title-en">
							<div>Stores</div>
						</h1>
					</div>
					<div class="bannerimg" data-focus-x="0" data-focus-y="0" style="background-image: url(styles/images/store-banner.jpg)"></div>
				</div>
			</header>
            <!--main ================================================== -->
            <div id="main" class="page-store lineBk bg2">
                <section class="section box1">
                    <div class="container">
                        <div class="hd">
                            <h2 class="title wow fadeInDown">Branches</h2>
                            <ol class="nav columns inline">
                                <li>
                                    <a href="#store1">North Taiwan</a>
                                </li>
                                <li>
                                    <a href="#store2">Central Taiwan</a>
                                </li>
                                <li>
                                    <a href="#store3">South Taiwan</a>
                                </li>
                            </ol>
                        </div>
                        <div class="info2">
                        
                        <%--
                            <h3 id="store1">North</h3>
                            <div class="list-item clear auto">
                                <div class="view left jqimgFill">
                                    <img src="../styles/images/1505754adc60000003e4.JPG" alt="" />
                                </div>
                                <div class="txt right">
                                    <h4>Zhongshan N. Branch</h4>
                                    <dl class="dl-horizontal">
                                        <dt>Address</dt>
                                        <dd class="mpat">2F., No.33, Sec. 2, Zhongshan N. Rd., Zhongshan Dist., Taipei City</dd>
                                        <dt>Phone</dt>
                                        <dd>+886 2-2536-1350</dd>
                                        <dt>Hours</dt>
                                        <dd>Noon：11:30~14:30
                                        <br>Evening：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                        </dd>
                                        <dt>Parketing LOT</dt>
                                        <dd>2 hours of free parking for all customers with receipts.</dd>
                                        <dt>Features</dt>
                                        <dd>5 min. walk from MRT Jhongshan Station</dd>
                                    </dl>
                                </div>
                            </div>
                            <div class="list-item clear auto">
                                <div class="view left jqimgFill"><img src="../styles/images/Image 001.png" width="1058" height="836" alt="" />
                                </div>
                                <div class="txt right">
                                    <h4>Taipei Nanjing E. Branch</h4>
                                    <dl class="dl-horizontal">
                                        <dt>Address </dt>
                                        <dd>No.169, Sec. 4, Nanjing E. Rd., Songshan Dist., Taipei City</dd>
                                        <dt>Phone</dt>
                                        <dd>+886 2-2325-3478</dd>
                                        <dt>Hours</dt>
                                        <dd>Noon：11:30~14:30
                                        <br>Evening：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                        </dd>
                                        <dt>Parketing LOT</dt>
                                        <dd>2 hours of free parking for all customers with receipts.</dd>
                                        <dt>Features</dt>
                                        <dd>15 min. walk from TAIPEI 101 Mall</dd>
                                    </dl>
                                </div>
                            </div>
                            <div class="list-item clear auto">
                                <div class="view left jqimgFill"><img src="../styles/images/Image 002.png" width="1197" height="780" alt="" />
                                </div>
                                <div class="txt right">
                                    <h4>Heping E Branch</h4>
                                    <dl class="dl-horizontal">
                                        <dt>Address </dt>
                                        <dd>No.177, Sec. 1, Heping E. Rd., Da’an Dist., Taipei City</dd>
                                        <dt>Phone</dt>
                                        <dd>+886 2-2393-4689</dd>
                                        <dt>Hours</dt>
                                        <dd>Noon：11:30~14:30
                                        <br> Evening：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                        </dd>
                                        <dt>Parketing LOT</dt>
                                        <dd>2 hours of free parking for all customers with receipts.</dd>
                                        <dt>Features</dt>
                                        <dd>3 min. walk from National Taiwan Normal University</dd>
                                    </dl>
                                </div>
                            </div>
                            <h3 id="store2">Central</h3>
                            <div class="list-item clear auto">
                                <div class="view left jqimgFill"><img src="../styles/images/Image 003.png" width="1397" height="938" alt="" />
                                </div>
                                <div class="txt right">
                                    <h4>Taichung Wuquan Branch</h4>
                                    <dl class="dl-horizontal">
                                        <dt>Address </dt>
                                        <dd>No.131, Wuquan Rd., West Dist., Taichung City</dd>
                                        <dt>Phone</dt>
                                        <dd>+886 4-2201-2012</dd>
                                        <dt>Hours</dt>
                                        <dd>Noon：11:30~14:30
                                        <br> Evening：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                        </dd>
                                        <dt>Parketing LOT</dt>
                                        <dd>2 hours of free parking for all customers with receipts.</dd>
                                    </dl>
                                </div>
                            </div>
                            <h3 id="store3">South</h3>
                            <div class="list-item clear auto">
                                <div class="view left jqimgFill"><img src="../styles/images/Image 003.png" width="1397" height="938" alt="" />
                                </div>
                                <div class="txt right">
                                    <h4>Tainan Zhonghua E. Branch</h4>
                                    <dl class="dl-horizontal">
                                        <dt>Address </dt>
                                        <dd>1F., No.92, Sec.1, Zhonghua E Rd., East Dist., Tainan City</dd>
                                        <dt>Phone</dt>
                                        <dd>+886 6-275-8979</dd>
                                        <dt>Hours</dt>
                                        <dd>Noon：11:30~14:30
                                        <br> Evening：17:30~22:00
                                        <br>
                                        <span class="red">*國定/例假日，彈性延長 服務時間</span>
                                        </dd>
                                        <dt>Parketing LOT</dt>
                                        <dd>2 hours of free parking for all customers with receipts.</dd>
                                    </dl>
                                </div>
                            </div>
                        --%>
                        
                        
                        
                         <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>
                          <br>
                          <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
                          <br>

                        
                        <img src="https://wowapp.wowprime.com/static/upload/store/155299d7715000002e95.png" alt="" />
                        </div>
                    </div>
                </div>
            </section>
        </div>
        <!-- / main ================================================== -->
        <div pload="footer.html"></div>
</form>
</body>
</html>
