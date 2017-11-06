<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="menu_page.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="l1" runat="server"></asp:Label>
    <br /><br />
    <asp:Label ID="l2" runat="server"></asp:Label>
    <br /><br />
    <asp:DropDownList ID="ddl1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="next_page"></asp:DropDownList>
    <br /><br />
    <asp:Button runat="server" ID="b1" Text="logout"  OnClick="b1_Click"/>
</asp:Content>

