<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateData.aspx.cs" Inherits="CogniTask30.UpdateData" %>

<asp:Content ID ="updatecon" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <table>
            <tr>
                <td>
                     <asp:Label runat="server" Text="Enter Id"></asp:Label>
                </td>
                <td>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                     <asp:Label runat="server" Text="New Address"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                     <asp:Button runat="server" Text="Update" OnClick="UpdateButton"></asp:Button>
            </td>
            </tr>
        </table>
    </div>
</asp:Content>
