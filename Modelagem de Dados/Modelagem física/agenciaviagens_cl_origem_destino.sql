-- MySQL dump 10.13  Distrib 8.0.12, for macos10.13 (x86_64)
--
-- Host: 127.0.0.1    Database: agenciaviagens
-- ------------------------------------------------------
-- Server version	8.0.12

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
-- Table structure for table `cl_origem_destino`
--

DROP TABLE IF EXISTS `cl_origem_destino`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `cl_origem_destino` (
  `cod_cl_origem_destino` int(11) NOT NULL AUTO_INCREMENT,
  `Id_cliente` int(11) DEFAULT NULL,
  `id_origem` int(11) DEFAULT NULL,
  `id_destino` int(11) DEFAULT NULL,
  `data_embarque` date DEFAULT NULL,
  `data_retorno` date DEFAULT NULL,
  `valor_total` float GENERATED ALWAYS AS ((300 + 400)) STORED,
  PRIMARY KEY (`cod_cl_origem_destino`),
  UNIQUE KEY `cod_cl_origem_destino_UNIQUE` (`cod_cl_origem_destino`),
  KEY `cod_cliente_idx` (`Id_cliente`),
  KEY `cod_destino_idx` (`id_destino`),
  KEY `cod_origem_idx` (`id_origem`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cl_origem_destino`
--

LOCK TABLES `cl_origem_destino` WRITE;
/*!40000 ALTER TABLE `cl_origem_destino` DISABLE KEYS */;
INSERT INTO `cl_origem_destino` (`cod_cl_origem_destino`, `Id_cliente`, `id_origem`, `id_destino`, `data_embarque`, `data_retorno`) VALUES (1,1,1,1,'2012-02-12','2012-02-20'),(2,2,1,2,'2020-12-12','2021-12-12');
/*!40000 ALTER TABLE `cl_origem_destino` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-20 11:31:07
