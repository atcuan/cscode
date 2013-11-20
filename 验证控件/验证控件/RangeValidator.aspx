<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RangeValidator.aspx.cs" Inherits="验证控件.RangeValidator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ControlToValidate="TextBox1" ErrorMessage="RangeValidator" MaximumValue="6" 
            MinimumValue="18"></asp:RangeValidator>
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator2" runat="server" 
            ControlToValidate="TextBox2" ErrorMessage="RangeValidator" 
            MaximumValue="2012-01-23" MinimumValue="1992-08-10" Type="Date"></asp:RangeValidator>
        <br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            BorderStyle="Dashed" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
    
    </div>
    </form>
</body>
</html>
