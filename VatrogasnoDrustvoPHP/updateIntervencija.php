<?php

/* 
 * Skripta za UPDATE intervencija
 */

require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])){
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    $mjesto = $data["Mjesto"];
    $opis = $data["Opis"];
    $adresa = $data["Adresa"];
    $uzrok = $data["Uzrok"];
    $pocetnoVrijeme = $data["PocetnoVrijeme"];
    $zavrsnoVrijeme = $data["ZavrsnoVrijeme"];
    $vrstaIntervencije = "(SELECT id_vrste_intervencija FROM vrste_intervencija WHERE naziv = '{$data ['Vrsta']}')";
    $brojDojave = $data["BrojDojave"];
    
    $id = $data['BrojDojave'];
    $delete = "DELETE FROM prisutni WHERE intervencija = '$id'";
    
    $Dbase = new DB();
    $Dbase->execute($delete);
    
    if($Dbase->hasFailed()){
        $response['passed'] = false;
        $response['text'] = "Neuspješno brisanje vatrogasca! ". $Dbase->getError();
        echo json_encode($response);
        exit;
    }
    
    $query = "UPDATE intervencije set mjesto = '$mjesto', adresa = '$adresa', pocetno_vrijeme = '$pocetnoVrijeme',"
                . " zavrsno_vrijeme = '$zavrsnoVrijeme', opis = '$opis', uzrok = '$uzrok', vrsta_intervencije ="
                . " $vrstaIntervencije WHERE broj_dojavnice = '$brojDojave'";
    
    $Dbase->execute($query);
     
    $vatrogasci = $data['prisutniVatrogasci'];
    
    $prisutni = "INSERT INTO prisutni VALUES ";
    foreach ($vatrogasci as $atributi){
        $clan = get_object_vars($atributi);
        $podupit = "((SELECT id_vatrogasci FROM vatrogasci WHERE oib = '{$clan['OIB']}'), $id), ";
        $prisutni .=$podupit;
    }
    $prisutni = substr($prisutni, 0,-2);

    $Dbase->execute($prisutni);

    if($Dbase->hasFailed()){
        $response['passed'] = false;
        $response['text'] = "Neuspješno ažuriranje vatrogasca! ". $Dbase->getError() . $prisutni;
        echo json_encode($response);
        exit;
    }
    $response['passed'] = true;

    echo json_encode($response);
    
}