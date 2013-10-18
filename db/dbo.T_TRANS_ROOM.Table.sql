USE [DB_IM_KUKUKU]
GO
/****** Object:  Table [dbo].[T_TRANS_ROOM]    Script Date: 10/19/2013 02:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_TRANS_ROOM](
	[TRANS_ID] [nvarchar](50) NOT NULL,
	[ROOM_ID] [nvarchar](50) NULL,
	[ROOM_BOOK_DATE] [datetime] NULL,
	[ROOM_IN_DATE] [datetime] NULL,
	[ROOM_OUT_DATE] [datetime] NULL,
	[ROOM_STATUS] [nvarchar](50) NULL,
	[ROOM_CASH_PAID] [decimal](18, 5) NULL,
	[ROOM_CREDIT_PAID] [decimal](18, 5) NULL,
	[ROOM_VOUCHER_PAID] [decimal](18, 5) NULL,
	[ROOM_COMMISSION_PRODUCT] [decimal](18, 5) NULL,
	[ROOM_COMMISSION_SERVICE] [decimal](18, 5) NULL,
	[ROOM_DESC] [nvarchar](max) NULL,
	[DATA_STATUS] [nvarchar](50) NULL,
	[CREATED_BY] [nvarchar](50) NULL,
	[CREATED_DATE] [datetime] NULL,
	[MODIFIED_BY] [nvarchar](50) NULL,
	[MODIFIED_DATE] [datetime] NULL,
	[ROW_VERSION] [timestamp] NULL,
	[PROMO_ID] [nvarchar](50) NULL,
	[PROMO_VALUE] [decimal](18, 5) NULL,
 CONSTRAINT [PK_T_TRANS_ROOM_REF] PRIMARY KEY CLUSTERED 
(
	[TRANS_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[T_TRANS_ROOM]  WITH CHECK ADD  CONSTRAINT [FK_T_TRANS_ROOM_M_PROMO] FOREIGN KEY([PROMO_ID])
REFERENCES [dbo].[M_PROMO] ([PROMO_ID])
GO
ALTER TABLE [dbo].[T_TRANS_ROOM] CHECK CONSTRAINT [FK_T_TRANS_ROOM_M_PROMO]
GO
ALTER TABLE [dbo].[T_TRANS_ROOM]  WITH CHECK ADD  CONSTRAINT [FK_T_TRANS_ROOM_M_ROOM] FOREIGN KEY([ROOM_ID])
REFERENCES [dbo].[M_ROOM] ([ROOM_ID])
GO
ALTER TABLE [dbo].[T_TRANS_ROOM] CHECK CONSTRAINT [FK_T_TRANS_ROOM_M_ROOM]
GO
ALTER TABLE [dbo].[T_TRANS_ROOM]  WITH CHECK ADD  CONSTRAINT [FK_T_TRANS_ROOM_T_TRANS] FOREIGN KEY([TRANS_ID])
REFERENCES [dbo].[T_TRANS] ([TRANS_ID])
GO
ALTER TABLE [dbo].[T_TRANS_ROOM] CHECK CONSTRAINT [FK_T_TRANS_ROOM_T_TRANS]
GO
