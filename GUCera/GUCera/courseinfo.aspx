<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="courseinfo.aspx.cs" Inherits="GUCera.courseinfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 114px">

            enter instructor ID<br />
            <asp:TextBox ID="enroll" runat="server"></asp:TextBox>
            <asp:Button ID="but" runat="server" Text="enrol" OnClick="enrol_Click" />
        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="H" runat="server"  OnClick="Home" Text="Home" />
        </p>
    
    </form>
    </body>
</html>
