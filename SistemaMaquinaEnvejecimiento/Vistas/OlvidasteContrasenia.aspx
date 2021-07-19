<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OlvidasteContrasenia.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.OlvidasteContrasenia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Sistema Maquina De Envejecimiento</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../public/bootstrap4/css/bootstrap.min.css">

    <link rel="stylesheet" href="../public/plugins/sweetAlert2/sweetalert2.min.css">

    <link rel="stylesheet" href="../public/plugins/animate.css/animate.css">

    <link href="../public/css/Style.css" rel="stylesheet" />
</head>
<body>
    <section class="container">
        <header class="align-content-center text-center">
            <asp:Image ImageUrl="~/public/img/logo.png" CssClass="img-fluid" Width="150" runat="server" />
            <div class="text-center text-dark"><strong>SISTEMA DE MAQUINA DE ENVEJECIMIENTO</strong></div>
        </header>
        <div class="container border" style="border-color: #cfd8dc;">
            <div class="text-center text-muted"><strong>Solicitud de Recuperar Contraseña</strong></div>
            <form id="form1" runat="server">
                <div class="form-group">
                    <asp:Label for="email" runat="server">Ingresa tu Correo</asp:Label>
                    <asp:TextBox ID="email" class="form-control" TextMode="Email" runat="server" placeholder="Ingresa tu Correo"></asp:TextBox>
                </div>
                <asp:Button ID="btnRecuperar" class="btn btn-lg btn-orange btn-block" runat="server" Text="Recuperar Contraseña" OnClick="btnRecuperar_Click" />
                <asp:Button ID="btnRegresar" class="btn btn-lg btn-orange btn-block" runat="server" Text="Regresar Al Login" OnClick="btnRegresar_Click" />
            </form>
        </div>
    </section>
    <footer>
        <div class="text-center padder">
            <p>
                <small>Universidad Politécnica de Tecámac<br>
                    © 2021</small>
            </p>
        </div>
    </footer>
    <script src="../public/js/jquery.min.js"></script>
    <script src="../public/js/popper.min.js"></script>
    <script src="../public/bootstrap4/js/bootstrap.min.js"></script>

    <!--    Plugin sweet Alert 2  -->
    <script src="../public/plugins/sweetAlert2/sweetalert2.all.min.js"></script>
    <script src="../public/js/verificacion3.js"></script>
</body>
</html>
