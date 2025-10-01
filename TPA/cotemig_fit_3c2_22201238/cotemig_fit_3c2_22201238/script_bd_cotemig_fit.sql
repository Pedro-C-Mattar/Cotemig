create database bd_cotemig_fit_22201238;
use bd_cotemig_fit_22201238;

DROP TABLE IF EXISTS `aluno`;
CREATE TABLE IF NOT EXISTS `aluno` (
  `idAluno` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(60) NOT NULL,
  `email` varchar(60) NOT NULL,
  `sexo` char(1) NOT NULL,
  `endereco` varchar(35) NOT NULL,
  `numero` int NOT NULL,
  `complemento` text NOT NULL,
  `bairro` varchar(25) NOT NULL,
  `cidade` varchar(35) NOT NULL,
  `uf` char(2) NOT NULL,
  `modalidade` varchar(35) NOT NULL,
  PRIMARY KEY (`idAluno`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
COMMIT;
