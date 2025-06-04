<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Staff.aspx.cs" Inherits="TechEd.Staff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Management Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>This page is for authorized users only, please sign in if you are a authorized user</h2>
            <asp:Label ID="username" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
            <asp:Label ID="response" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
