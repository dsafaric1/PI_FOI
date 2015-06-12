<?php

/* 
 * Skripta za INSERT narudzbi
 */

require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $vatrogasac = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));
    
    //build query
    $naziv = $data['Naziv'];
    $mjesto = $data['Mjesto'];
    $vrijeme = $data['VrijemeOdrzavanja'];
    $kotizacija = $data['Kotizacija'];
    $tip = "(SELECT id_tip_natjecanja FROM tip_natjecanja WHERE naziv = '{$data['Tip']}')";
    
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
?>