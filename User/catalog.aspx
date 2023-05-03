<%@ Page Title="" Language="C#" MasterPageFile="~/User/Masterorder.master" AutoEventWireup="true" CodeFile="catalog.aspx.cs" Inherits="Admin_catalog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">


    
        <asp:Label ID="lbltyoe" runat="server" style="z-index: 1; left: 119px; top: 133px; position: absolute" Text="type of content:" BackColor="#CC00CC" BorderColor="#660066" ForeColor="White"></asp:Label>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="Black" style="z-index: 1; left: 83px; top: 116px; position: absolute; height: 300px; width: 369px">
             <asp:RadioButtonList ID="rbltype" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="contenttype" DataValueField="contenttypeid" OnSelectedIndexChanged="rbltype_SelectedIndexChanged" style="z-index: 1; left: 27px; top: 23px; position: absolute; height: 26px; width: 86px" BackColor="#CC00CC" BorderColor="#660066" ForeColor="White">
                  </asp:RadioButtonList>
            <asp:DropDownList ID="ddlshow" runat="server" AutoPostBack="True" style="z-index: 1; left: 27px; top: 144px; position: absolute; bottom: 134px;" Visible="False" OnSelectedIndexChanged="ddlshow_SelectedIndexChanged" BackColor="#CC00FF" ForeColor="White">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlmovie" runat="server" AutoPostBack="True" style="z-index: 1; left: 28px; top: 104px; position: absolute" Visible="False" OnSelectedIndexChanged="ddlmovie_SelectedIndexChanged" BackColor="#CC00FF" ForeColor="White">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlsong" runat="server" AutoPostBack="True" style="z-index: 1; left: 23px; top: 188px; position: absolute" Visible="False" OnSelectedIndexChanged="ddlsong_SelectedIndexChanged" BackColor="#CC00FF" ForeColor="White">
        </asp:DropDownList>
        <asp:CheckBoxList ID="cblgenere" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cblgenere_SelectedIndexChanged" style="z-index: 1; left: 211px; top: 24px; position: absolute; height: 26px; width: 86px" BackColor="#CC00CC" BorderColor="#660066" ForeColor="White">
        </asp:CheckBoxList>
        </asp:Panel>
        
   
       
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\215327644elad.mdb" ProviderName="System.Data.OleDb" SelectCommand="SELECT [contenttypeid], [contenttype] FROM [tblcontenttype]"></asp:SqlDataSource>
        
        <asp:Panel ID="pnlAdd" runat="server" style="z-index: 1; left: 990px; top: 89px; position: absolute; height: 436px; width: 474px" BackColor="#CC00CC" BorderColor="Black" Visible="false">
            <asp:Label ID="lbltypecontent" runat="server" style="z-index: 1; left: 39px; top: 41px; position: absolute" Text="type" Font-Size="Large"></asp:Label>
            <asp:TextBox ID="txttype" runat="server" ReadOnly="True" style="z-index: 1; left: 96px; top: 40px; position: absolute; width: 100px; height: 19px;"></asp:TextBox>
            <asp:TextBox ID="txtcred" runat="server" ReadOnly="True" style="z-index: 1; left: 313px; top: 83px; position: absolute; width: 100px; height: 26px;"></asp:TextBox>
            <asp:TextBox ID="txtlen" runat="server" ReadOnly="True" style="z-index: 1; left: 315px; top: 39px; position: absolute; width: 100px; height: 19px;"></asp:TextBox>
            <asp:Label ID="lblprice" runat="server" Font-Size="Large" style="z-index: 1; left: 40px; top: 190px; position: absolute; bottom: 229px;" Text="price"></asp:Label>
            <asp:Label ID="lblcred" runat="server" Font-Size="Large" style="z-index: 1; left: 258px; top: 89px; position: absolute" Text="credit"></asp:Label>
            <asp:Button ID="btnslc" runat="server" OnClick="btnslc_Click" style="z-index: 1; left: 44px; top: 370px; position: absolute" Text="i want it!" />
            <asp:TextBox ID="txtPrice" runat="server" ReadOnly="True" style="z-index: 1; left: 105px; top: 185px; position: absolute; width: 99px"></asp:TextBox>
            <asp:Label ID="lblgen" runat="server" Font-Size="Large" style="z-index: 1; left: 39px; top: 134px; position: absolute" Text="genere"></asp:Label>
            <asp:Label ID="Label7" runat="server" Font-Size="Large" style="z-index: 1; left: 40px; top: 88px; position: absolute" Text="name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server" ReadOnly="True" style="z-index: 1; left: 98px; top: 87px; position: absolute; width: 99px"></asp:TextBox>
            <asp:TextBox ID="txtgen" runat="server" ReadOnly="True" style="z-index: 1; left: 102px; top: 132px; position: absolute; width: 99px"></asp:TextBox>
            <asp:Label ID="lbllen0" runat="server" Font-Size="Large" style="z-index: 1; left: 260px; top: 43px; position: absolute" Text="length"></asp:Label>
            <asp:Image ID="imgcover" runat="server" style="z-index: 1; left: 275px; top: 134px; position: absolute; height: 166px; width: 186px" />
            <asp:Image ID="str1" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 30px; top: 263px; position: absolute" Width="30px" Visible="False" />
            <asp:Image ID="str2" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 74px; top: 263px; position: absolute" Width="30px" Visible="False" />
            <asp:Image ID="str3" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 119px; top: 264px; position: absolute" Width="30px" Visible="False" />
            <asp:Image ID="str4" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 160px; top: 263px; position: absolute" Width="30px" Visible="False" />
            <asp:Image ID="str5" runat="server" Height="30px" ImageUrl="~/images/star.png" style="z-index: 1; left: 201px; top: 264px; position: absolute" Width="30px" Visible="False" />
        </asp:Panel>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>

