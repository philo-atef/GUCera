<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courses.aspx.cs" Inherits="GUCera.courses" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 111px">
            view course information<br />
            enter course ID<br />
            <asp:TextBox ID="iden" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="view" OnClick="Button1_Click" />
            <br />
        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="H" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
