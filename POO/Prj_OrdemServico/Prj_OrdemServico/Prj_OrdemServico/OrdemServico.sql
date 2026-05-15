create database db_os;
use db_os;

create table tbl_usuario(
	id_usuario int primary key not null auto_increment,
    tbl_setores_id_setor int not null,
    nome_usuario varchar(50) not null,
    email_usuario varchar(50) not null,
    tel_usuario char(14) not null
);

create table tbl_tecnico(
	id_tecnico int primary key not null auto_increment,
    nome_tecnico varchar(50) not null,
    tbl_especialidade_id_espec int not null
);  

create table tbl_setores(
id_setores int primary key not null auto_increment,
nome_setores varchar(50) not null
);

create table tbl_especialidade(
id_especialidade int primary key not null auto_increment,
nome_especialidade varchar(50) not null
);