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

create proc sp_mantenimiento_clientes
@codigo varchar (5),
@nombre varchar (50),
@edad int,
@telefono int,
@accion varchar(50) output
as
 if(@accion='1')
 begin
 declare @codnuevo varchar(5),@codmax varchar(5)
 set @codmax=(select max(codigo) from clientes)
 set @codmax= ISNULL(@codmax,'A0000')

 set @codnuevo='A'+ RIGHT(RIGHT(@codmax,4)+1001,4)
 insert into clientes(codigo,nombre,edad,telefono)
 values(@codnuevo,@nombre,@edad,@telefono)

 set @ ='Se genero el codigo: ' +@codnuevo

 END

 else if (@accion='2')
 begin
 update clientes SET nombre=@nombre, edad=@edad, telefono=@telefono where codigo=@codigo
 set @accion='Se modificó el codigo: ' +@codigo

 end

 else if (@accion='3')
 begin
 delete from clientes where codigo=@codigo
 set @accion