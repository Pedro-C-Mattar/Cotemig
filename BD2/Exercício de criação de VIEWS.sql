/*
Exercício de criação de VIEWS
*/

use sakila;

CREATE OR REPLACE VIEW Dados AS
SELECT country.country_id AS country_id, 
       country.country,  
       city.city_id,
       city.city
FROM country
INNER JOIN city ON country.country_id = city.country_id;

CREATE OR REPLACE VIEW Dados1 AS
SELECT city.city_id AS city_id, 
       city.city, 
       address.address_id,
       address.address
FROM city
INNER JOIN address ON city.city_id = address.city_id;

CREATE OR REPLACE VIEW Dados2 AS
SELECT address.address_id AS address_id,
       address.address,
       customer.customer_id,
       concat(customer.first_name, customer.last_name)
FROM address
INNER JOIN customer ON address.address_id = customer.address_id;

CREATE OR REPLACE VIEW Dados3 AS
SELECT customer.customer_id AS customer_id, 
       concat(customer.first_name, customer.last_name), 
        payment.payment_id,
       payment.amount
FROM customer
INNER JOIN payment ON customer.customer_id = payment.customer_id;

CREATE OR REPLACE VIEW Dados4 AS
SELECT payment.payment_id, 
       payment.amount, 
       customer.customer_id AS customer_id, 
       concat(customer.first_name, customer.last_name)
FROM payment
INNER JOIN customer ON payment.customer_id = customer.customer_id;

CREATE OR REPLACE VIEW Dados5 AS
SELECT film.film_id, 
       film.title,
       language.language_id AS language_id, 
       language.name AS language_name
FROM film
INNER JOIN language ON film.language_id = language.language_id;

create or replace view Dados6 as
select count(film_id) as NumeroDeFilmes, name as idioma from film inner join language on (language.language_id= film.language_id) group by name;

create or replace view Dados7 as
select count(payment_id) as TotalPagamentos, store.store_id as loja from store inner join staff on (store.store_id = staff.store_id) inner join payment on (staff.staff_id = payment.staff_id) group by store.store_id;

create or replace view Dados8 as
select count(customer_id) as QuantidadeClientes, store.store_id as loja from store inner join customer on (store.store_id = customer.store_id) group by store.store_id;

create or replace view Dados9 as
select store.store_id, avg(payment.amount) as Media, sum(payment.amount) as Total, count(payment.payment_id) as QuantidadePagamento, max(payment.amount) as Maximo, min(payment.amount) as Minimo from store
inner join staff on (store.store_id = staff.store_id) inner join payment on (staff.staff_id = payment.staff_id) group by store.store_id;

create or replace view Dados10 as
select customer.customer_id, sum(payment.amount) as TotalPagamentos from customer inner join payment on (customer.customer_id = payment.customer_id) group by customer.customer_id;

create or replace view Dados11 as
select language.name as idioma, count(film.film_id) as QuantidadeFilme from film inner join language on (film.language_id = language.language_id) where film.length between 100 and 150 group by language.name;

create or replace view Dados12 as
select store.store_id, sum(payment.amount) as TotalPagamentos from store inner join staff on (store.store_id = staff.store_id) inner join payment on (staff.staff_id = payment.staff_id) where payment.payment_date like "2005-08%" and "2005-09%" group by store.store_id;

create or replace view Dados13 as
select store.store_id, count(customer.customer_id) as QuantidadeClientes from store inner join customer on (store.store_id = customer.store_id) where customer.Last_name like "R%" group by store.store_id;

CREATE OR REPLACE VIEW Dados14 AS
SELECT city.city_id AS city_id, 
       city.city,
       address.address_id AS address_id, 
       address.address,
       customer.customer_id AS customer_id, 
       concat(customer.first_name, customer.last_name)
FROM city
INNER JOIN address ON city.city_id = address.city_id
INNER JOIN customer ON address.address_id = customer.address_id;

CREATE OR REPLACE VIEW Dados15 AS
SELECT customer.customer_id AS customer_id, 
       concat(customer.first_name, customer.last_name), 
       payment.payment_id AS payment_id, 
       payment.amount,
       rental.rental_id AS rental_id, 
       rental.rental_date
FROM customer
INNER JOIN payment ON customer.customer_id = payment.customer_id
INNER JOIN rental ON customer.customer_id = rental.customer_id;

CREATE OR REPLACE VIEW Dados16 AS
SELECT film.film_id AS film_id, 
       film.title,
       category.category_id AS category_id, 
       category.name
FROM film
INNER JOIN film_category ON film.film_id = film_category.film_id
INNER JOIN category ON film_category.category_id = category.category_id;

