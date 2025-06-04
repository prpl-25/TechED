<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TechEd.Login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <style>
        .table {
            width: 100%;
            border-collapse: collapse;
        }

        .table th {
            background-color: #f2f2f2;
            font-weight: normal;
        }

        .table th, .table td {
            border: 1px solid black;
            padding: 8px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login to continue (Enter any username and password)</h2>
            <asp:Label ID="lblUsername" runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox><br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />            
            
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        
        </div>
     
        <div>
            <h2>Service Directory</h2>
            <table class="table">
                <tr>
                    <th>Provider Name</th>
                    <th>Component Type</th>
                    <th>Operation Name</th>
                    <th>Parameters</th>
                    <th>Return Type</th>
                    <th>Function Description</th>
                    <th>TryIt Link</th>
                </tr>

                 <tr>
                     <th>Sindhu Rallabhandi</th>
                     <th>RESTful Service</th>
                     <th>Word Filter Service</th>
                     <th>string</th>
                     <th>string</th>
                     <th>Remove stop words from a string and return the string</th>
                     <th>implemented in the web app - FunZone.aspx.cs</th>
                 </tr>

                <tr>
                    <th>Sindhu Rallabhandi</th>
                    <th>RESTful Service</th>
                    <th>Web Downloading Service</th>
                    <th>url</th>
                    <th>string</th>
                    <th>Display the contents of the web page</th>
                    <th>implemented in the web app - FunZone.aspx.cs</th>
                </tr>

                <tr>
                    <th>Sindhu Rallabhandi</th>
                    <th>RESTful Service</th>
                    <th>NewsFocus Service</th>
                    <th>no input</th>
                    <th>articles</th>
                    <th>Fetches articles on technology using NewsAPI</th>
                    <th>implemented in the web app - Articles.aspx.cs</th>
                </tr>

                <tr>
                    <th>Sindhu Rallabhandi</th>
                    <th>Local Component</th>
                    <th>Cookies</th>
                    <th>username</th>
                    <th>-</th>
                    <th>stores the logged in username state for 1 minute</th>
                    <th>implemented in the web app - Login.aspx.cs</th>
                </tr>

                <tr>
                    <th>Sindhu Rallabhandi</th>
                    <th>Local Component</th>
                    <th>Event handler in Global.asax</th>
                    <th>-</th>
                    <th>-</th>
                    <th>Handles errors or exceptions that can occur within the application</th>
                    <th>implemented in the web app</th>
                </tr>

                <tr>
                    <th>Sindhu Rallabhandi</th>
                    <th>DLL</th>
                    <th>Hashing function</th>
                    <th>-</th>
                    <th>-</th>
                    <th>Hashes the password</th>
                    <th>used in Member.aspx.cs </th>
                </tr>

                 <tr>
                     <th>Sindhu Rallabhandi</th>
                     <th>Forms Security</th>
                     <th>Access to Staff.xml</th>
                     <th>-</th>
                     <th>-</th>
                     <th>Admin can add credentials or remove from Staff.xml</th>
                     <th>implemented in StaffManagement.aspx.cs</th>
                 </tr>
            </table>
        </div>
    </form>
</body>
</html>
