select * from Clientes;
select * from Pedidos;

Select cli. * from Clientes cli
inner join Pedidos ped on cli.Id = ped.ClienteId
where ped.Numero in ('N000000002','N000000004','N000000013')

select * from Pedidos ped
where ped.ClienteId in (select cli.Id from Clientes cli inner join
Pedidos ped on cli.Id = ped.ClienteId where ped.Numero in ('N000000002','N000000004','N000000013'))
order by ped.valor desc
