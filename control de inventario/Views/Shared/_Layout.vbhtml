﻿<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <title>@ViewBag.Title - Inventario</title>
    @Styles.Render("~/Content/css")
    @Scripts.Render("~/bundles/modernizr")



    <!-- Custom fonts for this template -->
    <link href="https://fonts.googleapis.com/css?family=Catamaran:100,200,300,400,500,600,700,800,900" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Lato:100,100i,300,300i,400,400i,700,700i,900,900i" rel="stylesheet">



</head>

<body>
    <!-- Navigation -->
    <nav class="navbar navbar-expand-lg navbar-dark navbar-custom fixed-top">
        <div class="container">
            <a class="navbar-brand btn-outline-secondary" href="@Url.Action("Index", "Home")">Inventario Tec</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ml-auto">
                    <li class="nav-item">
                        <a class="nav-link btn-outline-secondary" href="@Url.Action("Register", "Account")">Registro</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link btn-outline-secondary" href="@Url.Action("Login", "Account")">Iniciar sesion</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>


    @RenderBody()

    <!-- Footer -->
    <footer class="py-5 bg-black">
        <div class="container">
            <p class="m-0 text-center text-white small">Copyright &copy; Ventario Tecnologico 2020</p>
        </div>
        <!-- /.container -->
    </footer>

    <!-- Bootstrap core JavaScript -->
    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @RenderSection("scripts", required:=False)

</body>

</html>
