select * from Pedidos

select ped. * from Pedidos ped
inner join Clientes cli on ped.ClienteId = cli.Id
where cli.Nome = 'Gabriel'

select SUm (ped.Valor) from Pedidos ped
inner join Clientes cli on ped.ClienteId = cli.Id
where cli.Nome = 'Gabriel'

select 
IIF(SUm (ped.Valor) > 1000, 'brinde xiaomi','Nao ganhou nada ') as 'Resultado',
sum (ped.Valor) as 'Total',
cli.Nome
from Pedidos ped
inner join Clientes cli on ped.ClienteId = cli.Id
group by cli.Nome 

Select 
iif (sum (ped.valor) > 1100 , 'brinde xiaomi','nao ganhou') as 'resultado',
sum (ped.valor) as 'total', 
cli.nome
from clientes cli
inner join Pedidos ped on cli.Id = ped.ClienteId
group by cli.Nome  

