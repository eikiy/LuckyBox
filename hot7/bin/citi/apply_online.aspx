﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apply_online.aspx.cs" Inherits="citi_apply_online" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<HTML>
	<HEAD>
		<title>花旗饗樂生活卡</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
		<LINK href="javascript/Public.css" type="text/css" rel="stylesheet">
		<script language="JavaScript" type="text/JavaScript">
<!--



function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}
//-->
		</script>
		<link href="style.css" rel="stylesheet" type="text/css">
<style type="text/css">
<!--
body {
	background-color: #A9020A;
}
.style2 {font-size: 15px;
	font-weight: bold;
}
.style3 {color: #FFFFFF}
-->
</style></HEAD>
	<body leftmargin="0" topmargin="0">
<form id="Form1" name="form1" method="post" action="" runat="server">
			<table width="990" border="0" align="center" cellpadding="0" cellspacing="1" bgcolor="#A9020A">
				<tr>
					<td><table border="0" align="center" cellpadding="0" cellspacing="0">
							<tr>
								<td><img src="images/page_01.jpg" width="296" height="84"></td>
								<td><img src="images/page_02.gif" width="662" height="84" border="0" usemap="#Map" href="apply.htm"></td>
								<td><img src="images/page_03.gif" width="32" height="84"></td>
							</tr>
							<tr>
								<td><img src="images/page_04.jpg" width="296" height="431" border="0" usemap="#Map2"></td>
								<td bgcolor="#f3f3f3">
									<table width="600" height="203" border="0" align="center" cellpadding="0" cellspacing="10"
										bgcolor="#f3f3f3">
										<tr>
											<td><p><span class="subtitle">我有興趣辦花旗饗樂生活卡，我同意花旗銀行與我聯絡&#13;</span><br />
                                                <br />
為了提供您後續商品電話服務，於您按下「送出」時，您於上列所填寫的資料將會送予花旗銀行，由花旗銀行人員與您聯絡。花旗銀行必將以「花旗（台灣）銀行集團全球客戶隱私保護承諾」保護您個人資料安全，且於法令許可及行銷饗樂生活卡目的範圍內，在國內外蒐集、處理、利用您的個人資料。若您同意前述聲明且已詳閱並同意花旗銀行「<a href="http://www.citibank.com.tw/global_docs/chi/pressroom/infoprotect.pdf">蒐集、處理及利用個人資料告知事項</a>」
											<table width="100%" border="0" cellpadding="3" cellspacing="2">
													  <tr bgcolor="#ebebeb">
															<td>姓名</td>
															<td>
																<input type="text" name="textfield" id="txtName" runat="server">&nbsp;
																<asp:RadioButton id="radSex1" runat="server" GroupName="gupSex" Text="先生"></asp:RadioButton><FONT face="新細明體">&nbsp;
																</FONT>
																<asp:RadioButton id="radSex0" runat="server" GroupName="gupSex" Text="小姐"></asp:RadioButton></td>
														</tr>
														<tr bgcolor="#ebebeb">
															<td rowspan="2" valign="top">連絡電話</td>
															
                        <td>（O）
<input type="text" name="textfield2" id="txtOfficePhone" runat="server"> （H）
																<input type="text" name="textfield4" id="txtHomePhone" runat="server">
                          例如：02-12345678</td>
														</tr>
														<tr bgcolor="#ebebeb">
															<td>（手機） <input type="text" name="textfield3" class="AmountInputLimit" id="txtMobile" runat="server"
																	maxLength="10">
                          例如：0910123456</td>
														</tr>
														<tr bgcolor="#ebebeb">
															<td colspan="2">方便連絡時間： <input type="checkbox" name="checkbox" value="checkbox" id="cbAm" runat="server">
																上午 <input type="checkbox" name="checkbox2" value="checkbox" id="cbPm" runat="server">
																下午<INPUT id="cbNm" type="checkbox" value="checkbox" name="checkbox2" runat="server">
																晚上</td>
														</tr>
													</table>
												</p>											</td>
										</tr>
										<tr>
											<td><div align="right">
													<table width="100%" border="0" cellspacing="0" cellpadding="0">
														<tr>
															<td width="507">
																<table width="100%" border="0" cellpadding="0" cellspacing="0" bgcolor="#ff0000">
																	<tr>
																		<td width="500" height="1"></td>
																	</tr>
																</table>															</td>
															<td width="73"><asp:imagebutton id="btnSend" runat="server" BorderStyle="None" ImageUrl="images/btn_sure.gif" OnClick="btnSend_Click"></asp:imagebutton></td>
														</tr>
													</table>
												</div>											</td>
										</tr>
									</table>								</td>
								<td><img src="images/page_06.gif" width="32" height="431"></td>
							</tr>
							
						</table>
					  <table width="976" border="0" cellspacing="0" cellpadding="0">
					    <tr>
					      <td width="220">&nbsp;</td>
					      <td><iframe 
                  src="http://www.wangsteak.com.tw/citi/citi_note.html"  allowTransparency="true"name="menu" width="760" 
                  marginwidth="0"
                  height="100" marginheight="0" frameborder="0" id="menu"></iframe></td>
				        </tr>
				      </table></td>
				</tr>
	  </table>
		</form>
		<map name="Map">
			<area shape="RECT" coords="600,32,663,62" href="index.htm">
			<area shape="RECT" coords="524,35,588,61" href="QA.htm">
			<area shape="RECT" coords="421,38,514,63" href="right.htm">
			<area shape="RECT" coords="331,37,409,63" href="apply.htm">
		</map>

<map name="Map2"><area shape="rect" coords="42,387,181,430" href="../index.html" target="_blank">
</map></body>
</HTML>
