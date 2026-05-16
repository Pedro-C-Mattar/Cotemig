use sakila;

CREATE TABLE cliente_valores AS
SELECT 
    c.customer_id AS cliente_id,
    MONTH(p.payment_date) AS mes,
    SUM(p.amount) AS total_valor_pago,
    r.rental_id,
    0 AS lucro_esperado  -- Campo 'lucro_esperado' com valor inicial de 0
FROM 
    customer c
JOIN rental r ON c.customer_id = r.customer_id
JOIN payment p ON r.rental_id = p.rental_id
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
WHERE 
    p.payment_date BETWEEN '2005-03-01' AND '2005-09-30'
GROUP BY 
    c.customer_id, MONTH(p.payment_date), r.rental_id;

CREATE TABLE log_cliente_valores (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descricao VARCHAR(255),
    data TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

CREATE VIEW cliente_filmes_valores AS
SELECT 
    c.customer_id AS cliente_id,  -- Corrigido para customer_id
    MONTH(p.payment_date) AS mes,
    SUM(p.amount) AS total_valor_pago,
    r.rental_id,
    COUNT(f.film_id) AS quantidade_filmes
FROM 
    customer c
JOIN rental r ON c.customer_id = r.customer_id
JOIN payment p ON r.rental_id = p.rental_id
JOIN inventory i ON r.inventory_id = i.inventory_id
JOIN film f ON i.film_id = f.film_id
WHERE 
    p.payment_date BETWEEN '2005-03-01' AND '2005-09-30'
GROUP BY 
    c.customer_id, MONTH(p.payment_date), r.rental_id;

DELIMITER $$

CREATE FUNCTION calcular_lucro(total_valor_pago DECIMAL(10, 2), quantidade_filmes INT)
RETURNS DECIMAL(10, 2)
DETERMINISTIC
BEGIN
    DECLARE lucro DECIMAL(10, 2);
    
    IF quantidade_filmes > 30 THEN
        SET lucro = total_valor_pago * 0.10;
    ELSEIF quantidade_filmes > 20 AND quantidade_filmes <= 30 THEN
        SET lucro = total_valor_pago * 0.05;
    ELSE
        SET lucro = total_valor_pago * 0.02;
    END IF;

    RETURN lucro;
END $$

DELIMITER ;

DELIMITER $$

CREATE TRIGGER atualiza_lucro_esperado
AFTER UPDATE ON cliente_valores
FOR EACH ROW
BEGIN
    INSERT INTO log_cliente_valores (descricao, data) 
    VALUES (CONCAT('Novo lucro esperado: ', NEW.lucro_esperado), CURRENT_TIMESTAMP);
END $$

DELIMITER ;
drop TRIGGER atualiza_lucro_esperado;

DELIMITER $$

CREATE PROCEDURE calcular_e_atualizar_lucro()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE cliente_id INT;
    DECLARE mes INT;
    DECLARE total_valor_pago DECIMAL(10, 2);
    DECLARE rental_id INT;
    DECLARE quantidade_filmes INT;
    DECLARE lucro_calculado DECIMAL(10, 2);
    
    DECLARE cursor_lucros CURSOR FOR 
        SELECT cliente_id, mes, total_valor_pago, rental_id, quantidade_filmes
        FROM cliente_filmes_valores;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    OPEN cursor_lucros;
    
    read_loop: LOOP
        FETCH cursor_lucros INTO cliente_id, mes, total_valor_pago, rental_id, quantidade_filmes;
        
        IF done THEN
            LEAVE read_loop;
        END IF;

        -- Chama a função para calcular o lucro
        SET lucro_calculado = calcular_lucro(total_valor_pago, quantidade_filmes);
        
        -- Atualiza a tabela cliente_valores com o lucro esperado
        UPDATE cliente_valores 
        SET lucro_esperado = lucro_calculado
        WHERE cliente_id = cliente_id AND mes = mes AND rental_id = rental_id;
    END LOOP;
    
    CLOSE cursor_lucros;
END $$

DELIMITER ;

INSERT INTO cliente_valores (cliente_id, mes, total_valor_pago, rental_id)
VALUES (1, 3, 150.00, 101),
       (2, 4, 200.00, 102),
       (3, 5, 250.00, 103);

CALL calcular_e_atualizar_lucro();

SELECT * FROM cliente_valores;

SELECT * FROM log_cliente_valores;

