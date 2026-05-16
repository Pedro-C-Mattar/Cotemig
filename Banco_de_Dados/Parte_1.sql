
create database DbPetShop;

use DbPetShop;

create table Cliente(
	id int not null primary key ,
	cpf char(11) not null,
	nome_completo varchar(30) not null,
	endereco varchar(50) not null,
	email varchar(40) not null,
	telefone char(11) not null
);

create table Animal(
	tipo varchar(20) not null primary key,
    nome varchar(40) not null,
    fk_cliente_id int not null,
    foreign key(fk_cliente_id) references Cliente(id),
    dono varchar(40) not null,
    sexo char(1) not null,
    data_nasci time not null
);

create table Servico(
	id int primary key not null,
    descricao varchar(60) not null,
    valor_cobrado varchar(20) not null
);


alter table Animal add raca varchar(40) not null;

alter table Servico add tempo_medio time not null;

alter table Cliente change telefone celular char(11) not null;

alter table Cliente drop endereco;

alter table Cliente add rua varchar(20) not null;

alter table Cliente add numero int not null;

alter table Cliente add complemento varchar(3) not null;

alter table Cliente add bairro varchar(25) not null;

alter table Cliente add cidade varchar(30) not null;

alter table Cliente add cep char(11) not null;

Insert into Cliente values ('1', '08122479316', 'Pedro', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('2', '08122479316', 'Pedro2', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('3', '08122479316', 'Pedro3', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('4', '08122479316', 'Pedro4', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('5', '08122479316', 'Pedro5', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('6', '08122479316', 'Pedro6', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('7', '08122479316', 'Pedro7', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('8', '08122479316', 'Pedro8', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('9', '08122479316', 'Pedro9', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');
Insert into Cliente values ('10', '08122479316', 'Pedro10', 'fulano@gmail.com', 99999-9999, 'ituverava', '47','105','renascenca', 'Belo Horizonte', '31130500');

insert into Animal values ('1', 'boss', 1, 'Pedro', 'Macho', '2006', 'golden');
insert into Animal values ('2', 'boss2', 2, 'Pedro2', 'Macho', '2006', 'golden');
insert into Animal values ('3', 'boss3', 3, 'Pedro3', 'Macho', '2006', 'golden');
insert into Animal values ('4', 'boss4', 4, 'Pedro4', 'Macho', '2006', 'golden');
insert into Animal values ('5', 'boss5', 5, 'Pedro5', 'Macho', '2006', 'golden');
insert into Animal values ('6', 'boss6', 6, 'Pedro6', 'Macho', '2006', 'golden');
insert into Animal values ('7', 'boss7', 7, 'Pedro7', 'Macho', '2006', 'golden');
insert into Animal values ('8', 'boss8', 8, 'Pedro8', 'Macho', '2006', 'golden');
insert into Animal values ('9', 'boss9', 9, 'Pedro9', 'Macho', '2006', 'golden');
insert into Animal values ('10', 'boss10', 10, 'Pedro10', 'Macho', '2006', 'golden');

insert into Servico values ('1', 'tosa', '60,00');
insert into Servico values ('2', 'tosa', '60,00');
insert into Servico values ('3', 'tosa', '60,00');
insert into Servico values ('4', 'tosa', '60,00');
insert into Servico values ('5', 'tosa', '60,00');

select * from animal limit 5;

select * from cliente LIMIT 5 OFFSET 3;

select * from animal order by nome desc;

drop database dbpetshop;