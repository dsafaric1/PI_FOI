<?php

/**
 * Skripta za provjeru korisnika (lozinke)
 */
require_once './Bridge/DB.class.php';
require_once './Core/Vatrogasac.class.php';

$Dbase = new DB();
if(isset($_POST['obj'])) {
    $data = json_decode($_POST['obj'],true);
    $username = $data['username'];
    $password = $data['password'];
    
    //DB query
    $query = "SELECT * FROM vatrogasci WHERE korisnicko_ime = '$username'";
    $password_set = $Dbase->execute($query);
    
    //error
    if($Dbase->hasFailed()) {
        $response['valid'] = false;
        $response['text'] = "Pogreška u dohvaćanju: " . $Dbase->getError();

    //ako ima rezultata provjeri
    } elseif($password_set->num_rows != 0) {
        $dbPassword = $password_set->fetch_array();
        
        //lozinke se poklapaju
        if($dbPassword['lozinka'] == $password) {
            $response['valid'] = true;
            
            //povuci podatke
            $vatro = new Vatrogasac($dbPassword);            
            $response['vatrogasac'] = get_object_vars($vatro);
            
        } else {
            $response['valid'] = false;
            $response['text'] = "Neispravna lozinka!";
        }
    
    //nema rezultata
    } else {
        $response['valid'] = false;
        $response['text'] = "Nepostojeći korisnik!";
    }
    
    //vrati odg
    echo json_encode($response);
}