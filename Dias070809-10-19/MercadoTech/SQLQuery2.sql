insert into Funcionarios (Nome) values ('Gabriel'),('Giomar');


insert into Produtos (Nome, Valor) values 
('Skol', 5.49),
('Budweiser', 6.99),
('Stela' , 3.49),
('Patagonia', 15.90),
('Corona Extra', 4.99)

select * from Produtos

select * from Funcionarios
select * from Produtos
select*from Pedidos

insert into Pedidos (FuncionarioId,ProdutoId,Quantidade) values 
(3,5,4),
(3,4,4),
(4,5,10)

--ordem alfabetidaca
select * from Funcionarios order by Nome

--Listar produtos dos mais caros pros mais baratos
select * from Produtos order by Valor desc

--Vamos listar em uma seleção de nossos pedidos por funcionario trazendo o nome do funcionario

select ped.Id,  
fun.Nome,
ped.ProdutoId,
ped.Quantidade
from Pedidos ped inner join Funcionarios fun
on ped.FuncionarioId = fun.Id


--Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando sua respectiva quantidade de itens

Select 
fun.Nome,
sum(ped.Quantidade) as 'Quantidade'
from Pedidos ped 
inner join Funcionarios fun on ped.FuncionarioId = fun.Id
group by fun.Nome

--Vamos listar em uma seleção de nossos pedidos agrupando por funcionario os pedidos e somando seu valor total 
	--lembrando que o valor total e a a "quantidade * valor"

	select fun.Nome,
	sum(ped.Quantidade * pro.Valor) as 'Total'
	from Pedidos ped
	inner join Funcionarios fun on ped.FuncionarioId = fun.Id
	inner join Produtos pro on ped.ProdutoId = pro.Id
	group by fun.Nome

--Vamos retornar em uma seleção nosso produto mais pedido dentro de nossa base de dados

select top 1  pro.Nome ,sum (ped.Quantidade) as 'Quantidade'  from Produtos pro inner join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome
order by sum ( ped.Quantidade) desc

--Produto que gerou a maior receita dentro da base de dados

select top 1 pro.Nome, sum (ped.Quantidade * pro.Valor) as 'Receita' from Produtos pro
inner join Pedidos ped on pro.Id = ped.Id
group by pro.Nome
order by 'Receita' desc

--Vamos retornar em uma seleção para o primeiro funcionario os produtos que ele não comprou de nosso mercado


select * from Produtos 
where Id not in (
select pro.Id from Funcionarios fun 
inner join Pedidos ped on fun.Id = ped.FuncionarioId 
inner join Produtos pro on ped.ProdutoId = pro.Id
where fun.Nome like 'Gabriel%')


-- Vamos retornar em uma seleção os produtos ordenados pela ordem do mais comprado para o menos comprado

select pro.Nome, count (ped.ProdutoId) as 'Quantidade'from Produtos pro 
left join Pedidos ped on pro.Id = ped.ProdutoId
group by pro.Nome
order by 'Quantidade' desc





