use sakila;

-- 1a
CREATE TABLE filme_info AS
SELECT 
    film.film_id AS codigo,
    GROUP_CONCAT(CONCAT(actor.first_name, ' ', actor.last_name)) AS relacao_atores,
    category.name AS categoria,
    film.rental_rate AS taxa_aluguel,
    0 AS atraso,
    0 AS taxa_calculada
FROM film
JOIN film_actor ON film.film_id = film_actor.film_id
JOIN actor ON film_actor.actor_id = actor.actor_id
JOIN film_category ON film.film_id = film_category.film_id
JOIN category ON film_category.category_id = category.category_id
GROUP BY film.film_id
LIMIT 100;

-- 1b
CREATE TABLE log_alteracoes (
    id INT AUTO_INCREMENT PRIMARY KEY,
    descricao TEXT,
    data TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 1c
CREATE VIEW filme_estoque_view AS
SELECT 
    f.codigo,
    f.relacao_atores,
    f.categoria,
    f.taxa_aluguel,
    f.atraso,
    f.taxa_calculada,
    COUNT(inventory.inventory_id) AS quantidade_filmes
FROM filme_info f
LEFT JOIN inventory ON f.codigo = inventory.film_id
GROUP BY f.codigo;

-- 1d
DELIMITER //

CREATE FUNCTION calcula_taxa(quantidade_filmes INT, taxa_aluguel DECIMAL(5, 2)) 
RETURNS DECIMAL(10, 2)
DETERMINISTIC
BEGIN
    DECLARE resultado DECIMAL(10, 2);
    IF quantidade_filmes >= 6 THEN
        SET resultado = quantidade_filmes * POW(taxa_aluguel, 2);
    ELSE
        SET resultado = quantidade_filmes * taxa_aluguel;
    END IF;
    RETURN resultado;
END //

DELIMITER ;

-- 1e
DELIMITER //

CREATE TRIGGER trigger_update_filme_info
AFTER UPDATE ON filme_info
FOR EACH ROW
BEGIN
    IF OLD.atraso != NEW.atraso OR OLD.taxa_calculada != NEW.taxa_calculada THEN
        INSERT INTO log_alteracoes (descricao, data)
        VALUES (CONCAT('Atualização no filme ID ', NEW.codigo, ': atraso alterado para ', NEW.atraso, ', taxa_calculada alterada para ', NEW.taxa_calculada), CURRENT_TIMESTAMP());
    END IF;
END //

DELIMITER ;

-- 1f
DELIMITER //

CREATE PROCEDURE atualiza_filme_info()
BEGIN
    DECLARE done INT DEFAULT FALSE;
    DECLARE codigo INT;
    DECLARE quantidade_filmes INT;
    DECLARE taxa_aluguel DECIMAL(5, 2);
    DECLARE cursor_filmes CURSOR FOR SELECT codigo, quantidade_filmes, taxa_aluguel FROM filme_estoque_view;
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = TRUE;

    OPEN cursor_filmes;

    read_loop: LOOP
        FETCH cursor_filmes INTO codigo, quantidade_filmes, taxa_aluguel;
        IF done THEN
            LEAVE read_loop;
        END IF;

        UPDATE filme_info
        SET atraso = quantidade_filmes,
            taxa_calculada = calcula_taxa(quantidade_filmes, taxa_aluguel)
        WHERE codigo = codigo;
    END LOOP;

    CLOSE cursor_filmes;
END //

DELIMITER ;
