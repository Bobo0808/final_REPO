USE [report]
GO
/****** Object:  Table [dbo].[reports]    Script Date: 2023/3/28 下午 11:00:01 ******/
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
ALTER TABLE [dbo].[reports] ADD  CONSTRAINT [DF_reports_status]  DEFAULT ((0)) FOR [status]
GO
