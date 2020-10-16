USE [papema]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 16/10/2020 03:16:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[ID_Articulos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Precio] [float] NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
 CONSTRAINT [PK_Articulos] PRIMARY KEY CLUSTERED 
(
	[ID_Articulos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulos_Ventas]    Script Date: 16/10/2020 03:16:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos_Ventas](
	[ID_Articulos] [int] NOT NULL,
	[ID_Venta] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 16/10/2020 03:16:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Agencia] [nvarchar](20) NULL,
	[Telefono] [nvarchar](15) NULL,
	[Correo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Proveedores] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 16/10/2020 03:16:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[ID_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](20) NOT NULL,
	[Tipo_Acceso] [nvarchar](15) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[ID_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ventas]    Script Date: 16/10/2020 03:16:25 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ventas](
	[ID_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha_Venta] [date] NULL,
	[Total_Venta] [float] NOT NULL,
 CONSTRAINT [PK_Ventas] PRIMARY KEY CLUSTERED 
(
	[ID_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Articulos] ON 
GO
INSERT [dbo].[Articulos] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [ID_Proveedor]) VALUES (4, N'Leche Deslactosada', N'1 litro', 15.25, 2)
GO
INSERT [dbo].[Articulos] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [ID_Proveedor]) VALUES (5, N'SSD', N'Disco de 1 tb', 2123.25, 3)
GO
INSERT [dbo].[Articulos] ([ID_Articulos], [Nombre], [Descripcion], [Precio], [ID_Proveedor]) VALUES (7, N'Dell 7588', N'PC gamer dell g7 7588', 45.229999542236328, 4)
GO
SET IDENTITY_INSERT [dbo].[Articulos] OFF
GO
INSERT [dbo].[Articulos_Ventas] ([ID_Articulos], [ID_Venta]) VALUES (4, 1)
GO
INSERT [dbo].[Articulos_Ventas] ([ID_Articulos], [ID_Venta]) VALUES (5, 1)
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Nombre], [Agencia], [Telefono], [Correo]) VALUES (2, N'Lala', N'Leche de Mexico', N'4784567896', N'lecheLala@lala.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Nombre], [Agencia], [Telefono], [Correo]) VALUES (3, N'Fedex', N'Paqueteria Fedex', N'4571235689', N'fedex@gmail.com')
GO
INSERT [dbo].[Proveedores] ([ID_Proveedor], [Nombre], [Agencia], [Telefono], [Correo]) VALUES (4, N'Dell', N'Computadoras', N'4561233652', N'sdsdf@gmail.com')
GO
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([ID_Usuario], [Usuario], [Password], [Tipo_Acceso], [Nombre], [Apellido]) VALUES (2, N'admin', N'pass123', N'Administrador', N'Rodolfo', N'Rodarte Jr')
GO
INSERT [dbo].[Usuarios] ([ID_Usuario], [Usuario], [Password], [Tipo_Acceso], [Nombre], [Apellido]) VALUES (3, N'user', N'pass123', N'Usuario', N'Jose Manuel', N'Lopez')
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
SET IDENTITY_INSERT [dbo].[Ventas] ON 
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (1, CAST(N'1017-03-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (2, CAST(N'2019-03-18' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (3, CAST(N'2020-08-31' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (4, CAST(N'2020-09-01' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (5, CAST(N'2020-09-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (6, CAST(N'2020-09-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (7, CAST(N'2020-09-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (8, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (9, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (10, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (11, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (12, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (13, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (14, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (15, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (16, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (17, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (18, CAST(N'2020-09-05' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (19, CAST(N'2020-09-19' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (20, CAST(N'2020-09-19' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (21, CAST(N'2020-09-19' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (22, CAST(N'2020-10-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (23, CAST(N'2020-10-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (24, CAST(N'2020-10-03' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (27, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (28, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (29, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (30, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (31, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (32, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (33, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (34, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (35, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (36, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (37, CAST(N'2020-10-16' AS Date), 0)
GO
INSERT [dbo].[Ventas] ([ID_Venta], [Fecha_Venta], [Total_Venta]) VALUES (38, CAST(N'2020-10-16' AS Date), 0)
GO
SET IDENTITY_INSERT [dbo].[Ventas] OFF
GO
ALTER TABLE [dbo].[Articulos]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Proveedores] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Articulos] CHECK CONSTRAINT [FK_Articulos_Proveedores]
GO
ALTER TABLE [dbo].[Articulos_Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Ventas_Articulos] FOREIGN KEY([ID_Articulos])
REFERENCES [dbo].[Articulos] ([ID_Articulos])
GO
ALTER TABLE [dbo].[Articulos_Ventas] CHECK CONSTRAINT [FK_Articulos_Ventas_Articulos]
GO
ALTER TABLE [dbo].[Articulos_Ventas]  WITH CHECK ADD  CONSTRAINT [FK_Articulos_Ventas_Ventas] FOREIGN KEY([ID_Venta])
REFERENCES [dbo].[Ventas] ([ID_Venta])
GO
ALTER TABLE [dbo].[Articulos_Ventas] CHECK CONSTRAINT [FK_Articulos_Ventas_Ventas]
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_articulo]    Script Date: 16/10/2020 03:16:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregar_articulo]
(
    @nombre nvarchar(50),
	@descr nvarchar(max),
	@precio float,
	@id_prov int,
	@salida int out
)
as
BEGIN
    if not exists (select * from Articulos where Nombre = @nombre)
    begin
        insert into Articulos(Nombre,Descripcion,Precio,ID_Proveedor) values (@nombre,@descr,@precio,@id_prov);
		set @salida = 1;
	end
    else
    begin
		set @salida = 0;
    end

	return @salida;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_articulos_venta]    Script Date: 16/10/2020 03:16:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregar_articulos_venta]
(
    @id_articulo int,
	@id_venta int,
	@salida int out
)
as
BEGIN
	INSERT INTO Articulos_Ventas(ID_Articulos, ID_Venta)
	VALUES (7, 1);
		
	return @salida;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_proveedor]    Script Date: 16/10/2020 03:16:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregar_proveedor]
(
    @name nvarchar(30),
	@agencia nvarchar(20),
	@tel nvarchar(15),
	@email nvarchar(50),
	@salida int out
)
as
BEGIN
    if not exists (select * from Proveedores where Nombre = @name)
    begin
        insert into Proveedores(Nombre,Agencia,Telefono,Correo) values (@name,@agencia,@tel,@email);
		set @salida = 1;
	end
    else
    begin
		set @salida = 0;
    end

	return @salida;
END
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_usuarios]    Script Date: 16/10/2020 03:16:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregar_usuarios]
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
GO
/****** Object:  StoredProcedure [dbo].[sp_agregar_venta]    Script Date: 16/10/2020 03:16:26 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_agregar_venta]
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
GO
