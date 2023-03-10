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
-- Table structure for table `cadastros`
--

DROP TABLE IF EXISTS `cadastros`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cadastros` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(155) NOT NULL,
  `email` varchar(155) NOT NULL,
  `senha` varchar(155) NOT NULL,
  `permissao` varchar(20) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cadastros`
--

LOCK TABLES `cadastros` WRITE;
/*!40000 ALTER TABLE `cadastros` DISABLE KEYS */;
INSERT INTO `cadastros` VALUES (1,'Jasmine','jasmine@email.com','123456','adm'),(2,'Gustavo','gustavo@email.com','789456','editor');
/*!40000 ALTER TABLE `cadastros` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `campanhas`
--

DROP TABLE IF EXISTS `campanhas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `campanhas` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(55) NOT NULL,
  `descricao` longtext NOT NULL,
  `data` datetime NOT NULL,
  `url_foto_prateleira` longtext NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `campanhas`
--

LOCK TABLES `campanhas` WRITE;
/*!40000 ALTER TABLE `campanhas` DISABLE KEYS */;
/*!40000 ALTER TABLE `campanhas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `clientes`
--

DROP TABLE IF EXISTS `clientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clientes` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(45) NOT NULL,
  `telefone` varchar(45) DEFAULT NULL,
  `email` varchar(55) NOT NULL,
  `cpf` varchar(16) NOT NULL,
  `cep` varchar(45) NOT NULL,
  `logradouro` varchar(150) DEFAULT NULL,
  `numero` varchar(20) DEFAULT NULL,
  `bairro` varchar(90) DEFAULT NULL,
  `cidade` varchar(45) NOT NULL,
  `estado` varchar(45) NOT NULL,
  `complemento` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf_UNIQUE` (`cpf`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clientes`
--

LOCK TABLES `clientes` WRITE;
/*!40000 ALTER TABLE `clientes` DISABLE KEYS */;
INSERT INTO `clientes` VALUES (1,'Daniel Gon??alves','(11)91234-5678','dani_gon@email.com','877.017.977-85','25233-080','Rua Guiomar de Albuquerque','2300','Pilar','Duque de Caxias','Rio de Janeiro',NULL),(2,'Daniela Almeida','(11)91234-5678','dani_alm@email.com','163.491.221-78','79073-741','Travessa Juan Villarrodona','2300','Centro Oeste','Campo Grande','Mato Grosso do Sul',NULL),(3,'Jaziel Jazes','(11)91234-5678','jaziel@email.com','939.532.688-30','04545-041','Rua Santa Justina','2300','Vila Ol??mpia','S??o Paulo','S??o Paulo',NULL),(4,'Leonardo Aric??','(11)91234-5678','leoleo@email.com','022.815.508-85','05883-000','Rua Ros??rio Scamardi','2300','Jardim do Col??gio','S??o Paulo','S??o Paulo',NULL),(5,'Antony Aric??','(11)91234-5678','antant@email.com','589.308.068-80','05883-000','Rua Ros??rio Scamardi','2300','Jardim do Col??gio','S??o Paulo','S??o Paulo',NULL),(6,'Amanda Silva','(11)98546-3214','mandy@email.com','123.456.987-78','04207-906','Rua dos Patriotas','1065','Ipiranga','S??o Paulo','SP','517'),(7,'Luiza Mendes','(63)97896-3654','lulu@email.com','718.862.758-40','77435-300','Rua C-016','200','Setor Morada do Sol','Gurupi','TO',''),(8,'Mario Souza','(92)98563-1236','souzamario@email.com','346.392.911-24','69039-210','Rua Arthur de Souza','60','Novo Israel','Manaus','AM','casa 2'),(9,'Mariana Fernandes','(66)98523-6974','mafe@email.com','041.805.467-36','78710-185','Rua Bar??o do Rio Branco','369','Jardim Guanabara','Rondon??polis','MT',''),(10,'Carlos Matos','(82)96321-4857','matos@email.com','969.868.597-91','57081-170','Rua Newton Alves Coelho','40','Tabuleiro do Martins','Macei??','AL','casa 3'),(11,'Lucas Amorim','(64)97896-5237','lucas@email.com','746.565.941-80','75800-134','Rua Gumercindo Ferreira','1200','Vila Santa Maria','Jata??','GO','Apt 50 Bloco C'),(12,'Eduardo Hernandes','(63)96357-4129','edu@email.com','443.736.633-60','77015-010','Quadra ACSU SO 10 Avenida LO 3','702','Plano Diretor Sul','Palmas','TO','Apt 7 '),(13,'Diego Santos','(62)96325-7841','disantos@email.com','205.883.548-48','74369-137','Rua CV37','60','Parque das Paineiras (1,2,3 e 4 Etapa)','Goi??nia','GO','Quadra 7 Lote 10'),(14,'Rosa Teresa Silva','(79)96325-8741','roteresa@email.com','743.059.560-04','49085-410','Rua Sime??o Aguiar','80','Jos?? Conrado de Ara??jo','Aracaju','SE',''),(15,'Ana Francisca Moura','(11)96321-7548','fran@email.com','448.200.667-06','13234-431','Rua Vanessa','100','Condom??nio Cerro Azul','Campo Limpo Paulista','SP','Apt 30 Bloco D'),(16,'Renata Lima','(67)96547-7895','relima@email.com','277.252.378-01','79016-100','Rua Ant??nio Cl??udio de Lima','45','Nova Lima','Campo Grande','MS',''),(17,'Fernando Camargo','(99)97854-7896','fernando@email.com','441.238.573-61','69097-570','Travessa Contenda','7','Novo Aleixo','Manaus','AM',''),(18,'N??bia Bernardes ','(91)96321-7458','nube@email.com','035.870.658-02','68372-066','Rua Manoel Amorim','10','Jardim Independente I','Altamira','PA',''),(19,'Denis Moreira ','(22)97852-7415','denis@email.com','862.589.813-05','25525-220','Rua Miguel Arcanjo','90','Vila Tiradentes','S??o Jo??o de Meriti','RJ',''),(20,'Luciana Pereira','(11)96325-8521','lupe@email.com','818.711.481-97','06335-040','Rua Pedran??polis','87','Jardim Bom Sucesso','Carapicu??ba','SP','');
/*!40000 ALTER TABLE `clientes` ENABLE KEYS */;
UNLOCK TABLES;

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
INSERT INTO `lojas` VALUES (1,'Farmarcas',NULL,'01311-000','Avenida Paulista','2300','Bela Vista','S??o Paulo','SP',NULL,-23.5567,-46.6612),(2,'Itaim Bibi Loja',NULL,'01406-100','Avenida Nove de Julho','2300','Jardim Paulista','S??o Paulo','SP',NULL,-23.5838,-46.6781),(3,'Ultra Popular','Whatsapp: (11)92011-8532','05005-000','Rua Turiassu','390','Perdizes','S??o Paulo','SP','lado par',-23.5326,-46.6718),(4,'Ultra Popular','Delivery: (21)98014-3350 Whatsapp: (21)98014-3350','23042-500','Estrada das Agulhas Negras','101','Campo Grande','Rio de Janeiro','RJ','',-19.7507,-40.3799),(5,'Ultra Popular','Unidade de Alagoas','57300-340','Rua Quinze de Novembro','74','Centro','Arapiraca','AL','at?? 99997/99998',-9.75363,-36.6568),(6,'Super Popular','Delivery: (19)99164-5141 Segunda ?? Sexta: 08h ??s 22h S??bado: 08h ??s 20h Domingo e feriados: 08h ??s 20h','13181-680','Rua Jos?? Vedovatto','2275','Jardim Bom Retiro (Nova Veneza)','Sumar??','SP','',-22.8427,-47.1897),(7,'Super Popular','Delivery: (19)99164-5141 Segunda ?? Sexta: 07h ??s 20h S??bado: 07h ??s 17h Domingo e feriados: N??o abre','13013-070','Rua ??lvares Machado','678','Centro','Campinas','SP','at?? 620/621',-15.5427,-55.1509),(8,'Super Popular','Delivery: (11)99353-5564 Segunda ?? Sexta: 08h ??s 21h S??bado: 08h ??s 20h Domingo e feriados: 08h ??s 20h','02611-001','Avenida Parada Pinto','63','Vila Nova Cachoeirinha','S??o Paulo','SP','de 1502 ao fim - lado par',-23.4703,-46.6493),(9,'Maxi Popular','Whatsapp: (65)99979-9111','78145-900','Avenida Frei Coimbra','','Ikaray','V??rzea Grande','MT','s/n',0,0),(10,'Maxi Popular',NULL,'54735-470','Rua Cleto Campelo','5','Centro','S??o Louren??o da Mata','PE','',-8.06259,-34.8795),(11,'Entrefarma','Delivery: (31)3464-3421 Whatsapp: (31)98652-1368','30770-160','Rua Icara??','549','Cai??aras','Belo Horizonte','MG','at?? 529/530',-19.9077,-43.9695),(12,'Entrefarma','Delivery: (31)3731-1383 Whatsapp: (31)3731-1383','36410-064','Pra??a Presidente Kubitschek','164','Centro','Congonhas','MG','',-14.235,-51.9253),(13,'BigFort','Whatsapp: (61)99907-6565','70855-510','CLN 407 Bloco A','407','Asa Norte','Bras??lia','DF','',-15.766,-47.8788),(14,'BigFort',NULL,'08750-580','Rua Professora Lucinda Bastos','919','Jundiapeba','Mogi das Cruzes','SP','de 1200/1201 a 1598/1599',-23.549,-46.254),(15,'Mega Pharma','Telefone: (83) 99113-5645','58700-010','Rua do Prado','545','Centro','Patos','PB','',-7.03151,-37.2909),(16,'Drogaria Maestra','Whatsapp: (19)98935-5581','13289-158','Rua An??sio Augusto do Amaral','249','Santa Rosa','Vinhedo','SP','(Jardim Santa Rosa)',-14.235,-51.9253);
/*!40000 ALTER TABLE `lojas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidos`
--

DROP TABLE IF EXISTS `pedidos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `valor_total` float NOT NULL,
  `data` datetime NOT NULL,
  `Cliente_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_Pedidos_Clientes1_idx` (`Cliente_id`),
  CONSTRAINT `fk_Pedidos_Clientes1` FOREIGN KEY (`Cliente_id`) REFERENCES `clientes` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidos`
--

LOCK TABLES `pedidos` WRITE;
/*!40000 ALTER TABLE `pedidos` DISABLE KEYS */;
INSERT INTO `pedidos` VALUES (1,164.21,'2023-01-20 00:00:00',1),(2,32.96,'2023-01-21 00:00:00',2),(3,32.96,'2023-01-21 00:00:00',1),(4,59.52,'2023-01-23 00:00:00',6),(5,145.95,'2023-01-23 00:00:00',7),(6,19.74,'2023-01-23 00:00:00',8),(7,184.98,'2023-01-23 00:00:00',9),(8,59.39,'2023-01-23 00:00:00',8),(9,95.08,'2023-01-23 00:00:00',9),(10,31.81,'2023-01-23 00:00:00',10),(11,67.68,'2023-01-23 00:00:00',11),(12,37.9,'2023-01-23 00:00:00',12),(13,116.22,'2023-01-23 00:00:00',13),(14,539.69,'2023-01-23 00:00:00',14),(15,56.11,'2023-01-23 00:00:00',15),(16,89.9,'2023-01-23 00:00:00',16),(17,32.9,'2023-01-23 00:00:00',17),(18,22.49,'2023-01-23 00:00:00',18),(19,74.76,'2023-01-23 00:00:00',19),(20,63.08,'2023-01-23 00:00:00',20),(21,61.79,'2023-01-23 00:00:00',16),(22,18.9,'2023-01-23 00:00:00',1),(23,40.62,'2023-01-23 00:00:00',5),(24,89.9,'2023-01-23 00:00:00',14);
/*!40000 ALTER TABLE `pedidos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedidosprodutos`
--

DROP TABLE IF EXISTS `pedidosprodutos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pedidosprodutos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `valor` float NOT NULL,
  `quantidade` int NOT NULL,
  `Produto_id` int NOT NULL,
  `Pedido_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_PedidosProdutos_Produtos_idx` (`Produto_id`),
  KEY `fk_PedidosProdutos_Pedidos1_idx` (`Pedido_id`),
  CONSTRAINT `fk_PedidosProdutos_Pedidos1` FOREIGN KEY (`Pedido_id`) REFERENCES `pedidos` (`id`),
  CONSTRAINT `fk_PedidosProdutos_Produtos` FOREIGN KEY (`Produto_id`) REFERENCES `produtos` (`id`) ON DELETE RESTRICT
) ENGINE=InnoDB AUTO_INCREMENT=33 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedidosprodutos`
--

LOCK TABLES `pedidosprodutos` WRITE;
/*!40000 ALTER TABLE `pedidosprodutos` DISABLE KEYS */;
INSERT INTO `pedidosprodutos` VALUES (1,65.92,2,10,1),(2,75.8,2,9,1),(3,22.49,1,8,1),(4,32.96,1,10,2),(5,32.96,1,10,3),(6,18.9,1,12,4),(7,84.9,1,4,5),(8,19.74,3,6,6),(9,61.79,1,1,7),(10,41.8,2,2,8),(11,61.79,1,1,9),(12,22.49,1,8,10),(13,15.49,1,7,11),(14,37.9,1,9,11),(15,89.9,1,3,11),(16,26.32,4,6,11),(17,179.8,2,3,11),(18,169.8,2,4,11),(19,91.8,2,5,11),(20,22.49,1,8,11),(21,75.8,2,9,11),(22,20.31,1,14,11),(23,89.9,1,3,11),(24,32.9,5,6,11),(25,22.49,1,8,11),(26,41.8,2,2,11),(27,32.96,1,10,11),(28,33.48,4,17,11),(29,61.79,1,1,11),(30,18.9,1,12,11),(31,40.62,2,14,11),(32,89.9,1,3,11);
/*!40000 ALTER TABLE `pedidosprodutos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posicoesprodutos`
--

DROP TABLE IF EXISTS `posicoesprodutos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posicoesprodutos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `posicao_x` float NOT NULL,
  `posicao_y` float NOT NULL,
  `Produto_id` int NOT NULL,
  `Campanha_id` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_PosicoesProdutos_Produtos1_idx` (`Produto_id`),
  KEY `fk_PosicoesProdutos_Campanhas1_idx` (`Campanha_id`),
  CONSTRAINT `fk_PosicoesProdutos_Campanhas1` FOREIGN KEY (`Campanha_id`) REFERENCES `campanhas` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_PosicoesProdutos_Produtos1` FOREIGN KEY (`Produto_id`) REFERENCES `produtos` (`id`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posicoesprodutos`
--

LOCK TABLES `posicoesprodutos` WRITE;
/*!40000 ALTER TABLE `posicoesprodutos` DISABLE KEYS */;
/*!40000 ALTER TABLE `posicoesprodutos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `produtos`
--

DROP TABLE IF EXISTS `produtos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produtos` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(155) NOT NULL,
  `descricao` longtext,
  `valor` float NOT NULL,
  `qtd_estoque` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produtos`
--

LOCK TABLES `produtos` WRITE;
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` VALUES (1,'COL??RIO HYABAK 0,15% 10ML','HIALURONATO DE SODIO,HIALURONATO SODICO,SODIUM HYALURONATE',61.79,346),(2,'SUPLEMENTO VITAM??NICO VITASAY IMUNE D TRIP 10 COMPRIMIDOS EFERVESCENTES','Auxilia o sistema imune; Sabor laranja; Rico em Vitamina C, D e Zinco; Zero adi????o de a????cares.',20.9,304),(3,'PROTETOR SOLAR FACIAL VICHY ID??AL SOLEIL CLARIFY COR CLARA FPS 60 40G','Protetor solar facial com cor para peles claras, FPS 60; Alta prote????o UVA, UVB e luz vis??vel; \nTextura gel creme com toque seco, para uso di??rio; Previne o envelhecimento precoce da pele; Ideal para peles mistas e oleosas.',89.9,432),(4,'GEL DE LIMPEZA FACIAL LA ROCHE-POSAY EFFACLAR ALTA TOLER??NCIA 300G','Limpeza suave e purificante; Ideal para peles oleosas, sens??veis e sensibilizadas; Textura em gel; Antioleosidade; Hipoalerg??nico.',84.9,340),(5,'SABONETE EM BARRA LA ROCHE-POSAY EFFACLAR CONCENTRADO COM 70G','Sabonete facial em barra; Limpeza profunda antioleosidade; Desobstrui os poros; Ideal para peles oleosas e acneicas; \nDesenvolvido para pele brasileira.',45.9,326),(6,'DIPIRONA MONOIDRATADA 500MG 10 COMPRIMIDOS EMS GEN??RICO','A Dipirona S??dica ?? indicada como analg??sico e antit??rmico. Utilizada tamb??m em estados febris e dolorosos.',6.58,203),(7,'SIMETICONA 125MG 10 C??PSULAS CIMED GEN??RICO','Simeticona atua no est??mago e no intestino, diminuindo a tens??o superficial dos l??quidos digestivos, levando ao rompimento das bolhas(gases).',15.49,442),(8,'DESODORANTE REXONA CLINICAL CLASSIC ANTITRANSPIRANTE EM CREME 48G','Protege 3x mais contra a transpira????o excessiva; Conta com tecnologia TriSolid; Combatendo o suor e o mau odor; \nProporciona at?? 48h de hidrata????o e seguran??a; Testado dermatologicamente.',22.49,55),(9,'KIT ESCOVA DE DENTE COLGATE SLIM SOFT BLACK COM 4 UNIDADES','Cerdas com pontas ultrafinas que removem as part??culas mais dif??ceis entre os dentes e as gengivas; Promove uma limpeza profunda e delicada; \nRemove 88% da placa em apenas 1 escova????o; Cerdas macias com infus??o de carv??o.',37.9,444),(10,'DORFLEX DIPIRONA S??DICA 300MG + CITRATO DE ORFENADRINA 35MG + CAFE??NA 50MG 50 COMPRIMIDOS','Dorflex age na dor e relaxa a tens??o muscular causada pela m?? postura e movimentos repetitivos;  \nUma potente combina????o de analg??sico e relaxante muscular dispon??vel em vers??es de 10, 24, 36, 50 comprimidos e gotas.',32.96,493),(11,'Bacinantrat','Bacinantrat ?? um medicamento indicado para o tratamento de infec????es da pele e/ou de mucosas, causadas por diferentes bact??rias, Nas ???dobras??? da pele, ao redor dos pelos, na parte de fora da orelha, nos fur??nculos, nas les??es com pus, na acne infectada, nas feridas abertas (como ??lceras na pele) e nas queimaduras de pele.  Bacinantrat?? tamb??m ?? indicado para prevenir infec????es de pele e/ou de mucosas ap??s ferimentos, cortes (inclusive de cirurgias) e queimaduras pequenas.',4.66,500),(12,'Buscopan Composto','O Buscopan Composto ?? indicado para o alivio da dor, c??licas e desconforto abdominal, em adultos e crian??as, que pode ser encontrado em gotas, comprimidos ou injet??vel',18.9,390),(13,'Cetoconazol Shampoo','Cetoconazol ?? indicado para o tratamento de certas infec????es causadas por fungos',17.59,424),(14,'Cataflam','Entorses, distens??es e outras les??es, Dor e inflama????o no p??s-operat??rio, Condi????es inflamat??rias dolorosas em ginecologia, Infec????es do ouvido, nariz e garganta.',20.31,200),(15,'Baclofen','Baclofen ?? usado para reduzir e aliviar a rigidez excessiva e/ou espasmos nos m??sculos que podem ocorrer em v??rias condi????es tais como a esclerose m??ltipla, doen??as ou les??es na medula ??ssea, e certas doen??as cerebrais.',4.9,120),(16,'C Platin','C-Platin ?? um medicamento antineopl??sico, cujo princ??pio ativo ?? a cisplatina, que inibe a s??ntese do DNA, as s??nteses de prote??nas e RNA. ',35.8,350),(17,'Maizher','Maizher (cloridrato de memantina) ?? indicado para o tratamento da doen??a de Alzheimer moderada a grave.',8.37,450),(18,'Farmazol','Est?? indicado para o tratamento das seguintes condi????es:Candid??ase vaginal aguda e recorrente e balanites por C??ndida, bem como profilaxia para reduzir a incid??ncia de candid??ase vaginal recorrente (3 ou mais epis??dios por ano). Dermatomicoses incluindo Tinea pedis, Tinea corporis, Tinea cruris, Tinea ungulum (onicomicoses) e infec????es por C??ndida.',10.7,650),(19,'Narisoro','Descongestionante, umidificante e fluidificante.',19.78,399),(20,'Pamelor','Pamelor tem como princ??pio ativo o cloridrato de nortriptilina que ?? um antidepressivo.',11.07,190),(21,'Zemaira','Zemaira ?? utilizado em adultos com uma defici??ncia conhecida da alfa1antitripsina grave, uma doen??a heredit??ria tamb??m chamada de defici??ncia de alfa1antitripsina, que desenvolveu uma doen??a pulmonar chamada enfisema.',20.87,520),(22,'Cabertrix','Tratamento do aumento de prolactina (horm??nio respons??vel pela produ????o de leite), bem como de disfun????es associadas ?? hiperprolactinemia (aumento dos n??veis de prolactina), como amenorreia (aus??ncia de menstrua????o), oligomenorreia (redu????o do fluxo ou da frequ??ncia da menstrua????o), anovula????o (aus??ncia de ovula????o) e galactorreia (produ????o de leite fora do per??odo de gesta????o e lacta????o).',78.99,276),(23,'Advil Mulher','Indica????oC??licas menstruais, dor de cabe??a, dor nas costas e enxaqueca.Contra Indica????oDeve-se levar em considera????o a rela????o risco-benef??cio antes de iniciar o tratamento para pacientes com as seguintes condi????es: hist??ria de doen??a ulcerosa p??ptica, sangramento ou perfura????o gastrintestinal, disfun????o renal, cirrose, asma, ou outras afec????es al??rgicas, hipertens??o ou cardiopatia agravada por reten????o h??drica e edema, disfun????o hep??tica, hist??ria de dist??rbios da coagula????o ou l??pus eritematoso sist??mico, ou que estejam utilizando outros AINEs.',21.49,462),(24,'Advil 12h','Advil 12h fornece al??vio r??pido e de longa dura????o para as seguintes dores, por at?? 12 horas: dores de cabe??a, incluindo dor de cabe??a tensional e dor de enxaqueca; Al??vio tempor??rio de dores de leve a moderada intensidade, tais como: musculares (mialgia), nas articula????es (artralgia), nas costas (lombalgia), de gripe e resfriados comuns, dor de dente e de extra????es dent??rias, e dor menstrual; Al??vio de dores associadas a: inflama????o da garganta, dor p??s-traum??tica, (contus??o, hematomas), excesso de esfor??o f??sico, les??es leves oriundas da pr??tica esportiva, entorses, distens??es, tendinites. Advil 12h tamb??m est?? indicado para diminui????o da febre com dura????o por mais de 6 horas.',33.29,245);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `v_clientes_estados`
--

DROP TABLE IF EXISTS `v_clientes_estados`;
/*!50001 DROP VIEW IF EXISTS `v_clientes_estados`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_clientes_estados` AS SELECT 
 1 AS `estado`,
 1 AS `qtd_clientes`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_pedidos_estados`
--

DROP TABLE IF EXISTS `v_pedidos_estados`;
/*!50001 DROP VIEW IF EXISTS `v_pedidos_estados`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_pedidos_estados` AS SELECT 
 1 AS `estado`,
 1 AS `valor_total_faturado`,
 1 AS `qtd_pedidos`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `v_produtos_info`
--

DROP TABLE IF EXISTS `v_produtos_info`;
/*!50001 DROP VIEW IF EXISTS `v_produtos_info`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `v_produtos_info` AS SELECT 
 1 AS `nome`,
 1 AS `qtd_total_vendida`,
 1 AS `faturamento_total`,
 1 AS `qtd_estoque`*/;
