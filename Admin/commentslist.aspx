<%@ Page Language="C#" AutoEventWireup="true" CodeFile="commentslist.aspx.cs" Inherits="Admin_commentslist" %>

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
    
    </div>
        <asp:GridView ID="grdcm" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" OnRowCommand="grdcm_RowCommand" style="z-index: 1; left: 175px; top: 323px; position: absolute; height: 404px; width: 664px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="delete" ShowHeader="True" Text="press" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
        <asp:Button ID="btnall" runat="server" Font-Size="XX-Large" OnClick="btnall_Click" style="z-index: 1; left: 182px; top: 241px; position: absolute" Text="show all comments" />
        <asp:DropDownList ID="ddltype" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="commentType" DataValueField="commentType" Font-Size="Large" OnSelectedIndexChanged="ddltype_SelectedIndexChanged" style="z-index: 1; left: 797px; top: 239px; position: absolute">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\215327644elad.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [commentType] FROM [tblComment]"></asp:SqlDataSource>
    </form>
</body>
    <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
