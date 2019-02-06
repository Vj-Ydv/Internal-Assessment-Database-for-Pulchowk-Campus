-- MySQL dump 10.13  Distrib 8.0.11, for Win64 (x86_64)
--
-- Host: localhost    Database: internals
-- ------------------------------------------------------
-- Server version	8.0.11

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `marks`
--

DROP TABLE IF EXISTS `marks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `marks` (
  `sn` int(11) NOT NULL AUTO_INCREMENT,
  `RollNo` varchar(45) NOT NULL,
  `SubjectCode` varchar(45) NOT NULL,
  `TheoryObtained` varchar(45) DEFAULT NULL,
  `PracticalObtained` varchar(45) DEFAULT NULL,
  `TheoryRemarks` varchar(45) DEFAULT NULL,
  `PracticalRemarks` varchar(45) DEFAULT NULL,
  `TheoryInWords` varchar(45) DEFAULT NULL,
  `PracticalInWords` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`RollNo`,`SubjectCode`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marks`
--

LOCK TABLES `marks` WRITE;
/*!40000 ALTER TABLE `marks` DISABLE KEYS */;
INSERT INTO `marks` VALUES (1,'072BCT501','CT101','18','45','Pass','Pass','Eighteen','Forty-Five'),(6,'072BCT501','CT102','19','45','Pass','Pass',NULL,NULL),(30,'072BCT501','CV101','18','','Pass','','Eighteen',''),(14,'072BCT501','SH101','18','50','Pass','Pass',NULL,NULL),(2,'072BCT502','CT101','20','48','Pass','Pass','Twenty','Forty-Eight'),(31,'072BCT502','CV101','19','','Pass','','Nineteen',''),(15,'072BCT502','SH101','20','50','Pass','Pass',NULL,NULL),(3,'072BCT503','CT101','18','50','Pass','Pass','Eighteen','Fifty'),(32,'072BCT503','CV101','20','','Pass','','Twenty',''),(16,'072BCT503','SH101','20','46','Pass','Pass',NULL,NULL),(13,'072BCT504','CT101','19','49','Pass','Pass','Nineteen','Forty-Nine'),(33,'072BCT504','CV101','19','','Pass','','Nineteen',''),(17,'072BCT504','SH101','19','47','Pass','Pass',NULL,NULL),(7,'072BCT525','CT101','15','48','Pass','Pass','Fifteen',NULL),(8,'072BCT526','CT101','18','45','Pass','Pass','Eighteen',NULL),(9,'072BCT529','CT101','19','49','Pass','Pass','Nineteen',NULL),(37,'072BCT536','CT102','-','49','Absent','Pass','-','Forty-Nine'),(21,'072BCT536','CV101','-','0','Absent','Pass',NULL,NULL),(29,'072BCT536','SH101','19','50','Pass','Pass',NULL,NULL),(36,'072BCT541','CT102','7','50','Fail','Pass','Seven','Fifty'),(20,'072BCT541','CV101','7','0','Fail','Pass',NULL,NULL),(28,'072BCT541','SH101','20','49','Pass','Pass',NULL,NULL),(35,'072BCT546','CT102','19','48','Pass','Pass','Nineteen','Forty-Eight'),(19,'072BCT546','CV101','19','0','Pass','Pass',NULL,NULL),(27,'072BCT546','SH101','20','50','Pass','Pass',NULL,NULL),(34,'072BCT547','CT102','20','50','Pass','Pass','Twenty','Fifty'),(18,'072BCT547','CV101','20','0','Pass','Pass',NULL,NULL),(26,'072BCT547','SH101','20','50','Pass','Pass',NULL,NULL);
/*!40000 ALTER TABLE `marks` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-07-21 13:21:43
