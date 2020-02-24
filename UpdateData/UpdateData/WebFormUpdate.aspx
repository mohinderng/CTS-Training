<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebFormUpdate.aspx.cs" Inherits="UpdateData.WebFormUpdate" %>

<asp:Content ID ="updcontent" ContentPlaceHolderID="MainContent" runat ="server">
    <div class="jumbotran">
        <asp:Label ID="Label1" runat="server" Text="Roll Number"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Address"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="Button1" runat="server" Text="Update Button" OnClick="Updateit"  />
    <asp:Label ID="Label3" runat="server" Text="Error"></asp:Label>
</asp:Content>