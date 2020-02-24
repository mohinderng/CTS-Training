<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TutorialASP.aspx.cs" Inherits="InDepthASPDotNet.TutorialASP" %>

<asp:Content ID ="idnew" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Name Required" ControlToValidate="TextName" ForeColor="Red" ValidationGroup="vg1"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
        <br />
        <asp:TextBox ID="TextName" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Enter DOB" BackColor="#00CC00" BorderStyle="Dashed" BorderWidth="1px" ForeColor="Black"></asp:Label>
        <br />
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Select atleast one option" ControlToValidate="RadioButtonList1" ForeColor="Red" ValidationGroup="vg1"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Gender:"></asp:Label><br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Height="16px" Width="205px">
            <asp:ListItem>Female</asp:ListItem>
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Others</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Hobbies"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" Width="203px">
            <asp:ListItem>Badminton</asp:ListItem>
            <asp:ListItem>Singing</asp:ListItem>
            <asp:ListItem>Travelling</asp:ListItem>
            <asp:ListItem>Reading</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Select atleast one option" ControlToValidate="DropDownList1" ForeColor="Red" ValidationGroup="vg1"></asp:RequiredFieldValidator>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>High School</asp:ListItem>
            <asp:ListItem>Pre University</asp:ListItem>
            <asp:ListItem>Graduation</asp:ListItem>
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" Width="88px" />
        <br />
       
        

    </div>
     <asp:ValidationSummary ID="ValidationSummary1" runat="server" />

    <div class="jumbotron">
        <asp:Label ID="LabelDisplay" runat="server" Text="Label"></asp:Label>
        
    </div>
</asp:Content>

