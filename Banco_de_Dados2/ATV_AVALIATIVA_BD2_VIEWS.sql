/*
Atividade Avaliativa VIEWS
*/

use classicmodels;

create or replace view Dados as
select products.productCode, products.productName, sum(orderdetails.quantityOrdered) as totalQTD, orderdetails.priceEach, orders.orderDate
from products
inner join orderDetails on (products.productCode = orderdetails.productCode)
inner join orders on (orderdetails.orderNumber = orders.orderNumber)
where year(orders.orderDate) = 2003
group by products.productName
order by totalQTD desc
limit 20;

select * from Dados;
delete from Dados where productCode = ‘S10_1949’;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados set productName = ‘Novo Produto’ where productCode = ‘S10_1949’;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados1 as
select products.productCode, products.productName, month(orders.orderDate) as mes, avg(orderdetails.quantityOrdered * orderdetails.priceEach) as media, max(orderdetails.quantityOrdered * orderdetails.priceEach) as maximo, min(orderdetails.quantityOrdered * orderdetails.priceEach) as minimo, offices.city, orders.orderDate
from products
inner join orderDetails on (products.productCode = orderdetails.productCode)
inner join orders on (orderdetails.orderNumber = orders.orderNumber)
inner join customers on (orders.customerNumber = customers.customerNumber)
inner join employees on (customers.salesRepEmployeeNumber = employees.employeeNumber)
inner join offices on (employees.officeCode = employees.officeCode)
where year(orders.orderDate) = 2004 and offices.city = 'Paris'
group by month(orders.orderDate);

select * from Dados1;
delete from Dados1 where mes = 1;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados1 set media = 4000 where mes = 1;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados2 as
select orderdetails.productCode, products.productName, sum(orderdetails.quantityOrdered) as totalQTD, orders.requiredDate
from orderdetails
inner join orders on (orderdetails.orderNumber = orders.orderNumber)
inner join products on (orderdetails.productCode = products.productCode)
where month(orders.requiredDate) in (9, 10, 11, 12)
group by products.productName;

select * from Dados2;
delete from Dados2 where productCode = ‘S10_1949’;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados2 set totalQTD = 600 where productCode = ‘S10_1949’;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados3 as
select count(customers.customerNumber) as QTDclientes, offices.city
from customers
inner join employees on (customers.salesRepEmployeeNumber = employees.employeeNumber)
inner join offices on (employees.officeCode = offices.officeCode)
group by offices.city
order by QTDclientes desc;

select * from Dados3;
delete from Dados3 where officeCode = 1;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados3 set city = ‘Nova Cidade’ where officeCode = 1;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados4 as
select products.productCode, products.productName, sum(orderdetails.quantityOrdered) as totalQTD, orderdetails.priceEach, orders.orderDate
from products
inner join orderDetails on (products.productCode = orderdetails.productCode)
inner join orders on (orderdetails.orderNumber = orders.orderNumber)
where year(orders.orderDate) = 2004 and month(orders.orderDate) in (1, 2, 3, 4, 5, 6)
group by products.productName
order by totalQTD asc
limit 15;

select * from Dados4;
delete from Dados4 where productCode = ‘S10_1949’;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados4 set productName = ‘Novo Produto’ where productCode = ‘S10_1949’;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados5 as
select products.productCode, products.productName, month(orders.orderDate) as mes, avg(orderdetails.quantityOrdered * orderdetails.priceEach) as media, max(orderdetails.quantityOrdered * orderdetails.priceEach) as maximo, min(orderdetails.quantityOrdered * orderdetails.priceEach) as minimo, offices.city, orders.orderDate
from products
inner join orderDetails on (products.productCode = orderdetails.productCode)
inner join orders on (orderdetails.orderNumber = orders.orderNumber)
inner join customers on (orders.customerNumber = customers.customerNumber)
inner join employees on (customers.salesRepEmployeeNumber = employees.employeeNumber)
inner join offices on (employees.officeCode = employees.officeCode)
where year(orders.orderDate) = 2003 and offices.city = 'Tokyo'
group by products.productName;

select * from Dados5;
delete from Dados5 where media = 10000;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados5 set maximo = 60000 where media = 10000;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados6 as
select orderdetails.productCode, products.productName, min(orderdetails.quantityOrdered) as menorQTD, orders.orderdate
from orderDetails
join orders on (orderdetails.orderNumber = orders.orderNumber)
inner join products on (orderdetails.productCode = products.productCode)
where month(orders.orderDate) in (9, 10, 11, 12)
group by products.productName;

select * from Dados6;
delete from Dados6 where productCode = ‘S10_1949’;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados6 set menorQTD = 2 where productCode = ‘S10_1949’;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/

create or replace view Dados7 as
select count(customers.customerNumber) as QTDclientes, offices.city
from customers
inner join employees on (customers.salesRepEmployeeNumber = employees.employeeNumber)
inner join offices on (employees.officeCode = offices.officeCode)
group by offices.city
order by QTDclientes desc;

select * from Dados7;
delete from Dados7 where officeCode = 1;
/*
Não se consegue fazer Deletes em views que possuem junções ou agregações.
*/
update Dados7 set city = ‘Nova Cidade’ where officeCode = 1;
/*
Não se consegue fazer Updates em views que possuem junções ou agregações.
*/


