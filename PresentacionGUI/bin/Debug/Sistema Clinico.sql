create database SistemaClinico
go
use SistemaClinico
Go
Create table Usuario(
Id_Usuario nvarchar (20) primary key ,
Nombre_Usuario varchar(50),
Apellido_Usuario varchar(50),
Cargo_Usuario varchar(30),
Contraseña_Usuasio nvarchar(10)
);
Go
Create table Paciente(
Dui int primary key not null,
Nombre_Paciente varchar(50),
Apellidos_Paciente varchar(50),
Sexo_Paciente nvarchar(1),
Telefono_Paciente int,
Direccion_Paciente varchar(250),
EstadoCivil nvarchar(20),
FechaNacimiento datetime,
);
Go
Create table Expediente(
Num_Expediente int identity (1,1) primary key,
FechaCreacion datetime,
Antecedentes_Clinicos varchar(100),
Medicamentos_Escritos varchar(200),
tipo_sangre varchar(5),
dui int references Paciente(Dui)
);
go
Create table Diagnostico(
Id_Diagnostico int primary key identity(1,1),
Estado varchar(50),
Enfermedad nvarchar(250),
Peso float,
estatura float,
presion float,
fechaDiagnostico datetime,
temperatura float,
detalles varchar(200),
recomendaciones varchar(200),
Num_Expediente int references Expediente(Num_Expediente)
);
Go

Create table Citas(
num_cita int primary key identity(1,1),
Fecha_HoraCreacion datetime,
Fecha_HoraCita datetime unique,
Motivo varchar(100),
CreadoPor nvarchar(100),
Precio float,
dui int references Paciente(dui));

