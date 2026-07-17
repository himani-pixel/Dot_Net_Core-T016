<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Practical_4B._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    Name:
    <asp:TextBox ID="TextBox1" runat="server" Height="27px" Width="140px"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name feild is required."></asp:RequiredFieldValidator>
    <br />
    <br />
    Age:
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="You are under age" MaximumValue="99" MinimumValue="18" SetFocusOnError="True"></asp:RangeValidator>
    <br />
    <br />
    Password:
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Password doesn't match"></asp:CompareValidator>
    <br />
    <br />
    Confirm Password: <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Password doesn't match"></asp:CompareValidator>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Button" />

</asp:Content>
