<%@ Page Title="" Language="C#" MasterPageFile="~/Vistas/MasterPage/SideBar.Master" AutoEventWireup="true" CodeBehind="HistorialPruebas.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.HistorialPruebas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container border" style="margin: 10px;">
        <asp:Table ID="tbPrueba" runat="server">
            <asp:TableRow>
            <asp:TableCell>
                Row 0, Col 0
            </asp:TableCell>
            <asp:TableCell>
                Row 0, Col 1
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                Row 1, Col 0
            </asp:TableCell>
            <asp:TableCell>
                Row 1, Col 1
            </asp:TableCell>
        </asp:TableRow>
        </asp:Table>
    </div>
</asp:Content>
