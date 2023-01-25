-- ----------------------------
-- Cadastro
-- -----------------------------
INSERT INTO cadastros(nome,senha,email, permissao) 
VALUES ("Jasmine", "123456", "jasmine@email.com", "adm");

INSERT INTO cadastros(nome,senha,email, permissao) 
VALUES ("Gustavo", "789456", "gustavo@email.com", "editor");

-- ----------------------------
-- Lojas
-- -----------------------------
INSERT INTO lojas(nome, cep, logradouro, numero, bairro, cidade, estado, latitude, longitude)
VALUES ("Farmarcas", "01311-000", "Avenida Paulista", "2300", "Bela Vista", "São Paulo", "SP", -23.5566584, -46.6612175);

INSERT INTO lojas(nome, cep, logradouro, numero, bairro, cidade, estado, latitude, longitude)
VALUES ("Itaim Bibi Loja", "01406-100", "Avenida Nove de Julho", "2300", "Jardim Paulista", "São Paulo", "SP", -23.5837524, -46.6780758);