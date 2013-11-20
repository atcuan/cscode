<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="注册登录.register" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <style type="text/css">
        .error{color:Red;}
    </style>
        <script src="js/jquery-1.4.2.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(function() {
            $("#<%=txtPassword.ClientID%>").blur(function() {
                //判断密码强度
                var str = $(this).val();
                if (str.length <= 6) {
                    $("#forPassword").text("密码强度：弱");
                }
                else {
                    var regex = /\W/;
                    if (regex.test(str)) {
                        $("#forPassword").text("密码强度：强");
                    }
                    else {
                        $("#forPassword").text("密码强度：中");
                    }
                }
            });

            //判断两次密码是否一致
            $("#<% =form1.ClientID %>").submit(function(e) {
                var pw1 = $("#<% =txtPassword.ClientID %>").val();
                var pw2 = $("#<% =txtPwConfirm.ClientID %>").val();
                if (pw1 != pw2) {
                    alert("两次输入的密码不一致");
                    e.preventDefault();
                    //return false;
                }
            });

            //检查邮箱格式
            $("#<% =txtEmail.ClientID %>").blur(function() {
                var email = $("#<% =txtEmail.ClientID %>").val();
                var regex = /.+@.+/;
                if (!regex.test(email)) {
                    $("#forEmail").text("邮箱地址不合格");
                }
                else {
                    $("#forEmail").text("邮箱地址合格");
                    $("#forEmail").css("color","black");
                }

            });

        });
    </script>

    <title>注册会员</title>
</head>
<body>
    <form id="form1" method="post" runat="server">
    <div>
       <fieldset>
        <legend>用户注册</legend>
        <asp:Label ID="Label1" runat="server" Text="用户名:" 
            AssociatedControlID="txtUsername"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server" 
               ontextchanged="txtUsername_TextChanged" AutoPostBack="True"></asp:TextBox>
        <asp:Label ID="forUsername" CssClass="error" runat="server" Text="Label" Visible="False"></asp:Label>
        <br />
           
        <asp:Label ID="Label2" runat="server" Text="密　码:" 
            AssociatedControlID="txtPassword"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <span id="forPassword"></span>
        <br />
        
        <asp:Label ID="Label3" runat="server" Text="确　认:" 
               AssociatedControlID="txtPwConfirm"></asp:Label>
        <asp:TextBox ID="txtPwConfirm" runat="server" TextMode="Password"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Label" Visible="False"></asp:Label>
        <span id="forConfirm"></span>
        <br />
        
        <asp:Label ID="Label4" runat="server" Text="邮　箱:" AssociatedControlID="txtEmail"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
           <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
        <span id="forEmail" class="error"></span>
        <br />
        
        <asp:Button ID="btnReg" runat="server" Text="提交注册" onclick="btnReg_Click" />
     </fieldset>
    </div>
    </form>
</body>
</html>
