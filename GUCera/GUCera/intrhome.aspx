<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="intrhome.aspx.cs" Inherits="GUCera.intrhome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            add phone number(s)<br />
            <asp:TextBox ID="number" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
