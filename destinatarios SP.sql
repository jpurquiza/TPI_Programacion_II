CREATE PROC [dbo].[SP_CONSULTAR_DESTINATARIOS]
	@id_cliente int
AS
BEGIN
	SELECT d.nro_cbu, d.apellido, d.nombre, d.nro_dni, d.email , d.id_destinatario 
	FROM DESTINATARIOS d JOIN CLIENTES c ON d.id_cliente = c.id_cliente
	WHERE c.id_cliente = @id_cliente
END

-----------------------------------------------------------------------------------

CREATE PROC [dbo].[SP_ELIMINAR_DESTINATARIO]
	@id_destinatario int
AS
BEGIN
	DELETE FROM DESTINATARIOS
	WHERE id_destinatario = @id_destinatario
END

-----------------------------------------------------------------------------------

CREATE PROC [dbo].[SP_INSERTAR_DESTINATARIO]
	@id_cliente int,
	@nro_cbu int,
	@nro_dni int,
	@apellido varchar(20),
	@nombre varchar(20),
	@email varchar(50)
AS
BEGIN
	IF NOT EXISTS (select nro_cbu
					from DESTINATARIOS
					where nro_cbu = @nro_cbu)
		INSERT INTO DESTINATARIOS (id_cliente, nro_cbu, nro_dni, apellido, nombre, email)
		VALUES (@id_cliente, @nro_cbu, @nro_dni, @apellido, @nombre, @email)
END

-----------------------------------------------------------------------------------

CREATE PROC [dbo].[SP_MODIFICAR_DESTINATARIO]
	@idDestinatario int,
	@nro_cbu int,
	@nro_dni int,
	@apellido varchar(20),
	@nombre varchar(20),
	@email varchar(50)
AS
BEGIN
IF EXISTS (SELECT id_destinatario
			FROM DESTINATARIOS
			WHERE  id_destinatario=@idDestinatario)
	BEGIN
		UPDATE DESTINATARIOS SET nro_cbu=@nro_cbu, nro_dni=@nro_dni, apellido=@apellido,
		nombre=@nombre, email=@email
		WHERE id_destinatario=@idDestinatario
	END
END

-----------------------------------------------------------------------------------

CREATE PROC [dbo].[SP_VALIDAR_INSERT_DESTINATARIO]
	@idCliente int,
	@nro_cbu int,
		@nro_dni int

AS
BEGIN
IF EXISTS (SELECT id_destinatario
			FROM DESTINATARIOS
			WHERE (id_cliente=@idCliente AND @nro_cbu=nro_cbu) OR (id_cliente=@idCliente AND @nro_dni=nro_dni))
	BEGIN
		SELECT d.nro_cbu, d.apellido, d.nombre, d.nro_dni, d.email , d.id_destinatario 
		FROM DESTINATARIOS d JOIN CLIENTES c ON d.id_cliente = c.id_cliente
		WHERE c.id_cliente = @idCliente
	END
END