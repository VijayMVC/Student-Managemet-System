CREATE PROCEDURE usp_EmployeesGenerateNewEmployeeId
AS
	BEGIN
		DECLARE @EmployeeId INT
		SELECT @EmployeeId = ISNULL(MAX(EmployeeId), 0) 
		FROM [dbo].[Employees]
		SET @EmployeeId = @EmployeeId + 1
		SELECT @EmployeeId
	END