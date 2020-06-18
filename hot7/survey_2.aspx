<%@ Page Language="C#" AutoEventWireup="true" CodeFile="survey_2.aspx.cs" Inherits="survey_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html>
<head>
<meta charset="utf-8">
<title>hot7</title>
<link href="member/css/style.css" rel="stylesheet" type="text/css">
<style type="text/css">
.tbl {
	width: 72%;
}

@media only screen and (max-device-width: 480px){
.tbl {
    width : 85%;
}
}

.cb td{
   text-align : left;
 }
</style>
<script src="member/js/jquery.min.js"></script>
<script src="member/js/jquery.placeholder.js"></script>
<script>
	// $.fn.hide = function() { return this; }
	$(function() {
		$('input, textarea').placeholder({customClass:'placeholder'});
	});
</script>



    <script language="JavaScript">
    <!--
        function CleanText() {
            var sText = document.all.txtSuggestion.value;
            if (sText == "(限300字以內)")
                document.all.txtSuggestion.value = "";
        }
    //-->
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
<asp:ScriptManager ID="ScriptManager1" 
    runat="server" EnableScriptGlobalization="True">
</asp:ScriptManager>
&nbsp;<div class="head">
  <div class="logo"><a href="index.html"><img src="member/img/space.png" width="100%" height="100%" alt=""/></a></div>
