<?php

/**
 * Skripta za UPDATE opreme
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
        $query = "UPDATE oprema SET naziv = '$naziv', kolicina = '$kolicina', godiste = '$godiste',"
                . " broj_sjedala = $brojsjedala, zapremnina_vode = '$zapremnina', max_protok = '$maxprotok',"
                . " max_visina_pumpanja = '$maxvisina', jacina = '$jacina', tezina = '$tezina', tip_vozila = '$tipvozila'";
    }
    echo $query;
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