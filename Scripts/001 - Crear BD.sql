--Crear la base y usarla

CREATE DATABASE Peluqueria
use Peluqueria


--******************
--Crear las tablas
--******************



--*--
--(1) 
--*--
create table Clientes
(
	documento bigint,
	nom_cliente varchar (30),
	ape_cliente varchar (30),
	direccion varchar (80),
	fec_nac_C datetime,
	correo_cliente varchar (30),
	tel_cliente varchar (30)
	constraint PKclientes primary key (documento)	
)
--*--
--(2) 
--*--
create table Avisos
(
	id_aviso int identity(1,1),
	documento bigint not null,
	fecha_aviso datetime
	constraint PKavisos primary key (id_aviso),
	constraint FKavisos_cliente foreign key (documento) references Clientes(documento)
)
--*--
--(3) 
--*--
create table Transacciones
(
id_transaccion int identity(1,1),
documento bigint not null,
fecha datetime,
observaciones varchar (150),
tratamiento varchar (150),
color varchar (150),
productos varchar (150)
constraint PKtransacciones primary key(id_transaccion),
constraint FKtransacciones_clientes foreign key (documento) references Clientes(documento)
)



--*************
--*****FIN*** 
--************








