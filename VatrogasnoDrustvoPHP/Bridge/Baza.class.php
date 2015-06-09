<?php
/**
 * Klasa za spajanje na bazu i dohvat/obradu podataka
 *
 * @author Tomislav Turek
 */
require_once 'config.php';

class Baza {
    private $mysqli;
    private $insertedID;
    
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
     * @return type podaci iz baze
     */
    function selectDB($query) {
        $this->connect();
        $result = $this->mysqli->query($query);
        $this->mysqli->close();
        return $result;
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
