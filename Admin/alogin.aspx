<%@ Page Language="C#" AutoEventWireup="true" CodeFile="alogin.aspx.cs" Inherits="Admin_alogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background-color:blueviolet">
    <form id="form1" runat="server">
    <div style="width: 1400px; margin: 0 auto;">
        <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 278px; left: 636px; font-weight: bold; font-size: large" Text="pass"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 177px; left: 604px; font-weight: bold; font-size: large" Text="user name"></asp:Label>
        <asp:TextBox ID="txtpass" runat="server" style="z-index: 1; position: absolute; top: 328px; left: 552px; width: 229px; height: 43px"></asp:TextBox>
        <asp:TextBox ID="txtuser" runat="server" style="z-index: 1; position: absolute; top: 225px; left: 556px; width: 231px; height: 39px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; position: absolute; top: 434px; left: 703px; width: 99px; height: 58px" Text="התחבר" OnClick="Button1_Click1"  />
        <asp:Label ID="Labele" runat="server" style="z-index: 1; position: absolute; top: 163px; left: 399px; width: 132px; height: 52px; font-weight: bold; font-size: small" Text="wrong password or username" Visible="False"></asp:Label>
    </div>
    <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 46px; left: 547px; height: 79px; font-weight: bold; font-size: 35pt; width: 421px" Text="admin login"></asp:Label>
    </form>
</body>
</html>
