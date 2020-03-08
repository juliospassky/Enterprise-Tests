<?php
$matrizDados = array(
    array("Jan", 2014, 4, 12, 4, 3, 1),
    array("Fev", 2014, 6, 14, 6, 4, 2),
    array("Mar", 2014, 8, 16, 8, 5, 0),
    array("Abr", 2014, 10, 18, 10, 6, 1),
    array("Mai", 2014, 12, 20, 12, 7, 3),
    array("Jun", 2014, 14, 22, 14, 8, 4),
    array("Jul", 2014, 16, 24, 16, 9, 1),
    array("Ago", 2014, 14, 22, 14, 8, 2),
    array("Set", 2014, 12, 20, 12, 7, 0),
    array("Out", 2014, 10, 18, 10, 6, 3),
    array("Nov", 2014, 8, 16, 8, 5, 1),
    array("Dez", 2014, 6, 14, 6, 4, 2));
?>
<!DOCTYPE html>
<html lang="en">

    <head>

        <meta charset="utf-8">
        <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
        <meta name="description" content="">
        <meta name="author" content="">

        <title>Júlio César T. de Oliveira</title>

        <!-- Bootstrap core CSS -->
        <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">

        <!-- Custom fonts for this template -->
        <link href="https://fonts.googleapis.com/css?family=Saira+Extra+Condensed:100,200,300,400,500,600,700,800,900" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i" rel="stylesheet">
        <link href="vendor/font-awesome/css/font-awesome.min.css" rel="stylesheet">
        <link href="vendor/devicons/css/devicons.min.css" rel="stylesheet">
        <link href="vendor/simple-line-icons/css/simple-line-icons.css" rel="stylesheet">

        <!-- Custom styles for this template -->
        <link href="css/resume.min.css" rel="stylesheet">

    </head>

    <body id="page-top">

        <nav class="navbar navbar-expand-lg navbar-dark bg-primary fixed-top" id="sideNav">
            <a class="navbar-brand js-scroll-trigger" href="#page-top">
                <span class="d-block d-lg-none">Júlio César T. de Oliveira</span>
                <span class="d-none d-lg-block">
                    <img class="img-fluid img-profile rounded-circle mx-auto mb-2" src="img/logo.png" alt="">
                </span>
            </a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarSupportedContent">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#home">Home</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#empresa">A empresa</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#servicos">Serviços</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#clientes">Clientes</a>
                    </li>
                    <li class="nav-item">
                        <a class="nav-link js-scroll-trigger" href="#contato">Contato</a>
                    </li>
                </ul>
            </div>
        </nav>



        <div class="container-fluid p-0">
            
                <section class="resume-section p-3 p-lg-5 d-flex flex-column" id="home">
                <?php include 'pages/Cabecalho.php';?>
                <div class="my-auto">
                    <h2 class="mb-5">Dados de 2014</h2>
                    <html>
                        <head>
                            <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                            <script type="text/javascript">
                                    google.charts.load('current', {'packages': ['bar']});
                                    google.charts.setOnLoadCallback(drawChart);

                                    function drawChart() {
                                        var data = google.visualization.arrayToDataTable([
                                            ['Meses', 'Capacidade - Atendimento Realizado'],
                                            ['<?php echo $matrizDados[0][0]; ?>', <?php $valor = $matrizDados[0][3] - $matrizDados[0][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[1][0]; ?>', <?php $valor = $matrizDados[1][3] - $matrizDados[1][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[2][0]; ?>', <?php $valor = $matrizDados[2][3] - $matrizDados[2][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[3][0]; ?>', <?php $valor = $matrizDados[3][3] - $matrizDados[3][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[4][0]; ?>', <?php $valor = $matrizDados[4][3] - $matrizDados[4][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[5][0]; ?>', <?php $valor = $matrizDados[5][3] - $matrizDados[5][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[6][0]; ?>', <?php $valor = $matrizDados[6][3] - $matrizDados[6][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[7][0]; ?>', <?php $valor = $matrizDados[7][3] - $matrizDados[7][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[8][0]; ?>', <?php $valor = $matrizDados[8][3] - $matrizDados[8][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[9][0]; ?>', <?php $valor = $matrizDados[9][3] - $matrizDados[9][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[10][0]; ?>', <?php $valor = $matrizDados[10][3] - $matrizDados[10][5]; echo $valor; ?>],
                                            ['<?php echo $matrizDados[11][0]; ?>', <?php $valor = $matrizDados[11][3] - $matrizDados[11][5]; echo $valor; ?>]
                                            
                                        ]);

                                        var options = {
                                            chart: {
                                                title: 'Performace da compania',
                                                subtitle: 'Valores do ano: 2014',
                                            }
                                        };

                                        var chart = new google.charts.Bar(document.getElementById('columnchart_material'));

                                        chart.draw(data, google.charts.Bar.convertOptions(options));
                                    }
                            </script>
                        </head>
                        <body>
                            <div id="columnchart_material" style="width: 800px; height: 500px;"></div>
                        </body>
                    </html>
                    
                    
                    <html>
                        <head>
                        </head>
                        <body>
                        <html>
                            <head>
                                <script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
                                <script type="text/javascript">
                                    google.charts.load('current', {'packages': ['table']});
                                    google.charts.setOnLoadCallback(drawTable);

                                    function drawTable() {
                                        var data = new google.visualization.DataTable();
                                        data.addColumn('string', 'Data');
                                        data.addColumn('number', 'Demanda');
                                        data.addColumn('number', 'Capacidade');
                                        data.addColumn('number', 'Atendimento Planejado');
                                        data.addColumn('number', 'Atendimento realizado');
                                        data.addColumn('number', 'Desvio');


                                        data.addRows([
                                            ["<?php echo $matrizDados[0][0] . '/' . $matrizDados[0][1]; ?>",<?php echo $matrizDados[0][2]; ?>,<?php echo $matrizDados[0][3]; ?>,<?php echo $matrizDados[0][4]; ?>,<?php echo $matrizDados[0][5]; ?>,<?php echo $matrizDados[0][6]; ?>],
                                            ["<?php echo $matrizDados[1][0] . '/' . $matrizDados[1][1]; ?>",<?php echo $matrizDados[1][2]; ?>,<?php echo $matrizDados[1][3]; ?>,<?php echo $matrizDados[1][4]; ?>,<?php echo $matrizDados[1][5]; ?>,<?php echo $matrizDados[1][6]; ?>],
                                            ["<?php echo $matrizDados[2][0] . '/' . $matrizDados[2][1]; ?>",<?php echo $matrizDados[2][2]; ?>,<?php echo $matrizDados[2][3]; ?>,<?php echo $matrizDados[2][4]; ?>,<?php echo $matrizDados[2][5]; ?>,<?php echo $matrizDados[2][6]; ?>],
                                            ["<?php echo $matrizDados[3][0] . '/' . $matrizDados[3][1]; ?>",<?php echo $matrizDados[3][2]; ?>,<?php echo $matrizDados[3][3]; ?>,<?php echo $matrizDados[3][4]; ?>,<?php echo $matrizDados[3][5]; ?>,<?php echo $matrizDados[3][6]; ?>],
                                            ["<?php echo $matrizDados[4][0] . '/' . $matrizDados[4][1]; ?>",<?php echo $matrizDados[4][2]; ?>,<?php echo $matrizDados[4][3]; ?>,<?php echo $matrizDados[4][4]; ?>,<?php echo $matrizDados[4][5]; ?>,<?php echo $matrizDados[4][6]; ?>],
                                            ["<?php echo $matrizDados[5][0] . '/' . $matrizDados[5][1]; ?>",<?php echo $matrizDados[5][2]; ?>,<?php echo $matrizDados[5][3]; ?>,<?php echo $matrizDados[5][4]; ?>,<?php echo $matrizDados[5][5]; ?>,<?php echo $matrizDados[5][6]; ?>],
                                            ["<?php echo $matrizDados[6][0] . '/' . $matrizDados[6][1]; ?>",<?php echo $matrizDados[6][2]; ?>,<?php echo $matrizDados[6][3]; ?>,<?php echo $matrizDados[6][4]; ?>,<?php echo $matrizDados[6][5]; ?>,<?php echo $matrizDados[6][6]; ?>],
                                            ["<?php echo $matrizDados[7][0] . '/' . $matrizDados[7][1]; ?>",<?php echo $matrizDados[7][2]; ?>,<?php echo $matrizDados[7][3]; ?>,<?php echo $matrizDados[7][4]; ?>,<?php echo $matrizDados[7][5]; ?>,<?php echo $matrizDados[7][6]; ?>],
                                            ["<?php echo $matrizDados[8][0] . '/' . $matrizDados[8][1]; ?>",<?php echo $matrizDados[8][2]; ?>,<?php echo $matrizDados[8][3]; ?>,<?php echo $matrizDados[8][4]; ?>,<?php echo $matrizDados[8][5]; ?>,<?php echo $matrizDados[8][6]; ?>],
                                            ["<?php echo $matrizDados[9][0] . '/' . $matrizDados[9][1]; ?>",<?php echo $matrizDados[9][2]; ?>,<?php echo $matrizDados[9][3]; ?>,<?php echo $matrizDados[9][4]; ?>,<?php echo $matrizDados[9][5]; ?>,<?php echo $matrizDados[9][6]; ?>],
                                            ["<?php echo $matrizDados[10][0] . '/' . $matrizDados[10][1]; ?>",<?php echo $matrizDados[10][2]; ?>,<?php echo $matrizDados[10][3]; ?>,<?php echo $matrizDados[10][4]; ?>,<?php echo $matrizDados[10][5]; ?>,<?php echo $matrizDados[10][6]; ?>],
                                            ["<?php echo $matrizDados[11][0] . '/' . $matrizDados[11][1]; ?>",<?php echo $matrizDados[11][2]; ?>,<?php echo $matrizDados[11][3]; ?>,<?php echo $matrizDados[11][4]; ?>,<?php echo $matrizDados[11][5]; ?>,<?php echo $matrizDados[11][6]; ?>]
                                        ]);


                                        var table = new google.visualization.Table(document.getElementById('table_div'));

                                        table.draw(data, {showRowNumber: true, width: '100%', height: '100%'});
                                    }
                                </script>
                            </head>
                            <body>
                                <div id="table_div"></div>
                            </body>
                        </html>
                        </body>
                    </html>
                </div>
            </section>
            
            
            <section class="resume-section p-3 p-lg-5 d-flex d-column" id="empresa">
                <?php include 'pages/Cabecalho.php';?>
                <div class="my-auto">
                    <h2 class="mb-5">A empresa</h2>
                </div>
            </section>


            <section class="resume-section p-3 p-lg-5 d-flex d-column" id="servicos">
                <?php include 'pages/Cabecalho.php';?>
                <div class="my-auto">
                    <h2 class="mb-5">Serviços</h2>
                </div>
            </section>

            <section class="resume-section p-3 p-lg-5 d-flex d-column" id="clientes">
                <?php include 'pages/Cabecalho.php';?>
                <div class="my-auto">
                    <h2 class="mb-5">Clientes</h2>
                </div>
            </section>

            <section class="resume-section p-3 p-lg-5 d-flex d-column" id="contato">
                <?php include 'pages/Cabecalho.php';?>
                <div class="my-auto">
                    <h2 class="mb-5">Contato</h2>
                </div>
            </section>

        </div>

        <!-- Bootstrap core JavaScript -->
        <script src="vendor/jquery/jquery.min.js"></script>
        <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

        <!-- Plugin JavaScript -->
        <script src="vendor/jquery-easing/jquery.easing.min.js"></script>

        <!-- Custom scripts for this template -->
        <script src="js/resume.min.js"></script>

    </body>

</html>
