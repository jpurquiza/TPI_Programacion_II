CREATE DATABASE bancoPRUEBA
USE bancoPRUEBA

CREATE TABLE TIPOS_CUENTA (
	id_tipo_cuenta int identity(1,1) NOT NULL,
	descripcion varchar(30),
	CONSTRAINT pk_tipo_cuenta PRIMARY KEY (id_tipo_cuenta)
)

CREATE TABLE CUENTAS (
	id_cuenta int identity(1,1) NOT NULL,
	id_tipo_cuenta int NOT NULL,
	nro_cbu int NOT NULL,
	saldo int,
	CONSTRAINT pk_cuenta PRIMARY KEY (id_cuenta),
	CONSTRAINT fk_cuentas_tipos_cuenta FOREIGN KEY (id_tipo_cuenta)
		REFERENCES TIPOS_CUENTA (id_tipo_cuenta)
)

CREATE TABLE DESTINATARIOS (
	id_destinatario int identity(1,1) NOT NULL,
	nro_cbu int NOT NULL,
	nro_dni int,
	apellido varchar(20),
	nombre varchar(20),
	email varchar(50),
	CONSTRAINT pk_destinatario PRIMARY KEY (id_destinatario)
)

CREATE TABLE CLIENTES (
	id_cliente int identity(1,1) NOT NULL,
	id_cuenta int NOT NULL,
	id_destinatario int,
	nro_dni int,
	clave varchar(30),
	apellido varchar(20),
	nombre varchar(20),
	email varchar(50),
	CONSTRAINT pk_cliente PRIMARY KEY (id_cliente),
	CONSTRAINT fk_cliente_cuentas FOREIGN KEY (id_cuenta)
		REFERENCES CUENTAS (id_cuenta),
	CONSTRAINT fk_cliente_destinatarios FOREIGN KEY (id_destinatario)
		REFERENCES DESTINATARIOS (id_destinatario)
)

CREATE TABLE TRANSACCIONES (
	id_transaccion int identity(1,1) NOT NULL,
	id_cuenta int NOT NULL,
	id_destinatario int,
	fecha datetime,
	monto decimal(10,2),
	CONSTRAINT pk_transaccion PRIMARY KEY (id_transaccion),
	CONSTRAINT fk_transaccion_cuenta FOREIGN KEY (id_cuenta)
		REFERENCES CUENTAS (id_cuenta),
	CONSTRAINT fk_transaccion_destinatario FOREIGN KEY (id_destinatario)
		REFERENCES DESTINATARIOS (id_destinatario)
)
