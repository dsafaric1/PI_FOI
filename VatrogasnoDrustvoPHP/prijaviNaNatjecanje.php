<?php

/**
 * Skripta za prijavu na natjecanje
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $natjecanje = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));
    
    //učitaj podatke o prijavi
    $naziv = $data['Naziv'];
    $kategorija = "(SELECT id_kategorije FROM kategorije WHERE naziv = '{$data['Kategorija']}')";
    $clanovi = $data['Clanovi'];
    
    //izgradi query
    $ekipaQuery = "INSERT INTO ekipe VALUES (default, '$naziv', $kategorija, {$natjecanje['ID']}, 0, 0)";

    //izvrši
    $Dbase = new DB();
    $Dbase->execute($ekipaQuery);
    
    //pad izvršavanja
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Neuspješan unos ekipe! " . $Dbase->getError() . $ekipaQuery;
        
    } else {
        //unešeni id
        $id = $Dbase->getInsertedID();
        
        //izgradi insert
        $clanoviQuery = "INSERT INTO trenira VALUES ";
        foreach($clanovi as $atributi) {
            //članovi su objekti, iz oiba se vadi id
            $clan = get_object_vars($atributi);
            $subquery = "((SELECT id_vatrogasci FROM vatrogasci WHERE oib = '{$clan['OIB']}'), $id), ";
            $clanoviQuery .= $subquery;
        }
        $clanoviQuery = substr($clanoviQuery, 0, -2);
        
        //izvrši
        $Dbase->execute($clanoviQuery);
        
        //provjera i response
        if($Dbase->hasFailed()) {
            $response['passed'] = false;
            $response['text'] = "Neuspješan unos članova ekipe! " . $Dbase->getError();
        } else {
            $response['passed'] = true;
        }
    }
    
    echo json_encode($response);
}