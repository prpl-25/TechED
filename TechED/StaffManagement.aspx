<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StaffManagement.aspx.cs" Inherits="TechEd.About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Staff Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>As an authorized user (staff) you can add or remove people from Staff.xml</h1>
            <h2>You can manipulate data in Staff.xml</h2>
            <h3>Add a user</h3>
            <asp:Label ID="username" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="password" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="addBtn" runat="server" Text="Add User as Staff" OnClick="addBtn_Click"/>
            <asp:Label ID="response" runat="server" Text=""></asp:Label>
            <br /><br />
            <h3>Remove a user</h3>
            <asp:Label ID="usernameR" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="txtUsernameR" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="removeBtn" runat="server" Text="Add User as Staff" OnClick="removeBtn_Click"/>
            <asp:Label ID="response2" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>