Go
Insert into Usuario
values('admin','Alexander','Palma','Administrador','admin'),
('Billy','Billy','Mejia','Administrador','Billy2'),
('Carlos','Carlos','Sanchez','Administrador','Carlos3'),
('Fredy','Fredy','Mercury','Administrador','Fredy4'),
('Gabriel','Gabriel','Guidos','Administrador','Gabriel5'),
('Jeremias','Jeremias','Escobar','Administrador','Jeremias6'),
('Josue','Josue','Flores','Administrador','Josue7'),
('Pablo','Pablo','Escobar','Doctor','Pablo8'),
('Rubi','Rubi','Sanchez','Enfermera','Rubi9')
Go
insert into Paciente values 
(105698367,'Juan','Perez','M',22559678,'San Juan','Soltero','19990618'),
(145963248,'Jose','Flores','M',25504870,'Ilopango','Casado','19901210'),
(549320157,'Maria','Martinez','F',70801465,'Soyapango','Soltera','19950522'),
(586315774,'Jennifer','Aguilar','F',76524893,'San Miguel','Casado','20001203'),
(259863104,'Nancy','Lopez','F',73598614,'Mejicanos','Soltera','19980210'),
(496852301,'Pedro','Castro','M',79651236,'Ciudad Delgado','Casado','19931008'),
(596321458,'Jaime','Juarez','M',71102560,'La Cima','Soltero','19850520'),
(863254109,'Jazmin','Ortega','F',74563259,'Lourdes Colon','Soltera','19990616'),
(102598171,'Karla','Guzman','F',60489530,'Alta Vista','Casado','20000130'),
(369851450,'Paola','Aleman','F',74698520,'San Juan Opico','Soltera','19950615')
Go 
insert into Expediente values 
(SYSDATETIME(),'Ninguno','Ninguno','O +',105698367),
(SYSDATETIME(),'Riuma','Dolofin','A -',145963248),
(SYSDATETIME(),'Daltonico','Ninguno','O +',549320157),
(SYSDATETIME(),'Asmatico','Metaproterenol','AB +',586315774),
(SYSDATETIME(),'Ninguno','Ninguno','B -',259863104),
(SYSDATETIME(),'Ninguno','Nunguno','B +',496852301),
(SYSDATETIME(),'Chikungunya','Analgesicos','O -',596321458),
(SYSDATETIME(),'Covid 19','Hidroxicloroquina','AB -',863254109),
(SYSDATETIME(),'Ninguno','Ninguno','A +',102598171),
(SYSDATETIME(),'Ninguno','Ninguno','A -',369851450)
Go
Insert into Diagnostico
values('Estable','Reflujo gastroesofágico',67,1.68,110,SYSDATETIME(),38,'Restablecer el estado del paciente','Evitar comida chatarra y jugos artificiales',1),
('Moderado','Rinitis',65,1.62,120,SYSDATETIME(),40,'Mejorar su regulacion respiratoria','Evitar comer cosas heladas',2),
('Critico','Cancer colorrectal',60,1.42,98,SYSDATETIME(),35,'Evitar el Avanze del cancer encontrado en el paciente','Dieta y Nutricion adecuada',3),
('Estable','Deshidratacion',62,1.56,122,SYSDATETIME(),39,'Restablezer la hidratacion del paciente','Dieta y Nutricion adecuada',4),
('Estable','Dolor severo de cabeza',67,1.76,117,SYSDATETIME(),37,'Evitar el posible avanze del dolor','Tomar descanso adecuadamente',5),
('Estable','Dolor Estomacal',65,1.66,107,SYSDATETIME(),34,'Controlar el dolor estomacal','Dieta y Nutricion adecuada',6)
Go
Insert into Citas
values
(SYSDATETIME(),'20200218 10:00','Enfermedad Cronica','Ruby',15.99,369851450),
(SYSDATETIME(),'20200217 9:00','Sintomas de Covid-19','Ruby',25.99,102598171),
(SYSDATETIME(),'20200220 10:00','Chequeo General','Ruby',10.99,863254109),
(SYSDATETIME(),'20200222 11:00','Malestar Estomacal','Ruby',22.99,596321458),
(SYSDATETIME(),'20200328 15:00','Chequeo General','Ruby',10.99,586315774),
(SYSDATETIME(),'20200330 16:00','Dolor de Lumbago','Ruby',15.99,549320157),
(SYSDATETIME(),'20200301 7:00','Infeccion de vias urinarias','Ruby',15.99,145963248),
(SYSDATETIME(),'20200425 14:00','Chequedo de Diabetes','Ruby',15.99,259863104),
(SYSDATETIME(),'20200428 15:00','Chequeo General','Ruby',10.99,586315774),
(SYSDATETIME(),'20200430 16:00','Dolor de Lumbago','Ruby',15.99,549320157),
(SYSDATETIME(),'20200401 7:00','Infeccion de vias urinarias','Ruby',15.99,145963248),
(SYSDATETIME(),'20200520 10:00','Chequeo General','Ruby',10.99,863254109),
(SYSDATETIME(),'20200522 11:00','Malestar Estomacal','Ruby',22.99,596321458),
(SYSDATETIME(),'20200524 13:00','Terapia de Asma','Ruby',35.99,496852301),
(SYSDATETIME(),'20200525 14:00','Chequedo de Diabetes','Ruby',15.99,259863104),
(SYSDATETIME(),'20200618 10:00','Enfermedad Cronica','Ruby',15.99,369851450),
(SYSDATETIME(),'20200617 9:00','Sintomas de Covid-19','Ruby',25.99,102598171),
(SYSDATETIME(),'20200620 10:00','Chequeo General','Ruby',10.99,863254109),
(SYSDATETIME(),'20200622 11:00','Malestar Estomacal','Ruby',22.99,596321458),
(SYSDATETIME(),'20200624 13:00','Terapia de Asma','Ruby',35.99,496852301),
(SYSDATETIME(),'20200625 14:00','Chequedo de Diabetes','Ruby',15.99,259863104),
(SYSDATETIME(),'20200628 15:00','Chequeo General','Ruby',10.99,586315774),
(SYSDATETIME(),'20200630 16:00','Dolor de Lumbago','Ruby',15.99,549320157),
(SYSDATETIME(),'20200701 7:00','Infeccion de vias urinarias','Ruby',15.99,145963248),
(SYSDATETIME(),'20200704 8:00','Infeccion en la piel','Ruby',15.99,105698367),
(SYSDATETIME(),'20200801 7:00','Infeccion de vias urinarias','Ruby',15.99,145963248)
go
--select * from Usuario
--select * from Paciente
--select * from Expediente
--select * from Diagnostico
--select * from Citas
--select * from Movimientos
drop database SistemaClinico
----go
----Paciente
----1
go
create procedure Consultar
@dui int
as
select * from Expediente E inner join Paciente P on E.dui = P.Dui where E.dui = @dui and P.Dui=@dui

go
----2
create procedure Citass
@dui int
as
select * from Paciente P inner join Citas C on C.dui = P.Dui where P.dui = @dui and C.dui = @dui and Fecha_HoraCita = (select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui=@dui)