CREATE OR REPLACE VIEW Dados17 AS
SELECT actor.actor_id AS actor_id, 
       concat(actor.first_name, actor.last_name), 
       film.film_id AS film_id, 
       film.title
FROM actor
INNER JOIN film_actor ON actor.actor_id = film_actor.actor_id
INNER JOIN film ON film_actor.film_id = film.film_id;

create or replace view Dados18 as
select city, count(customer.customer_id) as QuantidadeClientes from city inner join address on (city.city_id = address.city_id) inner join customer on (address.address_id = customer.address_id) where customer.create_date like "2006-02%" group by city.city;

create or replace view Dados19 as
select actor.actor_id, actor.first_name, actor.last_name, count(film.film_id) as QuantidadeFilme from actor inner join film_actor on (actor.actor_id = film_actor.actor_id) inner join film on (film_actor.film_id = film.film_id)
where film.rental_duration in (3, 7) and film.length between 60 and 150 and film.replacement_cost > 12.00 group by actor.actor_id, actor.first_name, actor.last_name;

create or replace view Dados20 as
select category.name as Categoria, sum(film.replacement_cost) as TotalMulta from category inner join film_category on (category.category_id = film_category.category_id) inner join film on (film_category.film_id = film.film_id)
where film.rental_duration in (3, 7) and film.length between 60 and 150 and film.replacement_cost > 12.00 group by category.name;

CREATE OR REPLACE VIEW Dados21 AS
SELECT city.city_id AS city_id, 
       city.city, 
       address.address_id AS address_id, 
       address.address,
       customer.customer_id AS customer_id, 
       concat(customer.first_name, customer.last_name),
       payment.payment_id AS payment_id, 
       payment.amount
FROM city
INNER JOIN address ON city.city_id = address.city_id
INNER JOIN customer ON address.address_id = customer.address_id
INNER JOIN payment ON customer.customer_id = payment.customer_id;

CREATE OR REPLACE VIEW Dados22 AS
SELECT store.store_id AS store_id, 
       staff.staff_id AS staff_id, 
       concat(staff.first_name, staff.last_name), 
       payment.payment_id AS payment_id, 
       payment.amount,
       rental.rental_id AS rental_id, 
       rental.rental_date, 
       inventory.inventory_id AS inventory_id, 
       film.film_id AS film_id, 
       film.title
FROM store
INNER JOIN staff ON store.store_id = staff.store_id
INNER JOIN payment ON staff.staff_id = payment.staff_id
INNER JOIN rental ON payment.rental_id = rental.rental_id
INNER JOIN inventory ON rental.inventory_id = inventory.inventory_id
INNER JOIN film ON inventory.film_id = film.film_id;

CREATE OR REPLACE VIEW Dados23 AS
SELECT actor.actor_id AS actor_id, 
       concat(actor.first_name, actor.last_name), 
       film.film_id AS film_id, 
       film.title,
       inventory.inventory_id AS inventory_id, 
       rental.rental_id AS rental_id, 
       rental.rental_date, 
       payment.payment_id AS payment_id, 
       payment.amount, 
       customer.customer_id AS customer_id, 
       concat(customer.first_name, customer.last_name),
       address.address_id AS address_id, 
       address.address, 
       city.city_id AS city_id, 
       city.city, 
       country.country_id AS country_id, 
       country.country
FROM actor
INNER JOIN film_actor ON actor.actor_id = film_actor.actor_id
INNER JOIN film ON film_actor.film_id = film.film_id
INNER JOIN inventory ON film.film_id = inventory.film_id
INNER JOIN rental ON inventory.inventory_id = rental.inventory_id
INNER JOIN payment ON rental.rental_id = payment.rental_id
INNER JOIN customer ON payment.customer_id = customer.customer_id
INNER JOIN address ON customer.address_id = address.address_id
INNER JOIN city ON address.city_id = city.city_id
INNER JOIN country ON city.country_id = country.country_id;

create or replace view Dados24 as
select category.name as categoria, sum(payment.amount) as TotalPagamentos from payment inner join rental on (payment.rental_id = rental.rental_id)
inner join inventory on (rental.inventory_id = inventory.inventory_id) inner join film_category on (inventory.film_id = film_category.film_id)
inner join category on (film_category.category_id = category.category_id) group by category.name;

create or replace view Dados25 as
select country.country as países, count(payment.payment_id) as QuantidadePagamentos from payment inner join customer on (payment.customer_id = customer.customer_id)
inner join address on (customer.address_id = address.address_id) inner join city on (address.city_id = city.city_id)
inner join country on (city.country_id = country.country_id) group by country.country;

