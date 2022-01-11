<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student Register.aspx.cs" Inherits="GUCera.Student_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please fill below<br />
            first name<br />
            <asp:TextBox ID="firstName" runat="server"></asp:TextBox>
            <br />
            last name<br />
            <asp:TextBox ID="lastName" runat="server"></asp:TextBox>
            <br />
            password<br />
            <asp:TextBox ID="password" runat="server"></asp:TextBox>
            <br />
            email<br />
            <asp:TextBox ID="email" runat="server"></asp:TextBox>
            <br />
            gender<br />
            <asp:DropDownList ID="gender" runat="server">
                <asp:ListItem Value="False">male</asp:ListItem>
                <asp:ListItem Value="True">female</asp:ListItem>
            </asp:DropDownList>
            <br />
            address<br />
            <asp:TextBox ID="address" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="register" Text="register" />
        </div>
    </form>
</body>
</html>
