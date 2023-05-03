<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ulogin.aspx.cs" Inherits="User_ulogin" %>
  
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="~/masterstyle.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css">  
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css">  
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <style type="text/css">
        .auto-style5 {
            position: absolute;
            top: 109px;
            left: 404px;
             z-index: 1;
            height: 38px;
            width: 132px;
        }
        .auto-style6 {
            position: absolute;
            top: 191px;
            left: 405px;
            z-index: 1;
            height: 2px;
             width: 300px;
        }
        .auto-style7 {
            position: absolute;
            top: 103px;
            left: 750px;
            z-index: 1;
            width: 300px;
            height: 100px;
        }
        .auto-style8 {
            position: absolute;
            top: 180px;
            left: 751px;
            z-index: 1;
            width: 300px;
            height: 100px;
        }
        .auto-style9 {
            position: absolute;
            top: 302px;
            left: 767px;
            z-index: 1;
            height: 100px;
            width: 220px;
        }
        .auto-style11 {
            position: absolute;
            top: 459px;
            left: 785px;
            z-index: 1;
            width: 256px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <body>
            <div style="width: 1351px; margin: 0 auto; height: 456px;">
    
    
       <a href="homepage.aspx" style="border: medium groove white; z-index: 1; left: 777px; top: 393px; position: absolute; height: 50px; width: 283px; font-size:x-large; text-align:end; text-decoration:none">
           <button runat="server" type="button" class="button" onclick="btnsignup_Click"/>
               <span class="button__text">homepage</span>
               <span class="button__icon">
                   <ion-icon name="home-outline"></ion-icon>
               </span>
           </button>

            </a>
    
    
       
            <asp:Label ID="Label2" runat="server" CssClass="auto-style5" Text="username:" Font-Size="18pt" Font-Bold="True" ForeColor="White" Height="50px" Width="150px"></asp:Label>
            <asp:Label ID="Label3" runat="server" CssClass="auto-style6" Text="password:" Font-Size="18pt" Font-Bold="True" ForeColor="White" Width="150px" style="left: 407px; top: 191px"></asp:Label>
            <asp:TextBox ID="txtuser" runat="server" CssClass="auto-style7"  BorderColor="Black" OnTextChanged="txtuser_TextChanged" Height="50px" Width="300px" BackColor="Black" ForeColor="Purple"></asp:TextBox>
            <asp:TextBox ID="txtpass" runat="server" CssClass="auto-style8"  BorderColor="Black" OnTextChanged="txtpass_TextChanged" Height="50px" Width="300px" BackColor="Black" ForeColor="Purple"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" CssClass="auto-style9"  OnClick="Button1_Click" Text="connect" BackColor="purple" Font-Size="16pt" BorderColor="Black" Height="50px" ForeColor="black"  BorderStyle="Groove" />
            <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style11" Font-Size="14pt" Font-Underline="True">lost your password? reset it now</asp:HyperLink>
            <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 990px; top: 307px; position: absolute; height: 56px; width: 216px;" Text="user dont exist" Visible="False" Font-Size="XX-Large" ForeColor="White" Font-Bold="true"></asp:Label>
                <asp:Label ID="Label11" runat="server" BackColor="#6a4da6" ForeColor="White"  Font-Size="Large"  style="z-index: 1; left: -7px; top: -5px; position: absolute; height: 45px; width: 356px" Text="Label"></asp:Label>
        </div>
            <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
</body>

</asp:Content>

