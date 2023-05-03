<%@ Page Title="" Language="C#" MasterPageFile="~/User/Masterorder.master" AutoEventWireup="true" CodeFile="addtobasket.aspx.cs" Inherits="addtobasket" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
        <div>
        <asp:Panel ID="pnlPay" runat="server" style="z-index: 1;left: 780px; top: 300px; position: absolute; height: 223px; width: 317px" BackColor="black">
            <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 174px; top: 70px; position: absolute; width: 122px;" Text=":מחיר סופי לתשלום" ForeColor="Fuchsia"></asp:Label>
            <asp:TextBox ID="txtPay" runat="server" ReadOnly="True" style="z-index: 1; left: 24px; top: 69px; position: absolute; width: 100px;"></asp:TextBox>
            <asp:Button ID="btnCart" runat="server" OnClick="btnCart_Click" style="z-index: 1; left: 119px; top: 156px; position: absolute; width: 84px" Text="הוסף לסל" BackColor="#CC00CC" />
            <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 14px; top: 125px; position: absolute" Text="הוסף לסל בהצלחה" Visible="False" ForeColor="Fuchsia"></asp:Label>
            <asp:TextBox ID="txtid" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute"></asp:TextBox>
        </asp:Panel>
        <asp:Button ID="Button1" runat="server" BackColor="Black" ForeColor="Purple" OnClick="Button1_Click" style="z-index: 1; left: 533px; top: 300px; position: absolute" Text="coupon" />
        <asp:TextBox ID="txtcoup" runat="server" style="z-index: 1; left: 140px; top: 301px; position: absolute; width: 362px">enter coupon</asp:TextBox>
            <asp:TextBox ID="txtper" runat="server" style="z-index: 1; left: 194px; top: 329px; position: absolute">enter precent</asp:TextBox>
    </div>
</asp:Content>

