if  Object_id(N'DBO.GuardarLog','P') IS NOT NULL 
begin 
 drop procedure [dbo].GuardarLog;
end;
go

create procedure dbo.GuardarLog
	@query		varchar(max),
    @id_usuario int = null
as

set nocount on
set xact_abort on

insert into Log (Query, FechaCreacion, Id_Usuario)
Select @query, GetDate(), @id_usuario

--delete Log where datediff(day, FechaCreacion, getdate()) > 30

select Scope_identity()