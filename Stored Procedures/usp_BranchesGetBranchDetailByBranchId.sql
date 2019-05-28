CREATE PROCEDURE usp_BranchesGetBranchDetailByBranchId
(
	@BranchId INT
)
AS
	BEGIN
		SELECT [BranchId]
			  ,[BranchName]
			  ,[Email]
			  ,[Telephone]
		      ,[Website]
			  ,[AddressLine]
			  ,[CityId]
			  ,[DistrictId]
              ,[PostralCode]
              ,[BranchImage]
		FROM [dbo].[Branches]
		WHERE [BranchId] = @BranchId
	END