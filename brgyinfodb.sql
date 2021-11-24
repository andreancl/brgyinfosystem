-- MySQL dump 10.13  Distrib 8.0.25, for Win64 (x86_64)
--
-- Host: localhost    Database: brgyinfodb
-- ------------------------------------------------------
-- Server version	5.7.35-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `residents`
--

DROP TABLE IF EXISTS `residents`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `residents` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ResidentId` varchar(50) NOT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `Suffix` varchar(45) DEFAULT NULL,
  `Sex` varchar(45) DEFAULT NULL,
  `Birthdate` date DEFAULT NULL,
  `Birthplace` varchar(45) DEFAULT NULL,
  `CivilStatus` varchar(45) DEFAULT NULL,
  `Religion` varchar(45) DEFAULT NULL,
  `Nationality` varchar(45) DEFAULT NULL,
  `ContactNo` bigint(20) DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  PRIMARY KEY (`ResidentId`),
  UNIQUE KEY `ID_UNIQUE` (`Id`),
  UNIQUE KEY `RESIDENT_ID_UNIQUE` (`ResidentId`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `residents`
--

LOCK TABLES `residents` WRITE;
/*!40000 ALTER TABLE `residents` DISABLE KEYS */;
/*!40000 ALTER TABLE `residents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_details`
--

DROP TABLE IF EXISTS `service_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service_details` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `ServiceId` int(11) NOT NULL,
  `ComplaineeName` varchar(45) NOT NULL,
  `DefendantName` varchar(45) NOT NULL,
  `Incident` varchar(45) NOT NULL,
  `IncidentDate` date NOT NULL,
  `IncidentTime` time NOT NULL,
  `Statement` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  `ResidentID` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ServiceDetailIsD_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_details`
--

LOCK TABLES `service_details` WRITE;
/*!40000 ALTER TABLE `service_details` DISABLE KEYS */;
INSERT INTO `service_details` VALUES (1,2,'Bernard gRESOLA','Rafael','safdsafasd','2021-10-20','08:00:00','blah blah','2021-10-21 22:07:59','2021-10-21 22:07:59',NULL,'2'),(2,3,'Bernard gRESOLA','Rafael','safdsafasd','2021-10-20','08:00:00','blah blah','2021-10-21 22:07:59','2021-10-21 22:07:59',NULL,'2'),(3,1,'juna dla cruz','Rafael','safdsafasd','2021-10-20','08:00:00','blah blah','2021-10-21 22:07:59','2021-10-21 22:07:59',NULL,NULL);
/*!40000 ALTER TABLE `service_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_types`
--

DROP TABLE IF EXISTS `service_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service_types` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_types`
--

LOCK TABLES `service_types` WRITE;
/*!40000 ALTER TABLE `service_types` DISABLE KEYS */;
INSERT INTO `service_types` VALUES (1,'Blotter','2021-10-21 21:44:03','2021-10-21 21:44:03'),(2,'Business Permit','2021-10-21 21:44:03','2021-10-21 21:44:03'),(3,'Barangay Clearance','2021-10-21 21:44:03','2021-10-21 21:44:03'),(4,'Ayuda','2021-10-21 21:44:03','2021-10-21 21:44:03');
/*!40000 ALTER TABLE `service_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` int(11) NOT NULL,
  `ServiceTypeId` varchar(45) NOT NULL,
  `ResidentID` int(11) DEFAULT NULL,
  `ChairmanID` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `ServiceID_UNIQUE` (`Id`),
  KEY `ResidentID_idx` (`ResidentID`),
  KEY `UsersID_idx` (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `services`
--

LOCK TABLES `services` WRITE;
/*!40000 ALTER TABLE `services` DISABLE KEYS */;
INSERT INTO `services` VALUES (1,102,'3',1,'101','2021-10-21 21:49:12','2021-10-21 21:49:12',NULL),(2,102,'1',2,'101','2021-10-21 22:05:43','2021-10-21 22:05:43',NULL),(3,102,'1',2,'101','2021-10-21 22:05:43','2021-10-21 22:05:43',NULL),(4,102,'1',NULL,'101','2021-10-21 22:05:43','2021-10-21 22:05:43',NULL);
/*!40000 ALTER TABLE `services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user_types`
--

DROP TABLE IF EXISTS `user_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user_types` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserTypeID_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user_types`
--

LOCK TABLES `user_types` WRITE;
/*!40000 ALTER TABLE `user_types` DISABLE KEYS */;
INSERT INTO `user_types` VALUES (1,'Admin','2021-10-18 00:50:35','2021-10-18 00:50:35',NULL),(2,'Standard User','2021-10-21 21:37:41','2021-10-21 21:37:41',NULL);
/*!40000 ALTER TABLE `user_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserId` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `Suffix` varchar(45) DEFAULT NULL,
  `Sex` varchar(45) NOT NULL,
  `Birthdate` date NOT NULL,
  `Address` varchar(45) NOT NULL,
  `ContactNumber` bigint(20) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Position` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  `UserTypeId` int(11) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserID_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=103 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (101,'12345','','Chairman',NULL,NULL,'Female','2000-01-06','Caloocan City',9950573917,'admin','0000','Chairman',NULL,NULL,NULL,1),(102,'67890','Secretary','Secretary',NULL,NULL,'Female','2000-01-06','Caloocan City',9950573917,'secretary','12345','Secretary','2021-10-21 21:39:01','2021-10-21 21:39:01',NULL,2);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-24 14:57:44
