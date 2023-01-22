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
