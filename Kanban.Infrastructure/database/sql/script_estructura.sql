create database Kanban
use Kanban

create table Usuario (
	Id int Identity(1, 1) not null primary key,
	Nombre varchar(100) not null,
	Email varchar(100) not null,
	Usuario varchar(50) not null,
	Clave varchar(50) not null,
	Estado smallInt not null,
	FechaCreacion datetime not null,
	FechaModificacion datetime not null
)

create table Log (
	Id int Identity(1, 1) not null primary key,
	Query varchar(max) not null,
	FechaCreacion datetime not null,
	Id_Usuario int null

	--foreign key (Id_Usuario) references Usuario (Id)
)

