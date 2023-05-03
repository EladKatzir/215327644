<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="upage.aspx.cs" Inherits="User_upage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <body>
            <div style="width: 1351px; margin: 0 auto; height: 456px;">
    
    
       <a href="homepage.aspx" style="border: medium groove white; z-index: 1; left: 4px; top: 579px; position: absolute; height: 50px; width: 283px; font-size:x-large; text-align:end; text-decoration:none">
           <button runat="server" type="button" class="button" onclick="btnsignup_Click"/>
               <span class="button__text">homepage</span>
               <span class="button__icon">
                   <ion-icon name="home-outline"></ion-icon>
               </span>
           </button>

            </a>
                <asp:Label ID="Label11" runat="server" BackColor="#6a4da6" ForeColor="White"  Font-Size="Large"  style="z-index: 1; left: -7px; top: -5px; position: absolute; height: 45px; width: 356px" Text="Label"></asp:Label>
                      <asp:ImageButton ID="imgavatar" runat="server" style="z-index: 1; left: 1707px; top: 108px; position: absolute;height: 125px; width: 149px;border-radius: 50%;" BackColor="White" BorderColor="White" BorderStyle="Solid" BorderWidth="0.5px" OnClick="imgavatar_Click" />
                <asp:FileUpload ID="FileUpload1" runat="server" style="z-index: 1; left: 1750px; top: 214px; position: absolute; direction: ltr;" Visible="False" /> 
                <asp:Button ID="btnchanged" runat="server" style="z-index: 1; left: 1652px; top: 235px; position: absolute" Text="the profile pic changed,press to refresh" Visible="False" />
                <asp:Button ID="btnrefresh" runat="server" OnClick="btnrefresh_Click" style="z-index: 1; left: 1691px; top: 211px; position: absolute" Text="refresh" Visible="False" />
        </div>
            <script src="https://unpkg.com/ionicons@5.4.0/dist/ionicons.js"></script>
</body>
</asp:Content>

