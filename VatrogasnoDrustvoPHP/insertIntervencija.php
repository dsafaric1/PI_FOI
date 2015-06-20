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
    
    if(!isset($opis) || !isset($uzrok) || !isset($pocetnoVrijeme) || !isset($zavrsnoVrijeme) || !isset($vrstaIntervencije)
            || $adresa[0] != strtoupper($adresa[0]) || $mjesto[0] != strtoupper($mjesto[0])) {
        $response['passed'] = false;
        $response['text'] = "Nisu ispravno uneseni podaci!";
        echo json_encode($response);
        exit;
    }
    
    $query = "INSERT INTO intervencije values (default, '$mjesto', '$adresa', '$pocetnoVrijeme', '$zavrsnoVrijeme', "
                . "'$opis', '$uzrok', $vrstaIntervencije)";
    
    $Dbase = new DB();
     $Dbase->execute($query);
     $id = $Dbase->getInsertedID();
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
        $response['text'] = "Pogreška kod unosa nove intervencije!" .$Dbase->getError(). $query;
    } 
    else {
        $response['passed'] = TRUE;
    }
   
    echo json_encode($response);
    
}