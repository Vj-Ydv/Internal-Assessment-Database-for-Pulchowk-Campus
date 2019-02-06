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
  `TheoryObtained` int(11) DEFAULT NULL,
  `PracticalObtained` int(11) DEFAULT NULL,
  `TheoryRemarks` varchar(45) DEFAULT NULL,
  `PracticalRemarks` varchar(45) DEFAULT NULL,
  `TheoryInWords` varchar(45) DEFAULT NULL,
  `PracticalInWords` varchar(45) DEFAULT NULL,
  `UserName` varchar(45) DEFAULT NULL,
  `TheoryStatus` varchar(45) DEFAULT NULL,
  `PracticalStatus` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`RollNo`,`SubjectCode`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=168 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `marks`
--

LOCK TABLES `marks` WRITE;
/*!40000 ALTER TABLE `marks` DISABLE KEYS */;
INSERT INTO `marks` VALUES (122,'072BCT501','CT101',5,20,'Fail','Fail','Five','Twenty','RAM','0','1'),(123,'072BCT502','CT101',20,30,'Pass','Pass','Twenty','Thirty','ECD','2','2'),(124,'072BCT503','CT101',10,30,'Pass','Pass','Ten','Thirty','RAM','2','2'),(166,'072BCT504','CE655',20,NULL,'Pass',NULL,'Twenty',NULL,'ECD','2',NULL),(163,'072BCT504','CT101',14,40,'Pass','Pass','Fourteen','Forty','ECD','2','1'),(164,'072BCT504','CT102',15,46,'Pass','Pass','Fifteen','Forty-Six','ECD','2','1'),(165,'072BCT504','CT655',14,25,'Pass','Pass','Fourteen','Twenty-Five','ECD','2','1'),(167,'072BCT504','CT656',17,24,'Pass','Pass','Seventeen','Twenty-Four','ECD','2','1'),(162,'072BCT504','CV101',15,NULL,'Pass',NULL,'Fifteen',NULL,'ECD','2',NULL),(161,'072BCT504','SH101',20,40,'Pass','Pass','Twenty','Forty','ECD','2','1'),(143,'072BCT526','CE655',16,NULL,'Pass',NULL,'Sixteen',NULL,'ECD','2',NULL),(125,'072BCT526','CT101',12,48,'Pass','Pass','Twelve','Forty-Eight','ECD','2','1'),(131,'072BCT526','CT102',18,46,'Pass','Pass','Eighteen','Forty-Six','ECD','2','1'),(137,'072BCT526','CT655',20,20,'Pass','Pass','Twenty','Twenty','ECD','2','1'),(149,'072BCT526','CT656',0,5,'Absent','Fail','-','Five','ECD','1','1'),(117,'072BCT526','CV101',5,NULL,'Fail',NULL,'Five',NULL,'VIJAY','0','1'),(155,'072BCT526','SH101',20,49,'Pass','Pass','Twenty','Forty-Nine','ECD','2','1'),(144,'072BCT529','CE655',14,NULL,'Pass',NULL,'Fourteen',NULL,'ECD','2',NULL),(126,'072BCT529','CT101',7,20,'Fail','Fail','Seven','Twenty','ECD','0','1'),(132,'072BCT529','CT102',4,0,'Fail','Absent','Four','-','ECD','0','1'),(138,'072BCT529','CT655',7,25,'Fail','Pass','Seven','Twenty-Five','ECD','0','1'),(150,'072BCT529','CT656',16,0,'Pass','Absent','Sixteen','-','ECD','2','1'),(118,'072BCT529','CV101',0,NULL,'Absent',NULL,'-',NULL,'VIJAY','1','1'),(156,'072BCT529','SH101',14,50,'Pass','Pass','Fourteen','Fifty','ECD','2','1'),(145,'072BCT541','CE655',12,NULL,'Pass',NULL,'Twelve',NULL,'ECD','2',NULL),(127,'072BCT541','CT101',17,30,'Pass','Pass','Seventeen','Thirty','ECD','2','1'),(133,'072BCT541','CT102',15,48,'Pass','Pass','Fifteen','Forty-Eight','ECD','2','1'),(139,'072BCT541','CT655',13,24,'Pass','Pass','Thirteen','Twenty-Four','ECD','2','1'),(151,'072BCT541','CT656',7,22,'Fail','Pass','Seven','Twenty-Two','ECD','0','1'),(119,'072BCT541','CV101',15,NULL,'Pass',NULL,'Fifteen',NULL,'VIJAY','2','2'),(157,'072BCT541','SH101',18,50,'Pass','Pass','Eighteen','Fifty','ECD','2','1'),(146,'072BCT546','CE655',0,NULL,'Absent',NULL,'-',NULL,'ECD','1',NULL),(128,'072BCT546','CT101',0,45,'Absent','Pass','-','Forty-Five','ECD','1','1'),(134,'072BCT546','CT102',17,20,'Pass','Fail','Seventeen','Twenty','ECD','2','1'),(140,'072BCT546','CT655',20,24,'Pass','Pass','Twenty','Twenty-Four','ECD','2','1'),(152,'072BCT546','CT656',17,20,'Pass','Pass','Seventeen','Twenty','ECD','2','1'),(120,'072BCT546','CV101',16,NULL,'Pass',NULL,'Sixteen',NULL,'ECD','2','2'),(158,'072BCT546','SH101',16,46,'Pass','Pass','Sixteen','Forty-Six','ECD','2','1'),(147,'072BCT547','CE655',18,NULL,'Pass',NULL,'Eighteen',NULL,'ECD','2',NULL),(129,'072BCT547','CT101',18,50,'Pass','Pass','Eighteen','Fifty','ECD','2','1'),(135,'072BCT547','CT102',20,50,'Pass','Pass','Twenty','Fifty','ECD','2','1'),(141,'072BCT547','CT655',20,25,'Pass','Pass','Twenty','Twenty-Five','ECD','2','1'),(153,'072BCT547','CT656',20,25,'Pass','Pass','Twenty','Twenty-Five','ECD','2','1'),(121,'072BCT547','CV101',20,NULL,'Pass',NULL,'Twenty',NULL,'ECD','2','2'),(159,'072BCT547','SH101',20,43,'Pass','Pass','Twenty','Forty-Three','ECD','2','1'),(148,'072BCT548','CE655',16,NULL,'Pass',NULL,'Sixteen',NULL,'ECD','2',NULL),(130,'072BCT548','CT101',16,37,'Pass','Pass','Sixteen','Thirty-Seven','ECD','2','1'),(136,'072BCT548','CT102',12,0,'Pass','Absent','Twelve','-','ECD','2','1'),(142,'072BCT548','CT655',0,4,'Absent','Fail','-','Four','ECD','1','1'),(154,'072BCT548','CT656',20,21,'Pass','Pass','Twenty','Twenty-One','ECD','2','1'),(160,'072BCT548','SH101',16,0,'Pass','Absent','Sixteen','-','ECD','2','1');
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

-- Dump completed on 2018-09-22 16:55:39
