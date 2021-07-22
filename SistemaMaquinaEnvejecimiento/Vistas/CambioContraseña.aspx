<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CambioContraseña.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.CambioContraseña" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <title>Sistema Maquina De Envejecimiento Acelerado</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../public/bootstrap4/css/bootstrap.min.css">

    <link rel="stylesheet" href="../public/plugins/sweetAlert2/sweetalert2.min.css">

    <link rel="stylesheet" href="../public/plugins/animate.css/animate.css">

    <link href="../public/css/Style.css" rel="stylesheet" />
    <link href="../public/img/Iconos/logo.ico" rel="icon" />
</head>
<body>
    <section class="container">
        <header class="align-content-center text-center">
            <asp:Image ImageUrl="~/public/img/logo.png" CssClass="img-fluid" Width="150" runat="server" />
            <div class="text-center text-dark"><strong>SISTEMA DE MAQUINA DE ENVEJECIMIENTO</strong></div>
        </header>
        <div class="container border" style="border-color: #cfd8dc;">
            <div class="text-center text-muted"><strong>Cambio De Contraseña</strong></div>
            <form id="form1" runat="server">
                <asp:Label Text="" ID="lblToken" style="display:none;" runat="server" />
                <div class="form-group">
                    <asp:Label for="pass1" runat="server">Ingresa tu Nueva Contraseña</asp:Label>
                    <asp:TextBox ID="pass1" class="form-control" TextMode="Password" runat="server" placeholder="Ingresa tu Nueva Contraseña"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label for="pass2" runat="server">Confirmacion De contraseña</asp:Label>
                    <asp:TextBox ID="pass2" class="form-control" TextMode="Password" runat="server" placeholder="Confirmacion De contraseña"></asp:TextBox>
                </div>
                <asp:Button ID="btnCambiar" class="btn btn-lg btn-orange btn-block" runat="server" Text="Cambiar Contraseña" OnClick="btnCambiar_Click" />
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
    <script src="../public/js/verificacion4.js"></script>
</body>
</html>
