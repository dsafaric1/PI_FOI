-- MySQL dump 10.13  Distrib 5.5.43, for debian-linux-gnu (x86_64)
--
-- Host: localhost    Database: vatrogasci
-- ------------------------------------------------------
-- Server version	5.5.43-0ubuntu0.14.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `dobavljaci`
--

DROP TABLE IF EXISTS `dobavljaci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dobavljaci` (
  `id_dobavljaci` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `adresa` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `kontakt` varchar(20) COLLATE utf8_unicode_ci NOT NULL,
  `email` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_dobavljaci`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dobavljaci`
--

LOCK TABLES `dobavljaci` WRITE;
/*!40000 ALTER TABLE `dobavljaci` DISABLE KEYS */;
INSERT INTO `dobavljaci` VALUES (1,'Vatropromet','Zagrebačka 12, Zagreb','00385995551258','kontakt@vatropromet.hr'),(2,'Sigurnost','Čakovečka 4, Knezovec','00385991231258','kontakt@sigurnost.hr'),(3,'Novi dobavljač','Nova adresa 33','00385993213211','dsafaric@foi.hr'),(6,'Brodovi d.o.o.','Adresa brodova 96','00385997852010','kontakt@brodovi.hr'),(8,'Trigger d.o.o.','Triggerova 456, Zagreb','00385998927891','kontakt@trigger.hr'),(9,'bordo d.d.','Bordova b.b., Zagreb','','kontakt@bordo.hr');
/*!40000 ALTER TABLE `dobavljaci` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `duznosti`
--

DROP TABLE IF EXISTS `duznosti`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `duznosti` (
  `id_duznosti` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `opis` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  `vatrogasac` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_duznosti`),
  UNIQUE KEY `vatrogasac` (`vatrogasac`),
  KEY `fk_duznosti_vatrogasci1_idx` (`vatrogasac`),
  CONSTRAINT `fk_duznosti_vatrogasci1` FOREIGN KEY (`vatrogasac`) REFERENCES `vatrogasci` (`id_vatrogasci`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `duznosti`
--

LOCK TABLES `duznosti` WRITE;
/*!40000 ALTER TABLE `duznosti` DISABLE KEYS */;
INSERT INTO `duznosti` VALUES (1,'Predsjednik','Glavna osoba u društvu, predstavnik kod drugih društava',1),(2,'Zapovjednik','Odgovoran za intervencije, odgovoran za spremnost operativnih ekipa, najviši u lancu zapovjedanja',7),(3,'Tajnik','Obavlja administativne poslove, vodi evidenciju članova',3),(4,'ZamjenikPredsjednika','Zamjenik predsjednika',30),(6,'ZamjenikZapovjednika','Zapovjeda intervenciju ako nema zapovjednika na mjestu intervencije',6),(7,'Blagajnik','Blagajnik društva',2),(8,'Spremistar','Glavni na spremistu',35);
/*!40000 ALTER TABLE `duznosti` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ekipe`
--

DROP TABLE IF EXISTS `ekipe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `ekipe` (
  `id_ekipe` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `kategorija` int(11) NOT NULL,
  `natjecanje` int(11) NOT NULL,
  `rezultat` decimal(10,0) DEFAULT NULL,
  `ocjena` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_ekipe`),
  UNIQUE KEY `naziv` (`naziv`),
  KEY `fk_ekipe_vrste_ekipa1_idx` (`kategorija`),
  KEY `fk_ekipe_natjecanja1_idx` (`natjecanje`),
  CONSTRAINT `fk_ekipe_natjecanja1` FOREIGN KEY (`natjecanje`) REFERENCES `natjecanja` (`id_natjecanja`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ekipe_vrste_ekipa1` FOREIGN KEY (`kategorija`) REFERENCES `kategorije` (`id_kategorije`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ekipe`
--

LOCK TABLES `ekipe` WRITE;
/*!40000 ALTER TABLE `ekipe` DISABLE KEYS */;
INSERT INTO `ekipe` VALUES (1,'Moži',3,1,91,5),(24,'VD majstorzzz',3,21,88,4),(25,'L00z3rz',2,20,45,2),(26,'Tim ALFA',2,21,99,5),(27,'TIM NAICHIA',3,20,73,3),(40,'Rasbiachi',4,43,45,2),(41,'Numero unos',2,43,85,5),(42,'Kala team',3,43,67,3);
/*!40000 ALTER TABLE `ekipe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `intervencije`
--

DROP TABLE IF EXISTS `intervencije`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `intervencije` (
  `broj_dojavnice` int(11) NOT NULL AUTO_INCREMENT,
  `mjesto` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `adresa` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `pocetno_vrijeme` datetime NOT NULL,
  `zavrsno_vrijeme` datetime NOT NULL,
  `opis` longtext COLLATE utf8_unicode_ci NOT NULL,
  `uzrok` varchar(80) COLLATE utf8_unicode_ci NOT NULL,
  `vrsta_intervencije` int(11) NOT NULL,
  PRIMARY KEY (`broj_dojavnice`,`vrsta_intervencije`),
  KEY `fk_intervencije_vrste_intervencija1_idx` (`vrsta_intervencije`),
  CONSTRAINT `fk_intervencije_vrste_intervencija1` FOREIGN KEY (`vrsta_intervencije`) REFERENCES `vrste_intervencija` (`id_vrste_intervencija`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=26 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `intervencije`
--

LOCK TABLES `intervencije` WRITE;
/*!40000 ALTER TABLE `intervencije` DISABLE KEYS */;
INSERT INTO `intervencije` VALUES (1,'Varaždin','Optujska bb','2015-04-20 06:30:00','2015-04-20 06:55:00','Požar otvorenog skladišta','Greška kod motora viličara',1),(2,'Čakovec','Zagrebačka 33','2015-05-11 03:30:00','2015-05-11 05:52:00','Sudar osobnih automobila, upotreba hidrauličkih škara','prebrza voznja',2),(17,'Gornji Hrašćan','Čakovečka 33','2015-06-03 10:27:38','2015-06-03 11:35:38','Eksplozija plinske boce uzrokovala požar na tavanu obiteljske kuće u Gornjem Hrašćanu.','Plinska boca',1),(19,'Zagreb','Varaždinska 44','2015-06-02 05:07:11','2015-06-02 10:07:11','Izbava osobe iz bunara','Zaglavjena osoba',3),(22,'Varaždin','Dravska šuma b.b.','2015-03-09 09:57:35','2015-03-09 11:07:35','Otišli na roštilj pa zapalili šumu.','Roštilj',1),(25,'Varaždin','Stari grad 99','2015-03-17 02:07:25','2015-06-21 05:07:25','Vatromet iz obližnje kuće uzrokovao požar na kućici u dvorištu, materijalna šteta velika.','Vatromet',1);
/*!40000 ALTER TABLE `intervencije` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `kategorije`
--

DROP TABLE IF EXISTS `kategorije`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `kategorije` (
  `id_kategorije` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `raspon_godina` varchar(10) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_kategorije`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `kategorije`
--

LOCK TABLES `kategorije` WRITE;
/*!40000 ALTER TABLE `kategorije` DISABLE KEYS */;
INSERT INTO `kategorije` VALUES (1,'Podmladak','6-12'),(2,'Mladez','12-16'),(3,'SenioriA','+16'),(4,'SenioriB','+30');
/*!40000 ALTER TABLE `kategorije` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `narudzbe`
--

DROP TABLE IF EXISTS `narudzbe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `narudzbe` (
  `id_narudzbe` int(11) NOT NULL AUTO_INCREMENT,
  `rok_isporuke` date NOT NULL,
  `nacin_isporuke` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `datum_izrade` date NOT NULL,
  `dobavljac` int(11) DEFAULT NULL,
  `izradio` int(11) DEFAULT NULL,
  `storno` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`id_narudzbe`),
  KEY `fk_narudzbe_dobavljaci1_idx` (`dobavljac`),
  KEY `fk_narudzbe_vatrogasci1_idx` (`izradio`),
  CONSTRAINT `fk_narudzbe_dobavljaci1` FOREIGN KEY (`dobavljac`) REFERENCES `dobavljaci` (`id_dobavljaci`) ON DELETE SET NULL ON UPDATE CASCADE,
  CONSTRAINT `fk_narudzbe_vatrogasci1` FOREIGN KEY (`izradio`) REFERENCES `vatrogasci` (`id_vatrogasci`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=46 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `narudzbe`
--

LOCK TABLES `narudzbe` WRITE;
/*!40000 ALTER TABLE `narudzbe` DISABLE KEYS */;
INSERT INTO `narudzbe` VALUES (1,'2015-06-27','Pošta','2014-10-02',1,1,0),(3,'2015-06-06','Pošta','2014-10-02',1,1,1),(18,'2015-06-12','Vozilo','2015-06-12',3,3,0),(21,'2015-06-24','Helikopter','2015-06-13',3,3,0),(22,'2015-06-24','Helikopter','2015-06-13',3,3,1),(23,'2015-06-13','Vlastiti prijevoz','2015-06-13',2,3,0),(24,'2015-06-18','Brod','2015-06-13',6,3,0),(25,'2015-06-13','Vlastiti prijevoz','2015-06-13',1,3,0),(26,'2015-06-13','Vlastiti prijevoz','2015-06-13',1,3,1),(27,'2015-06-13','nekak','2015-06-13',1,3,1),(28,'2015-06-13','dddd','2015-06-13',1,3,0),(29,'2015-06-13','ddddd','2015-06-13',1,3,1),(30,'2015-06-14','Poštar','2015-06-14',8,3,1),(31,'2015-06-14','Poštar','2015-06-14',1,3,1),(33,'2015-06-14','Vozilo','2015-06-14',1,3,0),(34,'2015-06-15','Brodom','2015-06-15',2,3,1),(35,'2015-06-16','Vozilo','2015-06-16',1,3,0),(36,'2015-06-16','Traktor','2015-06-16',1,3,0),(37,'2015-06-19','Vlastiti prijevoz','2015-06-19',9,3,1),(38,'2015-05-20','Poštar','2015-02-22',1,3,0),(39,'2015-05-20','Poštar','2015-03-22',1,3,0),(40,'2015-05-20','Poštar','2014-12-22',1,3,0),(41,'2015-05-20','Vlastiti prijevoz','2015-01-10',3,3,0),(42,'2015-05-20','Vlastiti prijevoz','2015-04-16',3,3,0),(43,'2015-05-20','Vlastiti prijevoz','2015-05-24',3,3,0),(44,'2015-06-20','Poštar','2015-06-20',8,3,0),(45,'2015-06-21','Vozilo','2015-06-21',3,3,0);
/*!40000 ALTER TABLE `narudzbe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `natjecanja`
--

DROP TABLE IF EXISTS `natjecanja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `natjecanja` (
  `id_natjecanja` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(150) COLLATE utf8_unicode_ci NOT NULL,
  `mjesto` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `vrijeme_odrzavanja` datetime NOT NULL,
  `kotizacija` int(11) NOT NULL,
  `tip_natjecanja` int(11) NOT NULL,
  `kreirao_vatrogasac` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_natjecanja`),
  KEY `fk_natjecanja_tip_natjecanja1_idx` (`tip_natjecanja`),
  KEY `fk_natjecanja_vatrogasci1_idx` (`kreirao_vatrogasac`),
  CONSTRAINT `fk_natjecanja_tip_natjecanja1` FOREIGN KEY (`tip_natjecanja`) REFERENCES `tip_natjecanja` (`id_tip_natjecanja`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_natjecanja_vatrogasci1` FOREIGN KEY (`kreirao_vatrogasac`) REFERENCES `vatrogasci` (`id_vatrogasci`) ON DELETE SET NULL ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=44 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `natjecanja`
--

LOCK TABLES `natjecanja` WRITE;
/*!40000 ALTER TABLE `natjecanja` DISABLE KEYS */;
INSERT INTO `natjecanja` VALUES (1,'Županijsko za mladež u Zagrebu','Zagreb','2015-06-15 14:30:00',10,1,1),(20,'Memorijal Zagreb 2015','Zagreb','2015-06-13 11:00:00',100,4,3),(21,'Gradsko 2015','Zagreb','2015-06-20 12:00:00',100,3,3),(43,'Jubilarno natjecanje VŽ','Varaždin','2015-06-24 14:00:00',100,1,3);
/*!40000 ALTER TABLE `natjecanja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `oprema`
--

DROP TABLE IF EXISTS `oprema`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `oprema` (
  `id_oprema` int(11) NOT NULL AUTO_INCREMENT,
  `tip_opreme` int(11) NOT NULL,
  `naziv` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `kolicina` int(11) NOT NULL,
  `godiste` int(11) DEFAULT NULL,
  `broj_sjedala` int(11) DEFAULT NULL,
  `zapremnina_vode` int(11) DEFAULT NULL,
  `max_protok` int(11) DEFAULT NULL,
  `max_visina_pumpanja` decimal(10,0) DEFAULT NULL,
  `jacina` int(11) DEFAULT NULL,
  `tezina` decimal(10,0) DEFAULT NULL,
  `tip_vozila` int(11) DEFAULT NULL,
  PRIMARY KEY (`id_oprema`),
  KEY `fk_oprema_tip_vozila1_idx` (`tip_vozila`),
  KEY `fk_oprema_tip_opreme1_idx` (`tip_opreme`),
  CONSTRAINT `fk_oprema_tip_opreme1` FOREIGN KEY (`tip_opreme`) REFERENCES `tip_opreme` (`id_tip_opreme`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_oprema_tip_vozila1` FOREIGN KEY (`tip_vozila`) REFERENCES `tip_vozila` (`id_tip_vozila`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `oprema`
--

LOCK TABLES `oprema` WRITE;
/*!40000 ALTER TABLE `oprema` DISABLE KEYS */;
INSERT INTO `oprema` VALUES (2,11,'Navalno vozilo Rosenbauer',23,2007,3,2000,NULL,NULL,350,12000,1),(6,10,'Pumpa Honda X23',74,2014,NULL,NULL,1500,10,25,35,NULL),(9,14,'Zaštitna odora',56,2012,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(14,14,'Boca 10L prah',30,2014,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(15,10,'Pumpa MAX XL ZERO',10,2013,NULL,NULL,60,20,20,35,NULL),(16,11,'Toyota Jeep 4WL',3,2012,10,0,NULL,NULL,15,544,4),(17,11,'Toyota RAV4',2,2008,6,0,NULL,NULL,500,12000,6),(18,14,'Kaciga',19,2011,NULL,NULL,NULL,NULL,NULL,NULL,NULL),(23,10,'PUMPA SLR2000 10X2R',4,2011,NULL,NULL,20,30,90,95,NULL);
/*!40000 ALTER TABLE `oprema` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `prisutni`
--

DROP TABLE IF EXISTS `prisutni`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `prisutni` (
  `vatrogasac` int(11) NOT NULL,
  `intervencija` int(11) NOT NULL,
  PRIMARY KEY (`intervencija`,`vatrogasac`),
  KEY `fk_vatrogasci_has_intervencije_intervencije1_idx` (`intervencija`),
  KEY `fk_vatrogasci_has_intervencije_vatrogasci1_idx` (`vatrogasac`),
  CONSTRAINT `fk_vatrogasci_has_intervencije_intervencije1` FOREIGN KEY (`intervencija`) REFERENCES `intervencije` (`broj_dojavnice`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_vatrogasci_has_intervencije_vatrogasci1` FOREIGN KEY (`vatrogasac`) REFERENCES `vatrogasci` (`id_vatrogasci`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `prisutni`
--

LOCK TABLES `prisutni` WRITE;
/*!40000 ALTER TABLE `prisutni` DISABLE KEYS */;
INSERT INTO `prisutni` VALUES (1,1),(2,1),(6,1),(25,1),(1,17),(3,17),(6,17),(25,17),(2,19),(7,19),(2,22),(3,22),(7,22),(25,22),(33,22),(1,25),(2,25),(6,25),(7,25);
/*!40000 ALTER TABLE `prisutni` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `stavke_narudzbe`
--

DROP TABLE IF EXISTS `stavke_narudzbe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `stavke_narudzbe` (
  `narudzba` int(11) NOT NULL,
  `oprema` int(11) NOT NULL,
  `kolicina` int(11) NOT NULL,
  `cijena` decimal(15,2) NOT NULL,
  `jedinicna_mjera` varchar(10) NOT NULL,
  PRIMARY KEY (`narudzba`,`oprema`),
  KEY `fk_narudzbe_has_oprema_oprema1_idx` (`oprema`),
  KEY `fk_narudzbe_has_oprema_narudzbe1_idx` (`narudzba`),
  CONSTRAINT `fk_narudzbe_has_oprema_narudzbe1` FOREIGN KEY (`narudzba`) REFERENCES `narudzbe` (`id_narudzbe`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_narudzbe_has_oprema_oprema1` FOREIGN KEY (`oprema`) REFERENCES `oprema` (`id_oprema`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stavke_narudzbe`
--

LOCK TABLES `stavke_narudzbe` WRITE;
/*!40000 ALTER TABLE `stavke_narudzbe` DISABLE KEYS */;
INSERT INTO `stavke_narudzbe` VALUES (1,18,4,150.00,'komad'),(18,6,10,100.00,'komad'),(21,2,10,5434.00,'komad'),(21,6,20,123.00,'komad'),(21,9,10,20000.00,'komad'),(23,2,1,3723.00,'komad'),(23,6,2,20123.00,'komad'),(23,9,10,5633.00,'komad'),(24,2,10,100.00,'komad'),(24,6,20,2.00,'komad'),(24,9,30,3.00,'komad'),(25,6,20,1500.00,'komad'),(25,9,5,4532.00,'komad'),(25,14,3,2341.00,'komad'),(25,15,2,6432.00,'komad'),(28,15,3,1500.00,'komad'),(33,14,2,100.00,'komad'),(33,15,3,1000.00,'komad'),(33,18,3,500.00,'komad'),(34,9,1,16.00,'komad'),(34,14,15,50.00,'komad'),(35,2,2,2.00,'komad'),(35,6,2,2.00,'komad'),(35,16,1,1.00,'komad'),(35,18,3,1.00,'komad'),(36,14,10,100.00,'komad'),(36,16,1,1000.00,'komad'),(36,17,1,1000.00,'komad'),(38,16,1,100.00,'komad'),(38,17,2,200.00,'komad'),(39,14,2,3301.00,'komad'),(40,9,5,21312.00,'komad'),(41,9,6,2453.00,'komad'),(41,14,3,654.00,'komad'),(42,14,2,2253.00,'komad'),(42,17,1,5653.00,'komad'),(43,2,15,7757.00,'komad'),(43,16,4,757.00,'komad'),(44,15,2,545.00,'komad'),(45,18,10,100.00,'komad'),(45,23,2,1344.00,'komad');
/*!40000 ALTER TABLE `stavke_narudzbe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tip_natjecanja`
--

DROP TABLE IF EXISTS `tip_natjecanja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tip_natjecanja` (
  `id_tip_natjecanja` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_tip_natjecanja`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tip_natjecanja`
--

LOCK TABLES `tip_natjecanja` WRITE;
/*!40000 ALTER TABLE `tip_natjecanja` DISABLE KEYS */;
INSERT INTO `tip_natjecanja` VALUES (1,'Zupanijsko'),(2,'Opcinsko'),(3,'Gradsko'),(4,'Memorijal'),(5,'SpajanjeUsisnogVoda');
/*!40000 ALTER TABLE `tip_natjecanja` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tip_opreme`
--

DROP TABLE IF EXISTS `tip_opreme`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tip_opreme` (
  `id_tip_opreme` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_tip_opreme`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tip_opreme`
--

LOCK TABLES `tip_opreme` WRITE;
/*!40000 ALTER TABLE `tip_opreme` DISABLE KEYS */;
INSERT INTO `tip_opreme` VALUES (10,'Pumpa'),(11,'Vozilo'),(14,'Oprema');
/*!40000 ALTER TABLE `tip_opreme` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tip_vozila`
--

DROP TABLE IF EXISTS `tip_vozila`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tip_vozila` (
  `id_tip_vozila` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `opis` varchar(300) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_tip_vozila`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tip_vozila`
--

LOCK TABLES `tip_vozila` WRITE;
/*!40000 ALTER TABLE `tip_vozila` DISABLE KEYS */;
INSERT INTO `tip_vozila` VALUES (1,'Navalno','Navalno vozilo prvo izlazi na intervenciju jer je opremljeno opremom za gašenje svih vrsta požara. U pravilu sadrži: veliki spremnik vode te manje količine pjenila, vode, praha, CO2, odgovarajuću pumpu za vodu, razni alat, IC kameru, eksploziometar, aparate za zaštitu dišnih organa, manje ljestve a '),(2,'Tehnicko','Vatrogasno vozilo opremljeno opremom za tzv. tehničke intervencije kao što su prometne nezgode, elementarne nepogode ili druge vrste spašavanja'),(3,'Autocisterna','Služi za prijevoz vode i ljudi do mjesta intervencije. Obično se nalazi zadnja u Gasnom vlaku jer \"puni\" automobilsku ljestvu ili navalno vozilo vodom. Sadrži veću količinu vode te manju količinu pjenila i alata. Može služiti i za samostalno gašenje požara ako se radi o manjim požarima'),(4,'Specijalno','Vozilo koje može sadržavate razne količine vode, pjenila, praha CO2 te služi za razne intervencije kao požare zapaljivih tekućina'),(5,'Autoljestve','Vatrogasna ljestva je vatrogasno vozilo za spašavanje s visina. Osnovna namjena ljestava je spašavanje ljudi, gašenje požara i vršenje dodatnih tehničkih usluga. Ona je simbol vatrogasaca diljem svijeta i najprepoznatljivi dio ukupne vatrogasne opreme'),(6,'Zapovjedno','Zapovjedno vozilo je prvo vozilo u vatrogasnom vlaku. Prvo dolazi na intervenciju. U njemu se vozi zapovjednik'),(7,'Platforma','Vozilo za spašavanje iz visina i dubina. Razlika od Autoljestve je da ima veću košaru i nema ljestve do košare');
/*!40000 ALTER TABLE `tip_vozila` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trenira`
--

DROP TABLE IF EXISTS `trenira`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trenira` (
  `vatrogasac` int(11) NOT NULL,
  `ekipa` int(11) NOT NULL,
  PRIMARY KEY (`vatrogasac`,`ekipa`),
  KEY `fk_ekipe_has_vatrogasci_vatrogasci1_idx` (`vatrogasac`),
  KEY `fk_ekipe_has_vatrogasci_ekipe1_idx` (`ekipa`),
  CONSTRAINT `fk_ekipe_has_vatrogasci_ekipe1` FOREIGN KEY (`ekipa`) REFERENCES `ekipe` (`id_ekipe`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_ekipe_has_vatrogasci_vatrogasci1` FOREIGN KEY (`vatrogasac`) REFERENCES `vatrogasci` (`id_vatrogasci`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trenira`
--

LOCK TABLES `trenira` WRITE;
/*!40000 ALTER TABLE `trenira` DISABLE KEYS */;
INSERT INTO `trenira` VALUES (1,1),(1,26),(1,27),(1,42),(2,1),(2,24),(2,25),(2,41),(3,1),(3,24),(3,25),(3,40),(6,25),(6,26),(6,42),(7,24),(7,27),(7,42),(25,24),(25,40),(30,26),(30,27),(30,40),(33,40),(35,41);
/*!40000 ALTER TABLE `trenira` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vatrogasci`
--

DROP TABLE IF EXISTS `vatrogasci`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vatrogasci` (
  `id_vatrogasci` int(11) NOT NULL AUTO_INCREMENT,
  `ime` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `prezime` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `oib` varchar(11) COLLATE utf8_unicode_ci NOT NULL,
  `korisnicko_ime` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `lozinka` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `adresa` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `datum_rodjenja` date NOT NULL,
  `datum_uclanjenja` date NOT NULL,
  `vrsta_clana` int(11) NOT NULL,
  `zvanje` int(11) NOT NULL,
  PRIMARY KEY (`id_vatrogasci`),
  UNIQUE KEY `oib` (`oib`),
  KEY `fk_vatrogasci_vrste_clanova_idx` (`vrsta_clana`),
  KEY `fk_vatrogasci_zvanja1_idx` (`zvanje`),
  CONSTRAINT `fk_vatrogasci_vrste_clanova` FOREIGN KEY (`vrsta_clana`) REFERENCES `vrste_clanova` (`id_vrsta_clana`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_vatrogasci_zvanja1` FOREIGN KEY (`zvanje`) REFERENCES `zvanja` (`id_zvanja`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vatrogasci`
--

LOCK TABLES `vatrogasci` WRITE;
/*!40000 ALTER TABLE `vatrogasci` DISABLE KEYS */;
INSERT INTO `vatrogasci` VALUES (1,'Tomislav','Turek','01234567891','tturek','pass1234','adresa123','1994-02-11','2010-02-10',1,1),(2,'Denis','Šafarić','12312312312','dsafaric','lozinka123','Gornji Hrašćan','1993-06-03','2007-02-03',1,3),(3,'Maja','Vračan','12312555312','mvracan','lozinka321','Sisak','1994-05-24','2013-02-03',2,3),(6,'Suzana','Horvat','19995487312','shorvat','pass12345678','Čakovec','1977-03-04','2015-02-03',6,1),(7,'Matija','Novak','19995487777','mnovak','pass7777','Cakovec','1970-03-27','2002-09-11',6,5),(25,'Goran','Gorić','03216549879','ggoric','pass1234','Gorićeva','1989-06-14','2013-06-05',2,5),(30,'Ivo','Horvat','45645689789','null','null','Horvatova 33, Čakovec','1950-06-07','2015-06-12',7,1),(33,'Ivan','Ivanović','11111111111','null','null','Ivanovićeva 55, Čakovec','1994-02-16','2015-06-14',1,1),(35,'Marko','Markičević','67893423422','mmarki','123456','Gospodina Adresara 127','1974-06-28','2015-06-21',6,2);
/*!40000 ALTER TABLE `vatrogasci` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vrste_clanova`
--

DROP TABLE IF EXISTS `vrste_clanova`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vrste_clanova` (
  `id_vrsta_clana` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `opis` varchar(500) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_vrsta_clana`),
  UNIQUE KEY `naziv_UNIQUE` (`naziv`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vrste_clanova`
--

LOCK TABLES `vrste_clanova` WRITE;
/*!40000 ALTER TABLE `vrste_clanova` DISABLE KEYS */;
INSERT INTO `vrste_clanova` VALUES (1,'Operativni','Operativni vatrogasac'),(2,'Pricuvni','Pričuvni član je svaki član društva u dobi iznad 65 godina ili onaj član koji zbog svojih osobnih obveza, zdravstvenih i drugih razloga ne može provoditi obveze operativnog člana.'),(4,'Pomazuci','Pomažući član je fizička ili pravna osoba koja financijskom i drugom potporom odnosno aktivnošću pomaže društvo u ostvarivanju njegovih ciljeva i zadataka ili plaća članarinu koju odredi Skupština Društva na prijedlog Upravnog odbora.'),(5,'Pocasni','Počasni član je fizička ili pravna osoba koja na poseban način pridonosi ostvarivanju ciljeva i zadataka društva'),(6,'Izvrsni','Izvršni član je fizička osoba koja ima određenu dužnost u društvu ili je u upravnom odboru.'),(7,'Veteran','Ostali članovi su svi ostali članovi društva.');
/*!40000 ALTER TABLE `vrste_clanova` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vrste_intervencija`
--

DROP TABLE IF EXISTS `vrste_intervencija`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vrste_intervencija` (
  `id_vrste_intervencija` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_vrste_intervencija`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vrste_intervencija`
--

LOCK TABLES `vrste_intervencija` WRITE;
/*!40000 ALTER TABLE `vrste_intervencija` DISABLE KEYS */;
INSERT INTO `vrste_intervencija` VALUES (1,'Pozar'),(2,'Tehnicka'),(3,'Ostalo');
/*!40000 ALTER TABLE `vrste_intervencija` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `zvanja`
--

DROP TABLE IF EXISTS `zvanja`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zvanja` (
  `id_zvanja` int(11) NOT NULL AUTO_INCREMENT,
  `naziv` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`id_zvanja`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zvanja`
--

LOCK TABLES `zvanja` WRITE;
/*!40000 ALTER TABLE `zvanja` DISABLE KEYS */;
INSERT INTO `zvanja` VALUES (1,'Vatrogasac'),(2,'VatrogasacPrveKlase'),(3,'Docasnik'),(4,'DocasnikPrveKlase'),(5,'Casnik'),(6,'CasnikPrveKlase'),(7,'VisiCasnik'),(8,'VisiCasnikPrveKlase'),(9,'PocasniCasnik');
/*!40000 ALTER TABLE `zvanja` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-06-21  8:31:23
