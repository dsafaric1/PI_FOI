<?php

/**
 * Skripta za brisanje
 */
require_once './Bridge/DB.class.php';


if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $type = json_decode($_POST['additionalData']);
    
    switch(substr($type, strrpos($type, ".") + 1)) {
        case "Vatrogasac": 
            $table = "vatrogasci"; 
            $column = "oib";
            $id = $data['OIB'];
            break;
        case "Intervencija": 
            $table = "intervencije"; 
            $column = "broj_dojavnice";
            $id = $data['BrojDojave'];
            break;
        case "Natjecanje": 
            $table = "natjecanja"; 
            $column = "id_natjecanja";
            $id = $data['ID'];
            break;
        case "Dobavljac":
            $table = "dobavljaci";
            $column = "id_dobavljaci";
            $id = $data['ID'];
            break;
        case "Narudzba":
            $table = "narudzbe";
            $column = "id_narudzbe";
            $id = $data['Rbr'];
            break;
        case "Oprema":
            $table = "oprema";
            $column = "id_oprema";
            $id = $data['ID'];
            break;
        //i još kaj treba TODO
    }
    
    $delete = "DELETE FROM $table WHERE $column = '$id'";
    
    if($table == 'narudzbe') {
        $delete = "UPDATE $table SET storno = 1 WHERE $column = $id";
    }
    
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