SET character_set_client = @saved_cs_client;

--
-- Final view structure for view `v_clientes_estados`
--

/*!50001 DROP VIEW IF EXISTS `v_clientes_estados`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_clientes_estados` AS select `cli`.`estado` AS `estado`,count(0) AS `qtd_clientes` from `clientes` `cli` group by `cli`.`estado` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_pedidos_estados`
--

/*!50001 DROP VIEW IF EXISTS `v_pedidos_estados`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_pedidos_estados` AS select `cli`.`estado` AS `estado`,sum(`ped`.`valor_total`) AS `valor_total_faturado`,count(`ped`.`id`) AS `qtd_pedidos` from (`pedidos` `ped` join `clientes` `cli` on((`ped`.`Cliente_id` = `cli`.`id`))) group by `cli`.`estado` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `v_produtos_info`
--

/*!50001 DROP VIEW IF EXISTS `v_produtos_info`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `v_produtos_info` AS select `pro`.`nome` AS `nome`,sum(`pp`.`quantidade`) AS `qtd_total_vendida`,`pp`.`valor` AS `faturamento_total`,`pro`.`qtd_estoque` AS `qtd_estoque` from (`pedidosprodutos` `pp` join `produtos` `pro` on((`pp`.`Produto_id` = `pro`.`id`))) group by `pp`.`Produto_id` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-01-23 23:01:53
