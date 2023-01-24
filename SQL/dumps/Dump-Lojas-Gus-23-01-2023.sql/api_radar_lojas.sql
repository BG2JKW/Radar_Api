-- MySQL dump 10.13  Distrib 8.0.28, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: api_radar
-- ------------------------------------------------------
-- Server version	8.0.28

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
-- Table structure for table `lojas`
--

DROP TABLE IF EXISTS `lojas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lojas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(150) NOT NULL,
  `observacao` varchar(155) DEFAULT NULL,
  `cep` varchar(45) NOT NULL,
  `logradouro` varchar(45) NOT NULL,
  `numero` varchar(8) NOT NULL,
  `bairro` varchar(45) NOT NULL,
  `cidade` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `complemento` varchar(255) DEFAULT NULL,
  `latitude` float NOT NULL,
  `longitude` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lojas`
--

LOCK TABLES `lojas` WRITE;
/*!40000 ALTER TABLE `lojas` DISABLE KEYS */;
INSERT INTO `lojas` VALUES (1,'Farmarcas',NULL,'01311-000','Avenida Paulista','2300','Bela Vista','São Paulo','SP',NULL,-23.5567,-46.6612),(2,'Itaim Bibi Loja',NULL,'01406-100','Avenida Nove de Julho','2300','Jardim Paulista','São Paulo','SP',NULL,-23.5838,-46.6781),(3,'Ultra Popular','Whatsapp: (11)92011-8532','05005-000','Rua Turiassu','390','Perdizes','São Paulo','SP','lado par',-23.5326,-46.6718),(4,'Ultra Popular','Delivery: (21)98014-3350 Whatsapp: (21)98014-3350','23042-500','Estrada das Agulhas Negras','101','Campo Grande','Rio de Janeiro','RJ','',-19.7507,-40.3799),(5,'Ultra Popular','Unidade de Alagoas','57300-340','Rua Quinze de Novembro','74','Centro','Arapiraca','AL','até 99997/99998',-9.75363,-36.6568),(6,'Super Popular','Delivery: (19)99164-5141 Segunda à Sexta: 08h às 22h Sábado: 08h às 20h Domingo e feriados: 08h às 20h','13181-680','Rua José Vedovatto','2275','Jardim Bom Retiro (Nova Veneza)','Sumaré','SP','',-22.8427,-47.1897),(7,'Super Popular','Delivery: (19)99164-5141 Segunda à Sexta: 07h às 20h Sábado: 07h às 17h Domingo e feriados: Não abre','13013-070','Rua Álvares Machado','678','Centro','Campinas','SP','até 620/621',-15.5427,-55.1509),(8,'Super Popular','Delivery: (11)99353-5564 Segunda à Sexta: 08h às 21h Sábado: 08h às 20h Domingo e feriados: 08h às 20h','02611-001','Avenida Parada Pinto','63','Vila Nova Cachoeirinha','São Paulo','SP','de 1502 ao fim - lado par',-23.4703,-46.6493),(9,'Maxi Popular','Whatsapp: (65)99979-9111','78145-900','Avenida Frei Coimbra','','Ikaray','Várzea Grande','MT','s/n',0,0),(10,'Maxi Popular',NULL,'54735-470','Rua Cleto Campelo','5','Centro','São Lourenço da Mata','PE','',-8.06259,-34.8795),(11,'Entrefarma','Delivery: (31)3464-3421 Whatsapp: (31)98652-1368','30770-160','Rua Icaraí','549','Caiçaras','Belo Horizonte','MG','até 529/530',-19.9077,-43.9695),(12,'Entrefarma','Delivery: (31)3731-1383 Whatsapp: (31)3731-1383','36410-064','Praça Presidente Kubitschek','164','Centro','Congonhas','MG','',-14.235,-51.9253),(13,'BigFort','Whatsapp: (61)99907-6565','70855-510','CLN 407 Bloco A','407','Asa Norte','Brasília','DF','',-15.766,-47.8788),(14,'BigFort',NULL,'08750-580','Rua Professora Lucinda Bastos','919','Jundiapeba','Mogi das Cruzes','SP','de 1200/1201 a 1598/1599',-23.549,-46.254),(15,'Mega Pharma','Telefone: (83) 99113-5645','58700-010','Rua do Prado','545','Centro','Patos','PB','',-7.03151,-37.2909),(16,'Drogaria Maestra','Whatsapp: (19)98935-5581','13289-158','Rua Anésio Augusto do Amaral','249','Santa Rosa','Vinhedo','SP','(Jardim Santa Rosa)',-14.235,-51.9253);
/*!40000 ALTER TABLE `lojas` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-23 23:03:35
