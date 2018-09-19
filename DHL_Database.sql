
-- Codificado por: Jairo Medrano
-- Diagrama de referencia: DHL_Database.png

--Notas:

--	Este Script está basado en el diagrama de entidad-relacion
--	que se encuentra adjunto en esta misma carpeta.

--	Los nombres de las variables y de los campos se escribieron
--	en notacion lowerCamelCase para mayor comodidad al manejarlos, los
--	nombres de las tablas estan escritos en notacion UpperCamelCase	para
--	diferenciarlas de los campos del mismo nombre.

--	Algunos de los scripts para las consultas poseen nombres correlacionales
--	con el fin de evitar la redundancia de nombres originales y tambien para
--	evitar ambigüedades cuando una tabla tenga dos relaciones o más con otra
--	como la tabla Envios y Clientes para este caso.


--  		\\\\\\\//////
--  	   	|   __   __ |
--	       @ --|__| |__|-@
--          |      v    |
--	        \    \___   /
--	    	 \_________/


--	Saludos


use master
if exists (select * from sys.databases where name= 'DHL_Database')
drop database DHL_Database

create database DHL_Database
go

use DHL_Database
go

-- Create table | independientes


create table dbo.Personas(
	id_persona int identity(1,1) not null,
	nombre varchar(45) not null,
	apellido varchar(45) not null,
	identidad varchar(45) not null,
	telefono varchar(20),
	email varchar(45),
	primary key(id_persona)
)
go

create table dbo.Articulos(
	id_articulo int identity(1,1) not null,
	descripcion varchar(45) not null,
	origen varchar(45),
	prohibido bit,
	restringido bit,
	peligroso bit,
	material varchar(45),
	primary key(id_articulo)
)
go

create table dbo.Paises(
	id_paises int identity(1,1) not null,
	nombre varchar(45) not null,
	zona int,
	DHL_ExpressWorldWide bit,
	DHL_Express12 bit,
	DHL_Express9 bit,
	imports bit,
	primary key(id_paises)
)
go

create table dbo.ServiciosExtras(
	id_serviciosExtras int identity(1,1) not null,
	descripcion varchar(45) not null,
	precio decimal(10,2),
	tipoServicioExtra varchar(45),
	primary key(id_ServiciosExtras)
)
go

create table dbo.Almacenaje(
	id_almacenaje int identity(1,1) not null,
	dias int,
	valorTramoInicial decimal(10,2),
	valorTramoFinal decimal(10,2),
	costoFijo decimal(10,2),
	tipoAlmacenaje varchar(45),
	ciudad varchar(45),
	primary key(id_almacenaje)
)
go

create table dbo.TipoPago(
	id_tipoPago int identity(10,2) not null,
	descripcion varchar(45) not null,
	primary key(id_tipoPago)
)
go

create table dbo.TipoServicio(
	id_tipoServicio int,
	descripcion varchar(45)
	primary key(id_tipoServicio)
)
go

create table dbo.TarifasNacionales(
	id_tarifasNacionales int identity(1,1),
	peso decimal(10,2) not null,
	zona1 decimal(10,2) not null,
	ciudad varchar(45) not null,
	tipoServicio varchar(45),
	primary key(id_tarifasNacionales)
)
go

create table dbo.TarifasInternacionales(
	id_tarifasInternacionales int identity(1,1) not null,
	peso decimal(10,2) not null,
	zona1 decimal(10,2) not null,
	zona2 decimal(10,2) not null,
	zona3 decimal(10,2) not null,
	zona4 decimal(10,2) not null,
	zona5 decimal(10,2) not null,
	zona6 decimal(10,2) not null,
	zona7 decimal(10,2) not null,
	primary key(id_tarifasInternacionales)
)
go

create table dbo.Paquetes(
	id_paquete int identity(1,1) not null,
	peso decimal(10,2),
	largo decimal(10,2),
	ancho decimal(10,2),
	profundidad decimal(10,2),
	primary key(id_paquete)
)
go

-- Create table | dependientes

