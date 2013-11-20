<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="登录注册同页._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="Panel1" runat="server" GroupingText="登录">
    </asp:Panel>
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" ValidationGroup="login"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="RequiredFieldValidator" 
            ValidationGroup="login"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="login"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="RequiredFieldValidator" 
            ValidationGroup="login"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" ValidationGroup="login" />
    
    </div>
    <asp:Panel ID="Panel2" runat="server" GroupingText="注册">
        <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="Reg"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox3" ErrorMessage="RequiredFieldValidator" 
            ValidationGroup="Reg"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" ValidationGroup="Reg"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
            ControlToValidate="TextBox4" ErrorMessage="RequiredFieldValidator" 
            ValidationGroup="Reg"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="Reg"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="TextBox5" ErrorMessage="RequiredFieldValidator" 
            ValidationGroup="Reg"></asp:RequiredFieldValidator>
        <br />
        <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="Reg"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="TextBox6" ErrorMessage="RequiredFieldValidator" 
            ValidationGroup="Reg"></asp:RequiredFieldValidator>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Button" ValidationGroup="Reg" 
            onclick="Button2_Click" />
    </asp:Panel>
    </form>
</body>
</html>
