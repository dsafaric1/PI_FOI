<?php

/**
 * Skripta za provjeru korisnika (lozinke)
 */
require_once './Bridge/Baza.class.php';
require_once './Core/Vatrogasac.class.php';

$Dbase = new Baza();
if(isset($_POST['obj'])) {
    $data = json_decode($_POST['obj'],true);
    $username = $data['username'];
    $password = $data['password'];
    
    //DB query
    $query = "SELECT * FROM vatrogasci WHERE korisnicko_ime = '$username'";
    $password_set = $Dbase->selectDB($query);
    
    //ako ima rezultata provjeri
    if($password_set->num_rows != 0) {
        $dbPassword = $password_set->fetch_array();
        
        //lozinke se poklapaju
        if($dbPassword['lozinka'] == $password) {
            $response['valid'] = true;
            
            //povuci podatke
            $vatro = new Vatrogasac();
            $vatro->setAdresa($dbPassword['adresa']);
            $vatro->setDatum_rodjenja($dbPassword['datum_rodjenja']);
            $vatro->setDatum_uclanjenja($dbPassword['datum_uclanjenja']);
            $vatro->setIme($dbPassword['ime']);
            $vatro->setPrezime($dbPassword['prezime']);
            $vatro->setOib($dbPassword['oib']);
            $vatro->setVrsta_clana($dbPassword['vrsta_clana']);
            $vatro->setZvanje($dbPassword['zvanje']);
            
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