create table dbo.Clientes(
	id_cliente int identity(1,1) not null,
	id_persona int not null,
	direccion varchar(45) not null,
	primary key(id_cliente),
	foreign key(id_persona) references dbo.Personas(id_persona)
)
go

create table dbo.Empleados(
	id_empleado int identity(1,1) not null,
	id_persona int not null,
	cargo varchar(45),
	usuario varchar(45),
	contrasena varchar(45),
	primary key(id_empleado),
	foreign key(id_persona) references dbo.Personas(id_persona)
)
go

create table dbo.ArticulosEnPaquete(
	id_paquete int not null,
	id_articulo int not null,
	primary key(id_paquete, id_articulo),
	foreign key(id_paquete) references dbo.Paquetes(id_paquete),
	foreign key(id_articulo) references dbo.Articulos(id_articulo)
)
go

create table dbo.TipoTarifa(
	id_tipoTarifa int identity(1,1) not null,
	id_tarifasNacionales int,
	id_TarifasInternacionales int,
	primary key(id_tipoTarifa),
	foreign key(id_tarifasNacionales) references dbo.TarifasNacionales(id_tarifasNacionales),
	foreign key(id_tarifasInternacionales) references dbo.TarifasInternacionales(id_tarifasInternacionales)
)
go

create table dbo.Envios(
	id_envio int identity(1,1) not null,
	id_clienteEnvia int not null,
	id_clienteRecibe int not null,
	id_empleado int not null,
	id_paisOrigen int not null,
	id_paisDestino int not null,
	id_tipoTarifa int not null,
	id_tipoPago int not null,
	id_tipoServicio int not null,
	id_almacenaje int,
	id_paquete int not null,
	primary key(id_envio),
	foreign key(id_clienteEnvia) references dbo.Clientes(id_cliente),
	foreign key(id_clienteRecibe) references dbo.Clientes(id_cliente),
	foreign key(id_empleado) references dbo.Empleados(id_empleado),
	foreign key(id_paisOrigen) references dbo.Paises(id_paises),
	foreign key(id_paisDestino) references dbo.Paises(id_paises),
	foreign key(id_tipoTarifa) references dbo.TipoTarifa(id_tipoTarifa),
	foreign key(id_tipoPago) references dbo.TipoPago(id_tipoPago),
	foreign key(id_tipoServicio) references dbo.TipoServicio(id_tipoServicio),
	foreign key(id_almacenaje) references dbo.Almacenaje(id_almacenaje),
	foreign key(id_paquete) references dbo.Paquetes(id_paquete)
)
go

create table dbo.ServiciosEnvios(
	id_envio int not null,
	id_serviciosExtras int not null,
	primary key(id_envio, id_serviciosExtras),
	foreign key(id_envio) references dbo.Envios(id_envio),
	foreign key(id_serviciosExtras) references dbo.ServiciosExtras(id_serviciosExtras)
)
go


-- Create procedures | select * from
create procedure sp_sPersonas as select
	P.id_persona,
	P.nombre,
	P.apellido,
	P.identidad,
	P.telefono,
	P.email
from dbo.Personas P order by P.id_persona asc
go

create procedure sp_sClientes as select
	P.id_persona,
	C.id_cliente,
	P.nombre,
	P.apellido,
	P.identidad,
	P.telefono,
	P.email,
	C.direccion
from dbo.Personas P inner join dbo.Clientes C on C.id_persona = P.id_persona order by C.id_cliente asc
go

create procedure sp_sEmpleados as select
	P.id_persona,
	E.id_empleado,
	P.nombre,
	P.apellido,
	P.identidad,
	P.telefono,
	P.email,
	E.cargo
from dbo.Personas P inner join dbo.Empleados E on E.id_persona = P.id_persona order by E.id_empleado asc
go

create procedure sp_sEmpleadosComplete as select
	P.id_persona,
	E.id_empleado,
	P.nombre,
	P.apellido,
	P.identidad,
	P.telefono,
	P.email,
	E.cargo
from dbo.Personas P inner join dbo.Empleados E on E.id_persona = P.id_persona order by E.id_empleado asc
go

