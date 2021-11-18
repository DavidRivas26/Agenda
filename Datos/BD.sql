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
	Contra varchar(50)

)



insert into Contactos (Nombre, Apellido, Direccion, Telefono_Personal, Telefono_Trabajo) values (@nombre, @apellido, @direccion, @telefono_personal, @telefono_trabajo)

update Contactos set Nombre=@nombre, Apellido=@apellido, Direccion=@direccion, Telefono_Personal=@telefono_personal, Telefono_Trabajo=@telefono_trabajo where Id=@id

delete Contactos where Id=@id

select Id as Codigo, Nombre, Apellido, Direccion, Telefono_Personal, Telefono_Trabajo from Contactos

select Id, Nombre, Apellido, Direccion, Telefono_Personal, Telefono_Trabajo where Id=@id



insert into Usuarios (Nombre, Apellido, Nombre_Usuario, Contra) values (@nombre, @apellido, @usuario, @contra)

select Id, Nombre, Apellido, Nombre_Usuario, Contra where Id=@id