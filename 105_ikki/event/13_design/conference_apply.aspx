<%@ Page Language="C#" AutoEventWireup="true" CodeFile="conference_apply.aspx.cs"
    Inherits="event_13_design_conference_apply" %>

<%@ Register Assembly="System.Web.Extensions, Version=1.0.61025.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35"
    Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>藝奇 ikki 新日本料理 城市創藝 × 藝奇同饗</title>
    <link rel="stylesheet" type="text/css" href="css/main.css">
    <link rel="stylesheet" type="text/css" href="css/style.css">

    <script language='javascript' type="text/javascript">
    function EvImageOverChange(name, action)
    {   
        switch(action)
        {
            case 'in':
                name.src = "images/btn_goa.png";
            break;
            case 'out':
                name.src = "images/btn_go.png";
            break;
        }
    }
    </script>

</head>
<body>
<div style="position:absolute; top:560px; left:50%; margin-left:10px; width:476px; height:300px; background:url(images/hat_gift.png);"></div>
    <form id="form1" name="form1" method="post" action="" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" EnableScriptGlobalization="True">
        </asp:ScriptManager>
        <div class="wrapper">
            <table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <img src="images/13_design_02.jpg" border="0" usemap="#Map">
                        <map name="Map">
                            <area shape="rect" coords="0,-3,179,98" href="http://www.ikki.com.tw">
                        </map>
                    </td>
                    <td>
                        <a href="index.html">
                            <img src="images/13_design_03.jpg" onmouseover="this.src='images/13_design_03a.jpg'"
                                onmouseout="this.src='images/13_design_03.jpg'" alt="" width="78" height="98"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td>
                        <img src="images/13_design_04.jpg"></td>
                </tr>
            </table>
            <table border="0" cellpadding="0" cellspacing="0" style="*margin-top: -3px;">
                <tr>
                    <td>
                        <a href="redblack.html">
                            <img src="images/13_design_06.jpg" onmouseover="this.src='images/13_design_06a.jpg'"
                                onmouseout="this.src='images/13_design_06.jpg'" alt="" width="170" height="80"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td>
                        <a href="hat.html">
                            <img src="images/13_design_07.jpg" onmouseover="this.src='images/13_design_07a.jpg'"
                                onmouseout="this.src='images/13_design_07.jpg'" alt="" width="160" height="80"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td>
                        <a href="art.html">
                            <img src="images/13_design_08.jpg" onmouseover="this.src='images/13_design_08a.jpg'"
                                onmouseout="this.src='images/13_design_08.jpg'" alt="" width="179" height="80"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td>
                        <a href="expo.html">
                            <img src="images/13_design_09.jpg" onmouseover="this.src='images/13_design_09a.jpg'"
                                onmouseout="this.src='images/13_design_09.jpg'" alt="" width="196" height="80"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td>
                        <img src="images/13_design_10.jpg"></td>
                </tr>
            </table>
            <img src="images/13_design_con_11.jpg">
            <div style="background: url(images/13_design_con_12.jpg) no-repeat; *margin-top: -3px;">
                <table border="0" cellpadding="0" cellspacing="0" class="login-bg">
                    <tr>
                        <td colspan="6">&nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td align="right">&nbsp;
                            </td>
                        <td width="10%" align="left">
                            <font color="#ff0000">▌</font>姓名 :</td>
                        <td width="22%">
                            <asp:TextBox runat="server" ID="txtUserName1" Width="150px"></asp:TextBox>
                        </td>
                        <td width="10%" align="left">
                            <font color="#ff0000">▌</font>同行者姓名 :</td>
                        <td width="22%">
                            <asp:TextBox runat="server" ID="txtUserName2" Width="150px"></asp:TextBox>
                        </td>
                        <td width="29%">&nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td align="right">&nbsp;
                            </td>
                        <td align="left">
                            <font color="#ff0000">▌</font>手機 :</td>
                        <td>
                            <label>
                                <asp:TextBox runat="server" ID="txtPhome1" Width="150px" MaxLength="10"></asp:TextBox>
                            </label>
                        </td>
                        <td align="left">
                            <font color="#ff0000">▌</font>同行者手機 :</td>
                        <td>
                            <label>
                                <asp:TextBox runat="server" ID="txtPhone2" Width="150px" MaxLength="10" ></asp:TextBox>
                            </label>
                        </td>
                        <td>&nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td align="right">&nbsp;
                            </td>
                        <td align="left">
                            <font color="#ff0000">▌</font>Email :</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtEmail1" Width="150px"></asp:TextBox>
                        </td>
                        <td align="left">
                            <font color="#ff0000">▌</font>同行者E-mail :</td>
                        <td>
                            <asp:TextBox runat="server" ID="txtEmail2" Width="150px"></asp:TextBox>
                        </td>
                        <td>&nbsp;
                            </td>
                    </tr>
                    <tr>
                        <td align="right">&nbsp;
                            </td>
                        <td align="left">
                            <font color="#ff0000">▌</font>出生年月日 :</td>
                        <td>
                            <label>
                                <asp:TextBox runat="server" ID="txtBirthDate" Width="150px"></asp:TextBox>
                                <cc1:CalendarExtender ID="CalendarExtender1" runat="server" Format="yyyy/MM/dd" TargetControlID="txtBirthDate">
                                </cc1:CalendarExtender>
                            </label>
                        </td>
                        <td align="left">
                            <%-- <IFRAME id="iframe1" width="250"  name="iframe1" src="../../CheckImageCode.aspx" frameBorder="0"
									runat="server"></IFRAME>     --%>
                            <!--驗證碼請放這裡-->
                            <%-- <a href="conference_ok.aspx"><img src="http://www.ikki.com.tw/event/13_okinawa/images/btn_sure.gif" width="74" height="21" style="margin-left:20px;"></a>--%>
                        </td>
                        <td rowspan="3" align="left">
                        <div style="margin-bottom:60px;"><asp:ImageButton runat="server" ID="IBtnSend" ImageUrl="images/btn_go.png"
                                BorderColor="0" OnClick="IBtnSend_Click" /></div>
                        </td>
                    </tr>
                    <tr>
                        <td>
                        </td>
                        <td align="left">
                            <font color="#ff0000">▌</font>請輸入驗證碼 :</td>
                        <td>
                            <label>
                                <asp:TextBox runat="server" ID="txtCode"></asp:TextBox>
                            </label>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td></td>
                        <td></td>
                        <td colspan="2">
                        <div style="float:left;"><iframe id="iframe1" width="200" height="120" name="iframe1" src="../../CheckImageCode.aspx"
                                frameborder="0" runat="server"></iframe></div>
                        <div style="float:left;"><asp:Button ID="btnR" runat="server" Text="重新產生"></asp:Button></div>
                        </td>
                      <td>&nbsp;</td>
                    </tr>
                    <%--    <tr>
                <td></td>
                <td colspan="3">
                               <IFRAME id="iframe1" width="250" height="1" name="iframe1" src="../../CheckImageCode.aspx" frameBorder="0"
									runat="server"></IFRAME>
                </td>
                              <td colspan="2" style="padding-left:100px; padding-top:10px; color:#fff100;">目前報名人數:<span style="font-size:24px; font-weight:bold;"> 39</span> 組<br>
              ※ 本活動以「一起。分享」為宗旨，須兩人同行為乙組參加活動<br>※ 每人只可報名1次，兩人乙組，限100組<br>※ 請填寫正確聯絡方式，以方便聯繫<br>※ 額滿後報名系統將自動關閉</td>
            </tr>--%>
                    <tr>
                        <td colspan="6">
                        </td>
                    </tr>
                </table>
            </div>
            
          <table border="0" cellpadding="0" cellspacing="0" class="login-bg">
            <tr>
