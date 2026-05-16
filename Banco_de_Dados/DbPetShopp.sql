create database DbPetShop;
use DbPetShop;

create table Cliente(
idCliente int not null primary key auto_increment,
CPF char(14) not null,
nome_completo varchar(50) not null,
endereco varchar(80) not null,
email varchar(80) not null,
telefone char(12) not null
);

create table Animal(
idAnimal int not null primary key auto_increment,
tipo_animal varchar(20) not null,
nome_animal varchar(50) not null,
dono_animal varchar(50) not null,
sexo_animal varchar(10) not null,
data_nascimento varchar(20) not null,
fk_cliente_id int not null,
foreign key(fk_cliente_id) references Cliente(idCliente)
);

create table Servicos(
idServicos int not null primary key auto_increment,
descricao varchar(200) not null,
valor decimal(6,2) not null
);

alter table Animal add raca varchar(20) not null;
alter table Servicos add duracao varchar(30) not null;
alter table Cliente change telefone celular char(12) not null;
alter table Cliente drop endereco;
alter table Cliente add rua varchar(30) not null;
alter table Cliente add numero int not null;
alter table Cliente add complemento varchar(20) not null;
alter table Cliente add bairro varchar(30) not null;
alter table Cliente add cidade varchar(30) not null;
alter table Cliente add CEP char(9) not null;




