USE [Giberson]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[EnterDiagnosis]
	@name varchar(20),
	@description varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT into Diagnosis(
	name,
	description) Values

	(@name,
	@description)
END
GO



USE [Giberson]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


Create PROCEDURE [dbo].[EnterMedication]
	@name varchar(20),
	@description varchar(20)
AS
BEGIN
	SET NOCOUNT ON;
	INSERT into Medication(
	name,
	description) Values

	(@name,
	@description)
END

GO


