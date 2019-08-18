<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" 
    AutoEventWireup="true" CodeBehind="Default.aspx.cs" 
    Inherits="StandardWebApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" 
    runat="server">

    <asp:Label ID="TextToChange" runat="server" 
        Text="This is The Text to Change" Font-Size="Large" OnLoad="ChangeTheColor"></asp:Label>
    <asp:Button ID="ChangeText" runat="server" Text="Click Me" OnClick="ChangeText_Click" />

</asp:Content>
