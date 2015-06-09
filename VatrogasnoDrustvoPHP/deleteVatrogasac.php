<?php

if(isset($_POST['obj'])) {
    $data = get_object_vars(json_decode(html_entity_decode($_POST['obj'])));
    $oib = $data['OIB'];
    
    $delete = "DELETE FROM vatrogasci WHERE oib = '$oib'";
    
    $Dbase = new DB();
    $Dbase->execute($delete);
    
    if($Dbase->hasFailed()) {
        $response['passed'] = false;
        $response['text'] = "Pogreška u brisanju retka! " . $Dbase->getError();
    } else {
        $response['passed'] = true;
    }
    
    echo json_encode($response);
}

