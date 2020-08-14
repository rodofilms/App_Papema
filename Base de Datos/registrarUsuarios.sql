create procedure AgregarUsuarios
(
    @User nvarchar(30),
	@Pass nvarchar(20),
	@Tip nvarchar(15),
	@Name nvarchar(50),
	@Ape nvarchar(50),
	@Salida int out
)
as
BEGIN
    if not exists (select * from Usuarios where Usuario = @User)
    begin
        insert into Usuarios(Usuario,Password,Tipo_Acceso,Nombre,Apellido) values (@User,@Pass,@Tip,@Name,@Ape);
		set @Salida = 1;
	end
    else
    begin
		set @Salida = 0;
    end

	return @Salida;
END
