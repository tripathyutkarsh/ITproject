<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="reguser.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="l1" runat="server">Name:</asp:Label>
    <asp:TextBox runat="server" ID="tb1" ></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="rfv1" ControlToValidate="tb1" Text="THIS IS A REQUIRED FIELD" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="Label3" runat="server">ID:</asp:Label>
    <asp:TextBox runat="server" ID="tb4" ></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" ControlToValidate="tb4" Text="THIS IS A REQUIRED FIELD" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="Label1" runat="server" >Password:</asp:Label>
    <asp:TextBox runat="server" ID="tb2" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" ControlToValidate="tb2" Text="THIS IS A REQUIRED FIELD" ForeColor="Red"></asp:RequiredFieldValidator>
    <br /><br />
    <asp:Label ID="Label2" runat="server" >Confirm Password:</asp:Label>
    <asp:TextBox runat="server" ID="tb3" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator runat="server" ControlToCompare="tb2" ControlToValidate="tb3" ErrorMessage="PASSWORDS DO NOT MATCH!" EnableClientScript="true"></asp:CompareValidator>
    <br /><br />
    <asp:Button runat="server" Text="CREATE USER" OnClick="Createuser" />
    <br />
    <asp:Label runat="server" ID="warning" ForeColor="Red"></asp:Label>
</asp:Content>

