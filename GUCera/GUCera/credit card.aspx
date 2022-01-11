<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="credit card.aspx.cs" Inherits="GUCera.credit_card" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            number<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
            <br />
            name<br />
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <br />
            expiry date<br />
            <asp:Calendar ID="date" runat="server"></asp:Calendar>
            <br />
            cvv<br />
            <asp:TextBox ID="cvvv" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />
        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="H" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
