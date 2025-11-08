-- APAGANDO O BANCO DE DADOS

DROP DATABASE dbfrancisco;

-- CRIANDO O BANCO DE DADOS

CREATE DATABASE dbfrancisco;

-- ENTRANDO NO BANCO DE DADOS

USE dbfrancisco;

-- CRIANDO A TABELA DE VOLUNTÁRIOS

CREATE TABLE tbVoluntarios(

codVol INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
telCel VARCHAR(15) NOT NULL,
cpf VARCHAR(14) NOT NULL UNIQUE,
cep VARCHAR(9),
rua VARCHAR(100),
numero VARCHAR(5),
complemento VARCHAR(100),
bairro VARCHAR(100),
cidade VARCHAR(100),
estado VARCHAR(2),
PRIMARY KEY(codVol)
);

-- CRIANDO A TABELA DE CLIENTES

CREATE TABLE tbClientes(

codCli INT NOT NULL AUTO_INCREMENT,  
nome VARCHAR(100) NOT NULL,
cpf VARCHAR(14) UNIQUE,
cnpj VARCHAR(18) UNIQUE,
cep VARCHAR(9),
rua VARCHAR(100),
numero VARCHAR(5),
complemento VARCHAR(100),
bairro VARCHAR(100),
cidade VARCHAR(100),
estado VARCHAR(2),
telCel VARCHAR(15),
referencia VARCHAR(200) NOT NULL,
PRIMARY KEY(CodCli)
);

-- CRIANDO A TABELA DE USUÁRIOS

CREATE TABLE tbUsuarios(

codUsu INT NOT NULL AUTO_INCREMENT,
email VARCHAR(100) NOT NULL,
senha VARCHAR(100) NOT NULL,
tipo VARCHAR(100) NOT NULL,
salt VARCHAR(64) NOT NULL,
codVol INT NOT NULL,
PRIMARY KEY(codUsu),
FOREIGN KEY(codVol) REFERENCES tbVoluntarios(codVol)
);


-- CRIANDO A TABELA DE JORNAL

CREATE TABLE tbJornal(

codJor INT NOT NULL AUTO_INCREMENT,
titulo VARCHAR(100) NOT NULL,
dataDePublicacao DATETIME NOT NULL,
descricao VARCHAR(10000) NOT NULL, 
foto LONGBLOB NOT NULL,
tema VARCHAR(100) NOT NULL,
email VARCHAR(100),
nome VARCHAR(100),
codUsu INT NOT NULL,
PRIMARY KEY(codJor),
FOREIGN KEY(codUsu) REFERENCES tbUsuarios(codUsu)
);

-- CRIANDO A TABELA DE FALE CONOSCO

CREATE TABLE tbFaleConosco(

codFaleConosco INT NOT NULL AUTO_INCREMENT,
nome VARCHAR(100) NOT NULL,
email VARCHAR(100) NOT NULL,
assunto VARCHAR(100),
mensagem VARCHAR(200) NOT NULL,
codUsu INT NOT NULL,
PRIMARY KEY(codFaleConosco),
FOREIGN KEY(codUsu) REFERENCES tbUsuarios(codUsu)
);

-- CRIANDO A TABELA DE PRODUTOS
	
CREATE TABLE tbProdutos(

codProd INT NOT NULL AUTO_INCREMENT,  
nome VARCHAR(100) NOT NULL,
quantidade INT NOT NULL,
peso INT NOT NULL,
unidade VARCHAR(10) NOT NULL,
codBar VARCHAR(13) NOT NULL,
dataDeEntrada DATETIME NOT NULL,
dataDeValidade DATETIME NOT NULL,
dataLimiteDeSaida DATETIME,
dataDeSaida DATETIME,
codUsu INT NOT NULL,
PRIMARY KEY(codProd, codBar),
FOREIGN KEY(codUsu) REFERENCES tbUsuarios(codUsu)
);

-- CRIANDO A TABELA DE CESTAS

CREATE TABLE tbCestas(

codCes INT NOT NULL AUTO_INCREMENT,
dataDeSaida DATE NOT NULL,
quantidade INT NOT NULL,
codProd INT NOT NULL,
codUsu INT NOT NULL,
dataDeMontagem DATETIME NOT NULL,
codCli INT NOT NULL,
PRIMARY KEY(codCes),
FOREIGN KEY(codProd) REFERENCES tbProdutos(codProd),
FOREIGN KEY(codUsu) REFERENCES tbUsuarios(codUsu),
FOREIGN KEY(codCli) REFERENCES tbClientes(codCli)
);

-- Inser de voluntarios ficticios de teste

