<?php

class Pret
{

    // Atribus
    private float $capital;
    private float $tauxMensuel;
    private int $nbMois;

    // propriétés accesseur(getter)

    public function getCapital(): float
    {
        return $this->capital;
    }

    public function getTauxMensul(): float
    {
        return $this->tauxMensuel;
    }

    public function getMois(): int
    {
        return $this->nbMois;
    }

    //exemple modifieur(setter)
    public function setMois(int $nbNouvMois): void
    {
        $this->nbMois = $nbNouvMois;
    }


    public function __construct(float $_montant, float $_tauxAnnuel, int $_nbAnnees)
    {
        $this->capital = $_montant;
        $this->tauxMensuel = $_tauxAnnuel / 1200;
        $this->nbMois = $_nbAnnees * 12;
    }

    //methodes
    /*
    Q= (1-(1+ Tm )puissance -n)
    a : la mensualité constante recherché :
    a= (k * tm)/Q
    */
    public function calculMensualite(): float
    {
        $Q = (1 - pow((1 + $this->tauxMensuel), -$this->nbMois));
        $mensualite = ($this->capital * $this->tauxMensuel) / $Q;
        return round($mensualite, 2);
    }

    //methode pour affichage en string
    public function calculMensualite2(): string
    {
        $Q = (1 - pow((1 + $this->tauxMensuel), -$this->nbMois));
        $mensualite = ($this->capital * $this->tauxMensuel) / $Q;
        return number_format($mensualite, 2, ",", " ") . "€";
    }


    public function getTableauAmortissement(): array
    {
        $data = array();
        $parInteret = 0;
        $paramortissement = 0;
        $mensualite = $this->calculMensualite();
        $capitalRestant = $this->capital;
        for ($i = 0; $i < $this->nbMois; $i++) {
            $parInteret = $capitalRestant * $this->tauxMensuel;
            $paramortissement = $mensualite - $parInteret;

            if ($i > 0) {
                $capitalRestant -= $paramortissement;
            }

            $numeroMois = $i++;

            Array_push($data, ["numeroMois" => $i + 1, "partInteret" => round($parInteret, 2), "partAmortissement" => round($paramortissement, 2), "capitalRestant" => round($capitalRestant, 2), "mensualite" => round($mensualite, 2)]);
        }
        //return $data;

        for ($i = o; $i < count($data); $i++){
            
        }
    }
}
