<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="contant.aspx.cs" Inherits="User_contant" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <body>

    </body>
    <asp:Panel ID="pnlcon" runat="server" BackColor="#CC00CC" style="z-index: 1; left: 1102px; top: 107px; position: absolute; height: 400px; width: 503px; opacity:0.8;border-radius: 50%;">
        <asp:Label ID="lblmail" runat="server" style="z-index: 1; left: 377px; top: 98px; position: absolute; width: 33px;" Text="מייל:"></asp:Label>
        <asp:TextBox ID="txtmail" runat="server" style="z-index: 1; left: 191px; top: 95px; position: absolute; right: 184px;"></asp:TextBox>
        <asp:Label ID="lbltype" runat="server" style="z-index: 1; left: 382px; top: 139px; position: absolute; width: 33px" Text="סוג"></asp:Label>
        <asp:DropDownList ID="ddltype" runat="server" AutoPostBack="True" style="z-index: 1; left: 213px; top: 140px; position: absolute">
            <asp:ListItem Selected="True" Value="null">בחר</asp:ListItem>
            <asp:ListItem>תלונה</asp:ListItem>
            <asp:ListItem>הצעת ייעול</asp:ListItem>
            <asp:ListItem>שאלה</asp:ListItem>
            <asp:ListItem>בקשה</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="lbldate" runat="server" style="z-index: 1; left: 377px; top: 190px; position: absolute" Text="תאריך"></asp:Label>
        <asp:TextBox ID="txtdate" runat="server" style="z-index: 1; left: 183px; top: 187px; position: absolute; width: 126px;" Enabled="False"></asp:TextBox>
        <asp:Label ID="lblcomment" runat="server" style="z-index: 1; left: 384px; top: 239px; position: absolute; width: 33px" Text="הערה"></asp:Label>
        <asp:TextBox ID="txtcomment" runat="server" style="z-index: 1; left: 161px; top: 229px; position: absolute" TextMode="MultiLine"></asp:TextBox>
         <asp:Label ID="lblcon" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" style="z-index: 1; left: 288px; top: 30px; position: absolute; width: 167px" Text="צור קשר"></asp:Label>
        <asp:Button ID="btnsend" runat="server" OnClick="btnsend_Click" style="z-index: 1; left: 278px; top: 318px; position: absolute" Text="שלח" />
        <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 133px; top: 275px; position: absolute" Text="תודה על תגובתך" Visible="False"></asp:Label>
        <asp:Label ID="lblwel" runat="server" Font-Bold="False" Font-Size="Large" style="z-index: 1; left: 108px; top: 70px; position: absolute" Text="Label" Visible="False"></asp:Label>
    </asp:Panel>
      <asp:Label ID="Label2" runat="server" BackColor="#6a4da6" ForeColor="White"  Font-Size="Large"  style="z-index: 1; left: -7px; top: -5px; position: absolute; height: 45px; width: 356px" Text="Label"></asp:Label>
   
</asp:Content>

