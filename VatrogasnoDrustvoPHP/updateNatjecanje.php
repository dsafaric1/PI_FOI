<?php

/**
 * Skripta za UPDATE natjecanja
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    //build query
    $id = $data['ID'];
    $naziv = $data['Naziv'];
    $mjesto = $data['Mjesto'];
    $vrijeme = $data['VrijemeOdrzavanja'];
    $kotizacija = $data['Kotizacija'];
    $tip = "(SELECT id_tip_natjecanja FROM tip_natjecanja WHERE naziv = '{$data['Tip']}')";
    
    $query = "UPDATE natjecanja SET naziv = '$naziv', mjesto = '$mjesto', vrijeme_odrzavanja = '$vrijeme',"
            . " kotizacija = '$kotizacija', tip_natjecanja = $tip WHERE id_natjecanja = '$id'";

    //izvrši
    $Dbase = new DB();
    $Dbase->execute($query);
    
    //response
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u ažuriranju natjecanja! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}
