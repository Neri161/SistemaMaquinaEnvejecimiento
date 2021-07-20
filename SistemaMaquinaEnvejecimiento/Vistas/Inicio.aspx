<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPage/SideBar.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.Inicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container col-12">
        <header class="align-content-center text-center">
            <h1 class="display-5 mb-4">Bienvenido al Sistema De Maquina De Envejecimiento!</h1>
            <asp:Image ImageUrl="~/public/img/logo.png" CssClass="img-fluid" runat="server" />
        </header>
        <div class="text-center padder">
            <p>
                <small>Universidad Politécnica de Tecámac<br>
                    © 2021</small>
            </p>
        </div>
    </div>
</asp:Content>
