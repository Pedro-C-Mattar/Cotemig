
CREATE DATABASE bd_aviacao;

USE bd_aviacao;

CREATE TABLE aeronave (
    prefixo VARCHAR(10) PRIMARY KEY,
    modelo VARCHAR(50),
    lugares INT,
    autonomia INT
);

CREATE TABLE voo (
    numero INT PRIMARY KEY,
    origem VARCHAR(50),
    destino VARCHAR(50),
    datahora_saida DATETIME
);

CREATE TABLE piloto (
    registro INT PRIMARY KEY,
    nome VARCHAR(100),
    telefones VARCHAR(100),
    dependentes INT,
    endereco VARCHAR(200)
);

CREATE TABLE passagem (
    bilhete INT PRIMARY KEY,
    assento VARCHAR(10),
    check_in BOOLEAN
);

CREATE TABLE passageiro (
    CPF VARCHAR(15) PRIMARY KEY,
    nome VARCHAR(100),
    nascimento DATE,
    telefone VARCHAR(20),
    endereco VARCHAR(200)
);

ALTER TABLE voo ADD COLUMN aeronave_prefixo VARCHAR(10);
ALTER TABLE voo ADD FOREIGN KEY (aeronave_prefixo) REFERENCES aeronave(prefixo);

ALTER TABLE voo ADD COLUMN piloto_registro INT;
ALTER TABLE voo ADD FOREIGN KEY (piloto_registro) REFERENCES piloto(registro);

ALTER TABLE passagem ADD COLUMN voo_numero INT;
ALTER TABLE passagem ADD FOREIGN KEY (voo_numero) REFERENCES voo(numero);

ALTER TABLE passagem ADD COLUMN passageiro_CPF VARCHAR(15);
ALTER TABLE passagem ADD FOREIGN KEY (passageiro_CPF) REFERENCES passageiro(CPF);

INSERT INTO aeronave (prefixo, modelo, lugares, autonomia)
VALUES
    ('AB123', 'Boeing 737', 150, 3000),
    ('CD456', 'Airbus A320', 180, 2500),
    ('EF789', 'Embraer E190', 100, 2000);

INSERT INTO piloto (registro, nome, telefones, dependentes, endereco)
VALUES
    (1001, 'João Silva', '(11) 1234-5678', 2, 'Rua das Flores, 123'),
    (1002, 'Maria Souza', '(21) 9876-5432', 1, 'Avenida Principal, 456');

INSERT INTO passageiro (CPF, nome, nascimento, telefone, endereco)
VALUES
    ('123.456.789-01', 'Carlos Santos', '1990-05-15', '(31) 5555-5555', 'Rua das Palmeiras, 789'),
    ('987.654.321-09', 'Ana Oliveira', '1985-11-20', '(41) 7777-7777', 'Alameda dos Sonhos, 567');

INSERT INTO voo (numero, origem, destino, datahora_saida, aeronave_prefixo, piloto_registro)
VALUES
    (1, 'São Paulo', 'Rio de Janeiro', '2023-08-25 08:00:00', 'AB123', 1001),
    (2, 'Rio de Janeiro', 'Brasília', '2023-08-26 10:00:00', 'CD456', 1002);

INSERT INTO passagem (bilhete, assento, check_in, voo_numero, passageiro_CPF)
VALUES
    (10001, 'A1', TRUE, 1, '123.456.789-01'),
    (10002, 'B2', FALSE, 2, '987.654.321-09');

INSERT INTO aeronave (prefixo, modelo, lugares, autonomia)
VALUES
    ('GH234', 'Boeing 777', 300, 5000),
    ('IJ567', 'Airbus A330', 250, 4000),
    ('KL890', 'Embraer E175', 80, 1800),
    ('MN123', 'Boeing 747', 400, 5500),
    ('OP456', 'Airbus A350', 350, 4500),
    ('QR789', 'Bombardier CRJ900', 70, 1700),
    ('ST012', 'Cessna 172', 4, 500);

