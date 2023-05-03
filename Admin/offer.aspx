<%@ Page Language="C#" AutoEventWireup="true" CodeFile="offer.aspx.cs" Inherits="Admin_offer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background-color:blueviolet">
    <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
    <button runat="server" type="button" class="button" onclick="goBack()">
               <span class="button__text">go back</span>
               <span class="button__icon">
                   <ion-icon name="arrow-redo-outline"></ion-icon>
               </span>
           </button>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Font-Size="37pt" style="z-index: 1; left: 439px; top: 77px; position: absolute; width: 663px;" Text="מבצעים!"></asp:Label>
        <asp:GridView ID="grdMerch" runat="server" style="z-index: 1; left: 831px; top: 276px; position: absolute; height: 115px; width: 196px">
        </asp:GridView>
        <asp:Panel ID="pnlHi" runat="server" BackColor="WhiteSmoke" style="z-index: 1; left: 190px; top: 285px; position: absolute; height: 279px; width: 390px">
            <asp:Label ID="Label2" runat="server" Font-Size="X-Large" style="z-index: 1; left: 227px; top: 17px; position: absolute; height: 29px; width: 142px" Text=":ממוצע מחירים"></asp:Label>
            <asp:TextBox ID="txtAvg" runat="server" style="z-index: 1; left: 35px; top: 39px; position: absolute" ReadOnly="True"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" Font-Size="X-Large" style="z-index: 1; left: 238px; top: 106px; position: absolute" Text=":בחר אחוז"></asp:Label>
            <asp:TextBox ID="txtPrec" runat="server" style="z-index: 1; left: 38px; top: 107px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnInc" runat="server" OnClick="btnInc_Click" style="z-index: 1; left: 231px; top: 164px; position: absolute" Text="התייקרות" />
            <asp:Button ID="btnDec" runat="server" OnClick="btnDec_Click" style="z-index: 1; left: 110px; top: 167px; position: absolute; width: 56px" Text="הנחה" />
            <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 157px; top: 211px; position: absolute" Text="בוצע בהצלחה"></asp:Label>
            <asp:Button ID="btnsucc" runat="server" OnClick="btnsucc_Click" style="z-index: 1; left: 170px; top: 243px; position: absolute" Text="לרענון" />
            <asp:Button ID="btnBack" runat="server" style="z-index: 1; left: 1554px; top: 41px; position: absolute" Text="חזרה" />
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 237px; top: 60px; position: absolute; width: 190px;" Text=":כמות מוצרים באתר" Font-Size="X-Large"></asp:Label>
            <asp:TextBox ID="txtAmount" runat="server" style="z-index: 1; left: 37px; top: 77px; position: absolute" ReadOnly="True"></asp:TextBox>
        </asp:Panel>
    </div>
        
        <asp:Panel ID="pnlcoup" runat="server" BackColor="White" style="z-index: 1; left: 572px; top: 588px; position: absolute; height: 208px; width: 432px" Visible="False">
            <asp:Label ID="lbldone" runat="server" style="z-index: 1; left: 67px; top: 133px; position: absolute" Text="בוצע" Visible="False"></asp:Label>
             <asp:Button ID="up" runat="server" OnClick="up_Click" style="z-index: 1; left: 75px; top: 69px; position: absolute" Text="עדכון" />
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 163px; top: 25px; position: absolute" Text="קופונים"></asp:Label>
        <asp:TextBox ID="name" runat="server" style="z-index: 1; left: 205px; top: 109px; position: absolute">שם קופון</asp:TextBox>
        <asp:TextBox ID="pre" runat="server" style="z-index: 1; left: 202px; top: 158px; position: absolute">אחוז הנחה</asp:TextBox>
        <asp:Button ID="add" runat="server" style="z-index: 1; left: 296px; top: 63px; position: absolute" Text="הוספה" />
        </asp:Panel>
       
        <asp:GridView ID="grdco" runat="server" style="z-index: 1; left: 203px; top: 633px; position: absolute; height: 163px; width: 289px" Visible="False">
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 180px; top: 180px; position: absolute" Text="press to see coupons" />
       
    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