create procedure sp_sArticulos as select
	A.id_articulo,
	A.descripcion,
	A.origen,
	A.prohibido,
	A.restringido,
	A.peligroso,
	A.material
from dbo.Articulos A order by A.id_articulo asc
go

create procedure sp_sPaises as select
	P.id_paises,
	P.nombre,
	P.zona,
	P.DHL_ExpressWorldWide,
	P.DHL_Express12,
	P.DHL_Express9
from dbo.Paises P order by P.id_paises asc
go

create procedure sp_sServiciosExtras as select
	SE.id_serviciosExtras,
	SE.descripcion,
	SE.precio,
	SE.tipoServicioExtra
from dbo.ServiciosExtras SE order by SE.id_serviciosExtras asc
go

create procedure sp_sAlmacenaje as select
	A.id_almacenaje,
	A.dias,
	A.valorTramoInicial,
	A.valorTramoFinal,
	A.costoFijo,
	A.tipoAlmacenaje,
	A.ciudad
from dbo.Almacenaje A order by A.id_almacenaje asc
go

create procedure sp_sTipoPago as select
	TP.id_tipoPago,
	TP.descripcion
from dbo.TipoPago TP order by TP.id_tipoPago asc
go

create procedure sp_sTipoServicio as select
	TS.id_tipoServicio,
	TS.descripcion
from dbo.TipoServicio TS order by TS.id_tipoServicio asc
go

create procedure sp_sTarifasNacionales as select
	TN.id_tarifasNacionales,
	TN.peso,
	TN.zona1,
	TN.ciudad,
	TN.tipoServicio
from dbo.TarifasNacionales TN order by TN.id_tarifasNacionales asc
go

create procedure sp_sTarifasInternacionales as select
	TI.id_tarifasInternacionales,
	TI.peso,
	TI.zona1,
	TI.zona2,
	TI.zona3,
	TI.zona4,
	TI.zona5,
	TI.zona6,
	TI.zona7
from dbo.TarifasInternacionales TI order by TI.id_tarifasInternacionales asc
go

create procedure sp_sPaquetes as select
	P.id_paquete,
	P.peso,
	P.largo,
	P.ancho,
	P.profundidad
from dbo.Paquetes P order by P.id_paquete asc
go

create procedure sp_sArticulosEnPaquetes
	@id_paquete int
as select
	A.id_articulo,
	A.descripcion,
	A.origen,
	A.prohibido,
	A.restringido,
	A.peligroso,
	A.material
from dbo.ArticulosEnPaquete AP inner join dbo.Articulos A on
	AP.id_articulo = A.id_articulo
where
	AP.id_paquete = @id_paquete
go

create procedure sp_sServiciosEnvios
	@id_envio int
as select
	SE.id_serviciosExtras,
	SE.descripcion,
	SE.precio,
	SE.tipoServicioExtra
from dbo.ServiciosEnvios SEN inner join dbo.ServiciosExtras SE on
	SEN.id_serviciosExtras = SE.id_serviciosExtras
where
	SEN.id_envio = @id_envio
go

create procedure sp_sTipoTarifa
	@id_TipoTarifa int
as select * from dbo.TipoTarifa TT inner join
	dbo.TarifasInternacionales TI on TT.id_tarifasInternacionales = TI.id_tarifasInternacionales inner join
	dbo.TarifasNacionales TN on TT.id_tarifasNacionales = TN.id_tarifasNacionales
where TT.id_tipoTarifa = @id_TipoTarifa
go

create procedure sp_sEnviosId as select
	E.id_envio
from dbo.Envios E order by E.id_envio asc
go

create procedure sp_sEnviosCompleto as select * from
	dbo.Envios E order by E.id_envio
go


-- Create procedures / insert into


create procedure sp_iPersonas
	@nombre varchar(45),
	@apellido varchar(45),
	@identidad varchar(45),
	@telefono varchar(20),
	@email varchar(45)
as insert into dbo.Personas(
	nombre,
	apellido,
	identidad,
	telefono,
	email
)values(
	@nombre,
	@apellido,
	@identidad,
	@telefono,
	@email
)
go

