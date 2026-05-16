-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`pais`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`pais` (
  `id` SMALLINT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(80) NULL,
  `sigla` VARCHAR(5) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`pontuação`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`pontuação` (
  `id` TINYINT NOT NULL AUTO_INCREMENT,
  `pontos` TINYINT NULL,
  `pontos2` TINYINT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`equipe`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`equipe` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(60) NULL,
  `motor` VARCHAR(60) NULL,
  `pais` SMALLINT NULL,
  `pontuacao` MEDIUMINT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`carros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`carros` (
  `equipe_id` INT NOT NULL,
  `numero` TINYINT NULL,
  INDEX `fk_carros_equipe_idx` (`equipe_id` ASC) VISIBLE,
  CONSTRAINT `fk_carros_equipe`
    FOREIGN KEY (`equipe_id`)
    REFERENCES `mydb`.`equipe` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`gp`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`gp` (
  `codigo` SMALLINT NOT NULL AUTO_INCREMENT,
  `circuito` VARCHAR(60) NULL,
  `pais` SMALLINT NULL,
  PRIMARY KEY (`codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`campeonato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`campeonato` (
  `gp_codigo` INT NOT NULL,
  `equipe_id` INT NOT NULL,
  PRIMARY KEY (`gp_codigo`, `equipe_id`),
  INDEX `fk_gp_has_equipe_equipe1_idx` (`equipe_id` ASC) VISIBLE,
  INDEX `fk_gp_has_equipe_gp1_idx` (`gp_codigo` ASC) VISIBLE,
  CONSTRAINT `fk_gp_has_equipe_gp1`
    FOREIGN KEY (`gp_codigo`)
    REFERENCES `mydb`.`gp` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_gp_has_equipe_equipe1`
    FOREIGN KEY (`equipe_id`)
    REFERENCES `mydb`.`equipe` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`piloto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`piloto` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `pilotocol` VARCHAR(45) NULL,
  `nome` VARCHAR(80) NULL,
  `pais` SMALLINT NULL,
  `carro` TINYINT NULL,
  `pontuacao` MEDIUMINT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`classificacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`classificacao` (
  `posicao` TINYINT NULL,
  `gp_codigo` SMALLINT NOT NULL,
  `piloto_id` INT NOT NULL,
  INDEX `fk_classificacao_gp1_idx` (`gp_codigo` ASC) VISIBLE,
  INDEX `fk_classificacao_piloto1_idx` (`piloto_id` ASC) VISIBLE,
  CONSTRAINT `fk_classificacao_gp1`
    FOREIGN KEY (`gp_codigo`)
    REFERENCES `mydb`.`gp` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_classificacao_piloto1`
    FOREIGN KEY (`piloto_id`)
    REFERENCES `mydb`.`piloto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`contrato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`contrato` (
  `piloto_id` INT NOT NULL,
  `equipe_id` INT NOT NULL,
  PRIMARY KEY (`piloto_id`, `equipe_id`),
  INDEX `fk_piloto_has_equipe_equipe1_idx` (`equipe_id` ASC) VISIBLE,
  INDEX `fk_piloto_has_equipe_piloto1_idx` (`piloto_id` ASC) VISIBLE,
  CONSTRAINT `fk_piloto_has_equipe_piloto1`
    FOREIGN KEY (`piloto_id`)
    REFERENCES `mydb`.`piloto` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_piloto_has_equipe_equipe1`
    FOREIGN KEY (`equipe_id`)
    REFERENCES `mydb`.`equipe` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

select * from pais;

select nome, pontuacao from piloto;

select nome, numero from equipe join carros on equipe.id = carros.equipe_id;

select * from pilotos where pontuacao < 10;

insert into pais (id, nome, sigla) values (null, 'Brasil', 'BRA');

update piloto set pontuacao = 15 where id = 1;

update piloto set pontuacao = 20 where nome = 'Antonio Jose';

delete from pontuacao where posicao > 10;

select avg(pontuacao) from piloto;

select count(*) from pais;

delimiter |
 create procedure sp_lista_paises()
 begin 
 select * from pais;
 end ;
 |
 delimiter ;
 
 call sp_lista_paises() ;
 
 delimiter |
 create procedure sp_novo_pais(in nomepais varchar(80) , siglapais varchar(5) )
 begin 
 insert into pais (id, nome, sigla) values (null, nomepais, siglapais) ;
 end ;
 |
 delimiter ;
 
 call sp_novo_pais('Brasil', 'BRA') ;
 
 delimiter |
 create procedure sp_muda_pontos(in pilotonome varchar(80) , pilotopontos mediumint )
 begin 
 update piloto set pontuacao = pilotopontos where nome = pilotonome;
 end ;
 |
 delimiter ;
 
 call sp_muda_pontos('Antonio Jose', 20) ;
 
 delimiter |
 create trigger trg_del_piloto before delete on piloto for each row
 begin 
 delete from contrato where piloto_id = old.id;
 end ;
 |
 delimiter ;
 
 delete from piloto where id = 123;
 
 delimiter |
 create trigger trg_ina_equipe after insert on equipe for each row
 begin 
 insert into carros (equipe_id, numero) values (new.id, 0) ;
 end ;
 |
 delimiter ;
 
 insert into equipe (id, nome, motor, pais, pontuacao) values (null, 'Williams', 'Mercedes', 5, 0)