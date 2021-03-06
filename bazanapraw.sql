CREATE DATABASE BazaNapraw;
GO

USE [BazaNapraw]

USE [BazaNapraw] 
GO 
EXEC dbo.sp_changedbowner @loginame = N'sa', @map = false 
GO 
sp_configure 'show advanced options', 1; 
GO 
RECONFIGURE; 
GO 
sp_configure 'clr enabled', 1; 
GO 
RECONFIGURE; 
GO

/****** Object:  Table [dbo].[ActivitiesTypesDictionary]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ActivitiesTypesDictionary](
	[Type] [nvarchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ActivitiesTypesDictionary_1] PRIMARY KEY CLUSTERED 
(
	[Type] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Activity]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[Descr] [nvarchar](254) NOT NULL,
	[Status] [nvarchar](3) NOT NULL,
	[Result] [nvarchar](254) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ReqId] [int] NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
	[WorkerId] [int] NULL,
 CONSTRAINT [PK_Activity_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Client]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](10) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Client_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Login]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UName] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](254) NOT NULL,
	[WorkerId] [int] NOT NULL,
	[Expiration] [date] NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[WorkerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Object]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Object](
	[Name] [nvarchar](50) NOT NULL,
	[ClientId] [int] NOT NULL,
	[Type] [nvarchar](10) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Object_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ObjectType]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ObjectType](
	[Code] [nvarchar](10) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ObjectType_1] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Request]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Request](
	[Descr] [nvarchar](254) NOT NULL,
	[Status] [nvarchar](3) NOT NULL,
	[Result] [nvarchar](254) NULL,
	[ObjId] [int] NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WorkerId] [int] NULL,
 CONSTRAINT [PK_Request_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Worker]    Script Date: 06.06.2017 17:27:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Worker] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_ActivitiesTypesDictionary1] FOREIGN KEY([Type])
REFERENCES [dbo].[ActivitiesTypesDictionary] ([Type])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_ActivitiesTypesDictionary1]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Request1] FOREIGN KEY([ReqId])
REFERENCES [dbo].[Request] ([Id])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_Request1]
GO
ALTER TABLE [dbo].[Activity]  WITH CHECK ADD  CONSTRAINT [FK_Activity_Worker] FOREIGN KEY([WorkerId])
REFERENCES [dbo].[Worker] ([Id])
GO
ALTER TABLE [dbo].[Activity] CHECK CONSTRAINT [FK_Activity_Worker]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Worker] FOREIGN KEY([WorkerId])
REFERENCES [dbo].[Worker] ([Id])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Worker]
GO
ALTER TABLE [dbo].[Object]  WITH CHECK ADD  CONSTRAINT [FK_Object_Client] FOREIGN KEY([ClientId])
REFERENCES [dbo].[Client] ([Id])
GO
ALTER TABLE [dbo].[Object] CHECK CONSTRAINT [FK_Object_Client]
GO
ALTER TABLE [dbo].[Object]  WITH CHECK ADD  CONSTRAINT [FK_Object_ObjectType] FOREIGN KEY([Type])
REFERENCES [dbo].[ObjectType] ([Code])
GO
ALTER TABLE [dbo].[Object] CHECK CONSTRAINT [FK_Object_ObjectType]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Object] FOREIGN KEY([ObjId])
REFERENCES [dbo].[Object] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Object]
GO
ALTER TABLE [dbo].[Request]  WITH CHECK ADD  CONSTRAINT [FK_Request_Worker] FOREIGN KEY([WorkerId])
REFERENCES [dbo].[Worker] ([Id])
GO
ALTER TABLE [dbo].[Request] CHECK CONSTRAINT [FK_Request_Worker]
GO