create procedure sp_iClientes
	@id_persona int,
	@direccion varchar(45)
as insert into dbo.Clientes(
	id_persona,
	direccion
)values(
	@id_persona,
	@direccion
)
go

create procedure sp_iEmpleados
	@id_persona int,
	@cargo varchar(45),
	@usuario varchar(45),
	@contrasena varchar(45)
as insert into dbo.Empleados(
	id_persona,
	cargo,
	usuario,
	contrasena
)values(
	@id_persona,
	@cargo,
	@usuario,
	@contrasena
)
go

create procedure sp_iArticulos
	@descripcion varchar(45),
	@origen varchar(45),
	@prohibido bit,
	@restringido bit,
	@peligroso bit,
	@material varchar(45)
as insert into dbo.Articulos(
	descripcion,
	origen,
	prohibido,
	restringido,
	peligroso,
	material
)values(
	@descripcion,
	@origen,
	@prohibido,
	@restringido,
	@peligroso,
	@material
)
go

create procedure sp_iPaises
	@nombre varchar(45),
	@zona int,
	@DHL_ExpressWorldWide bit,
	@DHL_Express12 bit,
	@DHL_Express9 bit
as insert into dbo.Paises(
	nombre,
	zona,
	DHL_ExpressWorldWide,
	DHL_Express12,
	DHL_Express9
)values(
	@nombre,
	@zona,
	@DHL_ExpressWorldWide,
	@DHL_Express12,
	@DHL_Express9
)
go

create procedure sp_iServiciosExtras
	@descripcion varchar(45),
	@precio decimal(10,2),
	@tipoServicioExtra varchar(45)
as insert into dbo.ServiciosExtras(
	descripcion,
	precio,
	tipoServicioExtra
)values(
	@descripcion,
	@precio,
	@tipoServicioExtra
)
go

create procedure sp_iAlmacenaje
	@dias int,
	@valorTramoInicial decimal(10,2),
	@valorTramoFinal decimal(10,2),
	@costoFijo decimal(10,2),
	@tipoAlmacenaje varchar(45),
	@ciudad varchar(45)
as insert into dbo.Almacenaje(
	dias,
	valorTramoInicial,
	valorTramoFinal,
	costoFijo,
	tipoAlmacenaje,
	ciudad
)values(
	@dias,
	@valorTramoInicial,
	@valorTramoFinal,
	@costoFijo,
	@tipoAlmacenaje,
	@ciudad
)
go

create procedure sp_iTipoPago
	@descripcion varchar(45)
as insert into dbo.TipoPago(
	descripcion
)values(
	@descripcion
)
go

create procedure sp_iTipoServicio
	@descripcion varchar(45)
as insert into dbo.TipoServicio(
	descripcion
)values(
	@descripcion
)
go

create procedure sp_iTarifasNacionales
	@peso decimal(10,2),
	@zona1 decimal(10,2),
	@ciudad varchar(45),
	@tipoServicio varchar(45)
as insert into dbo.TarifasNacionales(
	peso,
	zona1,
	ciudad,
	tipoServicio
)values(
	@peso,
	@zona1,
	@ciudad,
	@tipoServicio
)
go

create procedure sp_iTarifasInternacionales
	@peso decimal(10,2),
	@zona1 decimal(10,2),
	@zona2 decimal(10,2),
	@zona3 decimal(10,2),
	@zona4 decimal(10,2),
	@zona5 decimal(10,2),
	@zona6 decimal(10,2),
	@zona7 decimal(10,2)
as insert into dbo.TarifasInternacionales(
	peso,
	zona1,
	zona2,
	zona3,
	zona4,
	zona5,
	zona6,
	zona7
)values(
	@peso,
	@zona1,
	@zona2,
	@zona3,
	@zona4,
	@zona5,
	@zona6,
	@zona7
)
go

create procedure sp_iPaquetes
	@peso decimal(10,2),
	@largo decimal(10,2),
	@ancho decimal(10,2),
	@profundidad decimal(10,2)
as insert into dbo.Paquetes(
	peso,
	largo,
	ancho,
	profundidad
)values(
	@peso,
	@largo,
	@ancho,
	@profundidad
)
go

