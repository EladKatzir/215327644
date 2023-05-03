<%@ Page Title="" Language="C#" MasterPageFile="~/User/Masterorder.master" AutoEventWireup="true" CodeFile="searchcat.aspx.cs" Inherits="User_searchcat" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <Style>

    .diva {
    position: absolute;
    top: 50%;
    left: 80%;
    transform: translate(-50%, -50%);
    padding: 20px;
}
        </Style>

    <div id="picie" style="background-color:black; text-align:center;" class="diva">
            <asp:Image ID="Image1" runat="server" Width="300" Height="300" />
            <asp:Image ID="Image2" runat="server" Width="300" Height="300" />
        </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:Timer ID="Timer1" runat="server" Interval="5000" OnTick="Timer1_Tick"></asp:Timer>
    <asp:GridView ID="GridView1" runat="server" style="z-index: 1; left: -539px; top: -161px; position: absolute; height: 163px; width: 289px"></asp:GridView>
   <div runat="server" style="background-color:black; text-align:center; z-index: 1; left: 137px; top: 313px; position: absolute; height: 41px; width: 699px;">
        <label for="searchTextBox">Search:</label>
        <asp:TextBox ID="searchTextBox" runat="server" Enabled="False">type in name</asp:TextBox>
        <asp:Button ID="searchButton" runat="server" Text="Search" OnClick="searchButton_Click" style="height: 26px" />
       </div>

         <asp:Panel ID="pnlAdd" runat="server" style="z-index: 1; left: 780px; top: 314px; position: absolute; height: 436px; width: 474px" BackColor="Black" BorderColor="Black" Visible="false">
            <asp:Label ID="lbltypecontent" runat="server" style="z-index: 1; left: 39px; top: 41px; position: absolute" Text="type" Font-Size="Large" ForeColor="Purple"></asp:Label>
            <asp:TextBox ID="txttype" runat="server" ReadOnly="True" style="z-index: 1; left: 96px; top: 40px; position: absolute; width: 100px; height: 19px;" ForeColor="Purple"></asp:TextBox>
            <asp:TextBox ID="txtcred" runat="server" ReadOnly="True" style="z-index: 1; left: 313px; top: 83px; position: absolute; width: 100px; height: 26px;" ForeColor="Purple"></asp:TextBox>
            <asp:TextBox ID="txtlen" runat="server" ReadOnly="True" style="z-index: 1; left: 315px; top: 39px; position: absolute; width: 100px; height: 19px;" ForeColor="Purple"></asp:TextBox>
            <asp:Label ID="lblprice" runat="server" Font-Size="Large" style="z-index: 1; left: 40px; top: 190px; position: absolute; bottom: 229px;" Text="price" ForeColor="Purple"></asp:Label>
            <asp:Label ID="lblcred" runat="server" Font-Size="Large" style="z-index: 1; left: 258px; top: 89px; position: absolute" Text="credit" ForeColor="Purple"></asp:Label>
            <asp:Button ID="btnslc" runat="server" OnClick="btnslc_Click" style="z-index: 1; left: 44px; top: 370px; position: absolute" Text="i want it!" ForeColor="Purple"/>
            <asp:TextBox ID="txtPrice" runat="server" ReadOnly="True" style="z-index: 1; left: 105px; top: 185px; position: absolute; width: 99px" ForeColor="Purple"></asp:TextBox>
            <asp:Label ID="lblgen" runat="server" Font-Size="Large" style="z-index: 1; left: 39px; top: 134px; position: absolute" Text="genere" ForeColor="Purple"></asp:Label>
            <asp:Label ID="Label7" runat="server" Font-Size="Large" style="z-index: 1; left: 40px; top: 88px; position: absolute" Text="name" ForeColor="Purple"></asp:Label>
            <asp:TextBox ID="txtname" runat="server" ReadOnly="True" style="z-index: 1; left: 98px; top: 87px; position: absolute; width: 99px" ForeColor="Purple"></asp:TextBox>
            <asp:TextBox ID="txtgen" runat="server" ReadOnly="True" style="z-index: 1; left: 102px; top: 132px; position: absolute; width: 99px" ForeColor="Purple"></asp:TextBox>
            <asp:Label ID="lbllen0" runat="server" Font-Size="Large" style="z-index: 1; left: 260px; top: 43px; position: absolute" Text="length" ForeColor="Purple"></asp:Label>
            <asp:Image ID="imgcover" runat="server" style="z-index: 1; left: 275px; top: 134px; position: absolute; height: 166px; width: 186px" ForeColor="Purple"/>
            <asp:Image ID="str1" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 30px; top: 263px; position: absolute" Width="30px" ForeColor="Purple" Visible="False" />
            <asp:Image ID="str2" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 74px; top: 263px; position: absolute" Width="30px" Visible="False" ForeColor="Purple" />
            <asp:Image ID="str3" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 119px; top: 264px; position: absolute" Width="30px" Visible="False" />
            <asp:Image ID="str4" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 160px; top: 263px; position: absolute" Width="30px" Visible="False" />
            <asp:Image ID="str5" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 201px; top: 264px; position: absolute" Width="30px" Visible="False" />
        </asp:Panel>

    <asp:RadioButtonList ID="RadioButtonList1" runat="server" BackColor="Black" ForeColor="Purple" RepeatDirection="Horizontal" style="z-index: 1; left: 139px; top: 240px; position: absolute; height: 26px; width: 690px" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="contenttype" DataValueField="contenttypeid" Font-Size="X-Large" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
    </asp:RadioButtonList>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\215327644elad.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [contenttypeid], [contenttype] FROM [tblcontenttype]"></asp:SqlDataSource>

    <asp:Label ID="lblfail" runat="server" style="z-index: 1; left: 443px; top: 509px; position: absolute" Text="fail" Visible="False"></asp:Label>

</asp:Content>


