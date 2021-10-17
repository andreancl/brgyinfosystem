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
-- Table structure for table `tbl_resident`
--

DROP TABLE IF EXISTS `tbl_resident`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_resident` (
  `ResidentID` int(11) NOT NULL AUTO_INCREMENT,
  `LastName` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `Suffix` varchar(45) DEFAULT NULL,
  `Sex` varchar(45) NOT NULL,
  `Birthdate` date NOT NULL,
  `Birthplace` varchar(45) NOT NULL,
  `CivilStatus` varchar(45) NOT NULL,
  `Religion` varchar(45) NOT NULL,
  `Nationality` varchar(45) NOT NULL,
  `ContactNo` bigint(20) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ResidentID`),
  UNIQUE KEY `ResidentID_UNIQUE` (`ResidentID`)
) ENGINE=InnoDB AUTO_INCREMENT=2100003 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_resident`
--

LOCK TABLES `tbl_resident` WRITE;
/*!40000 ALTER TABLE `tbl_resident` DISABLE KEYS */;
INSERT INTO `tbl_resident` VALUES (2100001,'Petilla','Aileen Joy','',NULL,'Female','2000-09-02','Manila','Single','Catholic','Filipino',9090909090,'Manila',NULL,NULL,NULL),(2100002,'Saban','John Michael',NULL,NULL,'Male','2021-10-17','Manila','Married','Christian','Filipino',12345678909,'Manila','2021-10-18 00:52:34','2021-10-18 00:52:34',NULL);
/*!40000 ALTER TABLE `tbl_resident` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_service-details`
--

DROP TABLE IF EXISTS `tbl_service-details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_service-details` (
  `ServiceDetailsID` int(11) NOT NULL AUTO_INCREMENT,
  `ServiceID` int(11) NOT NULL,
  `ComplaineeName` varchar(45) NOT NULL,
  `DefendantName` varchar(45) NOT NULL,
  `Incident` varchar(45) NOT NULL,
  `IncidentDate` date NOT NULL,
  `IncidentTime` time NOT NULL,
  `Statement` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ServiceDetailsID`),
  UNIQUE KEY `ServiceDetailIsD_UNIQUE` (`ServiceDetailsID`),
  KEY `ServiceID_idx` (`ServiceID`),
  CONSTRAINT `ServiceID` FOREIGN KEY (`ServiceID`) REFERENCES `tbl_services` (`ServiceID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_service-details`
--

LOCK TABLES `tbl_service-details` WRITE;
/*!40000 ALTER TABLE `tbl_service-details` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_service-details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_services`
--

DROP TABLE IF EXISTS `tbl_services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_services` (
  `ServiceID` int(11) NOT NULL AUTO_INCREMENT,
  `UsersID` int(11) NOT NULL,
  `ServiceType` varchar(45) NOT NULL,
  `ResidentID` int(11) NOT NULL,
  `Date` date NOT NULL,
  `ChairmanID` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ServiceID`),
  UNIQUE KEY `ServiceID_UNIQUE` (`ServiceID`),
  KEY `ResidentID_idx` (`ResidentID`),
  KEY `UsersID_idx` (`UsersID`),
  CONSTRAINT `ResidentID` FOREIGN KEY (`ResidentID`) REFERENCES `tbl_resident` (`ResidentID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `UsersID` FOREIGN KEY (`UsersID`) REFERENCES `tbl_user` (`UserID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_services`
--

LOCK TABLES `tbl_services` WRITE;
/*!40000 ALTER TABLE `tbl_services` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_services` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user`
--

DROP TABLE IF EXISTS `tbl_user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `UserTypeID` int(11) NOT NULL,
  `UserFullName` varchar(45) NOT NULL,
  `UserSuffix` varchar(45) DEFAULT NULL,
  `UserSex` varchar(45) NOT NULL,
  `UserBirthdate` date NOT NULL,
  `UserAddress` varchar(45) NOT NULL,
  `UserContactNo` bigint(20) NOT NULL,
  `Position` varchar(45) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  UNIQUE KEY `UserID_UNIQUE` (`UserID`)
) ENGINE=InnoDB AUTO_INCREMENT=102 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user`
--

LOCK TABLES `tbl_user` WRITE;
/*!40000 ALTER TABLE `tbl_user` DISABLE KEYS */;
INSERT INTO `tbl_user` VALUES (101,1,'Andrea Rafael',NULL,'Female','2000-01-06','Caloocan City',9950573917,'Chairman','admin','0000',NULL,NULL,NULL);
/*!40000 ALTER TABLE `tbl_user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tbl_user-types`
--

DROP TABLE IF EXISTS `tbl_user-types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tbl_user-types` (
  `UserTypeID` int(11) NOT NULL AUTO_INCREMENT,
  `UserID` int(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserTypeID`),
  UNIQUE KEY `UserTypeID_UNIQUE` (`UserTypeID`),
  KEY `UserID_idx` (`UserID`),
  CONSTRAINT `UserID` FOREIGN KEY (`UserID`) REFERENCES `tbl_user` (`UserID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_user-types`
--

LOCK TABLES `tbl_user-types` WRITE;
/*!40000 ALTER TABLE `tbl_user-types` DISABLE KEYS */;
INSERT INTO `tbl_user-types` VALUES (1,101,'Andrea Rafael','2021-10-18 00:50:35','2021-10-18 00:50:35',NULL);
/*!40000 ALTER TABLE `tbl_user-types` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-10-18  0:53:10
