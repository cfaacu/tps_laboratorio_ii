USE [master]
GO
/****** Object:  Database [TP4_Careri_Facundo]    Script Date: 22/11/2021 12:55:00 ******/
CREATE DATABASE [TP4_Careri_Facundo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Personas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Personas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Personas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Personas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4_Careri_Facundo] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4_Careri_Facundo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET  MULTI_USER 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4_Careri_Facundo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4_Careri_Facundo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4_Careri_Facundo] SET QUERY_STORE = OFF
GO
USE [TP4_Careri_Facundo]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 22/11/2021 12:55:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[edad] [int] NOT NULL,
	[sexo] [int] NOT NULL,
	[nacionalidad] [int] NOT NULL,
	[estadoCivil] [int] NOT NULL,
	[puesto] [int] NOT NULL,
	[sueldo] [float] NOT NULL,
	[activo] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 

INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (1, N'Pepe', N'Alonzo', 25, 1, 1, 0, 0, 15000, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (2, N'Rodolfo', N'Benitez', 32, 1, 0, 1, 3, 18000, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (3, N'Facundo', N'Careri', 21, 1, 0, 1, 4, 25000, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (4, N'Patricio', N'Gomez', 45, 1, 1, 0, 4, 28000, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (5, N'Roberto', N'Carlos', 65, 1, 2, 0, 2, 45000, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (6, N'Carla', N'Sport', 48, 0, 3, 3, 3, 65000, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (7, N'Lazaro', N'Vizcaino', 37, 1, 3, 2, 1, 89000, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (8, N'Lourdes', N'Antolin', 31, 0, 5, 3, 1, 76500, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (9, N'Maria', N'Santos', 19, 0, 4, 2, 2, 19800, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (10, N'Camila', N'Amor', 53, 0, 2, 1, 3, 42300, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (11, N'Elisa', N'Rodriguez', 34, 0, 5, 3, 0, 32200, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (12, N'Marwa', N'Manrique', 69, 0, 4, 0, 0, 29600, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (13, N'Amanda', N'Ribera', 37, 0, 3, 2, 4, 32100, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (14, N'Rodolfo', N'Aguado', 67, 2, 1, 1, 1, 23450, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (15, N'Uxuea', N'Mesa', 51, 2, 0, 2, 0, 36460, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (16, N'Leyre', N'Prados', 33, 2, 2, 0, 4, 44560, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (17, N'Arnau', N'Betancor', 55, 1, 0, 3, 3, 87800, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (18, N'Fermina', N'Sierra', 22, 3, 3, 1, 2, 57800, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (19, N'Arantxa', N'Aroca', 18, 3, 2, 2, 4, 26500, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (20, N'Nina', N'Elvira', 48, 0, 0, 0, 2, 21600, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (21, N'Marcela', N'Calero', 30, 0, 4, 3, 0, 22460, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (22, N'Florin', N'Canas', 41, 1, 5, 0, 0, 27940, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (23, N'Jordi', N'Cabello', 39, 1, 4, 1, 1, 65900, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (24, N'Fernando', N'Bolsa', 50, 1, 5, 2, 3, 24000, 1)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (1024, N'Sandra', N'Bulok', 47, 2, 0, 1, 3, 50000, 0)
INSERT [dbo].[Empleados] ([id], [nombre], [apellido], [edad], [sexo], [nacionalidad], [estadoCivil], [puesto], [sueldo], [activo]) VALUES (2024, N'pepe', N'alonso', 20, 2, 1, 1, 2, 15000, 1)
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
USE [master]
GO
ALTER DATABASE [TP4_Careri_Facundo] SET  READ_WRITE 
GO
