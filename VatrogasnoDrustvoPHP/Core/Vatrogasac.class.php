<?php

/**
 * Domenska klasa vatrogasca
 *
 * @author Tomo
 */
class Vatrogasac {
    public $ime, $prezime, $oib, $adresa, 
            $datum_rodjenja, $datum_uclanjenja, 
            $vrsta_clana, $zvanje;
    
    function __construct($dbPassword) {
        $this->adresa = $dbPassword['adresa'];
        $this->datum_rodjenja = $dbPassword['datum_rodjenja'];
        $this->datum_uclanjenja = $dbPassword['datum_uclanjenja'];
        $this->ime = $dbPassword['ime'];
        $this->prezime = $dbPassword['prezime'];
        $this->oib = $dbPassword['oib'];
        $this->vrsta_clana = $dbPassword['vrsta_clana'];
        $this->zvanje = $dbPassword['zvanje'];
    }
    
    function getIme() {
        return $this->ime;
    }

    function getPrezime() {
        return $this->prezime;
    }

    function getOib() {
        return $this->oib;
    }

    function getAdresa() {
        return $this->adresa;
    }

    function getDatum_rodjenja() {
        return $this->datum_rodjenja;
    }

    function getDatum_uclanjenja() {
        return $this->datum_uclanjenja;
    }

    function getVrsta_clana() {
        return $this->vrsta_clana;
    }

    function getZvanje() {
        return $this->zvanje;
    }

    function setIme($ime) {
        $this->ime = $ime;
    }

    function setPrezime($prezime) {
        $this->prezime = $prezime;
    }

    function setOib($oib) {
        $this->oib = $oib;
    }

    function setAdresa($adresa) {
        $this->adresa = $adresa;
    }

    function setDatum_rodjenja($datum_rodjenja) {
        $this->datum_rodjenja = $datum_rodjenja;
    }

    function setDatum_uclanjenja($datum_uclanjenja) {
        $this->datum_uclanjenja = $datum_uclanjenja;
    }

    function setVrsta_clana($vrsta_clana) {
        $this->vrsta_clana = $vrsta_clana;
    }

    function setZvanje($zvanje) {
        $this->zvanje = $zvanje;
    }


}
