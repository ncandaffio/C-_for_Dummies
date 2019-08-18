<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PerformRequest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!-- Shows the current path -->
            <asp:SiteMapPath ID="SiteMapPath1" Runat="server">
            </asp:SiteMapPath>

            <!-- Specifies the data source -->
            <asp:SiteMapDataSource ID="SiteMapDataSource1" Runat="server" />

            <!-- Displays the map in tree form -->
            <asp:TreeView ID="TreeView1" Runat="Server" 
                DataSourceID="SiteMapDataSource1">
            </asp:TreeView>

            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
