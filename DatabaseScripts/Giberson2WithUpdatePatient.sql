USE [master]
GO
/****** Object:  Database [Giberson2]    Script Date: 10/27/2013 7:40:40 PM ******/
CREATE DATABASE [Giberson2] ON  PRIMARY 
( NAME = N'Giberson2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Giberson2.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Giberson2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Giberson2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Giberson2] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Giberson2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Giberson2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Giberson2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Giberson2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Giberson2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Giberson2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Giberson2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Giberson2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Giberson2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Giberson2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Giberson2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Giberson2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Giberson2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Giberson2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Giberson2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Giberson2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Giberson2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Giberson2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Giberson2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Giberson2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Giberson2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Giberson2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Giberson2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Giberson2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Giberson2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Giberson2] SET  MULTI_USER 
GO
ALTER DATABASE [Giberson2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Giberson2] SET DB_CHAINING OFF 
GO
USE [Giberson2]
GO
/****** Object:  StoredProcedure [dbo].[auspGetAllery]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[auspGetAllery]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Allergy WHERE patientId = @patientId;

END

GO
/****** Object:  StoredProcedure [dbo].[auspGetInsurance]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[auspGetInsurance]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM Insurance WHERE patientId = @patientId;

END

GO
/****** Object:  StoredProcedure [dbo].[auspGetPatient]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[auspGetPatient]
@patientId int
AS
SET NOCOUNT ON;
SELECT *
FROM Patient
WHERE patientId = @patientId;

GO
/****** Object:  StoredProcedure [dbo].[auspGetPatientContact]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[auspGetPatientContact]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM PatientContact WHERE patientId = @patientId;

END

GO
/****** Object:  StoredProcedure [dbo].[auspGetReferenceDoctor]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[auspGetReferenceDoctor]
@patientId int
AS
BEGIN
	SET NOCOUNT ON;
	SELECT * FROM ReferenceDoctor WHERE patientId = @patientId;

END

GO
/****** Object:  StoredProcedure [dbo].[auspUpdateAllergy]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[auspUpdateAllergy] 
	@allergyId int,
	@patientId int,
	@name varchar(50),
	@category varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Allergy SET patientId = @patientId
					  ,name = @name
					  ,category = @category
 WHERE allergyId = @allergyId
END

GO
/****** Object:  StoredProcedure [dbo].[auspUpdateInsurance]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[auspUpdateInsurance]
	@insuranceId int,
	@patientId int,
	@type nchar(10),
	@insNumber nchar(10),
	@expDate nchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Insurance SET patientId = @patientId
					  ,type = @type
					  ,insNumber = @insNumber
					  ,expDate = @expDate
 WHERE insuranceId = @insuranceId
END

GO
/****** Object:  StoredProcedure [dbo].[auspUpdatePatient]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[auspUpdatePatient]
	@patientId int,
	@firstName nchar(10),
	@lastName nchar(10),
	@dob nchar(10),
	@gender nchar(10)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Patient SET firstName = @firstName
					  ,lastName = @lastName
					  ,dob = @dob
					  ,gender = @gender
 WHERE patientId = @patientId
END

GO
/****** Object:  StoredProcedure [dbo].[auspUpdatePatientContact]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[auspUpdatePatientContact]
	@patientId int,
	@phoneNo varchar(50),
	@phoneType varchar(50),
	@email varchar(50),
	@emailType varchar(50),
	@address varchar(100),
	@addressType varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PatientContact SET phoneNo = @phoneNo
					  ,phoneType = @phoneType
					  ,email = @email
					  ,emailType = @emailType
					  ,address = @address
					  ,addressType = @addressType
 WHERE patientId = @patientId
END

GO
/****** Object:  StoredProcedure [dbo].[auspUpdateReferenceDoctor]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[auspUpdateReferenceDoctor]
	@referenceId int,
	@patientId int,
	@referenceDoctor varchar(50),
	@doctorBillingCode varchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE ReferenceDoctor SET patientId = @patientId
					  ,referenceDoctor = @referenceDoctor
					  ,doctorBillingCode = @doctorBillingCode
 WHERE referenceId = @referenceId
END

GO
/****** Object:  Table [dbo].[Allergy]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Allergy](
	[allergyId] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[category] [varchar](50) NULL,
 CONSTRAINT [PK_Allergy] PRIMARY KEY CLUSTERED 
(
	[allergyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Insurance]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insurance](
	[insuranceId] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[type] [nchar](10) NOT NULL,
	[insNumber] [nchar](10) NOT NULL,
	[expDate] [nchar](10) NOT NULL,
	[timestamp] [datetime] NOT NULL,
 CONSTRAINT [PK_Insurance] PRIMARY KEY CLUSTERED 
(
	[insuranceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patientId] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nchar](10) NOT NULL,
	[lastName] [nchar](10) NOT NULL,
	[dob] [nchar](10) NULL,
	[gender] [nchar](10) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[patientContact]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[patientContact](
	[contactId] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[phoneNo] [varchar](50) NOT NULL,
	[phoneType] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[emailType] [varchar](50) NOT NULL,
	[address] [varchar](100) NOT NULL,
	[addressType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_patientContact] PRIMARY KEY CLUSTERED 
(
	[contactId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReferenceDoctor]    Script Date: 10/27/2013 7:40:40 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReferenceDoctor](
	[referenceId] [int] IDENTITY(1,1) NOT NULL,
	[patientId] [int] NOT NULL,
	[referenceDoctor] [varchar](50) NULL,
	[doctorBillingCode] [varchar](50) NULL,
	[timeStamp] [datetime] NULL,
 CONSTRAINT [PK_ReferenceDoctor] PRIMARY KEY CLUSTERED 
(
	[referenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [IX_Insurance]    Script Date: 10/27/2013 7:40:40 PM ******/
CREATE NONCLUSTERED INDEX [IX_Insurance] ON [dbo].[Insurance]
(
	[insuranceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Allergy]  WITH CHECK ADD  CONSTRAINT [FK_Allergy_Patient] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patient] ([patientId])
GO
ALTER TABLE [dbo].[Allergy] CHECK CONSTRAINT [FK_Allergy_Patient]
GO
ALTER TABLE [dbo].[Insurance]  WITH CHECK ADD  CONSTRAINT [FK_Insurance_Insurance] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patient] ([patientId])
GO
ALTER TABLE [dbo].[Insurance] CHECK CONSTRAINT [FK_Insurance_Insurance]
GO
ALTER TABLE [dbo].[patientContact]  WITH CHECK ADD  CONSTRAINT [FK_patientContact_Patient] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patient] ([patientId])
GO
ALTER TABLE [dbo].[patientContact] CHECK CONSTRAINT [FK_patientContact_Patient]
GO
ALTER TABLE [dbo].[ReferenceDoctor]  WITH CHECK ADD  CONSTRAINT [FK_ReferenceDoctor_Patient] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patient] ([patientId])
GO
ALTER TABLE [dbo].[ReferenceDoctor] CHECK CONSTRAINT [FK_ReferenceDoctor_Patient]
GO
USE [master]
GO
ALTER DATABASE [Giberson2] SET  READ_WRITE 
GO
