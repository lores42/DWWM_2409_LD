<?php
class AnnuaireRepository{
    private array $nomscolumn;
    private ?PDO $connect;

    public function __construct()
    {
        $this->connect=Connexion::getInstance();
        $this->nomscolumn=[];
    }

    public function info_table():array{
        $rq ="SELECT* form carnet";
        $PDOstatment= $this->connect->prepare($rq);
        $PDOstatment->execute();
        $nbCol= $PDOstatment->columnCount();
        for ($i=0; $i <$nbCol ; $i++) { 
            $tabinfo= $PDOstatment->getColumnMeta($i);
                array_push($this->nomscolumn, $tabinfo["name"]);
        }
        return $this->nomscolumn;


    }


}