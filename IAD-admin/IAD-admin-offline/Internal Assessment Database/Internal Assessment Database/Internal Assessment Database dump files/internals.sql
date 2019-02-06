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
-- Table structure for table `college`
--

DROP TABLE IF EXISTS `college`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `college` (
  `sn` int(11) NOT NULL AUTO_INCREMENT,
  `CollegeName` varchar(45) NOT NULL,
  `CollegeCode` varchar(45) NOT NULL,
  PRIMARY KEY (`CollegeCode`),
  UNIQUE KEY `sn_UNIQUE` (`sn`),
  UNIQUE KEY `CollegeName_UNIQUE` (`CollegeName`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `college`
--

LOCK TABLES `college` WRITE;
/*!40000 ALTER TABLE `college` DISABLE KEYS */;
INSERT INTO `college` VALUES (6,'Advanced College','ACE'),(10,'Himalayan College ','HCE'),(13,'Janakpur Eng. College','JEC'),(7,'Kantipur Eng. College','KAN'),(5,'Kathmandu Eng. College','KAT'),(8,'Khowpa Eng. College','KCE'),(11,'Kathford College','KIC'),(14,'Lalitpur Eng. College','LEC'),(15,'Asffggg','MNY'),(9,'National College ','NCE'),(3,'Paschimanchal Campus','PAS'),(1,'Pulchowk Campus','PUL'),(4,'Purwanchal Campus','PUR'),(12,'Sagarmatha College ','SEC'),(2,'Thapathali Campus','THA');
/*!40000 ALTER TABLE `college` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `login`
--

DROP TABLE IF EXISTS `login`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `login` (
  `sn` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(45) NOT NULL,
  `Password` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`UserName`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (3,'shreeram','shreeram'),(4,'suman','suman'),(2,'ujjwal','ujjwal'),(1,'vj','vj');
/*!40000 ALTER TABLE `login` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `program`
--

DROP TABLE IF EXISTS `program`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `program` (
  `sn` int(11) NOT NULL AUTO_INCREMENT,
  `ProgramCode` varchar(45) NOT NULL,
  `ProgramName` varchar(45) NOT NULL,
  PRIMARY KEY (`ProgramCode`),
  UNIQUE KEY `DepartmentName_UNIQUE` (`ProgramName`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `program`
--

LOCK TABLES `program` WRITE;
/*!40000 ALTER TABLE `program` DISABLE KEYS */;
INSERT INTO `program` VALUES (5,'ARN','Aeronautical'),(4,'BCE','Civil'),(1,'BCT','Computer'),(3,'BEL','Electrical'),(2,'BEX','Electronics');
/*!40000 ALTER TABLE `program` ENABLE KEYS */;
UNLOCK TABLES;

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
  `Lname` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `ProgramCode` varchar(45) NOT NULL,
  `Batch` varchar(3) NOT NULL,
  `GroupName` varchar(1) NOT NULL,
  `ContactNo` varchar(45) DEFAULT NULL,
  `CollegeCode` varchar(45) NOT NULL,
  PRIMARY KEY (`RollNo`,`CollegeCode`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student`
--

LOCK TABLES `student` WRITE;
/*!40000 ALTER TABLE `student` DISABLE KEYS */;
INSERT INTO `student` VALUES (12,'070BCE101','Mohan','Lal','lalmohan@gmail.com','BCE','070','B','987456305','THA'),(13,'070BCE102','Ravi','Kumar','kumar@gmail.com','BCE','070','B','9874563105','THA'),(14,'070BCE103','Shyam','Lal','lal@gmail.com','BCE','070','B','9874325844','THA'),(15,'070BCE107','Hari','Yadav','hari@gmail.com','BCE','070','B','9874563558','THA'),(16,'070BCE108','Jay','Prasad','jay@gmail.com','BCE','070','A','9874563210','THA'),(17,'070BCT011','John','Khatri','john@gmail.com','BCE','070','B','9854712300','THA'),(1,'072BCT501','Aashish ','Manandhar','aashish@gmail.com','BCT','072','A',NULL,'PAS'),(2,'072BCT502','Aashutosh ','Poudel','aasutosh@gmail.com','BCT','072','A',NULL,'PAS'),(3,'072BCT503','Aayush ','Gautam','aayush@gmail.com','BCT','072','A',NULL,'PUL'),(4,'072BCT504','Alina ','Devkota','alina@gmail.com','BCT','072','A',NULL,'PUL'),(5,'072BCT525','Prajwal ','Pradhan','prajwal@gmail.com','BCT','072','B',NULL,'PAS'),(6,'072BCT526','Prashant ','Khadka','prshnt@gmail.com','BCT','072','B',NULL,'PUL'),(7,'072BCT529','Rohan ','Thapa','rohan@gmail.com','BCT','072','B',NULL,'PUL'),(11,'072BCT536','Shree Ram','Rauniyar','shreeram@gmail.com','BCT','072','B',NULL,'PAS'),(10,'072BCT541','Suman','Khatri','suman@khatri.com','BCT','072','B',NULL,'PUL'),(9,'072BCT546','Ujjwal','gewali','ujjwal@gmail.com','BCT','072','B',NULL,'PUL'),(8,'072BCT547','Vijay','Yadav','vijay_ydv@hotmail.com','BCT','072','B','9808936302','PUL');
/*!40000 ALTER TABLE `student` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `subject` (
  `SN` int(11) NOT NULL AUTO_INCREMENT,
  `SubjectCode` varchar(45) NOT NULL,
  `SubjectName` varchar(45) NOT NULL,
  `ProgramCode` varchar(45) NOT NULL,
  `TheoryFull` varchar(45) DEFAULT '0',
  `TheoryPass` varchar(45) DEFAULT '0',
  `PracticalFull` varchar(45) DEFAULT '0',
  `PracticalPass` varchar(45) DEFAULT '0',
  PRIMARY KEY (`SubjectCode`),
  UNIQUE KEY `SubjectCode_UNIQUE` (`SubjectCode`),
  UNIQUE KEY `Course_UNIQUE` (`SubjectName`),
  UNIQUE KEY `SN_UNIQUE` (`SN`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (7,'CE655','Engineering Economics','BCE','20','08','0','0'),(1,'CT101','C programming','BCT','20','8','50','30'),(4,'CT102','DBMS','BCT','20','8','50','30'),(6,'CT655','Embedded System','BCT','20','08','25','10'),(5,'CT656','Operating System','BCT','20','08','25','10'),(3,'CV101','applied Mechanics','BCE','20','8','0','0'),(2,'SH101','Physics','SH','20','8','50','30');
/*!40000 ALTER TABLE `subject` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-07-21 13:21:05
