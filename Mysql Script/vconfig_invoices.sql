-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: vconfig
-- ------------------------------------------------------
-- Server version	8.0.36

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
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoices` (
  `id` int NOT NULL AUTO_INCREMENT,
  `alt_comp_id` varbinary(255) DEFAULT NULL,
  `model_id` int NOT NULL,
  `model_price` int NOT NULL,
  `ordered_qty` int NOT NULL,
  `total_price` int NOT NULL,
  `user_id` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoices`
--

LOCK TABLES `invoices` WRITE;
/*!40000 ALTER TABLE `invoices` DISABLE KEYS */;
INSERT INTO `invoices` VALUES (1,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0-\0\0.',201,15000,3,45000,101),(2,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0\0e\0\0\0g\0\0\0i\0\0\0j\0\0\0f\0\0\0h\0\0\0k',1,5000,9,57600,0),(3,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0\0e\0\0\0g\0\0\0i\0\0\0j\0\0\0f\0\0\0h\0\0\0k',1,5000,9,57600,0),(4,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0\0e\0\0\0g\0\0\0i\0\0\0j\0\0\0f\0\0\0h\0\0\0k',1,5000,9,57600,0),(5,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0\0e\0\0\0g\0\0\0i\0\0\0j\0\0\0f\0\0\0h\0\0\0k',1,5000,9,57600,0),(21,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0\0e\0\0\0g\0\0\0i\0\0\0j\0\0\0f\0\0\0h\0\0\0k',1,5000,9,57600,0),(22,_binary '�\�\0ur\0[IM�`&v겥\0\0xp\0\0\0\0\0\0e\0\0\0g\0\0\0i\0\0\0j\0\0\0f\0\0\0h\0\0\0k',1,5000,9,57600,0);
/*!40000 ALTER TABLE `invoices` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-08-29 21:24:55
