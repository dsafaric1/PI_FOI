<?php

/**
 * Skripta za dohvaćanje podataka iz tablica
 */
require_once './Bridge/DB.class.php';

if(isset($_GET['table'])) {
    $table = $_GET['table'];
    
    //za tablicu članovi
    if($table == "Članovi") {
        $query = "SELECT vatrogasci.oib as OIB, vatrogasci.ime as Ime, vatrogasci.prezime as Prezime,"
                . " vatrogasci.datum_rodjenja as 'Datum rođenja', vatrogasci.datum_uclanjenja as 'Datum učlanjenja',"
                . " zvanja.naziv as Zvanje, adresa as Adresa, vrste_clanova.naziv as 'Vrsta člana',"
                . " (SELECT duznosti.naziv FROM duznosti WHERE duznosti.vatrogasac = vatrogasci.id_vatrogasci) as 'Dužnost'"
                . " FROM vatrogasci JOIN vrste_clanova ON vrste_clanova.id_vrsta_clana = vatrogasci.vrsta_clana"
                . " JOIN zvanja ON zvanja.id_zvanja = vatrogasci.zvanje";
    }
    
    //za tablicu intervencije
    elseif($table == "Intervencije") {
        $query = "SELECT broj_dojavnice as 'Broj dojavnice', mjesto as 'Mjesto', adresa as 'Adresa', pocetno_vrijeme"
                . " as 'Početno vrijeme', zavrsno_vrijeme as 'Završno vrijeme', opis as 'Opis', uzrok as 'Uzrok',"
                . " naziv as 'Vrsta intervencije' FROM intervencije JOIN vrste_intervencija ON"
                . " id_vrste_intervencija = vrsta_intervencije";
    }
    
    elseif($table == "Natjecanja") {
        $query = "SELECT id_natjecanja as ID, natjecanja.naziv as 'Naziv', mjesto as Mjesto, vrijeme_odrzavanja as"
                . " 'Vrijeme održavanja', kotizacija as 'Kotizacija', tip_natjecanja.naziv as"
                . " 'Tip natjecanja' FROM natjecanja JOIN tip_natjecanja ON tip_natjecanja = id_tip_natjecanja";
    }
    
    elseif($table == "Oprema") {
        $query = "SELECT oprema.naziv as Oprema, kolicina as 'Količina', godiste as 'Godište', broj_sjedala"
                . " as 'Broj sjedala', zapremnina_vode as 'Zapremnina vode', max_protok as 'Max protok',"
                . " max_visina_pumpanja as 'Max visina pumpanja', jacina as 'Jačina', tezina as 'Težina',"
                . " tip_opreme.naziv as 'Tip opreme', tip_vozila.naziv as 'Tip vozila' FROM oprema JOIN tip_opreme"
                . " ON tip_opreme = id_tip_opreme JOIN tip_vozila ON tip_vozila = id_tip_vozila";
    }
    
    elseif($table == "NonUsers") {
        $query = "SELECT oib as OIB, CONCAT(ime, ' ', prezime) as Osoba FROM vatrogasci WHERE korisnicko_ime = 'null'";
    }
    
    elseif($table == "Dobavljači") {
        $query = "SELECT id_dobavljaci as 'Redni broj', naziv as 'Naziv', adresa as 'Adresa', kontakt as 'Kontakt broj',"
                . " 'e-mail' as 'E-mail' FROM dobavljaci";
    }
    
    elseif($table == "Competitors") {
        $id = $_GET['natjecanje'];
        $query = "SELECT oib as OIB, CONCAT(ime, ' ', prezime) as Osoba FROM vatrogasci JOIN trenira ON id_vatrogasca = vatrogasac WHERE id_vatrogasca NOT IN (SELECT vatrogasac FROM trenira)";
    }
    
    //izvrši upit
    $Dbase = new DB();
    $results = $Dbase->execute($query);
    
    //error
    if($Dbase->hasFailed()) {
        echo "Pogreška u dohvaćanju" . $Dbase->getError();
        exit;
    }
    
    $send = array();
    
    //spremi podatke
    while($res = $results->fetch_assoc()) {
        array_push($send, $res);
    }
    
    //šalji podatke
    echo json_encode($send);
}