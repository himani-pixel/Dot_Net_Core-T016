<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical_4A._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    Student Name:
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>BSc.IT</asp:ListItem>
        <asp:ListItem>BSc.CS</asp:ListItem>
        <asp:ListItem>BCA</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:CheckBox ID="CheckBox1" runat="server" Text="Accept Terms &amp; Conditions." />
    <br />
    <br />
    <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    <br />

    <asp:Button ID="Button2" runat="server"
        Text="Submit Form"
        OnClick="Button1_Click" />

    <br />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>
