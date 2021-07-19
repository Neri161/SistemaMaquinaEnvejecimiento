<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SistemaMaquinaEnvejecimiento.Vistas.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta charset="UTF-8">
    <meta name="viewport"
        content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Registro | SME</title>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="../public/bootstrap4/css/bootstrap.min.css">

    <link rel="stylesheet" href="../public/plugins/sweetAlert2/sweetalert2.min.css">

    <link rel="stylesheet" href="../public/plugins/animate.css/animate.css">

    <link href="../public/css/Style.css" rel="stylesheet" />

</head>
<body>
    <section class="container">
        <form id="form1" runat="server">
            <header class="align-content-center text-center">
                <asp:Image ImageUrl="~/public/img/logo.png" CssClass="img-fluid" Width="150" runat="server" />
                <div class="text-center text-dark"><strong>SISTEMA DE MAQUINA DE ENVEJECIMIENTO</strong></div>
            </header>
            <div class="container border" style="border-color: #cfd8dc;">
                <div class="text-center text-muted"><strong>Registrar Usuario</strong></div>
                <div class="form-row">
                    <div class="col">
                        <asp:Label ID="lblpaterno" runat="server" Text="Apellido Paterno"></asp:Label>
                        <asp:TextBox ID="paterno" class="form-control" runat="server" placeholder="Apellido Paterno" requiered></asp:TextBox>
                    </div>
                    <div class="col">
                        <asp:Label ID="lblmaterno" runat="server" Text="Apellido Materno"></asp:Label>
                        <asp:TextBox ID="materno" class="form-control" runat="server" placeholder="Apellido Materno" requiered></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblnombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:TextBox ID="nombre" class="form-control" runat="server" placeholder="Nombre" requiered></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblcorreo" runat="server" Text="Correo"></asp:Label>
                    <asp:TextBox ID="email" class="form-control" TextMode="Email" runat="server" placeholder="Correo" requiered></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblpass1" runat="server" Text="Contraseña"></asp:Label>
                    <asp:TextBox ID="pass1" class="form-control" TextMode="Password" runat="server" placeholder="Contraseña" requiered></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Label ID="lblpass2" runat="server" Text="Confirmar Contraseña"></asp:Label>
                    <asp:TextBox ID="pass2" class="form-control" TextMode="Password" runat="server" placeholder="Confirmar Contraseña" requiered></asp:TextBox>
                </div>
                <asp:Button ID="btnRegistrar" class="btn btn-lg btn-orange btn-block" runat="server" Text="Registrar" OnClick="btnRegistrar_Click" />
                <asp:Button ID="btnRegresar" class="btn btn-lg btn-orange btn-block" runat="server" Text="Regresar Al Login" OnClick="btnRegresar_Click" />
            </div>
        </form>
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
    <script src="../public/js/verificacion.js"></script>
</body>
</html>
