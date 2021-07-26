<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPage/SideBar.Master" AutoEventWireup="true" CodeBehind="HistorialPruebas.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.HistorialPruebas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="http://cdn.datatables.net/1.10.25/css/jquery.dataTables.min.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border table-responsive" style="margin: 10px;">
        <asp:GridView runat="server" ID="gvPrueba" AutoGenerateColumns="False" CssClass="table table-bordered" Style="margin-top: 10px;" OnRowCommand="gvPrueba_RowCommand">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" />
                <asp:BoundField DataField="Material" HeaderText="Material" />
                <asp:BoundField DataField="FechaInicioString" HeaderText="Fecha Inicio" />
                <asp:BoundField DataField="FechaTerminoString" HeaderText="Fecha Termino" />
                <asp:ButtonField ControlStyle-CssClass="btn btn-info" Text="Ver Registros" CommandName="mediciones" HeaderText="Ver Registros de Medicion">
                    <ControlStyle CssClass="btn btn-info" />
                </asp:ButtonField>
            </Columns>
        </asp:GridView>
    </div>
    <script src="http://cdn.datatables.net/1.10.25/js/jquery.dataTables.min.js"></script>
</asp:Content>
