USE [master]
GO
/****** Object:  Database [TorneoNatacion]    Script Date: 20/11/2019 10:26:48 ******/
CREATE DATABASE [TorneoNatacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TorneoNatacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TorneoNatacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TorneoNatacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\TorneoNatacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [TorneoNatacion] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TorneoNatacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TorneoNatacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TorneoNatacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TorneoNatacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TorneoNatacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TorneoNatacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [TorneoNatacion] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TorneoNatacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TorneoNatacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TorneoNatacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TorneoNatacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TorneoNatacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TorneoNatacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TorneoNatacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TorneoNatacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TorneoNatacion] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TorneoNatacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TorneoNatacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TorneoNatacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TorneoNatacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TorneoNatacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TorneoNatacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TorneoNatacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TorneoNatacion] SET RECOVERY FULL 
GO
ALTER DATABASE [TorneoNatacion] SET  MULTI_USER 
GO
ALTER DATABASE [TorneoNatacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TorneoNatacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TorneoNatacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TorneoNatacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TorneoNatacion] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'TorneoNatacion', N'ON'
GO
ALTER DATABASE [TorneoNatacion] SET QUERY_STORE = OFF
GO
USE [TorneoNatacion]
GO
/****** Object:  Table [dbo].[Clubs]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clubs](
	[id_Club] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[calle] [varchar](50) NULL,
	[numero] [varchar](50) NULL,
 CONSTRAINT [PK_Clubs] PRIMARY KEY CLUSTERED 
(
	[id_Club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidades]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidades](
	[id_Especialidad] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Especialidades] PRIMARY KEY CLUSTERED 
(
	[id_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripto]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripto](
	[fecha] [date] NOT NULL,
	[id_Torneo] [int] NOT NULL,
	[id_Nadador] [int] NOT NULL,
	[posicion] [int] NULL,
	[tiempo] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nadadores]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nadadores](
	[id_Nadador] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[id_tipoDoc] [int] NULL,
	[dni] [varchar](50) NULL,
	[id_Club] [int] NULL,
	[id_Profesor] [int] NULL,
 CONSTRAINT [PK_Nadadores] PRIMARY KEY CLUSTERED 
(
	[id_Nadador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NadadorXEspecialidad]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NadadorXEspecialidad](
	[id_Nadador] [int] NOT NULL,
	[id_Especialidad] [int] NOT NULL,
 CONSTRAINT [PK_NadadorXEspecialidad] PRIMARY KEY CLUSTERED 
(
	[id_Nadador] ASC,
	[id_Especialidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profesores]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesores](
	[id_Profesor] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Profesores] PRIMARY KEY CLUSTERED 
(
	[id_Profesor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProfesorXClub]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProfesorXClub](
	[id_Profesor] [int] NOT NULL,
	[id_Club] [int] NOT NULL,
 CONSTRAINT [PK_ProfesorXClub] PRIMARY KEY CLUSTERED 
(
	[id_Profesor] ASC,
	[id_Club] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoDocumentos]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDocumentos](
	[id_tipoDoc] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_TipoDocumentos] PRIMARY KEY CLUSTERED 
(
	[id_tipoDoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Torneo]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Torneo](
	[id_Torneo] [int] NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_Torneo] PRIMARY KEY CLUSTERED 
(
	[id_Torneo] ASC,
	[fecha] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 20/11/2019 10:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[nombre] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inscripto]  WITH CHECK ADD  CONSTRAINT [FK_Insc_id_Nadador] FOREIGN KEY([id_Nadador])
REFERENCES [dbo].[Nadadores] ([id_Nadador])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripto] CHECK CONSTRAINT [FK_Insc_id_Nadador]
GO
ALTER TABLE [dbo].[Nadadores]  WITH CHECK ADD  CONSTRAINT [FK_id_Club] FOREIGN KEY([id_Club])
REFERENCES [dbo].[Clubs] ([id_Club])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nadadores] CHECK CONSTRAINT [FK_id_Club]
GO
ALTER TABLE [dbo].[Nadadores]  WITH CHECK ADD  CONSTRAINT [FK_id_Profesor] FOREIGN KEY([id_Profesor])
REFERENCES [dbo].[Profesores] ([id_Profesor])
GO
ALTER TABLE [dbo].[Nadadores] CHECK CONSTRAINT [FK_id_Profesor]
GO
ALTER TABLE [dbo].[Nadadores]  WITH CHECK ADD  CONSTRAINT [FK_id_tipoDoc] FOREIGN KEY([id_tipoDoc])
REFERENCES [dbo].[TipoDocumentos] ([id_tipoDoc])
GO
ALTER TABLE [dbo].[Nadadores] CHECK CONSTRAINT [FK_id_tipoDoc]
GO
ALTER TABLE [dbo].[NadadorXEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_id_Especialidad] FOREIGN KEY([id_Especialidad])
REFERENCES [dbo].[Especialidades] ([id_Especialidad])
GO
ALTER TABLE [dbo].[NadadorXEspecialidad] CHECK CONSTRAINT [FK_id_Especialidad]
GO
ALTER TABLE [dbo].[NadadorXEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_id_Nadador] FOREIGN KEY([id_Nadador])
REFERENCES [dbo].[Nadadores] ([id_Nadador])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NadadorXEspecialidad] CHECK CONSTRAINT [FK_id_Nadador]
GO
ALTER TABLE [dbo].[NadadorXEspecialidad]  WITH CHECK ADD  CONSTRAINT [FK_NadadorXEspecialidad_NadadorXEspecialidad] FOREIGN KEY([id_Nadador], [id_Especialidad])
REFERENCES [dbo].[NadadorXEspecialidad] ([id_Nadador], [id_Especialidad])
GO
ALTER TABLE [dbo].[NadadorXEspecialidad] CHECK CONSTRAINT [FK_NadadorXEspecialidad_NadadorXEspecialidad]
GO
ALTER TABLE [dbo].[ProfesorXClub]  WITH CHECK ADD  CONSTRAINT [FK_Id_Clubs] FOREIGN KEY([id_Club])
REFERENCES [dbo].[Clubs] ([id_Club])
GO
ALTER TABLE [dbo].[ProfesorXClub] CHECK CONSTRAINT [FK_Id_Clubs]
GO
ALTER TABLE [dbo].[ProfesorXClub]  WITH CHECK ADD  CONSTRAINT [FK_Id_Profe] FOREIGN KEY([id_Profesor])
REFERENCES [dbo].[Profesores] ([id_Profesor])
GO
ALTER TABLE [dbo].[ProfesorXClub] CHECK CONSTRAINT [FK_Id_Profe]
GO
USE [master]
GO
ALTER DATABASE [TorneoNatacion] SET  READ_WRITE 
GO
