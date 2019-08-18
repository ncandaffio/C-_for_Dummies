<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="WebFormTest.TestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="Value1" runat="server" Text="1"></asp:TextBox><br />
            <asp:TextBox ID="Value2" runat="server" Text="2"></asp:TextBox><br />
            <asp:Button ID="Invoke" runat="server" Text="Invoke" OnClick="Invoke_Click" /><br />
            <asp:Label ID="Result" runat="server" Text="0"></asp:Label>
        </div>
    </form>
</body>
</html>
