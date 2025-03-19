create database ClinicaUH

use ClinicaUH

create table Paciente(
Cedula int identity primary key,
Nombre varchar(25) not null,
Apellido varchar(25) not null,
Telefono varchar (12) null,
Edad int,
Fecha_de_nacimiento datetime,
Especialidad varchar (50) null
)

create table Medico(
consultorio int identity primary key,
Nombre_medico varchar(25) not null
)

create table Consulta(
ConsultaID int identity primary key,
Fecha_Atencion datetime,
Hora_Atencion datetime,
consultorio int foreign key references Medico(consultorio)
)