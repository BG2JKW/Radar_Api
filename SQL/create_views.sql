-- --------------------
-- MODELO GANHO E PEDIDOS POR REGIÃO
-- --------------------
CREATE OR REPLACE VIEW v_pedidos_estados AS
	SELECT cli.estado, 
		   sum(ped.valor_total) as valor_total_faturado, 
		   count(ped.id) as qtd_pedidos
		FROM pedidos as ped
		inner join clientes as cli on ped.Cliente_id = cli.id
	group by cli.estado;

-- --------------------
-- MODELO INFO PRODUTOS
-- --------------------
CREATE OR REPLACE VIEW v_produtos_info AS
	SELECT pro.nome, 
		   sum(pp.quantidade) as qtd_total_vendida,
		   pp.valor as faturamento_total,
		   pro.qtd_estoque
		FROM pedidosprodutos as pp
		INNER JOIN produtos as pro ON pp.Produto_id = pro.id
	group by pp.Produto_id;

-- --------------------
-- MODELO CLIENTES POR ESTADO
-- --------------------
CREATE OR REPLACE VIEW v_clientes_estados AS
	SELECT cli.estado, count(*) as qtd_clientes
		FROM clientes as cli
	group by cli.estado;
<<<<<<< HEAD

	-- --------------------
-- MODELO PEDIDO 
-- --------------------
CREATE OR REPLACE VIEW v_pedido_info AS
	SELECT ID FROM Pedidos WHERE CLIENTE_ID=1 ORDER BY ID DESC LIMIT 1;


=======
    
-- --------------------
-- MODELO PEDIDOS COM CPF
-- --------------------
CREATE OR REPLACE VIEW v_pedidos_cpf AS
	SELECT ped.id, ped.valor_total, ped.data, cli.cpf FROM pedidos as ped
		INNER JOIN clientes as cli ON ped.cliente_id = cli.id GROUP BY id;
    
>>>>>>> 8673e0e9b312f984cd998bdff8b711ce945a0360
