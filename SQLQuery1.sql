create database DBTeam
go
use Dbteam
go

create table clientes
(
codigo varchar(5),
nombre varchar(50),
apellido varchar(50),
edad int,
telefono int
);
go
create proc sp_listar_clientes
as
select*from clientes order by codigo
go


create proc sp_buscar_clientes
@nombre varchar(50)
as
select codigo,nombre,edad,telefono from clientes where nombre like @nombre + '%'
go



