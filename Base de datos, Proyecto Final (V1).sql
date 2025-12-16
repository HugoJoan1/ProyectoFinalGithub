create database Empresa;
Use Empresa;
create table Empleados
(
Codigo			int(10)			not null,
Nombre			varchar(60)		not null,
Puesto			varchar(100)	not null,
Sexo			varchar(100)	not null,
Estado			varchar(30)		not null
);
select * From Empleados;