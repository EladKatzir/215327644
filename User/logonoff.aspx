<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="logonoff.aspx.cs" Inherits="User_logonoff" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            z-index: 1;
            left: 695px;
            top: 310px;
            position: absolute;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <body>
        <asp:Label ID="Label11" runat="server" BackColor="#6a4da6" ForeColor="White"  Font-Size="Large"  style="z-index: 1; left: -7px; top: -5px; position: absolute; height: 45px; width: 356px" Text="Label"></asp:Label>
    <asp:Label ID="lbl" runat="server" style="z-index: 1; left: 677px; top: 239px; position: absolute; height: 54px; width: 203px;" Text="text" BackColor="#CC00FF" Font-Size="X-Large"></asp:Label>
                <asp:Button ID="btn1" runat="server" CssClass="auto-style9"  OnClick="Button1_Click" Text="connect or disconnect" BackColor="purple" Font-Size="16pt" BorderColor="Black" Height="50px" ForeColor="black"  BorderStyle="Groove" BorderWidth="1px" />
            
        </body>
</asp:Content>

