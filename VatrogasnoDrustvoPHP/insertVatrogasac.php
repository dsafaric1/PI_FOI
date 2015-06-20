<?php

/**
 * Skripta za INSERT vatrogasaca
 */
require_once './Bridge/DB.class.php';

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    
    //fetch sve podatke
    $ime = $data['Ime'];
    $prezime = $data['Prezime'];
    $oib = $data['OIB'];
    $korisnicko_ime = "null";
    $lozinka = "null";
    $adresa = $data['Adresa'];
    $datum_rod = $data['DatumRodenja'];
    $datum_upis = $data['DatumUclanjenja'];
    $vrsta = "(SELECT id_vrsta_clana FROM vrste_clanova WHERE naziv = '{$data['VrstaClana']}')";
    $zvanje = "(SELECT id_zvanja FROM zvanja WHERE naziv = '{$data['Zvanje']}')";
    
    if(!isset($oib) || !isset($datum_rod) || !isset($datum_upis) || !isset($vrsta) || !isset($zvanje) || strlen($oib) != 11
            || $adresa[0] != strtoupper($adresa[0]) || $ime[0] != strtoupper($ime[0]) || $prezime[0] != strtoupper($prezime[0])) {
        $response['passed'] = false;
        $response['text'] = "Nisu ispravno uneseni podaci!";
        echo json_encode($response);
        exit;
    }
    
    $query = "INSERT INTO vatrogasci VALUES (default, '$ime', '$prezime', '$oib',"
            . " '$korisnicko_ime', '$lozinka', '$adresa', '$datum_rod', '$datum_upis',"
            . " $vrsta, $zvanje)";
    
    $Dbase = new DB();
    $Dbase->execute($query);
    
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška kod unosa novog člana! " . $Dbase->getError();
        
    } else {
        
        //kad izvršiš, ak ima dužnost, treba ju dodat u drugu tablicu
        if($data['Duznost'] != "Nema") {
            $id = $Dbase->getInsertedID();
            $duznost = "UPDATE duznosti SET vatrogasac = $id WHERE naziv = '{$data['Duznost']}'";
            $Dbase->execute($duznost);
            
            if($Dbase->hasFailed()) {
                
                $response['passed'] = false;
                $response['text'] = "Pogreška kod unosa dužnosti! " . $Dbase->getError();
                
            } else {
                $response['passed'] = true;
            }
        } else {
            $response['passed'] = true;
        }
    }
    
    echo json_encode($response);
}