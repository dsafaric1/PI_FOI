<?php

/* 
 * Skripta za INSERT narudzbi
 */

require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $vatrogasac = get_object_vars(json_decode(html_entity_decode($_POST['additionalData'])));
    
    //build query
    $rok = substr($data['RokIsporuke'], 0, 10);
    $nacin = $data['NacinIsporuke'];
    $datum = date("Y-m-d");
    $dob = get_object_vars($data['Dobavljac']);
    $dobavljac = "(SELECT id_dobavljaci FROM dobavljaci WHERE naziv = '{$dob['Naziv']}')";
    $izradio = "(SELECT id_vatrogasci FROM vatrogasci WHERE oib = '{$vatrogasac['OIB']}')";
    
    $query = "INSERT INTO narudzbe VALUES (default, '$rok', '$nacin', '$datum', $dobavljac, $izradio, 0)";

    //izvrši
    $Dbase = new DB();
    $Dbase->execute($query);
    
    //response
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u kreiranju narudžbe! " . $Dbase->getError();
    } else {
        $id = $Dbase->getInsertedID();
        $stavke = $data['Stavke'];
        $stavkeQuery = "INSERT INTO stavke_narudzbe VALUES ";
        $trigger = array();
        foreach($stavke as $stavka) {
            $s = get_object_vars($stavka);
            $oprema = get_object_vars($s['NarucenaOprema']);
            $opremaID = "(SELECT id_oprema FROM oprema WHERE naziv = '{$oprema['Naziv']}')";
            $stavkeQuery .= "($id, $opremaID, '{$s['Kolicina']}', '{$s['Cijena']}',"
                        . " '{$s['JedinicaMjera']}'), ";
            $trigger[] = "CALL kolicina_update({$s['Kolicina']}, $opremaID)";
        }
        $stavkeQuery = substr($stavkeQuery, 0, -2);        
        
        $Dbase->execute($stavkeQuery);
        
        if($Dbase->hasFailed()) {
            $response['passed'] = false;
            $response['text'] = "Pogreška u kreiranju stavki narudžbe! " . $Dbase->getError();
        } else {
            //izvrši update količine
            foreach($trigger as $command) {
                $Dbase->execute($command);
            }
            $response['passed'] = true;
        }
    }
    
    echo json_encode($response);
}
?>