-- Voluntario 1
INSERT INTO tbVoluntarios(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)
VALUES('Giovanne Silveira','1194513-8385','474.563.448-09','03905-050','Joao Batista Lima','327','','Jd.Aricanduva','São Paulo','SP');

INSERT INTO tbUsuarios(email,senha,tipo,salt,codVol)
VALUES('giovanne.silveira@email.com','123456789','Admin','134848646','1');

-- Voluntário 2
INSERT INTO tbVoluntarios(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)
VALUES('Mariana Oliveira','1198765-4422','512.449.987-33','04567-020','Rua das Rosas','120','','Jardim Paulista','São Paulo','SP'); 

INSERT INTO tbUsuarios(email,senha,tipo,salt,codVol)
VALUES('mariana.oliveira@email.com','123456789','Comum','789456123','2');

-- Voluntário 3
INSERT INTO tbVoluntarios(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)
VALUES('Carlos Eduardo Santos','1195544-3321','398.772.125-80','05843-210','Av. Dom Pedro II','450','Bloco B','Capão Redondo','São Paulo','SP'); 

INSERT INTO tbUsuarios(email,senha,tipo,salt,codVol)
VALUES('carlos.santos@email.com','123456789','Comum','951357456','3');

-- Voluntário 4
INSERT INTO tbVoluntarios(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)
VALUES('Fernanda Costa','1199944-7788','217.845.660-40','07012-310','Rua Antônio Dias','89','','Vila Galvão','Guarulhos','SP'); 

INSERT INTO tbUsuarios(email,senha,tipo,salt,codVol)
VALUES('fernanda.costa@email.com','123456789','Comum','753159842','4');

-- Voluntário 5
INSERT INTO tbVoluntarios(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)
VALUES('Ricardo Mendes','1196112-9090','330.998.471-12','04082-020','Rua Estrela do Norte','310','Apto 22','Vila Mariana','São Paulo','SP'); 

INSERT INTO tbUsuarios(email,senha,tipo,salt,codVol)
VALUES('ricardo.mendes@email.com','123456789','Comum','258963147','5');

-- Consulta para atualizar os dados do gráfico de produtos referente aos últimos itens adicionados e sua quantidade
-- SELECT p.nome AS nomeProduto, SUM(p.quantidade) AS totalQuantidadeProdutos FROM tbProdutos as p GROUP BY p.nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;

-- Consulta  últimos itens adicionados ao banco, incluindo quem cadastrou, quando e o que
-- SELECT DATE_FORMAT(prod.dataDeEntrada, '%d/%m/%Y'), DATE_FORMAT(prod.dataDeValidade, '%d/%m/%Y'), prod.nome, prod.quantidade, prod.unidade, prod.peso, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu ORDER BY dataDeEntrada DESC LIMIT 8;

-- Consulta de dados mensais (quantidade de produtos doados por mês durante o ano)
-- SELECT YEAR(dataDeEntrada) AS ano, MONTH(dataDeEntrada) AS mes, SUM(quantidade) AS totalMensal FROM tbProdutos GROUP BY YEAR(dataDeEntrada), MONTH(dataDeEntrada) ORDER BY ano, mes;

-- Consulta para referência de qual é o mês atual
-- SELECT COUNT(*) as total_mes_atual FROM tbProdutos WHERE MONTH(dataDeEntrada) = MONTH(CURDATE()) AND YEAR(dataDeEntrada) = YEAR(CURDATE());

-- Consultas para atualizar os dados de total referêntes ao mê vigente
-- SELECT SUM(quantidade) as total_itens FROM tbProdutos; -- atualiza a quantidade de itens totais
-- SELECT SUM(quantidade * peso) as total_peso FROM tbProdutos WHERE unidade = 'KG'; -- atualiza o total arrecadado em peso

-- SELECT nome, SUM(quantidade) FROM tbProdutos WHERE codProd = 1;

-- SELECT nome AS nomeProduto, SUM(quantidade) FROM tbProdutos GROUP BY nome;


-- realiza consulta de itens com base num período específico da data de entrada
-- SELECT prod.nome, prod.quantidade, prod.peso, prod.unidade, prod.dataDeEntrada, prod.dataDeValidade, usr.email FROM tbprodutos as prod INNER JOIN tbusuarios AS usr ON prod.codUsu = usr.codUsu WHERE prod.dataDeEntrada BETWEEN '2025-09-10' AND '2025-09-16' ORDER BY prod.dataDeEntrada DESC;



