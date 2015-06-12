<?php

/**
 * Skripta za INSERT opreme
 */

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $type = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));
    
    $naziv = $data['Naziv'];
    $kolicina = $data['Kolicina'];
    $godiste = $data['Godiste'];
    $brojsjedala = $data['BrojSjedala'];
    $zapremnina = $data['ZapremninaVode'];
    $jacina = $data['Jacina'];
    $tezina = $data['Tezina'];
    $tipvozila = $data['TipVozila'];
    $maxprotok = $data['MaxProtok'];
    $maxvisina = $data['MaxVisina'];
    
    //build query
    if($type['tip'] == 'Vozilo') {
        $query = "INSERT INTO oprema VALUES (default, 11, '$naziv', '$kolicina',"
                . " '$godiste', '$brojsjedala', '$zapremnina', null, null, '$jacina',"
                . " '$tezina', '$tipvozila')";
    }
    
    elseif($type['tip'] == 'Oprema') {
        $query = "INSERT INTO oprema VALUES (default, 14, '$naziv', '$kolicina', '$godiste')";
    }
    
    elseif($type['tip'] == 'Pumpa') {
        $query = "INSERT INTO oprema VALUES (default, 10, '$naziv', '$kolicina', '$godiste',"
                . " null, null, '$maxprotok', '$maxvisina', '$jacina', '$tezina', null";
    }
    echo $type['tip'] . $query;
    exit;
    //izvrši
    $Dbase = new DB();
    $Dbase->execute($query);
    
    //response
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u unosu opreme! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}