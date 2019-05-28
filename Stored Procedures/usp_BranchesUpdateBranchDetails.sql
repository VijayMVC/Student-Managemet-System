CREATE PROCEDURE usp_BranchesUpdateBranchDetails
(
	@BranchId INT,
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
		UPDATE [dbo].[Branches]
		   SET [BranchName] = @BranchName
			  ,[Email] = @Email
			  ,[Telephone] = @Telephone
			  ,[Website] = @Website
			  ,[AddressLine] = @AddressLine
			  ,[CityId] = @CityId
			  ,[DistrictId] = @DistrictId
			  ,[PostralCode] = @PostralCode
			  ,[CreatedBy] = @CreatedBy
			  ,[CreatedDate] = GETDATE()
			  ,[BranchImage] = @BranchImage
		 WHERE [BranchId] = @BranchId
	END
GO


