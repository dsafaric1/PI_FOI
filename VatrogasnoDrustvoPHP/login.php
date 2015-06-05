<?php

/**
 * Skripta za provjeru korisnika (lozinke)
 */
require_once './Bridge/Baza.class.php';

$Dbase = new Baza();
if(isset($_POST['obj'])) {
    $data = json_decode($_POST['obj'],true);
    $username = $data['username'];
    $password = $data['password'];
    
    //DB query
    $query = "SELECT lozinka FROM vatrogasci WHERE korisnicko_ime = '$username'";
    $password_set = $Dbase->selectDB($query);
    
    //ako ima rezultata provjeri
    if($password_set->num_rows != 0) {
        $dbPassword = $password_set->fetch_row();
        
        //lozinke se poklapaju
        if($dbPassword[0] == $password) {
            $response['valid'] = true;
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