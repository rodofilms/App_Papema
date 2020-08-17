create procedure sp_agregar_proveedor
(
    @name nvarchar(30),
	@agencia nvarchar(20),
	@tel nvarchar(15),
	@email nvarchar(50),
	@salida int out
)
as
BEGIN
    if not exists (select * from Provedores where Nombre = @name)
    begin
        insert into Provedores(Nombre,Agencia,Telefono,Correo) values (@name,@agencia,@tel,@email);
		set @salida = 1;
	end
    else
    begin
		set @salida = 0;
    end

	return @salida;
END
