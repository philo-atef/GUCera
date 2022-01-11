<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAddPromo.aspx.cs" Inherits="GUCera.AdminAddPromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Code:</div>
        <p>
            <asp:TextBox ID="code" runat="server"></asp:TextBox>
        </p>
        <p>
            Issue Date:</p>
        <p>
            <asp:TextBox ID="Idate" runat="server"></asp:TextBox>
        </p>
        <p>
            Expiry Date:</p>
        <p>
            <asp:TextBox ID="Edate" runat="server"></asp:TextBox>
        </p>
        <p>
            Discount:</p>
        <p>
            <asp:TextBox ID="Discount" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="submit" Text="Submit" />
             <p>
            <asp:Button ID="Button6" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="Button7" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
