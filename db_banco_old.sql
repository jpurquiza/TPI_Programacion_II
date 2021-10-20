﻿USE [master]
GO
/****** Object:  Database [db_banco]    Script Date: 18/10/2021 23:00:34 ******/
CREATE DATABASE [db_banco]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_banco', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_banco.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_banco_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\db_banco_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [db_banco] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_banco].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_banco] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_banco] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_banco] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_banco] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_banco] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_banco] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_banco] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_banco] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_banco] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_banco] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_banco] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_banco] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_banco] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_banco] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_banco] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_banco] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_banco] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_banco] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_banco] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_banco] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_banco] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_banco] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_banco] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_banco] SET  MULTI_USER 
GO
ALTER DATABASE [db_banco] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_banco] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_banco] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_banco] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_banco] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_banco] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_banco] SET QUERY_STORE = OFF
GO
USE [db_banco]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 18/10/2021 23:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[id_cuenta] [int] NULL,
	[id_destinatario] [int] NULL,
	[nro_dni] [int] NULL,
	[apellido] [varchar](20) NULL,
	[nombre] [varchar](20) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [pk_clientes] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CUENTAS]    Script Date: 18/10/2021 23:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CUENTAS](
	[id_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo_cuenta] [int] NULL,
	[nro_cbu] [int] NULL,
	[saldo] [decimal](10, 2) NULL,
 CONSTRAINT [pk_cuentas] PRIMARY KEY CLUSTERED 
(
	[id_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DESTINATARIOS]    Script Date: 18/10/2021 23:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DESTINATARIOS](
	[id_destinatario] [int] IDENTITY(1,1) NOT NULL,
	[nro_cbu] [int] NULL,
	[nro_dni] [int] NULL,
	[apellido] [varchar](20) NULL,
	[nombre] [varchar](20) NULL,
	[email] [varchar](50) NULL,
 CONSTRAINT [pk_destinatarios] PRIMARY KEY CLUSTERED 
(
	[id_destinatario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_CUENTA]    Script Date: 18/10/2021 23:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_CUENTA](
	[id_tipo_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[tipo_cuenta] [varchar](30) NULL,
 CONSTRAINT [pk_tipos_cuenta] PRIMARY KEY CLUSTERED 
(
	[id_tipo_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRANSACCIONES]    Script Date: 18/10/2021 23:00:34 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRANSACCIONES](
	[id_transaccion] [int] IDENTITY(1,1) NOT NULL,
	[id_cuenta] [int] NULL,
	[id_destinatario] [int] NULL,
	[fecha] [datetime] NULL,
	[monto] [decimal](10, 2) NULL,
 CONSTRAINT [pk_transacciones] PRIMARY KEY CLUSTERED 
(
	[id_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [fk_clientes_cuentas] FOREIGN KEY([id_cuenta])
REFERENCES [dbo].[CUENTAS] ([id_cuenta])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [fk_clientes_cuentas]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [fk_clientes_destinatarios] FOREIGN KEY([id_destinatario])
REFERENCES [dbo].[DESTINATARIOS] ([id_destinatario])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [fk_clientes_destinatarios]
GO
ALTER TABLE [dbo].[CUENTAS]  WITH CHECK ADD  CONSTRAINT [fk_cuentas_tipos_cuenta] FOREIGN KEY([id_tipo_cuenta])
REFERENCES [dbo].[TIPOS_CUENTA] ([id_tipo_cuenta])
GO
ALTER TABLE [dbo].[CUENTAS] CHECK CONSTRAINT [fk_cuentas_tipos_cuenta]
GO
ALTER TABLE [dbo].[TRANSACCIONES]  WITH CHECK ADD  CONSTRAINT [fk_transacciones_cuentas] FOREIGN KEY([id_cuenta])
REFERENCES [dbo].[CUENTAS] ([id_cuenta])
GO
ALTER TABLE [dbo].[TRANSACCIONES] CHECK CONSTRAINT [fk_transacciones_cuentas]
GO
ALTER TABLE [dbo].[TRANSACCIONES]  WITH CHECK ADD  CONSTRAINT [fk_transacciones_destinatarios] FOREIGN KEY([id_destinatario])
REFERENCES [dbo].[DESTINATARIOS] ([id_destinatario])
GO
ALTER TABLE [dbo].[TRANSACCIONES] CHECK CONSTRAINT [fk_transacciones_destinatarios]
GO
USE [master]
GO
ALTER DATABASE [db_banco] SET  READ_WRITE 
GO
