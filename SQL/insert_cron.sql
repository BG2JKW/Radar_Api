USE `api_radar` ;
-- --------------------
-- CLIENTES
-- --------------------
INSERT INTO clientes(nome,telefone,email,cpf,cep,logradouro,numero,bairro,cidade,estado) 
VALUES ("Daniel Gonçalves", "(11)91234-5678", "dani_gon@email.com", "877.017.977-85", "25233-080", "Rua Guiomar de Albuquerque", "2300", "Pilar", "Duque de Caxias", "Rio de Janeiro");

INSERT INTO clientes(nome,telefone,email,cpf,cep,logradouro,numero,bairro,cidade,estado) 
VALUES ("Daniela Almeida", "(11)91234-5678", "dani_alm@email.com", "163.491.221-78", "79073-741", "Travessa Juan Villarrodona", "2300", "Centro Oeste", "Campo Grande", "Mato Grosso do Sul");

INSERT INTO clientes(nome,telefone,email,cpf,cep,logradouro,numero,bairro,cidade,estado) 
VALUES ("Jaziel Jazes", "(11)91234-5678", "jaziel@email.com", "939.532.688-30", "04545-041", "Rua Santa Justina", "2300", "Vila Olímpia", "São Paulo", "São Paulo");

INSERT INTO clientes(nome,telefone,email,cpf,cep,logradouro,numero,bairro,cidade,estado) 
VALUES ("Leonardo Aricó", "(11)91234-5678", "leoleo@email.com", "022.815.508-85", "05883-000", "Rua Rosário Scamardi", "2300", "Jardim do Colégio", "São Paulo", "São Paulo");

INSERT INTO clientes(nome,telefone,email,cpf,cep,logradouro,numero,bairro,cidade,estado) 
VALUES ("Antony Aricó", "(11)91234-5678", "antant@email.com", "589.308.068-80", "05883-000", "Rua Rosário Scamardi", "2300", "Jardim do Colégio", "São Paulo", "São Paulo");

-- --------------------
-- PRODUTOS
-- --------------------
INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("COLÍRIO HYABAK 0,15% 10ML", "HIALURONATO DE SODIO,HIALURONATO SODICO,SODIUM HYALURONATE", 61.79, 349);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("SUPLEMENTO VITAMÍNICO VITASAY IMUNE D TRIP 10 COMPRIMIDOS EFERVESCENTES", "Auxilia o sistema imune; Sabor laranja; Rico em Vitamina C, D e Zinco; Zero adição de açúcares.", 20.90, 308);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("PROTETOR SOLAR FACIAL VICHY IDÉAL SOLEIL CLARIFY COR CLARA FPS 60 40G", "Protetor solar facial com cor para peles claras, FPS 60; Alta proteção UVA, UVB e luz visível; 
Textura gel creme com toque seco, para uso diário; Previne o envelhecimento precoce da pele; Ideal para peles mistas e oleosas.", 89.90, 438);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("GEL DE LIMPEZA FACIAL LA ROCHE-POSAY EFFACLAR ALTA TOLERÂNCIA 300G", "Limpeza suave e purificante; Ideal para peles oleosas, sensíveis e sensibilizadas; Textura em gel; Antioleosidade; Hipoalergênico.", 84.90, 343);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("SABONETE EM BARRA LA ROCHE-POSAY EFFACLAR CONCENTRADO COM 70G", "Sabonete facial em barra; Limpeza profunda antioleosidade; Desobstrui os poros; Ideal para peles oleosas e acneicas; 
Desenvolvido para pele brasileira.", 45.90, 328);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("DIPIRONA MONOIDRATADA 500MG 10 COMPRIMIDOS EMS GENÉRICO", "A Dipirona Sódica é indicada como analgésico e antitérmico. Utilizada também em estados febris e dolorosos.", 6.58, 215);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("SIMETICONA 125MG 10 CÁPSULAS CIMED GENÉRICO", "Simeticona atua no estômago e no intestino, diminuindo a tensão superficial dos líquidos digestivos, levando ao rompimento das bolhas(gases).", 15.49, 443);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("DESODORANTE REXONA CLINICAL CLASSIC ANTITRANSPIRANTE EM CREME 48G", "Protege 3x mais contra a transpiração excessiva; Conta com tecnologia TriSolid; Combatendo o suor e o mau odor; 
Proporciona até 48h de hidratação e segurança; Testado dermatologicamente.", 22.49, 58);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("KIT ESCOVA DE DENTE COLGATE SLIM SOFT BLACK COM 4 UNIDADES", "Cerdas com pontas ultrafinas que removem as partículas mais difíceis entre os dentes e as gengivas; Promove uma limpeza profunda e delicada; 
Remove 88% da placa em apenas 1 escovação; Cerdas macias com infusão de carvão.", 37.90, 447);

INSERT INTO produtos(nome,descricao,valor,qtd_estoque)
VALUES ("DORFLEX DIPIRONA SÓDICA 300MG + CITRATO DE ORFENADRINA 35MG + CAFEÍNA 50MG 50 COMPRIMIDOS", "Dorflex age na dor e relaxa a tensão muscular causada pela má postura e movimentos repetitivos;  
Uma potente combinação de analgésico e relaxante muscular disponível em versões de 10, 24, 36, 50 comprimidos e gotas.", 32.96, 494);

-- ----------------------------
-- Cadastro
-- -----------------------------
INSERT INTO cadastros(nome,senha,email, permissao) 
VALUES ("Jasmine", "123456", "jasmine@email.com", "adm");

INSERT INTO cadastros(nome,senha,email, permissao) 
VALUES ("Gustavo", "789456", "gustavo@email.com", "editor");