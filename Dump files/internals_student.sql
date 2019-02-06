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
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `student` (
  `sn` int(11) NOT NULL AUTO_INCREMENT,
  `RollNo` varchar(45) NOT NULL,
  `Fname` varchar(45) NOT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `Lname` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `ProgramCode` varchar(45) NOT NULL,
  `Batch` varchar(3) NOT NULL,
  `GroupName` varchar(1) NOT NULL,
  `ContactNo` varchar(45) DEFAULT NULL,
  `CollegeCode` varchar(45) NOT NULL,
  PRIMARY KEY (`RollNo`,`CollegeCode`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (12,'070BCE101','Mohan',NULL,'Lal','lalmohan@gmail.com','BCE','070','B','987456305','THA'),(13,'070BCE102','Ravi',NULL,'Kumar','kumar@gmail.com','BCE','070','B','9874563105','THA'),(14,'070BCE103','Shyam',NULL,'Lal','lal@gmail.com','BCE','070','B','9874325844','THA'),(15,'070BCE107','Hari',NULL,'Yadav','hari@gmail.com','BCE','070','B','9874563558','THA'),(16,'070BCE108','Jay',NULL,'Prasad','jay@gmail.com','BCE','070','A','9874563210','THA'),(18,'070BCE601','Roy',NULL,'Kapoor','roy@kapoor.com','BEX','070','A','9876985266','PAS'),(17,'070BCT011','John',NULL,'Khatri','john@gmail.com','BCE','070','B','9854712300','THA'),(1,'072BCT501','Aashish ','','Manandhar','aashish@gmail.com','BCT','072','A','','PAS'),(2,'072BCT502','Aashutosh ','','Paudel','aasutosh@gmail.com','BCT','072','A','','PAS'),(19,'072BCT503','Hari','','Yadav','hari@gmail.com','BCT','072','A','0000','PAS'),(4,'072BCT504','Alina ',NULL,'Devkota','alina@gmail.com','BCT','072','A',NULL,'PUL'),(5,'072BCT525','Prajwal ',NULL,'Pradhan','prajwal@gmail.com','BCT','072','B',NULL,'PAS'),(6,'072BCT526','Prashant ','Kumar','Khadka','prshnt@gmail.com','BCT','072','B','','PUL'),(7,'072BCT529','Rohan ','','Thapa','rohan@gmail.com','BCT','072','B','','PUL'),(11,'072BCT536','Shree Ram',NULL,'Rauniyar','shreeram@gmail.com','BCT','072','B',NULL,'PAS'),(10,'072BCT541','Suman','','Khatri','suman@khatri.com','BCT','072','B','','PUL'),(9,'072BCT546','Ujjwal','','gewali','ujjwal@gmail.com','BCT','072','B','','PUL'),(8,'072BCT547','Vijay','','Yadav','vijay_ydv@hotmail.com','BCT','072','B','9808936302','PUL'),(20,'072BCT548','Yogesh','','Rai','yogesh@gmail.com','BCT','072','B','9745632102','PUL');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
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
