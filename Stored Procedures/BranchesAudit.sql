USE [StudentManager]
GO

/****** Object:  Table [dbo].[Branches]    Script Date: 20/05/2019 9:11:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BranchesAudit](
	[BranchAuditId] [int] IDENTITY(1,1) NOT NULL,
	[BranchId] [int] NOT NULL,
	[BranchName] [nvarchar](150) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Telephone] [nvarchar](50) NOT NULL,
	[Website] [nvarchar](50) NOT NULL,
	[AddressLine] [nvarchar](50) NOT NULL,
	[CityId] [int] NOT NULL,
	[DistrictId] [int] NOT NULL,
	[PostralCode] [int] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[BranchImage] [image] NULL,
 CONSTRAINT [PK_BranchAudit] PRIMARY KEY CLUSTERED 
(
	[BranchAuditId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


