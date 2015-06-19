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
    
    //tablica natjecanja
    elseif($table == "Natjecanja") {
        $query = "SELECT id_natjecanja as ID, natjecanja.naziv as 'Naziv', mjesto as Mjesto, vrijeme_odrzavanja as"
                . " 'Vrijeme održavanja', kotizacija as 'Kotizacija', tip_natjecanja.naziv as"
                . " 'Tip natjecanja' FROM natjecanja JOIN tip_natjecanja ON tip_natjecanja = id_tip_natjecanja";
    }
    
    //tablica opreme
    elseif($table == "Oprema") {
        $query = "SELECT id_oprema as 'Šifra', oprema.naziv as Oprema, kolicina as 'Količina', godiste as 'Godište', broj_sjedala"
                . " as 'Broj sjedala', zapremnina_vode as 'Zapremnina vode', max_protok as 'Max protok',"
                . " max_visina_pumpanja as 'Max visina pumpanja', jacina as 'Jačina', tezina as 'Težina',"
                . " tip_opreme.naziv as 'Tip opreme', tip_vozila.naziv as 'Tip vozila' FROM oprema LEFT JOIN tip_opreme"
                . " ON tip_opreme = id_tip_opreme LEFT JOIN tip_vozila ON tip_vozila = id_tip_vozila";
    }
    
    //za članove koji nisu korisnici (registracija)
    elseif($table == "NonUsers") {
        $query = "SELECT oib as OIB, CONCAT(ime, ' ', prezime) as Osoba FROM vatrogasci WHERE korisnicko_ime = 'null'";
    }
    
    //tablica dobavljača
    elseif($table == "Dobavljači") {
        $query = "SELECT id_dobavljaci as 'Redni broj', naziv as 'Naziv', adresa as 'Adresa', kontakt as 'Kontakt broj',"
                . " email as 'E-mail' FROM dobavljaci";
    }
    
    //tablica narudzbi
    elseif($table == "Narudžbe") {
        $query = "SELECT id_narudzbe as 'Narudžbenica', datum_izrade as 'Datum izrade', rok_isporuke as 'Rok isporuke',"
                . " nacin_isporuke as 'Način isporuke', naziv as 'Dobavljač', CONCAT(ime, ' ', prezime) as 'Izradio', storno as 'Stornirano' FROM"
                . " vatrogasci JOIN narudzbe on id_vatrogasci = izradio JOIN dobavljaci ON dobavljac = id_dobavljaci";
    }
    
    //tablica natjecatelja na natjecanju xy
    elseif($table == "Competitors") {
        $natjecanje = $_GET['natjecanje'];
        $query = "SELECT DISTINCT oib as OIB, CONCAT(ime, ' ', prezime) as Osoba FROM vatrogasci LEFT JOIN trenira ON id_vatrogasci"
                . " = vatrogasac WHERE id_vatrogasci NOT IN (SELECT vatrogasac FROM trenira JOIN ekipe ON ekipa = id_ekipe"
                . " WHERE natjecanje = '$natjecanje')";
    }
    
    //tablica ekipa na natjecanju xy
    elseif($table == "Ekipe") {
        $natjecanje = $_GET['natjecanje'];
        $query =  "SELECT id_ekipe as 'ID', ekipe.naziv as 'Naziv', kategorije.naziv as 'Kategorija', natjecanja.naziv as"
                . " 'Natjecanje', rezultat as 'Rezultat', ocjena as 'Ocjena' FROM ekipe JOIN kategorije ON id_kategorije"
                . " = kategorija JOIN natjecanja ON id_natjecanja = natjecanje WHERE id_natjecanja = '$natjecanje'";
    }
    
    //tablica članova ekipe
    elseif($table == "ČlanoviEkipe") {
        $ekipa = $_GET['ekipa'];
        $query = "SELECT oib as OIB, ime as Ime, prezime as Prezime FROM vatrogasci JOIN trenira ON id_vatrogasci"
                . " = vatrogasac WHERE ekipa = '$ekipa'";
    }
    
    //prisutni vatrogasci na intervenciji xy
    elseif ($table == "Prisutni") {
        $prijavljeni = $_GET['intervencija'];
        $query = "SELECT v.oib as OIB, v.ime as Ime, v.prezime as Prezime FROM vatrogasci as v JOIN prisutni"
                . " ON id_vatrogasci = vatrogasac WHERE intervencija = '$prijavljeni'";
    }
    
    //stavke narudžbe xy
    elseif($table == "StavkeNarudžbe") {
        $narudzba = $_GET['narudzba'];
        $query = "SELECT oprema.naziv, stavke_narudzbe.kolicina, cijena, jedinicna_mjera FROM stavke_narudzbe"
                . " JOIN oprema ON oprema = id_oprema WHERE narudzba = '$narudzba'";
    }
    
    //prosječna ocjena po vatrogascu izračunata sa natjecanja
    elseif($table == "ProsječnaOcjena") {
        $query = "SELECT CONCAT(ime, ' ', prezime) as 'Vatrogasac', AVG(ocjena) as 'Prosječna ocjena' FROM"
                . " trenira LEFT JOIN vatrogasci ON vatrogasac = id_vatrogasci LEFT JOIN ekipe ON ekipa ="
                . " id_ekipe LEFT JOIN natjecanja ON natjecanje = id_natjecanja WHERE ocjena != 0 GROUP BY 1";
    }
    
    //variranje rezultata za pojedinu osobu
    elseif($table == "Rezultati") {
        $ime = $_GET['ime'];
        $prezime = $_GET['prezime'];
        $query = "SELECT CONCAT(ime, ' ', prezime) as Osoba, rezultat as Rezultat, natjecanja.naziv as Natjecanje"
                . "  FROM trenira LEFT JOIN vatrogasci ON vatrogasac = id_vatrogasci LEFT JOIN ekipe ON ekipa ="
                . "  id_ekipe LEFT JOIN natjecanja ON natjecanje = id_natjecanja WHERE rezultat != 0 AND ime ="
                . " '$ime' AND prezime = '$prezime'";
    }
    
    //intervencije prema mjesecu
    elseif($table == "MjesecIntervencija") {
        $query = "SELECT MONTH(pocetno_vrijeme), COUNT(*) FROM intervencije GROUP BY 1";
    }
    
    //potrošnja prema mjesecu
    elseif($table == "MjesecPotrošnje") {
        $query = "SELECT MONTH(datum_izrade), SUM(kolicina*cijena) FROM stavke_narudzbe JOIN narudzbe ON"
                . " id_narudzbe = narudzba GROUP BY 1";
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