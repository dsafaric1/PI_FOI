<?php

require_once 'config.php'; //database info

/**
 * Klasa za komunikaciju s bazom
 */
class DB {
    private $mysqli;
    private $insertedID;
    private $error;
    private $errstr;
    
    function __construct() {
        $this->mysqli = new mysqli();
    }
    
    function connect() {
        $this->mysqli->connect(HOST, USER, PASSWORD, DATABASE);
        $this->mysqli->set_charset('utf8');
    }
    
    public function execute($query) {
        $this->connect();
        $result = $this->mysqli->query($query);
        $this->insertedID = $this->mysqli->insert_id;
        $this->error = $this->mysqli->errno;
        $this->errstr = $this->mysqli->error;
        $this->disconnect();
        return $result;
    }
    
    public function getInsertedID() {
        return $this->insertedID;
    }
    
    public function hasFailed() {
        return $this->error;
    }
    
    public function getError() {
        return $this->errstr;
    }
    
    function disconnect() {
        $this->mysqli->close();
    }
}