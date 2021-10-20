use [db_banco]

USE bancoPRUEBA

INSERT INTO TIPOS_CUENTA (descripcion) VALUES ('cuenta corriente')
INSERT INTO TIPOS_CUENTA (descripcion) VALUES ('caja de ahorros')
INSERT INTO TIPOS_CUENTA (descripcion) VALUES ('cuenta sueldo')



--INSERT INTO TIPOS_CUENTA (tipo_cuenta) VALUES ('cuenta corriente')
--INSERT INTO TIPOS_CUENTA (tipo_cuenta) VALUES ('caja de ahorros')
--INSERT INTO TIPOS_CUENTA (tipo_cuenta) VALUES ('cuenta sueldo')

select * from TIPOS_CUENTA

---------------------------------------------------------------------------------------------------------------------

INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 832000)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 53002)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 3245)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 42355)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 2112)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 21356)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 63354)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 4353)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 87563)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 53425)

INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 92523, 43643)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 72170, 7685)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 90519, 34656)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 75586, 45674)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 22794, 21612)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 85080, 76457)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 90752, 6578)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 68274, 8674)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 15778, 5636)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (2, 14674, 87763)

INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 92523, 43665)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 72170, 54698)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 90519, 34522)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 75586, 78632)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 22794, 5643)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 85080, 67854)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 90752, 73446)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 68274, 23421)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 15778, 4747)
INSERT INTO CUENTAS (id_tipo_cuenta, nro_cbu, saldo) VALUES (3, 14674, 3452)


select * from cuentas

--delete CUENTAS

---------------------------------------------------------------------------------------------------------------------

INSERT INTO DESTINATARIOS (nro_cbu, nro_dni, apellido, nombre, email) VALUES (ABS(CAST(NEWID() as binary(6)) % 100000) + 1, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 'Lopez', 'Victoria', 'vlopez@gmail.com')

---------------------------------------------------------------------------------------------------------------------

INSERT INTO CLIENTES (id_cuenta, id_destinatario, nro_dni, clave, apellido, nombre, email)
	VALUES (1, 2, ABS(CAST(NEWID() as binary(6)) % 100000) + 1, 'lapicera', 'Lagos', 'Marcela', 'marcelagos@gmail.com')

select * from CLIENTES
---------------------------------------------------------------------------------------------------------------------

CREATE PROC SP_INSERTAR_DESTINATARIO
	@nro_cbu int,
	@nro_dni int,
	@apellido varchar(20),
	@nombre varchar(20),
	@email varchar(50)
AS
BEGIN
	INSERT INTO DESTINATARIOS (nro_cbu, nro_dni, apellido, nombre, email)
	VALUES (@nro_cbu, @nro_dni, @apellido, @nombre, @email)
END

--------------------------------------------------------------------------------
--cambiar
--falta id_

ALTER PROC SP_MODIFICAR_DESTINATARIO
	@nro_dni int,

AS
BEGIN
DECLARE @nro_dni int, @apellido varchar(20), @nombre varchar(20)
IF EXISTS (SELECT nro_dni, apellido, nombre
			FROM CLIENTES
			WHERE nro_dni=@nro_dni AND apellido=@apellido and nombre=@nombre)
	BEGIN
		UPDATE DESTINATARIOS SET nro_cbu=@nro_cbu, email=@email
	END
END

--EXEC SP_MODIFICAR_DESTINATARIO 
	
--------------------------------------------------------------------------------
ALTER PROC SP_ELIMINAR_DESTINATARIO
	@id_destinatario int
AS
BEGIN
	DELETE FROM DESTINATARIOS
	WHERE id_destinatario = @id_destinatario
END

select * from DESTINATARIOS

--exec SP_ELIMINAR_DESTINATARIO 1


--------------------------------------------------------------------------------
CREATE PROC SP_CONSULTAR_DESTINATARIOS
	@id_cliente int
AS
BEGIN
	SELECT d.nro_cbu, d.apellido, d.nombre, d.nro_dni, d.email 
	FROM DESTINATARIOS d JOIN CLIENTES c ON d.id_destinatario = c.id_destinatario
	WHERE c.id_cliente = @id_cliente
END

EXEC SP_CONSULTAR_DESTINATARIOS 4

select * from CLIENTES


--------------------------------------------------------------------------------
CREATE PROC SP_CONSULTAR_SALDO_TIPO_CUENTA
	@id_cuenta int
AS
BEGIN
	SELECT saldo FROM CUENTAS
	WHERE id_cuenta = @id_cuenta
END

EXEC SP_CONSULTAR_SALDO_TIPO_CUENTA 2


--------------------------------------------------------------------------------
ALTER PROC SP_INSERTAR_TRANSACCION
	@id_cuenta int,
	@id_destinatario int,
	@fecha datetime,
	@monto decimal(10,2)
AS 
BEGIN
declare @saldo int
	SELECT @saldo = saldo FROM CUENTAS WHERE @id_cuenta = id_cuenta
	IF(@monto < @saldo)
		BEGIN
			INSERT INTO TRANSACCIONES (id_cuenta, id_destinatario, fecha, monto)
			VALUES (@id_cuenta, @id_destinatario, @fecha, @monto)
		END
END


EXEC SP_INSERTAR_TRANSACCION 1,2, '10/20/2021',3232
SELECT * FROM TRANSACCIONES

--trigger para descontar saldo
--output id transaccion 
--------------------------------------------------------------------------------
CREATE PROC SP_CONSULTAR_TRANSACCION
	@id_cuenta int,
	@id_destinatario int,
	@fechaDesde datetime,
	@fechaHasta datetime,
	@monto decimal(10,2)
AS
BEGIN
	SELECT * FROM TRANSACCIONES
	WHERE (@monto is null OR monto=@monto)
	OR (id_destinatario = @id_destinatario OR @id_destinatario IS NULL)
	OR ((@fechaDesde is null and @fechaHasta is  null) OR (fecha between @fechaDesde and @fechaHasta))
	AND (id_cuenta = @id_cuenta OR @id_cuenta is null)
END


EXEC SP_CONSULTAR_TRANSACCION 1,NULL,'10/20/2021',NULL,NULL

----------- DUDAS MUCHAS DUDAS -----------
--sacar monto
--------------------------------------------------------------------------------
CREATE PROC SP_VALIDAR_LOGIN
	@dni int,
	@password varchar(30)
AS
BEGIN
	SELECT COUNT(*) FROM CLIENTES
	WHERE nro_dni = @dni AND clave = @password
END


EXEC SP_VALIDAR_LOGIN 82119, 'lapicera'

SELECT * FROM CLIENTES

--------------------------------------------------------------------------------
