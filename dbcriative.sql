//CRIAR ESSA BASE DE DADOS COM ESSAS TABELAS NO SQL SERVER ATUAL.
//DEPOIS, INTEGRAR ESSES DADOS UTILIZANDO O CONECTIONSTRING DA CAMADA DE CONTROL.

DROP DATABASE dbcriative
GO

CREATE DATABASE dbcriative
GO

USE dbcriative
GO

CREATE TABLE Empresa(
	codigo INT PRIMARY KEY,
	nome VARCHAR(60),
	nomedono VARCHAR(60) NOT NULL,
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

CREATE TABLE Produto(
	codigo INT PRIMARY KEY,
	nome VARCHAR(100) not null,
	valor NUMERIC(8,2) not null
)
GO

CREATE TABLE Pedido(
	codigo INT PRIMARY KEY,
	codigoempresa INT NOT NULL,
	dentista VARCHAR(60),
	paciente VARCHAR(60) NOT NULL,
	dataentrada DATETIME,
	datasaida DATETIME
)
GO

CREATE TABLE ItemPedido(
	codigo INT PRIMARY KEY IDENTITY(1,1),
	codigoproduto INT NOT NULL,
	codigopedido INT NOT NULL,
	valorunid NUMERIC(8,2) NOT NULL,
	qtde INT NOT NULL
)
GO

CREATE TABLE Observacao(
	codigo INT PRIMARY KEY IDENTITY(1,1),
	codigoitempedido INT NOT NULL,
	obser VARCHAR(60) NOT NULL,
	valor NUMERIC(8,2) NOT NULL
)
GO

ALTER TABLE Pedido
ADD CONSTRAINT FK_Pedido_Empresa
FOREIGN KEY(codigoempresa)
REFERENCES Empresa(codigo)
GO

ALTER TABLE ItemPedido
ADD CONSTRAINT FK_ItemPedido_Pedido
FOREIGN KEY(codigopedido)
REFERENCES Pedido(codigo)
GO

ALTER TABLE ItemPedido
ADD CONSTRAINT FK_ItemPedido_Produto
FOREIGN KEY(codigoproduto)
REFERENCES Produto(codigo)
GO

ALTER TABLE Observacao
ADD CONSTRAINT FK_Observacao_ItemPedido
FOREIGN KEY(codigoitempedido)
REFERENCES ItemPedido(codigo)
GO

CREATE PROCEDURE AlterarEmpresaCliente
	@codigoantigo int,
	@codigo int,
	@nome varchar(60),
	@nomedono varchar(60),
	@rua varchar(60),
	@numero nchar(10),
	@bairro varchar(60),
	@cidade varchar(60),
	@uf nchar(2),
	@cep nchar(8),
	@contatou varchar(11),
	@contatod varchar(11)
AS
BEGIN
	UPDATE Pedido set codigoempresa = @codigo WHERE codigoempresa = @codigoantigo
	UPDATE Empresa set codigo = @codigo, nome = @nome, nomedono = @nomedono, rua = @rua, numero = @numero, bairro = @bairro, cidade = @cidade, uf = @uf, cep = @cep,contatou = @contatou, contatod = @contatod WHERE codigo = @codigoantigo
	RETURN @codigo
END
GO

CREATE PROCEDURE AlterarProdutoItemPedido
	@codigoantigo int,
	@codigo int,
	@nome varchar(100),
	@valor decimal
AS
BEGIN
	UPDATE ItemPedido set codigoproduto = @codigo WHERE codigoproduto = @codigoantigo
	UPDATE Produto set codigo = @codigo, nome = @nome, valor = @valor WHERE codigo = @codigoantigo
	RETURN @codigo
END
GO

CREATE PROCEDURE OrdemServico
	@codigopedido int
AS
	SELECT P.codigo, E.nome, P.dentista, P.paciente, P.dataentrada, P.datasaida, A.codigo, A.nome, I.valorunid, I.qtde FROM Pedido P INNER JOIN Empresa E ON P.codigoempresa = E.codigo INNER JOIN ItemPedido I ON I.codigopedido = P.codigo INNER JOIN Produto A ON A.codigo = I.codigoproduto WHERE P.codigo = @codigopedido
RETURN 0
GO