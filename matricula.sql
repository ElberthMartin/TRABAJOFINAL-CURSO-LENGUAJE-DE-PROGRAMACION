USE [master]
GO
/****** Object:  Database [Matricula]    Script Date: 20/09/2023 10:52:46 ******/
CREATE DATABASE [Matricula]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Matricula', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Matricula.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Matricula_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Matricula_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Matricula] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Matricula].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Matricula] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Matricula] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Matricula] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Matricula] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Matricula] SET ARITHABORT OFF 
GO
ALTER DATABASE [Matricula] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Matricula] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Matricula] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Matricula] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Matricula] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Matricula] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Matricula] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Matricula] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Matricula] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Matricula] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Matricula] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Matricula] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Matricula] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Matricula] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Matricula] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Matricula] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Matricula] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Matricula] SET RECOVERY FULL 
GO
ALTER DATABASE [Matricula] SET  MULTI_USER 
GO
ALTER DATABASE [Matricula] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Matricula] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Matricula] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Matricula] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Matricula] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Matricula] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Matricula', N'ON'
GO
ALTER DATABASE [Matricula] SET QUERY_STORE = ON
GO
ALTER DATABASE [Matricula] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Matricula]
GO
/****** Object:  Table [dbo].[MatriculaInicial]    Script Date: 20/09/2023 10:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatriculaInicial](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrimerNombre] [varchar](255) NOT NULL,
	[SegundoNombre] [varchar](255) NULL,
	[PrimerApellido] [varchar](255) NOT NULL,
	[SegundoApellido] [varchar](255) NULL,
	[Celular] [varchar](15) NULL,
	[Direccion] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[FechaNacimiento] [date] NULL,
	[Observaciones] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatriculaPrimaria]    Script Date: 20/09/2023 10:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatriculaPrimaria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrimerNombre] [varchar](255) NULL,
	[Grado] [varchar](255) NULL,
	[Seccion] [varchar](255) NULL,
	[PrimerApellido] [varchar](255) NULL,
	[SegundoApellido] [varchar](255) NULL,
	[Celular] [varchar](20) NULL,
	[Direccion] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[FechaNacimiento] [date] NULL,
	[Observaciones] [varchar](1000) NULL,
	[NivelAcademico] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatriculaSecundaria]    Script Date: 20/09/2023 10:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatriculaSecundaria](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrimerNombre] [varchar](255) NULL,
	[Grado] [varchar](255) NULL,
	[Seccion] [varchar](255) NULL,
	[PrimerApellido] [varchar](255) NULL,
	[SegundoApellido] [varchar](255) NULL,
	[Celular] [varchar](20) NULL,
	[Direccion] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[FechaNacimiento] [date] NULL,
	[Observaciones] [varchar](1000) NULL,
	[NivelAcademico] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MatriculaInicial] ON 

INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (8, N'as', N'sasad', N'asa', N'dadsd', N'ass', N'sdass', N'asasa@qwqw', CAST(N'2022-10-10' AS Date), N'As')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (10, N'223', N'e', N'we', N'e', N'weew', N'we', N'weew@dfdf', CAST(N'2020-12-14' AS Date), N'ssaa')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (12, N'223', N'e', N'we', N'e', N'weew', N'we', N'weew@dfdf', CAST(N'2020-12-14' AS Date), N'ssaa')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (13, N'223', N'e', N'we', N'e', N'weew', N'we', N'weew@dfdf', CAST(N'2020-12-14' AS Date), N'ssaa')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (14, N'mario', N'e', N'we', N'e', N'weew', N'we', N'weew@dfdf', CAST(N'2020-12-14' AS Date), N'ssaa')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (17, N'as', N'as', N'as', N'as', N'as', N'as', N'as@as', CAST(N'2020-02-14' AS Date), N'wdsdss')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (18, N'as', N'as', N'as', N'as', N'as', N'as', N'as@as', CAST(N'2020-02-14' AS Date), N'wdsdss')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (19, N'adas', N'sd', N'ad', N'ad', N'ad', N'ad', N'sd@', CAST(N'2020-02-23' AS Date), N'')
INSERT [dbo].[MatriculaInicial] ([Id], [PrimerNombre], [SegundoNombre], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones]) VALUES (1002, N'luis', N'luis angel', N'santos', N'perez', N'52369856', N'mz.lote 234', N'jhshdkh@hsk', CAST(N'2020-09-13' AS Date), N'sdsdsd')
SET IDENTITY_INSERT [dbo].[MatriculaInicial] OFF
GO
SET IDENTITY_INSERT [dbo].[MatriculaSecundaria] ON 

INSERT [dbo].[MatriculaSecundaria] ([Id], [PrimerNombre], [Grado], [Seccion], [PrimerApellido], [SegundoApellido], [Celular], [Direccion], [Email], [FechaNacimiento], [Observaciones], [NivelAcademico]) VALUES (4, N'julia', N'4', N'B', N'lics', N'sannchez', N'5655653236', N'mz.lote2', N'78sj@gjshj.com', CAST(N'2002-08-05' AS Date), N'wwyiyudahk', N'Secundaria')
SET IDENTITY_INSERT [dbo].[MatriculaSecundaria] OFF
GO
ALTER TABLE [dbo].[MatriculaPrimaria] ADD  DEFAULT ('Primaria') FOR [Grado]
GO
ALTER TABLE [dbo].[MatriculaPrimaria] ADD  DEFAULT ('Primaria') FOR [NivelAcademico]
GO
ALTER TABLE [dbo].[MatriculaSecundaria] ADD  DEFAULT ('Secundaria') FOR [Grado]
GO
ALTER TABLE [dbo].[MatriculaSecundaria] ADD  DEFAULT ('Secundaria') FOR [NivelAcademico]
GO
USE [master]
GO
ALTER DATABASE [Matricula] SET  READ_WRITE 
GO
