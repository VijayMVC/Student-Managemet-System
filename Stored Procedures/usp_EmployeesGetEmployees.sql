CREATE PROCEDURE usp_EmployeesGetEmployees
AS
	BEGIN
		SELECT e.[EmployeeId]
			  ,e.[FullName]
			  ,CONVERT(varchar, e.[DateOfBirth], 103) AS 'DateOfBirth'
			  ,e.[CNICNumber]
			  ,e.[EmailAddress]
			  ,e.[Mobile]
			  ,e.[Telephone]
			  ,ISNULL(b.[BranchName], 'No Branch') AS 'BranchName'
		  FROM [dbo].[Employees] e
		  LEFT JOIN [dbo].[Branches] b
		  ON e.BranchId = b.BranchId
	END

GO

