-- MySQL dump 10.13  Distrib 8.0.46, for Linux (x86_64)
--
-- Host: localhost    Database: trainee_management_db
-- ------------------------------------------------------
-- Server version	8.0.46-0ubuntu0.24.04.2

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Current Database: `trainee_management_db`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `trainee_management_db` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;

USE `trainee_management_db`;

--
-- Table structure for table `LearningTasks`
--

DROP TABLE IF EXISTS `LearningTasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `LearningTasks` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Title` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ExpectedTechStack` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DueDate` datetime(6) NOT NULL,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `LearningTasks`
--

LOCK TABLES `LearningTasks` WRITE;
/*!40000 ALTER TABLE `LearningTasks` DISABLE KEYS */;
INSERT INTO `LearningTasks` VALUES (1,'frontend ','to complete frontend design','react','2026-06-12 00:00:00.000000','Closed','2026-06-12 10:19:58.705764','2026-06-12 10:26:07.749961'),(2,'frontend design','to complete frontend design','java','2026-06-12 00:00:00.000000','Draft','2026-06-12 10:20:35.893474','2026-06-12 10:20:35.893474'),(3,'frontend design','to complete frontend design','java','2026-06-13 00:00:00.000000','Draft','2026-06-12 10:21:38.396200','2026-06-12 10:21:38.396200'),(4,'backend','to complete backend apis','java','2026-06-13 00:00:00.000000','Draft','2026-06-12 10:22:19.564655','2026-06-12 10:22:19.564655');
/*!40000 ALTER TABLE `LearningTasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Mentors`
--

DROP TABLE IF EXISTS `Mentors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Mentors` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Expertise` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Mentors`
--

LOCK TABLES `Mentors` WRITE;
/*!40000 ALTER TABLE `Mentors` DISABLE KEYS */;
INSERT INTO `Mentors` VALUES (8,'Marcus','Chen','m.chen@techcorp.com','Cloud Architecture','Active','2026-06-12 08:51:02.126754','2026-06-12 08:51:02.126754'),(9,'Elena','Rodriguez','elena.rodriguez@designhub.io','UI/UX Design','Active','2026-06-12 08:51:11.363087','2026-06-12 08:51:11.363087'),(10,'David','Smith','dsmith@analytics.net','Data Science','Inactive','2026-06-12 08:51:20.416273','2026-06-12 08:53:49.505790'),(11,'Amina','Okonkwo','amina.o@security-ops.com','Cybersecurity','Active','2026-06-12 08:51:28.860106','2026-06-12 08:51:28.860106'),(12,'Hiroshi','Tanaka','h.tanaka@systems.jp','DevOps Engineering','Active','2026-06-12 08:51:37.437433','2026-06-12 08:51:37.437433'),(13,'Sarah','O\'Connor','sarah.oc@mobiledev.com','iOS/Android Development','Active','2026-06-12 08:51:48.477518','2026-06-12 08:51:48.477518');
/*!40000 ALTER TABLE `Mentors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Reviews`
--

DROP TABLE IF EXISTS `Reviews`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Reviews` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SubmissionId` int NOT NULL,
  `MentorId` int NOT NULL,
  `Feedback` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Score` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ReviewedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Reviews_MentorId` (`MentorId`),
  KEY `IX_Reviews_SubmissionId` (`SubmissionId`),
  CONSTRAINT `FK_Reviews_Mentors_MentorId` FOREIGN KEY (`MentorId`) REFERENCES `Mentors` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_Reviews_Submissions_SubmissionId` FOREIGN KEY (`SubmissionId`) REFERENCES `Submissions` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Reviews`
--

LOCK TABLES `Reviews` WRITE;
/*!40000 ALTER TABLE `Reviews` DISABLE KEYS */;
INSERT INTO `Reviews` VALUES (1,1,10,'good','A+','Accepted','2026-06-15 00:00:00.000000'),(2,1,9,'good','A+','Accepted','2026-06-15 00:00:00.000000'),(3,1,9,'very good','A+','Accepted','2026-06-17 00:00:00.000000'),(4,1,9,'excellent','10','Accepted','2026-06-16 00:00:00.000000');
/*!40000 ALTER TABLE `Reviews` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `SubmissionFiles`
--

DROP TABLE IF EXISTS `SubmissionFiles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `SubmissionFiles` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `SubmissionId` int NOT NULL,
  `OriginalFileName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `StorageName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ContentType` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `FileSizeBytes` bigint NOT NULL,
  `CheckSum` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `UploadedByUserId` int NOT NULL,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SubmissionFiles_SubmissionId` (`SubmissionId`),
  CONSTRAINT `FK_SubmissionFiles_Submissions_SubmissionId` FOREIGN KEY (`SubmissionId`) REFERENCES `Submissions` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `SubmissionFiles`
--

LOCK TABLES `SubmissionFiles` WRITE;
/*!40000 ALTER TABLE `SubmissionFiles` DISABLE KEYS */;
INSERT INTO `SubmissionFiles` VALUES (3,1,'Devtools_assignment (1).pdf','8a3359d0-1464-4ee6-9569-d5bda6ebaa7a.pdf','application/pdf',3084268,'DC87C2E53ED7FADEEA2D010258DDBB8DE4A83D1ADE00AF2C94B69DCEFBF260EE',1,'2026-06-19 13:50:57.830786','2026-06-19 13:50:57.830811');
/*!40000 ALTER TABLE `SubmissionFiles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Submissions`
--

DROP TABLE IF EXISTS `Submissions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Submissions` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TaskAssignmentId` int NOT NULL,
  `SubmissionUrl` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Notes` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `SubmissionDate` datetime(6) NOT NULL,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_Submissions_TaskAssignmentId` (`TaskAssignmentId`),
  CONSTRAINT `FK_Submissions_TaskAssignments_TaskAssignmentId` FOREIGN KEY (`TaskAssignmentId`) REFERENCES `TaskAssignments` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Submissions`
--

LOCK TABLES `Submissions` WRITE;
/*!40000 ALTER TABLE `Submissions` DISABLE KEYS */;
INSERT INTO `Submissions` VALUES (1,2,'drive','task submitted','2026-06-15 00:00:00.000000','Submitted'),(2,2,'drive','task submitted','2026-06-16 00:00:00.000000','Submitted');
/*!40000 ALTER TABLE `Submissions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `TaskAssignments`
--

DROP TABLE IF EXISTS `TaskAssignments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `TaskAssignments` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `TraineeId` int NOT NULL,
  `MentorId` int NOT NULL,
  `LearningTaskId` int NOT NULL,
  `AssignedDate` datetime(6) NOT NULL,
  `DueDate` datetime(6) NOT NULL,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Remarks` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  PRIMARY KEY (`Id`),
  KEY `IX_TaskAssignments_LearningTaskId` (`LearningTaskId`),
  KEY `IX_TaskAssignments_MentorId` (`MentorId`),
  KEY `IX_TaskAssignments_TraineeId` (`TraineeId`),
  CONSTRAINT `FK_TaskAssignments_LearningTasks_LearningTaskId` FOREIGN KEY (`LearningTaskId`) REFERENCES `LearningTasks` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_TaskAssignments_Mentors_MentorId` FOREIGN KEY (`MentorId`) REFERENCES `Mentors` (`Id`) ON DELETE CASCADE,
  CONSTRAINT `FK_TaskAssignments_Trainees_TraineeId` FOREIGN KEY (`TraineeId`) REFERENCES `Trainees` (`Id`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `TaskAssignments`
--

LOCK TABLES `TaskAssignments` WRITE;
/*!40000 ALTER TABLE `TaskAssignments` DISABLE KEYS */;
INSERT INTO `TaskAssignments` VALUES (2,2,8,4,'2026-06-15 00:00:00.000000','2026-06-15 00:00:00.000000','InProgress','string'),(3,3,9,1,'2026-06-16 00:00:00.000000','2026-06-16 00:00:00.000000','Completed','string'),(4,2,8,4,'2026-06-22 00:00:00.000000','2026-06-22 00:00:00.000000','Assigned','some remarks');
/*!40000 ALTER TABLE `TaskAssignments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Trainees`
--

DROP TABLE IF EXISTS `Trainees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Trainees` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `TechStack` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Status` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Trainees`
--

LOCK TABLES `Trainees` WRITE;
/*!40000 ALTER TABLE `Trainees` DISABLE KEYS */;
INSERT INTO `Trainees` VALUES (1,'Suraj','Prajapati','suraj@gmail.com','MERN','Inactive','2026-06-12 05:58:30.606773','2026-06-12 05:58:30.606789'),(2,'Anand','Prajapati','anand@gmail.com','Flutter','Inactive','2026-06-12 05:58:42.161911','2026-06-22 09:50:51.814949'),(3,'Roshan','Prajapati','roshan@gmail.com','Java','Active','2026-06-12 05:58:51.630232','2026-06-12 05:58:51.630232'),(4,'Priya','Sharma','priya.s@example.com','DotNet','Active','2026-06-12 05:58:59.139139','2026-06-12 05:58:59.139139'),(6,'Sneha','Reddy','sneha.r@example.com','React','Active','2026-06-12 05:59:15.631202','2026-06-12 05:59:15.631202'),(7,'Rahul','Mehta','rahul.m@example.com','Angular','Active','2026-06-12 05:59:23.229463','2026-06-12 05:59:23.229463'),(8,'Anjali','Singh','anjali.s@example.com','Vue','Inactive','2026-06-12 05:59:34.892967','2026-06-12 05:59:34.892968'),(9,'Vikram','Joshi','vikram.j@example.com','NodeJS','Active','2026-06-12 05:59:44.687913','2026-06-12 05:59:44.687913'),(10,'Karan','Malhotra','karan.m@example.com','Go','Active','2026-06-12 05:59:52.304234','2026-06-12 05:59:52.304234'),(11,'Sonia','Bose','sonia.b@example.com','AWS','Inactive','2026-06-12 06:00:03.028389','2026-06-12 06:00:03.028389'),(14,'Amit','Verma','amit.v@example.com','Python','Active','2026-06-22 10:21:06.176467','2026-06-22 10:22:24.276028');
/*!40000 ALTER TABLE `Trainees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Users`
--

DROP TABLE IF EXISTS `Users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Username` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `PasswordHash` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Role` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CreatedDate` datetime(6) NOT NULL,
  `UpdatedDate` datetime(6) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Users`
--

LOCK TABLES `Users` WRITE;
/*!40000 ALTER TABLE `Users` DISABLE KEYS */;
INSERT INTO `Users` VALUES (1,'admin','admin@gmail.com','AQAAAAIAAYagAAAAED28NJbaPqdTxZ58lwwIy+q4b+M914PwOJyyhWBFap+X1hSy4wbUtE2ISgcJc5UiHw==','Admin','2026-06-12 05:57:10.706614','2026-06-12 05:57:10.706634');
/*!40000 ALTER TABLE `Users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `__EFMigrationsHistory`
--

DROP TABLE IF EXISTS `__EFMigrationsHistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `__EFMigrationsHistory` (
  `MigrationId` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductVersion` varchar(32) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__EFMigrationsHistory`
--

LOCK TABLES `__EFMigrationsHistory` WRITE;
/*!40000 ALTER TABLE `__EFMigrationsHistory` DISABLE KEYS */;
INSERT INTO `__EFMigrationsHistory` VALUES ('20260612055605_InitialCreate','9.0.0'),('20260612063210_MentorAndTaskMigration','9.0.0'),('20260615063555_AddTaskAssignmentMigration','9.0.0'),('20260615095759_AddReviewAndSubmissionMigration','9.0.0'),('20260615132140_AddReviewAndSubmissionMigration2','9.0.0'),('20260619084428_AddSubmissionFileMigration','9.0.0'),('20260619084619_AddSubmissionFileMigration2','9.0.0');
/*!40000 ALTER TABLE `__EFMigrationsHistory` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-06-22 10:57:36
