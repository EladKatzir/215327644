<%@ Page Language="C#" AutoEventWireup="true" CodeFile="auser.aspx.cs" Inherits="Admin_amenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
     <style>
        body {
            background-image: url('../images/backu.png');
            background-size: cover;
            background-repeat: no-repeat;
        }
        .btn {
            border-style: none;
             border-color: inherit;
             border-width: medium;
             cursor: pointer;
             border-radius: 50%;
             background-color: transparent;
             text-shadow:inherit;
            height: 106px;
            width: 125px;
             color: #3498db;
             font-size: 1.5em;
             box-shadow: none;
        }
        
    </style>
<body>
       <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
     <button runat="server" type="button" class="button" onclick="goBack()">
               <span class="button__text">go back</span>
               <span class="button__icon">
                   <ion-icon name="arrow-redo-outline"></ion-icon>
               </span>
           </button>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </div>

        <asp:Button ID="Button7" runat="server"  style="z-index: 1; left: 165px; top: 525px; position: absolute" cssclass="btn" OnClick="Button7_Click" />
        <asp:Button ID="Button8" runat="server"  style="z-index: 1; left: 161px; top: 309px; position: absolute" cssclass="btn" OnClick="Button8_Click" />
        <asp:Button ID="Button10" runat="server"  style="z-index: 1; left: 158px; top: 732px; position: absolute" cssclass="btn" OnClick="Button10_Click" />
    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
