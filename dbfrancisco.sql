-- APAGANDO O BANCO DE DADOS

DROP DATABASE dbfrancisco;

-- CRIANDO O BANCO DE DADOS

CREATE DATABASE dbfrancisco;

-- ENTRANDO NO BANCO DE DADOS

USE dbfrancisco;

-- CRIANDO A TABELA DE VOLUNTÁRIOS

CREATE TABLE tbVoluntarios(

codVol INT NOT NULL AUTO_INCREMENT, -- 0
nome VARCHAR(100) NOT NULL, -- 1
telCel VARCHAR(15) NOT NULL, -- 2
email VARCHAR(100) NOT NULL UNIQUE,
cpf VARCHAR(14) NOT NULL UNIQUE,
cep VARCHAR(9),
rua VARCHAR(100),
numero VARCHAR(5),
complemento VARCHAR(100),
bairro VARCHAR(100),
cidade VARCHAR(100),
estado VARCHAR(2),
ativo BOOLEAN DEFAULT TRUE,
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
descricao VARCHAR(20) NOT NULL UNIQUE,
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
tipo ENUM('ADMIN','USER') DEFAULT 'ADMIN',
salt VARCHAR(64) NOT NULL,
ativo BOOLEAN DEFAULT TRUE,
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


INSERT INTO tbVoluntarios(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)VALUES('Adminin','0000000-0000','000.000.000-00','00000-000','Grupo Francisco','000','','Jd.Francisco','São Paulo','SP');

INSERT INTO tbVoluntarios
(nome,telCel,cpf,cep,rua,numero,complemento,bairro,cidade,estado)
VALUES
('João Silva','1191111-1111','111.111.111-01','01001-000','Rua A','10','','Centro','São Paulo','SP'),
('Maria Souza','1192222-2222','111.111.111-02','02002-000','Rua B','20','Apto 1','Bela Vista','São Paulo','SP'),
('Carlos Pereira','1193333-3333','111.111.111-03','03003-000','Rua C','30','','Mooca','São Paulo','SP'),
('Ana Costa','1194444-4444','111.111.111-04','04004-000','Rua D','40','Casa','Ipiranga','São Paulo','SP'),
('Lucas Lima','1195555-5555','111.111.111-05','05005-000','Rua E','50','','Santana','São Paulo','SP'),
('Fernanda Rocha','1196666-6666','111.111.111-06','06006-000','Rua F','60','Fundos','Penha','São Paulo','SP'),
('Bruno Martins','1197777-7777','111.111.111-07','07007-000','Rua G','70','','Tatuapé','São Paulo','SP'),
('Patricia Alves','1198888-8888','111.111.111-08','08008-000','Rua H','80','Bloco B','Lapa','São Paulo','SP'),
('Rafael Gomes','1199999-9999','111.111.111-09','09009-000','Rua I','90','','Pinheiros','São Paulo','SP'),
('Juliana Ribeiro','1181111-1111','111.111.111-10','10010-000','Rua J','100','Apto 12','Perdizes','São Paulo','SP'),
('Daniel Santos','1182222-2222','111.111.111-11','11011-000','Rua K','110','','Vila Mariana','São Paulo','SP'),
('Camila Torres','1183333-3333','111.111.111-12','12012-000','Rua L','120','Casa','Jabaquara','São Paulo','SP'),
('Eduardo Nunes','1184444-4444','111.111.111-13','13013-000','Rua M','130','','Butantã','São Paulo','SP'),
('Renata Freitas','1185555-5555','111.111.111-14','14014-000','Rua N','140','Apto 3','Morumbi','São Paulo','SP'),
('Thiago Barros','1186666-6666','111.111.111-15','15015-000','Rua O','150','','Campo Limpo','São Paulo','SP'),
('Aline Pacheco','1187777-7777','111.111.111-16','16016-000','Rua P','160','Bloco C','Itaquera','São Paulo','SP'),
('Marcos Teixeira','1188888-8888','111.111.111-17','17017-000','Rua Q','170','','Osasco','Osasco','SP'),
('Bianca Lopes','1189999-9999','111.111.111-18','18018-000','Rua R','180','Casa','Guarulhos','Guarulhos','SP'),
('Felipe Araujo','1171111-1111','111.111.111-19','19019-000','Rua S','190','','Santo Amaro','São Paulo','SP'),
('Larissa Mendes','1172222-2222','111.111.111-20','20020-000','Rua T','200','Apto 5','Interlagos','São Paulo','SP');



INSERT INTO tbUsuarios(codUsu,usuario,senha,tipo,salt,codVol)VALUES(1,'admin','123','Admin','134848646','1');
INSERT INTO tbUsuarios
(usuario,senha,tipo,salt,codVol)
VALUES
('joao.silva','123','Usuario','salt02',2),
('maria.souza','123','Usuario','salt03',3),
('carlos.pereira','123','Usuario','salt04',4),
('ana.costa','123','Usuario','salt05',5),
('lucas.lima','123','Usuario','salt06',6),
('fernanda.rocha','123','Usuario','salt07',7),
('bruno.martins','123','Usuario','salt08',8),
('patricia.alves','123','Usuario','salt09',9),
('rafael.gomes','123','Usuario','salt10',10),
('juliana.ribeiro','123','Usuario','salt11',11),
('daniel.santos','123','Usuario','salt12',12),
('camila.torres','123','Usuario','salt13',13),
('eduardo.nunes','123','Usuario','salt14',14),
('renata.freitas','123','Usuario','salt15',15),
('thiago.barros','123','Usuario','salt16',16),
('aline.pacheco','123','Usuario','salt17',17),
('marcos.teixeira','123','Usuario','salt18',18),
('bianca.lopes','123','Usuario','salt19',19),
('felipe.araujo','123','Usuario','salt20',20),
('larissa.mendes','123','Usuario','salt21',21);


-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(1,'Arroz Branco',10,5,'KG','1234561234561','2025-09-16','2026-09-10','2026-07-30',1);

-- SELECT nome AS nomeProduto, SUM(quantidade) AS totalQuantidadeProdutos, FROM tbProdutos GROUP BY nome ORDER BY totalQuantidadeProdutos DESC, totalQuantidadeEstoque DESC LIMIT 8;

-- SELECT nome, SUM(quantidade) FROM tbProdutos WHERE codProd = 1;

-- SELECT nome AS nomeProduto, SUM(quantidade) FROM tbProdutos GROUP BY nome;

-- SELECT nome AS nomeProduto, SUM(quantidade) AS totalQuantidadeProdutos FROM tbProdutos GROUP BY nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(2,'Feijão Carioca',5,1,'KG','1234561444888','2025-09-10','2026-09-05','2026-02-15',1);

-- SELECT p.nome AS nomeProduto, SUM(p.quantidade) AS totalQuantidadeProdutos FROM tbProdutos as p GROUP BY p.nome ORDER BY totalQuantidadeProdutos DESC LIMIT 8;

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(3,'Macarrão',20,500,'G','1234561555333','2025-06-10','2025-12-25','2026-03-05',1);

-- INSERT INTO tbProdutos(codProd,nome,quantidade,peso,unidade,codBar,dataDeEntrada,dataDeValidade,dataLimiteDeSaida,codUsu)VALUES(4,'Farinha de trigo',7,1,'KG','5468761566644','2025-09-11','2025-11-30','2026-12-28',1);