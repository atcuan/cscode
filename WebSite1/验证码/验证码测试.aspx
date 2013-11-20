<%@ Page Language="C#" AutoEventWireup="true" CodeFile="验证码测试.aspx.cs" Inherits="验证码_验证码测试" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<img src="YZM.ashx" onclick="this.src='YZM.ashx?a='+new Date()" /><!--点击图片刷新-->
    <form id="form1" runat="server">
    验证码：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </form>
</body>
</html>
