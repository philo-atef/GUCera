<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIssuePromo.aspx.cs" Inherits="GUCera.AdminIssuePromo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            Promocode:</p>
        <p>
            <asp:TextBox ID="code" runat="server"></asp:TextBox>
        </p>
        <p>
            Student ID:</p>
        <p>
            <asp:TextBox ID="stud" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" OnClick="submit" Text="Submit" />
             <p>
            <asp:Button ID="Button6" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="Button7" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
