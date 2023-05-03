<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userListByCity.aspx.cs" Inherits="userListByCity" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            z-index: 1;
            position: absolute;
            top: 78px;
            left: 611px;
        }
        .auto-style2 {
            position: absolute;
            top: 136px;
            left: 681px;
            z-index: 1;
            right: 549px;
            height: 54px;
        }
        .auto-style3 {
            z-index: 1;
            width: 422px;
            height: 257px;
            position: absolute;
            top: 205px;
            left: 528px;
        }
        .auto-style4 {
            position: absolute;
            top: 262px;
            left: 57px;
            z-index: 1;
        }
        .auto-style5 {
            position: absolute;
            top: 267px;
            left: 255px;
            z-index: 1;
        }
        #form1 {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
            height: 43px;
            width: 1400px;
        }
    </style>
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
    <div style="width: 1400px; margin: 0 auto;">
    
   
        <asp:GridView ID="grdlist" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" CssClass="auto-style3">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large; font-weight: bold" Text="רשימת משתמשים לפי עיר" CssClass="auto-style1"></asp:Label>
        <asp:DropDownList ID="ddlcity" runat="server" AutoPostBack="True" CssClass="auto-style2" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="CityID" OnSelectedIndexChanged="ddlcity_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:newly %>" ProviderName="<%$ ConnectionStrings:newly.ProviderName %>" SelectCommand="SELECT [CityID], [CityName] FROM [tblUsersCities]"></asp:SqlDataSource>
        <asp:TextBox ID="txtNumC" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="סהכ משתמשים בעיר"></asp:Label>
        <asp:Label ID="lbleu" runat="server" Font-Size="30pt" style="z-index: 1; left: 9px; top: 173px; position: absolute; height: 82px; width: 500px" Text="no users in that city"></asp:Label>

         </div>
    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
