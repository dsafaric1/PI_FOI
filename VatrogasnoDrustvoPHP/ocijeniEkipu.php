<?php

/**
 * Skripta za ocjenjivanje ekipe
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $ekipaObj = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));

    $ocjena = $data['ocjena'];
    $naziv = $data['naziv'];
    $rezultat = $data['rezultat'];
    $ekipa = $ekipaObj['ID'];
    
    $query = "UPDATE ekipe SET naziv = '$naziv', rezultat = $rezultat, ocjena = $ocjena WHERE id_ekipe = $ekipa";
    
    $Dbase = new DB();
    $Dbase->execute($query);
    
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška kod unosa rezultata/ocjena! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}
