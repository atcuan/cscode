<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="objds2.aspx.cs" Inherits="Dinding.objdatasrc.objds2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            DeleteMethod="Delete" InsertMethod="Insert" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
            TypeName="Dinding.objdatasrc.DAl.objdsTableAdapters.T_UsersTableAdapter" 
            UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_id" Type="Int64" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="username" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="Original_id" Type="Int64" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="username" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
            </InsertParameters>
        </asp:ObjectDataSource>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
         <ItemTemplate>主键:<%#Eval("id") %>--用户:<%#Eval("username") %>--邮箱:<%#Eval("email") %><hr /></ItemTemplate>
        </asp:Repeater>
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
