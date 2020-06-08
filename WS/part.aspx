<%@ Page Language="C#" AutoEventWireup="true" CodeFile="part.aspx.cs" Inherits="part" %>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">
<html>
<head>
    <title>同仁意見</title>
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
    <link href="style.css" rel="stylesheet" type="text/css">
</head>
<body bgcolor="#cccccc">
    <!-- Google Tag Manager -->
    <noscript>
        <iframe src="//www.googletagmanager.com/ns.html?id=GTM-WJ8GBQ" height="0" width="0"
            style="display: none; visibility: hidden"></iframe>
    </noscript>

    <script>        (function(w, d, s, l, i) {
            w[l] = w[l] || []; w[l].push({ 'gtm.start':
new Date().getTime(), event: 'gtm.js'
            }); var f = d.getElementsByTagName(s)[0],
j = d.createElement(s), dl = l != 'dataLayer' ? '&l=' + l : ''; j.async = true; j.src =
'//www.googletagmanager.com/gtm.js?id=' + i + dl; f.parentNode.insertBefore(j, f);
        })(window, document, 'script', 'dataLayer', 'GTM-WJ8GBQ');</script>

    <!-- End Google Tag Manager -->
    <form id="Form1" runat="server">
    <table height="100%" border="0" align="center" cellpadding="0" cellspacing="0">
        <tr>
            <td height="35">
                <img src="images/wanggroup_logo.gif" width="650" height="35">
            </td>
        </tr>
        <tr>
            <td valign="top" bgcolor="#ffffff">
                <br>
                <br>
                <table width="566" height="19" border="0" align="center" cellpadding="0" cellspacing="0">
                    <tr>
                        <td width="566">
                            We are family ! 歡迎您來到「同仁意見信箱」，為讓同仁皆可以充份表達想法，溝通意見，歡迎集團同仁填寫您的看法及建議，任何意見皆會獲得重視，如需回覆請註明您的姓名及email，以利相關部門可以迅速與您聯絡。
                        </td>
                    </tr>
                </table>
                <table width="87%" border="0" align="center" cellpadding="0" cellspacing="3">
                    <tr>
                        <td width="14%">
                            ‧事業別
                        </td>
                        <td width="86%">
                            <font face="新細明體">
                                <asp:DropDownList ID="seleCareer" runat="server" Width="101px" AutoPostBack="True">
                                </asp:DropDownList>
                                <%--			<SELECT id="seleCareer" size="1" name="seleCareer" runat="server">
                                <option value="請選擇" selected>請選擇</option>
                                <option value="王品">王品牛排</option>
                                <option value="TASTY">TASTy西堤牛排</option>
                                <option value="陶板屋">陶板屋和風創作料理</option>
                                <option value="原燒">原燒優質原味燒肉</option>
                                <option value="聚鍋">聚北海道昆布鍋</option>
                                <option value="ikki">藝奇懷石創作料理</option>
                                <option value="夏慕尼">夏慕尼新香榭鐵板燒</option>
                                <option value="品田牧場">品田牧場日式豬排咖哩</option>
                                <option value="石二鍋">石二鍋</option>
                                <option value="舒果">舒果新米蘭蔬食</option>
                                <option value="hot7">hot 7</option>
                                <option value="ita">ita</option>                
                                </SELECT>--%>
                            </font>
                        </td>
                    </tr>
                    <tr>
                        <td width="14%">
                            ‧主題
                        </td>
                        <td width="86%">
                            <asp:TextBox ID="txtSubject" runat="server" Width="262px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            ‧姓名
                        </td>
                        <td>
                            <asp:TextBox ID="txtAuthor" TabIndex="2" Width="262px" runat="server" MaxLength="20"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            ‧email
                        </td>
                        <td>
                            <asp:TextBox ID="txtEmail" TabIndex="3" Width="371px" runat="server" MaxLength="50"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            ‧內容
                        </td>
                        <td>
                            <asp:TextBox ID="txtArea" TabIndex="4" TextMode="MultiLine" Height="217px" Width="100%"
                                runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                        </td>
                        <td>
                            <asp:Label ID="lbl1" Width="389px" runat="server" ForeColor="Red" Visible="False">您輸入的資料不完整</asp:Label>
                        </td>
                    </tr>
                </table>
                <br>
                <table cellspacing="0" cellpadding="0" width="185" align="center" border="0">
                    <tr>
                        <td valign="middle" align="center">
                            <div align="center">
                                <font face="新細明體">
                                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="images/part_sure.gif"
                                        OnClick="ImageButton1_Click"></asp:ImageButton></font></div>
                        </td>
                        <td valign="middle" align="center">
                            <div align="center">
                                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="images/part_re.gif" OnClick="ImageButton2_Click">
                                </asp:ImageButton></div>
                        </td>
                    </tr>
                </table>
                <br>
            </td>
        </tr>
        <tr>
            <td bgcolor="#ffffff">
                <table border="0" align="center" cellpadding="0" cellspacing="3">
                    <tr>
                        <td class="list">
                            王品牛排
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">TASTy 西堤牛排</font>
                        </td>
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">陶板屋和風創作料理</font>
                        </td>
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">原燒優質原味燒肉</font>
                        </td>
                    </tr>
                </table>
                <table border="0" align="center" cellpadding="0" cellspacing="3">
                    <tr>
                        <td class="list">
                            <font color="#333333">聚北海道昆布鍋</font>
                        </td>
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">藝奇</font><font color="#333333">新日本料理</font>
                        </td>
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">夏慕尼新香榭鐵板燒</font>
                        </td>
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">品田牧場日式豬排咖哩</font>
                        </td>
                        <td class="list">
                            <img src="images/spacer.gif" width="10" height="8">
                        </td>
                        <td class="list">
                            <font color="#333333">石二鍋</font>
                        </td>
                    </tr>
                </table>
              <table border="0" align="center" cellpadding="0" cellspacing="3">
              <tr>
                <td class="list"><font color="#333333">舒果新米蘭蔬食</font></td>
                <td class="list"><img src="images/spacer.gif" alt="" width="10" height="8"></td>
                <td class="list"><font color="#333333">&nbsp;</font><font color="#333333">hot 7</font></td>
                <td class="list"><img src="images/spacer.gif" alt="" width="10" height="8"></td>
                <td class="list"><font color="#333333">ita義塔</font></td>
                <td class="list"><img src="images/spacer.gif" alt="" width="10" height="8"></td>
                <td class="list"><font color="#333333">莆田</font></td>
                </tr>
            </table></td>
        </tr>
    </table>
    </form>
</body>
</html>
