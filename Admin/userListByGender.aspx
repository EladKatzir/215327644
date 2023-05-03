<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userListByGender.aspx.cs" Inherits="Admin_userListByGender" %>

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
        .auto-style6 {
            position: absolute;
            top: 145px;
            left: 630px;
            z-index: 1;
        }
        .auto-style7 {
            width: 401px;
            height: 249px;
            position: absolute;
            top: 198px;
            left: 540px;
            z-index: 1;
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
    <div>
    
    </div>
        <asp:GridView ID="grdlist" runat="server" CellPadding="4" CssClass="auto-style7" ForeColor="#333333" GridLines="None">
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
        <asp:Label ID="Label1" runat="server" style="font-size: xx-large; font-weight: bold" Text="רשימת משתמשים לפי מגדר" CssClass="auto-style1"></asp:Label>
        <asp:DropDownList ID="ddlgender" runat="server" AutoPostBack="True" CssClass="auto-style6" DataSourceID="SqlDataSource1" DataTextField="Gender" DataValueField="GenderID" OnSelectedIndexChanged="ddlgender_SelectedIndexChanged1">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:newly %>" ProviderName="<%$ ConnectionStrings:newly.ProviderName %>" SelectCommand="SELECT [Gender], [GenderID] FROM [tblUsersGender]"></asp:SqlDataSource>
        <asp:TextBox ID="txtNumC" runat="server" CssClass="auto-style4"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="סהכ משתמשים במגדר"></asp:Label>
        <asp:Label ID="lbleu" runat="server" Font-Size="30pt" style="z-index: 1; left: 9px; top: 173px; position: absolute; height: 82px; width: 500px" Text="no users in that city"></asp:Label>

    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
