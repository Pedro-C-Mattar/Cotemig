-- Revisor: Rafael Pena

create database LojaTesteBancoDados2;

use LojaTesteBancoDados2;

create table Cliente(
Codigo_Cliente INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
email VARCHAR(100) NOT NULL,
cpf CHAR(11) NOT NULL
)engine=InnoDB;

create table Funcionario(
Codigo_Funcionario INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
funcao VARCHAR(100) NOT NULL,
cidade VARCHAR(100) NOT NULL
)engine=InnoDB;

create table Produto(
Codigo_Produto INT PRIMARY KEY AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
preco DECIMAL(10,2) NOT NULL,
descricao VARCHAR(100) NOT NULL,
quantidade_estoque INT NOT NULL
)engine=InnoDB;

create table Pedido(
Codigo_Pedido INT PRIMARY KEY AUTO_INCREMENT,
status VARCHAR(100) NOT NULL,
data_pedido DATETIME NOT NULL
)engine=InnoDB;

create table ItemPedido(
Codigo_Pedido INT,
FOREIGN KEY (Codigo_Pedido) REFERENCES Pedido(Codigo_Pedido),
Codigo_Produto INT,
FOREIGN KEY (Codigo_Produto) REFERENCES Produto(Codigo_Produto),
preco_venda DECIMAL(10,2) NOT NULL,
quantidade INT NOT NULL
)engine=InnoDB;

create table Auditoria(
data_modificacao DATETIME NOT NULL,
nome_tabela VARCHAR(100) NOT NULL,
historico VARCHAR(100) NOT NULL
)engine=InnoDB;

select * from Auditoria;



delimiter $
create trigger tgr_cliente_insercao after insert on Cliente for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Cliente', CONCAT('Insert: ', new.Codigo_Cliente, ' \ ', new.nome, ' \ ', new.email, ' \ ', new.cpf));
end$

create trigger tgr_cliente_atualizacao after update on Cliente for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Cliente', CONCAT('Update: ', new.Codigo_Cliente, ' \ ', new.nome, ' \ ', new.email, ' \ ', new.cpf));
end$

create trigger tgr_cliente_delete after delete on Cliente for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Cliente', CONCAT('Delete: ', old.Codigo_Cliente, ' \ ', old.nome, ' \ ', old.email, ' \ ', old.cpf));
end$



create trigger tgr_funcionario_insercao after insert on Funcionario for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Funcionario', CONCAT('Insert: ', new.Codigo_Funcionario, ' \ ', new.nome, ' \ ', new.funcao, ' \ ', new.cidade));
end$

create trigger tgr_funcionario_atualizacao after update on Funcionario for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Funcionario', CONCAT('Update: ', new.Codigo_Funcionario, ' \ ', new.nome, ' \ ', new.funcao, ' \ ', new.cidade));
end$

create trigger tgr_funcionario_delete after delete on Funcionario for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Funcionario', CONCAT('Delete: ', old.Codigo_Funcionario, ' \ ', old.nome, ' \ ', old.funcao, ' \ ', old.cidade));
end$



create trigger tgr_produto_insercao after insert on Produto for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Produto', CONCAT('Insert: ', new.Codigo_Produto, ' \ ', new.nome, ' \ ', new.preco, ' \ ', new.descricao, ' \ ', new.quantidade_estoque));
end$

create trigger tgr_produto_atualizacao after update on Produto for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Produto', CONCAT('Updade: ', new.Codigo_Produto, ' \ ', new.nome, ' \ ', new.preco, ' \ ', new.descricao, ' \ ', new.quantidade_estoque));
end$

create trigger tgr_produto_delete after delete on Produto for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Produto', CONCAT('Delete: ', old.Codigo_Produto, ' \ ', old.nome, ' \ ', old.preco, ' \ ', old.descricao, ' \ ', old.quantidade_estoque));
end$



create trigger tgr_pedido_insercao after insert on Pedido for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Pedido', CONCAT('Insert: ', new.Codigo_Pedido, ' \ ', new.status, ' \ ', new.data_pedido));
end$

create trigger tgr_pedido_atualizacao after update on Pedido for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Pedido', CONCAT('Update: ', new.Codigo_Pedido, ' \ ', new.status, ' \ ', new.data_pedido));
end$

create trigger tgr_pedido_delete after delete on Pedido for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'Pedido', CONCAT('Delete: ', old.Codigo_Pedido, ' \ ', old.status, ' \ ', old.data_pedido));
end$



create trigger tgr_itemPedido_insercao after insert on ItemPedido for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'ItemPedido', CONCAT('Insert: ', new.Codigo_Pedido, ' \ ', new.Codigo_Produto, ' \ ', new.preco_venda, ' \ ', new.quantidade));
end$

create trigger tgr_itemPedido_atualizacao after update on ItemPedido for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'ItemPedido', CONCAT('Update: ', new.Codigo_Pedido, ' \ ', new.Codigo_Produto, ' \ ', new.preco_venda, ' \ ', new.quantidade));
end$

