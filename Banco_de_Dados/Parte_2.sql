
create database DbEscola;

use DbEscola;

Create table Aluno(
CodigoAluno int primary key,
NomeAluno varchar(20) not null,
cpf varchar(11) not null
);

Create table Disciplina(
CodigoDisciplina int primary key,
NomeDisciplina varchar(20) not null,
idDepart int,
foreign key(IdDepart) References Departamento(CodigoDepartamento)
);

Create table Departamento(
CodigoDepartamento int primary key,
NomeDepartamento varchar(20) not null
);

create table Aluno_cursa_disciplina(
idAluno int,
idDisciplina int,
ano int,
foreign key(idAluno) references Aluno(CodigoAluno),
foreign key(idDisciplina) references Disciplina(CodigoDisciplina)
);

Insert into Aluno  values (1, 'Jose ', '222.222.222-22');
Insert into Aluno values (2, 'Camila ', '333.333.333-33');
Insert into Aluno values (3, 'Josefina ', '444.444.444-44');
Insert into Aluno values (4, 'Josué ', '555.555.555-55');
Insert into Aluno values (5, 'Fernanda  ', '666.666.666-66');

Insert into Disciplina values (1, 'Portugues ', 2);
Insert into Disciplina values (2, 'Matemática ', 1);
Insert into Disciplina values (3, 'Físicas ', 1);
Insert into Disciplina values (4, 'Robótica  ', 4);
Insert into Disciplina values (5, 'Games  ', 4);
Insert into Disciplina values (6, 'Literatura', 2);
Insert into Disciplina values (7, 'Redação', 2);
Insert into Disciplina values (8, 'Banco de Dados', 4);


Insert into Departamento values (1,'Exatas');
Insert into Departamento values (2,'Humanas');
Insert into Departamento values (3,'Biológica');
Insert into Departamento values (4,'Tecnológica');

insert into Aluno_cursa_disciplina values(1,1,2020);
insert into Aluno_cursa_disciplina values(1,2,2020);
insert into Aluno_cursa_disciplina values(1,3,2020);
insert into Aluno_cursa_disciplina values(1,5,2020);
insert into Aluno_cursa_disciplina values(2,1,2020);
insert into Aluno_cursa_disciplina values(2,4,2020);
insert into Aluno_cursa_disciplina values(2,5,2020);
insert into Aluno_cursa_disciplina values(2,6,2020);
insert into Aluno_cursa_disciplina values(2,7,2020);
insert into Aluno_cursa_disciplina values(2,6,2020);
insert into Aluno_cursa_disciplina values(5,8,2020);
insert into Aluno_cursa_disciplina values(4,2,2020);
insert into Aluno_cursa_disciplina values(4,4,2020);

alter table disciplina add CH int not null;

alter table delete where CodigoAluno = 5;

select idAluno from Aluno_cursa_disciplina where idDisciplina = 4;

select idDisciplina from Aluno_cursa_disciplina where ano = 2020;

truncate Aluno_cursa_disciplina;

truncate Disciplina;

truncate Aluno;



