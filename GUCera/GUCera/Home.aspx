<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GUCera.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
            <p style="margin-left: 480px">
                Welcome Student  <%=Session["user"] %></p>
        </div>
    <form id="form1" runat="server">
        <div>
            add phone number(s)<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
            
            <asp:Button ID="Button1" runat="server" Text="add phone number" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="view courses" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="View my profile" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Text="View my promocodes" OnClick="Button4_Click" />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="add credit card" OnClick="Button5_Click" />
            <br />
            <br />
            Student II:<br />
            <br />
            <div>
            
            <asp:Button ID="pButton5" runat="server" Text="View Assignments" OnClick="pButton5_Click" />
            
        </div>
        <div>
            <br />
            <asp:Button ID="pButton6" runat="server" Text="Submit Assignments" OnClick="pButton6_Click" />

        </div>
        <div>
            <br />
             <asp:Button ID="pButton7" runat="server" Text="View Assignments' Grades" OnClick="pButton7_Click" />
        </div>
        <div>
            <br />
             <asp:Button ID="pButton8" runat="server" Text="Add Feedbacks" OnClick="pButton8_Click" />
        </div>
        <div>
            <br />
             <asp:Button ID="pButton9" runat="server" Text="View Certificates" OnClick="pButton9_Click" />
           
        </div>

        </div>
        <p>
            <asp:Button ID="LO" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            
        </p>
    </form>
</body>
</html>
