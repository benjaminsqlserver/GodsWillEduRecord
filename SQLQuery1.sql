USE [master]
GO
/****** Object:  Database [GodswillDB]    Script Date: 9/30/2021 10:12:32 AM ******/
CREATE DATABASE [GodswillDB]
 
GO

USE [GodswillDB]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[GenderID] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[GenderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NextOfKins]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NextOfKins](
	[NextOfKinID] [bigint] IDENTITY(1,1) NOT NULL,
	[BiodataID] [bigint] NOT NULL,
	[NameOfNextOfKin] [nvarchar](250) NOT NULL,
	[RelationshipID] [int] NOT NULL,
	[NextOfKinPhoneNo] [nvarchar](50) NOT NULL,
	[NextOfKinEmail] [nvarchar](50) NOT NULL,
	[NextOfKinContactAddress] [ntext] NOT NULL,
 CONSTRAINT [PK_NextOfKins] PRIMARY KEY CLUSTERED 
(
	[NextOfKinID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Qualifications]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Qualifications](
	[QualificationID] [int] IDENTITY(1,1) NOT NULL,
	[QualificationName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Qualifications] PRIMARY KEY CLUSTERED 
(
	[QualificationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Relationships]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Relationships](
	[RelationshipID] [int] NOT NULL,
	[RelationshipName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Relationships] PRIMARY KEY CLUSTERED 
(
	[RelationshipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SchoolCourses]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SchoolCourses](
	[CourseOfStudyID] [int] IDENTITY(1,1) NOT NULL,
	[CourseOfStudyName] [nvarchar](300) NOT NULL,
	[CourseFee] [decimal](18, 2) NULL,
	[DurationInMonths] [int] NOT NULL,
 CONSTRAINT [PK_SchoolCourses] PRIMARY KEY CLUSTERED 
(
	[CourseOfStudyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateID] [int] IDENTITY(1,1) NOT NULL,
	[StateName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[StateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentBiodata]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentBiodata](
	[BiodataID] [bigint] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[OtherNames] [nvarchar](101) NULL,
	[ContactAddress] [ntext] NOT NULL,
	[DateOfBirth] [datetime2](7) NOT NULL,
	[GenderID] [int] NOT NULL,
	[StateOfOriginID] [int] NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[EmailAddress] [nvarchar](50) NOT NULL,
	[FacebookID] [nvarchar](50) NULL,
	[Picture] [nvarchar](max) NULL,
 CONSTRAINT [PK_StudentBiodata] PRIMARY KEY CLUSTERED 
(
	[BiodataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentCoursePayments]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCoursePayments](
	[PaymentID] [bigint] IDENTITY(1,1) NOT NULL,
	[BiodataID] [bigint] NOT NULL,
	[CourseOfStudyID] [int] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[CourseFee] [decimal](18, 2) NOT NULL,
	[AmountPaid] [decimal](18, 2) NOT NULL,
	[Balance] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_StudentCoursePayments] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentCourseRegistrations]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCourseRegistrations](
	[CourseRegistrationID] [bigint] IDENTITY(1,1) NOT NULL,
	[BiodataID] [bigint] NOT NULL,
	[CourseOfStudyID] [int] NOT NULL,
	[StudySessionID] [int] NOT NULL,
	[IsPrivateStudent] [bit] NULL,
	[PrivateTrainingVenue] [ntext] NULL,
	[PrivateTrainingTime] [nvarchar](50) NULL,
	[Signature] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_StudentCourseRegistrations] PRIMARY KEY CLUSTERED 
(
	[CourseRegistrationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentEducationHistories]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentEducationHistories](
	[EducationRecordID] [bigint] IDENTITY(1,1) NOT NULL,
	[BiodataID] [bigint] NOT NULL,
	[NameOfInstitution] [nvarchar](350) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NULL,
	[QualificationObtainedID] [int] NOT NULL,
 CONSTRAINT [PK_StudentEducationHistories] PRIMARY KEY CLUSTERED 
(
	[EducationRecordID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudySessions]    Script Date: 9/30/2021 10:12:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudySessions](
	[StudySessionID] [int] IDENTITY(1,1) NOT NULL,
	[StudySessionName] [nvarchar](50) NOT NULL,
	[Time] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StudySessions] PRIMARY KEY CLUSTERED 
(
	[StudySessionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Genders]    Script Date: 9/30/2021 10:12:34 AM ******/
ALTER TABLE [dbo].[Genders] ADD  CONSTRAINT [IX_Genders] UNIQUE NONCLUSTERED 
(
	[GenderName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Qualifications]    Script Date: 9/30/2021 10:12:34 AM ******/
ALTER TABLE [dbo].[Qualifications] ADD  CONSTRAINT [IX_Qualifications] UNIQUE NONCLUSTERED 
(
	[QualificationName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Relationships]    Script Date: 9/30/2021 10:12:34 AM ******/
ALTER TABLE [dbo].[Relationships] ADD  CONSTRAINT [IX_Relationships] UNIQUE NONCLUSTERED 
(
	[RelationshipName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_SchoolCourses]    Script Date: 9/30/2021 10:12:34 AM ******/
ALTER TABLE [dbo].[SchoolCourses] ADD  CONSTRAINT [IX_SchoolCourses] UNIQUE NONCLUSTERED 
(
	[CourseOfStudyName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_States]    Script Date: 9/30/2021 10:12:34 AM ******/
ALTER TABLE [dbo].[States] ADD  CONSTRAINT [IX_States] UNIQUE NONCLUSTERED 
(
	[StateName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_StudySessions]    Script Date: 9/30/2021 10:12:34 AM ******/
ALTER TABLE [dbo].[StudySessions] ADD  CONSTRAINT [IX_StudySessions] UNIQUE NONCLUSTERED 
(
	[StudySessionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[NextOfKins]  WITH CHECK ADD  CONSTRAINT [FK_NextOfKins_Relationships] FOREIGN KEY([RelationshipID])
REFERENCES [dbo].[Relationships] ([RelationshipID])
GO
ALTER TABLE [dbo].[NextOfKins] CHECK CONSTRAINT [FK_NextOfKins_Relationships]
GO
ALTER TABLE [dbo].[NextOfKins]  WITH CHECK ADD  CONSTRAINT [FK_NextOfKins_StudentBiodata] FOREIGN KEY([BiodataID])
REFERENCES [dbo].[StudentBiodata] ([BiodataID])
GO
ALTER TABLE [dbo].[NextOfKins] CHECK CONSTRAINT [FK_NextOfKins_StudentBiodata]
GO
ALTER TABLE [dbo].[StudentBiodata]  WITH CHECK ADD  CONSTRAINT [FK_StudentBiodata_Genders] FOREIGN KEY([GenderID])
REFERENCES [dbo].[Genders] ([GenderID])
GO
ALTER TABLE [dbo].[StudentBiodata] CHECK CONSTRAINT [FK_StudentBiodata_Genders]
GO
ALTER TABLE [dbo].[StudentBiodata]  WITH CHECK ADD  CONSTRAINT [FK_StudentBiodata_States] FOREIGN KEY([StateOfOriginID])
REFERENCES [dbo].[States] ([StateID])
GO
ALTER TABLE [dbo].[StudentBiodata] CHECK CONSTRAINT [FK_StudentBiodata_States]
GO
ALTER TABLE [dbo].[StudentCoursePayments]  WITH CHECK ADD  CONSTRAINT [FK_StudentCoursePayments_SchoolCourses] FOREIGN KEY([CourseOfStudyID])
REFERENCES [dbo].[SchoolCourses] ([CourseOfStudyID])
GO
ALTER TABLE [dbo].[StudentCoursePayments] CHECK CONSTRAINT [FK_StudentCoursePayments_SchoolCourses]
GO
ALTER TABLE [dbo].[StudentCoursePayments]  WITH CHECK ADD  CONSTRAINT [FK_StudentCoursePayments_StudentBiodata] FOREIGN KEY([BiodataID])
REFERENCES [dbo].[StudentBiodata] ([BiodataID])
GO
ALTER TABLE [dbo].[StudentCoursePayments] CHECK CONSTRAINT [FK_StudentCoursePayments_StudentBiodata]
GO
ALTER TABLE [dbo].[StudentCourseRegistrations]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourseRegistrations_SchoolCourses] FOREIGN KEY([CourseOfStudyID])
REFERENCES [dbo].[SchoolCourses] ([CourseOfStudyID])
GO
ALTER TABLE [dbo].[StudentCourseRegistrations] CHECK CONSTRAINT [FK_StudentCourseRegistrations_SchoolCourses]
GO
ALTER TABLE [dbo].[StudentCourseRegistrations]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourseRegistrations_StudentBiodata] FOREIGN KEY([BiodataID])
REFERENCES [dbo].[StudentBiodata] ([BiodataID])
GO
ALTER TABLE [dbo].[StudentCourseRegistrations] CHECK CONSTRAINT [FK_StudentCourseRegistrations_StudentBiodata]
GO
ALTER TABLE [dbo].[StudentCourseRegistrations]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourseRegistrations_StudySessions] FOREIGN KEY([StudySessionID])
REFERENCES [dbo].[StudySessions] ([StudySessionID])
GO
ALTER TABLE [dbo].[StudentCourseRegistrations] CHECK CONSTRAINT [FK_StudentCourseRegistrations_StudySessions]
GO
ALTER TABLE [dbo].[StudentEducationHistories]  WITH CHECK ADD  CONSTRAINT [FK_StudentEducationHistories_Qualifications] FOREIGN KEY([QualificationObtainedID])
REFERENCES [dbo].[Qualifications] ([QualificationID])
GO
ALTER TABLE [dbo].[StudentEducationHistories] CHECK CONSTRAINT [FK_StudentEducationHistories_Qualifications]
GO
ALTER TABLE [dbo].[StudentEducationHistories]  WITH CHECK ADD  CONSTRAINT [FK_StudentEducationHistories_StudentBiodata] FOREIGN KEY([BiodataID])
REFERENCES [dbo].[StudentBiodata] ([BiodataID])
GO
ALTER TABLE [dbo].[StudentEducationHistories] CHECK CONSTRAINT [FK_StudentEducationHistories_StudentBiodata]
GO
USE [master]
GO
ALTER DATABASE [GodswillDB] SET  READ_WRITE 
GO
