if  Object_id(N'DBO.GestionUsuario','P') IS NOT NULL 
begin 
 drop Procedure [DBO].[GestionUsuario];
end;
go

create procedure dbo.GestionUsuario
	@oper    char(1),
	@id      int = null,
	@nombre  varchar(100) = null,
	@email   varchar(100) = null,
	@usuario varchar(50) = null,
	@clave   varchar(50) = null
as

set nocount on
set xact_abort on

if @oper = 'S'
begin
	if IsNull(@id, 0) <> 0
	begin
		select Id, Nombre, Email, Usuario, Clave, Estado, FechaCreacion, FechaModificacion
		from Usuario
		where Id = @id
	end

	select 'Jhon Doe' as Nombre
	union
	select 'Emma Doe' as Nombre
	union
	select 'Carl Doe' as Nombre

	return
end

if @oper = 'V'
begin
	if exists(select 1 from Usuario where Usuario = @usuario and Clave = @clave)
	begin
		select Id, Nombre, Email, Usuario, Clave, Estado, FechaCreacion, FechaModificacion
		from Usuario 
		where Usuario = @usuario and Clave = @clave
			and Estado = 1
	end

	return
end

if @oper = 'I'
begin
	if IsNull(@id, 0) = 0
	begin
		insert into Usuario (Nombre, Email, Usuario, Clave, Estado, FechaCreacion, FechaModificacion)
		values (@nombre, @email, @usuario, @clave, 1, GetDate(), GetDate())

		set @id = SCOPE_IDENTITY()
	end
	else
	begin
		update Usuario
			set Nombre = @nombre,
				Email = @email
		where Id = @id
	end

	select @id as Id

	return
end