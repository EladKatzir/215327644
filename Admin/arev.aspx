<%@ Page Language="C#" AutoEventWireup="true" CodeFile="arev.aspx.cs" Inherits="Admin_arev" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <style>
        body {
            background-image: url('../images/backrev.png');
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
            height: 98px;
            width: 84px;
            color: #3498db;
            font-size: 1.5em;
            box-shadow:none;
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
        <asp:Button ID="Button1" runat="server" CssClass="btn" style="z-index: 1; left: 11%; position: absolute; width: 102px; top: 320px;" OnClick="Button1_Click" />
        <p>
        <asp:Button ID="Button2" runat="server" CssClass="btn" style="z-index: 1; left: 11%;  position: absolute; top: 522px;" OnClick="Button2_Click" />
        </p>
    </form>
</body>
     <script>
    function goBack() {
      window.history.back();
    }
  </script>
</html>
