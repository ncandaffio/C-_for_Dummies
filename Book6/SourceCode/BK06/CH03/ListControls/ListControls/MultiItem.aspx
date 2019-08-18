<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="MultiItem.aspx.cs" Inherits="ListControls.MultiItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1. Checkboxlist<br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                <asp:ListItem>Item 1</asp:ListItem>
                <asp:ListItem>Item 2</asp:ListItem>
                <asp:ListItem>Item 3</asp:ListItem>
                <asp:ListItem>Item 4</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            2. Listbox<br />
            <asp:ListBox ID="ListBox1" runat="server" 
                SelectionMode="Multiple">   
                <asp:ListItem>Item 1</asp:ListItem>
                <asp:ListItem>Item 2</asp:ListItem>
                <asp:ListItem>Item 3</asp:ListItem>
                <asp:ListItem>Item 4</asp:ListItem>
            </asp:ListBox>
        </div>
    </form>
</body>
</html>
