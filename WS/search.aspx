<%@ Page Language="C#" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<!DOCTYPE html>
<html lang="zh-TW" xml:lang="zh-TW">
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
</head>

<body>

    <div class="wp page">
		<header id="header">
			<div pload="pmenu_1.html"></div>

			<div class="banner">
				<div class="slogo wow fadeIn center">
					<h1 class="title-en">
						<div>Voucher inquiry</div>
					</h1>
				</div>
				<div class="bannerimg" data-focus-x="0" data-focus-y="0" style="background-image: url(styles/images/voucher-banner.jpg)"></div>
			</div>
		</header>
        <!--main ================================================== -->
        <div id="main" class="page-memberReissue lineBk">
            <section class="section box1">
                <div class="container sm">
                    <div class="hd">
                        <h2 class="title  wow fadeInDown">禮券查詢</h2>
                        <p class="wow fadeInUp">請輸入正確之禮券編號，謝謝！</p>
                        <p class="note">ex : 3012010501</p>
                    </div>
                    <div class="info clear">
                        <form class="form" runat=server>
                            <div class="form-group row">
                                <label for="mail" class="col-sm-2 control-label col-sm-offset-2">禮券編號</label>
                                <div class="col-sm-5">
                                    <%--<input type="text" class="form-control w100" id="mail">--%>
                                    <asp:TextBox ID="txtCode" runat="server" MaxLength="10" 
                                        CssClass="form-control w100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-12">
                                    <div class="btnwp">
                                        <%--<button type="submit" class="btn btn-primary">確認送出</button>--%>

                                        <asp:Button ID="Button1" runat="server" Text="確認送出" CssClass="btn btn-primary" 
                                            onclick="Button1_Click"></asp:Button>
                                    </div>
                                </div>
                            </div>
                        <div class="form-group">
                        </div>
                        <div class="text" align="center">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White"
                            BorderColor="LightGray"  >
                            <Columns>
                                <asp:BoundField DataField="CuponNo" HeaderText="禮卷編號" />
                                <asp:BoundField DataField="Price" HeaderText="面額" />
                                <asp:BoundField DataField="SalesDate" HeaderText="銷售日期" />
                                <asp:BoundField DataField="Status" HeaderText="禮券狀態" />
                                <asp:BoundField DataField="RetDate" HeaderText="保證截止" />
                                <asp:BoundField DataField="BankName" HeaderText="保證銀行" />
                            </Columns>
                            <HeaderStyle BorderColor="Transparent" BackColor="LightGray" Height="20px" HorizontalAlign="Center" />
                        </asp:GridView>
                        </div>
                        
                        
                        
                        </form>
                        
                        
                        
                    </div>
                    <div class="oter">
                        <h3>Notice</h3>
                        <ul>
                            <li>本公司所有銷售之禮券無使用期限。</li>
                            <li>本公司自2009/2/01起，已依行政院衛生署『餐飲業等商品（服務）禮券定型化契約』規定，對當日起銷售之禮券由銀行提供履約保證責任。</li>
                            <li>凡持本公司所發行乙張商品禮券，可享有禮券所記載之套餐乙客(已含服務費)。</li>
                            <li>本商品禮券若因季節更替調整菜單或營業型態改變，可兌換等值商品；但不同價格之套餐不在此限，須補足禮券面額之差額始能兌換。</li>
                            <li>本商品禮券如有遺失、被竊或毀損，變形致無法辨識者，概不掛失或補發，但本商品禮券如因毀損或變形，而其重要內容仍可辨認者，得請求交付商品或換發。</li>
                            <li>本商品禮券出售時已開立統一發票，兌換商品時則不再開立發票。</li>
                            <li>本商品禮券經店鋪蓋作廢章後，則視同已兌換，不得再重覆使用。</li>
                            <li>本商品禮券出售後若欲辦理禮券退回時，請持禮券及原購買禮券發票或消費明細至原購買門市辦理，並以禮券所載之面額為之；非直接向門市購買者，請向原購買單位辦理。</li>
                            <li>若買受人為個人且該交易金額全數退回，需收回原始發票並開立退貨折讓單。</li>
                            <li>若買受人為個人且該交易金額部份退回，直接開立退貨折讓單。</li>
                            <li>若買受人為公司請開立退貨折讓單，並需加蓋公司代表章。</li>
                            <li>退貨價格有面額以面額金額退款，無面額依原始出售金額為退款。</li>
                            <li>以信用卡購買者，由店舖辦理信用卡退刷，將款項退回原信用卡帳戶；依信用卡作業規定，恕無法以現金退還。</li>
                            <li>以現金購買者，如門市現金不足時，將由總公司代匯款至指定帳戶。</li>
                        </ul>
                    </div>
            </section>
            </div>
            <!-- / main ================================================== -->
            <div pload="footer.html"></div>
        </div>
</body>

</html>

