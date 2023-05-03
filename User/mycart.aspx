<%@ Page Title="" Language="C#" MasterPageFile="~/User/Masterorder.master" AutoEventWireup="true" CodeFile="mycart.aspx.cs" Inherits="User_mycart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
      <asp:Label ID="Label11" runat="server" BackColor="#6a4da6" ForeColor="White"  Font-Size="Large"  style="z-index: 1; left: -7px; top: -5px; position: absolute; height: 45px; width: 356px" Text="Label"></asp:Label>
        <div>
    
        <asp:TextBox ID="date" runat="server" style="z-index: 1; left: 115px; top: 47px; position: absolute; background-color:purple"></asp:TextBox>
        <asp:Button ID="btnpay" runat="server" BackColor="White" ForeColor="Black" OnClick="Button2_Click" style="z-index: 1; left: 484px; top: 323px; position: absolute; width: 61px; height: 30px" Text="pay" Visible="False" />
    
        <asp:GridView ID="grduser" runat="server" style="z-index: 1; left: 710px; top: 118px; position: absolute; height: 115px; width: 223px; bottom: 400px;" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
            <AlternatingRowStyle BackColor="#F7F7F7" />
            <Columns>
                <asp:TemplateField HeaderText="image">
                    <ItemTemplate>
                        <asp:Image ID="img1" runat="server" Height="65px" ImageUrl='<%# Eval("profile","{0}")%>' />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
            <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <SortedAscendingCellStyle BackColor="#F4F4FD" />
            <SortedAscendingHeaderStyle BackColor="#5A4C9D" />
            <SortedDescendingCellStyle BackColor="#D8D8F0" />
            <SortedDescendingHeaderStyle BackColor="#3E3277" />
        </asp:GridView>
    
    </div>
        <asp:TextBox ID="txtNum" runat="server" style="z-index: 1; left: 1023px; top: 313px; position: absolute" ></asp:TextBox>
        <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; left: 723px; top: 311px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 482px; top: 291px; position: absolute" Text="finish" OnClick="Button1_Click1" />
        
        <asp:Button ID="reciept" runat="server" OnClick="reciept_Click" style="z-index: 1; left: 477px; top: 247px; position: absolute; height: 33px; width: 66px" Text="reciept" Visible="False" />
        
        <asp:Label ID="Label9" runat="server" style="z-index: 1; left: 39px; top: 48px; position: absolute" Text="today:"></asp:Label>
        <asp:GridView ID="grdcart" runat="server" style="z-index: 1; left: 820px; top: 417px; position: absolute; height: 115px; width: 196px" BackColor="White" BorderColor="White" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="None">
            <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
            <PagerStyle BackColor="#C6C3C6" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#DEDFDE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#594B9C" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#33276A" />
        </asp:GridView>
        <asp:Panel ID="pnlPay" runat="server" style="z-index: 1; left: 124px; top: 186px; position: absolute; height: 292px; width: 289px" BackColor="white" Visible="False">
   <asp:TextBox ID="txtId" runat="server" style="z-index: 1; left: 8px; top: 5px; position: absolute; right: 153px;"></asp:TextBox>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 235px; top: 6px; position: absolute" Text="id"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 201px; top: 88px; position: absolute; bottom: 188px;" Text="card number"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 212px; top: 129px; position: absolute" Text="expiretion"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 216px; top: 43px; position: absolute" Text="provider"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; left: 231px; top: 169px; position: absolute" Text="cvv"></asp:Label>
        <asp:Label ID="lblsucc" runat="server" style="z-index: 1; left: 105px; top: 225px; position: absolute; height: 16px" Text="paid successfully" Visible="False"></asp:Label>
        <asp:TextBox ID="txtcardNum" runat="server" style="z-index: 1; left: 15px; top: 84px; position: absolute" OnTextChanged="txtcardNum_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txtex" TextMode="Date" runat="server" style="z-index: 1; left: 22px; top: 127px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="ddlCompany" runat="server" style="z-index: 1; left: 34px; top: 43px; position: absolute">
            <asp:ListItem>visa</asp:ListItem>
            <asp:ListItem>mastercard</asp:ListItem>
        </asp:DropDownList>
            <asp:TextBox ID="txtcvv" runat="server" style="z-index: 1; left: 21px; top: 168px; position: absolute" OnTextChanged="txtcvv_TextChanged"></asp:TextBox>
        </asp:Panel>
     
        <asp:Label ID="lblfake" runat="server" style="z-index: 1; left: 272px; top: 250px; position: absolute" Text="check again for errors" Visible="False"></asp:Label>
     
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 1038px; top: 285px; position: absolute; width: 106px;" Text="item amount" ForeColor="#9900CC"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 777px; top: 287px; position: absolute" Text="total" ForeColor="#9900CC"></asp:Label>
                    <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 38px; top: -180px; position: absolute" Visible="true"></asp:TextBox>
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 653px; top: -152px; position: absolute; width: 82px" Text="your info"></asp:Label>
        <p>
            &nbsp;</p>
</asp:Content>

