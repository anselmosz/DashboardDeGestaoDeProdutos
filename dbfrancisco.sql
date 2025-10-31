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



INSERT INTO tbVoluntarios(codVol,nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)VALUES(1,'Giovanne Silveira','1194513-8385','474.563.448-09','03905-050','Joao Batista Lima','327','','Jd.Aricanduva','São Paulo','SP');

INSERT INTO tbUsuarios(codUsu,email,senha,tipo,salt,codVol)VALUES(1,'senac@senac.com','123456789','Admin','134848646','1');


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


INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(1,'Arroz Branco',10,5,'KG','1234561234561','2025-09-16','2026-09-10','2026-07-30',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(2,'Feijão Carioca',5,1,'KG','1234561444888','2025-09-10','2026-09-05','2026-02-15',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(3,'Macarrão',20,500,'G','1234561555333','2025-06-10','2025-12-25','2026-03-05',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(4,'Farinha de trigo',7,1,'KG','5468761566644','2025-09-11','2025-11-30','2026-12-28',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(5,'Açúcar Refinado',12,1,'KG','7891234567001','2025-01-15','2026-01-10','2026-02-01',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(6,'Óleo de Soja',30,900,'ML','7891234567002','2025-02-20','2026-02-15','2026-03-10',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(7,'Café Torrado e Moído',15,500,'G','7891234567003','2025-03-18','2026-03-12','2026-04-01',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(8,'Leite Integral',25,1,'L','7891234567004','2025-04-25','2025-11-20','2025-12-05',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(9,'Sal Refinado',40,1,'KG','7891234567005','2025-05-10','2027-05-05','2027-01-20',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(10,'Molho de Tomate',18,340,'G','7891234567006','2025-07-08','2026-01-25','2026-02-10',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(11,'Biscoito Recheado',22,140,'G','7891234567007','2025-08-19','2026-02-18','2026-03-01',1);

INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)
VALUES(12,'Sabão em Pó',10,2,'KG','7891234567008','2025-10-12','2026-10-10','2026-09-30',1);