-- Produtos do Giovanne Silveira (codUsu = 1) -> codProd 11..16
INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(11,'Arroz Integral',20,5,'KG','1000000000011','2025-01-10','2026-01-08','2025-12-01',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(12,'Feijão Carioca',12,1,'KG','1000000000012','2025-02-05','2026-02-01','2026-01-15',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(13,'Macarrão Parafuso',30,500,'G','1000000000013','2025-03-20','2025-12-31','2025-11-30',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(14,'Açúcar Cristal',25,1,'KG','1000000000014','2025-04-12','2026-04-10','2026-03-05',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(15,'Óleo de Soja',40,900,'ML','1000000000015','2025-08-01','2026-07-20','2026-05-30',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(16,'Leite UHT',18,1,'L','1000000000016','2025-10-28','2025-12-15','2025-12-01',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(41,'Arroz Agulhinha',20,5,'KG','2000000000041','2025-11-01','2026-11-01','2026-09-15',1);



-- Produtos da Mariana Oliveira (codUsu = 2) -> codProd 17..22
INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(17,'Farinha de Trigo Integral',14,1,'KG','1000000000021','2025-01-22','2025-11-30','2025-10-15',2);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(46,'Café Torrado e Moído',12,500,'G','2000000000046','2025-11-01','2026-04-15','2026-03-01',2);


INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(18,'Biscoito Recheado',50,200,'G','1000000000022','2025-03-05','2026-03-01','2026-02-10',2);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(19,'Molho de Tomate',28,340,'G','1000000000023','2025-05-17','2026-05-10','2026-03-20',2);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(20,'Café Solúvel',16,200,'G','1000000000024','2025-06-09','2026-06-01','2026-04-15',2);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(21,'Achocolatado em Pó',22,400,'G','1000000000025','2025-09-02','2026-08-20','2026-07-01',2);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(22,'Sardinha em Lata',35,125,'G','1000000000026','2025-10-15','2027-01-10','2026-12-01',2);


-- Produtos do Carlos Eduardo Santos (codUsu = 3) -> codProd 23..28
INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(23,'Óleo de Girassol',10,900,'ML','1000000000031','2025-02-28','2026-02-20','2026-01-31',3);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(51,'Arroz Integral',22,5,'KG','2000000000051','2025-11-01','2026-10-01','2026-08-10',3);


INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(24,'Arroz Parboilizado',60,5,'KG','1000000000032','2025-04-03','2026-04-01','2026-02-15',3);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(25,'Feijão Vermelho',9,1,'KG','1000000000033','2025-05-21','2026-05-15','2026-04-05',3);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(26,'Macarrão Instantâneo',80,85,'G','1000000000034','2025-07-30','2026-07-25','2026-06-10',3);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(27,'Extrato de Tomate',24,200,'G','1000000000035','2025-08-14','2026-08-10','2026-07-01',3);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(28,'Leite em Pó',12,400,'G','1000000000036','2025-10-05','2026-09-30','2026-08-15',3);


-- Produtos da Fernanda Costa (codUsu = 4) -> codProd 29..34
INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(29,'Sabão em Pó',26,2,'KG','1000000000041','2025-01-30','2027-01-20','2026-12-01',4);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(30,'Detergente Líquido',40,500,'ML','1000000000042','2025-03-12','2026-03-05','2026-02-01',4);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(56,'Sabão em Pó',16,2,'KG','2000000000056','2025-11-01','2027-01-01','2026-12-15',4);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(31,'Pasta de Dente',33,90,'G','1000000000043','2025-05-02','2027-05-01','2027-03-30',4);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(32,'Papel Higiênico (4 unid)',18,0.5,'KG','1000000000044','2025-06-18','2028-06-01','2028-03-20',4);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(33,'Água Mineral 1.5L',72,1.5,'L','1000000000045','2025-09-07','2027-09-01','2027-07-15',4);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(34,'Desinfetante',20,1,'L','1000000000046','2025-10-22','2026-10-15','2026-09-01',4);


-- Produtos do Ricardo Mendes (codUsu = 5) -> codProd 35..40
INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(35,'Sal Marinho',60,1,'KG','1000000000051','2025-02-11','2027-02-01','2026-12-10',5);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(61,'Sal Refinado',30,1,'KG','2000000000061','2025-11-01','2027-01-01','2026-10-01',5);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(36,'Gelatina em Pó',44,20,'G','1000000000052','2025-04-27','2026-04-20','2026-03-15',5);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(37,'Leite Fermentado',26,200,'ML','1000000000053','2025-07-04','2025-11-25','2025-11-10',5);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(38,'Farinha de Milho',34,1,'KG','1000000000054','2025-08-29','2026-08-20','2026-06-30',5);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(39,'Cereal Matinal',15,300,'G','1000000000055','2025-09-18','2026-09-10','2026-08-01',5);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(40,'Leite Longa Vida',20,1,'L','1000000000056','2025-10-30','2025-12-20','2025-12-05',5);

