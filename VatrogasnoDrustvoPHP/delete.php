<?php

/**
 * Skripta za brisanje
 */
require_once './Bridge/DB.class.php';


if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $type = json_decode($_POST['additionalData']);
    $oib = $data['OIB'];
    
    
    switch(substr($type, strrpos($type, ".") + 1)) {
        case "Vatrogasac": $table = "vatrogasci"; break;
        case "Intervencija": $table = "intervencije"; break;
        case "Natjecanje": $table = "natjecanja"; break;
        //i još kaj treba TODO
    }
    
    $delete = "DELETE FROM $table WHERE oib = '$oib'";
    
    $Dbase = new DB();
    $Dbase->execute($delete);
    
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u brisanju retka! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}

