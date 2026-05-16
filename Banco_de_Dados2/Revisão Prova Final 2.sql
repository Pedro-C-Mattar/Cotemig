-- Revisão Prova Final

-- Questão 1

use sakila;

CREATE OR REPLACE VIEW cliente_pais AS
SELECT 
    country.country AS paises,
    COUNT(customer.customer_id) AS total_clientes
FROM 
    customer
INNER JOIN 
    address ON (customer.address_id = address.address_id)
INNER JOIN 
    city ON (address.city_id = city.city_id)
INNER JOIN 
    country ON (city.country_id = country.country_id)
GROUP BY 
    Paises
ORDER BY
	total_clientes desc;
    
SELECT * FROM cliente_pais;
    
    
    
    
-- Questão 2  

use sakila;

CREATE OR REPLACE VIEW cliente_pais_pagamento AS
SELECT 
    country.country AS paises,
    COUNT(customer.customer_id) AS total_clientes,
    SUM(payment.amount) AS total_pagamentos,
    customer.store_id AS loja
FROM 
    customer
INNER JOIN 
    address ON (customer.address_id = address.address_id)
INNER JOIN 
    city ON (address.city_id = city.city_id)
INNER JOIN 
    country ON (city.country_id = country.country_id)
INNER JOIN
	payment ON (customer.customer_id = payment.customer_id)
WHERE
	customer.store_id = 2
GROUP BY
	paises
ORDER BY
	total_clientes desc;

SELECT * FROM cliente_pais_pagamento;

WITH RECURSIVE pagamento_loja_pais (paises, clientes, receita, loja) AS 
(
SELECT 
	paises, total_clientes, total_pagamentos, loja
FROM 
	cliente_pais_pagamento
)

SELECT * FROM pagamento_loja_pais;




-- Questão 3

use classicmodels;

delimiter $

CREATE PROCEDURE produto_receita_quantidade (in PARAM_ano int)
BEGIN
SELECT 
	products.productName, orderdetails.quantityOrdered*orderdetails.priceEach AS total_pagamento, orders.orderDate
FROM 
	products
INNER JOIN 
	orderdetails ON (products.productCode = orderdetails.productCode) 
INNER JOIN 
	orders ON (orderdetails.orderNumber = orders.orderNumber) 
WHERE 
	YEAR(orders.orderDate) = PARAM_ano
GROUP BY
	products.productName;
END$

delimiter ;

DROP PROCEDURE produto_receita_quantidade;

CALL produto_receita_quantidade (2004);




-- Questão 4

use sakila;

SELECT 
	category.name AS categoria, COUNT(film.film_id) AS qtde_filmes
FROM
	film
INNER JOIN
	film_category ON (film.film_id = film_category.film_id)
INNER JOIN
	category ON (film_category.category_id = category.category_id)
GROUP BY
	categoria;

