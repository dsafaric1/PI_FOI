<?php

/**
 * Registracija korisnika sustava
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    $username = $data['username'];
    $password = $data['password'];
    $oib = $data['user'];
   
    //korisnici koji nemaju password
    $query = "UPDATE vatrogasci SET korisnicko_ime = '$username', lozinka = '$password' WHERE oib = '$oib'";

    $Dbase = new DB();
    $Dbase->execute($query);
    
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška kod registriranja člana! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}