<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPage/SideBar.Master" AutoEventWireup="true" CodeBehind="Mediciones.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.Mediciones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border table-responsive" style="margin: 10px;">
        <asp:GridView ID="gvMedicion" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered" Style="margin-top: 10px;">
            <Columns>
                <asp:BoundField DataField="Temperatura" HeaderText="Temperatura" />
                <asp:BoundField DataField="Humedad" HeaderText="Humedad" />
                <asp:BoundField DataField="EstatusLuz" HeaderText="Estatus De La Luz" />
                <asp:BoundField DataField="CicloTrabajo" HeaderText="Ciclo De Trabajo" />
                <asp:BoundField DataField="FechaString" HeaderText="Fecha" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
