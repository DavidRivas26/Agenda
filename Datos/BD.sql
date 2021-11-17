create database Ejercicio_10

use Ejercicio_10

create table Contactos
(

	Id int identity,
	Nombre varchar(50),
	Apellido varchar(50),
	Direccion varchar(100),
	Telefono_Personal varchar(25),
	Telefono_Trabajo varchar(25)

)

create table Usuarios
(

	Id int identity,
	Nombre varchar(50),
	Apellido varchar(50),
	Nombre_Usuario varchar(50),
	Contra varchar(50),
	Confirmar_Contra varchar(50)

)

select * from Contactos

select * from Usuarios