create trigger tgr_itemPedido_delete after delete on ItemPedido for each row
begin
	insert into Auditoria (data_modificacao, nome_tabela, historico) 
		values (NOW(), 'ItemPedido', CONCAT('Delete: ', old.Codigo_Pedido, ' \ ', old.Codigo_Produto, ' \ ', old.preco_venda, ' \ ', old.quantidade));
end$
delimiter ;



delimiter $
Create procedure inserir_cliente (IN  Param_nome VARCHAR(100), IN  Param_email VARCHAR(100), IN  Param_cpf CHAR(11))
begin
insert into Cliente (Codigo_Cliente, nome, email, cpf) values (DEFAULT, Param_nome, Param_email, Param_cpf);
end$

Create procedure inserir_funcionario (IN Param_nome VARCHAR(100), IN Param_funcao VARCHAR(100), IN Param_cidade VARCHAR(100))
begin
insert into Funcionario (Codigo_Funcionario, nome, funcao, cidade) values (DEFAULT, Param_nome, Param_funcao, Param_cidade);
end$

Create procedure inserir_produto (IN Param_nome VARCHAR(100), IN Param_preco DECIMAL(10,2), IN Param_descricao VARCHAR(100), IN Param_quantidade_estoque INT)
begin
insert into Produto (Codigo_Produto, nome, preco, descricao, quantidade_estoque) values (DEFAULT, Param_nome, Param_preco, Param_descricao, Param_quantidade_estoque);
end$

delimiter ;

call inserir_cliente ('cleber', 'cleber@mail.com', 11111111111);
call inserir_funcionario ('julio', 'vendedor', 'sao paulo');
call inserir_produto ('pente', 5.00, 'ferramenta capilar', 20);


Create table Carrinho(
Codigo_Produto INT,
FOREIGN KEY (Codigo_Produto) REFERENCES Produto(Codigo_Produto),
Codigo_Cliente INT,
FOREIGN KEY (Codigo_Cliente) REFERENCES Cliente(Codigo_Cliente),
Codigo_Funcionario INT,
FOREIGN KEY (Codigo_Funcionario) REFERENCES Funcionario(Codigo_Funcionario),
Quantidade INT NOT NULL,
Preco DECIMAL(10,2) NOT NULL
)engine=InnoDB;

DELIMITER $
CREATE PROCEDURE inserir_pedido_item(IN Param_status VARCHAR(100), IN Param_data_pedido DATETIME, IN Param_items TEXT)
BEGIN
    DECLARE done INT DEFAULT 0;
    DECLARE v_Codigo_Pedido INT;
    DECLARE v_Codigo_Produto INT;
    DECLARE v_quantidade INT;
    DECLARE v_preco_venda DECIMAL(10, 2);

    DECLARE item_cursor CURSOR FOR
        SELECT Codigo_Produto, quantidade FROM JSON_TABLE(Param_items, '$[*]' COLUMNS (
            Codigo_Produto INT PATH '$.Codigo_Produto',
            quantidade INT PATH '$.quantidade'
        )) AS items;

    DECLARE CONTINUE HANDLER FOR NOT FOUND SET done = 1;

    START TRANSACTION;

    INSERT INTO Pedido (status, data_pedido) VALUES (Param_status, Param_data_pedido);
    SET v_Codigo_Pedido = LAST_INSERT_ID();

    OPEN item_cursor;

    read_loop: LOOP
        FETCH item_cursor INTO v_Codigo_Produto, v_quantidade;

        IF done THEN
            LEAVE read_loop;
        END IF;

        IF v_quantidade <= 0 THEN
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Invalid quantity for product.';
        END IF;

        IF (SELECT quantidade_estoque FROM Produto WHERE Codigo_Produto = v_Codigo_Produto) < v_quantidade THEN
            SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Insufficient stock for product.';
        END IF;

        SET v_preco_venda = (SELECT preco FROM Produto WHERE Codigo_Produto = v_Codigo_Produto);

        INSERT INTO ItemPedido (Codigo_Pedido, Codigo_Produto, preco_venda, quantidade) 
        VALUES (v_Codigo_Pedido, v_Codigo_Produto, v_preco_venda, v_quantidade);
    END LOOP;

    CLOSE item_cursor;

    COMMIT;
END$
DELIMITER ;

call inserir_pedido_item('Em Andamento', NOW(), '[{"Codigo_Produto": 1, "quantidade": 5}]');



CREATE OR REPLACE VIEW pedidos_mais_vendidos AS
SELECT 
    Produto.Codigo_Produto,
    Produto.nome,
    SUM(ItemPedido.quantidade) AS Total_Vendido
FROM 
    ItemPedido
JOIN 
    Produto ON (ItemPedido.Codigo_Produto = Produto.Codigo_Produto)
GROUP BY 
    Produto.Codigo_Produto, Produto.nome
ORDER BY 
    Total_Vendido DESC;
    
select * from pedidos_mais_vendidos;