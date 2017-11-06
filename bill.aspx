<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="bill.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #ContentPlaceHolder1_p1
        {
            position:relative;
            top:-60px;
            left:-40px;
            height:280px;
        }
        #ContentPlaceHolder1_l1
        {
            position:absolute;
            left:60px;
        }
        #ContentPlaceHolder1_l2
        {
            position:absolute;
            left:45px;
        }
        #ContentPlaceHolder1_l
        {
            position:absolute;
            left:85px;
        }
    </style>
    <asp:Panel ID="p1" runat="server" BorderStyle="Solid">

    <asp:Label ID="l" runat="server">INVOICE</asp:Label>
    <br /><br />
    <asp:Table ID="tbl" runat="server"></asp:Table>
    <br />
    <asp:Label ID="l1" runat="server"></asp:Label>
    <br /><br />
    <asp:Label ID="l2" runat="server">CASH PAYMENT ONLY</asp:Label>

     </asp:Panel>
</asp:Content>

