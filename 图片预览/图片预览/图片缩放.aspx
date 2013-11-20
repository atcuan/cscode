<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="图片缩放.aspx.cs" Inherits="图片预览.图片缩放" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title></title>
    <script src="js/jquery-1.4.2.js" type="text/javascript"></script>
</head>
<body>
 <form id="form1" runat="server">
  <div>

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
    
    <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
      <HeaderTemplate><table id="tab_imgs"><tr></HeaderTemplate>
      <ItemTemplate>
       <td><img src="images/<%#Eval("pic_path") %>" pic_remarks="<%#Eval("pic_remarks") %>" pic_id=<%#Eval("id") %> width="200" height="150" /></td>
      </ItemTemplate>
      <FooterTemplate></tr></table></FooterTemplate>
    </asp:Repeater>
    
    <script type="text/javascript">
        $(function() {
            $("#tab_imgs img").css("cursor", "pointer").click(function() {
            $(this).animate({ "width": "600", "h    eight": "400" },"slow");
            $("#tab_imgs img").not($(this)).animate({ "width": "200", "height": "150" }, "slow")
            });
        });
    </script>

  </div>
 </form>
</body>
</html>
