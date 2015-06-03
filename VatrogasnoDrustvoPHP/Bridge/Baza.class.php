<?php
/**
 * Klasa za spajanje na bazu i dohvat/obradu podataka
 *
 * @author Tomislav Turek
 */
class Baza {
    private $mysqli;
    
    function __construct() {
        $this->mysqli = new mysqli();
    }
    
    private function connect() {
        $this->mysqli->connect(HOST, USER, PASSWORD, DATABASE);
        $this->mysqli->set_charset('utf-8');
    }
    
    /**
     * Metoda za upite tipa SELECT
     * @param type upit
     * @return type podaci u JSON formatu
     */
    function selectDB($query) {
        $this->connect();
        $result = $this->mysqli->query($query);
        $this->mysqli->close();
        return json_encode($result);
    }
    
    /**
     * Metoda za upite ostalih tipa (non select)
     * @param type $query upit
     * @return type uspjeh u izvršavanju
     */
    function queryDB($query) {
        $this->connect();
        if($this->mysqli->query($query)) {
            $this->mysqli->close();
            return true;
        } else {
            $this->mysqli->close();
            return false;
        }
    }
}