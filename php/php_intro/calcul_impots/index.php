<!DOCTYPE html>
<html lang="fr_FR">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="./assets/css/style.css"> 
    <title>Calcul impot</title>
</head>
<body>
    <form action="#" method="get" enctype="text/plain">
        <label for="nom"> Votre nom :</label>
        <input type="text" maxlength="50" name="nom" id="nom" require ><br>
        <label for="revenu">salaire annuel</label>
        <input type="number" name="revenu" id="revenu" step="0.01" require><br>
        <input type="submit" value="calculer" name="calcul" id="calcul"><br>
        <label for="impot"> montant de l'impot sur le revenu</label><br>
        <input type="text" name="impot" id="impot" readonly size="10">
    </form>
    
</body>
<?php

const TAUX_REDUIT=0.09;
const TAUX_MAX=0.14;

function calculerTmpot( float $_salaire ):float
{
    $montant=0.01;
    if ($_salaire<=15000) {
        $montant= $_salaire*TAUX_REDUIT;
    }
    else {
        $tranche1 = 15000*TAUX_REDUIT;
        $tranche2 = ($_salaire-15000)*TAUX-MAX;
        $montant=$tranche1+$tranche2;
    }
    return $montant;
}

if (isset($_GET["revenu"]) && !empty($_GET["revenu"])) {
    $montantImpot= calculerTmpot(floatval($_GET["revenu"]));
    echo "Votres impot sur le revenu est de : ".$montanImpot."€";
}
?>
</html>