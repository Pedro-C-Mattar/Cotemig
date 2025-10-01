-- Criação do banco de dados
CREATE DATABASE bd_park;
-- Utilização do banco de dados criado
USE bd_park;

-- Criação da tabela categoria
CREATE TABLE categoria (
    idCategoria INT PRIMARY KEY auto_increment,
    categoriaVeiculo VARCHAR(50)
);

-- Criação da tabela marca
CREATE TABLE marca (
    idMarca INT PRIMARY KEY auto_increment,
    marca VARCHAR(50)
);

-- Criação da tabela proprietario
CREATE TABLE proprietario (
    idProprietario INT PRIMARY KEY auto_increment,
    nomeProprietario VARCHAR(100),
    endereco VARCHAR(200),
    bairro VARCHAR(100),
    CPF VARCHAR(14),
    telefone VARCHAR(20)
);

-- Criação da tabela veiculo
CREATE TABLE veiculo (
    idVeiculo INT PRIMARY KEY auto_increment,
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
INSERT INTO categoria (idCategoria, categoriaVeiculo)
VALUES
    (default, 'Sedan'),
    (default, 'SUV'),
    (default, 'Hatchback'),
    (default, 'Caminhonete'),
    (default, 'Esportivo'),
    (default, 'Caminhão'),
    (default, 'Van'),
    (default, 'Motocicleta'),
    (default, 'Utilitário'),
    (default, 'Coupé');

-- Inserção de registros na tabela marca
INSERT INTO marca (idMarca, marca)
VALUES
    (default, 'Toyota'),
    (default, 'Ford'),
    (default, 'Honda'),
    (default, 'Chevrolet'),
    (default, 'Volkswagen'),
    -- Insira mais registros aqui
    (default, 'Nissan'),
    (default, 'BMW'),
    (default, 'Audi'),
    (default, 'Mitsubishi'),
    (default, 'Mercedes-Benz');

-- Inserção de registros na tabela proprietario
INSERT INTO proprietario (idProprietario, nomeProprietario, endereco, bairro, CPF, telefone)
VALUES
    (default, 'João da Silva', 'Rua A, 123', 'Centro', '123.456.789-01', '(11) 1234-5678'),
    (default, 'Maria Santos', 'Av. B, 456', 'Vila Nova', '987.654.321-09', '(22) 9876-5432'),
    (default, 'Carlos Souza', 'Rua C, 789', 'Bairro X', '456.789.123-45', '(33) 3333-3333'),
    (default, 'Ana Oliveira', 'Av. D, 567', 'Bairro Y', '789.123.456-78', '(44) 4444-4444'),
    (default, 'Fernanda Pereira', 'Rua E, 890', 'Bairro Z', '012.345.678-90', '(55) 5555-5555'),
    -- Insira mais registros aqui
    (default, 'Pedro Almeida', 'Rua K, 111', 'Vila Alegre', '234.567.890-12', '(66) 6666-6666'),
    (default, 'Lúcia Silva', 'Av. L, 222', 'Centro', '345.678.901-23', '(77) 7777-7777'),
    (default, 'Roberto Santos', 'Rua M, 333', 'Bairro B', '456.789.012-34', '(88) 8888-8888'),
    (default, 'Laura Costa', 'Av. N, 444', 'Vila C', '567.890.123-45', '(99) 9999-9999'),
    (default, 'Mariana Oliveira', 'Rua O, 555', 'Bairro D', '678.901.234-56', '(00) 0000-0000');

-- Inserção de registros na tabela veiculo
INSERT INTO veiculo (idVeiculo, placaVeiculo, anoVeiculo, Categoria_idCategoria, Proprietario_idProprietario, Marca_idMarca)
VALUES
    (default, 'ABC1234', 2020, 1, 1, 1),
    (default, 'DEF5678', 2019, 2, 2, 2),
    (default, 'GHI9012', 2022, 3, 3, 3),
    (default, 'JKL3456', 2021, 4, '', 4),
    (default, 'MNO7890', 2020, 5, 5, 5),
    -- Insira mais registros aqui
    (default, 'PQR2345', 2018, 1, 11, 6),
    (default, 'STU6789', 2017, 2, '', 7),
    (default, 'VWX0123', 2023, 3, 13, 8),
    (default, 'YZA4567', 2022, 4, 14, 9),
    (default, 'BCD8901', 2021, 5, '', 10);
