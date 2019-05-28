CREATE PROCEDURE usp_EmployeesGetEmployeeDetailsId
(
	@EmployeeId INT
)
AS
	BEGIN
		SELECT [EmployeeId]
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
		  FROM [dbo].[Employees]
		  WHERE [EmployeeId] = @EmployeeId
	END

GO


