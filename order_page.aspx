<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="order_page.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #ContentPlaceHolder1_b1
        {
            position:absolute;
            left:35px;
        }
        #ContentPlaceHolder1_gv1
        {
            position:relative   ;
            left:-95px;
        }
    </style>
    <asp:Label ID="test" runat="server"></asp:Label>
    <asp:SqlDataSource ID="ds1" ConnectionString="<%$ ConnectionStrings:hotel %>" SelectCommand="select Dish,Price from Menu" runat="server">
            </asp:SqlDataSource>
            <asp:GridView DataSourceID="ds1" ID="gv1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:TemplateField HeaderText="select">
                        <ItemTemplate>
                            <asp:CheckBox ID="cb1" runat="server" /> 
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="ITEM">
                        <ItemTemplate>
                           <asp:Label ID="nameofdish" runat="server" Text='<%#Bind("Dish")%>'></asp:Label> 
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="PRICE">
                        <ItemTemplate>
                            <asp:Label ID="price" runat="server" Text='<%#Bind("Price") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="select">
                        <ItemTemplate>
                            <asp:TextBox ID="tb1" runat="server" Text="0" />
                            <asp:RangeValidator runat="server" ID="rv1" Type="Integer" ControlToValidate="tb1" MaximumValue="100" MinimumValue="0" ForeColor="red">!!</asp:RangeValidator>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <asp:Button ID="b1" runat="server" Text="Place Order" OnClick="b1_Click" />
</asp:Content>

    