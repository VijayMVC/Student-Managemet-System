CREATE PROCEDURE usp_BranchesGetAllBranches
AS
	BEGIN
		SELECT [BranchId]
			  ,[BranchName]
			  ,[Email]
			  ,[Telephone]
			  ,[AddressLine]
		FROM [dbo].[Branches]
	END