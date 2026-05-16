create database bdEscola;

use bdEscola;

create table tblAlunos(
id int not null auto_increment primary key,
nome varchar(50) not null,
idade int not null,
unidade char(1) not null,
serie int not null,
turma char(1) not null
);

select * from tblAlunos;