<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="event_14_fall_index" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>藝奇‧新日本料理</title>
<link type="text/css" href="css/reset.css" rel="stylesheet" />
<link type="text/css" href="css/style.css" rel="stylesheet" />

<style>
div.S 
{
    font-size:18px;
	background:;
	text-decoration:none;
	padding:7px 12px;
	color:#000;
	margin-left:135px;
	margin-rigfht:5px;
   
}
</style>

 <script language='javascript' type="text/javascript" >
     function EvImageOverChange(name, action) {
         switch (action) {
             case 'in':
                 name.style.background = "#eed81e";
                 break;
             case 'out':
                 name.style.background = "#86D72D";
                 break;
         }
     }
    </script>
</head>

<body>
    <form id="form1" runat="server">
<div id="drapper">
	<div class="main">
    	<div class="con">
            <div class="login">
            <div class="logo"><a href="/index.html"><img src="images/logo.jpg" /></a></div>
                <div class="login01">
                	<p class="texttop">11/30前憑兌換券至全台藝奇消費套餐，即可兌換創作留言板乙組</p>
                    <label class="dibm">E-mail帳號</label>
                    <asp:TextBox ID="txtEmail" runat="server" Width="180px" MaxLength="80"   class="text"></asp:TextBox>
                
                    <br>
                    <label class="dibm">密碼</label>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"  class="text"  maxlength="8" Width="180px"></asp:TextBox>
                     <br>
                   <div class="dibm"> <div class="S">                  
                       <asp:Button ID="Button1" runat="server" Text="下載兌換卷" onmouseover="EvImageOverChange(this, 'in');"
                       onmouseout= "EvImageOverChange(this, 'out');"
                          Height="40px" onclick="Button1_Click" 
                           BorderStyle="None" Width="130px" BackColor="#86D72D" Font-Size="Large" /></div>
                      </div>
                   <div class="dibm p13"> <a class="p13" target="_blank" href="/member_join.aspx">加入會員</a> | <a class="p13" target="_blank" href="/member_forget.aspx">忘記密碼</a></div>
                   <div class="textbom">
                   	※下載優惠請先登入網路會員，若您還不是我們的會員，歡迎加入，謝謝！<br/>
                   	※當您關閉此分頁時，您的會員資料將自動完成登出。謝謝！
                   </div>
                </div>
            </div>
		</div>
    </div>
    <div class="foot">
    </div>
</div>
    </form>
</body>
<script src="http://www.google-analytics.com/urchin.js" type="text/javascript">
</script>
<script type="text/javascript">
_uacct = "UA-2488504-1";
urchinTracker();
</script>
</html>
