<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="objds.aspx.cs" Inherits="Dinding.objdatasrc.objds" %>

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
            TypeName="Dinding.objdatasrc.DAl.objdsTableAdapters.T_PersonTableAdapter" 
            UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_id" Type="Int64" />
            </DeleteParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="age" Type="Int32" />
                <asp:Parameter Name="Original_id" Type="Int64" />
            </UpdateParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="age" Type="Int32" />
            </InsertParameters>
        </asp:ObjectDataSource>
    
    </div>
    <asp:DropDownList ID="DropDownList1" runat="server" AppendDataBoundItems="True" 
        DataSourceID="ObjectDataSource1" DataTextField="name" DataValueField="id" 
        Height="16px" Width="82px">
        <asp:ListItem Selected="True">请选择姓名</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="age" DataValueField="id">
    </asp:CheckBoxList>
    <asp:BulletedList ID="BulletedList1" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="id" DataValueField="id">
    </asp:BulletedList>
    <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
        DataSourceID="ObjectDataSource1" DataTextField="name" DataValueField="id">
    </asp:RadioButtonList>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    </form>
</body>
</html>
