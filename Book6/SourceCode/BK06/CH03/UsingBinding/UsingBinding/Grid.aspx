<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grid.aspx.cs" 
    Inherits="UsingBinding.Grid" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Chapter3.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <!-- Uncomment this tag to use styles.
            <asp:GridView ID="GridView2" runat="server" 
                CssClass="GridView"></asp:GridView> -->
        </div>
    </form>
</body>
</html>
