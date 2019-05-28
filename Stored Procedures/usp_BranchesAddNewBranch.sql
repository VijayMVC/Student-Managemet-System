CREATE PROCEDURE usp_BranchesAddNewBranch
(
	@BranchName NVARCHAR(150)
   ,@Email NVARCHAR(50)
   ,@Telephone NVARCHAR(50)
   ,@Website NVARCHAR(50)
   ,@AddressLine NVARCHAR(50)
   ,@CityId INT
   ,@DistrictId INT
   ,@PostralCode INT
   ,@CreatedBy NVARCHAR(50)
   ,@BranchImage IMAGE
)
AS
	BEGIN

	INSERT INTO [dbo].[Branches]
			   ([BranchName]
			   ,[Email]
			   ,[Telephone]
			   ,[Website]
			   ,[AddressLine]
			   ,[CityId]
			   ,[DistrictId]
			   ,[PostralCode]
			   ,[CreatedBy]
			   ,[CreatedDate]
			   ,[BranchImage])
		 VALUES
			   (@BranchName
			   ,@Email
			   ,@Telephone
			   ,@Website
			   ,@AddressLine
			   ,@CityId
			   ,@DistrictId
			   ,@PostralCode
			   ,@CreatedBy
			   ,GETDATE()
			   ,@BranchImage)
	END
GO


