CREATE TRIGGER utr_EmployeesAuditEmployeesDetails
ON Employees
AFTER INSERT, UPDATE
AS
	BEGIN
		DECLARE @EmployeeId INT
		SELECT @EmployeeId = i.EmployeeId FROM inserted i

		INSERT INTO [dbo].[EmployeesAudit]
		SELECT * FROM [dbo].[Employees]
		WHERE [EmployeeId] = @EmployeeId
	END