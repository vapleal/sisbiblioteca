USE [master]
GO
/****** Object:  Database [bd-biblioteca]    Script Date: 20/12/2021 20:27:23 ******/
CREATE DATABASE [bd-biblioteca]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bd-biblioteca', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd-biblioteca.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bd-biblioteca_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\bd-biblioteca_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bd-biblioteca] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bd-biblioteca].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bd-biblioteca] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bd-biblioteca] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bd-biblioteca] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bd-biblioteca] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bd-biblioteca] SET ARITHABORT OFF 
GO
ALTER DATABASE [bd-biblioteca] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bd-biblioteca] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bd-biblioteca] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bd-biblioteca] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bd-biblioteca] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bd-biblioteca] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bd-biblioteca] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bd-biblioteca] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bd-biblioteca] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bd-biblioteca] SET  DISABLE_BROKER 
GO
ALTER DATABASE [bd-biblioteca] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bd-biblioteca] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bd-biblioteca] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bd-biblioteca] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bd-biblioteca] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bd-biblioteca] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bd-biblioteca] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bd-biblioteca] SET RECOVERY FULL 
GO
ALTER DATABASE [bd-biblioteca] SET  MULTI_USER 
GO
ALTER DATABASE [bd-biblioteca] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bd-biblioteca] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bd-biblioteca] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bd-biblioteca] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bd-biblioteca] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bd-biblioteca] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bd-biblioteca', N'ON'
GO
ALTER DATABASE [bd-biblioteca] SET QUERY_STORE = OFF
GO
USE [bd-biblioteca]
GO
/****** Object:  Table [dbo].[tb_autor]    Script Date: 20/12/2021 20:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_autor](
	[id_autor] [int] IDENTITY(1,1) NOT NULL,
	[nome_autor] [varchar](150) NOT NULL,
	[nac_autor] [varchar](100) NOT NULL,
	[genero_autor] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_autor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_livro]    Script Date: 20/12/2021 20:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_livro](
	[isbn_livro] [varchar](15) NOT NULL,
	[titulo_livro] [varchar](100) NOT NULL,
	[gen_livro] [varchar](3) NOT NULL,
	[sin_livro] [varchar](255) NULL,
	[capa_livro] [varchar](50) NULL,
	[pk_autor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[isbn_livro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_usuario]    Script Date: 20/12/2021 20:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_usuario](
	[id_usu] [int] IDENTITY(1,1) NOT NULL,
	[nome_usu] [varchar](100) NULL,
	[login_usu] [varchar](20) NULL,
	[senha_usu] [varchar](20) NULL,
	[nivel_usu] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_autor] ON 

INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (1, N'autor zero um', N'brasil', N'ficção')
INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (2, N'autor zero um', N'brasil', N'ficção')
INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (3, N'autor um dois', N'eua', N'ficção')
INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (4, N'autor dois tres', N'eua', N'ficção')
INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (6, N'autor zero um', N'cuba', N'ficção')
INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (7, N'autor quatro cinco', N'arabia', N'ficção')
INSERT [dbo].[tb_autor] ([id_autor], [nome_autor], [nac_autor], [genero_autor]) VALUES (8, N'Teste', N'Algum lugar', N'variado')
SET IDENTITY_INSERT [dbo].[tb_autor] OFF
GO
INSERT [dbo].[tb_livro] ([isbn_livro], [titulo_livro], [gen_livro], [sin_livro], [capa_livro], [pk_autor]) VALUES (N'111111111111', N'teste', N'fic', N'', N'0', 3)
INSERT [dbo].[tb_livro] ([isbn_livro], [titulo_livro], [gen_livro], [sin_livro], [capa_livro], [pk_autor]) VALUES (N'12222222', N'teste', N'rom', N'casdasdasd', N'22112019142913.jpg', 1)
INSERT [dbo].[tb_livro] ([isbn_livro], [titulo_livro], [gen_livro], [sin_livro], [capa_livro], [pk_autor]) VALUES (N'1222222222', N'Titulo Teste', N'pol', N'dwfasfdasfd', N'22112019142933.jpg', 1)
INSERT [dbo].[tb_livro] ([isbn_livro], [titulo_livro], [gen_livro], [sin_livro], [capa_livro], [pk_autor]) VALUES (N'1233333333', N'Teste dois', N'fan', N'asdASDdsADS', N'22112019143231.jpg', 1)
GO
SET IDENTITY_INSERT [dbo].[tb_usuario] ON 

INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (1, N'Administrador', N'admin', N'123', N'0')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (2, N'Usuario Novo Um', N'user1', N'456', N'0')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (5, N'Teste Online', N'TesteOnline', N'741', N'0')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (7, N'Teste 1', N't1', N'111', N'1')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (8, N'Teste 2', N't2', N'222', N'0')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (9, N'Teste 3', N't3', N'333', N'1')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (10, N'Teste 4', N't4', N'444', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (11, N'Teste 5', N't5', N'555', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (12, N'Teste 6', N't6', N'666', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (13, N'Teste 7', N't7', N'777', N'1')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (14, N'Teste 8', N't8', N'888', N'1')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (15, N'Teste 9', N't9', N'999', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (16, N'Teste 10', N't10', N'101', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (17, N'Teste 11', N't11', N'110', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (18, N'Teste 12', N't12', N'121', N'2')
INSERT [dbo].[tb_usuario] ([id_usu], [nome_usu], [login_usu], [senha_usu], [nivel_usu]) VALUES (19, N'Teste 13', N't13', N'131', N'1')
SET IDENTITY_INSERT [dbo].[tb_usuario] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__tb_usuar__0EA877E10CFA3977]    Script Date: 20/12/2021 20:27:24 ******/
ALTER TABLE [dbo].[tb_usuario] ADD UNIQUE NONCLUSTERED 
(
	[login_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_livro]  WITH CHECK ADD FOREIGN KEY([pk_autor])
REFERENCES [dbo].[tb_autor] ([id_autor])
GO
/****** Object:  StoredProcedure [dbo].[pr_login_usu]    Script Date: 20/12/2021 20:27:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_login_usu] 
@usuario VARCHAR(100),
@senha VARCHAR(20)
AS
SELECT * FROM tb_usuario WHERE 
login_usu = @usuario AND 
senha_usu = @senha
GO
USE [master]
GO
ALTER DATABASE [bd-biblioteca] SET  READ_WRITE 
GO
