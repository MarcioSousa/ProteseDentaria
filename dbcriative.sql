DROP DATABASE dbcriative
GO

CREATE DATABASE dbcriative
GO

USE dbcriative
GO

CREATE TABLE Tipo(
	codigo INT not null IDENTITY(1,1),
	nome VARCHAR(30) not null,
)
GO

ALTER TABLE Tipo
ADD CONSTRAINT PK_CODIGOTIPO
PRIMARY KEY (codigo)
GO

INSERT INTO Tipo(nome) VALUES('FAZE METÁLICA')
INSERT INTO Tipo(nome) VALUES('IMPLANTES')
INSERT INTO Tipo(nome) VALUES('SOLDAGEM')
INSERT INTO Tipo(nome) VALUES('CERÂMICA')
INSERT INTO Tipo(nome) VALUES('EMAX')
INSERT INTO Tipo(nome) VALUES('RESINA FOTO')
INSERT INTO Tipo(nome) VALUES('ZIRCÔNICA')
INSERT INTO Tipo(nome) VALUES('PLACAS')
INSERT INTO Tipo(nome) VALUES('TRABALHOS PROVISÓRIOS')
GO

--========================================================================================
CREATE TABLE Produto(
	codigo INT not null,
	nome VARCHAR(100) not null,
	valor NUMERIC(8,2) not null,
	codigotipo INT not null
)
GO

ALTER TABLE Produto
ADD CONSTRAINT PK_CODIGOPRODUTO
PRIMARY KEY (codigo)
GO

ALTER TABLE Produto
ADD CONSTRAINT FK_PRODUTO_ITEM
FOREIGN KEY(codigotipo)
REFERENCES Tipo(codigo)
GO

INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1001, 'NÚCLEO FUNDIÇÃO DIRETA', 50.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1002, 'NÚCLEO SIMPLES', 60.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1003, 'NÚCLEO ESTOJADO', 70.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1004, 'NÚCLEO BI-PARTIDO', 80.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1005, 'NÚCLEO TRI-PARTIDO', 90.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1006, 'NÚCLEO ESTÉTICO EM RESINA', 90.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1007, 'COPING METÁLICO PLÁSTICA', 90.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1008, 'COPING METÁLICO CERÂMICA', 90.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1009, 'PRÓTESE ADESIVA Adesiva', 160.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1010, 'GENGIVA ARTIFICIAL POR ELEMENTO', 7.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1011, 'COROA TOTAL METÁLICA', 120.00, 1)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1012, 'COPING METÁLICO', 90.00, 2)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1013, 'INFRA ESTRUTURA PERSONALIZADA', 100.00, 2)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1014, 'USINAGEM DE COMPONENTE', 15.00, 2)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1015, 'GUIA CURURGICO PARCIAL', 60.00, 2)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1016, 'GUIA CURURGICO TOTAL', 100.00, 2)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1017, 'MONTAGEM DE DIAGNÓSTICO', 60.00, 2)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1018, 'PONTO DE SOLDA À LASER', 0, 3)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1019, 'APLICACAO DE CERÂMICA', 100.00, 4)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1020, 'OMBRO CERÂMICO', 50.00, 4)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1021, 'APLICAÇÃO DE GENGIVA (POR ELEMENTO)', 60.00, 4)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1022, 'JAQUETA/COROA', 350.00, 5)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1023, 'INLAY/ONLAY', 350.00, 5)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1024, 'LENTE DE CONTATO', 350.00, 5)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1025, 'COROA TOTAL', 80.00, 6)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1026, 'INLAY/ONLAY', 80.00, 6)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1027, 'FACETA LAMINADA', 80.00, 6)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1028, 'GENGIVA CERAMAGE', 55.00, 6)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1029, 'APLICAÇÃO', 150.00, 7)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1030, 'COPING', 150.00, 7)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1031, 'FIXA POR ELEMENTO', 150.00, 7)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1032, 'ABUTMENT PERSONALIZADO', 0, 7)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1033, 'PLACA DE CLAREAMENTO', 50.00, 8)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1034, 'PLACA DE BRUXISMO (SILICONE)', 70.00, 8)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1035, 'PROVISÓRIO', 35.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1036, 'PROVISÓRIO SOBRE IMPLANTE', 45.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1037, 'ENCERRAMENTO DE DIAGNÓSTICO', 20.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1038, 'CASQUETE PARA MOLDAGEM', 35.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1039, 'ELEMENTO EM DURALAY', 35.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1040, 'PLANO DE REGISTRO OCLUSAL', 60.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1041, 'MURALHA/INDEX', 25.00, 9)
INSERT INTO Produto(codigo, nome, valor, codigotipo) VALUES(1042, 'MOCAP', 25.00, 9)
GO

