<?php

/*
 * Skripta za INSERT dobavljaća 
 */
 
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])){
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    $naziv = $data["Naziv"];
    $kontakt = $data["Kontakt"];
    $adresa = $data["Adresa"];
    $email = $data["Email"];
    
    if(!preg_match("#^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$#", $email)
            || $adresa[0] != strtoupper($adresa[0])) {
        $response['passed'] = false;
        $response['text'] = "Nisu ispravno uneseni podaci!";
        echo json_encode($response);
        exit;
    }
    
    $upit = " insert into dobavljaci(naziv, adresa, kontakt, email) values ('$naziv', '$adresa', '$kontakt', '$email')";
    $Dbase = new DB();
    $Dbase->execute($upit);
    
    if($Dbase->hasFailed()){
        $response['passed'] = false;
        $response['text'] = "Pogreška kod unosa novoga dobavljača!" .$Dbase->getError();
    } 
    else {
        $response['passed'] = true;
    }
    echo json_encode($response);
}

