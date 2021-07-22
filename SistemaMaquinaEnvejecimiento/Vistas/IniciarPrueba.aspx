<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPage/SideBar.Master" AutoEventWireup="true" CodeBehind="IniciarPrueba.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.IniciarPrueba" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn {
            background-color: rgb(255,145,28);
            border: rgb(255,145,28);
            color: white;
            margin: 10px;
        }

            .btn:hover {
                background-color: rgb(255,139,20);
                border: rgb(255,159,57);
                color: azure;
            }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border" style="margin: 10px;">
        <div class="form-row">
            <asp:Label Text="Nombre Material" ID="lblMaterial" runat="server" />
            <asp:TextBox ID="txtMaterial" CssClass="form-control" runat="server" />
        </div>
        <div class="form-row text-center">
            <div class="col">
                <asp:Label ID="lblFechaInicio" runat="server" Text="Fecha De Inicio"></asp:Label>
                <center>
                    <asp:Calendar ID="CalendarInicio" runat="server"></asp:Calendar>
                </center>
            </div>
            <div class="col">
                <asp:Label ID="lblFechaTermino" runat="server" Text="Fecha De Termino"></asp:Label>
                <center>
                    <asp:Calendar ID="CalendarFin" runat="server"></asp:Calendar>
                </center>
            </div>
        </div>
        <br />
        <div class="form-row">
            <asp:Label ID="lblPrivacidad" runat="server" Text="Privacidad"></asp:Label>
            <asp:DropDownList ID="ddlPrivacidad" runat="server" class="form-control">
                <asp:ListItem Selected="True" Value="White">---- Selecciona La Privacidad ---- </asp:ListItem>
                <asp:ListItem Value="Publico">Publico </asp:ListItem>
                <asp:ListItem Value="Privado">Privado </asp:ListItem>
            </asp:DropDownList>
        </div>
        <div class="form-row">
            <br />
            <asp:Button ID="btnIniciar" CssClass="btn btn-lg btn-orange btn-block" Text="Iniciar" runat="server" OnClick="btnIniciar_Click" />
        </div>
    </div>
</asp:Content>
