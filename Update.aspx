<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="UniversityManagement.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Seleccione universidad<br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>Mesoamericana</asp:ListItem>
        <asp:ListItem>Landivar</asp:ListItem>
        <asp:ListItem>USAC</asp:ListItem>
    </asp:DropDownList>
    <br />
    Buscar alumno<br />
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Buscar" />
    <br />
    Ingrese nuevo nombre<br />
    <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Enabled="False" OnClick="Button1_Click" Text="Cambiar nombre" />
</asp:Content>
