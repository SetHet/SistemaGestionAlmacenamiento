IF db_id('SGAPersia') IS NULL 
    CREATE DATABASE SGAPersia

GO


USE [SGAPersia]
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bodega](
	[id_bodega] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado](
	[rut_empleado] [varchar](15) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[rut_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntradaCabecera]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaCabecera](
	[cod_entrada] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_proveedor] [int] NOT NULL,
	[id_bodega] [int] NOT NULL,
	[rut_empleado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_EntradaCabecera] PRIMARY KEY CLUSTERED 
(
	[cod_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EntradaDetalle]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaDetalle](
	[id_producto] [int] NOT NULL,
	[cod_entrada] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_EntradaDetalle] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[cod_entrada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_producto] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalidaCabecera]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalidaCabecera](
	[cod_salida] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [datetime] NOT NULL,
	[id_sucursal] [int] NOT NULL,
	[id_bodega] [int] NOT NULL,
	[rut_empleado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_SalidaCabecera] PRIMARY KEY CLUSTERED 
(
	[cod_salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalidaDetalle]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalidaDetalle](
	[id_producto] [int] NOT NULL,
	[cod_salida] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_SalidaDetalle] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC,
	[cod_salida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[id_sucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 30-11-2020 3:26:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[id_tipo_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bodega] ON 

INSERT [dbo].[Bodega] ([id_bodega], [nombre], [direccion]) VALUES (4, N'Bodega Centro', N'La Moneda 4500')
INSERT [dbo].[Bodega] ([id_bodega], [nombre], [direccion]) VALUES (5, N'Bodega La Florida', N'Vicuña Maquena 2000')
SET IDENTITY_INSERT [dbo].[Bodega] OFF
GO
INSERT [dbo].[Empleado] ([rut_empleado], [nombre], [apellido], [password]) VALUES (N'12.213.487-8', N'Mark', N'Lockwood', N'marino82')
INSERT [dbo].[Empleado] ([rut_empleado], [nombre], [apellido], [password]) VALUES (N'12.345.678-9', N'Bob', N'Robins', N'1234')
GO
SET IDENTITY_INSERT [dbo].[EntradaCabecera] ON 

INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (18, CAST(N'2020-11-29T16:41:52.000' AS DateTime), 3, 4, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (19, CAST(N'2020-11-29T16:42:02.000' AS DateTime), 4, 5, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (20, CAST(N'2020-11-29T18:10:57.000' AS DateTime), 3, 4, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (21, CAST(N'2020-11-29T18:40:42.000' AS DateTime), 3, 5, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (22, CAST(N'2020-11-29T18:42:53.000' AS DateTime), 3, 5, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (23, CAST(N'2020-11-29T23:14:31.000' AS DateTime), 6, 4, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (24, CAST(N'2020-11-30T03:21:01.000' AS DateTime), 3, 4, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (25, CAST(N'2020-11-30T03:21:17.000' AS DateTime), 3, 5, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (26, CAST(N'2020-11-30T03:21:48.000' AS DateTime), 3, 4, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (27, CAST(N'2020-11-30T03:22:26.000' AS DateTime), 3, 5, N'12.345.678-9')
SET IDENTITY_INSERT [dbo].[EntradaCabecera] OFF
GO
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (1, 18, 100)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (1, 20, 73)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 19, 200)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 20, 15)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 21, 110)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 27, 40)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (5, 23, 50)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (5, 27, 37)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (6, 22, 1000)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (6, 26, 15)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (11, 24, 100)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (11, 25, 150)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (12, 26, 70)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (15, 26, 15)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (15, 27, 3)
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (1, 6, N'Asus Z240', N'144Hz Full HD')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (2, 7, N'ROG Box', N'Certificacion militar')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (5, 8, N'Intel i7 3770K', N'The best CPU')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (6, 7, N'ColdTower', N'Mejor flujo de aire')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (11, 12, N'RTX 3060', N'Graficos Medio-Alto 2K')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (12, 12, N'GT 1030', N'Grafica para oficina')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (13, 12, N'RTX 3090 TI', N'8K 60Hz')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (14, 9, N'Razer Evo', N'Mayor Costo')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (15, 6, N'Samsung X48', N'Compatible PS5 y XS')
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [direccion]) VALUES (3, N'Intel', N'Alameda 32')
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [direccion]) VALUES (4, N'AMD', N'Coquimbo 11')
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [direccion]) VALUES (6, N'Samsung', N'Las Mercedes 22')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[SalidaCabecera] ON 

INSERT [dbo].[SalidaCabecera] ([cod_salida], [fecha], [id_sucursal], [id_bodega], [rut_empleado]) VALUES (4, CAST(N'2020-11-29T16:43:36.000' AS DateTime), 3, 4, N'12.345.678-9')
INSERT [dbo].[SalidaCabecera] ([cod_salida], [fecha], [id_sucursal], [id_bodega], [rut_empleado]) VALUES (5, CAST(N'2020-11-29T16:43:43.000' AS DateTime), 4, 5, N'12.345.678-9')
INSERT [dbo].[SalidaCabecera] ([cod_salida], [fecha], [id_sucursal], [id_bodega], [rut_empleado]) VALUES (6, CAST(N'2020-11-29T23:15:23.000' AS DateTime), 4, 4, N'12.345.678-9')
INSERT [dbo].[SalidaCabecera] ([cod_salida], [fecha], [id_sucursal], [id_bodega], [rut_empleado]) VALUES (7, CAST(N'2020-11-30T03:23:24.000' AS DateTime), 3, 5, N'12.345.678-9')
SET IDENTITY_INSERT [dbo].[SalidaCabecera] OFF
GO
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (1, 4, 10)
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (2, 5, 30)
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (5, 6, 50)
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (6, 7, 150)
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (11, 7, 30)
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

INSERT [dbo].[Sucursal] ([id_sucursal], [nombre], [direccion]) VALUES (3, N'PcFactory La Florida', N'Mall Plaza Vespucio 45')
INSERT [dbo].[Sucursal] ([id_sucursal], [nombre], [direccion]) VALUES (4, N'PcFactory Puente Alto', N'Mall Plaza Puente Alto')
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProducto] ON 

INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (6, N'Monitores')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (7, N'Gabinetes')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (8, N'CPU')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (9, N'Mouse')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (11, N'KeyBoards')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (12, N'GPU')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (13, N'Almacenamiento')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (14, N'HeadPhones')
SET IDENTITY_INSERT [dbo].[TipoProducto] OFF
GO
ALTER TABLE [dbo].[EntradaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_EntradaCabecera_Bodega] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[Bodega] ([id_bodega])
GO
ALTER TABLE [dbo].[EntradaCabecera] CHECK CONSTRAINT [FK_EntradaCabecera_Bodega]
GO
ALTER TABLE [dbo].[EntradaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_EntradaCabecera_Empleado] FOREIGN KEY([rut_empleado])
REFERENCES [dbo].[Empleado] ([rut_empleado])
GO
ALTER TABLE [dbo].[EntradaCabecera] CHECK CONSTRAINT [FK_EntradaCabecera_Empleado]
GO
ALTER TABLE [dbo].[EntradaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_EntradaCabecera_Proveedor] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[Proveedor] ([id_proveedor])
GO
ALTER TABLE [dbo].[EntradaCabecera] CHECK CONSTRAINT [FK_EntradaCabecera_Proveedor]
GO
ALTER TABLE [dbo].[EntradaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_EntradaDetalle_EntradaCabecera] FOREIGN KEY([cod_entrada])
REFERENCES [dbo].[EntradaCabecera] ([cod_entrada])
GO
ALTER TABLE [dbo].[EntradaDetalle] CHECK CONSTRAINT [FK_EntradaDetalle_EntradaCabecera]
GO
ALTER TABLE [dbo].[EntradaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_EntradaDetalle_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[EntradaDetalle] CHECK CONSTRAINT [FK_EntradaDetalle_Producto]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoProducto] FOREIGN KEY([id_tipo_producto])
REFERENCES [dbo].[TipoProducto] ([id_tipo_producto])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TipoProducto]
GO
ALTER TABLE [dbo].[SalidaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_SalidaCabecera_Bodega] FOREIGN KEY([id_bodega])
REFERENCES [dbo].[Bodega] ([id_bodega])
GO
ALTER TABLE [dbo].[SalidaCabecera] CHECK CONSTRAINT [FK_SalidaCabecera_Bodega]
GO
ALTER TABLE [dbo].[SalidaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_SalidaCabecera_Empleado] FOREIGN KEY([rut_empleado])
REFERENCES [dbo].[Empleado] ([rut_empleado])
GO
ALTER TABLE [dbo].[SalidaCabecera] CHECK CONSTRAINT [FK_SalidaCabecera_Empleado]
GO
ALTER TABLE [dbo].[SalidaCabecera]  WITH CHECK ADD  CONSTRAINT [FK_SalidaCabecera_Sucursal] FOREIGN KEY([id_sucursal])
REFERENCES [dbo].[Sucursal] ([id_sucursal])
GO
ALTER TABLE [dbo].[SalidaCabecera] CHECK CONSTRAINT [FK_SalidaCabecera_Sucursal]
GO
ALTER TABLE [dbo].[SalidaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_SalidaDetalle_Producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[Producto] ([id_producto])
GO
ALTER TABLE [dbo].[SalidaDetalle] CHECK CONSTRAINT [FK_SalidaDetalle_Producto]
GO
ALTER TABLE [dbo].[SalidaDetalle]  WITH CHECK ADD  CONSTRAINT [FK_SalidaDetalle_SalidaCabecera] FOREIGN KEY([cod_salida])
REFERENCES [dbo].[SalidaCabecera] ([cod_salida])
GO
ALTER TABLE [dbo].[SalidaDetalle] CHECK CONSTRAINT [FK_SalidaDetalle_SalidaCabecera]
GO
