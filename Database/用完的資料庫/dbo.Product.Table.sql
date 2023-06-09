USE [iSpanFinal]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 2023/4/5 上午 01:27:54 ******/
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
