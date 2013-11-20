<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="下载权限控制.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        用户名：<asp:TextBox ID="usrName" runat="server"></asp:TextBox>
        <br />
        密　码：<asp:TextBox ID="password" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="ErrorMsg" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
        <asp:Button ID="btn" runat="server" onclick="btn_Click" Text="登陆" />
    
    </div>
    </form>
</body>
</html>
