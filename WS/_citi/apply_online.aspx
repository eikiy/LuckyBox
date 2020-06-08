<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apply_online.aspx.cs" Inherits="citi_apply_online" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <meta http-equiv="X-UA-Compatible" content="IE=9" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="../styles/bootstrap.css" rel="stylesheet" type="text/css" />
    <link href="city.css" rel="stylesheet" type="text/css" />
    <link href="style.css" rel="stylesheet" type="text/css" />
    <link href="javascript/Public.css" type="text/css" rel="stylesheet" />
    <script src='../js/jquery.min.js'></script>
    <script src='../js/bootstrap.min.js'></script>
    <title>花旗饗樂生活卡</title>
    <script language="JavaScript" type="text/JavaScript">
<!--



    function MM_preloadImages() { //v3.0
        var d = document; if (d.images) {
            if (!d.MM_p) d.MM_p = new Array();
            var i, j = d.MM_p.length, a = MM_preloadImages.arguments; for (i = 0; i < a.length; i++)
                if (a[i].indexOf("#") != 0) { d.MM_p[j] = new Image; d.MM_p[j++].src = a[i]; }
        }
    }
    //-->
    </script>
</head>
<body>
    <div class="page">
        <table border="0" style="max-width: 976px;">
            <tr>
                <td valign="top">
                    <!--content-->
                    <div class="content">
                        <div class="content hidden-xs hidden-sm" id="apDiv1">
                            <img src="img/meal2.png" width="300" />
                        </div>
                        <table>
                            <tr>
                                <td class="hidden-xs hidden-sm">&nbsp;</td>
                                <td valign="bottom">
                                    <div class="title-links">
                                        <a href="index.html" class="home"><span class="glyphicon glyphicon-home"></span></a><a href="apply.htm" style="background: #808080">立即申請</a> <a href="right.htm">聯名卡權益</a> <a href="QA.htm">答客問</a>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td align="center" valign="bottom" width="215px" class="hidden-xs hidden-sm">
                                    <div class="left-bg">
                                        <img src="img/gift.png" width="270px" />
                                        <a href="../index_PASS_1101.html">
                                            <img src="img/logo.png" width="143" height="42" border="0" /></a>
                                    </div>
                                </td>
                                <td bgcolor="#FFFFFF">
                                    <div id="info-right" style="padding: 10px;">
                                        <form class="form" id="Form1" name="form1" method="post" action="" runat="server">
                                            <div class="subtitle" style="margin:30px auto;">我有興趣辦花旗饗樂生活卡，我同意花旗銀行與我聯絡&#13;</div>
                                            <div style="margin-bottom:20px">
                                                為了提供您後續商品電話服務，於您按下「送出」時，您於上列所填寫的資料將會送予花旗銀行，由花旗銀行人員與您聯絡。花旗銀行必將以「花旗（台灣）銀行集團全球客戶隱私保護承諾」保護您個人資料安全，且於法令許可及行銷饗樂生活卡目的範圍內，在國內外蒐集、處理、利用您的個人資料。若您同意前述聲明且已詳閱並同意花旗銀行「<a href="http://www.citibank.com.tw/global_docs/chi/pressroom/infoprotect.pdf">蒐集、處理及利用個人資料告知事項</a>
                                            </div>
                                            <div class="form-group row">
                                                <label for="name" class="col-sm-2 control-label">姓名</label>
                                                <div class="col-sm-4">
                                                    <input type="text" name="textfield" id="txtName" runat="server" class="form-control" />
                                                </div>
                                                <div class="col-sm-4">
                                                    <asp:RadioButton ID="radSex1" runat="server" Text="先生" GroupName="gupSex"></asp:RadioButton>
                                                    <asp:RadioButton ID="radSex0" runat="server" Text="小姐" GroupName="gupSex"></asp:RadioButton>
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="name" class="col-sm-2 control-label">連絡電話</label>
                                            </div>
                                            <div class="form-group row">
                                                <label for="name" class="col-sm-2 control-label">(Office)</label>
                                                <div class="col-sm-4">
                                                    <input type="text" name="textfield2" id="txtOfficePhone" runat="server" class="form-control" />
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="name" class="col-sm-2 control-label">(Home)</label>
                                                <div class="col-sm-4">
                                                    <input type="text" name="textfield4" id="txtHomePhone" runat="server" class="form-control" />
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="name" class="col-sm-2 control-label">(手機)</label>
                                                <div class="col-sm-4">
                                                    <input type="text" name="textfield3" id="txtMobile" runat="server" class="form-control AmountInputLimit" />
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <label for="name" class="col-sm-2 control-label">方便連絡時間</label>
                                                <div class="col-sm-4">
                                                    <input type="checkbox" name="checkbox" value="checkbox" id="cbAm" runat="server" />
                                                    上午
                                                    <input type="checkbox" name="checkbox2" value="checkbox" id="cbPm" runat="server" />
                                                    下午
                                                    <input id="cbNm" type="checkbox" value="checkbox" name="checkbox2" runat="server" />
                                                    晚上
                                                </div>
                                            </div>
                                            <div class="form-group row">
                                                <div class="col-sm-12 text-center">
                                                    <asp:ImageButton ID="btnSend" runat="server" BorderStyle="None"
                                                        ImageUrl="images/btn_sure.gif" OnClick="btnSend_Click"></asp:ImageButton>
                                                </div>
                                            </div>
                                        </form>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td class="hidden-xs hidden-sm">&nbsp;</td>
                                <td>
                                    <div id="notes"></div>
                                    <script>
                                        $("#notes").load("citi_note.html");
                                    </script>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!--content end-->
                </td>
            </tr>
        </table>
    </div>
</body>
</html>
