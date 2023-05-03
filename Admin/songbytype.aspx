<%@ Page Language="C#" AutoEventWireup="true" CodeFile="songbytype.aspx.cs" Inherits="Admin_songbytype" %>

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
        <asp:Label ID="lble" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 10px; top: 39px; position: absolute" Text="epmty genere"></asp:Label>
        <asp:DropDownList ID="ddlgen" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlgen_SelectedIndexChanged1" style="z-index: 1; left: 812px; top: 193px; position: absolute">
        </asp:DropDownList>
        <asp:GridView ID="grdan" runat="server" style="z-index: 1; left: 371px; top: 245px; position: absolute; height: 163px; width: 289px">
        </asp:GridView>
        <asp:Button ID="btns" runat="server" OnClick="btns_Click" style="z-index: 1; left: 482px; top: 122px; position: absolute" Text="start" />
    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
