<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addFeedback.aspx.cs" Inherits="GUCera.addFeedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label7" runat="server" Text="Course ID :        "></asp:Label>
            <asp:TextBox ID="CIDTB" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label8" runat="server" Text="Feedback :   "></asp:Label>
            <asp:TextBox ID="FBT" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Add Feedback" OnClick="AFB_Click" />
            <br />
        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="H" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
