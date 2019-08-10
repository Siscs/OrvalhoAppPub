--use master
--drop database orvalho
use orvalho

select * from UnidadeMedidas

select * from categorias

insert into Categorias values ('Orgânicos')

select * from produtos

-- -------------------------------

select * from UNIDADEMEDIDAs

select * from produtos

select * from CATEGORIAS

select 
'new Produto() { Nome="' + Nome + '", ' +
'Preco=' + trim(str(preco)) + ', ' +
'Quantidade=' + trim(str(Quantidade)) + ', ' +
'Bloqueado=false, ' +
'CategoriaId=' + trim(str(CategoriaId)) + ', ' +
'UnidadeMedidaId=' + trim(str(UnidadeMedidaId)) + ' }, '
from PRODUTOS
