<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Articles.aspx.cs" Inherits="TechEd.Articles" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Fetch top headlines on technology to read and stay up tp date</h1>
        </div>
        <div>
            <h2>NewsFocus Service</h2>
            <h3>Click on the button to fetch articles</h3>
            <asp:Button ID="fetchArticles" runat="server" Text="Get News!" OnClick="fetchArticles_Click" />
        </div>
        <div>
            <asp:Literal ID="outputLiteral" runat="server" />
        </div>
    </form>
</body>
</html>
