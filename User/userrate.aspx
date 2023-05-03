<%@ Page Title="" Language="C#" MasterPageFile="~/User/Masterorder.master" AutoEventWireup="true" CodeFile="userrate.aspx.cs" Inherits="User_userrate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

    <asp:Label ID="lblw" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" style="z-index: 1; left: 875px; top: 231px; position: absolute" Text="rate my site!"></asp:Label>
<asp:Panel ID="Panel1" runat="server" BackColor="Black" BorderColor="Purple" BorderStyle="Inset" BorderWidth="10px" ForeColor="White" style="z-index: 1; left: 536px; top: 300px; position: absolute; height: 309px; width: 574px">
    <asp:RadioButtonList ID="rblrate" runat="server" AutoPostBack="True" CellSpacing="70" Font-Bold="True" Font-Size="XX-Large" ForeColor="Purple" RepeatDirection="Horizontal" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 74px; width: 203px">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Button ID="btnrate" runat="server" BackColor="White" Font-Size="X-Large" ForeColor="Black" OnClick="btnrate_Click" style="z-index: 1; left: 257px; top: 207px; position: absolute" Text="press to rate" />
    <asp:Label ID="lblsucc" runat="server" Font-Size="X-Large" style="z-index: 1; left: 69px; top: 207px; position: absolute; height: 28px; width: 99px" Text="done succesfully" Visible="False"></asp:Label>
</asp:Panel>

</asp:Content>

