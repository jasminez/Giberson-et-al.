USE [master]
GO
/****** Object:  Database [Giberson]    Script Date: 2013-10-14 2:36:55 PM ******/
CREATE DATABASE [Giberson]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Giberson', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Giberson.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Giberson_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Giberson_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Giberson] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Giberson].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Giberson] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Giberson] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Giberson] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Giberson] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Giberson] SET ARITHABORT OFF 
GO
ALTER DATABASE [Giberson] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Giberson] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Giberson] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Giberson] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Giberson] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Giberson] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Giberson] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Giberson] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Giberson] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Giberson] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Giberson] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Giberson] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Giberson] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Giberson] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Giberson] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Giberson] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Giberson] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Giberson] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Giberson] SET RECOVERY FULL 
GO
ALTER DATABASE [Giberson] SET  MULTI_USER 
GO
ALTER DATABASE [Giberson] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Giberson] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Giberson] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Giberson] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Giberson', N'ON'
GO
USE [Giberson]
GO
/****** Object:  Table [dbo].[Allergy]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Allergy](
	[allergyID] [int] NOT NULL,
	[name] [varchar](250) NOT NULL,
	[category] [varchar](50) NULL,
 CONSTRAINT [PK_Allergy] PRIMARY KEY CLUSTERED 
(
	[allergyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Appointment](
	[appointmentID] [int] IDENTITY(1,1) NOT NULL,
	[scheduleID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[patientID] [int] NOT NULL,
	[calender] [varchar](50) NULL,
	[timeZone] [varchar](10) NOT NULL,
	[dateTimeStart] [datetime] NOT NULL,
	[dateTimeEnd] [datetime] NULL,
	[duration] [time](7) NOT NULL,
	[completed] [datetime] NULL,
	[status] [varchar](50) NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[appointmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[diagnosisID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Diagnosis] PRIMARY KEY CLUSTERED 
(
	[diagnosisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Doctor](
	[doctorID] [int] NOT NULL,
	[billingCode] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[employeeID] [int] NOT NULL,
	[hireDate] [date] NOT NULL,
	[userName] [varchar](50) NOT NULL,
	[password] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EMR]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMR](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[clinicalImpression] [text] NULL,
 CONSTRAINT [PK_EMR] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRDiagnosis]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRDiagnosis](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[diagnosisID] [int] NOT NULL,
 CONSTRAINT [PK_EMRDiagnosis] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[diagnosisID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRLaboratory]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRLaboratory](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[laboratoryID] [int] NOT NULL,
 CONSTRAINT [PK_EMRLaboratory] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[laboratoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRMedication]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRMedication](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[medicationID] [int] NOT NULL,
 CONSTRAINT [PK_EMRMedication] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[medicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EMRRadiology]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMRRadiology](
	[patientID] [int] NOT NULL,
	[doctorID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[radiologyID] [int] NOT NULL,
 CONSTRAINT [PK_EMRRadiology] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[doctorID] ASC,
	[timestamp] ASC,
	[radiologyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Laboratory]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Laboratory](
	[laboratoryID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Laboratory] PRIMARY KEY CLUSTERED 
(
	[laboratoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Manager]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manager](
	[managerID] [int] NOT NULL,
 CONSTRAINT [PK_Manager] PRIMARY KEY CLUSTERED 
(
	[managerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medication]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Medication](
	[medicationID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Medication] PRIMARY KEY CLUSTERED 
(
	[medicationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[patientID] [int] NOT NULL,
	[referialDoctorID] [int] NULL,
	[registratonDate] [date] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PatientAllergy]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientAllergy](
	[patientID] [int] NOT NULL,
	[allergyID] [int] NOT NULL,
 CONSTRAINT [PK_PatientAllergy] PRIMARY KEY CLUSTERED 
(
	[patientID] ASC,
	[allergyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PatientInsurance]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientInsurance](
	[timestamp] [timestamp] NOT NULL,
	[patientID] [int] NOT NULL,
	[type] [varchar](50) NOT NULL,
	[accountNumber] [varchar](250) NOT NULL,
	[expiryDate] [date] NOT NULL,
 CONSTRAINT [PK_PatientInsurance] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[patientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Person]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Person](
	[personID] [int] IDENTITY(1,1) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[givenMiddleName] [varchar](150) NOT NULL,
	[dateOfBirth] [date] NOT NULL,
	[gender] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonAddress]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonAddress](
	[personID] [int] NOT NULL,
	[timestamp] [timestamp] NOT NULL,
	[type] [varchar](50) NULL,
	[deliveryAddress] [varchar](200) NOT NULL,
	[subdivision] [varchar](100) NOT NULL,
	[division] [varchar](50) NOT NULL,
	[postalCode] [varchar](20) NOT NULL,
	[country] [varbinary](50) NULL,
 CONSTRAINT [PK_PersonAddress] PRIMARY KEY CLUSTERED 
(
	[personID] ASC,
	[timestamp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonEmail]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonEmail](
	[timestamp] [timestamp] NOT NULL,
	[personID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[emailAddress] [varchar](255) NOT NULL,
 CONSTRAINT [PK_PersonEmail] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PersonPhone]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonPhone](
	[timestamp] [timestamp] NOT NULL,
	[personID] [int] NOT NULL,
	[type] [varchar](50) NULL,
	[phoneNumber] [varchar](50) NOT NULL,
 CONSTRAINT [PK_PersonPhone] PRIMARY KEY CLUSTERED 
(
	[timestamp] ASC,
	[personID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Radiology]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Radiology](
	[radiologyID] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](250) NOT NULL,
	[description] [text] NULL,
 CONSTRAINT [PK_Radiology] PRIMARY KEY CLUSTERED 
(
	[radiologyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Schedule]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Schedule](
	[scheduleID] [int] IDENTITY(1,1) NOT NULL,
	[doctorID] [int] NOT NULL,
	[calender] [varchar](50) NULL,
	[timeZone] [varchar](10) NOT NULL,
	[dateTimeStart] [datetime] NOT NULL,
	[dateTimeEnd] [datetime] NULL,
	[duration] [time](7) NULL,
	[exclusionDate] [text] NULL,
	[exclusionRule] [text] NULL,
	[recurrenceDate] [text] NULL,
	[recurrenceRule] [text] NULL,
 CONSTRAINT [PK_Schedule_1] PRIMARY KEY CLUSTERED 
(
	[scheduleID] ASC,
	[doctorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2013-10-14 2:36:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[staffID] [int] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[staffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Patient]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Schedule] FOREIGN KEY([scheduleID], [doctorID])
REFERENCES [dbo].[Schedule] ([scheduleID], [doctorID])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Schedule]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Employee] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Person] FOREIGN KEY([employeeID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Person]
GO
ALTER TABLE [dbo].[EMR]  WITH CHECK ADD  CONSTRAINT [FK_EMR_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[EMR] CHECK CONSTRAINT [FK_EMR_Patient]
GO
ALTER TABLE [dbo].[EMRDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_EMRDiagnosis_Diagnosis] FOREIGN KEY([diagnosisID])
REFERENCES [dbo].[Diagnosis] ([diagnosisID])
GO
ALTER TABLE [dbo].[EMRDiagnosis] CHECK CONSTRAINT [FK_EMRDiagnosis_Diagnosis]
GO
ALTER TABLE [dbo].[EMRDiagnosis]  WITH CHECK ADD  CONSTRAINT [FK_EMRDiagnosis_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRDiagnosis] CHECK CONSTRAINT [FK_EMRDiagnosis_EMR]
GO
ALTER TABLE [dbo].[EMRLaboratory]  WITH CHECK ADD  CONSTRAINT [FK_EMRLaboratory_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRLaboratory] CHECK CONSTRAINT [FK_EMRLaboratory_EMR]
GO
ALTER TABLE [dbo].[EMRLaboratory]  WITH CHECK ADD  CONSTRAINT [FK_EMRLaboratory_Laboratory] FOREIGN KEY([laboratoryID])
REFERENCES [dbo].[Laboratory] ([laboratoryID])
GO
ALTER TABLE [dbo].[EMRLaboratory] CHECK CONSTRAINT [FK_EMRLaboratory_Laboratory]
GO
ALTER TABLE [dbo].[EMRMedication]  WITH CHECK ADD  CONSTRAINT [FK_EMRMedication_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRMedication] CHECK CONSTRAINT [FK_EMRMedication_EMR]
GO
ALTER TABLE [dbo].[EMRMedication]  WITH CHECK ADD  CONSTRAINT [FK_EMRMedication_Medication] FOREIGN KEY([medicationID])
REFERENCES [dbo].[Medication] ([medicationID])
GO
ALTER TABLE [dbo].[EMRMedication] CHECK CONSTRAINT [FK_EMRMedication_Medication]
GO
ALTER TABLE [dbo].[EMRRadiology]  WITH CHECK ADD  CONSTRAINT [FK_EMRRadiology_EMR] FOREIGN KEY([patientID], [doctorID], [timestamp])
REFERENCES [dbo].[EMR] ([patientID], [doctorID], [timestamp])
GO
ALTER TABLE [dbo].[EMRRadiology] CHECK CONSTRAINT [FK_EMRRadiology_EMR]
GO
ALTER TABLE [dbo].[EMRRadiology]  WITH CHECK ADD  CONSTRAINT [FK_EMRRadiology_Radiology] FOREIGN KEY([radiologyID])
REFERENCES [dbo].[Radiology] ([radiologyID])
GO
ALTER TABLE [dbo].[EMRRadiology] CHECK CONSTRAINT [FK_EMRRadiology_Radiology]
GO
ALTER TABLE [dbo].[Manager]  WITH CHECK ADD  CONSTRAINT [FK_Manager_Employee] FOREIGN KEY([managerID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Manager] CHECK CONSTRAINT [FK_Manager_Employee]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Person] FOREIGN KEY([patientID])
REFERENCES [dbo].[Person] ([personID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Person]
GO
ALTER TABLE [dbo].[PatientAllergy]  WITH CHECK ADD  CONSTRAINT [FK_PatientAllergy_Allergy] FOREIGN KEY([allergyID])
REFERENCES [dbo].[Allergy] ([allergyID])
GO
ALTER TABLE [dbo].[PatientAllergy] CHECK CONSTRAINT [FK_PatientAllergy_Allergy]
GO
ALTER TABLE [dbo].[PatientAllergy]  WITH CHECK ADD  CONSTRAINT [FK_PatientAllergy_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientAllergy] CHECK CONSTRAINT [FK_PatientAllergy_Patient]
GO
ALTER TABLE [dbo].[PatientInsurance]  WITH CHECK ADD  CONSTRAINT [FK_PatientInsurance_Patient] FOREIGN KEY([patientID])
REFERENCES [dbo].[Patient] ([patientID])
GO
ALTER TABLE [dbo].[PatientInsurance] CHECK CONSTRAINT [FK_PatientInsurance_Patient]
GO
ALTER TABLE [dbo].[PersonAddress]  WITH CHECK ADD  CONSTRAINT [FK_PersonAddress_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PersonAddress] CHECK CONSTRAINT [FK_PersonAddress_Person]
GO
ALTER TABLE [dbo].[PersonEmail]  WITH CHECK ADD  CONSTRAINT [FK_PersonEmail_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[PersonEmail] CHECK CONSTRAINT [FK_PersonEmail_Person]
GO
ALTER TABLE [dbo].[PersonPhone]  WITH CHECK ADD  CONSTRAINT [FK_PersonPhone_Person] FOREIGN KEY([personID])
REFERENCES [dbo].[Person] ([personID])
GO
ALTER TABLE [dbo].[PersonPhone] CHECK CONSTRAINT [FK_PersonPhone_Person]
GO
ALTER TABLE [dbo].[Schedule]  WITH CHECK ADD  CONSTRAINT [FK_Schedule_Doctor] FOREIGN KEY([doctorID])
REFERENCES [dbo].[Doctor] ([doctorID])
GO
ALTER TABLE [dbo].[Schedule] CHECK CONSTRAINT [FK_Schedule_Doctor]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_Employee] FOREIGN KEY([staffID])
REFERENCES [dbo].[Employee] ([employeeID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_Employee]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PersonAddress'
GO
USE [master]
GO
ALTER DATABASE [Giberson] SET  READ_WRITE 
GO
