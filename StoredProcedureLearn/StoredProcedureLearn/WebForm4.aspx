<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="StoredProcedureLearn.WebForm4" %>

<asp:Content ID="mywebform" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotran">

        <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Roll Number"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Address"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        </table>
        
        <asp:Button ID="Button1" runat="server" Text="Insert" OnClick ="Clickme"/>

        <asp:Label ID="Label4" runat="server" Text="Except"></asp:Label>

    </div>
</asp:Content>