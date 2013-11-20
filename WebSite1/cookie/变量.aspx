<%@ Page Language="C#" AutoEventWireup="true" CodeFile="变量.aspx.cs" Inherits="cookie_变量" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <p>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            Text="设置session" />
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            Text="读取session" />
    </p>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