--========================================================================================
CREATE TABLE Empresa(
	codigo INT not null,
	empresanome VARCHAR(60),
	dentistadono VARCHAR(60) NOT NULL,
	rua VARCHAR(60),
	numero NCHAR(10),
	bairro VARCHAR(60),
	cidade VARCHAR(60),
	uf CHAR(2),
	cep CHAR(8),
	contatou VARCHAR(11),
	contatod VARCHAR(11)
)
GO

ALTER TABLE Empresa
ADD CONSTRAINT PK_CODIGOEMPRESA
PRIMARY KEY (codigo)
GO

--========================================================================================
CREATE TABLE Pedido(
	codigo INT NOT NULL,
	codigoempresa INT NOT NULL,
	dentista VARCHAR(60),
	datafechamento DATETIME
)
GO

ALTER TABLE Pedido
ADD CONSTRAINT PK_CODIGOPEDIDO
PRIMARY KEY (codigo)
GO

ALTER TABLE Pedido
ADD CONSTRAINT FK_PEDIDO_EMPRESA
FOREIGN KEY(codigoempresa)
REFERENCES Empresa(codigo)
GO

--INSERT INTO Pedido(codigo, codigoempresa, dentista, datafechamento) VALUES (122, 2, 'DR. RAFAEL','2019-06-30')
--INSERT INTO Pedido(codigo, codigoempresa, dentista, datafechamento) VALUES (1000, 2, 'DR. RICARDO', '2019-07-20')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1001, 2, 'DR. ROBERTO')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1002, 2, 'DRA. ROBERTA')
--INSERT INTO Pedido(codigo, codigoempresa, dentista, datafechamento) VALUES (1003, 2, 'DRA. RENATA', '2018-01-30')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1004, 2, 'DRA. AMANDA')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1005, 2, 'DR. MARCIO')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1006, 2, 'DR. LEONARDO')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1007, 2, 'DR. PAULO')
--INSERT INTO Pedido(codigo, codigoempresa, dentista) VALUES (1008, 2, 'DR. GABRIEL')
--GO

--========================================================================================

CREATE TABLE ItemPedido(
	codigo INT NOT NULL IDENTITY(1,1),
	codigoproduto INT NOT NULL,
	codigopedido INT NOT NULL,
	valorunid NUMERIC(8,2) NOT NULL,
	qtde INT NOT NULL,
	paciente VARCHAR(60),
	dataentrega DATETIME
)
GO

ALTER TABLE ItemPedido
ADD CONSTRAINT PK_CODIGOITEMPEDIDO
PRIMARY KEY (codigo)
GO

--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1001, 122, 50.00, 2, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1002, 122, 60.00, 1, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1001, 1000, 50.00, 3, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1003, 122, 70.00, 1, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1001, 1001, 50.00, 2, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1004, 1002, 80.00, 3, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1001, 122, 50.00, 1, 'RODRIGO', '2019-07-20')
--INSERT INTO ItemPedido(codigoproduto, codigopedido, valorunid, qtde, paciente, dataentrega) VALUES (1005, 1005, 90.00, 1, 'RODRIGO', '2019-07-20')
--========================================================================================