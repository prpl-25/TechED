<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Member.aspx.cs" Inherits="TechEd.Member" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Member Registration (Self Register)</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>You can self subscribe to be a member</h2>
            <asp:Label ID="username" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            <asp:Label ID="password" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox><br />
            <asp:Label ID="captcha" runat="server" Text="CAPTCHA: "></asp:Label>
            <asp:Label ID="generatedCaptcha" runat="server"></asp:Label>
            <asp:TextBox ID="enteredCaptcha" runat="server"></asp:TextBox><br />
            <asp:Button ID="register" runat="server" Text="Register" OnClick="register_Click"></asp:Button>
            <asp:Label ID="message" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
