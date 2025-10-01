create database primeirocrud;
use primeirocrud;

create table client(
id int primary key NOT NULL AUTO_INCREMENT,
name varchar (100),
email varchar (100),
cpf varchar (100),
birth date,
phone varchar(100),
address varchar(100)
)engine=InnoDB;