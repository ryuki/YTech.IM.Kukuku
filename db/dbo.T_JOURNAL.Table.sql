USE [DB_IM_KUKUKU]
GO
/****** Object:  Table [dbo].[T_JOURNAL]    Script Date: 10/19/2013 02:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_JOURNAL](
	[JOURNAL_ID] [nvarchar](50) NOT NULL,
	[COST_CENTER_ID] [nvarchar](50) NULL,
	[JOURNAL_TYPE] [nvarchar](50) NULL,
	[JOURNAL_VOUCHER_NO] [nvarchar](50) NULL,
	[JOURNAL_PIC] [nvarchar](50) NULL,
	[JOURNAL_DATE] [datetime] NULL,
	[JOURNAL_EVIDENCE_NO] [nvarchar](50) NULL,
	[JOURNAL_AMMOUNT] [numeric](18, 5) NULL,
	[JOURNAL_STATUS] [nvarchar](50) NULL,
	[JOURNAL_DESC] [nvarchar](max) NULL,
	[DATA_STATUS] [nvarchar](50) NULL,
	[CREATED_BY] [nvarchar](50) NULL,
	[CREATED_DATE] [datetime] NULL,
	[MODIFIED_BY] [nvarchar](50) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[ROW_VERSION] [timestamp] NULL,
 CONSTRAINT [PK_T_JOURNAL] PRIMARY KEY CLUSTERED 
(
	[JOURNAL_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[T_JOURNAL]  WITH CHECK ADD  CONSTRAINT [FK_T_JOURNAL_M_COST_CENTER] FOREIGN KEY([COST_CENTER_ID])
REFERENCES [dbo].[M_COST_CENTER] ([COST_CENTER_ID])
GO
ALTER TABLE [dbo].[T_JOURNAL] CHECK CONSTRAINT [FK_T_JOURNAL_M_COST_CENTER]
GO
