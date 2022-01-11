<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="newuser.aspx.cs" Inherits="GUCera.newuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            you have registered successfully, your id is 
        <%=Session["newid"] %>
        </div>
        <asp:Button runat="server" Text="Login" OnClick="Unnamed1_Click" />
    </form>
</body>
</html>

