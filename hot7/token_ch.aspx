﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="token_ch.aspx.cs" Inherits="token_ch" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html>
  <head>
    <meta charset="utf-8">
    <title>禮券查詢
    </title>
    <!--theme css-->
    <link rel="stylesheet" type="text/css" media="all" href="css/bootstrap.min.css">
    <link rel="stylesheet" type="text/css" media="all" href="css/theme-animate.css">
    <link rel="stylesheet" type="text/css" media="all" href="css/style.css">
    <style type="text/css">body { 	background-image: url(images/wood.jpg); 	padding: 2em 0; 	line-height: 1.6em; } ul, ol, p { 	line-height: 1.6em; 	margin-top: 1em; 	margin-bottom: 1em; }.title { 	border-top-left-radius: 10px; 	border-top-right-radius: 10px; 	font-size: 20px; 	font-weight: bold; 	color: #FFFFFF; }.content { 	padding: 2em; 	background-image: url(images/space_trans_wht.png); } ul { 	list-style-position: outside; 	list-style-type: disc; 	margin-left: 2em; } ol { 	list-style-position: outside; 	list-style-type: decimal; 	margin-left: 2em; }.content1 {	padding: 10px 20px 15px 20px; 	background-image: url(images/space_trans_wht.png); }
    </style>
  </head>
  <body>
      <form id="form2" runat="server">
    <div class="col-lg-12 col-md-12 col-sm-12 " align="center">
      <h6 class="m_bottom_20 m_top_20">
        <div class="d_inline_m icon_wrap_size_3 bg_color_green color_light circle m_right_10 ">
          <i class="icon-bookmark-1"></i>
        </div>
        <span class="color_red d_inline_m fw_ex_bold">禮券查詢
        </span>
      </h6>
      <table width="80%" border="0" cellspacing="0" cellpadding="0">
        <tbody>
          <tr>
            <td align="left" class="content1">
              <div class="col-lg-8 col-md-8 col-sm-8 m_top_35 m_bottom_20" align="left">
                <span class=" color_dark_green m_bottom_10 m_top_10 fw_ex_bold">▌請輸入禮券號碼&nbsp;&nbsp;&nbsp;&nbsp;
                </span>
                <%--<input name="txtCode" type="text" maxlength="10" id="txtCode" class="bg_color_grey"/>--%>
                <asp:TextBox ID="txtCode" runat="server" MaxLength="10" CssClass="bg_color_grey"></asp:TextBox>
                
                &nbsp;&nbsp;(ex.0123456789)
              </div>
              <div class="col-lg-4 col-md-4 col-sm-4 m_top_20" align="center">
                <%--<button class="button_type_4 color_red r_corners tt_uppercase fs_large tr_all f_left m_right_10 m_md_bottom_10">確認送出
                </button>--%>
                  <asp:Button ID="Button1" runat="server" Text="確認送出" 
                      CssClass="button_type_4 color_red r_corners tt_uppercase fs_large tr_all f_left m_right_10 m_md_bottom_10" 
                      onclick="Button1_Click" />
              </div></td>
          </tr>
          
          <tr>
          <td align="left" class="content1">
          
          <asp:GridView ID="GridView1" runat="server" Width="600" Height="72" border="0" CellPadding="5"
                                            CellSpacing="1" bgcolor="#CCCCCC" AutoGenerateColumns="False" GridLines="None"
                                            EditRowStyle-ForeColor="Silver">
                                            <HeaderStyle CssClass="t13" BackColor="#CCCCCC" HorizontalAlign="NotSet" />
                                            <RowStyle CssClass="board_12" BackColor="#FFFFFF" />
                                            <Columns>
                                                <asp:BoundField DataField="CuponNo" HeaderText="禮券編號" />
                                                <asp:BoundField DataField="Price" HeaderText="面額" />
                                                <asp:BoundField DataField="SalesDate" HeaderText="銷售日期" />
                                                <asp:BoundField DataField="Status" HeaderText="禮券狀態" />
                                                <asp:BoundField DataField="RetDate" HeaderText="保證截止" />
                                                <asp:BoundField DataField="BankName" HeaderText="保證銀行" />
                                            </Columns>
                                            <EditRowStyle ForeColor="Silver"></EditRowStyle>
                                        </asp:GridView>
          
          </td></tr>
          
          
          
          
          <tr>
            <td align="left" class="content1">
              <ol>
                <li>本公司所有銷售之禮券無使用期限。
                </li>
                <li>本公司自2009/2/01起，已依行政院衛生署『餐飲業等商品（服務）禮券定型化契約』規定，對當日起銷售之禮券由銀行提供履約保證責任。
                </li>
                <li>凡持本公司所發行乙張商品禮券，可享有禮券所記載之套餐乙客(已含服務費)。
                </li>
                <li>本商品禮券若因季節更替調整菜單或營業型態改變，可兌換等值商品；但不同價格之套餐不在此限，須補足禮券面額之差額始能兌換。
                </li>
                <li>本商品禮券如有遺失、被竊或毀損，變形致無法辨識者，概不掛失或補發， 但本商品禮券如因毀損或變形，而其重要內容仍可辨認者， 得請求交付商品或換發。
                </li>
                <li>本商品禮券出售時已開立統一發票，兌換商品時則不再開立發票。
                </li>
                <li>本商品禮券經店鋪蓋作廢章後，則視同已兌換，不得再重覆使用。
                </li>
                <li>本商品禮券出售後若欲辦理禮券退回時，請持禮券及原購買禮券發票或消費明細至原購買門市辦理，並以禮券所載之面額為之；非直接向門市購買者，請向原購買單位辦理。
                </li>
                <li>若買受人為個人且該交易金額全數退回，需收回原始發票並開立退貨折讓單。
                </li>
                <li>若買受人為個人且該交易金額部份退回，直接開立退貨折讓單。
                </li>
                <li>若買受人為公司請開立退貨折讓單，並需加蓋公司代表章。
                </li>
                <li>退貨價格有面額以面額金額退款，無面額依原始出售金額為退款。
                </li>
                <li>以信用卡購買者，由店舖辦理信用卡退刷，將款項退回原信用卡帳戶；依信用卡作業規定，恕無法以現金退還。
                </li>
                <li>以現金購買者，如門市現金不足時，將由總公司代匯款至指定帳戶。
                </li>
              </ol>
              <h6 class="color_dark_green m_bottom_10 m_top_10 fw_ex_bold">&nbsp;
              </h6></td>
          </tr>
        </tbody>
      </table>
    </div>
    </form>
  </body>
</html>
