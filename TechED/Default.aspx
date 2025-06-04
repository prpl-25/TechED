<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TechEd._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">TechEd</h1>
            <h2>- By Sindhu Vadapalli</h2>
            <p class="lead">TechEd is an educational web app to expose middle school students to technology and spark interest in the field.</p>
            <p class="lead"> Users have access to the top headlines about technology to increase knowledge and be up to date with information. 
                Further, users can go to the "fun zone" where they can experiment and use services provided.
                Currently, the fun zone has 2 "games", WordFilter and WebDownloading.
                Using the services and seeing these cool features will help students gain interest in cs and related fields.
            </p>
            <p class="lead">
                WordFilter: given a string this service removes all stop words and returns thes string.
                For example: given "I am Sindhu", it'll return "I Sindhu"
            </p>
            <p class="lead">
                WebDownloading: given a webpage url, this service displays the contents of that web page.
                For example: given "www.google.com", it'll return the contents of google
            </p>
            <p class="lead">
                NewsFocus: This is the part that returns the list of top headlines in technology.
                This service uses the NewsAPI to fetch articles and displays the result for the user.
            </p>

            <br />
            <h2>How to test services (For TA/ Grader)</h2>
            <p class="lead">
                To run the fun zone services, navigate to the fun zone page and select the service you want to use.
                <br />
                To view the top headlines in technology, navigate to the articles page.
                <br />
                If you want to test the cookies function, close the application and run it in the same browser. This time
                you won't have to log in again since the session is stored for a min.
                <br />
                Go to the Member Page to self register as a member.
                <br />
                Go to the Staff Page, log in using "TA" credentials and edit Staff.xml as a admin
            </p>

            <asp:Button ID="memberBtn" runat="server" Text="Memeber Page" OnClick="memberBtn_Click" />
            <asp:Button ID="staffBtn" runat="server" Text="Staff Page" OnClick="staffBtn_Click"/>

        </section>

    </main>

</asp:Content>
