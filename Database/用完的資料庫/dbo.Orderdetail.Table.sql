USE [iSpanFinal]
GO
/****** Object:  Table [dbo].[Orderdetail]    Script Date: 2023/4/5 上午 01:27:54 ******/
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
ALTER TABLE [dbo].[Orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_Orderdetail_Order] FOREIGN KEY([od_ID])
REFERENCES [dbo].[Order] ([o_ID])
GO
ALTER TABLE [dbo].[Orderdetail] CHECK CONSTRAINT [FK_Orderdetail_Order]
GO
ALTER TABLE [dbo].[Orderdetail]  WITH CHECK ADD  CONSTRAINT [FK_Orderdetail_Product] FOREIGN KEY([od_p_ID])
REFERENCES [dbo].[Product] ([p_ID])
GO
ALTER TABLE [dbo].[Orderdetail] CHECK CONSTRAINT [FK_Orderdetail_Product]
GO

drop table Orderdetail