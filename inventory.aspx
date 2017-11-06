<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="inventory.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #ContentPlaceHolder1_gv1
        {
            position:absolute;
            top:-100px;
            left:-30px; 
        }
        #ContentPlaceHolder1_b1
        {
            position:relative;
            bottom:-270px;
        }
    </style>
    <asp:SqlDataSource ID="ds1" runat="server" ConnectionString="<%$ ConnectionStrings:hotel %>" SelectCommand="select Product_name,Quantity,Min_quantity from Inventory" UpdateCommand="update Inventory set Quantity=@Quantity where Product_name=@Product_name">
        <UpdateParameters>
            <asp:ControlParameter Name="Product_name" ControlID="gv1" />
            <asp:ControlParameter Name="Quantity" ControlID="gv1" />
        </UpdateParameters>
    </asp:SqlDataSource>
    
    <asp:GridView ID="gv1" DataSourceID="ds1" AutoGenerateColumns="false" runat="server" OnRowDataBound="gv1_RowDataBound" DataKeyNames="Product_name">
        <Columns>
            <asp:BoundField DataField="Product_name" HeaderText="NAME OF PRODUCT" ReadOnly="true"/>    
            <asp:BoundField DataField="Quantity" HeaderText="REMAINING QUANTITY" />
            <asp:CommandField ShowEditButton="true" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="b1" runat="server" OnClick="b1_Click" Text="BACK TO MAIN MENU"/>
    
</asp:Content>