create procedure sp_iArticulosEnPaquete
	@id_paquete int,
	@id_articulo int
as insert into dbo.ArticulosEnPaquete(
	id_paquete,
	id_articulo
)values(
	@id_paquete,
	@id_articulo
)
go

create procedure sp_iTipoTarifa
	@id_tarifasNacionales int,
	@id_tarifasInternacionales int
as insert into dbo.TipoTarifa(
	id_tarifasNacionales,
	id_TarifasInternacionales
)values(
	@id_tarifasNacionales,
	@id_TarifasInternacionales
)
go

create procedure sp_iEnvios
	@id_clienteEnvia int,
	@id_clienteRecibe int,
	@id_empleado int,
	@id_paisOrigen int,
	@id_paisDestino int,
	@id_tipoTarifa int,
	@id_tipoPago int,
	@id_tipoServicio int,
	@id_Almacenaje int,
	@id_paquete int
as insert into dbo.Envios(
	id_clienteEnvia,
	id_clienteRecibe,
	id_empleado,
	id_paisOrigen,
	id_paisDestino,
	id_tipoTarifa,
	id_tipoPago,
	id_tipoServicio,
	id_Almacenaje,
	id_paquete
)values(
	@id_clienteEnvia,
	@id_clienteRecibe,
	@id_empleado,
	@id_paisOrigen,
	@id_paisDestino,
	@id_tipoTarifa,
	@id_tipoPago,
	@id_tipoServicio,
	@id_Almacenaje,
	@id_paquete
)
go

create procedure sp_iServiciosEnvios
	@id_envio int,
	@id_serviciosExtras int
as insert into dbo.ServiciosEnvios(
	id_envio,
	id_serviciosExtras
)values(
	@id_envio,
	@id_serviciosExtras
)
go

-- create procedure | update from

create procedure sp_uPersonas
	@id_persona int,
	@nombre varchar(45),
	@apellido varchar(45),
	@identidad varchar(45),
	@telefono varchar(20),
	@email varchar(45)
as update dbo.Personas set
	nombre = @nombre,
	apellido = @apellido,
	identidad = @identidad,
	telefono = @telefono,
	email = @email
where
	id_persona = @id_persona
go

create procedure sp_uClientes
	@id_cliente int,
	@id_persona int,
	@direccion varchar(45)
as update dbo.Clientes set
	id_persona = @id_persona,
	direccion = @direccion
where
	id_cliente = @id_cliente
go

create procedure sp_uEmpleados
	@id_empleado int,
	@id_persona int,
	@cargo varchar(45),
	@usuario varchar(45),
	@contrasena varchar(45)
as update dbo.Empleados set
	id_persona = @id_persona,
	cargo = @cargo,
	usuario = @usuario,
	contrasena = @contrasena
where
	id_empleado = @id_empleado
go

create procedure sp_uArticulos
	@id_articulo int,
	@descripcion varchar(45),
	@origen varchar(45),
	@prohibido bit,
	@restringido bit,
	@peligroso bit,
	@material varchar(45)
as update dbo.Articulos set
	descripcion = @descripcion,
	origen = @origen,
	prohibido = @prohibido,
	restringido = restringido,
	peligroso = @peligroso,
	material = @material
where
	id_articulo = @id_articulo
go

create procedure sp_uPaises
	@id_paises int,
	@nombre varchar(45),
	@zona int,
	@DHL_ExpressWorldWide bit,
	@DHL_Express12 bit,
	@DHL_Express9 bit
as update dbo.Paises set
	nombre = @nombre,
	zona = @zona,
 	DHL_ExpressWorldWide = @DHL_ExpressWorldWide,
	DHL_Express12 = @DHL_Express12,
	DHL_Express9 = @DHL_Express9
where
	id_paises = @id_paises
go

create procedure sp_uServiciosExtras
	@id_serviciosExtras int,
	@descripcion varchar(45),
	@precio decimal(10,2),
	@tipoServicioExtra varchar(45)
