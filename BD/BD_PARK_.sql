-- Criação do banco de dados
CREATE DATABASE IF NOT EXISTS bd_park;

-- Utilização do banco de dados criado
USE bd_park;

-- Criação da tabela categoria
CREATE TABLE IF NOT EXISTS categoria (
    idCategoria INT AUTO_INCREMENT PRIMARY KEY,
    categoriaVeiculo VARCHAR(50)
);

-- Criação da tabela marca
CREATE TABLE IF NOT EXISTS marca (
    idMarca INT AUTO_INCREMENT PRIMARY KEY,
    marca VARCHAR(50)
);

-- Criação da tabela proprietario
CREATE TABLE IF NOT EXISTS proprietario (
    idProprietario INT AUTO_INCREMENT PRIMARY KEY,
    nomeProprietario VARCHAR(100),
    endereco VARCHAR(200),
    bairro VARCHAR(100),
    CPF VARCHAR(14),
    telefone VARCHAR(20)
);

-- Criação da tabela veiculo
CREATE TABLE IF NOT EXISTS veiculo (
    idVeiculo INT AUTO_INCREMENT PRIMARY KEY,
    placaVeiculo VARCHAR(10),
    anoVeiculo INT,
    Categoria_idCategoria INT,
    Proprietario_idProprietario INT,
    Marca_idMarca INT,
    FOREIGN KEY (Categoria_idCategoria) REFERENCES categoria(idCategoria),
    FOREIGN KEY (Proprietario_idProprietario) REFERENCES proprietario(idProprietario),
    FOREIGN KEY (Marca_idMarca) REFERENCES marca(idMarca)
);

-- Inserção de registros na tabela categoria
INSERT INTO categoria (categoriaVeiculo)
VALUES
    ('Sedan'),
    ('SUV'),
    ('Hatchback'),
    ('Caminhonete'),
    ('Esportivo'),
    ('Caminhão'),
    ('Van'),
    ('Motocicleta'),
    ('Utilitário'),
    ('Coupé');

-- Inserção de registros na tabela marca
INSERT INTO marca (marca)
VALUES
    ('Toyota'),
    ('Ford'),
    ('Honda'),
    ('Chevrolet'),
    ('Volkswagen'),
    ('Nissan'),
    ('BMW'),
    ('Audi'),
    ('Mitsubishi'),
    ('Mercedes-Benz');

-- Inserção de registros na tabela proprietario
INSERT INTO proprietario (nomeProprietario, endereco, bairro, CPF, telefone)
VALUES
    ('João da Silva', 'Rua A, 123', 'Centro', '123.456.789-01', '(11) 1234-5678'),
    ('Maria Santos', 'Av. B, 456', 'Vila Nova', '987.654.321-09', '(22) 9876-5432'),
    ('Carlos Souza', 'Rua C, 789', 'Bairro X', '456.789.123-45', '(33) 3333-3333'),
    ('Ana Oliveira', 'Av. D, 567', 'Bairro Y', '789.123.456-78', '(44) 4444-4444'),
    ('Fernanda Pereira', 'Rua E, 890', 'Bairro Z', '012.345.678-90', '(55) 5555-5555'),
    ('Pedro Almeida', 'Rua K, 111', 'Vila Alegre', '234.567.890-12', '(66) 6666-6666'),
    ('Lúcia Silva', 'Av. L, 222', 'Centro', '345.678.901-23', '(77) 7777-7777'),
    ('Roberto Santos', 'Rua M, 333', 'Bairro B', '456.789.012-34', '(88) 8888-8888'),
    ('Laura Costa', 'Av. N, 444', 'Vila C', '567.890.123-45', '(99) 9999-9999'),
    ('Mariana Oliveira', 'Rua O, 555', 'Bairro D', '678.901.234-56', '(00) 0000-0000');

-- Inserção de registros na tabela veiculo
INSERT INTO veiculo (placaVeiculo, anoVeiculo, Categoria_idCategoria, Proprietario_idProprietario, Marca_idMarca)
VALUES
    ('ABC1234', 2020, 1, 1, 1),
    ('DEF5678', 2019, 2, 2, 2),
    ('GHI9012', 2022, 3, 3, 3),
    ('JKL3456', 2021, 4, 14, 4), -- Updated Proprietario_idProprietario to a valid value
    ('MNO7890', 2020, 5, 5, 5),
    ('PQR2345', 2018, 1, 11, 6),
    ('STU6789', 2017, 2, 13, 7), -- Updated Proprietario_idProprietario to a valid value
    ('VWX0123', 2023, 3, 13, 8),
    ('YZA4567', 2022, 4, 14, 9),
    ('BCD8901', 2021, 5, 10, 10); -- Updated Proprietario_idProprietario to a valid value

-- Check the contents of the tables
SELECT * FROM categoria;
SELECT * FROM marca;
SELECT * FROM proprietario;
SELECT * FROM veiculo;

DESC veiculo;

-- crie uma consulta para visualizar os campos idVeiculo, placaVeiculo, anoVeiculo da tabela veiculo e os campos nomeProprietario e bairro da tabela proprietario;
select v.idVeiculo, v.placaVeiculo, v.anoVeiculo,p.nomeproprietario,p.bairro from veiculo v inner join proprietario p;
-- Aprimore a consulta para exibir o campo anoVeiculo de forma decrescente;
select v.idVeiculo, v.placaVeiculo, v.anoVeiculo,p.nomeproprietario,p.bairro from veiculo v inner join proprietario p order by v.anoveiculo desc;
-- crie uma consulta para visualizar os campos placaVeiculo, anoVeiculo da tabela veiculo e o campo marca da tabela marca;
select v.placaVeiculo, v.placaVeiculo, m.marca from veiculo v inner join marca m;
-- Aprimore a consulta para exibir o campo placaVeiculo de forma crescente;
select v.placaVeiculo, v.placaVeiculo, m.marca from veiculo v inner join marca m order by v.placaVeiculo asc;
-- USANDO o recurso de INNER JOIN, crie uma consulta para exibir a junção das tabelas veículo e proprietario.
select * from veiculo inner join proprietario;