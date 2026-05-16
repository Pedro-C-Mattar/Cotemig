/* TRABALHO BD2 - Procedure Carrinho de Compras */

USE CLASSICMODELS;

CREATE TABLE Carrinho(
    idProduto VARCHAR(50),
    Qtde INT,
    Preco DECIMAL(10, 2),
    idCliente INT
);

SELECT * FROM CLASSICMODELS.CUSTOMERS WHERE SALESREPEMPLOYEENUMBER IS NOT NULL;

SELECT * FROM CLASSICMODELS.EMPLOYEES WHERE JOBTITLE = 'SALES REP';

SELECT * FROM CLASSICMODELS.PRODUCTS;

DELIMITER $

CREATE PROCEDURE Gerar_Pedido(IN PARAM_idCliente INT, IN PARAM_idVendedor INT, OUT Resultado VARCHAR(200))
iclv:BEGIN

    DECLARE idCliente_Carrinho INT;
    DECLARE numPedido INT;
    DECLARE codProduto VARCHAR(15);
    DECLARE Qtde INT;
    DECLARE Preco DECIMAL(10, 2);
    DECLARE Contador INT DEFAULT 0;

    DECLARE c_Carrinho CURSOR FOR
        SELECT codProduto, Qtde, Preco 
        FROM Carrinho 
        WHERE idCliente = PARAM_idCliente;
  
    DECLARE CONTINUE HANDLER FOR NOT FOUND SET Contador = 1;
  
    IF NOT EXISTS (SELECT CUSTOMERNUMBER FROM CUSTOMERS WHERE CUSTOMERNUMBER = PARAM_idCliente) THEN
        SET Resultado = 'CLIENTE NÃO EXISTENTE';
        LEAVE iclv;
    END IF;
  
    IF NOT EXISTS (SELECT EMPLOYEENUMBER FROM EMPLOYEES WHERE EMPLOYEENUMBER = PARAM_idVendedor) THEN
        SET Resultado = 'VENDEDOR NÃO EXISTENTE';
        LEAVE iclv;
    END IF;
  
    IF NOT EXISTS (SELECT idCliente FROM Carrinho WHERE idCliente = PARAM_idCliente) THEN
        SET Resultado = 'CLIENTE NÃO FEZ COMPRAS EM SEU CARRINHO';
        LEAVE iclv;
    END IF;
  
    START TRANSACTION;
  
    INSERT INTO ORDERS (
        ORDERDATE, 
        REQUIREDDATE, 
        STATUS, 
        CUSTOMERNUMBER
    ) VALUES (
        CURDATE(), 
        DATE_ADD(CURDATE(), INTERVAL 7 DAY), 
        'IN PROCESS', 
        PARAM_idCliente
    );
  
    SET numPedido = LAST_INSERT_ID();
    
    OPEN c_Carrinho;
    
    REPEAT

        FETCH c_Carrinho INTO codProduto, Qtde, Preco;
        IF Contador = 1 THEN
            LEAVE iclv;
        END IF;

        CALL Gerar_Item_Pedido(codProduto, Qtde, Preco, numPedido);
        
    UNTIL Contador = 1

    END REPEAT;

    CLOSE c_Carrinho;       
       
    UPDATE CUSTOMERS
    SET SALESREPEMPLOYEENUMBER = PARAM_idVendedor
    WHERE CUSTOMERNUMBER = PARAM_idCliente;
    
    SET Resultado = CONCAT('CRIADO O PEDIDO DE NÚMERO: ', numPedido);
    
    COMMIT;
    
    LEAVE iclv;

END$   

CREATE PROCEDURE Gerar_Item_Pedido(
    IN PARAM_codProduto VARCHAR(15), 
    IN PARAM_Qtde INT, 
    IN PARAM_Preco DECIMAL(10, 2), 
    IN PARAM_numPedido INT
)
BEGIN
    DECLARE exProduto INT;

    SELECT COUNT(*) INTO exProduto 
    FROM PRODUCTS 
    WHERE PRODUCTCODE = PARAM_codProduto;
    
    IF exProduto = 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'PRODUTO NÃO ENCONTRADO';
    END IF;

    IF PARAM_Qtde <= 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'QUANTIDADE NÃO PERMITIDA';
    END IF;

    INSERT INTO ORDERDETAILS (
        ORDERNUMBER, 
        PRODUCTCODE, 
        QUANTITYORDERED, 
        PRICEEACH, 
        ORDERLINENUMBER
    ) VALUES (
        PARAM_NUMEROPEDIDO, 
        PARAM_CODIGOPRODUTO, 
        PARAM_QUANTIDADE, 
        PARAM_PRECO, 
        (SELECT IFNULL(MAX(ORDERLINENUMBER), 0) + 1 FROM ORDERDETAILS WHERE ORDERNUMBER = PARAM_numPedido)
    );

    UPDATE PRODUCTS
    SET QUANTITYINSTOCK = QUANTITYINSTOCK - PARAM_Qtde
    WHERE PRODUCTCODE = PARAM_codProduto;

END$ 

DELIMITER ;
