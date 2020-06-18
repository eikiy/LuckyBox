<%@ Page Language="C#" AutoEventWireup="true" CodeFile="test.aspx.cs" Inherits="test" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <meta http-equiv="X-UA-Compatible" content="IE=9; IE=8;" />
<script>
  (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
  (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
  })(window,document,'script','//www.google-analytics.com/analytics.js','ga');

  ga('create', 'UA-42392000-2', 'hot-7.com');
  ga('send', 'pageview');

</script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList AutoPostBack="True" ID="selecity" runat="server" Width="73px" OnSelectedIndexChanged="selecity_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:DropDownList   ID="cbozip" runat="server" Width="100px">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
