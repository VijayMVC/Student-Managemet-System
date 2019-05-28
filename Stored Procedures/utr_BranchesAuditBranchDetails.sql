CREATE TRIGGER utr_BranchesAuditBranchDetails
ON [dbo].[Branches]
AFTER INSERT,UPDATE
AS
	BEGIN
		DECLARE @BranchId INT
		SELECT @BranchId = i.BranchId FROM inserted i

		INSERT INTO [dbo].[BranchesAudit]
		SELECT * FROM [dbo].[Branches]
		WHERE BranchId = @BranchId
	END