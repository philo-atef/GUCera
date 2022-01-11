<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAssignGrades.aspx.cs" Inherits="GUCera.viewAssignGrades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label4" runat="server" Text="Course ID :        "></asp:Label>
            <asp:TextBox ID="CIDT" runat="server"></asp:TextBox>
            <br />
            
            <asp:Label ID="Label6" runat="server" Text="Assigment Type :   "></asp:Label>
            <asp:TextBox ID="ATT" runat="server"></asp:TextBox>
             <br />
            
            <asp:Label ID="Label10" runat="server" Text="Assigment Number :   "></asp:Label>
            <asp:TextBox ID="ANT" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="VG" runat="server" Text="View Grades" OnClick="VG_Click" />
            <br />
        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="H" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
