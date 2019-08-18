<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="SingleItem.aspx.cs" Inherits="ListControls.SingleItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            1. The Checkbox<br />
            <asp:CheckBox ID="CheckBox1" runat="server" />
            <br />
            <br />
            2. The Radio Button List<br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Selected="True">Item 1</asp:ListItem>
                <asp:ListItem>Item 2</asp:ListItem>
                <asp:ListItem>Item 3</asp:ListItem>
                <asp:ListItem>Item 4</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            3. The dropdownlist<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Selected="True">Item 1</asp:ListItem>
                <asp:ListItem>Item 2</asp:ListItem>
                <asp:ListItem>Item 3</asp:ListItem>
                <asp:ListItem>Item 4</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
