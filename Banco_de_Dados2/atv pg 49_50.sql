-- PÁGINA 49

use sakila;

-- Left Inclusive

select * from address left join customer on (address.address_id = customer.address_id);

-- Left Exclusive

select * from address left join customer on (address.address_id = customer.address_id) where customer.customer_id is null;

-- Right Inclusive

select * from address right join customer on (address.address_id = customer.address_id);

-- Right Exclusive

select * from address right join customer on (address.address_id = customer.address_id) where customer.customer_id is null;

-- Full Outer Inclusive

select * from address left join customer on (address.address_id = customer.address_id)
union
select * from address right join customer on (address.address_id = customer.address_id);

-- Full Outer Exclusive 

select * from address left join customer on (address.address_id = customer.address_id)
union
select * from address right join customer on (address.address_id = customer.address_id) where address.address_id is null or customer.customer_id is null;

-- Inner Join

select * from address inner join customer on (address.address_id = customer.address_id);

-- PÁGINA 50

-- QUESTÃO 2

/*
DDL
DCL
DML
DDL
DCL
DML
DML
*/

-- QUESTÃO 3

/*
Para evitar esses problemas, devemos sempre usar a cláusula WHERE ao realizar um UPDATE.
*/





