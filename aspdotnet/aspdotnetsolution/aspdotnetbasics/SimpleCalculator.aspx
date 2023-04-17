<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleCalculator.aspx.cs" Inherits="aspdotnetbasics.SimpleCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Label ID="Label1" runat="server" Text="Simple Calculator"></asp:Label>

    <asp:Label ID="Label2" runat="server" Text="Enter First Number"></asp:Label>
    <asp:TextBox ID="TextBoxFN" runat="server"></asp:TextBox>
    <asp:Label ID="Label3" runat="server" Text="Enter Operator"></asp:Label>
    <asp:TextBox ID="TextBoxOper" runat="server"></asp:TextBox>
    <asp:Label ID="Label4" runat="server" Text="Enter Second Number"></asp:Label>
    <asp:TextBox ID="TextBoxSN" runat="server"></asp:TextBox>
    <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" /><br />
    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
</asp:Content>
