

USE [SGAPersia]
GO
ALTER TABLE [dbo].[SalidaDetalle] DROP CONSTRAINT [FK_SalidaDetalle_SalidaCabecera]
GO
ALTER TABLE [dbo].[SalidaDetalle] DROP CONSTRAINT [FK_SalidaDetalle_Producto]
GO
ALTER TABLE [dbo].[SalidaCabecera] DROP CONSTRAINT [FK_SalidaCabecera_Sucursal]
GO
ALTER TABLE [dbo].[SalidaCabecera] DROP CONSTRAINT [FK_SalidaCabecera_Empleado]
GO
ALTER TABLE [dbo].[SalidaCabecera] DROP CONSTRAINT [FK_SalidaCabecera_Bodega]
GO
ALTER TABLE [dbo].[Producto] DROP CONSTRAINT [FK_Producto_TipoProducto]
GO
ALTER TABLE [dbo].[EntradaDetalle] DROP CONSTRAINT [FK_EntradaDetalle_Producto]
GO
ALTER TABLE [dbo].[EntradaDetalle] DROP CONSTRAINT [FK_EntradaDetalle_EntradaCabecera]
GO
ALTER TABLE [dbo].[EntradaCabecera] DROP CONSTRAINT [FK_EntradaCabecera_Proveedor]
GO
ALTER TABLE [dbo].[EntradaCabecera] DROP CONSTRAINT [FK_EntradaCabecera_Empleado]
GO
ALTER TABLE [dbo].[EntradaCabecera] DROP CONSTRAINT [FK_EntradaCabecera_Bodega]
GO
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TipoProducto]') AND type in (N'U'))
DROP TABLE [dbo].[TipoProducto]
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sucursal]') AND type in (N'U'))
DROP TABLE [dbo].[Sucursal]
GO
/****** Object:  Table [dbo].[SalidaDetalle]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalidaDetalle]') AND type in (N'U'))
DROP TABLE [dbo].[SalidaDetalle]
GO
/****** Object:  Table [dbo].[SalidaCabecera]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SalidaCabecera]') AND type in (N'U'))
DROP TABLE [dbo].[SalidaCabecera]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Proveedor]') AND type in (N'U'))
DROP TABLE [dbo].[Proveedor]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Producto]') AND type in (N'U'))
DROP TABLE [dbo].[Producto]
GO
/****** Object:  Table [dbo].[EntradaDetalle]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntradaDetalle]') AND type in (N'U'))
DROP TABLE [dbo].[EntradaDetalle]
GO
/****** Object:  Table [dbo].[EntradaCabecera]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EntradaCabecera]') AND type in (N'U'))
DROP TABLE [dbo].[EntradaCabecera]
GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empleado]') AND type in (N'U'))
DROP TABLE [dbo].[Empleado]
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 28-11-2020 6:21:31 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Bodega]') AND type in (N'U'))
DROP TABLE [dbo].[Bodega]
GO
USE [master]
GO
/****** Object:  Database [SGAPersia]    Script Date: 28-11-2020 6:21:31 ******/
DROP DATABASE [SGAPersia]
GO
/****** Object:  Database [SGAPersia]    Script Date: 28-11-2020 6:21:31 ******/
CREATE DATABASE [SGAPersia]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SGAPersia', FILENAME = N'D:\Tools\SQLServer\FeaturesDeveloper\MSSQL15.MSSQLSERVER\MSSQL\DATA\SGAPersia.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SGAPersia_log', FILENAME = N'D:\Tools\SQLServer\FeaturesDeveloper\MSSQL15.MSSQLSERVER\MSSQL\DATA\SGAPersia_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SGAPersia] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SGAPersia].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SGAPersia] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SGAPersia] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SGAPersia] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SGAPersia] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SGAPersia] SET ARITHABORT OFF 
GO
ALTER DATABASE [SGAPersia] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SGAPersia] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SGAPersia] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SGAPersia] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SGAPersia] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SGAPersia] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SGAPersia] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SGAPersia] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SGAPersia] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SGAPersia] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SGAPersia] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SGAPersia] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SGAPersia] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SGAPersia] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SGAPersia] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SGAPersia] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SGAPersia] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SGAPersia] SET RECOVERY FULL 
GO
ALTER DATABASE [SGAPersia] SET  MULTI_USER 
GO
ALTER DATABASE [SGAPersia] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SGAPersia] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SGAPersia] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SGAPersia] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SGAPersia] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SGAPersia', N'ON'
GO
ALTER DATABASE [SGAPersia] SET QUERY_STORE = OFF
GO
USE [SGAPersia]
GO
/****** Object:  Table [dbo].[Bodega]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[Empleado]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[EntradaCabecera]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[EntradaDetalle]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[Producto]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[Proveedor]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[SalidaCabecera]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[SalidaDetalle]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[Sucursal]    Script Date: 28-11-2020 6:21:32 ******/
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
/****** Object:  Table [dbo].[TipoProducto]    Script Date: 28-11-2020 6:21:32 ******/
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