as update dbo.ServiciosExtras set
	descripcion = @descripcion,
	precio = @precio,
	tipoServicioExtra = @tipoServicioExtra
where
	id_serviciosExtras = @id_serviciosExtras
go

create procedure sp_uAlmacenaje
	@id_almacenaje int,
	@dias int,
	@valorTramoInicial decimal(10,2),
	@valorTramoFinal decimal(10,2),
	@costoFijo decimal(10,2),
	@tipoAlmacenaje varchar(45),
	@ciudad varchar(45)
as update dbo.Almacenaje set
	dias = @dias,
	valorTramoInicial = @valorTramoInicial,
	valorTramoFinal = @valorTramoFinal,
	costoFijo = @costoFijo,
	tipoAlmacenaje = @tipoAlmacenaje,
	ciudad = @ciudad
where
	id_almacenaje = @id_Almacenaje
go

create procedure sp_uTipoPago
	@id_tipoPago int,
	@descripcion varchar(45)
as update dbo.TipoPago set
	descripcion = @descripcion
where
	id_tipoPago = @id_tipoPago
go

create procedure sp_uTipoServicio
	@id_tipoServicio int,
	@descripcion varchar(45)
as update dbo.TipoServicio set
	descripcion = @descripcion
where
	id_tipoServicio = @id_tipoServicio
go

create procedure sp_uTarifasNacionales
	@id_tarifasNacionales	int,
	@peso decimal(10,2),
	@zona1 decimal(10,2),
	@ciudad varchar(45),
	@tipoServicio varchar(45)
as update dbo.TarifasNacionales set
	peso = @peso,
	zona1 = @zona1,
	ciudad = @ciudad,
	tipoServicio = @tipoServicio
where
	id_tarifasNacionales = @id_tarifasNacionales
go

create procedure sp_uTarifasInternacionales
	@id_tarifasInternacionales	int,
	@peso decimal(10,2),
	@zona1 decimal(10,2),
	@zona2 decimal(10,2),
	@zona3 decimal(10,2),
	@zona4 decimal(10,2),
	@zona5 decimal(10,2),
	@zona6 decimal(10,2),
	@zona7 decimal(10,2)
as update dbo.TarifasInternacionales set
	peso = @peso,
	zona1 = @zona1,
	zona2 = @zona2,
	zona3 = @zona3,
	zona4 = @zona4,
	zona5 = @zona5,
	zona6 = @zona6,
	zona7 = @zona7
where
	id_TarifasInternacionales = @id_tarifasInternacionales
go

create procedure sp_uPaquetes
	@id_paquete int,
	@peso decimal(10,2),
	@largo decimal(10,2),
	@ancho decimal(10,2),
	@profundidad decimal(10,2)
as update dbo.Paquetes set
	peso = @peso,
	largo = @largo,
	ancho = @ancho,
	profundidad = @profundidad
where
	id_paquete = @id_paquete
go

create procedure sp_uArticulosEnPaquete
	@id_paquete int,
	@id_articulo int
as update dbo.ArtivulosEnPaquete set
	id_articulo = @id_articulo
where
	id_paquete = @id_paquete
go

create procedure sp_uTipoTarifa
	@id_tipoTarifa int,
	@id_tarifasNacionales int,
	@id_tarifasInternacionales int
as update dbo.TipoTarifa set
	id_tarifasNacionales = @id_tarifasNacionales,
	id_tarifasInternacionales = @id_tarifasInternacionales
where
	id_tipoTarifa = @id_tipoTarifa
go

create procedure sp_uEnvios
	@id_envio int,
	@id_clienteEnvia int,
	@id_clienteRecibe int,
	@id_empleado int,
	@id_paisOrigen int,
	@id_paisDestino int,
	@id_tipoTarifa int,
	@id_tipoPago int,
	@id_tipoServicio int,
	@id_almacenaje int,
	@id_paquete int
