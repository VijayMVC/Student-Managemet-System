CREATE PROCEDURE usp_EmployeesAddNewEmployee
(
	 @EmployeeId INT
	,@FullName NVARCHAR(50)
	,@DateOfBirth DATETIME
	,@CNICNumber NVARCHAR(50)
	,@EmailAddress NVARCHAR(50)
	,@Mobile NVARCHAR(50)
	,@Telephone NVARCHAR(50)
	,@GenderId INT
	,@EmploymentDate DATETIME
	,@BranchId INT
	,@Photo IMAGE = NULL
	,@AddressLine NVARCHAR(50)
	,@CityId INT
	,@DistrictId INT
	,@PostralCode INT
	,@JobTitleId INT 
	,@CurrentSalary DECIMAL(18, 2)
	,@StartingSalary DECIMAL(18, 2)
	,@HasLeft BIT
	,@DateLeft DATETIME
	,@ReasonLeftId INT
	,@Comments NVARCHAR(MAX)
	,@CreatedBy NVARCHAR(50)
)
AS
	BEGIN
		INSERT INTO [dbo].[Employees]
				   ([EmployeeId]
				   ,[FullName]
				   ,[DateOfBirth]
				   ,[CNICNumber]
				   ,[EmailAddress]
				   ,[Mobile]
				   ,[Telephone]
				   ,[GenderId]
				   ,[EmploymentDate]
				   ,[BranchId]
				   ,[Photo]
				   ,[AddressLine]
				   ,[CityId]
				   ,[DistrictId]
				   ,[PostralCode]
				   ,[JobTitleId]
				   ,[CurrentSalary]
				   ,[StartingSalary]
				   ,[HasLeft]
				   ,[DateLeft]
				   ,[ReasonLeftId]
				   ,[Comments]
				   ,[CreatedBy]
				   ,[CreatedDate])
			 VALUES
				   (@EmployeeId
				   ,@FullName
				   ,@DateOfBirth
				   ,@CNICNumber
				   ,@EmailAddress
				   ,@Mobile
				   ,@Telephone
				   ,@GenderId
				   ,@EmploymentDate
				   ,@BranchId
				   ,@Photo
				   ,@AddressLine
				   ,@CityId
				   ,@DistrictId
				   ,@PostralCode
				   ,@JobTitleId
				   ,@CurrentSalary
				   ,@StartingSalary
				   ,@HasLeft
				   ,@DateLeft
				   ,@ReasonLeftId
				   ,@Comments
				   ,@CreatedBy
				   ,GETDATE())
	END

GO


