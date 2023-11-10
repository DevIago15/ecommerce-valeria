---------------------------------------
-- DESTUIR O BANCO DE DADOS, CASO ELE
-- EXITA
---------------------------------------
drop database Lanches_LP_CCO2023
go

---------------------------------------
-- CRIAR O BANCO DE DADOS
---------------------------------------
create database Lanches_LP_CCO2023
go

---------------------------------------
-- ACESSAR O BANCO DE DADOS
---------------------------------------
use Lanches_LP_CCO2023
go

---------------------------------------
-- CRIAR AS TABELAS DO BANCO DE DADOS
---------------------------------------

---------------------------------------
-- TABELA CATEGORIAS
---------------------------------------
create table Categorias
(
	idCat		int			not null	primary key		identity,
	nome		varchar(30)	not null
)
go

---------------------------------------
-- TABELA PRODUTOS
---------------------------------------
create table Produtos
(
	idProduto	int				not null	primary key		identity,
	nome		varchar(20)		not null,
	descricao	varchar(100)	not null,
	qtdProd		int				not null	check(qtdProd >= 0),
	valor		decimal(10,2)		null	check(valor > 0.0),
	urlImg		varchar(150)		null,
	status		int					null,
	catId		int				not null	default 1,
	foreign key	(catId)	references	Categorias(idCat)
)
go

insert into Categorias (nome)
values	('Alimentacao'),
		('Eletrodomestico'),
		('Higiene Pessoal')
go

create procedure sp_CadProduto
(
	@nomeProd	varchar(20),
	@descProd	varchar(100),
	@qtdProd	int,
	@precoProd	decimal(6,2),
	@imgProd	varchar(150),
	@stsProd	int,
	@catIdProd	int
)
as
begin
	insert into Produtos (nome, descricao, qtdProd, valor, urlImg, status, catId)
	values(@nomeProd, @descProd, @qtdProd, @precoProd, @imgProd, @stsProd, @catIdProd)
end 
go

exec sp_CadProduto 'Chocolate', 'Chocolate meio amargo 70%', 100, 12.90, 'choco.png', 1, 1
go

exec sp_CadProduto 'Chiclete', 'Chiclete de menta', 100, 2.90, 'chicle.png', 1, 1
go

select * from Categorias
select * from Produtos
go


create view v_Produto
as
	select P.idProduto, P.nome, P.descricao, P.qtdProd, P.valor, P.urlImg, P.catId, C.nome nomeCat
	from Categorias C, Produtos P
	where P.catId = C.idCat
go

select * from v_Produto
go