<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="GUCera.HomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      
       <div>
            <p style="margin-left: 480px">
                Welcome Admin   <%=Session["user"] %></p>
        </div>
    <form id="form1" runat="server"> 
 add phone number(s)<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button8" runat="server" Text="add" OnClick="Button1_Click" />
            <br />
            <br />
   
        <asp:Button ID="Button1" runat="server" OnClick="listcourses" Text="List all courses" />
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="listUAcourses" Text="List Courses not yet accepted" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" OnClick="Acceptcourses" Text="Accept Courses" />
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="addpromo" Text="Create Promo Code" />
        </p>
        <asp:Button ID="Button5" runat="server" OnClick="IssuePromo" Text="Issue Promocode To Student" />
        <p>
            <asp:Button ID="Button6" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="Button7" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
