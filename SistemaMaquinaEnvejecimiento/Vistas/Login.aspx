<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Login | SME</title>
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
            <div class="text-center text-muted"><strong>Inicia Sesión</strong></div>
            <form id="form2" runat="server">
                <div class="form-group">
                    <asp:Label for="email" runat="server">Correo</asp:Label>
                    <asp:TextBox ID="email" class="form-control" TextMode="Email" runat="server" placeholder="Correo"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label for="pass" runat="server">Contraseña</asp:Label>
                    <asp:TextBox ID="pass" class="form-control" TextMode="Password" runat="server" placeholder="Contraseña"></asp:TextBox>
                    <div class="text-right">
                        <br />
                        <asp:LinkButton Text="¿Olvidaste tu Contraseña?" runat="server" OnClick="Unnamed4_Click" />
                    </div>
                </div>
                <asp:Button ID="btnIngresar" class="btn btn-lg btn-orange btn-block" runat="server" Text="Iniciar" OnClick="btnIngresar_Click" />
                <br />
                <div class="text-center">
                    ¿No tienes Cuenta?<asp:LinkButton Text=" Crear Cuenta" runat="server" ID="linkRegister" OnClick="linkRegister_Click" />
                </div>
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
    <script src="../public/js/verificacion2.js"></script>
</body>
</html>
