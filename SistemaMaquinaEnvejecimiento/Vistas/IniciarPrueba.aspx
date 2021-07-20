<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPage/SideBar.Master" AutoEventWireup="true" CodeBehind="IniciarPrueba.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.IniciarPrueba" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border" style="margin:10px;">
        <div class="form-group">
            <asp:Label ID="lblMaterial" runat="server" Text="Material"></asp:Label>
            <asp:TextBox ID="material" class="form-control" runat="server" placeholder="Material" requiered></asp:TextBox>
        </div>
        <div class="form-group">
            <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha De Inicio"></asp:Label>
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
        </div>
        <div class="form-group">
            <asp:Label ID="lblFechaTermino" runat="server" Text="Fecha De Termino"></asp:Label>
            <asp:Calendar ID="Calendar2" runat="server"></asp:Calendar>
        </div>
    </div>
</asp:Content>
