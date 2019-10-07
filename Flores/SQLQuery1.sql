insert into Flores (Nome,Quantidade ) values 
('Rosa',3),
('Margarida', 4),
('Copo de leite',2),
('11 horas',5),
('Violeta',4)

--Devemos ter uma seleção ordenada das flores, da que contem a maior quantidade para a menor

select *from Flores order by Quantidade desc

--Devemos retornar uma seleção com a quantidade total de flores que temos em nossa tabela

select count(*) from Flores

