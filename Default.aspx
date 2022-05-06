﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UniversityManagement._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de personal</h1>
        <span style="font-size: large">Universidad</span>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="Mesoamericana">Mesoamericana</asp:ListItem>
            <asp:ListItem Value="Landivar">Landivar</asp:ListItem>
            <asp:ListItem Value="USAC">USAC</asp:ListItem>
        </asp:DropDownList>
        <br />

        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <br />
        <div>
            Numero de IGGS&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <br />
            Nombre
            <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            <br />
            <br />
            Apellido
            <asp:TextBox ID="TextBox3" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
        </div>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Ingresar personal" />

        <br />
        <br />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Ingresar universidad" />

    </div>

</asp:Content>