INSERT [dbo].[Bodega] ([id_bodega], [nombre], [direccion]) VALUES (1, N'PCFactory AA', N'Las Luciernagas 82')
INSERT [dbo].[Bodega] ([id_bodega], [nombre], [direccion]) VALUES (2, N'PCFACTORY Bod CCC', N'Chile Central Continental 42')
SET IDENTITY_INSERT [dbo].[Bodega] OFF
GO
INSERT [dbo].[Empleado] ([rut_empleado], [nombre], [apellido], [password]) VALUES (N'12.345.678-9', N'Bob', N'Robins', N'1234')
GO
SET IDENTITY_INSERT [dbo].[EntradaCabecera] ON 

INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (1, CAST(N'2020-11-28T00:34:09.840' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (2, CAST(N'2020-11-28T00:38:01.700' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (10, CAST(N'2020-11-28T01:09:47.000' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (11, CAST(N'2020-11-28T01:10:32.000' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (12, CAST(N'2020-11-28T04:42:33.000' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (13, CAST(N'2020-11-28T04:43:11.000' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (14, CAST(N'2020-11-28T04:43:50.000' AS DateTime), 1, 1, N'12.345.678-9')
INSERT [dbo].[EntradaCabecera] ([cod_entrada], [fecha], [id_proveedor], [id_bodega], [rut_empleado]) VALUES (15, CAST(N'2020-11-28T05:52:12.000' AS DateTime), 1, 1, N'12.345.678-9')
SET IDENTITY_INSERT [dbo].[EntradaCabecera] OFF
GO
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (1, 1, 10)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (1, 12, 40)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (1, 13, 33)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 1, 30)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 13, 29)
INSERT [dbo].[EntradaDetalle] ([id_producto], [cod_entrada], [cantidad]) VALUES (2, 14, 120)
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (1, 6, N'Asus', N'vacio')
INSERT [dbo].[Producto] ([id_producto], [id_tipo_producto], [nombre], [descripcion]) VALUES (2, 7, N'ROG', N'nada')
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [direccion]) VALUES (1, N'prov', N'las manutas 222')
INSERT [dbo].[Proveedor] ([id_proveedor], [nombre], [direccion]) VALUES (2, N'Intel', N'Intel Central')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[SalidaCabecera] ON 

INSERT [dbo].[SalidaCabecera] ([cod_salida], [fecha], [id_sucursal], [id_bodega], [rut_empleado]) VALUES (1, CAST(N'2020-11-28T05:34:18.000' AS DateTime), 2, 2, N'12.345.678-9')
INSERT [dbo].[SalidaCabecera] ([cod_salida], [fecha], [id_sucursal], [id_bodega], [rut_empleado]) VALUES (2, CAST(N'2020-11-28T05:34:45.000' AS DateTime), 1, 1, N'12.345.678-9')
SET IDENTITY_INSERT [dbo].[SalidaCabecera] OFF
GO
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (1, 1, 20)
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (1, 2, 15)
INSERT [dbo].[SalidaDetalle] ([id_producto], [cod_salida], [cantidad]) VALUES (2, 2, 15)
GO
SET IDENTITY_INSERT [dbo].[Sucursal] ON 

INSERT [dbo].[Sucursal] ([id_sucursal], [nombre], [direccion]) VALUES (1, N'PCFactory La Florida', N'Mall Plaza Vespucion 422')
INSERT [dbo].[Sucursal] ([id_sucursal], [nombre], [direccion]) VALUES (2, N'PCFactory Puente Alto', N'Mall Plaza Puente Alto 1500')
SET IDENTITY_INSERT [dbo].[Sucursal] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoProducto] ON 

INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (6, N'Monitores')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (7, N'Gabinetes')
INSERT [dbo].[TipoProducto] ([id_tipo_producto], [nombre_tipo]) VALUES (8, N'CPU')
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
USE [master]
GO
ALTER DATABASE [SGAPersia] SET  READ_WRITE 
GO
