<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Dinding._Default" %>

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
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" 
            DataSourceID="ObjectDataSource1" DataTextField="username" DataValueField="id">
        </asp:DropDownList>
        <br />
        <br />
        <asp:XmlDataSource ID="XmlDataSource1" runat="server"></asp:XmlDataSource>
        <br />
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" 
            BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
            Font-Size="0.8em" ForeColor="#333333">
            <TextBoxStyle Font-Size="0.8em" />
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" 
                BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" 
                ForeColor="White" />
        </asp:Login>
        <br />
        <br />
        <br />
        <asp:LoginView ID="LoginView1" runat="server" 
            onviewchanged="LoginView1_ViewChanged">
        </asp:LoginView>
        <asp:PasswordRecovery ID="PasswordRecovery1" runat="server">
        </asp:PasswordRecovery>
        <br />
        <br />
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
        <br />
        <br />
        <asp:LoginName ID="LoginName1" runat="server" />
        <asp:ChangePassword ID="ChangePassword1" runat="server">
        </asp:ChangePassword>
        <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep runat="server" />
                <asp:CompleteWizardStep runat="server" />
            </WizardSteps>
        </asp:CreateUserWizard>
        <asp:LoginView ID="LoginView2" runat="server">
        </asp:LoginView>
    
        <br />
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
            DeleteMethod="Delete" InsertMethod="Insert" 
            OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
            TypeName="Dinding.objdatasrc.DAl.objdsTableAdapters.T_UsersTableAdapter" 
            UpdateMethod="Update">
            <DeleteParameters>
                <asp:Parameter Name="Original_id" Type="Int64" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="username" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="username" Type="String" />
                <asp:Parameter Name="password" Type="String" />
                <asp:Parameter Name="sex" Type="String" />
                <asp:Parameter Name="email" Type="String" />
                <asp:Parameter Name="Original_id" Type="Int64" />
            </UpdateParameters>
        </asp:ObjectDataSource>
        <br />
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
        </asp:Repeater>
        <br />
        <br />
    
    </div>
    <br />
    <asp:DropDownList ID="DropDownList2" runat="server" 
        DataSourceID="ObjectDataSource2" DataTextField="id" DataValueField="password">
    </asp:DropDownList>
    <br />
    </form>
</body>
</html>
