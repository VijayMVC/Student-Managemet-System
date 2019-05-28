CREATE PROCEDURE usp_BranchesGetAllBrancheNames
AS
	BEGIN
		SELECT [BranchId] AS 'Id'
			  ,[BranchName] AS 'Description'
		FROM [dbo].[Branches]
	END


GO


