<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=, initial-scale=1.0">
    <title>Affichage tableau amorrtissement Prêt</title>
</head>
<body>
    
<?php
include "./models/Pret.php";
$objPret = new Pret(10000, 5.3, 5);
echo $objPret->calculMensualite2();
$tableauAmrt = $objPret->getTableauAmortissement();
var_export($tableauAmrt);


?>

</body>
</html>