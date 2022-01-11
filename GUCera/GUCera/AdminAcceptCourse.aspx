<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminAcceptCourse.aspx.cs" Inherits="GUCera.AdminAcceptCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            Course ID:<br />
            <asp:TextBox ID="course" runat="server" style="margin-left: 0px" Width="184px"></asp:TextBox>
        </div>
        <p>
            
            <asp:Button ID="Button1" runat="server" OnClick="submit" Text="Accept" />
        </p>
             <p>
            <asp:Button ID="Button6" runat="server" style="margin-left: 663px" OnClick="Logout" Text="Log Out" />
            <asp:Button ID="Button7" runat="server"  OnClick="Home" Text="Home" />
        </p>
    </form>
</body>
</html>
