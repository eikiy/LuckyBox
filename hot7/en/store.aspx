<%@ Page Language="C#" AutoEventWireup="true" CodeFile="store.aspx.cs" Inherits="en_store" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title>hot 7 新鉄板料理</title>
    <link href="/css/main.css" rel="stylesheet" type="text/css">
    <link href="/css/style.css" rel="stylesheet" type="text/css">
    <link href="/css/four.css" rel="stylesheet" type="text/css">

    <script src="/js/jquery-1.7.min.js" type="text/javascript"></script>

    <script src="/js/scroll_toolbar.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
    <div class="btn_01_en pos alp">
        <a href="store.aspx">
            <img src="images/f_01.png" width="98" height="96" onmouseover="this.src='images/f_01a.png'"
                onmouseout="this.src='images/f_01.png'" alt="" style="cursor: pointer; border: none;" /></a></div>
    <div class="btn_02_en pos alp">
        <a href="menu.aspx">
            <img src="images/f_02.png" width="78" height="109" onmouseover="this.src='images/f_02a.png'"
                onmouseout="this.src='images/f_02.png'" alt="" style="cursor: pointer; border: none;" /></a></div>
    <div class="btn_03_en pos alp">
        <a href="talk.aspx">
            <img src="images/f_03.png" width="105" height="111" onmouseover="this.src='images/f_03a.png'"
                onmouseout="this.src='images/f_03.png'" alt="" style="cursor: pointer; border: none;" /></a></div>
    <div class="wrapper">
        <div class="container">
            <a href="../index.html">
                <div class="logo_m">
                </div>
            </a>
            <div class="word" style="margin-top: 180px; padding-bottom: 30px;">
                <div style="padding: 20px 31px 0 0x;">
                    <table width="95%" border="0" cellpadding="0" cellspacing="0" class="x_tb">
                        <tr>
                            <td class="x_f05" style="text-align: center;">
                                Branches
                            </td>
                        </tr>
                        <tr>
                            <td class="x_line_y">
                            </td>
                        </tr>
                    </table>
                    <table width="90%" border="0" cellpadding="0" cellspacing="0" class="x_store">
                        <tr>
                            <td colspan="6" class="x_line">&nbsp;
                                
                            </td>
                        </tr>
                        <tr>
                            <td width="25%">
                                <img src="../images/four/icn_01.png" width="18" height="25">
                                <a href="#01">North Taiwan</a>
                            </td>
                            <td width="25%">
                                <img src="../images/four/icn_01.png" width="18" height="25">
                                <a href="#02">Central Taiwan</a>
                            </td>
                            <td width="25%">
                                <img src="../images/four/icn_01.png" width="18" height="25">
                                <a href="#03">South Taiwan</a>
                            </td>
                            <td width="25%">
                                <img src="../images/four/icn_01.png" width="18" height="25">
                                <a href="#04">East Taiwan</a>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6" class="x_line">&nbsp;
                                
                            </td>
                        </tr>
                    </table> 
                    <asp:Literal ID="LiteArea1" runat="server"></asp:Literal>                   
                      <asp:Literal ID="LiteArea2" runat="server"></asp:Literal>                   
                      <asp:Literal ID="LiteArea3" runat="server"></asp:Literal>
                      <asp:Literal ID="LiteArea4" runat="server"></asp:Literal>
                   
                </div>
            </div>
        </div>
    </div>
    <div class="footer">
        <div style="background: url(../images/underline_bg.png) repeat-x; text-align: center;">
            <img src="../images/underline.png"></div>
        <br>
        <img src="images/footer.png" width="761" height="72" border="0">
    </div>
    </form>
</body>

<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>

</html>
