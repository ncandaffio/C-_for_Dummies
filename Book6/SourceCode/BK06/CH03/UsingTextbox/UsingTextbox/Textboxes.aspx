<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Textboxes.aspx.cs" Inherits="UsingTextbox.Textboxes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1 - The TextBox<br />
            <asp:TextBox ID="TextBox1" 
                runat="server">The TextBox</asp:TextBox>
            <br />
            <br />
            2. The TextArea<br />
            <asp:TextBox ID="TextBox2" runat="server" 
                TextMode="MultiLine">The TextArea</asp:TextBox>
            <br />
            <br />
            3. The Password<br />
            <asp:TextBox ID="TextBox3" runat="server" 
                TextMode="Password">The Password</asp:TextBox>
        </div>
    </form>
</body>
</html>
