<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showMessage.aspx.cs" Inherits="注册登录.showMessage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>正在努力的跳转中...</title>
    <script type="text/jscript">
        setTimeout(function() { location.href = '<%=Request["RedirectURL"] %>'},3000);
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Literal ID="Literal1" Mode="Encode" runat="server"></asp:Literal>
        <a href='<%=Request["RedirectURL"] %>'>点击此处立即跳转</a>
    </div>
    </form>
</body>
</html>
