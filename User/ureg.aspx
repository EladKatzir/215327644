<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="ureg.aspx.cs" Inherits="User_ureg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style3 {
            position: relative;
            top: 132px;
            left: 397px;
        }
        .auto-style14 {
            z-index: 1;
            left: 676px;
            top: 228px;
            position: absolute;
        }
        .auto-style15 {
            z-index: 1;
            left: 675px;
            top: 255px;
            position: absolute;
        }
        .auto-style19 {
            z-index: 1;
            left: 404px;
            top: 289px;
            position: absolute;
        }
        .auto-style25 {
            z-index: 1;
            left: 405px;
            top: 325px;
            position: absolute;
        }
        .auto-style17 {
            z-index: 1;
            left: 452px;
            top: 326px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 409px;
            top: 354px;
            position: absolute;
        }
        .auto-style13 {
            z-index: 1;
            left: 697px;
            top: 375px;
            position: absolute;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <html>
    <body>
     <div style="width: 1423px; margin: 0 auto; height: 443px;">
    
        <asp:TextBox ID="txtfname" runat="server" CssClass="auto-style1" Height="20px" style="z-index: 1; left: 400px; top: 119px; position: absolute" Width="200px">first name</asp:TextBox>
    
    
        <asp:DropDownList ID="ddlc" runat="server" CssClass="auto-style7" DataSourceID="SqlDataSource1" DataTextField="CityName" DataValueField="CityID" Height="20px" style="z-index: 1; left: 781px; top: 341px; position: absolute">
        </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:city %>" ProviderName="<%$ ConnectionStrings:city.ProviderName %>" SelectCommand="SELECT [CityID], [CityName] FROM [tblUsersCities]"></asp:SqlDataSource>
        <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style5">address</asp:TextBox>
    
    
        <asp:TextBox ID="txtlname" runat="server" CssClass="auto-style3" Height="20px" Width="200px">last name</asp:TextBox>
    
    
        <asp:DropDownList ID="ddlg" runat="server" CssClass="auto-style13" DataSourceID="SqlDataSource2" DataTextField="Gender" DataValueField="GenderID">
        </asp:DropDownList>
         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:city %>" ProviderName="<%$ ConnectionStrings:city.ProviderName %>" SelectCommand="SELECT [GenderID], [Gender] FROM [tblUsersGender]"></asp:SqlDataSource>
        <asp:Label ID="lblperfect" runat="server" CssClass="auto-style27" Text="registered succesfully" BackColor="White"></asp:Label>
        <asp:Button ID="bs" runat="server" CssClass="auto-style28" OnClick="bs_Click" Text="go to home page" />
        <asp:Button ID="btreg" runat="server" CssClass="auto-style21" OnClick="Button1_Click" Text="sign up" />
        <asp:Button ID="bsign" runat="server" CssClass="auto-style23" OnClick="Button2_Click" Text="sign in" />
        <asp:Label ID="lblunerror" runat="server" CssClass="auto-style20" Text="username is already in use"></asp:Label>
        <asp:Label ID="lblne" runat="server" style="z-index: 1; left: 737px; top: 51px; position: absolute; width: 450px;" Text="the details you entered are illogical, please retry" CssClass="auto-style26" BackColor="White"></asp:Label>
        <asp:Label ID="lblpe" runat="server" CssClass="auto-style24" Text="phone should have 10 digits" BackColor="White"></asp:Label>
        <asp:TextBox ID="txtpass" runat="server" CssClass="auto-style15">password</asp:TextBox>
        <asp:TextBox ID="txtphone" runat="server" CssClass="auto-style17">phone number</asp:TextBox>
        <asp:DropDownList ID="ddl3d" runat="server" CssClass="auto-style25">
            <asp:ListItem>050</asp:ListItem>
            <asp:ListItem>052</asp:ListItem>
            <asp:ListItem>053</asp:ListItem>
            <asp:ListItem>054</asp:ListItem>
            <asp:ListItem>058</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label9" runat="server" CssClass="auto-style18" Text="Mail"></asp:Label>
        <asp:TextBox ID="txtuser" runat="server" CssClass="auto-style14">user name</asp:TextBox>
        <asp:TextBox ID="txtmail" runat="server" CssClass="auto-style19">mail</asp:TextBox>
         </div>
        <%--  .auto-style1 {
            z-index: 1;
            left: 1037px;
            top: 184px;
            position: absolute;
        }
        .auto-style2 {
            z-index: 1;
            left: 1240px;
            top: 183px;
            position: absolute;
            bottom: 465px;
        }
        .auto-style3 {
            z-index: 1;
            left: 1036px;
            top: 237px;
            position: absolute;
        }
        .auto-style4 {
            z-index: 1;
            left: 1237px;
            top: 236px;
            position: absolute;
        }
        .auto-style5 {
            z-index: 1;
            left: 1037px;
            top: 287px;
            position: absolute;
        }
        .auto-style6 {
            z-index: 1;
            left: 1236px;
            top: 290px;
            position: absolute;
        }
        .auto-style7 {
            z-index: 1;
            left: 1037px;
            top: 329px;
            position: absolute;
            width: 121px;
            height: 19px;
        }
        .auto-style8 {
            z-index: 1;
            left: 1236px;
            top: 328px;
            position: absolute;
        }
        .auto-style10 {
            z-index: 1;
            left: 1238px;
            top: 379px;
            position: absolute;
            width: 43px;
            height: 14px;
        }
        .auto-style11 {
            position: absolute;
            top: 424px;
            left: 1233px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            left: 1236px;
            z-index: 1;
            top: 461px;
        }
        .auto-style13 {
            position: absolute;
            top: 379px;
            left: 1036px;
            z-index: 1;
            width: 121px;
            height: 19px;
        }
        .auto-style14 {
            position: absolute;
            top: 422px;
            left: 1037px;
            z-index: 1;
        }
        .auto-style15 {
            position: absolute;
            top: 461px;
            left: 1037px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            top: 501px;
            left: 1239px;
            z-index: 1;
        }
        .auto-style17 {
            position: absolute;
            top: 500px;
            left: 1035px;
            z-index: 1;
        }
        .auto-style18 {
            position: absolute;
            top: 538px;
            left: 1242px;
            z-index: 1;
        }
        .auto-style19 {
            position: absolute;
            top: 535px;
            left: 1035px;
            z-index: 1;
        }
        .auto-style20 {
            position: absolute;
            top: 414px;
            left: 599px;
            z-index: 1;
        }
        .auto-style21 {
            position: absolute;
            top: 585px;
            left: 1067px;
            z-index: 1;
        }
        .auto-style23 {
            position: absolute;
            top: 406px;
            left: 857px;
            z-index: 1;
        }
        .auto-style24 {
            position: absolute;
            top: 469px;
            left: 679px;
            z-index: 1;
        }
        .auto-style25 {
            position: absolute;
            top: 498px;
            left: 913px;
            z-index: 1;
        }
        .auto-style26 {
            bottom: 412px;
        }
        .auto-style27 {
            position: absolute;
            top: 562px;
            left: 779px;
            z-index: 1;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [cityId], [cityName] FROM [tblCities]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [genderId], [gender] FROM [tblGender]"></asp:SqlDataSource>
        
        
<asp:Panel ID="Panel1" runat="server" style="z-index: 1; left: -171px; top: -122px; position: absolute; height: 789px; width: 1607px; margin-right: 0px">
        <asp:Label ID="Label1" runat="server" Text="address" CssClass="auto-style6"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="name" CssClass="auto-style2"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="surname" CssClass="auto-style4"></asp:Label>
        <asp:TextBox ID="txtfname" runat="server" CssClass="auto-style1"></asp:TextBox>
        <asp:TextBox ID="txtAddress" runat="server" CssClass="auto-style5"></asp:TextBox>
        <asp:TextBox ID="txtlname" runat="server" CssClass="auto-style3"></asp:TextBox>
    
    
        <asp:Label ID="Label4" runat="server" Text="gender" CssClass="auto-style10"></asp:Label>
        <asp:Label ID="Label5" runat="server" Text="city name" CssClass="auto-style8"></asp:Label>
        <asp:DropDownList ID="ddlc" runat="server" CssClass="auto-style7" DataSourceID="SqlDataSource1" DataTextField="cityName" DataValueField="cityId">
        </asp:DropDownList>
        <asp:DropDownList ID="ddlg" runat="server" CssClass="auto-style13" DataSourceID="SqlDataSource2" DataTextField="gender" DataValueField="genderId">
        </asp:DropDownList>
        
        
        <asp:Label ID="lblperfect" runat="server" CssClass="auto-style27" Text="registered succesfully"></asp:Label>
        <asp:Button ID="btreg" runat="server" CssClass="auto-style21" OnClick="Button1_Click" Text="sign up" />
        <asp:Button ID="bsign" runat="server" CssClass="auto-style23" OnClick="Button2_Click" Text="sign in" />
        <asp:Label ID="lblunerror" runat="server" CssClass="auto-style20" Text="username is already in use"></asp:Label>
        <asp:Label ID="lblne" runat="server" style="z-index: 1; left: 568px; top: 353px; position: absolute; width: 464px;" Text="the details you entered are illogical, please retry" CssClass="auto-style26"></asp:Label>
        <asp:Label ID="lblpe" runat="server" CssClass="auto-style24" Text="phone should have 10 digits"></asp:Label>
        <asp:TextBox ID="txtpass" runat="server" CssClass="auto-style15"></asp:TextBox>
        <asp:TextBox ID="txtphone" runat="server" CssClass="auto-style17"></asp:TextBox>
        <asp:DropDownList ID="ddl3d" runat="server" CssClass="auto-style25">
            <asp:ListItem>050</asp:ListItem>
            <asp:ListItem>052</asp:ListItem>
            <asp:ListItem>053</asp:ListItem>
            <asp:ListItem>054</asp:ListItem>
            <asp:ListItem>058</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label8" runat="server" CssClass="auto-style16" Text="Phone "></asp:Label>
        <asp:Label ID="Label6" runat="server" CssClass="auto-style11" Text="username"></asp:Label>
        <asp:Label ID="Label7" runat="server" CssClass="auto-style12" Text="password"></asp:Label>
        <asp:TextBox ID="txtuser" runat="server" CssClass="auto-style14"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" CssClass="auto-style18" Text="Mail"></asp:Label>
       <asp:TextBox ID="txtmail" runat="server" CssClass="auto-style19"></asp:TextBox>
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/return arrow.png" OnClick="ImageButton2_Click1" style="z-index: 1; left: 415px; top: 468px; position: absolute; height: 31px; width: 36px" />
</asp:Panel>
    </form>
</body> --%>
</body>
        </html>
</asp:Content>

