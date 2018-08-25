<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="网站.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            科目一在线答题网站<br />
            <br />
            登陆ID:<asp:TextBox ID="txtLoginID" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
            登陆密码:&nbsp;
            <asp:TextBox ID="txtLoginPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnlogin" runat="server" OnClick="btnlogin_Click" Text="登陆" />
&nbsp;&nbsp;
            <asp:Button ID="btnCanle" runat="server" Text="取消" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnrg" runat="server" OnClick="btnrg_Click" Text="注册" />
            <br />
            <asp:Label ID="lblMess" runat="server" ForeColor="Red"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
