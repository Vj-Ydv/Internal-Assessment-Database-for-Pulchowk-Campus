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
INSERT INTO `college` VALUES (6,'Advanced College','ACE'),(10,'Himalayan College ','HCE'),(13,'Janakpur Eng. College','JEC'),(7,'Kantipur Eng. College','KAN'),(5,'Kathmandu Eng. College','KAT'),(8,'Khowpa Eng. College','KCE'),(11,'Kathford College','KIC'),(14,'Lalitpur Eng. College','LEC'),(9,'National College ','NCE'),(3,'Paschimanchal Campus','PAS'),(1,'Pulchowk Campus','PUL'),(4,'Purwanchal Campus','PUR'),(12,'Sagarmatha College ','SEC'),(2,'Thapathali Campus','THA');
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
  `Password` varbinary(50) DEFAULT NULL,
  `CollegeCode` varchar(45) NOT NULL,
  PRIMARY KEY (`UserName`,`CollegeCode`),
  UNIQUE KEY `sn_UNIQUE` (`sn`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `login`
--

LOCK TABLES `login` WRITE;
/*!40000 ALTER TABLE `login` DISABLE KEYS */;
INSERT INTO `login` VALUES (2,'ECD','R\Œdm™äJHÉ´	ı/6ô','ECD'),(3,'PAS','÷º\⁄˛\–;ªı–çò	É\Î','PAS');
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
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subject`
--

LOCK TABLES `subject` WRITE;
/*!40000 ALTER TABLE `subject` DISABLE KEYS */;
INSERT INTO `subject` VALUES (7,'CE655','Engineering Economics','BCE','20','08','0','0'),(1,'CT101','C programming','BCT','20','8','50','30'),(4,'CT102','DBMS','BCT','20','8','50','30'),(8,'CT500','Nrn','BCT','20','08','50','30'),(6,'CT655','Embedded System','BCT','20','08','25','10'),(5,'CT656','Operating System','BCT','20','08','25','10'),(3,'CV101','applied Mechanics','BCE','20','8','0','0'),(2,'SH101','Physics','SH','20','8','50','30');
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

-- Dump completed on 2018-09-22 16:54:58
