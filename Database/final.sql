USE [master]
GO
/****** Object:  Database [final]    Script Date: 2023/4/9 上午 11:31:35 ******/
CREATE DATABASE [final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER02\MSSQL\DATA\final.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER02\MSSQL\DATA\final_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [final] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [final] SET ARITHABORT OFF 
GO
ALTER DATABASE [final] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [final] SET  ENABLE_BROKER 
GO
ALTER DATABASE [final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [final] SET RECOVERY FULL 
GO
ALTER DATABASE [final] SET  MULTI_USER 
GO
ALTER DATABASE [final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [final] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [final] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [final] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'final', N'ON'
GO
ALTER DATABASE [final] SET QUERY_STORE = OFF
GO
USE [final]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
/****** Object:  Table [dbo].[Ads]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ads](
	[AdID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
	[ItemID] [int] NULL,
	[LocationID] [int] NULL,
	[ImageURL] [nvarchar](max) NULL,
	[TargetURL] [nvarchar](max) NULL,
	[Clicks] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advertising_Items]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertising_Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PartnerID] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[Start_Time] [datetime] NULL,
	[End_Time] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Advertising_Locations]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Advertising_Locations](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Characters]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Characters](
	[character_ID] [int] IDENTITY(1,1) NOT NULL,
	[member_ID] [int] NULL,
	[character_Name] [nvarchar](8) NULL,
	[character_gender] [bit] NULL,
	[character_created_at] [date] NULL,
	[character_appearance] [int] NULL,
	[character_coin] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[character_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Debuglog]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
/****** Object:  Table [dbo].[Inventory]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Inventory_ID] [int] IDENTITY(1,1) NOT NULL,
	[character_ID] [int] NULL,
	[ItemID] [int] NULL,
	[quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Inventory_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Item_ID] [int] IDENTITY(1,1) NOT NULL,
	[Item_Name] [nvarchar](20) NULL,
	[Item_Type] [nvarchar](10) NULL,
	[Item_Image] [nvarchar](max) NULL,
	[Item_Price] [int] NULL,
	[Item_Date] [date] NULL,
	[Item_Description] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginStaus]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
/****** Object:  Table [dbo].[Map]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
/****** Object:  Table [dbo].[Map_BlockedSpaces]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
/****** Object:  Table [dbo].[Map_UserCount]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
/****** Object:  Table [dbo].[Order]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[o_ID] [int] IDENTITY(1,1) NOT NULL,
	[o_a_ID] [int] NOT NULL,
	[o_Date] [datetime] NULL,
	[o_TotalPrice] [int] NULL,
	[o_Cancel] [bit] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[o_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orderdetail]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orderdetail](
	[od_ID] [int] IDENTITY(1,1) NOT NULL,
	[od_o_ID] [int] NOT NULL,
	[od_p_ID] [int] NOT NULL,
	[od_UnitPrice] [int] NULL,
	[od_Sum] [int] NULL,
	[od_Quantity] [int] NULL,
 CONSTRAINT [PK_Orderdetail] PRIMARY KEY CLUSTERED 
(
	[od_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Partners]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Partners](
	[Partners_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Contact] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[Partners_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[p_ID] [int] IDENTITY(1,1) NOT NULL,
	[p_Name] [nvarchar](20) NULL,
	[p_Type] [nvarchar](10) NULL,
	[p_Price] [int] NULL,
	[p_Image] [nvarchar](50) NULL,
	[p_Describe] [nvarchar](200) NULL,
	[p_Instock] [int] NULL,
	[p_Date] [datetime] NULL,
	[p_Discount] [nvarchar](50) NULL,
	[p_Discontinuted] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[p_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reports]    Script Date: 2023/4/9 上午 11:31:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reports](
	[reportNo] [int] IDENTITY(1,1) NOT NULL,
	[ID] [int] NOT NULL,
	[reportedID] [int] NOT NULL,
	[reportTime] [datetime] NOT NULL,
	[reportType] [nvarchar](20) NOT NULL,
	[reportReason] [nvarchar](200) NOT NULL,
	[status] [int] NULL,
	[reply] [nvarchar](500) NULL,
 CONSTRAINT [PK_reports] PRIMARY KEY CLUSTERED 
(
	[reportNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Society]    Script Date: 2023/4/9 上午 11:31:35 ******/
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
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Characte__8F44E5D8324045F0]    Script Date: 2023/4/9 上午 11:31:36 ******/
ALTER TABLE [dbo].[Characters] ADD UNIQUE NONCLUSTERED 
(
	[character_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Characte__8F44E5D8D312131E]    Script Date: 2023/4/9 上午 11:31:36 ******/
ALTER TABLE [dbo].[Characters] ADD UNIQUE NONCLUSTERED 
(
	[character_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[reports] ADD  CONSTRAINT [DF_reports_status]  DEFAULT ((0)) FOR [status]
GO
ALTER TABLE [dbo].[Ads]  WITH CHECK ADD  CONSTRAINT [FK__Ads__ItemID__5629CD9C] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Advertising_Items] ([ItemID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ads] CHECK CONSTRAINT [FK__Ads__ItemID__5629CD9C]
GO
ALTER TABLE [dbo].[Ads]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[Advertising_Items] ([ItemID])
GO
ALTER TABLE [dbo].[Ads]  WITH CHECK ADD  CONSTRAINT [FK_Ads_Advertising_Locations] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Advertising_Locations] ([LocationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Ads] CHECK CONSTRAINT [FK_Ads_Advertising_Locations]
GO
ALTER TABLE [dbo].[Advertising_Items]  WITH CHECK ADD  CONSTRAINT [FK__Advertisi__Partn__5812160E] FOREIGN KEY([PartnerID])
REFERENCES [dbo].[Partners] ([Partners_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Advertising_Items] CHECK CONSTRAINT [FK__Advertisi__Partn__5812160E]
GO
ALTER TABLE [dbo].[Advertising_Items]  WITH CHECK ADD FOREIGN KEY([PartnerID])
REFERENCES [dbo].[Partners] ([Partners_ID])
GO
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD FOREIGN KEY([character_appearance])
REFERENCES [dbo].[Inventory] ([Inventory_ID])
GO
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD FOREIGN KEY([character_appearance])
REFERENCES [dbo].[Inventory] ([Inventory_ID])
GO
ALTER TABLE [dbo].[Characters]  WITH CHECK ADD  CONSTRAINT [FK_Characters_Account] FOREIGN KEY([member_ID])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Characters] CHECK CONSTRAINT [FK_Characters_Account]
GO
ALTER TABLE [dbo].[Debuglog]  WITH CHECK ADD  CONSTRAINT [FK__Debuglog__A_id__6477ECF3] FOREIGN KEY([A_id])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Debuglog] CHECK CONSTRAINT [FK__Debuglog__A_id__6477ECF3]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([Item_ID])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([Item_ID])
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Characters] FOREIGN KEY([character_ID])
REFERENCES [dbo].[Characters] ([character_ID])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_Characters]
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
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Account] FOREIGN KEY([o_a_ID])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Account]
GO
ALTER TABLE [dbo].[Orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_Orderdetail_Order] FOREIGN KEY([od_o_ID])
REFERENCES [dbo].[Order] ([o_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orderdetail] CHECK CONSTRAINT [FK_Orderdetail_Order]
GO
ALTER TABLE [dbo].[Orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_Orderdetail_Product] FOREIGN KEY([od_p_ID])
REFERENCES [dbo].[Product] ([p_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orderdetail] CHECK CONSTRAINT [FK_Orderdetail_Product]
GO
ALTER TABLE [dbo].[reports]  WITH CHECK ADD  CONSTRAINT [FK_reports_Account] FOREIGN KEY([ID])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[reports] CHECK CONSTRAINT [FK_reports_Account]
GO
ALTER TABLE [dbo].[reports]  WITH CHECK ADD  CONSTRAINT [FK_reports_Account1] FOREIGN KEY([reportedID])
REFERENCES [dbo].[Account] ([A_ID])
GO
ALTER TABLE [dbo].[reports] CHECK CONSTRAINT [FK_reports_Account1]
GO
ALTER TABLE [dbo].[Society]  WITH CHECK ADD FOREIGN KEY([SA_ID])
REFERENCES [dbo].[Account] ([A_ID])
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [final] SET  READ_WRITE 
GO
