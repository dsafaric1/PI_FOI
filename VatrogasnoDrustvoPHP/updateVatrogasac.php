<?php

/**
 * Skripta za UPDATE
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    //build update
    $update = "UPDATE vatrogasci SET ime = '{$data['Ime']}', prezime = '{$data['Prezime']}',"
    . " oib = '{$data['OIB']}', adresa = '{$data['Adresa']}', datum_rodjenja = '{$data['DatumRodenja']}',"
    . " datum_uclanjenja = '{$data['DatumUclanjenja']}', vrsta_clana = (SELECT id_vrsta_clana FROM vrste_clanova"
    . " WHERE naziv = '{$data['VrstaClana']}'), zvanje = (SELECT id_zvanja FROM zvanja WHERE naziv = '{$data['Zvanje']}')"
    . " WHERE oib = '{$data['OIB']}'";
    
    //izvrši upit
    $Dbase = new DB();
    $Dbase->execute($update);
    
    //desila se greška
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u ažuriranju člana! " . $Dbase->getError();
        
    //sve je ok
    } else {
        //ažurirana dužnost
        if($data['Duznost'] != "Nema") {
            $duznost = "UPDATE duznosti SET vatrogasac = (SELECT id_vatrogasci FROM vatrogasci WHERE"
                    . " oib = '{$data['OIB']}') WHERE naziv = '{$data['Duznost']}'";
            $Dbase->execute($duznost);
            
            //greška kod dužnosti
            if($Dbase->hasFailed()) {
                $response['passed'] = false;
                $response['text'] = "Pogreška u ažuriranju dužnosti! " . $Dbase->getError();
                
            //sve je dobro
            } else {
                $response['passed'] = true;
            }
            
        } else {
            $response['passed'] = true;
        }
    }
    
    echo json_encode($response);
}