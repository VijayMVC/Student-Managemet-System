CREATE PROCEDURE usp_EmployeesUpdateEmployeeDetails
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
		UPDATE [dbo].[Employees]
		   SET [EmployeeId] = @EmployeeId
			  ,[FullName] = @FullName
			  ,[DateOfBirth] = @DateOfBirth
			  ,[CNICNumber] = @CNICNumber
			  ,[EmailAddress] = @EmailAddress
			  ,[Mobile] = @Mobile
			  ,[Telephone] = @Telephone
			  ,[GenderId] = @GenderId
			  ,[EmploymentDate] = @EmploymentDate
			  ,[BranchId] = @BranchId
			  ,[Photo] = @Photo
			  ,[AddressLine] = @AddressLine
			  ,[CityId] = @CityId
			  ,[DistrictId] = @DistrictId
			  ,[PostralCode] = @PostralCode
			  ,[JobTitleId] = @JobTitleId
			  ,[CurrentSalary] = @CurrentSalary
			  ,[StartingSalary] = @StartingSalary
			  ,[HasLeft] = @HasLeft
			  ,[DateLeft] = @DateLeft
			  ,[ReasonLeftId] = @ReasonLeftId
			  ,[Comments] = @Comments
			  ,[CreatedBy] = @CreatedBy
			  ,[CreatedDate] = GETDATE()
		 WHERE [EmployeeId] = @EmployeeId
	END


GO


