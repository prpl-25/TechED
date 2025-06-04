<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MemberOnly.aspx.cs" Inherits="TechEd.MemberOnly" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>This page is for Members Only</h2>
            <asp:Button id="back" runat="server" text="Go Back To Home" onclick="back_Click" />
            <br />

            <h2>Edit Account Info</h2>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="usernametxt" runat="server" Text=""></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Change Password:"></asp:Label><br />
            <asp:Label ID="newPass" runat="server" Text="New Password:"></asp:Label>
            <asp:TextBox ID="txtNewPass" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Label ID="confirmPass" runat="server" Text="Confirm Password:"></asp:Label>
            <asp:TextBox ID="txtConfirmPass" runat="server" TextMode="Password"></asp:TextBox><br />
            <asp:Button ID="changePass" runat="server" Text="Change Password" OnClick="changePass_Click" />
            

        </div>
    </form>
</body>
</html>
