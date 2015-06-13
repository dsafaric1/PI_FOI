<?php

/**
 * Skripta za UPDATE opreme
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $type = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));
    
    $id = $data['ID'];
    $naziv = $data['Naziv'];
    $kolicina = $data['Kolicina'];
    $godiste = $data['Godiste'];
    $brojsjedala = $data['BrojSjedala'];
    $zapremnina = $data['ZapremninaVode'];
    $jacina = $data['Jacina'];
    $tezina = $data['Tezina'];
    $tipvozila = "(SELECT id_tip_vozila FROM tip_vozila WHERE naziv = '{$data['TipVozila']}')";
    $maxprotok = $data['MaxProtok'];
    $maxvisina = $data['MaxVisinaPumpanja'];
    
    //build query
    if($type['tip'] == 'Vozilo') {
        $query = "UPDATE oprema SET naziv = '$naziv', kolicina = '$kolicina', godiste = '$godiste',"
                . " broj_sjedala = $brojsjedala, zapremnina_vode = '$zapremnina',"
                . " jacina = '$jacina', tezina = '$tezina', tip_vozila = $tipvozila"
                . " WHERE id_oprema = $id";
    }
    elseif($type['tip'] == 'Oprema') {
        $query = "UPDATE oprema SET naziv = '$naziv', kolicina = '$kolicina', godiste = '$godiste'"
                . " WHERE id_oprema = $id";
    }
    elseif($type['tip'] == 'Pumpa') {
        $query = "UPDATE oprema SET naziv = '$naziv', kolicina = '$kolicina', godiste = '$godiste',"
                . " max_protok = '$maxprotok', max_visina_pumpanja = '$maxvisina', jacina = '$jacina',"
                . " tezina = '$tezina' WHERE id_oprema = $id";
    }
    
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