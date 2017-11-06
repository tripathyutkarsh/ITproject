<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <style>
        #ContentPlaceHolder1_b1
        {
            position:absolute;
            left:90px;
        }
    </style>
    <asp:Label ID="l1" runat="server" >USERNAME:</asp:Label>
    <asp:TextBox ID="tb1" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rf1" runat="server" ControlToValidate="tb1" ForeColor="Red" Text="THIS FIELD IS REQUIRED!"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="l2" runat="server">PASSWORD:</asp:Label>
    <asp:TextBox ID="tb2" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ForeColor="Red" ControlToValidate="tb2" Text="THIS FIELD IS REQUIRED!"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Button ID="b1" runat="server" Text="LOGIN" OnClick="user_login" />
    <br /><br />
    <asp:Label ID="lb3" ForeColor="Red" runat="server"></asp:Label>

</asp:Content>

