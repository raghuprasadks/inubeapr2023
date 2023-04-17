<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="aspdotnetbasics.SignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Sign Up" BackColor="#3399FF" BorderColor="#003399" BorderStyle="Solid" Font-Bold="True"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Enter Name"></asp:Label><br />
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label3" runat="server" Text="Enter EMail"></asp:Label><br />
    <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox><br />

    <asp:Label ID="Label4" runat="server" Text="Enter Mobile"></asp:Label><br />
    <asp:TextBox ID="TextBoxMobile" runat="server"></asp:TextBox><br />
    <asp:Button ID="ButtonSignUp" runat="server" Text="SignUp" /><br />
</asp:Content>
