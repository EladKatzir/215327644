<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ratelist.aspx.cs" Inherits="Admin_ratelist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:blueviolet">
     <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
     <button runat="server" type="button" class="button" onclick="goBack()">
               <span class="button__text">go back</span>
               <span class="button__icon">
                   <ion-icon name="arrow-redo-outline"></ion-icon>
               </span>
           </button>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="grdrate" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" Font-Size="X-Large" ForeColor="Black" GridLines="Vertical" style="z-index: 1; left: 395px; top: 107px; position: absolute; height: 384px; width: 682px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:TextBox ID="txtavg" runat="server" style="z-index: 1; left: 1177px; top: 322px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblavg" runat="server" Font-Size="X-Large" style="z-index: 1; left: 1184px; top: 289px; position: absolute" Text="average rate"></asp:Label>
        <asp:Label ID="lblw" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 710px; top: 55px; position: absolute" Text="all rating!"></asp:Label>
    </form>
</body>
    <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
