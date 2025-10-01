create database escola;

use escola;

create table Aluno(
idAluno int primary key not null auto_increment,
nome varchar(80) not null,
CPF varchar(80) not null,
telefone varchar(80) not null,
email varchar(80) not null,
endereco varchar(80) not null,
dataNascimento datetime not null
)engine=InnoDB;

create table Professor(
idProfessor int primary key not null auto_increment,
nome varchar(80) not null,
CPF varchar(80) not null,
telefone varchar(80) not null,
email varchar(80) not null,
endereco varchar(80) not null,
dataNascimento datetime not null
)engine=InnoDB;

create table Curso(
idCurso int primary key not null auto_increment,
nome varchar(80) not null,
turno varchar(80) not null,
periodo varchar(80) not null,
cargaHoraria varchar(80) not null
)engine=InnoDB;

create table Colaborador(
idColaborador int primary key not null auto_increment,
nome varchar(80) not null,
CPF varchar(80) not null,
telefone varchar(80) not null,
salario varchar(80) not null,
email varchar(80) not null,
endereco varchar(80) not null,
dataNascimento datetime not null,
cargo varchar(80) not null
)engine=InnoDB;

create table Disciplina(
idDisciplina int primary key not null auto_increment,
nome varchar(80) not null,
diaSemana varchar(80) not null,
turno varchar(80) not null,
cargaHoraria varchar(80) not null,
horario varchar(80) not null
)engine=InnoDB;

create table Endereco(
idEndereco int primary key not null auto_increment,
logradouro varchar(80) not null,
numero varchar(80) not null,
complemento varchar(80) not null,
bairro varchar(80) not null,
CEP varchar(80) not null,
cidade varchar(80) not null,
estado varchar(80) not null
)engine=InnoDB;


