-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: bdoccasioncs
-- ------------------------------------------------------
-- Server version	8.0.31

create database if not exists bdoccasioncs;
use bdoccasioncs;

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
-- Table structure for table `compte`
--

DROP TABLE IF EXISTS `compte`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compte` (
  `nom` varchar(24) NOT NULL,
  `mdp` varchar(24) NOT NULL,
  PRIMARY KEY (`nom`,`mdp`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compte`
--

LOCK TABLES `compte` WRITE;
/*!40000 ALTER TABLE `compte` DISABLE KEYS */;
INSERT INTO `compte` VALUES ('0Va1DesCb72ul2g5leFPIw==','0Va1DesCb72ul2g5leFPIw=='),('2vOISz5z3Hs2g+noNCt/ow==','2vOISz5z3Hs2g+noNCt/ow=='),('admin','admin'),('dGadqdFx0kZW5BV/Z/1OXg==','dGadqdFx0kZW5BV/Z/1OXg=='),('n6ISFhte8AohkKkXaBkUAw==','n6ISFhte8AohkKkXaBkUAw=='),('vxVDMIOi0T25vm8DAEKBLg==','vxVDMIOi0T25vm8DAEKBLg==');
/*!40000 ALTER TABLE `compte` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `concessionnaire`
--

DROP TABLE IF EXISTS `concessionnaire`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `concessionnaire` (
  `idConces` int NOT NULL AUTO_INCREMENT,
  `nom` varchar(15) DEFAULT NULL,
  `prenom` varchar(15) DEFAULT NULL,
  `adresse` varchar(50) DEFAULT NULL,
  `codePostal` varchar(5) DEFAULT NULL,
  `ville` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idConces`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `concessionnaire`
--

LOCK TABLES `concessionnaire` WRITE;
/*!40000 ALTER TABLE `concessionnaire` DISABLE KEYS */;
INSERT INTO `concessionnaire` VALUES (1,'Davolio','Jeanne','5 rue de la poste','63000','CLERMONT-FERRAND'),(2,'Fuller','Philippe','254 avenue Berthelot','63000','CLERMONT-FERRAND'),(3,'Darverling','Laura','1 place de Jaude','63000','CLERMONT-FERRAND'),(4,'Peacock','Emilie','23 Impasse des Fleurs','63000','CLERMONT-FERRAND'),(5,'Buchanan','Pierre','32 place de L\"Hotel de Ville','63200','RIOM'),(6,'Bucyama','Michel','15 rue des pinsons','63200','RIOM'),(7,'King','Louis','57 rue de la gare','63500','ISSOIRE'),(8,'Callahan','Jean','23 boulevard Central','63500','ISSOIRE'),(9,'Bucsworth','Pierre','7 rue de la paix','63500','ISSOIRE');
/*!40000 ALTER TABLE `concessionnaire` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-05-10 20:43:17
