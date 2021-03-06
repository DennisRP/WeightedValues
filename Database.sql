USE [weightedvalues_db]
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Education](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PrimaryKey_b0262a83-e826-4844-a9b6-d7fafc097fba] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationKeyword](
	[EducationID] [int] NOT NULL,
	[KeywordID] [int] NOT NULL,
	[Weight] [int] NOT NULL,
 CONSTRAINT [PrimaryKey_91f012c6-6c54-42ff-bbe5-d278f00ba918] PRIMARY KEY CLUSTERED 
(
	[EducationID] ASC,
	[KeywordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Keyword](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PrimaryKey_e505cc55-c3f5-4543-87c3-1ca3aff733ab] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO
INSERT [dbo].[Education] ([ID], [Name]) VALUES (0, N'Anlægsgartner')
INSERT [dbo].[Education] ([ID], [Name]) VALUES (1, N'Kontoruddannelsen')
INSERT [dbo].[Education] ([ID], [Name]) VALUES (2, N'Revisor')
INSERT [dbo].[Education] ([ID], [Name]) VALUES (3, N'Kommunikation')
INSERT [dbo].[Education] ([ID], [Name]) VALUES (4, N'Tandklinikassistent')
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (0, 0, 100)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (0, 1, 30)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (0, 2, 70)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (1, 1, 80)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (1, 3, 70)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (1, 4, 70)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (2, 1, 90)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (2, 2, 30)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (2, 3, 70)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (2, 5, 65)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (3, 2, 80)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (3, 3, 20)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (3, 4, 75)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (3, 5, 70)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (4, 4, 80)
INSERT [dbo].[EducationKeyword] ([EducationID], [KeywordID], [Weight]) VALUES (4, 6, 80)
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (0, N'Natur')
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (1, N'Organisation')
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (2, N'Være kreativ')
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (3, N'Folde papirsflyvere')
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (4, N'Kundekontakt')
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (5, N'Det gør ikke noget det er en lang uddannelse')
INSERT [dbo].[Keyword] ([ID], [Name]) VALUES (6, N'Anatomi er spændende!')
ALTER TABLE [dbo].[EducationKeyword] ADD  CONSTRAINT [ColumnDefault_a037f203-451d-4f0f-b1cf-7c0ffac5a24a]  DEFAULT ((0)) FOR [Weight]
GO
ALTER TABLE [dbo].[EducationKeyword]  WITH CHECK ADD  CONSTRAINT [FK_EducationKeyword_0] FOREIGN KEY([EducationID])
REFERENCES [dbo].[Education] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EducationKeyword] CHECK CONSTRAINT [FK_EducationKeyword_0]
GO
ALTER TABLE [dbo].[EducationKeyword]  WITH CHECK ADD  CONSTRAINT [FK_EducationKeyword_1] FOREIGN KEY([KeywordID])
REFERENCES [dbo].[Keyword] ([ID])
GO
ALTER TABLE [dbo].[EducationKeyword] CHECK CONSTRAINT [FK_EducationKeyword_1]
GO