as update dbo.Envios set
	id_clienteEnvia = @id_clienteEnvia,
	id_clienteRecibe = @id_clienteRecibe,
	id_empleado = @id_empleado,
	id_paisOrigen = @id_paisOrigen,
	id_paisDestino = @id_paisDestino,
	id_tipoTarifa = @id_tipoTarifa,
	id_tipoPago = @id_tipoPago,
	id_tipoServicio = @id_tipoServicio,
	id_almacenaje = @id_almacenaje,
	id_paquete = @id_paquete
where
	id_envio = @id_envio
go

create procedure sp_uServicioEnvios
	@id_envio int,
	@id_serviciosExtras int
as update dbo.ServiciosEnvios set
	id_serviciosExtras = @id_serviciosExtras
where
	id_envio = @id_envio
go


-- create procedure | delete

create procedure sp_dPersonas
	@id_persona int
as delete from
	dbo.Personas
where
	id_persona = @id_persona
go

create procedure sp_dClientes
	@id_cliente int
as delete from
	dbo.Clientes
where
	id_cliente = @id_cliente
go

create procedure sp_dEmpleados
	@id_empleado int
as delete from
	dbo.Empleados
where
	id_empleado = @id_empleado
go

create procedure sp_dArticulos
	@id_articulo int
as delete from
	dbo.Articulos
where
	id_articulo = @id_articulo
go

create procedure sp_dPaises
	@id_paises int
as delete from
	dbo.Paises
where
	id_paises = @id_paises
go

create procedure sp_dServiciosExtras
	@id_serviciosExtras int
as delete from
	dbo.ServiciosExtras
where
	id_serviciosExtras = @id_serviciosExtras
go

create procedure sp_dAlmacenaje
	@id_almacenaje int
as delete from
	dbo.Almacenaje
where
	id_almacenaje = @id_almacenaje
go

create procedure sp_dTipoPago
	@id_tipoPago int
as delete from
	dbo.TipoPago
where
	id_tipoPago = @id_tipoPago
go

create procedure sp_dTipoServicio
	@id_tipoServicio int
as delete from
	dbo.TipoServicio
where
	id_tipoServicio = @id_tipoServicio
go

create procedure sp_dTarifasNacionales
	@id_tarifasNacionales int
as delete from
	dbo.TarifasNacionales
where
	id_tarifasNacionales = @id_tarifasNacionales
go

create procedure sp_dTarifasInternacionales
	@id_tarifasInternacionales int
as delete from
	dbo.TarifasInternacionales
where
	id_tarifasInternacionales = @id_tarifasInternacionales
go

create procedure sp_dArticulosEnPaquete
	@id_paquete int,
	@id_articulo int
as delete from
	dbo.sp_dArticulosEnPaquete
where
	id_paquete = @id_paquete and id_articulo = @id_articulo
go

create procedure sp_dTipoTarifa
	@id_tipoTarifa int
as delete from
	dbo.tipoTarifa
where
	id_tipoTarifa = @id_tipoTarifa
go

create procedure sp_dEnvios
	@id_envio int
as delete from
	dbo.Envio
where
	id_envio = @id_envio
go

create procedure sp_dServiciosEnvios
	@id_envio int,
	@id_serviciosExtras int
as delete from
	dbo.ServiciosEnvios
where
	id_envio = @id_envio and id_serviciosExtras = @id_serviciosExtras
go


create procedure sp_ultimaPersona as select max(id_persona) ultimoRegistro from dbo.Personas
go

-- executes

exec sp_iPersonas "Manuel Alejandro", "Gamez Montoya", "0512-1989-55447","97721848","manuelito28@gmail.com"
exec sp_iPersonas "Ana Lourdes", "Urrea Mansur", "0512-1988-54547","99663322","anita@gmail.com"
exec sp_iPersonas "Mauricio Eliseo", "Hernandez Mendez", "0801-1995-02616","95487844","luis@gmail.com"

exec sp_iClientes 1,"Col: Loarque"

exec sp_iEmpleados 2,"Asesor","anitaurrea1234","1234"
exec sp_iEmpleados 3,"Asesor","hernandez123","h1234"

exec sp_iArticulos "Mauser KAR-37", "Alemania", 0,0,0,"Metal"


exec sp_sPersonas
exec sp_sArticulos

exec sp_ultimaPersona