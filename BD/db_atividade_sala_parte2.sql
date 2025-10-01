create database db_parte2;

use db_parte2;

CREATE TABLE pais (
id INT PRIMARY KEY,
nome VARCHAR(40) NOT NULL,
sigla CHAR(2) NOT NULL,
idioma VARCHAR(2)
);

INSERT INTO pais VALUES (1, "Afeganistão", "PS", "Af");
INSERT INTO pais VALUES (2, "França", "FR", "Fr");
INSERT INTO pais VALUES (3, "Alemanha", "AL", "Al");
INSERT INTO pais VALUES (4, "Holanda", "HL", "Hl");
INSERT INTO pais VALUES (5, "Brasil", "BR", "PT");

UPDATE pais SET sigla='AF' WHERE id=1;

SELECT * FROM pais;

SELECT nome FROM pais 
WHERE idioma='PT';

ALTER TABLE pais
ADD Populacao INT(10);

UPDATE pais SET Populacao='546123' WHERE id=1;
UPDATE país SET Populacao='461300' WHERE id=2; 
UPDATE pais SET Populacao='1234' WHERE id=3;
UPDATE pais SET Populacao='623' WHERE id=4; 
UPDATE país SET Populacao='9123' WHERE id=5;

TRUNCATE TABLE pais;
SELECT * FROM pais;

DROP TABLE pais;
SELECT * FROM pais;