</div>
<div class="main">
  <div class="regbox" align="center">
    <table border="0" cellpadding="0" cellspacing="0" class="tbl">
      <tbody>
        <tr>
          <td class="bg_line"><h4 class="form_tx flt_l"><i class="demo-icon c_blue">&#xe80d;</i> 填寫建議卡</h4>
          <div class="form_tx flt_r">
          <i class="demo-icon c_or">&#xe846;</i>必填</div>
            </td>
        </tr>
      </tbody>
    </table>
         <asp:UpdatePanel ID="UpdatePanel1" runat="server" 
          UpdateMode="Conditional" ><%-- ChildrenAsTriggers="true"--%>
                     <ContentTemplate> 

    <table border="0" cellspacing="0" cellpadding="0" class="tbl">
      <tbody>
        <tr>
          <td>&nbsp;</td>
        </tr>
      </tbody>
    </table>
    <table width="72%" border="0" cellpadding="0" cellspacing="0" class="tbl">
      <tbody>
      <tr>
        <td align="left" valign="top"><p>1 </p></td>
        <td><p><i class="demo-icon c_or">&#xe846;</i>請問您這是第一次到【hot7】用餐嗎？</p></td>
      </tr>
      <tr>
        <td align="left" valign="top">&nbsp;</td>
        <td>
            <%--<div class="flt_l"><input type="radio">是(請跳到第3題)</div>
            <div class="flt_l"><input type="radio">否</div>--%>
            <div class="flt_l">
            <asp:RadioButtonList ID="rblQ1" runat="server" RepeatDirection="Horizontal" 
               OnSelectedIndexChanged="rblQ1_SelectedIndexChanged" AutoPostBack="True">
            </asp:RadioButtonList>
            <asp:Label ID="lblQ1" runat="server" Visible="False"></asp:Label>
            </div>
        </td>
      </tr>
      <tr>
        <td align="left" valign="top"><p>2 </p></td>
        <td><p><i class="demo-icon c_or">&#xe846;</i>請問您最近半年總共到【hot7】用餐幾次？</p></td>
      </tr>
        <tr>
  <td align="left" valign="top">&nbsp;</td>
          <td>
          <%--<select name="time" class="input_field">
          <option selected>1次</option>
          <option>2次</option>
          <option>3次</option>
          <option>4次</option>
          <option>5次以上</option>
          </select>--%>
          <asp:DropDownList ID="drpQ2" runat="server" CssClass="input_field">
          </asp:DropDownList>
          <asp:Label ID="lblQ2" runat="server" Visible="False"></asp:Label>
                   
          </td>
        </tr>        
        <tr>
          <td align="left" valign="top"><p>3 </p></td>
          <td><p><i class="demo-icon c_or">&#xe846;</i>請問您是如何知道本店？(可複選)
          </p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <td>
            <%--<div class="checkblock_4"><input type="checkbox">以前來過</div>
            <div class="checkblock_4"><input type="checkbox">媒體報導</div>
            <div class="checkblock_4"><input type="checkbox">網路資訊</div>
            <div class="checkblock_4"><input type="checkbox">親友介紹</div>
            <div class="checkblock_4"><input type="checkbox">廣告文宣</div>
            <div class="checkblock_4"><input type="checkbox">路過</div>
            <div class="checkblock_4"><input type="checkbox">簡訊</div>
            <div class="checkblock_4"><input type="checkbox">其他</div>--%>
            <div class="flt_l">

            <asp:CheckBoxList ID="chkQ3" runat="server" RepeatColumns="2"    RepeatDirection="Horizontal"
             CssClass="cb">
            </asp:CheckBoxList>            
            <asp:Label ID="lblQ3" runat="server" Visible="False"></asp:Label>

            </div>
          </td>
        </tr>
        <tr>
          <td align="left" valign="top"><p>4 </p></td>
          <td><p><i class="demo-icon c_or">&#xe846;</i>請問您今天到【hot7】用餐的主餐是？(單選)</p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <td>
  		
            <div class="flt_l">
            
            <asp:DropDownList ID="drpQ5" runat="server" CssClass="input_field">
            </asp:DropDownList>
            <asp:Label ID="lblQ5" runat="server" Visible="False"></asp:Label>
          
            </div>
          </td>
        </tr>
        <tr>
          <td align="left" valign="top"><p>5 </p></td>
          <td><p><i class="demo-icon c_or">&#xe846;</i>請問您對【hot7】&#8230;</p></td>
        </tr>
        <%--<tr>
          <td align="left" valign="top">&nbsp;
          
          </td>
          <td><div class="flt_l form_tx">餐點口感</div>  
            <div class="form_span flt_r">
              <select name="select" class="input_field">
                <option value="">請選擇</option>
                <option value="1">非常滿意</option>
                <option value="2">滿意</option>
                <option value="3">普通</option>
                <option value="4">差</option>
                <option value="5">很差</option>
              </select>
          </div>       
          </td>
        </tr>--%>

       <tr>
            <td align="left" valign="top">&nbsp;
              <asp:Label ID="lblQ6" runat="server" Visible="False"></asp:Label>  
            </td>
            <td >
                <asp:GridView ID="grdQ6" runat="server" AutoGenerateColumns="False" 
                    GridLines="None" OnRowDataBound="grdQ6_RowDataBound1"  ShowHeader="False" CssClass="input_field">
                    <Columns>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:Label ID="lblQ6AnsName" runat="server" Text='<%# Eval("AnsName") %>'></asp:Label>
                                <asp:Label ID="lblQ6AnsGUID" runat="server" Visible="false" Text='<%# Eval("AnsGUID") %>'></asp:Label>
                                <asp:Label ID="lblQ6AnsOrder" runat="server" Visible="false" Text='<%# Eval("AnsOrder") %>'></asp:Label>
                                <asp:Label ID="lblQ6AnsLocal" runat="server" Visible="false" Text='<%# Eval("AnsLocal") %>'></asp:Label>
                                <asp:Label ID="lblQ6AnsScore" runat="server" Visible="false" Text='<%# Eval("AnsScore") %>'></asp:Label>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Left"/>
                        </asp:TemplateField>
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:DropDownList ID="drpQ6" runat="server" CssClass="form_span flt_r">
                                </asp:DropDownList>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Left"/>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>

      
        
         <tr>
          <td align="left" valign="top"><p>6 </p></td>
          <td><p><i class="demo-icon c_or">&#xe846;</i>
          您認為本店最吸引人的兩項特色是? (限填兩項)
          <asp:Label ID="lblAlertQ7" runat="server"  ForeColor="Red" Visible="False">只可以選2項喔!</asp:Label>              
          </p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <td>
            <%--<div class="checkblock"><input type="checkbox">菜色多樣化</div>
            <div class="checkblock"><input type="checkbox">服務好</div>
            <div class="checkblock"><input type="checkbox">價格合理</div>
            <div class="checkblock"><input type="checkbox">好吃</div>
            <div class="checkblock"><input type="checkbox">氣氛好 </div>--%>
            <div class="flt_l">            
            <asp:CheckBoxList ID="chkQ7" runat="server" RepeatDirection="Horizontal"
                AutoPostBack="True" OnSelectedIndexChanged="chkQ7_SelectedIndexChanged" RepeatColumns="2" CssClass="cb">
            </asp:CheckBoxList>
             <asp:Label ID="lblQ7" runat="server" Visible="False"></asp:Label>  
                                    
            </div>                            
                                        
          </td>
        </tr>
        <tr>
          <td align="left" valign="top"><p>7 </p></td>
          <td><p><i class="demo-icon c_or">&#xe846;</i>請問您會不會介紹朋友來本店用餐？</p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <td>
            <%--<div class="flt_l"><input type="radio">會</div>
            <div class="flt_l"><input type="radio">不會</div>--%>
            <div class="flt_l">
            <asp:RadioButtonList ID="rblQ8" runat="server" RepeatDirection="Horizontal"
                BorderColor="White" RepeatColumns="2"
                OnSelectedIndexChanged="rblQ8_SelectedIndexChanged" AutoPostBack="True">
            </asp:RadioButtonList>
            <asp:Label ID="lblQ8" runat="server" Visible="False"></asp:Label>
            </div>
        </td>
        </tr>

       
       
       
       <%--
       
        <tr>
          <td align="left" valign="top"><p>8 </p></td>
          <td><p><i class="demo-icon c_or">&#xe846;</i>承第7題，不願意介紹朋友的原因？(限填兩項)
          <asp:Label ID="lblAlertQ12" runat="server"  ForeColor="Red" Visible="False">只可以選2項喔!</asp:Label> 
          </p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <td>         
            <asp:CheckBoxList ID="chkQ12" runat="server" RepeatDirection="Horizontal"
                AutoPostBack="True" OnSelectedIndexChanged="chkQ12_SelectedIndexChanged" RepeatColumns="2" CssClass="cb">
            </asp:CheckBoxList>
            <asp:Label ID="lblQ12" runat="server" Visible="False"></asp:Label>  
         </td>
        </tr>
        
        
        
        <tr>
          <td align="left" valign="top"><p>9 </p></td>
          <td><p>請問您最喜歡的菜色及期待更好的菜色是&#8230;?(各至多限填三道)</p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;
          <asp:HiddenField ID="coontGV_Like" runat="server"/>
          </td>
          <td>        
          
             <div class="flt_l form_tx">最喜歡的菜色</div>
             <div class="form_span flt_r">             
              
              <asp:GridView ID="grdAnalysisData_Like" runat="server" AutoGenerateColumns="False" Width="100%"
                OnRowDataBound="grdAnalysisData_RowDataBound_Like" BorderStyle="None" 
                ShowFooter="True" ShowHeader="False" GridLines="None" >
                <Columns>
                    <asp:TemplateField>
                        <FooterTemplate>
                               <div class="flt_l form_tx">
                               <asp:LinkButton ID="LinkButton_AddRow_Like" runat="server" OnClick="LinkButton_AddRow_Click_Like">
                               <i class="demo-icon c_blue">&#xe853;</i>增選菜色</asp:LinkButton> 
                               </div>
                        </FooterTemplate>
                        <ItemTemplate>
                            <table width="100%">
                                <tr>
                                    <td>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpSugType_Like" CssClass="input_field" runat="server"
                                            OnSelectedIndexChanged="drpSugType_SelectedIndexChanged_Like" AutoPostBack="True">
                                        </asp:DropDownList>
                                        </div>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpAnalysisMain_Like" CssClass="input_field" runat="server" AutoPostBack="True">
                                        </asp:DropDownList>
                                       
                                        </div>
                                        
                                        
                                        <asp:HiddenField ID="hidDOGUID_Like" runat="server" 
                                            Value='<%# Eval("sDOGUID_Like") %>' />
                                        <asp:HiddenField ID="hidSugType_Like" runat="server" 
                                            Value='<%# Eval("sSugType_Like") %>' />
                                        <asp:HiddenField ID="hidAnalysisMain_Like" runat="server" 
                                            Value='<%# Eval("sAnalysisMain_Like") %>' />
                                    
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="NoneNumber" HeaderText="空白列" Visible="False">
                        <ItemStyle Width="10px" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView> 
          
             </div>
          </td>
        </tr>
        
        
        
		<tr>
          <td align="left" valign="top">&nbsp;
          <asp:HiddenField ID="coontGV_unLike" runat="server"/></td>
          <td>
          <div class="flt_l form_tx">期待更好的菜色</div>
          <div class="form_span flt_r">
            
            <asp:GridView ID="grdAnalysisData_unLike" runat="server" AutoGenerateColumns="False" Width="100%"
                OnRowDataBound="grdAnalysisData_RowDataBound_unLike" BorderStyle="None" 
                ShowFooter="True" ShowHeader="False" GridLines="None" >
                <Columns>
                    <asp:TemplateField>
                        <FooterTemplate>
                               <div class="flt_l form_tx">
                               <asp:LinkButton ID="LinkButton_AddRow_unLike" runat="server" OnClick="LinkButton_AddRow_Click_unLike">
                               <i class="demo-icon c_blue">&#xe853;</i>增選菜色</asp:LinkButton> 
                               </div>
                        </FooterTemplate>
                        <ItemTemplate>
                            <table width="100%">
                                <tr>
                                    <td>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpSugType_unLike" CssClass="input_field" runat="server"
                                            OnSelectedIndexChanged="drpSugType_SelectedIndexChanged_unLike" AutoPostBack="True">
                                        </asp:DropDownList>
                                        </div>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpAnalysisMain_unLike" CssClass="input_field" runat="server" AutoPostBack="True">
                                        </asp:DropDownList>
                                        </div>
                                        
                                        
                                        <asp:HiddenField ID="hidDOGUID_unLike" runat="server" 
                                            Value='<%# Eval("sDOGUID_unLike") %>' />
                                        <asp:HiddenField ID="hidSugType_unLike" runat="server" 
                                            Value='<%# Eval("sSugType_unLike") %>' />
                                        <asp:HiddenField ID="hidAnalysisMain_unLike" runat="server" 
                                            Value='<%# Eval("sAnalysisMain_unLike") %>' />
                                    
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="NoneNumber" HeaderText="空白列" Visible="False">
                        <ItemStyle Width="10px" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView> 
              
              
              
              
            </div>
          </td>
        </tr>      
        
        
        --%>
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        <tr>
          <td align="left" valign="top"><p>10</p></td>
          <td><p>&nbsp;請問您對本店或服務人員的建議是&#8230;</p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <%--<td> 
           <div class="flt_l">
              <select name="select" class="input_field">
                  <option value="">建議方向</option>
              </select>
           </div>
           <div class="flt_l">
                <select name="select" class="input_field">
                  <option value="" selected>類別</option>
                  <option value="1">餐點</option>
                  <option value="2">服務</option>
                  <option value="3">環境</option>
                  <option value="4">其他</option>
              </select>
           </div> 
           <div class="flt_l">
              <select name="select" class="input_field">
                  <option value="">品項</option>
              </select>
           </div>
           <div class="flt_l">
              <select name="select" class="input_field">
                  <option value="">意見內容</option>
              </select>
           </div>
              <div class="flt_l form_tx"><a href="#"><i class="demo-icon c_blue">&#xe853;</i>更多意見</a></div>
           </td>--%>          
           
           
           <td><asp:HiddenField ID="coontGV" runat="server"/>
                                         
            <asp:GridView ID="grdAnalysisData" runat="server" AutoGenerateColumns="False" Width="100%"
                OnRowDataBound="grdAnalysisData_RowDataBound" BorderStyle="None" 
                ShowFooter="True" ShowHeader="False" GridLines="None" >
                <Columns>
                    <asp:TemplateField>
                        <FooterTemplate>
                               <div class="flt_l form_tx">
                               <asp:LinkButton ID="LinkButton_AddRow" runat="server" OnClick="LinkButton_AddRow_Click">
                               <i class="demo-icon c_blue">&#xe853;</i>更多意見</asp:LinkButton> 
                               </div>
                        </FooterTemplate>
                        <ItemTemplate>
                            <table width="100%">
                                <tr>
                                    <td>
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpSugTypeM" runat="server" CssClass="input_field" Visible="False">
                                        </asp:DropDownList>
                                        </div>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpSugType" CssClass="input_field" runat="server"
                                            OnSelectedIndexChanged="drpSugType_SelectedIndexChanged" AutoPostBack="True">
                                        </asp:DropDownList>
                                        </div>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpAnalysisMain" CssClass="input_field" runat="server" AutoPostBack="True"
                                            OnSelectedIndexChanged="drpAnalysisMain_SelectedIndexChanged">
                                        </asp:DropDownList>
                                        </div>
                                        
                                        <div class="flt_l">
                                        <asp:DropDownList ID="drpAnalysisDetail" CssClass="input_field" runat="server" >
                                        </asp:DropDownList>
                                        </div>
                                        
                                        <asp:HiddenField ID="hidDOGUID" runat="server" 
                                            Value='<%# Eval("sDOGUID") %>' />
                                        <asp:HiddenField ID="hidSugType" runat="server" 
                                            Value='<%# Eval("sSugType") %>' />
                                        <asp:HiddenField ID="hidAnalysisMain" runat="server" 
                                            Value='<%# Eval("sAnalysisMain") %>' />
                                        <asp:HiddenField ID="hidAnalysisDetail" runat="server" 
                                            Value='<%# Eval("sAnalysisDetail") %>' />
                                        <asp:HiddenField ID="txtSuggestion0" runat="server" 
                                            Value='<%# Eval("sSugText") %>' />
                                    
                                    </td>
                                </tr>
                                <tr>
                                    <td>               
                                        <asp:TextBox ID="txtSuggestion" runat="server" CssClass="input_field" Width="100%" 
                                            TextMode="MultiLine" OnFocus="javascript:if(this.value=='限300字以內') {this.value=''}"
                                            OnBlur="javascript:if(this.value==''){this.value='限300字以內'}" Text='<%# Eval("sSugText") %>'
                                            onkeyup="this.value = this.value.slice(0,300)" Rows="5"></asp:TextBox>
   
                                    </td>
                                </tr>
                            </table>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="NoneNumber" HeaderText="空白列" Visible="False">
                        <ItemStyle Width="10px" />
                    </asp:BoundField>
                </Columns>
            </asp:GridView>   
        
        
        </td> 
          
           
           
        </tr>
        
        
        
        
        
        <%--<tr>
          <td align="left" valign="top"><p>11</p></td>
          <td><p>&nbsp;若有其他建議，請您於下方說明</p></td>
        </tr>
        <tr>
          <td align="left" valign="top">&nbsp;</td>
          <td>
            <textarea name="textarea" rows="5" class="input_field" id="textarea" placeholder="限300字以內"></textarea>
          </td>
        </tr>--%>
        
        
        
        
        <tr>
          <td colspan="2" align="left" valign="top">
          <%--<input type="button" name="button" class="butn input_field form_tx" value="送出問卷 抽獎GO" onClick="location.href='survey_login.html'">--%>
              <asp:Button ID="sendY_btn" runat="server" Text="送出問卷 抽獎GO" 
                  CssClass="butn input_field form_tx" onclick="sendY_btn_Click1" />
          </td>
        </tr>
        <tr>
          <td colspan="2">
          <%--<input type="button" name="button" class="butn input_field form_tx" value="送出問卷 不抽獎" onClick="location.href='survey_nonlog.html'">--%>
              <asp:Button ID="sendN_btn" runat="server" Text="送出問卷 不抽獎" 
                  CssClass="butn input_field form_tx" onclick="sendN_btn_Click1"/>
          
          </td>
        </tr>
          
          
        <tr>
          <td colspan="2">
            
          <asp:Label ID="lblQ9" runat="server" Visible="False"></asp:Label>
          <asp:RadioButtonList ID="rblQ9" runat="server" Visible="False"></asp:RadioButtonList>
          <asp:Label ID="lblQ10" runat="server" Visible="False"></asp:Label>
          <asp:RadioButtonList ID="rblQ10" runat="server" Visible="False"></asp:RadioButtonList>
          <asp:Label ID="lblQ11" runat="server" Visible="False"></asp:Label>
          <asp:DropDownList ID="drpQ11" runat="server" Visible="False"></asp:DropDownList> 
                                        
          <asp:Label ID="lblVersionID" runat="server" Visible="False"></asp:Label>
          <asp:Label ID="lblMainDataGUID" runat="server" Visible="False"></asp:Label>
          <asp:Label ID="lblVersionName" runat="server" Visible="False"></asp:Label>
          <asp:Label ID="lbl115_SC_IQType" runat="server"  Visible="false"></asp:Label>
          
          
          </td>
        </tr>
      </tbody>
  </table>
    </ContentTemplate>
     </asp:UpdatePanel>
  </div>
</div>
</form>
</body>
    </html>

