if  Object_id(N'DBO.GestionUsuario','P') IS NOT NULL 
begin 
 drop Procedure [DBO].[GestionUsuario];
end;
go

create procedure dbo.GestionUsuario
	@oper char(1)
as

set nocount on
set xact_abort on

if @oper = 'S'
begin
	select 1 as uno
	select 2 as dos

	return
end