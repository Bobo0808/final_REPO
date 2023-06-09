USE [iSpanFinal]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 2023/4/5 上午 01:27:54 ******/
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
