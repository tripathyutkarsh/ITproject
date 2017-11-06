<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #ContentPlaceHolder1_b1
        {
            position:absolute;
            bottom:30px;
            left:30px;
            font-family:'Times New Roman';
        }
        #ContentPlaceHolder1_b2
        {
            position:absolute;
            bottom:0px;
            left:45px;
            font-family:'Times New Roman';
        }
    </style>
    <br /><br />
    <asp:Button ID="b1" runat="server" OnClick="reguser" Text="NEW USER?"/>
    <br /><br />
    <asp:Button ID="b2" runat="server" OnClick="login" Text="LOGIN" />
</asp:Content>

 