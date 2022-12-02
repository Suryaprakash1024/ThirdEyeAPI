USE [ThirdEye]
GO
/****** Object:  Table [dbo].[ObjectMaster]    Script Date: 12/2/2022 7:41:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectMaster](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Shape] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PositionMaster]    Script Date: 12/2/2022 7:41:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PositionMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PositionId] [varchar](120) NULL,
	[x] [int] NULL,
	[y] [int] NULL,
	[shape] [varchar](120) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ObjectMaster] ON 
GO
INSERT [dbo].[ObjectMaster] ([ID], [Shape]) VALUES (1, N'Circle')
GO
INSERT [dbo].[ObjectMaster] ([ID], [Shape]) VALUES (2, N'Rectangle')
GO
INSERT [dbo].[ObjectMaster] ([ID], [Shape]) VALUES (3, N'Square')
GO
INSERT [dbo].[ObjectMaster] ([ID], [Shape]) VALUES (4, N'Ellipse')
GO
SET IDENTITY_INSERT [dbo].[ObjectMaster] OFF
GO
