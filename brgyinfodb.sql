-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: brgyinfodb
-- ------------------------------------------------------
-- Server version	8.0.27

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
  `Id` int NOT NULL AUTO_INCREMENT,
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
  `ContactNo` bigint DEFAULT NULL,
  `Address` varchar(45) DEFAULT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY (`ResidentId`),
  UNIQUE KEY `ID_UNIQUE` (`Id`),
  UNIQUE KEY `RESIDENT_ID_UNIQUE` (`ResidentId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `residents`
--

LOCK TABLES `residents` WRITE;
/*!40000 ALTER TABLE `residents` DISABLE KEYS */;
INSERT INTO `residents` VALUES (5,'RES271120210507','Castillo','Joseph Brian','Ramirez','II','Male','2000-05-21','Quezon City','Separated','Born Again','Filipino',9728364518,'210 P Tuazon Blvd Manila','2021-11-27 17:37:07','2021-11-27 17:37:07',NULL,NULL),(2,'RES271120210516','Saban','John Michael','Dante','Jr.','Male','1999-06-15','Quezon City','Married','Christian','Filipino',9124745924,'555 T. Alonzo St. Manila','2021-11-27 17:23:16','2021-11-27 17:23:16',NULL,NULL),(4,'RES271120210518','Sullera','Real','','','Male','1999-09-21','Manila','Single','Catholic','Filipino',9274851927,'1476 V.G. Cruz St. Manila','2021-11-27 17:35:18','2021-11-27 17:35:18',NULL,NULL),(3,'RES271120210526','Ovalles','Aiyies Lois','Casaclang','I','Male','1998-02-11','Manila','Separated','Iglesia Ni Cristo','Korean',9133237538,'1203 Benavidez St. Manila','2021-11-27 17:31:26','2021-11-27 17:31:26',NULL,NULL),(6,'RES271120210543','Napao','Ninna Odette','Villegas','','Female','1999-12-24','San Juan','Single','Iglesia Ni Cristo','Filipino',9276279301,'2339 Jesus St. Pandacan, Manila','2021-11-27 17:41:43','2021-11-27 17:41:43',NULL,NULL),(1,'RES271120210551','Petilla','Aileen Joy','Abellar','','Female','2000-09-02','Manila','Single','Catholic','Russian',9123423982,'734 R Hidalgo St. Manila','2021-11-27 17:21:51','2021-11-27 17:21:51',NULL,NULL),(8,'RES271120210557','Reyes','Austine Jherico','Rizaga','III','Male','2000-05-16','Caloocan','Single','Christian','Filipino',9263827354,'561 Quintin Paredes St. Binondo Manila','2021-11-27 17:44:57','2021-11-27 17:44:57',NULL,NULL),(9,'RES271120210652','Sibulo','Abegail','Yanson','','Female','2000-07-21','Manila','Single','Catholic','Filipino',9374628379,'1349 Rizal Avenue Ext. Manila','2021-11-27 18:37:52','2021-11-27 18:37:52',NULL,NULL),(10,'RES281120210212','Beloro','Danilo','Robrigado','','Male','1998-03-23','Bicol City','Married','Catholic','Filipino',9263874512,'1003 Ongpin Street Sta. Cruz, Manila','2021-11-28 14:47:12','2021-11-28 14:47:12',NULL,NULL),(11,'RES281120210216','Ragasa','Danica','Medilo','','Female','1999-12-14','Manila','Single','Christian','Filipino',9263748621,'839-841 Alvarado St. Manila','2021-11-28 14:48:16','2021-11-28 14:48:16',NULL,NULL),(12,'RES281120210258','Orot','Rico','Sol','I','Male','1999-03-12','Cavite','Single','Iglesia Ni Cristo','Filipino',9827364519,'711 T. Alonzo St. Manila','2021-11-28 14:50:58','2021-11-28 14:50:58',NULL,NULL),(13,'RES281120210401','Balacano','Jayson Jade','Barroga','Jr.','Male','1999-05-18','Pasig City','Separated','Christian','Filipino',9726354812,'658 Herbosa St. Manila','2021-11-28 16:09:01','2021-11-28 16:09:01',NULL,NULL),(14,'RES281120210458','Alimpuyo','Christian Mar','Bungay','','Male','1999-11-27','Taguig City','Married','Muslim','Filipino',9736251831,' 1406 Apacible St, Paco, Manila','2021-11-28 16:10:58','2021-11-28 16:10:58',NULL,NULL);
/*!40000 ALTER TABLE `residents` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_details`
--

DROP TABLE IF EXISTS `service_details`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service_details` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `ServiceId` int NOT NULL,
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
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_details`
--

LOCK TABLES `service_details` WRITE;
/*!40000 ALTER TABLE `service_details` DISABLE KEYS */;
INSERT INTO `service_details` VALUES (1,2,'Bernard gRESOLA','Rafael','safdsafasd','2021-10-20','08:00:00','blah blah','2021-10-21 22:07:59','2021-10-21 22:07:59',NULL,'2'),(2,3,'Bernard gRESOLA','Rafael','safdsafasd','2021-10-20','08:00:00','blah blah','2021-10-21 22:07:59','2021-10-21 22:07:59',NULL,'2'),(3,1,'juna dla cruz','Rafael','safdsafasd','2021-10-20','08:00:00','blah blah','2021-10-21 22:07:59','2021-10-21 22:07:59',NULL,NULL),(4,1,'John Saban','Ovalles Aiyies','Theft','2021-11-27','14:26:51','Nnaakawan ako uuhuhuuh','2021-11-27 14:26:51','2021-11-27 14:26:51',NULL,'RES271120211241');
/*!40000 ALTER TABLE `service_details` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `service_types`
--

DROP TABLE IF EXISTS `service_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `service_types` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `service_types`
--

LOCK TABLES `service_types` WRITE;
/*!40000 ALTER TABLE `service_types` DISABLE KEYS */;
INSERT INTO `service_types` VALUES (1,'Blotter','2021-10-21 21:44:03','2021-10-21 21:44:03'),(2,'Certificate of Residency','2021-10-21 21:44:03','2021-10-21 21:44:03'),(3,'Barangay Clearance','2021-10-21 21:44:03','2021-10-21 21:44:03'),(4,'Ayuda','2021-10-21 21:44:03','2021-10-21 21:44:03'),(5,'Certificate of Indigency','2021-11-28 21:36:09','2021-11-28 21:36:09');
/*!40000 ALTER TABLE `service_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `services`
--

DROP TABLE IF EXISTS `services`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `services` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` int NOT NULL,
  `ServiceTypeId` varchar(45) NOT NULL,
  `ResidentID` int DEFAULT NULL,
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
  `Id` int NOT NULL AUTO_INCREMENT,
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
  `Id` int NOT NULL AUTO_INCREMENT,
  `UserId` varchar(45) NOT NULL,
  `LastName` varchar(45) NOT NULL,
  `FirstName` varchar(45) NOT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `Suffix` varchar(45) DEFAULT NULL,
  `Sex` varchar(45) NOT NULL,
  `Birthdate` date NOT NULL,
  `Address` varchar(45) NOT NULL,
  `ContactNumber` bigint NOT NULL,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `Position` varchar(45) NOT NULL,
  `DateTimeCreated` datetime DEFAULT CURRENT_TIMESTAMP,
  `DateTimeUpdated` datetime DEFAULT CURRENT_TIMESTAMP,
  `Remarks` varchar(45) DEFAULT NULL,
  `UserTypeId` int DEFAULT NULL,
  `Age` int DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserID_UNIQUE` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (101,'USER281120210903','Rafael','Andrea Nicole','Bautista',NULL,'Female','2000-01-06','Caloocan City',9950573917,'admin','0000','Chairman','2021-11-28 21:32:00','2021-11-28 21:32:00',NULL,1,NULL),(103,'USER281120210900','Aileen','Aileen Joy','Abellar','N/A','Female','2000-09-02','Manila',9950573917,'secretary','qwert123','Secretary','2021-11-28 21:23:00','2021-11-28 21:23:00',NULL,2,NULL);
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

-- Dump completed on 2021-11-28 21:38:13
