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
usuario VARCHAR(100) NOT NULL,
senha VARCHAR(256) NOT NULL,
salt VARCHAR(64) NOT NULL,
observacao VARCHAR(500),
foto LONGBLOB,
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
PRIMARY KEY(codCli)
);

-- CRIANDO A TABELA DE FORNECEDORES

CREATE TABLE tbOrigemDoacao(

codOri INT NOT NULL AUTO_INCREMENT,  
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
referencia VARCHAR(200),
PRIMARY KEY(codOri)
);

-- CRIANDO A TABELA DE UNIDADES

CREATE TABLE tbUnidades(

codUni INT NOT NULL AUTO_INCREMENT,  
descricao VARCHAR(20) NOT NULL,
PRIMARY KEY(codUni)
);

-- CRIANDO A TABELA DE LISTA PRODUTOS

CREATE TABLE tbLista(

codList INT NOT NULL AUTO_INCREMENT,  
descricao VARCHAR(100) NOT NULL,
peso INT NOT NULL,
unidade VARCHAR(20) NOT NULL,
codUni INT NOT NULL,
PRIMARY KEY(codList),
FOREIGN KEY(codUni) REFERENCES tbUnidades(codUni)
);

-- CRIANDO A TABELA DE USUÁRIOS

CREATE TABLE tbUsuarios(

codUsu INT NOT NULL AUTO_INCREMENT,
usuario VARCHAR(100) NOT NULL,
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
descricao VARCHAR(100) NOT NULL,
quantidade INT NOT NULL,
peso INT NOT NULL,
unidade VARCHAR(20) NOT NULL,
codBar VARCHAR(13) NOT NULL,
dataDeEntrada DATETIME NOT NULL,
dataDeValidade DATETIME NOT NULL,
dataLimiteDeSaida DATETIME,
codUsu INT NOT NULL,
codOri INT NOT NULL,
codList INT NOT NULL,
PRIMARY KEY(codProd, codBar),
FOREIGN KEY(codUsu) REFERENCES tbUsuarios(codUsu),
FOREIGN KEY(codOri) REFERENCES tbOrigemDoacao(codOri),
FOREIGN KEY(codList) REFERENCES tbLista(codList)
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


INSERT INTO tbVoluntarios(codVol,nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)VALUES(1,'Adminin','0000000-0000','000.000.000-00','00000-000','Grupo Francisco','000','','Jd.Francisco','São Paulo','SP');

INSERT INTO tbUsuarios(codUsu,usuario,senha,tipo,salt,codVol)VALUES(1,'admin','123','Admin','134848646','1');

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(1,'Arroz Branco',10,5,'KG','1234561234561','2025-09-16','2026-09-10','2026-07-30',1);

-- SELECT nome AS nomeProduto, SUM(quantidade) AS totalQuantidadeProdutos, FROM tbProdutos GROUP BY nome ORDER BY totalQuantidadeProdutos DESC, totalQuantidadeEstoque DESC LIMIT 8;

-- SELECT nome, SUM(quantidade) FROM tbProdutos WHERE codProd = 1;

-- SELECT nome AS nomeProduto, SUM(quantidade) FROM tbProdutos GROUP BY nome;

-- SELECT nome AS nomeProduto, SUM(quantidade) AS totalQuantidadeProdutos FROM tbProdutos GROUP BY nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(2,'Feijão Carioca',5,1,'KG','1234561444888','2025-09-10','2026-09-05','2026-02-15',1);

-- SELECT p.nome AS nomeProduto, SUM(p.quantidade) AS totalQuantidadeProdutos FROM tbProdutos as p GROUP BY p.nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(3,'Macarrão',20,500,'G','1234561555333','2025-06-10','2025-12-25','2026-03-05',1);

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(4,'Farinha de trigo',7,1,'KG','5468761566644','2025-09-11','2025-11-30','2026-12-28',1);