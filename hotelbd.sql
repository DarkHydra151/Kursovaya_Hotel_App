-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: hotelbd
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `booking`
--

DROP TABLE IF EXISTS `booking`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking` (
  `id` int NOT NULL AUTO_INCREMENT,
  `room_id` int DEFAULT NULL,
  `client_id` int DEFAULT NULL,
  `status` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=621 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking`
--

LOCK TABLES `booking` WRITE;
/*!40000 ALTER TABLE `booking` DISABLE KEYS */;
INSERT INTO `booking` VALUES (303,302,NULL,'booked','cust1'),(305,352,NULL,'booked','cust1'),(353,402,NULL,'booked','cust1'),(452,652,NULL,'booked','cust1'),(453,554,252,'booked','cust1'),(502,552,202,'booked','cust1'),(553,702,NULL,'booked','cust2'),(602,553,203,'booked','cust1'),(603,123,NULL,'booked','cust1'),(604,124,NULL,'booked','cust1'),(605,124,NULL,'booked','cust1'),(608,3333,NULL,'333','333'),(610,4444,605,'33','3232'),(615,710,259,'booked','cust1'),(620,712,263,'booked','cust5');
/*!40000 ALTER TABLE `booking` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `booking_seq`
--

DROP TABLE IF EXISTS `booking_seq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `booking_seq` (
  `next_val` bigint DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `booking_seq`
--

LOCK TABLES `booking_seq` WRITE;
/*!40000 ALTER TABLE `booking_seq` DISABLE KEYS */;
INSERT INTO `booking_seq` VALUES (701);
/*!40000 ALTER TABLE `booking_seq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `assigned_room_id` int DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `used_room_ids` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=262 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (202,552,'$2a$12$TLJOLK.QjLRdxOHew1XMT.eYa2Xr5HMHaT14fRoI3gMOIZijNu9F2','552','client1'),(203,553,'$2a$12$TLJOLK.QjLRdxOHew1XMT.eYa2Xr5HMHaT14fRoI3gMOIZijNu9F2','553','client2'),(206,555,'$2a$12$TLJOLK.QjLRdxOHew1XMT.eYa2Xr5HMHaT14fRoI3gMOIZijNu9F2','555','client5'),(205,554,'$2a$12$TLJOLK.QjLRdxOHew1XMT.eYa2Xr5HMHaT14fRoI3gMOIZijNu9F2','554','client4'),(252,554,'$2a$12$TLJOLK.QjLRdxOHew1XMT.eYa2Xr5HMHaT14fRoI3gMOIZijNu9F2','602,603,554','client6'),(253,NULL,'$2a$11$p/LI1YgDv7b5L0CHQCZZje8GACcZFo01/5AiNaEo9iJRFFMitFwVy',NULL,'clien7'),(255,NULL,'$2a$11$AxHOQgYDNUDhZxPwTOmVO.ejhDv6iJDpYOWUgCl3.wz0InPI/8UHW',NULL,'434'),(259,NULL,'$2a$11$t51LryT7PDvPxOvOdc3xIO4d/Ws/4CggFnDjrVJ/J1wyqlgp7uyyW',NULL,'client8'),(261,NULL,'$2a$11$CAjcoso9INpqtilTn5D7CezVMPvL/6LJeiQS2V7FVS1eyYkabiO0C',NULL,'3443');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `client_seq`
--

DROP TABLE IF EXISTS `client_seq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client_seq` (
  `next_val` bigint DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client_seq`
--

LOCK TABLES `client_seq` WRITE;
/*!40000 ALTER TABLE `client_seq` DISABLE KEYS */;
INSERT INTO `client_seq` VALUES (351);
/*!40000 ALTER TABLE `client_seq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room`
--

DROP TABLE IF EXISTS `room`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room` (
  `id` int NOT NULL AUTO_INCREMENT,
  `available_for_booking` tinyint(1) DEFAULT '0',
  `time` varchar(255) DEFAULT NULL,
  `client_id` int DEFAULT NULL,
  `model` varchar(255) DEFAULT NULL,
  `number_of_residents` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=711 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room`
--

LOCK TABLES `room` WRITE;
/*!40000 ALTER TABLE `room` DISABLE KEYS */;
INSERT INTO `room` VALUES (552,0,'Day',202,'Apartment',4),(553,0,'Night',203,'Balcony',4),(554,0,'Day',252,'Family',7),(555,1,'Day',206,'Studio',3),(602,1,'Day',NULL,'Studio',3),(603,1,'Day',252,'Studio',3),(652,0,'Day',NULL,'Family',7),(702,0,'Night',NULL,'Family',7),(703,1,NULL,NULL,'Balcony',NULL),(709,1,'Day',NULL,'Family',7),(710,1,'Day',NULL,'Family',7);
/*!40000 ALTER TABLE `room` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room_request`
--

DROP TABLE IF EXISTS `room_request`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room_request` (
  `id` int NOT NULL,
  `room_id` int NOT NULL,
  `client_id` int NOT NULL,
  `request_status` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room_request`
--

LOCK TABLES `room_request` WRITE;
/*!40000 ALTER TABLE `room_request` DISABLE KEYS */;
INSERT INTO `room_request` VALUES (303,402,102,'PENDING'),(302,554,252,'APPROVED'),(352,402,102,'PENDING'),(353,402,102,'PENDING'),(354,554,252,'PENDING');
/*!40000 ALTER TABLE `room_request` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room_request_seq`
--

DROP TABLE IF EXISTS `room_request_seq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room_request_seq` (
  `next_val` bigint DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room_request_seq`
--

LOCK TABLES `room_request_seq` WRITE;
/*!40000 ALTER TABLE `room_request_seq` DISABLE KEYS */;
INSERT INTO `room_request_seq` VALUES (451);
/*!40000 ALTER TABLE `room_request_seq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `room_seq`
--

DROP TABLE IF EXISTS `room_seq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `room_seq` (
  `next_val` bigint DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `room_seq`
--

LOCK TABLES `room_seq` WRITE;
/*!40000 ALTER TABLE `room_seq` DISABLE KEYS */;
INSERT INTO `room_seq` VALUES (801);
/*!40000 ALTER TABLE `room_seq` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL,
  `password` varchar(255) DEFAULT NULL,
  `role` varchar(255) DEFAULT NULL,
  `username` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'$2a$12$q6uEwAQbTEat0.7VeRC8hOsFZCle66hRDHcYEyYQiBD1Oq8Ry5zwe','ADMIN','admin'),(2,'$2a$12$iJOC0gB0HKAtHq6u93/HAOgWzcR5uudmg/8j5JeAamylycr/UxA7G','USER','cust1'),(3,'$2a$12$WWwVoIGPrIt7/KkEeb2os.ytO9LQdazZVXvNvDVXeSPj.5jzkork2','USER','cust2');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users_seq`
--

DROP TABLE IF EXISTS `users_seq`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users_seq` (
  `next_val` bigint DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users_seq`
--

LOCK TABLES `users_seq` WRITE;
/*!40000 ALTER TABLE `users_seq` DISABLE KEYS */;
INSERT INTO `users_seq` VALUES (1);
/*!40000 ALTER TABLE `users_seq` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-28 22:24:09
