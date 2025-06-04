<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FunZone.aspx.cs" Inherits="TechEd.FunZone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Run these services! Wanna build cool projects like this? Look into learning coding!</h1>
        </div>
        <div>
            <h2>Word Filter Service</h2>
            <h3>use to remove stop words from strings!</h3>
            <asp:Label ID="inputL" runat="server" Text="Enter a string:"></asp:Label>
            <asp:TextBox ID="input" runat="server"></asp:TextBox>
            <asp:Button ID="submit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
            <br/><br/>
            <asp:Label ID="outputL" runat="server" Text="Result:"></asp:Label>
            <asp:TextBox ID="output" runat="server" Width="300px" Height="100px" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
        </div>

        <br /><br /><br />

        <div>
            <h2>Web Downloading Service</h2>
            <h3>enter a url and see the web page contents!</h3>
            <asp:Label ID="urlLabel" runat="server" Text="Enter a web page URL:"></asp:Label>
            <asp:TextBox ID="inputUrl" runat="server"></asp:TextBox>
            <asp:Button ID="webBtn" runat="server" Text="Go" OnClick="webBtn_Click" />
            <br/><br/>
            <asp:Label ID="resultLabel" runat="server" Text="Result:"></asp:Label>
            <p>
                <asp:Label ID="outputLbl" runat="server" ></asp:Label>&nbsp;</p>
            </div>



    </form>
</body>
</html>