----3
----create procedure Actualizar_Expediente
----@antecedentes varchar(100),@Medicamentos varchar(200),@dui int,@sangre varchar(5)
----as
----update Expediente set Antecedentes_Clinicos = @antecedentes, Medicamentos_Escritos= @medicamentos, tipo_sangre= @sangre 
----from  Expediente  where dui = @dui
----4
----create procedure Actualizar_Paciente
----@Nombre varchar(50),@apellido varchar(50),@sexo nvarchar(1),@telefono int,@direccion varchar(250),@estadocivil nvarchar(20),@fechanac nvarchar(20),@dui int
----as
----update Paciente set Nombre_Paciente= @nombre , Apellidos_Paciente = @apellido ,
---- Sexo_Paciente = @sexo, Telefono_Paciente = @telefono, Direccion_Paciente = @direccion ,
---- EstadoCivil = @estadocivil , FechaNacimiento =@fechanac 
----from Paciente where dui = @dui
----5
----create procedure insercion_Paciente
----@dui int,@Nombre varchar(50),@apellido varchar(50),@sexo nvarchar(1),@telefono int,@direccion varchar(250),@estadocivil nvarchar(20),@fechanac nvarchar(20)
----as
----Insert into Paciente(Dui,Nombre_Paciente,Apellidos_Paciente ,Sexo_Paciente ,Telefono_Paciente ,Direccion_Paciente,EstadoCivil ,FechaNacimiento)
----values(@dui,@nombre,@apellido,@sexo,@telefono,@direccion,@estadocivil,@fechanac)

----6

----create procedure insercion_Expediente
----@antecendetes varchar(100),@medicamentos varchar(200),@sangre varchar(5),@dui int
----as
----insert into Expediente (FechaCreacion,Antecedentes_Clinicos,Medicamentos_Escritos,tipo_sangre ,dui )
----values (SYSDATETIME(),@antecendetes ,@medicamentos,@sangre,@dui)

----7
----create procedure eliminar_Expediente
----@dui int 
----as
----delete from Expediente where dui = @dui 

----create procedure eliminar_Paciente
----@dui int 
----as
----delete from Paciente where Dui = @dui

----8

go
create procedure insercion_Diagnostico
@Enfermedad nvarchar(250),@Estado varchar(50),@peso float ,@estatura float,@presion float ,@temperatura float,@detalles varchar(200),@recomendaciones varchar(200),@Expe int 
as
insert into Diagnostico (Enfermedad,Estado,Peso,estatura,presion ,fechaDiagnostico ,temperatura ,detalles ,recomendaciones,Num_Expediente)
values (@Enfermedad,@Estado,@peso,@estatura,@presion,SYSDATETIME(),@temperatura,@detalles,@recomendaciones,@Expe)

----9
go
create procedure insercion_Citas
@fechaCita datetime,@motivo varchar(100),@CreadoPor varchar(100),@Precio float,@dui int
as
insert into Citas (Fecha_HoraCreacion,Fecha_HoraCita,Motivo,CreadoPor,Precio,dui)
values (SYSDATETIME(),@fechaCita,@motivo,@CreadoPor,@Precio,@dui)

----10
go
create procedure Actualizar_Citas
@dui int,@fechaCita datetime, @motivo varchar(100),@CreadoPor varchar(50),@Precio float
as
Update Citas set Fecha_HoraCita=@fechaCita,Motivo=@motivo,CreadoPor=@CreadoPor,Precio=@Precio 
from citas where dui = @dui and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =@dui)
----11
----create procedure eliminar_citas
----@dui int
----as
----delete from citas where dui = @dui and Fecha_HoraCita=(select min(Fecha_HoraCita) from Citas where Fecha_HoraCita >= SYSDATETIME() and dui =@dui)

----Usuario
--1
go
create procedure consultar_usuario
@usuario nvarchar (20),@contraseña nvarchar(10)
as
Select * from Usuario where Id_Usuario = @usuario and Contraseña_Usuasio = @contraseña

--2
go
create procedure actualizar_Usuario
@usuario nvarchar (20),@nombre varchar(50),@apellido varchar(50),@contraseña nvarchar(10)
as
update Usuario set Id_Usuario=@usuario,Nombre_Usuario=@nombre,Apellido_Usuario=@apellido,Contraseña_Usuasio=@contraseña
 where Id_Usuario=@usuario

-----Graficos
----select CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)),datename(MONTH,CONVERT(date, Fecha_HoraCita)) + ' ' + CONVERT(varchar(50),DATEPART(year,convert(date,Fecha_HoraCita ))) as fecha,
----convert(varchar(50),SUM(Precio))
----from Citas
----where Fecha_HoraCita <= SYSDATETIME()
----group by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)),datename(MONTH,CONVERT(date, Fecha_HoraCita)) + ' ' + CONVERT(varchar(50),DATEPART(year,convert(date,Fecha_HoraCita ))) order by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2)) asc

----select CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2))+' '+ CAST(YEAR(Fecha_HoraCita) AS VARCHAR(4)) ,sum(Precio)
----from Citas
----group by CAST(MONTH(Fecha_HoraCita) AS VARCHAR(2))+' '+ CAST(YEAR(Fecha_HoraCita) AS VARCHAR(4))

----select sum(Precio) as Monto from Citas where Fecha_HoraCita <= SYSDATETIME()
----select count(Fecha_HoraCita) as TotalCitas from Citas where Fecha_HoraCita <= SYSDATETIME()


