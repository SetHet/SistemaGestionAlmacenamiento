USE [SGAPersia]
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bodega](
	[id_bodega] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Bodega] PRIMARY KEY CLUSTERED 
(
	[id_bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 26-11-2020 20:37:47 ******/
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
/****** Object:  Table [dbo].[EntradaCabecera]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EntradaCabecera](
	[cod_entrada] [int] NOT NULL,
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
/****** Object:  Table [dbo].[EntradaDetalle]    Script Date: 26-11-2020 20:37:47 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id_producto] [int] NOT NULL,
	[id_tipo_producto] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](500) NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[id_proveedor] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[id_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalidaCabecera]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalidaCabecera](
	[cod_salida] [int] NOT NULL,
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
/****** Object:  Table [dbo].[SalidaDetalle]    Script Date: 26-11-2020 20:37:47 ******/
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
/****** Object:  Table [dbo].[Sucursal]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sucursal](
	[id_sucursal] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[id_sucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 26-11-2020 20:37:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoProducto](
	[id_tipo_producto] [int] NOT NULL,
	[nombre_tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoProducto] PRIMARY KEY CLUSTERED 
(
	[id_tipo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
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
