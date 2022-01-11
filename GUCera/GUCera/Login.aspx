<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUCera.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Log in<br />
            ID:<br />
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br />
            password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="login" Text="Login" />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="register" Text="I don't have an account" />
            <br />
        </div>
    </form>
</body>
</html>
