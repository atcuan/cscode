<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="图片备注预览.aspx.cs" Inherits="图片预览.图片预览" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script src="js/jquery-1.4.2.js" type="text/javascript"></script>
</head>   
<body>
    <form id="form1" runat="server">
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        DeleteMethod="Delete" InsertMethod="Insert" 
        OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" 
        TypeName="图片预览.DAL.DataSetPicTableAdapters.pic_infoTableAdapter" 
        UpdateMethod="Update">
        <DeleteParameters>
            <asp:Parameter Name="Original_id" Type="Int32" />
        </DeleteParameters>
        <UpdateParameters>
            <asp:Parameter Name="pic_path" Type="String" />
            <asp:Parameter Name="pic_remarks" Type="String" />
            <asp:Parameter Name="Original_id" Type="Int32" />
        </UpdateParameters>
        <InsertParameters>
            <asp:Parameter Name="pic_path" Type="String" />
            <asp:Parameter Name="pic_remarks" Type="String" />
        </InsertParameters>
    </asp:ObjectDataSource>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
        DataSourceID="ObjectDataSource1" DataTextField="pic_path" 
        DataValueField="id" AppendDataBoundItems="True">
        <asp:ListItem>图片地址</asp:ListItem>
    </asp:DropDownList>
    
    </form>
    
    <div>
        <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
        <HeaderTemplate><table id="tab_imgs"><tr><td></HeaderTemplate>
        <ItemTemplate>
            <td><img width="400px" height="250px" src="images/<%#Eval("pic_path") %>" remarks="<%#Eval("pic_remarks") %>" pid="<%#Eval("id") %>" /></td>
        </ItemTemplate>
        <FooterTemplate></td></tr></table></FooterTemplate>
        </asp:Repeater>
         <script type="text/javascript">
             $(function() {
             $("img").mouseenter(function(e) {
             $("#data").text($(this).attr("remarks"));
             $("#age").text($(this).attr("pid"));
             $("#divDetails").css("top", e.pageY).css("left", e.pageX).show("slow");
             });
             });
     </script>
    </div>
    
    <div style="display:none;position:absolute;background:green;" id="divDetails">
        <p>时间：<span id="data"></span></p>
        <p>年龄<span id="age"></span></p>
    </div>
</body>
</html>
