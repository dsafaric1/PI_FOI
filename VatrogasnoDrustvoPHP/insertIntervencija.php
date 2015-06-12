<?php

/* 
 * Skripta za INSERT intervencija
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
    
    if(isset($_POST['additionalData'])){
        $query = "INSERT INTO intervencije values (default, '$mjesto', '$adresa', '$pocetnoVrijeme', '$zavrsnoVrijeme', "
                . "'$opis', '$uzrok', $vrstaIntervencije)";
    }
    else {
        $query = "UPDATE intervencije set mjesto = '$mjesto', adresa = '$adresa', pocetno_vrijeme = '$pocetnoVrijeme',"
                . " zavrsno_vrijeme = '$zavrsnoVrijeme', opis = '$opis', uzrok = '$uzrok', vrsta_intervencije ="
                . " $vrstaIntervencije WHERE broj_dojavnice = '$brojDojave'";
    } 
    
    $Dbase = new DB();
    $Dbase->execute($query);
    
    if($Dbase->hasFailed()){
        $response['passed'] = false;
        $response['text'] = "Pogreška kod unosa nove intervencije!" .$Dbase->getError();
    } 
    else {
        $response['passed'] = true;
    }
    echo json_encode($response);
    
}