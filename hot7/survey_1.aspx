<%@ Page Language="C#" AutoEventWireup="true" CodeFile="survey_1.aspx.cs" Inherits="survey_1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">


<html>
<head>
<!-- Google Tag Manager -->
<script>(function(w,d,s,l,i){w[l]=w[l]||[];w[l].push({'gtm.start':
new Date().getTime(),event:'gtm.js'});var f=d.getElementsByTagName(s)[0],
j=d.createElement(s),dl=l!='dataLayer'?'&l='+l:'';j.async=true;j.src=
'https://www.googletagmanager.com/gtm.js?id='+i+dl;f.parentNode.insertBefore(j,f);
})(window,document,'script','dataLayer','GTM-TP54J99');</script>
<!-- End Google Tag Manager -->

<meta charset="utf-8">
<title>hot7_線上建議卡 </title>
<link href="member/css/style.css" rel="stylesheet" type="text/css">
<script src="member/js/jquery.min.js"></script>
<script src="member/js/jquery.placeholder.js"></script>
<script>
	// $.fn.hide = function() { return this; }
	$(function() {
		$('input, textarea').placeholder({customClass:'placeholder'});
	});
</script>


<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-70997142-1', 'auto');
  ga('send', 'pageview');

</script>



</head>
<body>
<form id="form2" runat="server">
<div class="head">
  <div class="logo"><a href="index.html"><img src="member/img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td><h4 class=" c_or"><i class="demo-icon tx_l">&#xe834;</i> 填問卷 每月抽100名免費熱饗hot 7
</h4></td>
        </tr>
        <tr>
          <td><div class="c_blue tx_l"><i class="demo-icon">&#xe832;</i>活動時間：</div>
            即日起~2017/09/30<br />
            <div class="c_blue tx_l"><i class="demo-icon">&#xe832;</i>活動方式：</div>
            登入用餐發票號碼即可填問卷，抽獎請先加入會員&nbsp;<br />
輸入發票號碼截止時間為每次月7日<br />
            <div class="c_blue tx_l"><i class="demo-icon">&#xe832;</i>獎項：</div>
            <p>hot  7 套餐券(市價NT$329)</p>
            <div class="c_blue tx_l"><i class="demo-icon">&#xe832;</i>說明：</div>
            次月7日前：可輸入本月發票號碼<br />
            次月10日：公佈本月中獎名單<br />
            次月14日前：確認中獎名單聯絡資料<br />
            次月15日：寄出獎項 <br />
            中獎名單公布或獎項寄送時間如遇假日，相關作業將順延。例如7/10(日)，順延至7/11(一)
             <div class="c_blue tx_l"><i class="demo-icon">&#xe832;</i>注意事項：</div>
            <p>輸入發票號碼截止時間為每次月7日，逾期未輸入者，不具抽獎資格。
              <br />
              每張發票號碼限登錄一次為原則，非店內發票經查證將由系統自動刪除。
參加者於參加本活動之同時，即同意接受本活動之活動辦法與注意事項之規範，如有違反，hot 7得取消其參加或得獎者資格。<br />
hot 7保有變更活動之權力，一切公告以網站為主，不另行通知。
若對本活動有任何疑問歡迎email至 marketing@hot-7.com，我們將盡快予以回覆。</p></td>
        </tr>
        <tr>
          <td><div>
            <p class="flt_l c_blue">&nbsp;</p>
            <p class="flt_l c_blue"><i class="demo-icon">&#xe84c;</i><a href="member_edit.aspx"> 修改中獎資料</a></p>
          </div></td>
        </tr>
      </tbody>
    </table>
    <table border="0" cellspacing="0" cellpadding="0"  class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe80d;</i> 填寫問卷</h4>
            <div class="form_tx flt_r"> <i class="demo-icon c_or">&#xe846;</i>必填</div></td>
        </tr>
      </tbody>
    </table>
    <table border="0" cellspacing="0" cellpadding="0" class="tbl">
      <tbody>
        <tr>
          <td><p class="c_or">非常感謝您光臨hot7~<br>
          今天的餐點及服務是否讓您滿意呢?您的建議與指教，是推動我們不斷前進的動力！您的滿意也是hot7努力的目標，在此請您給我們一些寶貴的意見，謝謝。</p>
          <input type="button" name="button" onClick="location.href='member_join.aspx'" class="butn input_field" value="參加活動請先加入會員">
          </td>
        </tr>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>用餐日期 </div><div class="form_span flt_r">
          <%--<select name="year1" id="year1">
          <option selected>年</option>
          <option>1950</option></select>--%>
          
        <%--<select name="month1"  id="month1">
          <option>月</option>
          <option>01</option></select>--%>
        
        
        <%--<select name="day1"  id="day1">
          <option>日</option>
          <option>30</option></select>--%>
        
        <asp:DropDownList ID="selectYear" runat="server">
              <asp:ListItem Value="">年</asp:ListItem>
          </asp:DropDownList>                  
          <asp:DropDownList ID="selectMonth" runat="server">
               <asp:ListItem Value="">月</asp:ListItem>
           </asp:DropDownList>           
           <asp:DropDownList ID="selectDay" runat="server">
               <asp:ListItem Value="">日</asp:ListItem>
           </asp:DropDownList>
        
        </div></td>
        </tr>
<tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>用餐時間 </div>
          <div class="form_span flt_r">
          <%--<select name="time" class="input_field">
          <option selected>午11:30~15:00</option>
          <option>晚17:30~23:30</option>
          </select>--%>
          <asp:DropDownList ID="dropTime" runat="server"  CssClass="input_field">
          </asp:DropDownList>
          <asp:Label ID="lbl115_SC_IQType" runat="server" Visible="False"></asp:Label>
          </div></td>
        </tr>        
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>用餐店舖</div>
          <div class="form_span flt_r">
          <%--<select name="store" class="input_field">
          <option selected>台灣大道店</option>
          <option>金典店</option>
          </select>--%>
          <asp:DropDownList ID="dropStore" runat="server" CssClass="input_field">
          </asp:DropDownList>
          
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_l form_tx"><i class="demo-icon c_or">&#xe846;</i>用餐發票</div>
          <div class="form_span flt_r">
           <%-- <input name="textfield2" type="text" class="input_field" id="textfield2" maxlength="20">--%>
            <asp:TextBox ID="txtInvoice" runat="server" CssClass="input_field" MaxLength="10"></asp:TextBox>
          </div></td>
        </tr>
        <tr>
          <td><div class="flt_r ">發票2碼英文8碼數字，例：PT12345678</div></td>
        </tr>
        <tr>
          <td>&nbsp;</td>
        </tr>
        <tr>
          <td>
          <%--<input type="button" name="button" onClick="location.href='survey_2.html'" class="butn input_field" value="下一步">--%>
              <asp:Button ID="Button1" runat="server" Text="下一步" 
                  CssClass="butn input_field" onclick="btnSend_Click" />
          </td>
        </tr>
      </tbody>
  </table>
  </div>
</div>
</form>
</body>
<!-- Google Tag Manager (noscript) -->
<noscript><iframe src="https://www.googletagmanager.com/ns.html?id=GTM-TP54J99"
height="0" width="0" style="display:none;visibility:hidden"></iframe></noscript>
<!-- End Google Tag Manager (noscript) -->

    </html>

