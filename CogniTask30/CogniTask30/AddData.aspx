<%@ Page Language="C#" MasterPageFile="~/Site.Mobile.Master" AutoEventWireup="true" CodeBehind="AddData.aspx.cs" Inherits="CogniTask30.AddData" %>

<asp:Content ID="mycontent" ContentPlaceHolderID ="MainContent" runat ="server">
    <div class ="jumbotron">
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Sid"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Sname"></asp:Label>
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

           <asp:Button ID="Button1" runat="server" Text="Insert" Onclick ="ButtonCall"></asp:Button>

         <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </div>
    </asp:Content>
