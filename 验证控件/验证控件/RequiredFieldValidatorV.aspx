<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequiredFieldValidatorV.aspx.cs" Inherits="验证控件._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" AutoPostBack="True" Height="22px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="不能为空" 
            SetFocusOnError="True"></asp:RequiredFieldValidator>
    
    </div>
    <p>
        <asp:TextBox ID="TextBox2" runat="server">请输入关键字</asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="请输入关键字" InitialValue="请输入关键字"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>--请选择性别--</asp:ListItem>
            <asp:ListItem Value="male">男</asp:ListItem>
            <asp:ListItem Value="female">女</asp:ListItem>
            <asp:ListItem Value="secret">保密</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="DropDownList1" ErrorMessage="--请选择性别--" 
            InitialValue="--请选择性别--"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </p>
    </form>
</body>
</html>
