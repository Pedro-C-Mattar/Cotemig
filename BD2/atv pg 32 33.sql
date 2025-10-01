-- Uso do Banco Sakila 
use sakila;

-- Q2
select * from film where rental_rate = 2.99;

-- Q3
select * from film order by length desc limit 10;

-- Q4
select * from category order by name asc;

-- Q5
select title from film where film_id in (select film_id from film_category where category_id in (select category_id from category where name = 'Comedy'));

-- Q6
select * from film where language_id <> 1 order by title desc;

-- Q7
select customer_id, first_name, email, active from customer order by first_name asc;

-- Q8
select concat(first_name, ' ', last_name) from customer where active = 0;

-- Q9
select payment_id as ID, amount as ValorOriginal, (amount + ((amount/100) * 10)) as ValoCom10PorCentro, payment_date as DataDePgto from payment;

-- Q10
select * from actor limit 15;

-- Q11
select * from actor order by actor_id desc limit 20;

