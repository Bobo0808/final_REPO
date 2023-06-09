USE [master]
GO
/****** Object:  Database [ChickenLife]    Script Date: 2023/4/3 下午 06:24:12 ******/
CREATE DATABASE [ChickenLife]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ChickenLife', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ChickenLife.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ChickenLife_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ChickenLife_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ChickenLife] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ChickenLife].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ChickenLife] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ChickenLife] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ChickenLife] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ChickenLife] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ChickenLife] SET ARITHABORT OFF 
GO
ALTER DATABASE [ChickenLife] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ChickenLife] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ChickenLife] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ChickenLife] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ChickenLife] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ChickenLife] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ChickenLife] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ChickenLife] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ChickenLife] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ChickenLife] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ChickenLife] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ChickenLife] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ChickenLife] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ChickenLife] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ChickenLife] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ChickenLife] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ChickenLife] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ChickenLife] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ChickenLife] SET  MULTI_USER 
GO
ALTER DATABASE [ChickenLife] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ChickenLife] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ChickenLife] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ChickenLife] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ChickenLife] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ChickenLife] SET QUERY_STORE = OFF
GO
USE [ChickenLife]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[A_ID] [int] IDENTITY(1,1) NOT NULL,
	[A_Name] [nvarchar](20) NOT NULL,
	[UserName] [nvarchar](20) NOT NULL,
	[UserPWD] [nvarchar](30) NOT NULL,
	[A_Gender] [int] NULL,
	[A_Birthday] [datetime] NULL,
	[A_level] [int] NULL,
	[A_Email] [nvarchar](50) NOT NULL,
	[A_Phone] [nvarchar](50) NULL,
	[A_add] [nvarchar](50) NULL,
	[A_RegisteredAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[A_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Debuglog]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Debuglog](
	[D_id] [int] IDENTITY(1,1) NOT NULL,
	[A_id] [int] NOT NULL,
	[D_time] [datetime] NOT NULL,
	[D_event] [varchar](50) NOT NULL,
	[D_isSolved] [bit] NOT NULL,
 CONSTRAINT [PK__Debuglog__76B7E375186BE7AB] PRIMARY KEY CLUSTERED 
(
	[D_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginStaus]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginStaus](
	[L_id] [int] IDENTITY(1,1) NOT NULL,
	[A_id] [int] NOT NULL,
	[L_cTime] [datetime] NOT NULL,
	[L_dcTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[L_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Map]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Map](
	[m_id] [int] IDENTITY(1,1) NOT NULL,
	[m_desc] [varchar](20) NOT NULL,
	[m_type] [int] NOT NULL,
	[m_src] [varchar](50) NOT NULL,
	[m_minX] [int] NOT NULL,
	[m_minY] [int] NOT NULL,
	[m_maxX] [int] NOT NULL,
	[m_maxY] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[m_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Map_BlockedSpaces]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Map_BlockedSpaces](
	[mb_id] [int] IDENTITY(1,1) NOT NULL,
	[m_id] [int] NOT NULL,
	[mb_startX] [int] NOT NULL,
	[mb_startY] [int] NOT NULL,
	[mb_EndX] [int] NOT NULL,
	[mb_EndY] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[mb_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Map_UserCount]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Map_UserCount](
	[MU_id] [int] IDENTITY(1,1) NOT NULL,
	[m_id] [int] NOT NULL,
	[MU_time] [datetime] NOT NULL,
	[MU_count] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MU_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Society]    Script Date: 2023/4/3 下午 06:24:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Society](
	[S_ID] [int] IDENTITY(1,1) NOT NULL,
	[SA_ID] [int] NULL,
	[S_TargetID] [int] NULL,
	[CreatedAt] [datetime] NOT NULL,
	[UpdatedAt] [datetime] NOT NULL,
	[Notes] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Debuglog]  WITH CHECK ADD  CONSTRAINT [FK__Debuglog__A_id__6477ECF3] FOREIGN KEY([A_id])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Debuglog] CHECK CONSTRAINT [FK__Debuglog__A_id__6477ECF3]
GO
ALTER TABLE [dbo].[LoginStaus]  WITH CHECK ADD FOREIGN KEY([A_id])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Map_BlockedSpaces]  WITH CHECK ADD  CONSTRAINT [FK_Map_BlockedSpaces_Map] FOREIGN KEY([m_id])
REFERENCES [dbo].[Map] ([m_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Map_BlockedSpaces] CHECK CONSTRAINT [FK_Map_BlockedSpaces_Map]
GO
ALTER TABLE [dbo].[Map_UserCount]  WITH CHECK ADD  CONSTRAINT [FK_Map_UserCount_Map] FOREIGN KEY([m_id])
REFERENCES [dbo].[Map] ([m_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Map_UserCount] CHECK CONSTRAINT [FK_Map_UserCount_Map]
GO
ALTER TABLE [dbo].[Society]  WITH CHECK ADD FOREIGN KEY([SA_ID])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [ChickenLife] SET  READ_WRITE 
GO
