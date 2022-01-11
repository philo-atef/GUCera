<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewCert.aspx.cs" Inherits="GUCera.viewCert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Label ID="Label9" runat="server" Text="Course ID:"></asp:Label>
            <br />
            <asp:TextBox ID="TB6" runat="server"></asp:TextBox>
            <br />
        <asp:Button ID="Button4" runat="server" Text="View Certificates" OnClick="Button4_Click" />
        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="H" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
