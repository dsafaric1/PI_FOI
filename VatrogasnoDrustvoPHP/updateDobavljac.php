<?php

/**
 * Skripta za UPDATE dobavljaca
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    //build query
    $naziv = $data['Naziv'];
    $adresa = $data['Adresa'];
    $kontakt = $data['Kontakt'];
    $email = $data['Email'];
    $id = $data['ID'];
    $query = "UPDATE dobavljaci SET naziv = '$naziv', adresa = '$adresa',"
            . " kontakt = '$kontakt', email = '$email' WHERE id_dobavljaci = $id";

    //izvrši
    $Dbase = new DB();
    $Dbase->execute($query);
    
    //response
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u ažuriranju dobavljača! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}
