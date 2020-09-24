create procedure sp_agregar_venta
(
    @fecha date,
	@total float,
	@id_venta int out
)
as
BEGIN
    insert into Ventas(Fecha_Venta,Total_Venta) values (@fecha,@total);

	
	set @id_venta = Scope_identity();
	
	return @id_venta;
END