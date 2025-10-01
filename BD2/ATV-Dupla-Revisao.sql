-- Aluno 1: Pedro Mattar
-- Aluno 2: Rafael Pena

-- QUESTÃO 1

/*
A Modelagem é importante porque é a partir dela que se orientará o desenvolvimento e que dará informações sobre as características do projeto em questão. 
É na Modelagem que se é capaz notar a presença de especificação das regras de negócio, que é um passo fundamental na criação de um sistema computacional.
A modelagem ajuda na organização e na estruturização na criação do banco de dados.
*/

-- QUESTÃO 2

create database db_farmacia;

use db_farmacia;

create table Farmacia(
CNPJ_farmacia int unsigned auto_increment not null primary key,
nome_farmacia varchar(30) not null,
tel_farmacia int not null,
end_farmacia varchar(50) not null  
)engine=InnoDB;

create table Produto(
cod_produto int unsigned auto_increment not null primary key,
valor_produto decimal(5,2) not null,
qtd_produto int not null,
fk_CNPJ_farmacia int unsigned not null,
foreign key (fk_CNPJ_farmacia) references Farmacia (CNPJ_farmacia) on delete restrict
)engine=InnoDB;

create table Farmaceutico(
RG_farmaceutico int unsigned auto_increment not null primary key,
nome_farmaceutico varchar(30) not null,
fk_CNPJ_farmacia int unsigned not null,
foreign key (fk_CNPJ_farmacia) references Farmacia (CNPJ_farmacia) on delete restrict
)engine=InnoDB;

-- QUESTÃO 3

use sakila;

-- A)

select title, count(distinct film_actor.actor_id) as QTD_Atores, count(distinct inventory.inventory_id) as QTD_Estoque
from film 
join inventory using (film_id)
join film_actor using (film_id)
group by title 
order by QTD_Estoque desc, QTD_Atores desc
limit 20;

-- B)

select store_id, name as Nome_categoria, count(*) as Numero_filmes 
from film
join film_category using (film_id)
join category using (category_id)
join inventory using (film_id)
join store using (store_id)
where name in ('Drama', 'Horror', 'Comedy')
group by store_id, name
order by store_id, Numero_filmes desc;

-- QUESTÃO 4

/*
Consulta: Retornar a quantidade dos clientes inativo, que tiveram pagamento em 2005 e que são residentes nos países que começam com a letra A
          Retornar a quantidade dos clientes ativo, que tiveram pagamento em 2005 e são residentes nos países com o critério %B_A%
*/


select ifnull(count(customer_id),0) as qtde, 'Inativo' as tipo_cliente from country join city using (country_id) join address using (city_id) join customer using (address_id) join payment using (customer_id)
where year (payment_date) = 2005 and country like "A%" and active = 0 group by tipo_cliente
UNION ALL
select count(customer_id) as qtde, 'Inativo' as tipo_cliente from country join city using (country_id) join address using (city_id) join customer using (address_id) join payment using (customer_id)
where year (payment_date) = 2005 and country like "%B_A%" and active = 1 group by tipo_cliente;



