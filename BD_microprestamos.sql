Create database BD_microprestamos;
use BD_microprestamos;
go

create table usuarios(
    idusuario int identity(1,1) primary key,
    usuario varchar(20) not null,
    contrasena varchar(20) not null,
    nombre varchar(150),
    idrol varchar(50) foreign key references roles(idrol) default 'usuario',
    estado int default 0
);


create table roles(
    idrol varchar(50) primary key,
    descripcion varchar(150),
    estado int default 0
);


create table opciones(
    idopcion varchar(50) primary key,
    descripcion varchar(150),
    estado int default 0
);


create table opc_x_roles(
    idrol varchar(50) not null foreign key  references roles (idrol),
    idopcion varchar(50) not null foreign key  references opciones (idopcion),
    primary key (idrol,idopcion),    
);

create table cliente(
idCliente int identity(1,1) primary key,
nombre varchar(50),
apellido varchar(50),
cedula int,
ciudad varchar(50),
direccion varchar (50),
correo_electronico varchar(100),
telefono varchar(15)
);
insert into cliente(nombre, apellido, cedula,ciudad,direccion, correo_electronico,telefono) 
values('Orlando','Franjul',401131123,'SD', 'proceres', 'Of@gmail', '809423233');

alter table cliente alter column cedula int
create table prestamos(
idPrestamos int identity(1,1) primary key,
numeroOperacion int,
fechaRegistro varchar(20),
idTipoPago int foreign key  references tipo_Pago (idTipoPago),
fechaInicio varchar(20),
fechaFin varchar(20),
montoPrestamo decimal(19, 2),
interes varchar(10),
numeroDeCuotas varchar(15),
montoTotal decimal(19, 2),
idCliente int foreign key  references cliente (idCliente),
estado varchar(10),
montoCuotas varchar(150),
clausula varchar(255)
);
alter table prestamos add  montoCuotas varchar(150)

insert into prestamos(numeroOperacion, fechaRegistro, idTipoPago,fechaInicio,fechaFin, montoPrestamo,interes, numeroDeCuotas, 
totalIntereses, montoTotal, idCliente, estado, clausula ) 
values('0001','20/12/22',1, '20/12/22', '20/1/23', 2000,'1.15', '1', '200', 2200, 1, 'A', 'Clausula01');

create table tipo_Pago(
idTipoPago int identity(1,1) primary key,
descripcion varchar(20),
);
insert into tipo_Pago(descripcion) 
values('Efectivo');

create table datos_prestamo(
iddatos_prestamo int identity(1,1) primary key,
razonSocial varchar(255),
RNC varchar(20),
representante varchar(120),
correo varchar(100),
telefono varchar(30)
);

create table Cuotas(
IdCuota int identity(1,1) primary key,
idPrestamos int foreign key  references prestamos (idPrestamos),
NumeroCuota	varchar(50),
FechaPagoCuota	varchar(15),
MontoCuota	decimal(19, 2),
EstadoCuota varchar(20),
FechaPago varchar(15),
ProximoPago	decimal(19, 2)
);
insert into Cuotas (idPrestamos, NumeroCuota, FechaPagoCuota, MontoCuota, EstadoCuota, FechaPago, ProximoPago)
values (9, '4', '20/11/23', 4000, 'A', '20/11/23', 4000)
CREATE TABLE Presupuesto (
idpresupuesto int identity(1,1) primary key,
monto Decimal(19, 2),
fecha DATE,
idPrestamos int FOREIGN KEY REFERENCES Prestamos(idPrestamos)
);
delete from usuarios where idusuario = 8

select * from usuarios	

SELECT (montoPrestamo - MontoCuota) as RESULTADO from prestamos join Cuotas on IdCuota = IdCuota where numeroOperacion = 1;

insert into usuarios(usuario, contrasena, nombre,idrol,estado) values('Orlando01','120345','Orlando Franjul','admin',1);
insert into usuarios(usuario, contrasena, nombre,idrol,estado) values('directivo','directivo','Admin','supervisor',1);
insert into usuarios(usuario, contrasena, nombre,idrol,estado) values('Alex23','983898','Alex Rodríguez','usuario',1);
insert into usuarios(usuario, contrasena, nombre,idrol,estado) values('Esmarling25','121453','Esmarling Ramos','soporte',1);
insert into usuarios(usuario, contrasena, nombre,idrol,estado) values('gabriel01','123','Gabriel Villalona','servicio al cliente',1);

insert into usuarios(usuario, contrasena, nombre,estado) values('admin','123','Administrador',1);
insert into usuarios(usuario, contrasena, nombre,estado) values('supervisor','supervisor','Supervisor de Ventas',1);
insert into usuarios(usuario, contrasena, nombre,estado) values('soporte','soporte','Soporte Tecnico',1);

insert into roles (idrol,descripcion,estado) values ('admin','Administrador',1);
insert into roles (idrol,descripcion, estado) values ('soporte','Soporte Tecnico',1);
insert into roles (idrol,descripcion, estado) values ('usuario','Usuario Final',1);

insert into opciones (idopcion,descripcion,estado) values ('inicio','Inicio de Menu',1);
insert into opciones (idopcion,descripcion, estado) values ('consulta','consultas de maestros',1);
insert into opciones (idopcion,descripcion, estado) values ('formulario','Mantenimientos',1);
insert into opciones (idopcion,descripcion,estado) values ('reporte','Reportes del Sistema',1);
insert into opciones (idopcion,descripcion, estado) values ('administracion','administracion del sistema',1);
insert into opciones (idopcion,descripcion, estado) values ('configuracion','configuraciones',1);
insert into opciones (idopcion,descripcion, estado) values ('ayuda','ayudas del sistema',1);

insert into opc_x_roles (idopcion,idrol) values ('inicio','admin');
insert into opc_x_roles (idopcion,idrol) values ('consulta','admin');
insert into opc_x_roles (idopcion,idrol) values ('formulario','admin');
insert into opc_x_roles (idopcion,idrol) values ('reporte','admin');
insert into opc_x_roles (idopcion,idrol) values ('administracion','admin');
insert into opc_x_roles (idopcion,idrol) values ('configuracion','admin');
insert into opc_x_roles (idopcion,idrol) values ('ayuda','admin');

insert into opc_x_roles (idopcion,idrol) values ('inicio','admin');
insert into opc_x_roles (idopcion,idrol) values ('consulta','admin');
insert into opc_x_roles (idopcion,idrol) values ('formulario','admin');
insert into opc_x_roles (idopcion,idrol) values ('reporte','admin');
insert into opc_x_roles (idopcion,idrol) values ('administracion','admin');
insert into opc_x_roles (idopcion,idrol) values ('configuracion','admin');
insert into opc_x_roles (idopcion,idrol) values ('ayuda','admin');

insert into opc_x_roles (idopcion,idrol) values ('inicio','soporte');
insert into opc_x_roles (idopcion,idrol) values ('administracion','soporte');

insert into opc_x_roles (idopcion,idrol) values ('inicio','usuario');
insert into opc_x_roles (idopcion,idrol) values ('consulta','usuario');
insert into opc_x_roles (idopcion,idrol) values ('formulario','usuario');
insert into opc_x_roles (idopcion,idrol) values ('reporte','usuario');
insert into opc_x_roles (idopcion,idrol) values ('ayuda','usuario');