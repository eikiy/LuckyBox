<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="event_15_spring_login" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<title>藝奇新日本料理 春祭 一起玩味</title>
<meta property="og:url" content="http://www.ikki.com.tw/event/15_spring/index.aspx"/>
<meta property="og:image" content="http://www.ikki.com.tw/event/15_spring/images/fb.gif"/>
<meta property="og:site_name" content="藝奇新日本料理 春祭。一起玩味"/>
<meta property="og:description" content="2015/4/30前分享私房賞櫻景點，即可獲得9折及好禮優惠券(價值350元)，並有機會抽中承億文旅文創旅店住宿券(價值8,888元)！ "/>
		<LINK href="css/main.css" type="text/css" rel="stylesheet">
		<LINK href="css/style.css" type="text/css" rel="stylesheet">
		<LINK href="css/fb.css" type="text/css" rel="stylesheet">        

</head>

<body style="background:none;">
<form id="form" runat="server">
<div class="keyin">
                                <table cellSpacing="0" cellPadding="0" border="0">
									<tr>
										<td>email 帳號</td>
										<td>
										
										
										
										<asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
										
										
										
										
										(請填寫藝奇會員email帳號)
										</td>
									</tr>
									<tr>
										<td align="left">密碼</td>
										<td>
										
										
							
										<asp:TextBox ID="txtPwd" runat="server" MaxLength="8" TextMode="Password" ></asp:TextBox>

										 (<A href="/member_forget.aspx" target="_blank">忘記密碼</A>)
										
										
										
										
										</td>
									</tr>
                                    <tr>
										<td align="left"><span class="font-agree">暱稱</span></td>
										<td>
										
										
							
										<asp:TextBox ID="dataName" runat="server" MaxLength="8"></asp:TextBox>

										 (限8字)
										
										
										
										
										</td>
									</tr>
                                    <tr>
										<td align="left"><span class="font-agree">我要推薦</span></td>
										<td>
										
										
							
										<asp:TextBox ID="dataPlace" runat="server" MaxLength="5"></asp:TextBox>

										 (限5字) <span class="font-agree">賞櫻最好玩!</span>
										
										
										
										
										</td>
									</tr>
									<tr>
										<td colSpan="2">
                                        	※ 參加活動請先<A href="/member_join.aspx" target="_blank">加入藝奇網路會員</A>。<br>
                                        	※ 此帳號留言成功後，將取得優惠券及抽獎資格(每帳號有一次抽獎機會)<br>
											※ 當您關閉此分頁時，您的會員資料將自動完成登出。謝謝~</td>
									</tr>
									<tr>
										<td align="center" colSpan="2"><A href="loginok.aspx#ok">
										
										
								
										
										<asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/btn_sure.gif"
										onclick="ImageButton1_Click"  width="74" height="21" />
										
										</A></td>
									</tr>
								</table>
</div>
</form>                            
</body>
</html>

