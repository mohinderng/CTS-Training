<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddData.aspx.cs" Inherits="WebOperationsLearn.AddData" %>

<asp:Content ID="mycontent" ContentPlaceHolderID ="MainContent" runat ="server">
    <div class ="jumbotran">
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
                  <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
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
