--Alteração da tabela marcas

update Marcas
set UsuAlt = 1 , UsuInc = 1
where UsuInc = 0


--MArcas que o Felipe cadastrou

select mar.Nome
from Marcas mar
inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

--MArcas que o Giomar cadastrou

select mar.Nome
from Marcas mar
inner join Usuarios usu on mar.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'

--Quantidade de marcas que felipe cadastrou

select count (Mar.Nome) as 'Quantidade de marcas', usu.Usuario
from Marcas mar 
inner join Usuarios usu on mar.usuInc = usu.Id
where Mar.usualt = 1
group by usu.Usuario
order by count (Mar.Nome) desc

--Quantidade de marcas que Giomar cadastrou

select count (Mar.Nome) as 'Quantidade de marcas', usu.Usuario
from Marcas mar 
inner join Usuarios usu on mar.usuInc = usu.Id
where Mar.usualt = 2 
group by usu.Usuario
order by count (Mar.Nome) desc

--Trazer somente a quantidade de marcas que Felipe e Giomar cadastraram 

select count (Mar.Nome) as 'Quantidade de marcas dos dois usuarios',usu.Usuario
from Marcas mar 
inner join Usuarios usu on mar.usuInc = usu.Id
where usu.Usuario like 'Felipe%' or  usu.Usuario like 'Giomar%'
group by usu.Usuario 
order by count (Mar.Nome) desc


--Trazer somente os carros que Felipe cadastrou

select (Car.Modelo) as 'Carros', usu.Usuario 
from Carros car
inner join Usuarios usu on car.UsuAlt = usu.Id
where usu.Usuario like 'Felipe%'


--Trazer somente os carros que Giomar cadastrou

select (Car.Modelo) as 'Carros', usu.Usuario 
from Carros car
inner join Usuarios usu on car.UsuAlt = usu.Id
where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de carros das marcas que Felipe cadastrou maior para menor

select count (car.Modelo) as 'Quantida de carros'
from carros car 
inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Felipe%'

--Trazer somente a quantidade de carros das marcas que Giomar cadastrou maior para menor

select count (car.Modelo) as 'Quantida de carros'
from carros car 
inner join Usuarios usu on car.UsuInc = usu.Id
where usu.Usuario like 'Giomar%'

--Trazer somente a quantidade de carros que Felipe e Giomar cadastraram 

select count (Car.Modelo) as 'Quantidade de Veiculos dos dois usuarios',usu.Usuario
from Carros car 
inner join Usuarios usu on car.usuInc = usu.Id
where usu.Usuario like 'Felipe%' or  usu.Usuario like 'Giomar%'
group by usu.Usuario 
order by count (Car.Modelo) desc

--Trazer somente os carros das marcas que Felipe cadastrou

select count (car.Modelo)
from Carros car
inner join Marcas mar on  car.Marca = mar.Id
inner join Usuarios usu on usu.Id = mar. UsuInc
where usu.Usuario like'Felipe%' and mar.UsuInc = 1
order by count (car.Modelo)

--Trazer somente os carros das marcas que Giomar cadastrou

select 
 count(car.Modelo)
from Carros car
inner join Marcas mar on  car.Marca = mar.Id
inner join Usuarios usu on usu.Id = mar. UsuInc
where usu.Usuario like'Giomar%' and mar.UsuInc = 2
order by count (car.Modelo)
 

--Trazer o valor total de vendas 2019 isolado

select sum (ven.Quantidade * ven.Valor)
from Vendas ven
where YEAR (ven.DatInc) = 2019





