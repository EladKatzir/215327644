<%@ Page Title="" Language="C#" MasterPageFile="~/User/Masterorder.master" AutoEventWireup="true" CodeFile="reciept.aspx.cs" Inherits="User_reciept" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/css/all.min.css"/>
   
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 66px; top: 39px; position: absolute"></asp:TextBox>
        <asp:Panel ID="pnl" runat="server" BackColor="Black" BorderColor="Purple" BorderStyle="Dotted" BorderWidth="12px" style="z-index: 1; left: 426px; top: 160px; position: absolute; height: 415px; width: 848px">
              <asp:TextBox ID="orderid" runat="server" style="z-index: 1; left: 408px; top: 47px; position: absolute; height: 26px; width: 124px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 643px; top: 42px; position: absolute" Text="חשבונית/קבלה"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 583px; top: 47px; position: absolute; height: 33px;  width: 166px" Text="מס' הזמנה" Font-Size="Large" ForeColor="White"></asp:Label>
              <asp:Button ID="print" runat="server" OnClick="print_Click" style="z-index: 1; left: 438px; top: 289px; position: absolute; height: 61px; width: 203px" Text="הדפס" />
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 524px; top: 102px; position: absolute; font-size: large; width: 195px; text-align: center" Text="מספר כרטיס" Font-Size="Large" ForeColor="White"></asp:Label>
        <asp:TextBox ID="credit" runat="server" style="z-index: 1; left: 355px; top: 102px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 565px; top: 165px; position: absolute; font-size: large; text-align: center" Text="כמות פריטים" ForeColor="White"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 594px; top: 203px; position: absolute; font-size: large; text-align: center" Text="מחיר" ForeColor="White"></asp:Label>
        <asp:TextBox ID="amount" runat="server" style="z-index: 1; left: 354px; top: 161px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="price" runat="server" style="z-index: 1; left: 353px; top: 204px; position: absolute"></asp:TextBox>
              <asp:ImageButton ID="imgeye" runat="server" Height="29px" ImageUrl="../images/eyeo.png" style="z-index: 1; left: 495px; top: 101px; position: absolute" Width="30px" OnClick="imgeye_Click" />
        <asp:GridView ID="grdrec" runat="server" style="z-index: 1; left: -313px; top: -6px; position: absolute; height: 125px; width: 283px" CellPadding="4" ForeColor="White" GridLines="Horizontal" BackColor="Black" BorderColor="Purple" BorderStyle="Dashed" BorderWidth="10px">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
     </asp:Panel>
      
</asp:Content>

