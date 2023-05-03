<%@ Page Language="C#" AutoEventWireup="true" CodeFile="apro.aspx.cs" Inherits="Admin_apro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
     <style>
        body {
            background-image: url('../images/backpro.png');
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
            height: 79px;
            width: 78px;
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
    
    </div>
        
        <asp:Button ID="Button1" runat="server" CssClass="btn" style="z-index: 1; left: 207px; top: 323px; position: absolute; bottom: 262px;" OnClick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" CssClass="btn" style="z-index: 1; left: 207px; top: 539px; position: absolute;" OnClick="Button2_Click" />
        <asp:Button ID="Button4" runat="server" CssClass="btn" style="z-index: 1; left: 762px; top: 539px; position: absolute; bottom: 46px;" OnClick="Button4_Click" />
        <asp:Button ID="Button5" runat="server" CssClass="btn" style="z-index: 1; left: 207px; top: 752px; position: absolute;" OnClick="Button5_Click" />
        <asp:Button ID="Button6" runat="server" CssClass="btn" style="z-index: 1; left: 760px; top: 749px; position: absolute;" OnClick="Button6_Click" />
        
        <p>
            &nbsp;</p>
        <p>
        <asp:Button ID="Button3" runat="server" CssClass="btn" style="z-index: 1; left: 761px; top: 332px; position: absolute;" OnClick="Button3_Click" />
        </p>
        
    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
