<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ImagesWebForm.aspx.cs" Inherits="MasterPageDemo.ImagesWebForm" %>

<asp:Content ID ="conid" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br>
        <br>

        <asp:Button ID="Button1" runat="server" Text="Upload" OnClick="Button1_Click"/>
        <br>
        <br>

        <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
            <ItemTemplate>
                <asp:Image ID="Image1"
                    ImageUrl='<%# Eval("Name","~/Resources/{0}") %>'
                    width="350px" Height="350px" runat="server" />
                <br />
                <%#Eval("Name") %>
            </ItemTemplate>
        </asp:DataList>
        </div>
</asp:Content>