<td style="padding-left: 100px; padding-top: 10px; color: #fff100;">
                            目前報名人數:<span style="font-size: 24px; font-weight: bold;"> <asp:Label runat="server" ID="lblConferenceCnt"  style="font-size: 24px; font-weight: bold;"></asp:Label></span> 組<br>
                            ※ 本活動以「一起。分享」為宗旨，須兩人同行為乙組參加活動<br>
                            ※ 每人只可報名1次，兩人乙組，限100組<br>
                            ※ 請填寫正確聯絡方式，以方便聯繫<br>
                            ※ 額滿後報名系統將自動關閉</td>
                    </tr>
            </table>
            
<table border="0" cellpadding="0" cellspacing="0">
                <tr>
                    <td>
                        <img src="images/13_design_con_13.jpg"></td>
                    <td>
                        <a href="books.aspx">
                            <img src="images/13_design_con_14.jpg" onmouseover="this.src='images/13_design_con_14a.jpg'"
                                onmouseout="this.src='images/13_design_con_14.jpg'" alt="" width="236" height="120"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td>
                        <a href="fb.html">
                            <img src="images/13_design_con_15.jpg" onmouseover="this.src='images/13_design_con_15a.jpg'"
                                onmouseout="this.src='images/13_design_con_15.jpg'" alt="" width="247" height="120"
                                style="cursor: pointer; border: none;" /></a></td>
                    <td width="450"></td>
                </tr>
            </table>
        </div>
        <div class="footer_bg" style="height: 400%;">
            <div class="footer">
                <table border="0" cellpadding="0" cellspacing="0">
                    <tr>
                        <td>
                            <a href="http://www.books.com.tw/fashion/activity/2013/08/ikki/" target="_blank">
                                <img src="images/footer_16.jpg" onmouseover="this.src='images/footer_16a.jpg'" onmouseout="this.src='images/footer_16.jpg'"
                                    alt="" width="351" height="50" style="cursor: pointer; border: none;" /></a></td>
                        <td>
                            <a href="story.html">
                                <img src="images/footer_17.jpg" onmouseover="this.src='images/footer_17a.jpg'" onmouseout="this.src='images/footer_17.jpg'"
                                    alt="" width="281" height="50" style="cursor: pointer; border: none;" /></a></td>
                        <td>
                            <a href="tips.html">
                                <img src="images/footer_18.jpg" onmouseover="this.src='images/footer_18a.jpg'" onmouseout="this.src='images/footer_18.jpg'"
                                    alt="" width="348" height="50" style="cursor: pointer; border: none;" /></a></td>
                    </tr>
                </table>
            </div>
        </div>
        <div class="link">
        <img src="images/footer_19.jpg" border="0" usemap="#Map2">
                <map name="Map2">
          <area shape="rect" coords="195,33,312,73" href="http://www.books.com.tw/" target="_blank">
          <area shape="rect" coords="385,31,656,71" href="http://www.designexpo.org.tw/" target="_blank">
          <area shape="rect" coords="168,76,306,137" href="http://www.larche100.org/" target="_blank">
          <area shape="rect" coords="307,76,454,137" href="http://www.kangfu.org.tw/" target="_blank">
          <area shape="rect" coords="457,77,578,137" href="https://www.facebook.com/pages/%E6%A8%82%E6%B4%BB%E8%82%B2%E5%B9%BC%E9%99%A2/142081229246320" target="_blank">
          <area shape="rect" coords="676,23,769,131" href="https://www.facebook.com/pages/%E8%97%9D%E5%A5%87%E6%96%B0%E6%97%A5%E6%9C%AC%E6%96%99%E7%90%86_ikki/196280158629?fref=ts" target="_blank">
        </map>
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
