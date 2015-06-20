<?php

/**
 * Skripta za INSERT natjecanja
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $vatrogasac = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));
    
    //build query
    $oib = "(SELECT id_vatrogasci FROM vatrogasci WHERE oib = '{$vatrogasac['OIB']}')";
    $naziv = $data['Naziv'];
    $mjesto = $data['Mjesto'];
    $vrijeme = $data['VrijemeOdrzavanja'];
    $kotizacija = $data['Kotizacija'];
    $tip = "(SELECT id_tip_natjecanja FROM tip_natjecanja WHERE naziv = '{$data['Tip']}')";
    
    if(!isset($naziv) || !isset($mjesto) || $kotizacija<0 || !isset($tip)) {
        $response['passed'] = false;
        $response['text'] = "Nisu ispravno uneseni podaci!";
        echo json_encode($response);
        exit;
    }
    
    $query = "INSERT INTO natjecanja VALUES (default, '$naziv', '$mjesto', '$vrijeme', '$kotizacija', $tip, $oib)";

    //izvrši
    $Dbase = new DB();
    $Dbase->execute($query);
    
    //response
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u kreiranju natjecanja! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}


