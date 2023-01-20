SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

CREATE SCHEMA IF NOT EXISTS `api_radar` DEFAULT CHARACTER SET utf8 ;
USE `api_radar` ;

CREATE TABLE IF NOT EXISTS `api_radar`.`Cadastros` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(155) NOT NULL,
   `email` VARCHAR(155) NOT NULL,
  `senha` VARCHAR(155) NULL,
  `permissao` VARCHAR(20) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `api_radar`.`Produtos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(155) NOT NULL,
  `descricao` LONGTEXT NULL,
  `valor` FLOAT NULL,
  `qtd_estoque` INT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `api_radar`.`Clientes` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `telefone` VARCHAR(45) NULL,
  `email` VARCHAR(55) NOT NULL,
  `cpf` VARCHAR(16) NOT NULL,
  `cep` VARCHAR(45) NULL,
  `logradouro` VARCHAR(45) NULL,
  `numero` VARCHAR(8) NULL,
  `bairro` VARCHAR(45) NULL,
  `cidade` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  `complemento` VARCHAR(255) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `cpf_UNIQUE` (`cpf` ASC) VISIBLE)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `api_radar`.`Pedidos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `valor_total` FLOAT NULL,
  `data` DATETIME NOT NULL,
  `Cliente_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_Pedidos_Clientes1_idx` (`Cliente_id` ASC) VISIBLE,
  CONSTRAINT `fk_Pedidos_Clientes1`
    FOREIGN KEY (`Cliente_id`)
    REFERENCES `api_radar`.`Clientes` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `api_radar`.`PedidosProdutos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `valor` FLOAT NULL,
  `quantidade` INT NULL,
  `Produto_id` INT NOT NULL,
  `Pedido_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_PedidosProdutos_Produtos_idx` (`Produto_id` ASC) VISIBLE,
  INDEX `fk_PedidosProdutos_Pedidos1_idx` (`Pedido_id` ASC) VISIBLE,
  CONSTRAINT `fk_PedidosProdutos_Produtos`
    FOREIGN KEY (`Produto_id`)
    REFERENCES `api_radar`.`Produtos` (`id`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_PedidosProdutos_Pedidos1`
    FOREIGN KEY (`Pedido_id`)
    REFERENCES `api_radar`.`Pedidos` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `api_radar`.`Campanhas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(55) NULL,
  `descricao` LONGTEXT NULL,
  `data` DATETIME NULL,
  `url_foto_prateleira` LONGTEXT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `api_radar`.`PosicoesProdutos` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `posicao_x` FLOAT NULL,
  `posicao_y` FLOAT NULL,
  `Produto_id` INT NOT NULL,
  `Campanha_id` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_PosicoesProdutos_Produtos1_idx` (`Produto_id` ASC) VISIBLE,
  INDEX `fk_PosicoesProdutos_Campanhas1_idx` (`Campanha_id` ASC) VISIBLE,
  CONSTRAINT `fk_PosicoesProdutos_Produtos1`
    FOREIGN KEY (`Produto_id`)
    REFERENCES `api_radar`.`Produtos` (`id`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,
  CONSTRAINT `fk_PosicoesProdutos_Campanhas1`
    FOREIGN KEY (`Campanha_id`)
    REFERENCES `api_radar`.`Campanhas` (`id`)
    ON DELETE CASCADE
    ON UPDATE CASCADE)
ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS `api_radar`.`Lojas` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(55) NULL,
  `observacao` VARCHAR(155) NULL,
  `cep` VARCHAR(45) NULL,
  `logradouro` VARCHAR(45) NULL,
  `numero` VARCHAR(8) NULL,
  `bairro` VARCHAR(45) NULL,
  `cidade` VARCHAR(45) NULL,
  `estado` VARCHAR(45) NULL,
  `complemento` VARCHAR(255) NULL,
  `latitude` FLOAT NULL,
  `longitude` FLOAT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;


