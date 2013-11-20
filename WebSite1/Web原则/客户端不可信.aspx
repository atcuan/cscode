<%@ Page Language="C#" AutoEventWireup="true" CodeFile="客户端不可信.aspx.cs" Inherits="Web原则_客户端不可信" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="getMoney" runat="server" onclick="Button1_Click" Text="取款" OnClientClick="var value = document.getElementById('TextBox1').value;if(parseInt(value,10)>100){alert('金额不能大于100元');return false;}" />
    <!--若禁用JS便可以跳过校验，所以需要在服务端校验，故客户端不可信-->
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
