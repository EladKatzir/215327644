<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addnewcontent.aspx.cs" Inherits="Admin_addnewcontent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body  style="background-color:blueviolet">

    <form id="form1" runat="server">
    <div>
        <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
     <button runat="server" type="button" class="button" onclick="goBack()">
               <span class="button__text">go back</span>
               <span class="button__icon">
                   <ion-icon name="arrow-redo-outline"></ion-icon>
               </span>
           </button>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 236px; top: -155px; position: absolute" Text="add new content"></asp:Label>
    <asp:DropDownList ID="ddltype" runat="server" DataSourceID="SqlDataSource1" DataTextField="contenttype" DataValueField="contenttypeid" style="z-index: 1; left: 392px; top: 136px; position: absolute" AutoPostBack="True" OnSelectedIndexChanged="ddltype_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\215327644elad.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [contenttype], [contenttypeid] FROM [tblcontenttype]"></asp:SqlDataSource>
        <asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: 155px; top: 230px; position: absolute; height: 232px; width: 541px; bottom: 270px" Visible="False">
            <asp:TextBox ID="txtname" runat="server" style="z-index: 1; left: 23px; top: 34px; position: absolute"></asp:TextBox>
             <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 255px; top: 32px; position: absolute" Text="name"></asp:Label>
        <asp:TextBox ID="txtprice" runat="server" style="z-index: 1; left: 28px; top: 105px; position: absolute"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 244px; top: 101px; position: absolute" Text="price"></asp:Label>
        
        <asp:Button ID="btnadd" runat="server" OnClick="btnadd_Click" style="z-index: 1; left: 356px; top: 172px; position: absolute" Text="add" />
        </asp:Panel>
        
        <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 452px; top: 363px; position: absolute" Text="added!" Visible="False"></asp:Label>
    </div>
       
    </form>
</body>
    <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
