<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseThePhoneNumber.aspx.cs" Inherits="CreateUserControl.UseThePhoneNumber" %>

<%@ Register Src="~/PhoneNumber.ascx" TagPrefix="uc1" TagName="PhoneNumber" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:PhoneNumber runat="server" id="PhoneNumber" /><br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
