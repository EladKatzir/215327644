<%@ Page Language="C#" AutoEventWireup="true" CodeFile="atype.aspx.cs" Inherits="Admin_atype" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <style>
    body {
        background-image: url('../images/cmdbytype.png');
        background-size: cover;
        background-repeat: no-repeat;
    }
    .btn {
        cursor: pointer;
        border-radius: 50%;
        border: none;
        background-color: transparent;
        text-shadow: inherit;
        height: 24.6%;
        width: 14.1%;
        color: #3498db;
        font-size: 1.5em;
        box-shadow: none;
        position: absolute;
    }
    
    #btnrev {
        z-index: 1;
        left: 66.5%;
        top: 32.6%;
        font-size: 3em;
    }

    #btnuser {
        z-index: 1;
        left: 13.3%;
        top: 32.6%;
        font-size: 3em;
    }

    #btnpro {
        z-index: 1;
        left: 39.7%;
        top: 32.5%;
        font-size: 3em;
    }
</style>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnrev" runat="server" CssClass="btn" Font-Bold="True" ForeColor="White" OnClick="btnrev_Click" />
            <asp:Button ID="btnuser" runat="server" CssClass="btn" Font-Bold="True" ForeColor="White" OnClick="btnuser_Click" />
            <asp:Button ID="btnpro" runat="server" CssClass="btn" Font-Bold="True" ForeColor="White" OnClick="btnpro_Click" />
        </div>
    </form>
</body>


</html>
