<%@ Page Language="C#" AutoEventWireup="true" CodeFile="changeprice.aspx.cs" Inherits="Admin_changeprice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background-color:blueviolet">
  
    <form id="form1" runat="server">
    <div>
    </div>
         <button runat="server" type="button" class="button" onclick="goBack()">
               <span class="button__text">go back</span>
               <span class="button__icon">
                   <ion-icon name="arrow-redo-outline"></ion-icon>
               </span>
           </button>
        <asp:Label ID="Label1" runat="server" Font-Size="37pt" style="z-index: 1; left: 443px; top: 70px; position: absolute; width: 659px;" Text="עדכון מחיר מוצר"></asp:Label>
        <asp:GridView ID="grdMerch" runat="server" style="z-index: 1; left: 895px; top: 162px; position: absolute; height: 115px; width: 196px" OnRowCommand="grdMerch_RowCommand" OnSelectedIndexChanged="grdMerch_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField ButtonType="Button" Text="בחר" />
            </Columns>
        </asp:GridView>
        <asp:Panel ID="pnlChange" runat="server" BackColor="WhiteSmoke" style="z-index: 1; left: 429px; top: 172px; position: absolute; height: 288px; width: 267px">
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 193px; top: 30px; position: absolute; height: 19px; width: 67px;" Text="שם מוצר"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" ReadOnly="True" style="z-index: 1; left: 15px; top: 27px; position: absolute"></asp:TextBox>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 158px; top: 100px; position: absolute; width: 109px;" Text="הכנס אחוז שינוי"></asp:Label>
            <asp:TextBox ID="txtPrec" runat="server" style="z-index: 1; left: 15px; top: 97px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnInc" runat="server" style="z-index: 1; left: 161px; top: 179px; position: absolute" Text="התייקרות" OnClick="btnInc_Click" />
            <asp:Button ID="btnDec" runat="server" style="z-index: 1; left: 39px; top: 179px; position: absolute; width: 67px" Text="הנחה" OnClick="btnDec_Click" />
            <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 64px; top: 220px; position: absolute" Text=":עדכון בוצע. לרענון הדף" Visible="False"></asp:Label>
            <asp:Button ID="btnRefresh" runat="server" OnClick="btnRefresh_Click" style="z-index: 1; left: 96px; top: 252px; position: absolute; width: 71px" Text="לרענון" Visible="False" />
        </asp:Panel>
        <asp:RadioButtonList ID="rbl" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="contenttype" DataValueField="contenttypeid" OnSelectedIndexChanged="rblTy_SelectedIndexChanged" style="z-index: 1; left: 1290px; top: 168px; position: absolute; height: 26px; width: 86px">
        </asp:RadioButtonList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:newly %>" ProviderName="<%$ ConnectionStrings:newly.ProviderName %>" SelectCommand="SELECT [contenttype], [contenttypeid] FROM [tblcontenttype]"></asp:SqlDataSource>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 1308px; top: 140px; position: absolute" Text="סוג מוצר"></asp:Label>
    
    </form>
</body>
       <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