INSERT INTO piloto (registro, nome, telefones, dependentes, endereco)
VALUES
    (1003, 'Rafael Oliveira', '(51) 2222-3333', 0, 'Rua das Montanhas, 789'),
    (1004, 'Fernanda Rodrigues', '(11) 8888-9999', 3, 'Avenida das Estrelas, 456'),
    (1005, 'Pedro Santos', '(31) 4444-5555', 2, 'Rua das Águas, 123'),
    (1006, 'Mariana Almeida', '(21) 6666-7777', 1, 'Avenida do Sol, 789'),
    (1007, 'Lucas Costa', '(41) 5555-6666', 0, 'Alameda das Flores, 567'),
    (1008, 'Camila Souza', '(61) 7777-8888', 2, 'Rua Principal, 101'),
    (1009, 'Daniel Pereira', '(85) 9999-0000', 1, 'Avenida Central, 303');

INSERT INTO passageiro (CPF, nome, nascimento, telefone, endereco)
VALUES
    ('111.222.333-44', 'Ricardo Martins', '1978-03-10', '(81) 1234-5678', 'Rua da Praia, 101'),
    ('222.333.444-55', 'Juliana Lima', '1995-09-22', '(32) 8765-4321', 'Avenida das Palmeiras, 202'),
    ('333.444.555-66', 'Paulo Ferreira', '1982-06-18', '(41) 9876-5432', 'Rua das Estrelas, 303'),
    ('444.555.666-77', 'Laura Santos', '2000-12-01', '(51) 4567-8901', 'Avenida dos Sonhos, 404'),
    ('555.666.777-88', 'Gustavo Oliveira', '1998-01-30', '(21) 7654-3210', 'Alameda dos Sonhos, 505'),
    ('666.777.888-99', 'Isabela Souza', '1989-07-09', '(31) 6543-2109', 'Rua das Flores, 606'),
    ('777.888.999-00', 'Vinícius Silva', '2005-11-15', '(11) 5432-1098', 'Avenida Principal, 707');

INSERT INTO voo (numero, origem, destino, datahora_saida, aeronave_prefixo, piloto_registro)
VALUES
    (3, 'Brasília', 'São Paulo', '2023-08-27 12:00:00', 'GH234', 1003),
    (4, 'São Paulo', 'Belo Horizonte', '2023-08-28 15:30:00', 'IJ567', 1004),
    (5, 'Rio de Janeiro', 'Porto Alegre', '2023-08-29 14:45:00', 'KL890', 1005),
    (6, 'Salvador', 'Recife', '2023-08-30 09:15:00', 'MN123', 1006),
    (7, 'Curitiba', 'Fortaleza', '2023-08-31 07:30:00', 'OP456', 1007),
    (8, 'Belo Horizonte', 'Brasília', '2023-09-01 10:30:00', 'QR789', 1008),
    (9, 'Porto Alegre', 'São Paulo', '2023-09-02 16:00:00', 'ST012', 1009);

INSERT INTO passagem (bilhete, assento, check_in, voo_numero, passageiro_CPF)
VALUES
    (10003, 'C3', TRUE, 3, '111.222.333-44'),
    (10004, 'D4', FALSE, 4, '222.333.444-55'),
    (10005, 'E5', TRUE, 5, '333.444.555-66'),
    (10006, 'F6', FALSE, 6, '444.555.666-77'),
    (10007, 'G7', TRUE, 7, '555.666.777-88'),
    (10008, 'H8', TRUE, 8, '666.777.888-99'),
    (10009, 'I9', FALSE, 9, '777.888.999-00');


show tables;
select * from aeronave;
select * from passageiro;
select * from passagem;
select * from piloto;
select * from voo;

SELECT v.numero, v.origem, v.destino, a.modelo, p.nome
FROM voo v
INNER JOIN aeronave a ON v.aeronave_prefixo = a.prefixo
INNER JOIN piloto p ON v.piloto_registro = p.registro;


