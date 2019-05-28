CREATE PROCEDURE usp_StudentAddNewStudent
(
	@StudentId INT
   ,@StudentName NVARCHAR(50)			
   ,@FatherName NVARCHAR(50)
   ,@PhoneNumber NVARCHAR(50)
   ,@CityId INT
   ,@EmailAddress NVARCHAR(50)
   ,@DepartmentId INT
   ,@AddressLine NVARCHAR(50)
)
AS
	BEGIN
		INSERT INTO [dbo].[Student]
				   ([StudentId]
				   ,[StudentName]
				   ,[FatherName]
				   ,[PhoneNumber]
				   ,[CityId]
				   ,[EmailAddress]
				   ,[DepartmentId]
				   ,[AddressLine])
			 VALUES
				   (@StudentId
				   ,@StudentName
				   ,@FatherName
				   ,@PhoneNumber
				   ,@CityId
				   ,@EmailAddress
				   ,@DepartmentId
				   ,@AddressLine)
	END


GO


