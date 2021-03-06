USE [SarkiAlbumUygulama]
GO
/****** Object:  StoredProcedure [dbo].[procTurSil]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procTurSil]
GO
/****** Object:  StoredProcedure [dbo].[procTurSarkiciEkle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procTurSarkiciEkle]
GO
/****** Object:  StoredProcedure [dbo].[procTurGuncelle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procTurGuncelle]
GO
/****** Object:  StoredProcedure [dbo].[procTurGetir]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procTurGetir]
GO
/****** Object:  StoredProcedure [dbo].[procTurEkle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procTurEkle]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiSil]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiSil]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiGuncelle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiGuncelle]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiGetir]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiGetir]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiEkle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiEkle]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiciSil]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiciSil]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiciGuncelle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiciGuncelle]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiciGetir]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiciGetir]
GO
/****** Object:  StoredProcedure [dbo].[procSarkiciEkle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procSarkiciEkle]
GO
/****** Object:  StoredProcedure [dbo].[ProcAlbumSil]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[ProcAlbumSil]
GO
/****** Object:  StoredProcedure [dbo].[procAlbumGuncelle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procAlbumGuncelle]
GO
/****** Object:  StoredProcedure [dbo].[procAlbumGetir]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procAlbumGetir]
GO
/****** Object:  StoredProcedure [dbo].[procAlbumEkle]    Script Date: 5.08.2016 12:22:04 ******/
DROP PROCEDURE [dbo].[procAlbumEkle]
GO
ALTER TABLE [dbo].[Sarkici] DROP CONSTRAINT [FK_Sarkici_Turler]
GO
ALTER TABLE [dbo].[Sarki] DROP CONSTRAINT [FK_Sarki_Album]
GO
ALTER TABLE [dbo].[Album] DROP CONSTRAINT [FK_Album_Sarkici]
GO
/****** Object:  Table [dbo].[Turler]    Script Date: 5.08.2016 12:22:04 ******/
DROP TABLE [dbo].[Turler]
GO
/****** Object:  Table [dbo].[Sarkici]    Script Date: 5.08.2016 12:22:04 ******/
DROP TABLE [dbo].[Sarkici]
GO
/****** Object:  Table [dbo].[Sarki]    Script Date: 5.08.2016 12:22:04 ******/
DROP TABLE [dbo].[Sarki]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 5.08.2016 12:22:04 ******/
DROP TABLE [dbo].[Album]
GO
/****** Object:  User [ahmetn]    Script Date: 5.08.2016 12:22:04 ******/
DROP USER [ahmetn]
GO
USE [master]
GO
/****** Object:  Database [SarkiAlbumUygulama]    Script Date: 5.08.2016 12:22:04 ******/
DROP DATABASE [SarkiAlbumUygulama]
GO
/****** Object:  Database [SarkiAlbumUygulama]    Script Date: 5.08.2016 12:22:04 ******/
CREATE DATABASE [SarkiAlbumUygulama]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SarkiAlbumUygulama', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SarkiAlbumUygulama.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SarkiAlbumUygulama_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SarkiAlbumUygulama_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SarkiAlbumUygulama] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SarkiAlbumUygulama].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SarkiAlbumUygulama] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET ARITHABORT OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET RECOVERY FULL 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET  MULTI_USER 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SarkiAlbumUygulama] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SarkiAlbumUygulama] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SarkiAlbumUygulama', N'ON'
GO
USE [SarkiAlbumUygulama]
GO
/****** Object:  User [ahmetn]    Script Date: 5.08.2016 12:22:04 ******/
CREATE USER [ahmetn] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 5.08.2016 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[AlbumID] [int] IDENTITY(1,1) NOT NULL,
	[AlbumAdi] [nvarchar](50) NOT NULL,
	[AlbumAciklama] [nvarchar](250) NOT NULL,
	[AlbumSarkiciID] [int] NOT NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[AlbumID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sarki]    Script Date: 5.08.2016 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sarki](
	[SarkiID] [int] IDENTITY(1,1) NOT NULL,
	[SarkiAdi] [nvarchar](50) NOT NULL,
	[SarkiSozleri] [nvarchar](250) NOT NULL,
	[Besteci] [nvarchar](50) NOT NULL,
	[SozYazari] [nvarchar](50) NOT NULL,
	[AlbumID] [int] NOT NULL,
	[CikisTarihi] [datetime] NOT NULL,
 CONSTRAINT [PK_Sarki] PRIMARY KEY CLUSTERED 
(
	[SarkiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sarkici]    Script Date: 5.08.2016 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sarkici](
	[SarkiciID] [int] IDENTITY(1,1) NOT NULL,
	[SarkiciAdi] [nvarchar](50) NOT NULL,
	[SarkiciSoyadi] [nvarchar](50) NOT NULL,
	[SarkiciTurID] [int] NOT NULL,
 CONSTRAINT [PK_Sarkici] PRIMARY KEY CLUSTERED 
(
	[SarkiciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Turler]    Script Date: 5.08.2016 12:22:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turler](
	[TurID] [int] IDENTITY(1,1) NOT NULL,
	[TurAdi] [nvarchar](50) NOT NULL,
	[TurAciklama] [nvarchar](250) NULL,
 CONSTRAINT [PK_Turler] PRIMARY KEY CLUSTERED 
(
	[TurID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Album] ON 

INSERT [dbo].[Album] ([AlbumID], [AlbumAdi], [AlbumAciklama], [AlbumSarkiciID]) VALUES (1, N'adadsa11', N'dadasldjaldsad', 1)
INSERT [dbo].[Album] ([AlbumID], [AlbumAdi], [AlbumAciklama], [AlbumSarkiciID]) VALUES (2, N'dadasdas1', N'weweew1', 2)
SET IDENTITY_INSERT [dbo].[Album] OFF
SET IDENTITY_INSERT [dbo].[Sarki] ON 

INSERT [dbo].[Sarki] ([SarkiID], [SarkiAdi], [SarkiSozleri], [Besteci], [SozYazari], [AlbumID], [CikisTarihi]) VALUES (1, N'AAA', N'BBB', N'cccc', N'dsadas', 1, CAST(N'2015-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[Sarki] ([SarkiID], [SarkiAdi], [SarkiSozleri], [Besteci], [SozYazari], [AlbumID], [CikisTarihi]) VALUES (4, N'AAA9', N'BBB3', N'cccc1', N'dsadas1', 1, CAST(N'2015-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[Sarki] ([SarkiID], [SarkiAdi], [SarkiSozleri], [Besteci], [SozYazari], [AlbumID], [CikisTarihi]) VALUES (5, N'AAA2', N'BBB2', N'cccc1', N'dsadas1', 1, CAST(N'2015-06-16 00:00:00.000' AS DateTime))
INSERT [dbo].[Sarki] ([SarkiID], [SarkiAdi], [SarkiSozleri], [Besteci], [SozYazari], [AlbumID], [CikisTarihi]) VALUES (6, N'AAA8', N'BBB3', N'cccc1', N'dsadas1', 1, CAST(N'2015-06-16 00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Sarki] OFF
SET IDENTITY_INSERT [dbo].[Sarkici] ON 

INSERT [dbo].[Sarkici] ([SarkiciID], [SarkiciAdi], [SarkiciSoyadi], [SarkiciTurID]) VALUES (1, N'AAAA11', N'BBBB11', 1)
INSERT [dbo].[Sarkici] ([SarkiciID], [SarkiciAdi], [SarkiciSoyadi], [SarkiciTurID]) VALUES (2, N'BBBB12', N'CCCC12', 2)
INSERT [dbo].[Sarkici] ([SarkiciID], [SarkiciAdi], [SarkiciSoyadi], [SarkiciTurID]) VALUES (3, N'CCCC', N'DDDD', 1)
INSERT [dbo].[Sarkici] ([SarkiciID], [SarkiciAdi], [SarkiciSoyadi], [SarkiciTurID]) VALUES (5, N'CCCC', N'DDDD', 8)
SET IDENTITY_INSERT [dbo].[Sarkici] OFF
SET IDENTITY_INSERT [dbo].[Turler] ON 

INSERT [dbo].[Turler] ([TurID], [TurAdi], [TurAciklama]) VALUES (1, N'Pop', N'Pop Müzik')
INSERT [dbo].[Turler] ([TurID], [TurAdi], [TurAciklama]) VALUES (2, N'Rock', N'Rock Müzik')
INSERT [dbo].[Turler] ([TurID], [TurAdi], [TurAciklama]) VALUES (8, N'AAAA', N'BBBB')
SET IDENTITY_INSERT [dbo].[Turler] OFF
ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_Album_Sarkici] FOREIGN KEY([AlbumSarkiciID])
REFERENCES [dbo].[Sarkici] ([SarkiciID])
GO
ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_Album_Sarkici]
GO
ALTER TABLE [dbo].[Sarki]  WITH CHECK ADD  CONSTRAINT [FK_Sarki_Album] FOREIGN KEY([AlbumID])
REFERENCES [dbo].[Album] ([AlbumID])
GO
ALTER TABLE [dbo].[Sarki] CHECK CONSTRAINT [FK_Sarki_Album]
GO
ALTER TABLE [dbo].[Sarkici]  WITH CHECK ADD  CONSTRAINT [FK_Sarkici_Turler] FOREIGN KEY([SarkiciTurID])
REFERENCES [dbo].[Turler] ([TurID])
GO
ALTER TABLE [dbo].[Sarkici] CHECK CONSTRAINT [FK_Sarkici_Turler]
GO
/****** Object:  StoredProcedure [dbo].[procAlbumEkle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procAlbumEkle] 
	-- Add the parameters for the stored procedure here
	@AlbumAdi nvarchar(50),
	@AlbumAciklama nvarchar(250),
	@SarkiciID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Album Values(@AlbumAdi,@AlbumAciklama,@SarkiciID)
END

GO
/****** Object:  StoredProcedure [dbo].[procAlbumGetir]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procAlbumGetir]
	@SarkiciID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select * from Album where AlbumSarkiciID=@SarkiciID
END

GO
/****** Object:  StoredProcedure [dbo].[procAlbumGuncelle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procAlbumGuncelle] 
	-- Add the parameters for the stored procedure here
	@AlbumAdi nvarchar(50),
	@AlbumAciklama nvarchar(250),
	@SarkiciID int,
	@AlbumID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Album set AlbumAdi=@AlbumAdi,AlbumAciklama=@AlbumAciklama,AlbumSarkiciID=@SarkiciID where AlbumID=@AlbumID
END

GO
/****** Object:  StoredProcedure [dbo].[ProcAlbumSil]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[ProcAlbumSil]
	@AlbumID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete from Album where AlbumID=@AlbumID
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiciEkle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiciEkle]
	@SarkiciAdi nvarchar(50),
	@SarkiciSoyadi nvarchar(50),
	@TurId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Sarkici Values(@SarkiciAdi,@SarkiciSoyadi,@TurId)
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiciGetir]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiciGetir]
	
	@TurID int
AS

BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select * from Sarkici where SarkiciTurID=@TurID
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiciGuncelle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiciGuncelle]
	@SarkiciAdi nvarchar(50),
	@SarkiciSoyadi nvarchar(50),
	@TurId int,
	@SarkiciID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Sarkici set SarkiciAdi=@SarkiciAdi,SarkiciSoyadi=@SarkiciSoyadi,SarkiciTurID=@TurId where SarkiciID=@SarkiciID
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiciSil]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiciSil]
	@SarkiciID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete Sarkici where SarkiciID=@SarkiciID
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiEkle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiEkle]
   @SarkiSozleri nvarchar(250),
   @SarkiAdi nvarchar(50),
   @Besteci nvarchar(50),
   @SozYazari nvarchar(50),
   @AlbumID int,
   @Cikis datetime
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Sarki Values(@SarkiAdi,@SarkiSozleri,@Besteci,@SozYazari,@AlbumID,@Cikis)
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiGetir]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiGetir]
	@AlbumID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select * from Sarki where AlbumID=@AlbumID
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiGuncelle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procSarkiGuncelle]
   @SarkiSozleri nvarchar(250),
   @SarkiAdi nvarchar(50),
   @Besteci nvarchar(50),
   @SozYazari nvarchar(50),
   @AlbumID int,
   @Cikis datetime,
   @SarkiID int
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Sarki set SarkiAdi= @SarkiAdi,SarkiSozleri= @SarkiSozleri,Besteci= @Besteci,SozYazari= @SozYazari,AlbumID= @AlbumID,CikisTarihi = @Cikis where 
	SarkiID=@SarkiID
END

GO
/****** Object:  StoredProcedure [dbo].[procSarkiSil]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
Create PROCEDURE [dbo].[procSarkiSil]
  
   @SarkiID int
As
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Delete Sarki where SarkiID=@SarkiID
END

GO
/****** Object:  StoredProcedure [dbo].[procTurEkle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procTurEkle]
	@TurAdi nvarchar(50),
	@TurAciklama nvarchar(250)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Insert into Turler Values(@TurAdi,@TurAciklama)
END

GO
/****** Object:  StoredProcedure [dbo].[procTurGetir]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procTurGetir]
	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Select * from Turler
END

GO
/****** Object:  StoredProcedure [dbo].[procTurGuncelle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procTurGuncelle]
	@TurAdi nvarchar(50),
	@TurAciklama nvarchar(250),
	@TurID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	Update Turler  set TurAdi= @TurAdi,TurAciklama= @TurAciklama where TurID=@TurID
END

GO
/****** Object:  StoredProcedure [dbo].[procTurSarkiciEkle]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procTurSarkiciEkle]
	@TurAdi nvarchar(50),
	@TurAciklama nvarchar(250),
	@TurId int,
	@SarkiciAdi nvarchar(50),
	@SarkiciSoyadi nvarchar(50),
    @id int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into Turler Values(@TurAdi,@TurAciklama)
    
     select @id=TurID from Turler where TurAdi=@TurAdi
    Insert into Sarkici Values(@SarkiciAdi,@SarkiciSoyadi,@id)
    
END

GO
/****** Object:  StoredProcedure [dbo].[procTurSil]    Script Date: 5.08.2016 12:22:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[procTurSil]
	@TurID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	delete Turler where TurID=@TurID
END

GO
USE [master]
GO
ALTER DATABASE [SarkiAlbumUygulama] SET  READ_WRITE 
GO
