<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="图片下载权限控制2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        用户名：<asp:TextBox ID="txtUsrName" runat="server"></asp:TextBox>
    
        <br />
        密　码：<asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox>
    
        <br />
        <asp:Label ID="loginMsg" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="loginBtn" runat="server" onclick="loginBtn_Click" Text="登录" />
    
    </div>
    </form>
</body>
</html>
