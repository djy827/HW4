<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="网站.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script>
        function back()
        {
            window.open('login.aspx');

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            注册页面<br />
            <br />
            注册ID：<asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <br />
            注册用户名：<asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged"></asp:TextBox>
            <br />
            <br />
            注册密码：<asp:TextBox ID="txtPsw" runat="server" OnTextChanged="txtPsw_TextChanged"></asp:TextBox>
            <br />
            <br />
            确认密码：<asp:TextBox ID="txtPswOK" runat="server" OnTextChanged="txtPswOK_TextChanged"></asp:TextBox>
            <br />
            <br />         
            &nbsp;<asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="注册" />
&nbsp;&nbsp;&nbsp;&nbsp;         
            <input type="button" id="B" value="返回" onclick="back()" />
            <asp:Label ID="lblMess" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>
