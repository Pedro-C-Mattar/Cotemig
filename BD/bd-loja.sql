-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema bd_loja
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bd_loja
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bd_loja` DEFAULT CHARACTER SET utf8 ;
USE `bd_loja` ;

-- -----------------------------------------------------
-- Table `bd_loja`.`Clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_loja`.`Clientes` (
  `idClientes` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  `cidade` VARCHAR(45) NULL,
  PRIMARY KEY (`idClientes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bd_loja`.`Produtos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_loja`.`Produtos` (
  `idProdutos` INT NOT NULL AUTO_INCREMENT,
  `descricao` VARCHAR(45) NULL,
  `valor` VARCHAR(45) NULL,
  PRIMARY KEY (`idProdutos`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `bd_loja`.`Pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bd_loja`.`Pedidos` (
  `idPedidos` INT NOT NULL AUTO_INCREMENT,
  `quantidade` VARCHAR(45) NULL,
  `idClientes` INT NULL,
  `idProdutos` INT NULL,
  PRIMARY KEY (`idPedidos`),
  INDEX `fk_Pedidos_Clientes_idx` (`idClientes` ASC) VISIBLE,
  INDEX `fk_Pedidos_Produtos1_idx` (`idProdutos` ASC) VISIBLE,
  CONSTRAINT `fk_Pedidos_Clientes`
    FOREIGN KEY (`idClientes`)
    REFERENCES `bd_loja`.`Clientes` (`idClientes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Pedidos_Produtos1`
    FOREIGN KEY (`idProdutos`)
    REFERENCES `bd_loja`.`Produtos` (`idProdutos`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;



select p.idpedidos, c.idclientes, c.nome from Pedidos p inner join Clientes c;

select p.idpedidos, c.idclientes, c.nome from Pedidos p inner join Clientes c;

select idpedidos, idprodutos, descricao from Pedidos;
