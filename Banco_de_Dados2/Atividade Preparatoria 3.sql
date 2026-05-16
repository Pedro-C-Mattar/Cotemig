use classicmodels;

-- 1a
CREATE TABLE ComprasProdutos (
    codigo_produto VARCHAR(8),
    qtde_produto INT,
    qtde_estoque INT,
    nome_produto VARCHAR(200),
    preco_compra DECIMAL(10, 2)
);

-- 1b
CREATE TABLE LogAlteracoesCompras (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Descricao VARCHAR(255),
    Data TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);

-- 1c
CREATE OR REPLACE VIEW view_produtos_compra AS
SELECT 
    p.productCode,
    SUM(od.quantityOrdered) AS somatorio,
    p.quantityInStock,
    p.productName,
    p.buyPrice
FROM
    orderdetails od
JOIN products p ON od.productCode = p.productCode
GROUP BY p.productCode, p.quantityInStock, p.productName, p.buyPrice;

-- 1d
DELIMITER //
CREATE FUNCTION calcularPrecoCompra(buyprice DECIMAL(10, 2), somatorio INT)
RETURNS DECIMAL(10, 2)
BEGIN
    DECLARE resultado DECIMAL(10, 2);
    IF somatorio >= 90 THEN
        SET resultado = (buyprice * somatorio) * 1.02;
    ELSE
        SET resultado = (buyprice * somatorio) * 1.05;
    END IF;
    RETURN resultado;
END //
DELIMITER ;

-- 1e
DELIMITER //
CREATE TRIGGER trg_InsertCompraProduto
AFTER INSERT ON ComprasProdutos
FOR EACH ROW
BEGIN
    INSERT INTO LogAlteracoesCompras (Descricao, Data)
    VALUES (CONCAT('Inserção do produto: ', NEW.nome_produto, ' com valor de compra: ', NEW.preco_compra), CURRENT_TIMESTAMP);
END //
DELIMITER ;

-- 1f
DELIMITER //
CREATE PROCEDURE inserirDadosCompras()
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE codigo VARCHAR(8);
    DECLARE qtde INT;
    DECLARE estoque INT;
    DECLARE nome VARCHAR(200);
    DECLARE preco DECIMAL(10, 2);
    
    DECLARE cur CURSOR FOR
        SELECT product_code, somatorio, quantityInStock, productName, buyprice FROM vw_ProdutosCompras;
    
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;
    
    OPEN cur;
    
    loop_cursor: LOOP
        FETCH cur INTO codigo, qtde, estoque, nome, preco;
        
        IF done THEN
            LEAVE loop_cursor;
        END IF;
        
        SET preco = calcularPrecoCompra(preco, qtde);
        
        INSERT INTO ComprasProdutos (codigo_produto, qtde_produto, qtde_estoque, nome_produto, preco_compra)
        VALUES (codigo, qtde, estoque, nome, preco);
    END LOOP loop_cursor;
    
    CLOSE cur;
END //
DELIMITER ;
