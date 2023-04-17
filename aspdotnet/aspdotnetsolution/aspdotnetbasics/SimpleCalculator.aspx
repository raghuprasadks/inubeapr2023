<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SimpleCalculator.aspx.cs" Inherits="aspdotnetbasics.SimpleCalculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Simple Calculator"></asp:Label><br />
    <asp:Label ID="Label2" runat="server" Text="Enter First Number"></asp:Label><br />
    <asp:TextBox ID="TextBoxFN" runat="server" ValidateRequestMode="Enabled"></asp:TextBox><br />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="First Number is mandatory" Display="Dynamic" ValidateRequestMode="Enabled" ControlToValidate="TextBoxFN" BackColor="#FF0066"></asp:RequiredFieldValidator><br />
    
    <asp:Label ID="Label3" runat="server" Text="Enter Operator"></asp:Label><br />
    <asp:TextBox ID="TextBoxOper" runat="server"></asp:TextBox><br />
    <asp:Label ID="Label4" runat="server" Text="Enter Second Number"></asp:Label><br />
    <asp:TextBox ID="TextBoxSN" runat="server"></asp:TextBox><br />
    <asp:Button ID="ButtonCalculate" runat="server" Text="Calculate" OnClick="ButtonCalculate_Click" /><br />
    <asp:Label ID="LabelResult" runat="server" Text=""></asp:Label>
</asp:Content>
