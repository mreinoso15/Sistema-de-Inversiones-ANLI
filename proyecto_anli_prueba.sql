CREATE DATABASE  IF NOT EXISTS `proyecto_anli_prueba` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `proyecto_anli_prueba`;
-- MySQL dump 10.13  Distrib 8.0.31, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto_anli_prueba
-- ------------------------------------------------------
-- Server version	8.0.31

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
-- Table structure for table `depositos`
--

DROP TABLE IF EXISTS `depositos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `depositos` (
  `id_deposito` int NOT NULL AUTO_INCREMENT,
  `id_solicitud` int NOT NULL,
  `cantidad_deposito` double NOT NULL,
  `fecha_aprobacion` date NOT NULL,
  `tasa_inversion` double NOT NULL,
  `estado_interes` tinyint NOT NULL,
  `tipo_deposito` tinyint NOT NULL,
  PRIMARY KEY (`id_deposito`),
  KEY `FK_DEPOSITOS_idx` (`id_solicitud`),
  CONSTRAINT `FK_DEPOSITOS` FOREIGN KEY (`id_solicitud`) REFERENCES `solicitudes_deposito` (`id_solicitud`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `aceptar_transferencia_deposito` AFTER INSERT ON `depositos` FOR EACH ROW BEGIN
	IF new.tipo_deposito < 3 THEN
		UPDATE `usuario` AS u
        INNER JOIN solicitudes_deposito AS sd ON u.id_usuario = sd.id_usuario 
        INNER JOIN depositos AS d ON sd.id_solicitud = d.id_solicitud
		SET u.cantidad_inversion = u.cantidad_inversion + d.cantidad_deposito
        WHERE u.id_usuario = sd.id_usuario;
	END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `retiros`
--

DROP TABLE IF EXISTS `retiros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `retiros` (
  `id_retiro` int NOT NULL AUTO_INCREMENT,
  `id_solicitud` int NOT NULL,
  `cantidad_retiro` double NOT NULL,
  `fecha_aprobacion` date NOT NULL,
  PRIMARY KEY (`id_retiro`),
  KEY `FK_RETIROS_idx` (`id_solicitud`),
  CONSTRAINT `FK_RETIROS` FOREIGN KEY (`id_solicitud`) REFERENCES `solicitudes_retiro` (`id_solicitud`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `solicitudes_deposito`
--

DROP TABLE IF EXISTS `solicitudes_deposito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `solicitudes_deposito` (
  `id_solicitud` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  `cantidad_deposito` double NOT NULL,
  `fecha_deposito` date NOT NULL,
  `estado_deposito` tinyint NOT NULL,
  `no_folio` varchar(45) DEFAULT NULL,
  `url_foto` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`id_solicitud`),
  KEY `FK_SOLICITUD_DEPOSITO_idx` (`id_usuario`),
  CONSTRAINT `FK_SOLICITUD_DEPOSITO` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `aceptar_solicitud_deposito_insert` AFTER INSERT ON `solicitudes_deposito` FOR EACH ROW BEGIN
	DECLARE var_id_tasas INTEGER;
    DECLARE var_valor_tasa DOUBLE;
    
    SET var_id_tasas = (SELECT `id_tasas` FROM `usuario` WHERE `id_usuario` = new.`id_usuario`);
    SET var_valor_tasa = (SELECT `tasa` FROM `tasas_interes` WHERE `id_tasas` = var_id_tasas);
    
	IF new.`estado_deposito` <=> 1 THEN
		INSERT INTO `proyecto_anli_prueba`.`depositos`(`id_solicitud`,`cantidad_deposito`,`fecha_aprobacion`,`tasa_inversion`,`estado_interes`,`tipo_deposito`)
		VALUES(new.`id_solicitud`,new.`cantidad_deposito`,DATE(NOW()),var_valor_tasa,0,1);
    ELSE IF new.`estado_deposito` <=> 3 THEN   
		INSERT INTO `proyecto_anli_prueba`.`depositos`(`id_solicitud`,`cantidad_deposito`,`fecha_aprobacion`,`tasa_inversion`,`estado_interes`,`tipo_deposito`)
		VALUES(new.`id_solicitud`,new.`cantidad_deposito`,DATE(NOW()),var_valor_tasa,0,3);
    END IF;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `aceptar_solicitud_deposito` AFTER UPDATE ON `solicitudes_deposito` FOR EACH ROW BEGIN
	DECLARE var_id_tasas INTEGER;
    DECLARE var_valor_tasa DOUBLE;
    
    SET var_id_tasas = (SELECT `id_tasas` FROM `usuario` WHERE `id_usuario` = old.`id_usuario`);
    SET var_valor_tasa = (SELECT `tasa` FROM `tasas_interes` WHERE `id_tasas` = var_id_tasas);
    
	IF new.`estado_deposito` <=> 1 THEN
		INSERT INTO `proyecto_anli_prueba`.`depositos`(`id_solicitud`,`cantidad_deposito`,`fecha_aprobacion`,`tasa_inversion`,`estado_interes`,`tipo_deposito`)
		VALUES(old.`id_solicitud`,old.`cantidad_deposito`,DATE(NOW()),var_valor_tasa,0,2);
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `solicitudes_retiro`
--

DROP TABLE IF EXISTS `solicitudes_retiro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `solicitudes_retiro` (
  `id_solicitud` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  `tipo_retiro` varchar(100) NOT NULL,
  `fecha_retiro` date NOT NULL,
  `cantidad_retiro` double NOT NULL,
  `estado_retiro` tinyint NOT NULL,
  PRIMARY KEY (`id_solicitud`),
  KEY `FK_SOLICITUD_RETIRO_idx` (`id_usuario`),
  CONSTRAINT `FK_SOLICITUD_RETIRO` FOREIGN KEY (`id_usuario`) REFERENCES `usuario` (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `aceptar_solicitud_retiro` AFTER UPDATE ON `solicitudes_retiro` FOR EACH ROW BEGIN
	IF new.`estado_retiro` <=> 1 THEN
		INSERT INTO `proyecto_anli_prueba`.`retiros`(`id_solicitud`,`cantidad_retiro`,`fecha_aprobacion`)
		VALUES(old.`id_solicitud`,old.`cantidad_retiro`,DATE(NOW()));
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `solicitudes_usuario`
--

DROP TABLE IF EXISTS `solicitudes_usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `solicitudes_usuario` (
  `id_solicitud` int NOT NULL AUTO_INCREMENT,
  `id_usuario` int NOT NULL,
  `nombre_usuario` varchar(100) NOT NULL,
  `estado_solicitud` tinyint NOT NULL,
  `fecha_solicitud` date NOT NULL,
  PRIMARY KEY (`id_solicitud`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `aceptar_solicitud_usuario` AFTER UPDATE ON `solicitudes_usuario` FOR EACH ROW BEGIN
	IF new.`estado_solicitud` <=> 1 THEN
		INSERT INTO `proyecto_anli_prueba`.`usuario`(`id_usuario`,`nombre_usuario`,`fecha_registro`,`cantidad_ahorro`,`cantidad_inversion`,`estatus_usuario`,`id_tasas`)
		VALUES(old.`id_usuario`,old.`nombre_usuario`, DATE(NOW()),0,0,1,1);
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `tasas_interes`
--

DROP TABLE IF EXISTS `tasas_interes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tasas_interes` (
  `id_tasas` int NOT NULL AUTO_INCREMENT,
  `tasa` double NOT NULL,
  `tipo_tasa` varchar(45) NOT NULL,
  `descripcion_tasa` varchar(150) NOT NULL,
  PRIMARY KEY (`id_tasas`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `id_usuario` int NOT NULL,
  `nombre_usuario` varchar(100) NOT NULL,
  `fecha_registro` date NOT NULL,
  `cantidad_ahorro` double DEFAULT NULL,
  `cantidad_inversion` double DEFAULT NULL,
  `estatus_usuario` tinyint NOT NULL,
  `id_tasas` int NOT NULL,
  PRIMARY KEY (`id_usuario`),
  KEY `FK_USUARIO_TASA_idx` (`id_tasas`),
  CONSTRAINT `FK_USUARIO_TASA` FOREIGN KEY (`id_tasas`) REFERENCES `tasas_interes` (`id_tasas`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping events for database 'proyecto_anli_prueba'
--

--
-- Dumping routines for database 'proyecto_anli_prueba'
--
/*!50003 DROP PROCEDURE IF EXISTS `actIntereses` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `actIntereses`()
BEGIN
	#VARIABLES DE CONTROL
	DECLARE n INT ;
	DECLARE i INT ;
    
    #VARIABLES DE OPERACION
    DECLARE FECHA_ACTUAL DATE;
    DECLARE DIF_FECHA INT;
    DECLARE TASA DOUBLE;
    DECLARE CANTIDAD DOUBLE;
    DECLARE TOTAL DOUBLE;
    
    #VARIABLES PARA ACTUALIZACION
    DECLARE var_solicitud_deposito INT;
    DECLARE var_id_usuario INT;
	SELECT COUNT(*) FROM DEPOSITOS INTO n;
SET i=0;
WHILE i<n DO 
	
		SET var_solicitud_deposito = (SELECT `id_solicitud` FROM depositos WHERE `estado_interes` = 0 LIMIT i,1);
        SET var_id_usuario = (SELECT `id_usuario` FROM solicitudes_deposito WHERE `id_solicitud` <=> var_solicitud_deposito);
        SET FECHA_ACTUAL = (SELECT `fecha_aprobacion` FROM depositos WHERE `estado_interes` = 0 LIMIT i,1); 
		SET DIF_FECHA = DATEDIFF(NOW(),FECHA_ACTUAL);
        SET TASA = (SELECT `tasa_inversion` FROM depositos WHERE `estado_interes` = 0 LIMIT i,1); 
        SET CANTIDAD = (SELECT `cantidad_deposito` FROM depositos WHERE `estado_interes` = 0 LIMIT i,1);
        SET TOTAL = (DIF_FECHA*TASA*CANTIDAD)/360;
		UPDATE usuario SET `cantidad_ahorro` = `cantidad_ahorro` + TOTAL WHERE id_usuario = var_id_usuario;
  SET i = i + 1;
END WHILE;
		UPDATE depositos SET `estado_interes` = 1 WHERE `estado_interes` <=> 0;
End ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `insertarNuevoDeposito` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `insertarNuevoDeposito`()
BEGIN
	DECLARE n INT ;
	DECLARE i INT ;
    DECLARE var_id_usuario INT;
	DECLARE AHORRO DOUBLE;
    DECLARE INVERSION DOUBLE;
    DECLARE TOTAL DOUBLE;
    SELECT COUNT(*) FROM usuario INTO n;
SET i=0;
WHILE i<n DO 
		SET var_id_usuario = (SELECT id_usuario FROM usuario LIMIT i,1);
        SET INVERSION = (SELECT cantidad_inversion FROM usuario LIMIT i,1);
        SET AHORRO = (SELECT cantidad_ahorro FROM usuario LIMIT i,1);
		SET TOTAL = INVERSION + AHORRO;
		INSERT INTO `proyecto_anli_prueba`.`solicitudes_deposito`
		(`id_usuario`,`cantidad_deposito`,`fecha_deposito`,`estado_deposito`)
		VALUES(var_id_usuario,TOTAL,DATE(NOW()),3);
	SET i = i + 1;
END WHILE;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-03-13 13:20:36
